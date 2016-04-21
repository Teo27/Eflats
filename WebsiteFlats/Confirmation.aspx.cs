using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
//using System.Windows.Forms;

public partial class Confirmation : System.Web.UI.Page
{
    ServiceReference1.WcfEFlatsServiceClient client = new ServiceReference1.WcfEFlatsServiceClient();
    protected void Page_Load(object sender, EventArgs e)
    {

        string url = HttpContext.Current.Request.Url.Query;

        string output = url.Substring(url.IndexOf('?') + 1);

        if (client.Validate(output) == true)
        {
            LabelVerificationYes.Visible = true;
        }
        else
        {
            LabelVerificationNo.Visible = true;
        }

    }


   
}