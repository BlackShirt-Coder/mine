<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 39px;
            width: 1329px;
        }
    </style>
</head>
<body style="height: 48px; width: 1693px">
    <form id="form1" runat="server">
    <div>
    <h1 style="height: 35px; width: 1326px">Hello</h1>
    </div>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <asp:Button ID="Button1" runat="server" Height="29px" OnClick="Button1_Click" style="margin-left: 17px; margin-right: 0px; margin-top: 33px; margin-bottom: 0px" Text="Button" Width="55px" />
        <br />
        <br />
        Good Morning<br />
        <br />
    </form>
  
</body>
</html>
