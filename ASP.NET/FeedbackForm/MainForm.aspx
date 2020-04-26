<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainForm.aspx.cs" Inherits="FeedbackForm.MainForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            <asp:Label ID="Label1" runat="server" Text="Email"></asp:Label>
            <asp:TextBox ID="email" runat="server" Height="24px" Width="216px"></asp:TextBox>
        </p>
        <div>
        </div>
        Subject<asp:TextBox ID="subject" runat="server" Width="185px"></asp:TextBox>
        <div>
            <p>
            <asp:Label ID="Label2" runat="server" Text="Message"></asp:Label>
            <asp:TextBox ID="message" runat="server" Height="68px" Width="243px"></asp:TextBox>
            </p>
        </div>
        <p>
            <asp:Button ID="send" runat="server" Height="43px" OnClick="send_Click" Text="Send letter" Width="167px" />
        </p>
        
        <asp:Label ID="valid" runat="server"></asp:Label>  
    </form>
</body>
</html>