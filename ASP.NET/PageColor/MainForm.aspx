<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainForm.aspx.cs" Inherits="PageColor.MainForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style>
        body
        {
            background: result;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label3" runat="server" Text="Red"></asp:Label>
            <asp:TextBox ID="red" runat="server" Width="100px"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Label4" runat="server" Text="Green"></asp:Label>
            <asp:TextBox ID="green" runat="server" Width="100px"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Label5" runat="server" Text="Blue"></asp:Label>
            <asp:TextBox ID="blue" runat="server" Width="100px"></asp:TextBox>
        </div>
        <div>
            <asp:Button ID="Button1" runat="server" Text="Find out color" OnClick="Button1_Click" />
        </div>
        <asp:Label ID="Label1" runat="server"></asp:Label>
    </form>
</body>
</html>