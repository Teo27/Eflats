<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Offers.aspx.cs" Inherits="Offers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Offers</title>

    <meta http-equiv="X-UA_Compatible" content="IE=edge" />
     <meta name="viewport" content="width=device-width, initial-scale=1" />
     <link rel="stylesheet" type="text/css" href="css/bootstrap.css" />
    <link rel="stylesheet" type="text/css" href="css/Colouring.css" />


    <style type="text/css">
       /* Fix for the phone menu */

        .navbar-collapse.in,
        .navbar-collapse.collapsing {
            clear: left;
        }
           
        .dropdown-menu > .disabled{
            cursor: not-allowed; 
        }

         .dropdown-menu > .disabled > a {
            pointer-events: none;
        }

        
        .Initial
        {
             display: block;
             padding: 4px 18px 4px 18px;
             float: left;
             background: #c7b4b4 no-repeat right top;
             color: Black;
             font-weight: bold;
        }
        .Initial:hover
        {
             color: Black;
             background: #808080 no-repeat right top;
        }
        .Clicked
        {
             float: left;
             display: block;
             background: #3497d9 no-repeat right top;
             padding: 4px 18px 4px 18px;
             color: Black;
             font-weight: bold;
             color: White;
        }
       

        .auto-style50 {
            height: 608px;
            text-align: center;
        }

       



    </style>
</head>
<body>
    <form id="form1" runat="server">
  <nav class="navbar navbar-default navbar-fixed-top">
        <div class="container-fluid">

            <%-- STUFF ON LEFT SIDE --%>

            <div class="navbar-header pull-left">

                <a class="pull-left" href="MainPageLandlord.aspx">
                    <img src="images/home.png" height="48px" width="48px" /></a>

                <%-- LINKS WITH ID TO CONNECT WITH PHONE MENU --%>


                <ul class="nav navbar-nav collapse navbar-collapse" id="myNavbar">
                    <li><a href="MainPageLandlord.aspx"><b class="cream">Home</b></a></li>


                    <li class="dropdown active">
                    <a class="dropdown-toggle" data-toggle="dropdown" href="#"><b> Flats </b><span class="caret"></span></a>
                        <ul class="dropdown-menu">
                          <li><a  href="FlatsAdd.aspx">Add Flat</a></li>
                          <li><a  href="FlatsUpdate.aspx">Update Flat</a></li>
                          <li class="disabled"><a href="#">Delete Flat</a></li>
                          <li><a href="Offers.aspx">Offers</a></li>
                        </ul>
                    </li>
                    <li><a href="EditProfileLandlord.aspx"><b class="cream">Edit Profile</b></a></li>
                    <li class="disabled inactive"><a href="#"><b class="cream">FAQ</b></a></li>
                    <li class="disabled inactive"><a href="#"><b class="cream">About us</b></a></li>
                </ul>

                    &nbsp;&nbsp;&nbsp;&nbsp;

                     <%-- PHONE MENU --%>

                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target="#myNavbar">
                    <span class="sr-only"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>

                </button>

            </div>

            <%-- STUFF ON THE RIGHT SIDE --%>

            <div class="navbar-header pull-right">
                <a href="EditProfileLandlord.aspx" style="color: black; text-decoration: none;"><asp:Label ID="WelcomeLabel" runat="server" Text="Welcome " class="hidden-xs cream" Font-Bold="True"></asp:Label></a>
                  <asp:Button ID="LogOut" runat="server" OnClick="LogOut_Click" Text="Log Out"  CssClass="btn btn-sm button2" ForeColor="#9f4e3e" Font-Bold="True" />
                  
                <button class="btn navbar-btn btn-sm dropdown-toggle button2" type="button" data-toggle="dropdown" aria-haspopup="true" aria-expanded="true"><b >Language</b> <span class="caret"></span></button>

                <ul class="dropdown-menu">

                    <li class="dropdown-header"><b>Europe</b></li>

                    <li class="active"><a href="#">
                        <img src="images/UK.png" />
                        &nbsp; English</a></li>
                    <li class="disabled"><a href="#">
                        <img src="images/Denmark.png" />
                        &nbsp; Danish</a></li>

                    <li role="separator" class="divider"></li>
                    <li class="dropdown-header"><b>Africa</b></li>

                    <li class="disabled"><a href="#">
                        <img src="images/Kenya.png" />
                        &nbsp; Swahili</a></li>

                    <li role="separator" class="divider"></li>
                    <li class="dropdown-header"><b>Asia</b></li>

                    <li class="disabled"><a href="#">
                        <img src="images/Mongolia.png" />
                        &nbsp; Mongolian</a></li>
                    <li class="disabled"><a href="#">
                        <img src="images/China.png" />
                        &nbsp; Chinese</a></li>

                </ul>

                    &nbsp;

            </div>
        </div>
    </nav>


        <table style="margin: 100px auto; width:50%">
          
            
            <tr>
                

                <td colspan="2" style="text-align:center">
                          <asp:Label ID="LabelNoOffers" runat="server" Text="You do not have any offers." Visible="False"></asp:Label>
                          <asp:GridView ID="GridViewAllFlats"   runat="server" AllowPaging="True" AllowSorting="True" BorderWidth="1px" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="Id"  ForeColor="#9f4e3e" GridLines="None" Width="100%" HeaderStyle-CssClass="HeaderStyle" >
                              <AlternatingRowStyle BackColor="White" HorizontalAlign="Center" />
                              <Columns>
                                  <asp:BoundField DataField="FlatId" HeaderText="FlatId" InsertVisible="False"   ReadOnly="True" HeaderStyle-HorizontalAlign="NotSet" />
                                  
                                  <asp:BoundField DataField="StudentEmail" HeaderText="Student Email"  /> 
                                  <asp:BoundField DataField="DateOfOffer" HeaderText="Date Of Offer"  /> 
                                  <asp:BoundField DataField="DateOfConfirmation" HeaderText="Date Of Confirmation" > 
                                  </asp:BoundField>

                                  
                         

                                                                                  

                              </Columns>
                              <EditRowStyle BackColor="#7C6F57" HorizontalAlign="Center" />
                              <EmptyDataRowStyle HorizontalAlign="Center" />
                              <FooterStyle BackColor="#9f4e3e" Font-Bold="True" ForeColor="#ffffde" />
                              <HeaderStyle BackColor="#9f4e3e" Font-Bold="True" ForeColor="#ffffde" />
                              <PagerStyle BackColor="#9f4e3e" ForeColor="#ffffde" HorizontalAlign="Center" />
                              <RowStyle BackColor="#ffffde" HorizontalAlign="Center" />
                              <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" HorizontalAlign="Center" />
                              <SortedAscendingCellStyle BackColor="#F8FAFA" HorizontalAlign="Center" />
                              <SortedAscendingHeaderStyle BackColor="#246B61" HorizontalAlign="Center" />
                              <SortedDescendingCellStyle BackColor="#D4DFE1" HorizontalAlign="Center" />
                              <SortedDescendingHeaderStyle BackColor="#15524A" HorizontalAlign="Center" />
                              <AlternatingRowStyle BackColor="#fafad9" />
                          </asp:GridView>
                </td>
              
            </tr>
            </table>
    <nav class="navbar navbar-default navbar-fixed-bottom">
        <div class="container">
            <br />

            <p class="pull-left">
                studentflatsdenmark@gmail.com 
              <br />
                +45 12345678
            </p>

            <p class="pull-right">
                <a href="#">
                    <img src="images/facebook.png" /></a>&nbsp;
                <a href="#">
                    <img src="images/twitter.png" /></a>&nbsp;
                <a href="#">
                    <img src="images/linkedin.png" /></a>&nbsp;
                <a href="#">
                    <img src="images/google.png" /></a>
            </p>

        </div>
    </nav>


            
   
    </form>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js"></script>
    <script>window.jQuery || document.write('<script src="jquery/jquery-1.11.3.min.js"><\/script>')</script>
    <script src="js/bootstrap.min.js"></script>


</body>
</html>
