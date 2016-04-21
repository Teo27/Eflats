<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Flats.aspx.cs" Inherits="Flats" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
               .btn {
  
  border-radius: 8px;
  font-family: Arial;
  color: #ffffff;
  font-size: 18px;
  background: #3497d9;
  padding: 10px 20px 10px 20px;
  text-decoration: none;
}

.btn:hover {
  background: #5dbffc;
  background-image: -webkit-linear-gradient(top, #5dbffc, #377096);
  background-image: -moz-linear-gradient(top, #5dbffc, #377096);
  background-image: -o-linear-gradient(top, #5dbffc, #377096);
  background-image: linear-gradient(to bottom, #5dbffc, #377096);
  text-decoration: none;
}
 .auto-style1 {
            width: 1499px;
            height: 439px;
        }
        .auto-style21 {
            width: 249px;
            height: 192px;
        }
        .auto-style25 {
            height: 192px;
        }
        .auto-style36 {
            margin-bottom: 61px;
        }
        .Initial
        {
             display: block;
             padding: 4px 18px 4px 18px;
             float: left;
             background: #AC4E3D no-repeat right top;
             color: Black;
             font-weight: bold;
        }
        .Initial:hover
        {
             color: White;
             background: #753023 no-repeat right top;
        }
        .Clicked
        {
             float: left;
             display: block;
             background: #753023 no-repeat right top;
             padding: 4px 18px 4px 18px;
             color: Black;
             font-weight: bold;
             color: White;
        }
        .auto-style45 {
            width: 250px;
            height: 192px;
        }
        .auto-style51 {
            width: 249px;
            height: 430px;
        }
        .auto-style52 {
            height: 430px;
        }
        .auto-style53 {
            height: 17px;
            text-align: center;
        }
        .auto-style54 {
            width: 669px;
            height: 192px;
            text-align: right;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style21">
                 <a href="MainPageLandlord.aspx">   <asp:Image ID="Image3" runat="server" Height="158px" ImageUrl="http://www.homesapp.ca/images/home-5-256.png" Width="190px" /> </a>
                </td>
                <td class="auto-style25"></td>
                <td class="auto-style54">
                    <a href="EditProfile.aspx"><asp:Label ID="WelcomeLabel" runat="server" Text="Welcome " ></asp:Label></a>
                    <br />
                </td>
                <td class="auto-style45">
                    <asp:Button ID="LogOut0" runat="server" OnClick="LogOut_Click" Text="Log Out" BackColor="#3497D9" CssClass="btn" ForeColor="White" />
                </td>
            </tr>
            <tr>
                <td class="auto-style53" colspan="4">
                    <asp:Button ID="ButtonHome" runat="server" Text="Home" BackColor="#3497D9" OnClick="ButtonHome_Click" Width="200px" CssClass="btn" ForeColor="White" />
                    <asp:Button ID="ButtonFlats0" runat="server" Text="Flats" BackColor="#3497D9" OnClick="ButtonFlats_Click" Width="200px" CssClass="btn" ForeColor="White" />
                    <asp:Button ID="ButtonProfile0" runat="server" Text="Edit Profile" BackColor="#3497D9" OnClick="ButtonProfile_Click" Width="200px" CssClass="btn" ForeColor="White" />
                </td>
            </tr>
            <tr>
                <td class="auto-style51">
                </td>
                <td class="auto-style52">
                    <asp:Button ID="ButtonAdd" runat="server" OnClick="ButtonAdd_Click" Text="Add a flat" Width="200px" BackColor="#3497D9" CssClass="btn" ForeColor="White" />
                    <br />
                    <br />
                    <asp:Button ID="ButtonOffers" runat="server" OnClick="ButtonOffers_Click" Text="Offers" Width="200px" BackColor="#3497D9" CssClass="btn" ForeColor="White" />
                    <br />
                    <br />
                    <asp:Button ID="ButtonUpdate" runat="server" OnClick="ButtonUpdate_Click" Text="Update a flat" Width="200px" BackColor="#3497D9" CssClass="btn" ForeColor="White" />
                    <br />
                    <br />
                </td>
                <td class="auto-style52">
                    &nbsp;</td>
                <td class="auto-style52"></td>
            </tr>
            </table>
    <div class="auto-style36">
    
    </div>
    </form>
</body>
</html>
