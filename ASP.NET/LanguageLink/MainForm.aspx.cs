using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LanguageLink
{
    public partial class MainForm : Page 
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String s = CultureInfo.CurrentCulture.Name;

            if (HttpContext.Current.Request.UrlReferrer == null )
            {
                if (s.Equals("ru-RU"))
                {
                    page.Text = "Вы не посещали страницы";
                    lang.Text = s;
                }
                if (s.Equals("en-EN"))
                {
                    page.Text = "You haven't visited pages yet";
                    lang.Text = s;
                }
            }
            else
            {
                page.Text = ConvertTextUrlToLink(Page.PreviousPage.ToString());
            }
            
        }
        private string ConvertTextUrlToLink(string url)
        {
            string regex = @"((www\.|(http|https|ftp|news|file)+\:\/\/)[_.a-z0-9-]+\.[a-z0-9\/_:@=.+?,##%&~-]*[^.|\'|\# |!|\(|?|,| |>|<|;|\)])";
            Regex r = new Regex(regex, RegexOptions.IgnoreCase);
            return r.Replace(url, "a href=\"$1\" title=\"Click here to open in a new window or tab\"target =\"_blank\">$1</a>").Replace("href=\"www", "href=\"http://www");
        }
    }
}