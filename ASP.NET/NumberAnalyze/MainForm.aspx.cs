using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AnalyzeNumber
{
    public partial class MainForm : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double num;

           if(Double.TryParse(number.Text,out num))
           {
                result.Text = "Entered value " + num;

                if (num % 2 == 0)
                {
                    result.Text += "\nEvenness of number: even";
                }
                else
                {
                    result.Text += "\nEvenness of number: odd";
                }

                if (num < 0)
                {
                    result.Text += "\nSign: - ";
                }
                if (num > 0)
                {
                    result.Text += "\nNumber symbol: + ";
                }

                result.Text += "\nNumber of digits: " + Math.Abs(num).ToString().Length;
            }
           else
           {
                result.Text = "\n It's not a number";
           }
        }
    }
}