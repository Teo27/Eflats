﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MainPageLandlord : System.Web.UI.Page
{
    ServiceReference1.WcfEFlatsServiceClient client = new ServiceReference1.WcfEFlatsServiceClient();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["New"] != null)
        {
            if (!IsPostBack)
            {
                WelcomeLabel.Text += Session["Email"].ToString();
                DataSet ds = client.GetFlatsLandlord(Session["Email"].ToString().Trim());
                GridViewAllFlats.DataSource = ds.Tables[0];
                GridViewAllFlats.DataBind();
            }
            for (int i = 0; i < GridViewAllFlats.Rows.Count; i++)
            {
                if ((GridViewAllFlats.Rows[i].Cells[2].Text.Trim() == "Closed") || (GridViewAllFlats.Rows[i].Cells[2].Text.Trim() == "Pending"))
                {
                    GridViewAllFlats.Rows[i].Cells[6].FindControl("ButtonSend").Visible = false;
                }
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

    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "Send")
        {
            int flatId = Convert.ToInt32(GridViewAllFlats.Rows[int.Parse(e.CommandArgument.ToString())].Cells[0].Text);
            string availableFrom = GridViewAllFlats.Rows[int.Parse(e.CommandArgument.ToString())].Cells[4].Text.Trim();
            client.UpdateFlatStatus(flatId, "Pending","", availableFrom);
            Response.Redirect("MainPageLandlord.aspx");
        }
        if (e.CommandName == "View")
        {

            Session["Flat"] = Convert.ToInt32(GridViewAllFlats.Rows[int.Parse(e.CommandArgument.ToString())].Cells[0].Text);
            Response.Redirect("FlatsDetailsLandlord.aspx");
        }
    }

  
}