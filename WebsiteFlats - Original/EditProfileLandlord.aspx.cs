using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Runtime.Serialization;

public partial class EditProfile : System.Web.UI.Page
{
    ServiceReference1.WcfEFlatsServiceClient client = new ServiceReference1.WcfEFlatsServiceClient();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["New"] != null)
        {
            if (!IsPostBack)
            {
                WelcomeLabel.Text += Session["Email"].ToString();

                TextBoxName.Text = Session["Name"].ToString().Trim();
                TextBoxAddress.Text = Session["Address"].ToString().Trim();
                TextBoxPostCode.Text = Session["PostCode"].ToString().Trim();
                TextBoxCity.Text = Session["City"].ToString().Trim();
                TextBoxCountry.Text = Session["Country"].ToString().Trim();
                TextBoxPhone.Text = Session["Phone"].ToString().Trim();
                TextBoxContactAndSurname.Text = Session["ContactPerson"].ToString().Trim();
            }
        }            
        else
        {
            Response.Redirect("Register.aspx");
        }
    }   

    protected void ButtonHome_Click(object sender, EventArgs e)
    {
        Response.Redirect("MainPageLandlord.aspx");
    }

    protected void ButtonProfile_Click(object sender, EventArgs e)
    {
        Response.Redirect("EditProfileLandlord.aspx");
    }

    protected void ButtonFlats_Click(object sender, EventArgs e)
    {
        Response.Redirect("Flats.aspx");
    }

    protected void ButtonEdit_Click(object sender, EventArgs e)
    {        
            ServiceReference1.MdlLandlord landlord = new ServiceReference1.MdlLandlord();
            landlord.Email = Session["Email"].ToString().Trim();
            landlord.Name = TextBoxName.Text;
            landlord.Contact_person = TextBoxContactAndSurname.Text;
            landlord.Address = TextBoxAddress.Text;
            landlord.PostCode = TextBoxPostCode.Text;
            landlord.City = TextBoxCity.Text;
            landlord.Country = TextBoxCountry.Text;
            landlord.Phone = TextBoxPhone.Text;

            client.EditLandlordProfile(landlord);

            Session["Name"] = TextBoxName.Text;
            Session["ContactPerson"] = TextBoxContactAndSurname.Text;
            Session["Address"] = TextBoxAddress.Text;
            Session["PostCode"] = TextBoxPostCode.Text;
            Session["City"] = TextBoxCity.Text;
            Session["Country"] = TextBoxCountry.Text;
            Session["Phone"] = TextBoxPhone.Text;

        if(client.EditLandlordProfile(landlord) == true)
        {
            LabelEditProfile.Text = "Profile was updated successfully";
        }
        else
        {
            LabelEditProfile.Text = "Profile update failed";
        }
       
    }

    protected void LogOut_Click(object sender, EventArgs e)
    {
        Session["New"] = null;
        Response.Redirect("Register.aspx");
    }
}