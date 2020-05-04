using System;
using System.Web.UI;

namespace Test
{
    public partial class WebForm1 : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Timer1.Enabled = true;
            Timer1.Interval = 1000;
            Timer1.Tick += new EventHandler<EventArgs>(Timer1_Tick);
        }

        void Timer1_Tick(object sender, EventArgs e)
        {
            int i = (Convert.ToInt16(Label6.Text));
            i = i + 1;
            Label6.Text = i.ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Timer1.Enabled = false;

            int result = 0;
            if (DropDownList1.Text == "Sandwich")
                result++;
            if (DropDownList2.Text == "Program for interaction with the Internet through some ports")
                result++;
            if (DropDownList3.Text == "Turing test")
                result++;
            switch (result)
            {
                case 0:
                    Label5.Text = "Bad";
                    break;
                case 1:
                    Label5.Text = "Normal";
                    break;
                case 2:
                    Label5.Text = "Good";
                    break;
                case 3:
                    Label5.Text = "Excellent";
                    break;
            }
        }
    }
}