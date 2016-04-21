using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Runtime.Serialization;
using System.Windows.Forms;

public partial class Register : System.Web.UI.Page
{
    ServiceReference1.WcfEFlatsServiceClient client = new ServiceReference1.WcfEFlatsServiceClient();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["New"] != null)
        {

            if (Session["Type"].ToString() == "Landlord")
            {
                Response.Redirect("MainPageLandlord.aspx");
            }
            else if (Session["Type"].ToString() == "Student")
            {
                Response.Redirect("MainPageStudent.aspx");
            }
        }
    }


    protected void ButtonRegister_Click(object sender, EventArgs e)
    {
        if (IsPostBack)
        {
            try
            {
                if (DropDownListType.SelectedValue == "Landlord")
                {                    
                    ServiceReference1.MdlLandlord landlord = new ServiceReference1.MdlLandlord();
                    landlord.Address = TextBoxAddress.Text;
                    landlord.City = TextBoxCity.Text;
                    landlord.Contact_person = TextBoxSurnameAndContact.Text;
                    landlord.Country = TextBoxCountry.Text;
                    landlord.Email = TextBoxEmail.Text;
                    landlord.Name = TextBoxName.Text;
                    landlord.Password = TextBoxPassword.Text;
                    landlord.Phone = TextBoxPhone.Text;
                    landlord.PostCode = TextBoxPostCode.Text;
                    
                    if (client.AddLandlord(landlord).Trim().Equals("Registration successful."))
                    {
                        LabelRegistration.Text = "Registration successful.";

                        ClearFields();
                    }
                    else if (client.AddLandlord(landlord).Trim().Equals("Registration has failed due to the existing Email."))
                    {      
                        LabelRegistration.Text = "Registration has failed due to the existing Email.";
                    }
                    else
                    {
                        LabelRegistration.Text = "Unable to connect to database.";
                    }
                }

                else if (DropDownListType.SelectedValue == "Student")
                {
                    ServiceReference1.WcfEFlatsServiceClient client = new ServiceReference1.WcfEFlatsServiceClient();
                    ServiceReference1.MdlStudent student = new ServiceReference1.MdlStudent();

                    student.Address = TextBoxAddress.Text;
                    student.City = TextBoxCity.Text;
                    student.Surname = TextBoxSurnameAndContact.Text;
                    student.Country = TextBoxCountry.Text;
                    student.Email = TextBoxEmail.Text;
                    student.Name = TextBoxName.Text;
                    student.Password = TextBoxPassword.Text;
                    student.Phone = TextBoxPhone.Text;
                    student.PostCode = TextBoxPostCode.Text;

                  

                    if (client.AddStudent(student).Trim().Equals("Registration successful."))
                    {
                        LabelRegistration.Text = "Registration successful.";
                        ClearFields();
                    }
                    else if (client.AddStudent(student).Trim().Equals("Registration has failed due to the existing Email."))
                    {
                        LabelRegistration.Text = "Registration has failed due to the existing Email.";
                    }
                    else
                    {
                        LabelRegistration.Text = "Unable to connect to the database";
                    }
                }
            }
            catch 
            {
                Response.Redirect("ErrorPage.aspx");
            }
        }
    }

    protected void ButtonLogin_Click(object sender, EventArgs e)
    {
        client.Login(TextBoxEmailLogin.Text, TextBoxPasswordLogin.Text);
        Response.Write(client.Login(TextBoxEmailLogin.Text, TextBoxPasswordLogin.Text));

        if (client.Login(TextBoxEmailLogin.Text, TextBoxPasswordLogin.Text).Trim().Equals("You have successfully logged in."))
        {
            Session["New"] = TextBoxEmailLogin.Text;

            if (client.GetUserType(TextBoxEmailLogin.Text).Trim().Equals("Student"))
            {
                ServiceReference1.MdlStudent student = (ServiceReference1.MdlStudent)client.GetStudentData(TextBoxEmailLogin.Text);
                storeStudentObjToSession(student);
                Response.Redirect("MainPageStudent.aspx");
            }
            else
            {
                ServiceReference1.MdlLandlord landlord = (ServiceReference1.MdlLandlord)client.GetLandlordData(TextBoxEmailLogin.Text);
                storeLandlordObjToSession(landlord);
                Response.Redirect("MainPageLandlord.aspx");
            }

        }
        else
        {
            LabelNotCorrect.Visible = true;
        }
    }

    private void storeStudentObjToSession(ServiceReference1.MdlStudent student)
    {
        Session["Email"] = student.Email.ToString();
        Session["Confirmed"] = Convert.ToBoolean(student.Confirmed);
        Session["Student"] = Convert.ToBoolean(student.Student);
        Session["Score"] = Convert.ToInt32(student.Score);
        Session["Number_of_children"] = Convert.ToInt32(student.Number_of_children);
        Session["Pet"] = Convert.ToBoolean(student.Pet);
        Session["NumberOfCohabiters"] = Convert.ToInt32(student.Number_of_cohabiters);
        Session["Disabled"] = Convert.ToBoolean(student.Disabled);
        Session["DateOfCreation"] = Convert.ToDateTime(student.Date_of_creation);
        Session["Name"] = student.Name.ToString();
        Session["Surname"] = student.Surname.ToString();
        Session["Address"] = student.Address.ToString();
        Session["PostCode"] = student.PostCode.ToString();
        Session["City"] = student.City.ToString();
        Session["Country"] = student.Country.ToString();
        Session["Phone"] = student.Phone.ToString();
        Session["Type"] = "Student";       
    }

    private void storeLandlordObjToSession(ServiceReference1.MdlLandlord landlord)
    {
        Session["Email"] = landlord.Email.ToString();
        
        Session["Confirmed"] = Convert.ToBoolean(landlord.Confirmed);
        Session["DateOfCreation"] = Convert.ToDateTime(landlord.Date_of_creation);
        Session["Name"] = landlord.Name.ToString();
        Session["ContactPerson"] = landlord.Contact_person.ToString();
        Session["Address"] = landlord.Address.ToString();
        Session["PostCode"] = landlord.PostCode.ToString();
        Session["City"] = landlord.City.ToString();
        Session["Country"] = landlord.Country.ToString();
        Session["Phone"] = landlord.Phone.ToString();
        Session["Type"] = "Landlord";
    }

    protected void DropDownListType_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (DropDownListType.SelectedValue.ToString() == "Landlord" )
        {
            LabelContactPerson.Visible = true;
            LabelSurname.Visible = false;
        }
        else if (DropDownListType.SelectedValue.ToString() == "Student")
        {
            LabelContactPerson.Visible = false;
            LabelSurname.Visible = true;
        }
    }

    protected void ButtonClear_Click(object sender, EventArgs e)
    {
        ClearFields();
    }

    private void ClearFields()
    {
        TextBoxEmail.Text = "";
        TextBoxAddress.Text = "";
        TextBoxCity.Text = "";
        TextBoxCountry.Text = "";
        TextBoxName.Text = "";
        TextBoxPassword.Text = "";
        TextBoxPhone.Text = "";
        TextBoxPostCode.Text = "";
        TextBoxSurnameAndContact.Text = "";

        DropDownListType.SelectedIndex = 0;
    }
}