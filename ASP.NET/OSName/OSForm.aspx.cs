using System;
using System.Runtime;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OSName
{
    public partial class OSForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var osNameAndVersion = System.Runtime.InteropServices.RuntimeInformation.OSDescription;
            osname.Text = "Your OS is " + osNameAndVersion.ToString();
        }
    }
}