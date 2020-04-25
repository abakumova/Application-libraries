<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainForm.aspx.cs" Inherits="IncreasingSequence.MainForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script> </script>

<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        Enter numbers using spaces
        <p>
            <asp:TextBox ID="TextBox1" runat="server" Width="753px"></asp:TextBox>
        </p>
        <asp:Button type="button" ID="Button2" runat="server" OnClick="Button2_Click" Text="Display sequence" />
        <p>
            <asp:TextBox ID="TextBox2" runat="server" Height="44px" ReadOnly="True" Width="759px"></asp:TextBox>
        </p>
        <asp:Label ID="Label1" runat="server" Text="Sum of elements"></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server" ReadOnly="True"></asp:TextBox>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Minimum"></asp:Label>
            <asp:TextBox ID="TextBox4" runat="server" ReadOnly="True"></asp:TextBox>
        </p>
    </form>
</body>
</html>