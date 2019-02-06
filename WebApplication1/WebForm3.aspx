<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="WebApplication1.WebForm3" %>

<!DOCTYPE html>
<%@ Import Namespace="System.IO" %>
<%@ Import Namespace="System.Net"%>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Resources/Style.css" rel="stylesheet" />
    <style>
        .sub-header {
            margin-top: 10px;
            margin-left: 60px;
            color: black;
            font-size: 20px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" style="height: auto; background-color: black;" >
        <div id="header">
            <a href="WebForm1.aspx">
                <span class="logo"><b><i>TR</i></b></span>
            </a>
        </div>
        <div id="container">
            <div id="box2" style="height: auto;">
                 <a href="WebForm2.aspx">
		            <img src="Resources/back.png" width="50" height="50"/>
	            </a>
                <span>Current Time:</span>
                <div id="currentSearchTime" runat="server" style="margin-top: 20px; margin-left: 80px;">
                </div>
                <p class="sub-header"><b>Train information:</b></p>
                <div id="scheduleTrain" runat="server" class="scheduleTrain" style="margin-left: 80px; margin-top: 20px">
                </div>
                <p class="sub-header"><b>Schedule information:</b></p>
                <asp:GridView ID="infomationTable" runat="server" AutoGenerateColumns="false" style="margin: 0px 30px 50px 80px;">
                    <Columns>
                        <asp:BoundField DataField="stationShortCode" HeaderText="StationCode"/>
                        <asp:BoundField DataField="scheduledDate" HeaderText="Date"/>
                        <asp:BoundField DataField="type" HeaderText="Running type"/>
                        <asp:BoundField DataField="scheduledTime" HeaderText="Schedule Time"/>
                        <asp:BoundField DataField="actualTime" HeaderText="Actual Time"/>
                        <asp:BoundField DataField="differenceInMinutes" HeaderText="Delay Time"/>
                    </Columns>
                </asp:GridView>
            </div>
        </div>
    </form>
</body>
</html>
