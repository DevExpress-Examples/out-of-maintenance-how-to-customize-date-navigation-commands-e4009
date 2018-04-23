Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Web.ASPxScheduler
Imports DevExpress.Web.ASPxScheduler.Internal

Partial Public Class _Default
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)

	End Sub

	Protected Sub ASPxScheduler1_BeforeExecuteCallbackCommand(ByVal sender As Object, ByVal e As DevExpress.Web.ASPxScheduler.SchedulerCallbackCommandEventArgs)
		If e.CommandId = SchedulerCallbackCommandId.NavigateForward Then
			e.Command = New CustomNavigateForwardCallbackCommand(CType(sender, ASPxScheduler))
		ElseIf e.CommandId = SchedulerCallbackCommandId.NavigateBackward Then
			e.Command = New CustomNavigateBackwardCallbackCommand(CType(sender, ASPxScheduler))
		End If
	End Sub
End Class

Public Class CustomNavigateForwardCallbackCommand
	Inherits NavigateForwardCallbackCommand
	Public Sub New(ByVal control As ASPxScheduler)
		MyBase.New(control)

	End Sub

	Protected Overrides Sub ExecuteCore()
		Me.Control.Start = Me.Control.TimelineView.GetBaseTimeScale().GetPrevDate(Me.Control.TimelineView.GetVisibleIntervals().End)
	End Sub
End Class

Public Class CustomNavigateBackwardCallbackCommand
	Inherits NavigateBackwardCallbackCommand
	Public Sub New(ByVal control As ASPxScheduler)
		MyBase.New(control)

	End Sub

	Protected Overrides Sub ExecuteCore()
		Dim duration As TimeSpan = Me.Control.ActiveView.GetVisibleIntervals().Duration
		Me.Control.Start = Me.Control.TimelineView.GetBaseTimeScale().GetNextDate(Me.Control.ActiveView.GetVisibleIntervals().Start.Subtract(duration))
	End Sub
End Class