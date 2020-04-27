using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PageColor
{
    public partial class MainForm : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (!Int32.TryParse(red.Text, out var a) ||
                !Int32.TryParse(green.Text, out var b) ||
                !Int32.TryParse(blue.Text, out var c))
            {
                Label1.Text = "Enter number";
                return;
            }

            if (a < 0 || a > 255 ||
                b < 0 || b > 255 ||
                c < 0 || c > 255)
            {
                Label1.Text = "Enter number  0 - 255";
                return;
            }

            Page.Header.StyleSheet.CreateStyleRule(new Style
            {
                BackColor = Color.FromArgb(a, b, c),
                ForeColor = Color.LightCyan
            }, this, "body");
        }
    }
}