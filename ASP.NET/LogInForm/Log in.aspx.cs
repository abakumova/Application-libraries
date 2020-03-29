using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LogIn
{
    public partial class Log_in : Page
    {
        static string patternName = @"\D{1,10}";
        Regex regexName = new Regex(patternName);

        
        static string patternEmail = @"^(([^<>()[\]\\.,;:\s@\""]+(\.[^<>()[\]\\.,;:\s@\""]+)*)|(\"".+\""))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$";
        Regex regexEmail = new Regex(patternEmail);

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (regexName.IsMatch(name.Text) && regexEmail.IsMatch(email.Text))
            {
                result.Text = "You have successfully loged in";
            }
            else
            {
                result.Text = "Entered data had a mistake. Please re-fill out the form";
            }
        }
    }
}