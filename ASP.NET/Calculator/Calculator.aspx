<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calculator.aspx.cs" Inherits="Calculator.Calculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        #Select1 {
            width: 60px;
            height: 37px;
        }
        #operation {
            width: 65px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>Hello! This is a simple calculator. </p>
        </div>
        <p>Number 1</p>
        <p>
            <asp:TextBox ID="num1" runat="server"></asp:TextBox>
        </p>
        <p>
            &nbsp;<asp:DropDownList ID="sign" runat="server">
                <asp:ListItem Selected="True" Value="+"> + </asp:ListItem>
                  <asp:ListItem Value="-"> - </asp:ListItem>
                  <asp:ListItem Value="*"> * </asp:ListItem>
                  <asp:ListItem Value="/"> / </asp:ListItem>
            </asp:DropDownList>
        </p>
        <p> Number 2</p>
        <p>
            <asp:TextBox ID="num2" runat="server"></asp:TextBox>
        </p>
        <asp:Button ID="solve" runat="server" Height="53px" Text="=" Width="115px" OnClick="solve_Click" />
        <p><asp:TextBox ID="answer" runat="server" IsReadOnly="True" ReadOnly="True"  Width="300px"></asp:TextBox></p>
    </form>      
</body>
</html>