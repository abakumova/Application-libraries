using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IncreasingSequence
{
    public partial class MainForm : Page
    {
        List<double> sequence = new List<double>();

        protected void Page_Load(object sender, EventArgs e)
        {
               
        }
 
        protected void Button2_Click(object sender, EventArgs e)
        {
            double k;
            string[] numbers = TextBox1.Text.Split(' ');
            foreach (var item in numbers)
            {
                if (double.TryParse(item, out k))
                {
                    sequence.Add(k);
                }
            }
            TextBox1.Text = "";
            sequence.Sort();
            sequence.Reverse();
            string value = "";
            foreach (var i in sequence)
            {
                value += (i + " ");
            }
            TextBox2.Text = value;
        }
    }
}