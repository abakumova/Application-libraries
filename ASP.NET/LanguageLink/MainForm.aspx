<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainForm.aspx.cs" Inherits="LanguageLink.MainForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:TextBox ID="page" runat="server" Height="46px" ReadOnly="True" Width="688px"></asp:TextBox>
        <p>
            <asp:TextBox ID="lang" runat="server" Height="49px" ReadOnly="True" Width="688px"></asp:TextBox>
        </p>
    </form>
</body>
</html>
