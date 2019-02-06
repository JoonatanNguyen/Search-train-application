<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.Main_page" %>

<!DOCTYPE html>
<%@ Import Namespace="System.IO" %>
<%@ Import Namespace="System.Net"%>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Main Page</title>
    <link href="Resources/Style.css" rel="stylesheet" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" integrity="sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u" crossorigin="anonymous"/>
	<script src="https://code.jquery.com/jquery-1.10.2.js"></script>
	<script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js" integrity="sha384-Tc5IQib027qvyjSMfHjOMaLkfuWVxZxUPnCJA7l2mCWNIpG9mGCD8wGNIcPD7Txa" crossorigin="anonymous"></script>
    
</head>
<body style="background-color:rgb(230, 228, 228)">
    <div id="header">
        <a href="WebForm1.aspx">
            <span class="logo"><b><i>TR</i></b></span>
        </a>
    </div>
    
    <div id="container">
        <div id="box1">
            <form id="form1" runat="server" style="text-align: center;">
                <h2><b>SEARCH FOR YOUR TRAIN</b></h2>
                <div class="button">
                    <asp:Button ID="Button1" runat="server" Text="Long distance" class="submit" onClick="Button1_Click"/>
                    <asp:Button ID="Button2" runat="server" Text="Commuter" class="submit" onClick="Button2_Click"/>
                </div>
            </form>
        </div>
    </div>
</body>
</html>
