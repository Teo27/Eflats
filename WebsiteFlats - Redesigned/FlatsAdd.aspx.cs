using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using ServerDatabase;
using System.Windows.Forms;

public partial class FlatsAdd : System.Web.UI.Page
{
    ServiceReference1.WcfEFlatsServiceClient client = new ServiceReference1.WcfEFlatsServiceClient();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["New"] != null)
        {
            if (Session["Type"].ToString() == "Landlord")
            {
                if (!IsPostBack)
                {
                    WelcomeLabel.Text += Session["Email"].ToString();
                    TextBoxDate.Text = "";
                }
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

    

    protected void ButtonAddFlat_Click(object sender, EventArgs e)
    {
        try
        {           
            string landlordEmail = Session["Email"].ToString().Trim();
            string type = DropdownType.SelectedValue.ToString();
            string address = TextBoxAddress.Text;
            string postCode = TextBoxPostCode.Text;
            string city = TextBoxCity.Text;
            string availableFrom = Calendar1.SelectedDate.ToString("dd/MM/yyyy");
            double rent = Convert.ToDouble(TextBoxRent.Text.Trim());
            double deposit = Convert.ToDouble(TextBoxDeposit.Text.Trim());
            string description = TextBoxDescription.Text;

            String output = client.AddFlat(landlordEmail, type, address, postCode, city, rent, deposit, availableFrom, description);

            if (output.Trim().Equals("Successfully added."))
            {

                LabelAddFlat.Text = "Successfully added.";
                Calendar1.SelectedDates.Clear();
            }
            else if (output.Equals("Unable to add flat due to nonexisting landlord email."))

                LabelAddFlat.Text = "Unable to add flat due to nonexisting landlord email.";

            else
            {
                LabelAddFlat.Text = "Unable to connect to database.";
            }
        }

        catch
        {
            Response.Redirect("ErrorPage.aspx");
        }

    }

    protected void Calendar1_DayRender(object sender, DayRenderEventArgs e)
    {

        DateTime pastday = e.Day.Date;
        DateTime date = DateTime.Now;
        int year = date.Year;
        int month = date.Month;
        int day = date.Day;
        DateTime today = new DateTime(year, month, day);
        if (pastday.CompareTo(today) < 0)
        {
            e.Cell.BackColor = System.Drawing.Color.Gray;
            e.Day.IsSelectable = false;
        }
    }

    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        TextBoxDate.Text = Calendar1.SelectedDate.ToString("dd/MM/yyyy").Trim();
    }

    protected void ButtonClear_Click(object sender, EventArgs e)
    {
        DropdownType.SelectedValue = "0";
        TextBoxAddress.Text = "";
        TextBoxPostCode.Text = "";
        TextBoxRent.Text = "";
        TextBoxDeposit.Text = "";
        TextBoxCity.Text = "";
        TextBoxDescription.Text = "";
        Calendar1.SelectedDates.Clear();
        TextBoxDate.Text = "";
    }
}