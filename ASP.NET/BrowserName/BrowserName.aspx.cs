using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BrowserName
{
    public partial class BrowserName : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var userAgent = HttpContext.Current.Request.UserAgent;
            var userBrowser = new HttpBrowserCapabilities { Capabilities = new Hashtable { { string.Empty, userAgent } } };
            var factory = new BrowserCapabilitiesFactory();
            factory.ConfigureBrowserCapabilities(new NameValueCollection(), userBrowser);
            browser.Text = "Your browser is " + userBrowser.Browser.ToString();       
        }
    }
}