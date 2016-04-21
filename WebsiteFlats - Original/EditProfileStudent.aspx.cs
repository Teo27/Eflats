using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Runtime.Serialization;

public partial class EditProfileStudent : System.Web.UI.Page
{
    ServiceReference1.WcfEFlatsServiceClient client = new ServiceReference1.WcfEFlatsServiceClient();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["New"] != null)
        {
            if (!IsPostBack)
            {
                WelcomeLabel.Text += Session["Email"].ToString().Trim();

                TextBoxName.Text = Session["Name"].ToString().Trim();
                TextBoxAddress.Text = Session["Address"].ToString().Trim();
                TextBoxPostCode.Text = Session["PostCode"].ToString().Trim();
                TextBoxCity.Text = Session["City"].ToString().Trim();
                TextBoxCountry.Text = Session["Country"].ToString().Trim();
                TextBoxPhone.Text = Session["Phone"].ToString().Trim();
                TextBoxContactAndSurname.Text = Session["Surname"].ToString().Trim();
                TextBoxChildren.Text = Session["Number_of_children"].ToString().Trim();
                TextBoxCohabitors.Text = Session["NumberOfCohabiters"].ToString().Trim();
                if (Convert.ToBoolean(Session["Pet"]) == true)
                {
                    CheckBoxPets.Checked = true;
                }
                if (Convert.ToBoolean(Session["Disabled"]) == true)
                {
                    CheckBoxDisability.Checked = true;
                }
            }
        }            
        else
        {
            Response.Redirect("MainPageStudent.aspx");
        }


    }

    protected void ButtonWishList_Click(object sender, EventArgs e)
    {
        Response.Redirect("WishList.aspx");
    }

    protected void ButtonProfile_Click(object sender, EventArgs e)
    {
        Response.Redirect("EditProfileStudent.aspx");
    }

    protected void ButtonHome_Click(object sender, EventArgs e)
    {
        Response.Redirect("MainPageStudent.aspx");
    }

    protected void ButtonEdit_Click(object sender, EventArgs e)
    {
            bool pet = false;
            bool disabled = false;
            string email = Session["Email"].ToString().Trim();
            string name = TextBoxName.Text;
            string surname = TextBoxContactAndSurname.Text;
            string address = TextBoxAddress.Text;
            string postCode = TextBoxPostCode.Text;
            string city = TextBoxCity.Text;
            string country = TextBoxCountry.Text;
            string phone = TextBoxPhone.Text;
            int number_of_children = Convert.ToInt32(TextBoxChildren.Text);
            int number_of_cohabiters = Convert.ToInt32(TextBoxCohabitors.Text);

            if (CheckBoxPets.Checked == true)
                pet = true;
            
            if (CheckBoxDisability.Checked == true)
            disabled = true;

            client.EditStudentProfile(email, number_of_children, pet, number_of_cohabiters, disabled, name, surname, address, postCode, city, country, phone);

            Session["Number_of_children"] = Convert.ToInt32(TextBoxChildren.Text);
            Session["Pet"] = pet;
            Session["NumberOfCohabiters"] = Convert.ToInt32(TextBoxCohabitors.Text);
            Session["Disabled"] = disabled;
            Session["Name"] = TextBoxName.Text;
            Session["Surname"] = TextBoxContactAndSurname.Text;
            Session["Address"] = TextBoxAddress.Text;
            Session["PostCode"] = TextBoxPostCode.Text;
            Session["City"] = TextBoxCity.Text;
            Session["Country"] = TextBoxCountry.Text;
            Session["Phone"] = TextBoxPhone.Text;

        if (client.EditStudentProfile(email, number_of_children, pet, number_of_cohabiters, disabled, name, surname, address, postCode, city, country, phone) == true)
        {
            LabelProfileEdit.Text = "Profile was updated successfully";
        }
        else
        {
            LabelProfileEdit.Text = "Profile update failed";
        }

    }

    protected void LogOut_Click(object sender, EventArgs e)
    {

        Session["New"] = null;
        Response.Redirect("Register.aspx");
    }


}