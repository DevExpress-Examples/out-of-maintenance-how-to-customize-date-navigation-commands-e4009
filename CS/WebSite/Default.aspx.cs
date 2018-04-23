using System;
using DevExpress.Web.ASPxScheduler;
using DevExpress.Web.ASPxScheduler.Internal;

public partial class _Default : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) {

    }

    protected void ASPxScheduler1_BeforeExecuteCallbackCommand(object sender, DevExpress.Web.ASPxScheduler.SchedulerCallbackCommandEventArgs e) {
        if (e.CommandId == SchedulerCallbackCommandId.NavigateForward) {
            e.Command = new CustomNavigateForwardCallbackCommand((ASPxScheduler)sender);
        }
        else if (e.CommandId == SchedulerCallbackCommandId.NavigateBackward) {
            e.Command = new CustomNavigateBackwardCallbackCommand((ASPxScheduler)sender);
        }
    }
}

public class CustomNavigateForwardCallbackCommand : NavigateForwardCallbackCommand {
    public CustomNavigateForwardCallbackCommand(ASPxScheduler control)
        : base(control) {
    }
    
    protected override void ExecuteCore() {
        this.Control.Start = this.Control.TimelineView.GetBaseTimeScale().GetPrevDate(this.Control.TimelineView.GetVisibleIntervals().End);
    }
}

public class CustomNavigateBackwardCallbackCommand : NavigateBackwardCallbackCommand {
    public CustomNavigateBackwardCallbackCommand(ASPxScheduler control)
        : base(control) {

    }

    protected override void ExecuteCore() {
        TimeSpan duration = this.Control.ActiveView.GetVisibleIntervals().Duration;
        this.Control.Start = this.Control.TimelineView.GetBaseTimeScale().GetNextDate(this.Control.ActiveView.GetVisibleIntervals().Start.Subtract(duration));
    }
}