using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

public partial class FlatsUpdate : System.Web.UI.Page
{
    ServiceReference1.WcfEFlatsServiceClient client = new ServiceReference1.WcfEFlatsServiceClient();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["New"] != null)
        {
            if (!IsPostBack)
            {
                if (Session["Type"].ToString() == "Landlord")
                {
                    WelcomeLabel.Text += Session["New"].ToString();
                    DataSet ds = client.GetFlatsLandlord(Session["New"].ToString());
                    DropDownList1.DataSource = ds;
                    DropDownList1.DataBind();

                }
                int rowCount = 0;
                int finalRow = 0;
                DataSet ds2 = client.GetAllFlats();

                foreach (DataRow row in ds2.Tables[0].Rows)
                {
                    if ((row["Id"].ToString().Trim()).Equals(DropDownList1.SelectedValue))
                    {
                        finalRow = rowCount;
                    }
                    rowCount++;
                    LabelStatus.Text = ds2.Tables[0].Rows[finalRow]["Status"].ToString().Trim();
                    LabelId.Text = DropDownList1.SelectedValue.ToString().Trim();

                    TextBoxDeposit.Text = ds2.Tables[0].Rows[finalRow]["Deposit"].ToString().Trim();
                    TextBoxRent.Text = ds2.Tables[0].Rows[finalRow]["Rent"].ToString().Trim();
                    TextBoxDescription.Text = ds2.Tables[0].Rows[finalRow]["Description"].ToString().Trim();
                }
            }           
        }
        else
        {
          //  Response.Redirect("Register.aspx");
        }
    }

    protected void LogOut_Click(object sender, EventArgs e)
    {
        Session["New"] = null;
        Response.Redirect("Register.aspx");
    }


    protected void ButtonUpdate_Click(object sender, EventArgs e)
    {
        ServiceReference1.UpdateFlatRequest updateFlat = new ServiceReference1.UpdateFlatRequest();

        updateFlat.flatId = Convert.ToInt32(DropDownList1.SelectedValue);
        updateFlat.rent =  Convert.ToDouble(TextBoxRent.Text);
        updateFlat.deposit = Convert.ToDouble(TextBoxDeposit.Text);
        updateFlat.description = TextBoxDescription.Text;

        client.UpdateFlat(updateFlat.flatId, updateFlat.rent, updateFlat.deposit, updateFlat.description);
        if (client.UpdateFlat(updateFlat.flatId, updateFlat.rent, updateFlat.deposit, updateFlat.description) == true)
        {
            LabelUpdated.Text = "Flat sucessfully updated";
        }
        else
        {
            LabelUpdated.Text = "Flat failed to be updated";
        }
    }

    protected void ButtonReopen_Click(object sender, EventArgs e)
    {
        if (MessageBox.Show("If you click yes the flat will be open and people can apply for it. Are you sure you want to continue?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
        {
            client.UpdateFlatStatus(Convert.ToInt32(DropDownList1.SelectedValue), "Open", "" , Calendar1.SelectedDate.ToString("dd/MM/yyyy"));
            LabelStatus.Text = "Open";

            if (client.UpdateFlatStatus(Convert.ToInt32(DropDownList1.SelectedValue), "Open", "" , Calendar1.SelectedDate.ToString("dd/MM/yyyy")) == true)
            {
                LabelStatusUpdated.Text = "Flat sucessfully updated";
            }
            else
            {
                LabelStatusUpdated.Text = "Flat failed to be updated";
            }
        }
    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        int rowCount = 0;
        int finalRow = 0;
        DataSet ds2 = client.GetAllFlats();

        foreach (DataRow row in ds2.Tables[0].Rows)
        {
            if ((row["Id"].ToString().Trim()).Equals(DropDownList1.SelectedValue))
            {
                finalRow = rowCount;
            }
            rowCount++;
            LabelId.Text = DropDownList1.SelectedValue.ToString().Trim();
            LabelStatus.Text = ds2.Tables[0].Rows[finalRow]["Status"].ToString().Trim();
            TextBoxDeposit.Text = ds2.Tables[0].Rows[finalRow]["Deposit"].ToString().Trim();
            TextBoxRent.Text = ds2.Tables[0].Rows[finalRow]["Rent"].ToString().Trim();
            TextBoxDescription.Text = ds2.Tables[0].Rows[finalRow]["Description"].ToString().Trim();
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
            e.Cell.BackColor = System.Drawing.ColorTranslator.FromHtml("#b96c5d");
            e.Cell.ForeColor = System.Drawing.ColorTranslator.FromHtml("#ffffde");
            e.Day.IsSelectable = false;
        }
        if (e.Day.IsOtherMonth)
        {
            e.Cell.Text = string.Empty;
        }
    }

}