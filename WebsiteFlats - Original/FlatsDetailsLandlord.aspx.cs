using ServiceReference2;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//using System.Windows.Forms;

public partial class FlatsDetailsLandlord : System.Web.UI.Page
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
                    WelcomeLabel.Text += Session["New"].ToString();
                    DataSet ds = client.GetAllFlats();
                    int finalRow = 0;
                    int rowCount = 0;
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        if ((row["Id"].ToString().Trim()).Equals(Session["Flat"].ToString().Trim()))
                        {
                            DataTable dt = new DataTable();
                            dt.Columns.Add("Id");
                            dt.Columns.Add("LandlordEmail");
                            dt.Columns.Add("Type");
                            dt.Columns.Add("Address");
                            dt.Columns.Add("PostCode");
                            dt.Columns.Add("City");
                            dt.Columns.Add("Rent");
                            dt.Columns.Add("Deposit");
                            dt.Columns.Add("AvailableFrom");
                            dt.Columns.Add("DateOfCreation");
                            dt.Columns.Add("Description");
                            dt.Columns.Add("Status");
                            dt.Columns.Add("DateOfOffer");

                            dt.ImportRow(row);

                            finalRow = rowCount;
                            FormView1.DataSource = dt;
                            FormView1.DataBind();
                        }
                        rowCount++;
                    }
                }
            }
            else
            {
                Response.Redirect("Register.aspx");
            }
        }
        else
        {
            Response.Redirect("Register.aspx");
        }
        
            using (var client = new GoogleMapsGeolocationClient())
            {
            try {
                Label IDLabel1 = (Label)FormView1.FindControl("AddressLabel");
                Label IDLabel2 = (Label)FormView1.FindControl("CityLabel");
                string MyValue = IDLabel2.Text + ", " + IDLabel1.Text;

                string[] location = client.GetLattitudeAndLogitudeByAdress(MyValue).Split('#');

                LabelGoogleMaps.Visible = true;

                string url1 = "https://maps.google.com/maps?f=q&source=s_q&hl=en&geocode=&q="
                + location[0].Replace(',', '.') + "," + location[1].Replace(',', '.') + " (custom heading)&output=embed";

                loc.Value = url1;
            }
            catch
            {
                Response.Redirect("ErrorPage.aspx");
            }  

            }

}

    protected void LogOut_Click(object sender, EventArgs e)
    {
        Session["New"] = null;
        Response.Redirect("Register.aspx");
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
}