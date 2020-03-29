<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Log in.aspx.cs" Inherits="LogIn.Log_in" %>

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
        Hello. It is a simple log in form<p>
            Name (max 10)</p>
        <asp:TextBox ID="name" runat="server" Width="201px"></asp:TextBox>
        <p>
            E-mail</p>
        <asp:TextBox ID="email" runat="server" Width="202px"></asp:TextBox>
        <p>
            <asp:Button ID="login" runat="server" Height="59px" OnClick="Button1_Click" Text="Log in" Width="143px" />
        </p>
        <asp:TextBox ID="result" runat="server" Height="44px" ReadOnly="True" Width="397px"></asp:TextBox>
    </form>
</body>
</html>