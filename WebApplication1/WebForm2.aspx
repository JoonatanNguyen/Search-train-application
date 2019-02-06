<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication1.train_list" %>

<!DOCTYPE html>
<%@ Import Namespace="System.IO" %>
<%@ Import Namespace="System.Net"%>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Train list</title>
    <link href="Resources/Style.css" rel="stylesheet" />
	<meta name="viewport" content="width=device-width, initial-scale=1.0"/>
	<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" integrity="sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u" crossorigin="anonymous"/>
	<script src="https://code.jquery.com/jquery-1.10.2.js"></script>
	<script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js" integrity="sha384-Tc5IQib027qvyjSMfHjOMaLkfuWVxZxUPnCJA7l2mCWNIpG9mGCD8wGNIcPD7Txa" crossorigin="anonymous"></script>
    <style>
        .ddl {
            margin-left: 20px;
           
        }
        .scheduleTrain {
            margin-left: 250px;
            margin-top: -20px;
            
        }
    </style>
</head>
<body style="background-color:rgb(230, 228, 228)">
    <form id="form1" runat="server" style="height: auto;">
        <div id="header">
		    <a href="WebForm1.aspx">
			    <span class="logo"><b><i>TR</i></b></span>	
		    </a>
        </div>
        <div id="container">
 	        <div id="box1">
	            <a href="WebForm1.aspx">
		            <img src="Resources/back.png" width="50" height="50"/>
	            </a>
                <br/>   
            <!--  train lisi display as scroll-->
                <div style="margin-top: 10px;">
 		            <!--first possible choice-->
                    <span style="margin-left: 80px; font-size: 16px; font-weight: bold;">Train Number: </span>
                    <asp:dropdownlist
                        id="numberList"
                        runat="server"
                        OnSelectedIndexChanged="numberList_SelectedIndexChanged"
                        AutoPostBack="true"
                        CssClass="ddl"
                   >
                    </asp:dropdownlist>
	            </div>
                 <div id="scheduleTrain" runat="server" class="scheduleTrain">
                    
                 </div>
            </div>
        </div>
    </form>
</body>
</html>

