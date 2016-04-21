using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Flats : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(Session["New"]!=null)
        {
            if (Session["Type"].ToString() == "Landlord")
            {
                if (!IsPostBack)
                {
                    WelcomeLabel.Text += Session["Email"].ToString();
                }
            }
            else if (Session["Type"].ToString() == "Student")
            {
                Response.Redirect("Register.aspx");
            }
        }
        else
        {
            Response.Redirect("Register.aspx");
        }

    }

    protected void LogOut_Click(object sender, EventArgs e)
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

    protected void ButtonAdd_Click(object sender, EventArgs e)
    {
        Response.Redirect("FlatsAdd.aspx");
    }

    protected void ButtonUpdate_Click(object sender, EventArgs e)
    {
        Response.Redirect("FlatsUpdate.aspx");
    }

    protected void ButtonOffers_Click(object sender, EventArgs e)
    {
        Response.Redirect("Offers.aspx");
    }
}