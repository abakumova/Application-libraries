using System;

namespace SimpleTest
{
    public partial class MainForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (DropDownList1.Text == "Sandwich")
            {
                r1.Text = "Correct";
            } else
            {
                r1.Text = "Incorrect";
            }
            if (DropDownList2.Text == "Program for interaction with the Internet through some ports")
            {
                r2.Text = "Correct";
            }
            else
            {
                r2.Text = "Incorrect";
            }
            if (DropDownList3.Text == "Turing test")
            {
                r3.Text = "Correct";
            } else
            {
                r3.Text = "Incorrect";
            }
                
        }
    }
}