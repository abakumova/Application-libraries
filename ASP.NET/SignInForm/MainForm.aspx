<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainForm.aspx.cs" Inherits="SignInForm.MainForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script runat="server">
        static string patternEmail = @"^(([^<>()[\]\\.,;:\s@\""]+(\.[^<>()[\]\\.,;:\s@\""]+)*)|(\"".+\""))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$";
        Regex regexEmail = new Regex(patternEmail);

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            int number;
            if (age.Text != "" && password.Text != "" && name.Text != "" && email.Text != "" && CheckBox1.Checked == true)
            {
                if (regexEmail.IsMatch(email.Text) && Int32.TryParse(age.Text, out number))
                {
                    Label5.Text = "Congratulations! Registration Complete";
                }
                else
                {
                    Label5.Text = "Provide valid email or age";
                }
            }
            else
            {
                Label5.Text = "Fields should be filled in";
            }
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>
                <asp:Label ID="Label3" runat="server" Text="Name: "></asp:Label>
            <asp:TextBox ID="name" runat="server"></asp:TextBox> 
            </div>

            <div>
                <asp:Label ID="Label4" runat="server" Text="Email: "></asp:Label>
            <asp:TextBox ID="email" runat="server"></asp:TextBox> 
            </div>

            <div>
                <asp:Label ID="Label1" runat="server" Text="Age: "></asp:Label>
            <asp:TextBox ID="age" runat="server"></asp:TextBox>
            </div>
            
            <div>
                <asp:Label ID="Label2" runat="server" Text="Password: "></asp:Label>
            <asp:TextBox ID="password" runat="server"></asp:TextBox> 
            </div>
      
            <div>
                <asp:CheckBox ID="CheckBox1" runat="server" OnCheckedChanged="CheckBox1_CheckedChanged" />
			<asp:Label ID="Label6" runat="server" Text="I agree"></asp:Label>
            </div>
            
            <div>
                <asp:Button ID="Button1" runat="server" Text="Send" onclick="Button1_Click" />
            </div>

            <div>
                <asp:Label ID="Label5" runat="server" Text=" "></asp:Label>
            </div>      
        </div>
    </form>
</body>
</html>