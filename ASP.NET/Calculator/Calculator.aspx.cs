using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Calculator
{
    public partial class Calculator : Page
    {
        double number1, number2;
        string operat = null;

        static string pattern = @"^\D|\D$|.\D.";
        static string patterncomma = @"[.,]";
        Regex regex = new Regex(pattern);
        Regex regexcomma = new Regex(patterncomma);

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        
        protected void solve_Click(object sender, EventArgs e)
        {
            if (!regex.IsMatch(num1.Text) || regexcomma.IsMatch(num1.Text))
            {
                Double.TryParse(num1.Text, out number1);
                
            } else
            {
                answer.Text = "Error. Entered number had a mistake";
                return;
            }

            if (!regex.IsMatch(num2.Text) || regexcomma.IsMatch(num2.Text))
            {
                Double.TryParse(num2.Text, out number2);
            }
            else
            {
                answer.Text = "Error. Entered number had a mistake";
                return;
            }

            operat = sign.SelectedItem.Value;

            switch (operat)
            {
                case "+":
                    answer.Text = (number1 + number2).ToString();
                    break;
                case "-":
                    answer.Text = (number1 - number2).ToString();
                    break;
                case "*":
                    answer.Text = (number1 * number2).ToString();
                    break;
                case "/":
                    answer.Text = (number1 / number2).ToString();
                    break;
            }
        }
    }
}