using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Offers : System.Web.UI.Page
{
    ServiceReference1.WcfEFlatsServiceClient client = new ServiceReference1.WcfEFlatsServiceClient();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["New"] != null)
        {
            if (!IsPostBack)
            {
                WelcomeLabel.Text += Session["Email"].ToString();           
                DataSet ds = client.GetConfirmedFlats(Session["Email"].ToString().Trim());
                GridViewAllFlats.DataSource = ds.Tables[0];                   
                GridViewAllFlats.DataBind();
            }            
        }
        else
        {
            WelcomeLabel.Visible = false;
            LogOut.Visible = false;
        }
    }

    protected void ButtonLogOut_Click(object sender, EventArgs e)
    {
        Session["New"] = null;
        Response.Redirect("Register.aspx");
    }

    protected void ButtonProfile_Click(object sender, EventArgs e)
    {
        Response.Redirect("EditProfileLandlord.aspx");
    }

    protected void ButtonFlats_Click(object sender, EventArgs e)
    {
        Response.Redirect("Flats.aspx");
    }

    protected void ButtonHome_Click(object sender, EventArgs e)
    {
        Response.Redirect("MainPageLandlord.aspx");
    }
}