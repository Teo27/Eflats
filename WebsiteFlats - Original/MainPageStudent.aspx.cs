using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
// using System.Windows.Forms;

public partial class MainPageStudent : System.Web.UI.Page
{
    ServiceReference1.WcfEFlatsServiceClient client = new ServiceReference1.WcfEFlatsServiceClient();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["New"] != null)
        {
            if (!IsPostBack)
            {
                WelcomeLabel.Text += Session["Email"].ToString();
                BindFlatsDataAll();
                ButtonVisibilityAll();
                if (Session["View"] != null)
                {
                    MainView.ActiveViewIndex = Convert.ToInt32(Session["View"].ToString());
                    if (Session["State"] != null)
                    {
                        if (Session["State"].ToString() == "GridViewOpen")
                        {
                            GridViewOpen.PageIndex = Convert.ToInt32(Session["Page"].ToString());
                            BindFlatsDataOpen();
                            ButtonVisibilityOpen();
                            Tab3.CssClass = "Clicked";
                        }
                        else if (Session["State"].ToString() == "GridViewAllFlats")
                        {
                            GridViewAllFlats.PageIndex = Convert.ToInt32(Session["Page"].ToString());
                            BindFlatsDataAll();
                            ButtonVisibilityAll();
                            Tab1.CssClass = "Clicked";
                        }
                        else if (Session["State"].ToString() == "GridViewMostRecent")
                        {
                            GridViewMostRecent.PageIndex = Convert.ToInt32(Session["Page"].ToString());
                            BindFlatsDataMostRecent();
                            ButtonVisibilityMostRecent();
                            Tab2.CssClass = "Clicked";
                        }

                    }else if(Convert.ToInt32(Session["View"].ToString()) == 0)
                    {
                        BindFlatsDataAll();
                        ButtonVisibilityAll();
                        Tab1.CssClass = "Clicked";
                    }
                    else if (Convert.ToInt32(Session["View"].ToString()) == 1)
                    {
                        BindFlatsDataMostRecent();
                        ButtonVisibilityMostRecent();
                        Tab2.CssClass = "Clicked";
                    }
                    else if (Convert.ToInt32(Session["View"].ToString()) == 2)
                    {
                        BindFlatsDataOpen();
                        ButtonVisibilityOpen();
                        Tab3.CssClass = "Clicked";
                    }
                }
                else if (Session["State"] != null)
                {
                    GridViewAllFlats.PageIndex = Convert.ToInt32(Session["Page"].ToString());
                    BindFlatsDataAll();
                    ButtonVisibilityAll();
                    Tab1.CssClass = "Clicked";
                }
                else
                {
                    BindFlatsDataAll();
                    ButtonVisibilityAll();
                    Tab1.CssClass = "Clicked";
                }
            }            
        }
        else
        {
            WelcomeLabel.Visible = false;
            LogOut.Visible = false;
        }

        Tab1.CssClass = "Clicked";
        MainView.ActiveViewIndex = 0;
    }

    protected void ButtonLogOut_Click(object sender, EventArgs e)
    {
        Session["New"] = null;
        Response.Redirect("Register.aspx");
    }

    protected void ButtonHome_Click(object sender, EventArgs e)
    {
        Response.Redirect("MainPageStudent.aspx");
    }
    
    protected void ButtonWishList_Click(object sender, EventArgs e)
    {
        Response.Redirect("WishList.aspx");
    }

    protected void ButtonProfile_Click(object sender, EventArgs e)
    {
        Response.Redirect("EditProfileStudent.aspx");
    }
    
    protected void Tab2_Click(object sender, EventArgs e)
    {
        Tab1.CssClass = "Initial";
        Tab2.CssClass = "Clicked";
        Tab3.CssClass = "Initial";

        MainView.ActiveViewIndex = 1;
        BindFlatsDataMostRecent();
        ButtonVisibilityMostRecent();
        Session["View"] = MainView.ActiveViewIndex;
        Session["State"] = null;
    }

    protected void Tab1_Click(object sender, EventArgs e)
    {
        Tab1.CssClass = "Clicked";
        Tab2.CssClass = "Initial";
        Tab3.CssClass = "Initial";

        MainView.ActiveViewIndex = 0;
        BindFlatsDataAll();
        ButtonVisibilityAll();
        Session["View"] = MainView.ActiveViewIndex;
        Session["State"] = null;
    }


    protected void Tab3_Click(object sender, EventArgs e)
    {
        Tab1.CssClass = "Initial";
        Tab2.CssClass = "Initial";
        Tab3.CssClass = "Clicked";

         
        MainView.ActiveViewIndex = 2;
        BindFlatsDataOpen();
        ButtonVisibilityOpen();
        Session["View"] = MainView.ActiveViewIndex;
        Session["State"] = null;
    }

    protected void GridViewAllFlats_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        int rowindex = Convert.ToInt32(e.CommandArgument) % GridViewAllFlats.PageSize;

        if (e.CommandName == "Add")
        {
            int flatId = Convert.ToInt32(GridViewAllFlats.Rows[rowindex].Cells[0].Text);
            string studentEmail = Session["Email"].ToString();
            int score = Convert.ToInt32(Session["Score"]);
            client.AddToWishlist(studentEmail, flatId, score);
            Response.Redirect("MainPageStudent.aspx");

        }
        else if (e.CommandName == "Remove")
        {          
            int flatId = Convert.ToInt32(GridViewAllFlats.Rows[rowindex].Cells[0].Text);
            string studentEmail = Session["Email"].ToString();
            client.RemoveFromWishlist(studentEmail.Trim(), flatId);
            Response.Redirect("MainPageStudent.aspx");

        }
        if (e.CommandName == "View")
        {

            Session["Flat"] = Convert.ToInt32(GridViewAllFlats.Rows[rowindex].Cells[0].Text);
            Response.Redirect("FlatsDetailsStudent.aspx");
        }

    }


    protected void GridViewMostRecent_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        int rowindex = Convert.ToInt32(e.CommandArgument) % GridViewMostRecent.PageSize;
        if (e.CommandName == "Add")
        {
            int flatId = Convert.ToInt32(GridViewMostRecent.Rows[rowindex].Cells[0].Text);
            string studentEmail = Session["Email"].ToString();
            int score = Convert.ToInt32(Session["Score"]);
            client.AddToWishlist(studentEmail, flatId, score);
            Response.Redirect("MainPageStudent.aspx");

        }
        else if (e.CommandName == "Remove")
        {
            int flatId = Convert.ToInt32(GridViewMostRecent.Rows[rowindex].Cells[0].Text);
            string studentEmail = Session["Email"].ToString();
            client.RemoveFromWishlist(studentEmail.Trim(), flatId);
            Response.Redirect("MainPageStudent.aspx");
           
        }
        if (e.CommandName == "View")
        {
            Session["Flat"] = Convert.ToInt32(GridViewMostRecent.Rows[rowindex].Cells[0].Text);
            Response.Redirect("FlatsDetailsStudent.aspx");
        }

    }

    protected void GridViewOpen_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        int rowindex = Convert.ToInt32(e.CommandArgument) % GridViewOpen.PageSize;
        if (e.CommandName == "Add")
        {
            int flatId = Convert.ToInt32(GridViewOpen.Rows[rowindex].Cells[0].Text);
            string studentEmail = Session["Email"].ToString();
            int score = Convert.ToInt32(Session["Score"]);
            client.AddToWishlist(studentEmail, flatId, score);
            Response.Redirect("MainPageStudent.aspx");
           
        }
        else if (e.CommandName == "Remove")
        {
            int flatId = Convert.ToInt32(GridViewOpen.Rows[rowindex].Cells[0].Text);
            string studentEmail = Session["Email"].ToString();
            client.RemoveFromWishlist(studentEmail.Trim(), flatId);
            Response.Redirect("MainPageStudent.aspx");
            
        }
        if (e.CommandName == "View")
        {
            Session["Flat"] = Convert.ToInt32(GridViewOpen.Rows[rowindex].Cells[0].Text);
            Response.Redirect("FlatsDetailsStudent.aspx");
        }

    }

    protected void ButtonSearchFlats_Click(object sender, EventArgs e)
    {
        try
        {                     
            if (TextBoxMinDeposit.Text == "")
            {
                TextBoxMinDeposit.Text = "0";
            }
            if (TextBoxMaxDeposit.Text == "")
            {
                TextBoxMaxDeposit.Text = "50000";
            }
            if (TextBoxMinRent.Text == "")
            {
                TextBoxMinRent.Text = "0";
            }
            if (TextBoxMaxRent.Text == "")
            {
                TextBoxMaxRent.Text = "10000";
            }

            DataSet ds = client.SearchFlats(TextBoxCity.Text.Trim(), Convert.ToInt32(TextBoxMinRent.Text), Convert.ToInt32(TextBoxMaxRent.Text), Convert.ToInt32(TextBoxMinDeposit.Text), Convert.ToInt32(TextBoxMaxDeposit.Text));
            DataTable dt = ds.Tables[0];

            GridViewAllFlats.DataSource = dt;
            GridViewAllFlats.DataBind();

            LabelFlats.Visible = false;
            GridViewAllFlats.Visible = true;

            Tab1.Visible = true;
            Tab2.Visible = true;
            Tab3.Visible = true;
            ButtonVisibilityAll();
        }

        catch
        {
            LabelFlats.Visible = true;
            GridViewAllFlats.Visible = false;
            Tab1.Visible = false;
            Tab2.Visible = false;
            Tab3.Visible = false;
        }
    }

    //Bindings
    private void ButtonVisibilityAll()
    {
        DataSet dsApp = client.GetWishlist(Session["Email"].ToString().Trim());
        int i = 0;
        bool found = false;
        foreach (GridViewRow dr2 in GridViewAllFlats.Rows)
        {
            found = false;
            foreach (DataRow row in dsApp.Tables[0].Rows)
            {
                if (row["FlatId"].ToString().Trim().Equals(dr2.Cells[0].Text.Trim()))
                    found = true;
            }

            if (found)
            {
                GridViewAllFlats.Rows[i].Cells[5].FindControl("ButtonAdd").Visible = false;
                GridViewAllFlats.Rows[i].Cells[5].FindControl("ButtonRemove").Visible = true;
            }
            else
            {
                GridViewAllFlats.Rows[i].Cells[5].FindControl("ButtonRemove").Visible = false;
                GridViewAllFlats.Rows[i].Cells[5].FindControl("ButtonAdd").Visible = true;
            }

            i++;
        }
    }

    private void ButtonVisibilityMostRecent()
    {
        DataSet dsApp = client.GetWishlist(Session["Email"].ToString().Trim());
        int i = 0;
        bool found = false;
        foreach (GridViewRow dr2 in GridViewMostRecent.Rows)
        {
            found = false;
            foreach (DataRow row in dsApp.Tables[0].Rows)
            {
                if (row["FlatId"].ToString().Trim().Equals(dr2.Cells[0].Text.Trim()))
                    found = true;
            }

            if (found)
            {
                GridViewMostRecent.Rows[i].Cells[5].FindControl("ButtonAdd").Visible = false;
                GridViewMostRecent.Rows[i].Cells[5].FindControl("ButtonRemove").Visible = true;
            }
            else
            {
                GridViewMostRecent.Rows[i].Cells[5].FindControl("ButtonRemove").Visible = false;
                GridViewMostRecent.Rows[i].Cells[5].FindControl("ButtonAdd").Visible = true;
            }

            i++;
        }
    }

    private void ButtonVisibilityOpen()
    {
        DataSet dsApp = client.GetWishlist(Session["Email"].ToString().Trim());
        int i = 0;
        bool found = false;
        foreach (GridViewRow dr2 in GridViewOpen.Rows)
        {
            found = false;
            foreach (DataRow row in dsApp.Tables[0].Rows)
            {
                if (row["FlatId"].ToString().Trim().Equals(dr2.Cells[0].Text.Trim()))
                    found = true;
            }

            if (found)
            {
                GridViewOpen.Rows[i].Cells[5].FindControl("ButtonAdd").Visible = false;
                GridViewOpen.Rows[i].Cells[5].FindControl("ButtonRemove").Visible = true;
            }
            else
            {
                GridViewOpen.Rows[i].Cells[5].FindControl("ButtonRemove").Visible = false;
                GridViewOpen.Rows[i].Cells[5].FindControl("ButtonAdd").Visible = true;
            }

            i++;
        }
    }


    private void BindFlatsDataAll()
    {

        DataSet ds = client.GetAllFlats();
        DataTable dt2 = new DataTable();

        dt2.Columns.Add("Id");
        dt2.Columns.Add("LandlordEmail");
        dt2.Columns.Add("Type");
        dt2.Columns.Add("Address");
        dt2.Columns.Add("PostCode");
        dt2.Columns.Add("City");
        dt2.Columns.Add("Rent");
        dt2.Columns.Add("Deposit");
        dt2.Columns.Add("AvailableFrom");
        dt2.Columns.Add("DateOfCreation");
        dt2.Columns.Add("Description");
        dt2.Columns.Add("Status");
        dt2.Columns.Add("Date_of_offer");
     
        ds.Tables.Add(dt2);

        GridViewAllFlats.DataSource = ds.Tables[0];
        GridViewAllFlats.DataBind();

        
    }
    private void BindFlatsDataMostRecent()
    {       
        DataSet ds = client.GetAllFlats();
        DataTable dt2 = new DataTable();

        dt2.Columns.Add("Id");
        dt2.Columns.Add("LandlordEmail");
        dt2.Columns.Add("Type");
        dt2.Columns.Add("Address");
        dt2.Columns.Add("PostCode");
        dt2.Columns.Add("City");
        dt2.Columns.Add("Rent");
        dt2.Columns.Add("Deposit");
        dt2.Columns.Add("AvailableFrom");
        dt2.Columns.Add("DateOfCreation");
        dt2.Columns.Add("Description");
        dt2.Columns.Add("Status");
        dt2.Columns.Add("Date_of_offer");
       
        ds.Tables.Add(dt2);

        DataTable dt = ds.Tables[0];
        dt.DefaultView.Sort = "DateOfCreation Desc";
        dt = dt.DefaultView.ToTable();
        GridViewMostRecent.DataSource = dt;
        GridViewMostRecent.DataBind();

    }
    private void BindFlatsDataOpen()
    {
        DataSet ds = client.GetAllFlats();
        DataTable dt2 = new DataTable();

        dt2.Columns.Add("Id");
        dt2.Columns.Add("LandlordEmail");
        dt2.Columns.Add("Type");
        dt2.Columns.Add("Address");
        dt2.Columns.Add("PostCode");
        dt2.Columns.Add("City");
        dt2.Columns.Add("Rent");
        dt2.Columns.Add("Deposit");
        dt2.Columns.Add("AvailableFrom");
        dt2.Columns.Add("DateOfCreation");
        dt2.Columns.Add("Description");
        dt2.Columns.Add("Status");
        dt2.Columns.Add("Date_of_offer");

        foreach (DataRow dr in ds.Tables[0].Rows)
        {
            if (dr["Status"].ToString().Trim().Equals("Open"))
            {
                dt2.ImportRow(dr);
            }

        }
        ds.Tables.Add(dt2);

        GridViewOpen.DataSource = ds.Tables[1];
        GridViewOpen.DataBind();

    }
    protected void gridViewAllFlats_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridViewAllFlats.PageIndex = e.NewPageIndex;
        BindFlatsDataAll();
        ButtonVisibilityAll();
        MainView.ActiveViewIndex = 0;
        Session["State"] = "GridViewAllFlats";
        Session["Page"] = GridViewAllFlats.PageIndex;
        Tab1.CssClass = "Clicked";
        Tab2.CssClass = "Initial";
        Tab3.CssClass = "Initial";
    }

    protected void gridViewMostRecent_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridViewMostRecent.PageIndex = e.NewPageIndex;
        BindFlatsDataMostRecent();
        ButtonVisibilityMostRecent();
        MainView.ActiveViewIndex = 1;
        Session["State"] = "GridViewMostRecent";
        Session["Page"] = GridViewMostRecent.PageIndex;
        Tab1.CssClass = "Initial";
        Tab2.CssClass = "Clicked";
        Tab3.CssClass = "Initial";
    }
    protected void gridViewOpen_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridViewOpen.PageIndex = e.NewPageIndex;
        BindFlatsDataOpen();
        ButtonVisibilityOpen();
        MainView.ActiveViewIndex = 3;
        Session["State"] = "GridViewOpen";
        Session["Page"] = GridViewOpen.PageIndex;
        Tab1.CssClass = "Initial";
        Tab2.CssClass = "Initial";
        Tab3.CssClass = "Clicked";
    }
}