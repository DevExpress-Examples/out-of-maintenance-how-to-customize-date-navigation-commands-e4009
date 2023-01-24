<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register Assembly="DevExpress.Web.ASPxScheduler.v14.1, Version=14.1.15.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxScheduler" TagPrefix="dxwschs" %>
<%@ Register Assembly="DevExpress.XtraScheduler.v14.1.Core, Version=14.1.15.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.XtraScheduler" TagPrefix="dx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <dxwschs:ASPxScheduler ID="ASPxScheduler1" runat="server" ActiveViewType="Timeline" 
            onbeforeexecutecallbackcommand="ASPxScheduler1_BeforeExecuteCallbackCommand">
            <Views>
                <TimelineView IntervalCount="7">
                    <Scales>
                        <dx:TimeScaleYear Enabled="False" />
                        <dx:TimeScaleQuarter Enabled="False" />
                        <dx:TimeScaleMonth Enabled="False" />
                        <dx:TimeScaleWeek Enabled="False" />
                        <dx:TimeScaleDay />
                        <dx:TimeScaleHour Enabled="False" />
                        <dx:TimeScaleFixedInterval Enabled="False" />
                    </Scales>
                </TimelineView>
            </Views>
        </dxwschs:ASPxScheduler>
        
    </div>
    </form>
</body>
</html>
