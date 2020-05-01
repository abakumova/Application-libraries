<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainForm.aspx.cs" Inherits="Chart.MainForm" %>

<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>

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
        <asp:Table ID="Table1" runat="server" Height="34px" Width="172px" OnDataBinding="Table1_DataBinding">
            <asp:TableHeaderRow runat="server" ForeColor="Snow" BackColor="OliveDrab" Font-Bold="true">
                <asp:TableHeaderCell>X</asp:TableHeaderCell>
                <asp:TableHeaderCell>Y</asp:TableHeaderCell>
            </asp:TableHeaderRow>
            <asp:TableRow ID="TableRow1" runat="server">
                <asp:TableCell><asp:TextBox ID="x1" runat="server"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="y1" runat="server"></asp:TextBox></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow ID="TableRow2" runat="server">
                <asp:TableCell><asp:TextBox ID="x2" runat="server"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="y2" runat="server"></asp:TextBox></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow ID="TableRow3" runat="server">
                <asp:TableCell><asp:TextBox ID="x3" runat="server"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="y3" runat="server"></asp:TextBox></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow ID="TableRow4" runat="server">
                <asp:TableCell><asp:TextBox ID="x4" runat="server"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="y4" runat="server"></asp:TextBox></asp:TableCell>
            </asp:TableRow>
            <asp:TableRow ID="TableRow5" runat="server">
                <asp:TableCell><asp:TextBox ID="x5" runat="server"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="y5" runat="server"></asp:TextBox></asp:TableCell>
            </asp:TableRow>
        </asp:Table>
        <div>
                    <asp:Button ID="Button1" runat="server" Text="Build" OnClick="Button1_Click" />
        </div>
        <asp:Chart ID="Chart1" runat="server" Palette="Berry">
            <series>
                <asp:Series Name="Series1" ChartType="Spline">
                </asp:Series>
            </series>
            <chartareas>
                <asp:ChartArea Name="ChartArea1">
                </asp:ChartArea>
            </chartareas>
        </asp:Chart>
    </form>
</body>
</html>