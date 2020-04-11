<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainForm.aspx.cs" Inherits="AnalyzeNumber.MainForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Enter a number"></asp:Label>
            <asp:TextBox ID="number" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Button ID="Button1" runat="server" Text="Analyze" OnClick="Button1_Click" />
        </div>
        <asp:TextBox ID="result" runat="server" ReadOnly="True" Height="222px" Width="347px" TextMode="MultiLine"></asp:TextBox>
    </form>
</body>
</html>
