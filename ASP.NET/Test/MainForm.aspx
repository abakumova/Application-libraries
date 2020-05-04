<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainForm.aspx.cs" Inherits="Test.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                <asp:Timer ID="Timer1" runat="server">
                </asp:Timer>
                <asp:ScriptManager ID="ScriptManager1" runat="server">
                </asp:ScriptManager>
                <asp:Label ID="Label6" runat="server" Text="1"></asp:Label>
                <asp:Label ID="Label7" runat="server" Text=" Sec"></asp:Label>
                </ContentTemplate>
            </asp:UpdatePanel>
            <asp:Label ID="Label2" runat="server" Text="Which of the above is not a sorting method?"></asp:Label>
     <asp:DropDownList ID="DropDownList1" runat="server">
         <asp:ListItem>Comb</asp:ListItem>
         <asp:ListItem>Sandwich</asp:ListItem>
         <asp:ListItem>Bubble</asp:ListItem>
         <asp:ListItem>Radix</asp:ListItem> 
        </asp:DropDownList>
        <p>
     <asp:Label ID="Label3" runat="server" Text="What is a firewall?"></asp:Label>
    <asp:DropDownList ID="DropDownList2" runat="server">
         <asp:ListItem>Burn to disk program</asp:ListItem>
         <asp:ListItem>Same thing as the antivirus</asp:ListItem>
         <asp:ListItem>Program for interaction with the Internet through some ports</asp:ListItem>
         <asp:ListItem>Program that evaluates the level of security of the system</asp:ListItem> 
         </asp:DropDownList> 
         <p>
      <asp:Label ID="Label4" runat="server" Text="Artificial Intelligence Test"></asp:Label>
      <asp:DropDownList ID="DropDownList3" runat="server">
         <asp:ListItem>Winner Test</asp:ListItem>
         <asp:ListItem>Turing test</asp:ListItem>
         <asp:ListItem>Neumann test</asp:ListItem>
         <asp:ListItem>Xenera Test</asp:ListItem> 
        </asp:DropDownList>  <p>
    <asp:Button ID="Button1" runat="server" Text="Check" onclick="Button1_Click" /><p> 
     <asp:Label ID="Label5" runat="server" Text=" "></asp:Label>  
        </div>
    </form>
</body>
</html>