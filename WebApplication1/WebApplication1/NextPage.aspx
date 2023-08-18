<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NextPage.aspx.cs" Inherits="WebApplication1.NextPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 93px;
            width: 1442px;
        }
    </style>
</head>
<body style="height: 173px">
    <form id="form1" runat="server">
    <div>
    
    </div>
        Enter Your Name:&nbsp;
        <br />
        <br />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="Submit" />
        <br />
        <br />
        <p>
            <asp:Label ID="Label1" runat="server"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="OK" ForeColor="Red" OnClientClick="javascript:alert('Welcome to My Page')" />
        </p>
    </form>
</body>
</html>
