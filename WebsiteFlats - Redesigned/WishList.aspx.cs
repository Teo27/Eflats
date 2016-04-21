using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

public partial class WishList : System.Web.UI.Page
{
    ServiceReference1.WcfEFlatsServiceClient client = new ServiceReference1.WcfEFlatsServiceClient();

    protected void Page_Load(object sender, EventArgs e)
    {
        if(Session["New"]!=null)
        {
            if (Session["Type"].ToString() == "Student")
            {
                if (!IsPostBack)
                {
                    WelcomeLabel.Text += Session["Email"].ToString();
                    DataSet ds1 = client.GetWishlist(Session["Email"].ToString());
                    GridView1.DataSource = ds1.Tables[0];
                    GridView1.DataBind();
                }
                
                DataSet ds2 = client.GetAllFlats();

                for (int i = 0; i < GridView1.Rows.Count; i++)
                {
                    if (Convert.ToInt32(GridView1.Rows[i].Cells[2].Text) == 1)
                    {

                        int rowCount = 0;
                        int finalRow = 0;
                        string status;
                        foreach (DataRow row in ds2.Tables[0].Rows)
                        {
                            if ((row["Id"].ToString().Trim()).Equals(GridView1.Rows[i].Cells[0].Text.Trim()))
                            {
                                finalRow = rowCount;
                            }
                            rowCount++;
                            status = ds2.Tables[0].Rows[finalRow]["Status"].ToString().Trim();
                            if (status.Equals("Pending"))
                            {
                                GridView1.Rows[i].Cells[4].FindControl("ButtonAccept").Visible = true;
                                GridView1.Rows[i].Cells[4].FindControl("ButtonDeny").Visible = true;
                            }
                            else
                            {
                                GridView1.Rows[i].Cells[4].FindControl("ButtonAccept").Visible = false;
                                GridView1.Rows[i].Cells[4].FindControl("ButtonDeny").Visible = false;
                            }
                        }
                       
                    }
                }

            }
            else if (Session["Type"].ToString() == "Landlord")
            {
                Response.Redirect("MainPageLandlord.aspx");
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

    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {       
            if (e.CommandName == "Remove")
            {
                int flatId = Convert.ToInt32(GridView1.Rows[int.Parse(e.CommandArgument.ToString())].Cells[0].Text);
                string studentEmail = Session["Email"].ToString();
                client.RemoveFromWishlist(studentEmail.Trim(), flatId);
                Response.Redirect("WishList.aspx");
            }
            if (e.CommandName == "Accept")
            {
                if (MessageBox.Show("If you click yes the flat will be removed from wishlist and you will pay a fee. Do you wish to continue?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                                        
                int flatId = Convert.ToInt32(GridView1.Rows[int.Parse(e.CommandArgument.ToString())].Cells[0].Text);
                if (client.ConfirmTenants(flatId, Session["Email"].ToString().Trim()))
                {
                    client.UpdateFlatStatus(flatId, "Closed", "", "Not available");

                    string studentEmail = Session["Email"].ToString();
                    client.RemoveFromWishlist(studentEmail.Trim(), flatId);
                    Response.Redirect("WishList.aspx");
                }
                else
                    Response.Redirect("ErrorPage.aspx");

            }
            else
            {
                int flatId = Convert.ToInt32(GridView1.Rows[int.Parse(e.CommandArgument.ToString())].Cells[0].Text);
                string studentEmail = Session["Email"].ToString();
                client.RemoveFromWishlist(studentEmail.Trim(), flatId);
                Response.Redirect("WishList.aspx");
            }

        }
        if (e.CommandName == "Deny")
            {
                if (MessageBox.Show("If you click yes the flat will be removed from wishlist. Do you wish to continue?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int flatId = Convert.ToInt32(GridView1.Rows[int.Parse(e.CommandArgument.ToString())].Cells[0].Text);
                    string studentEmail = Session["Email"].ToString();
                    client.RemoveFromWishlist(studentEmail.Trim(), flatId);
                    Response.Redirect("WishList.aspx");
                }
            }
    }

}

