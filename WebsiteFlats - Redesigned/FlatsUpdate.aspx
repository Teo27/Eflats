<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FlatsUpdate.aspx.cs" Inherits="FlatsUpdate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Flat Update</title>

    <meta http-equiv="X-UA_Compatible" content="IE=edge" />
     <meta name="viewport" content="width=device-width, initial-scale=1" />
     <link rel="stylesheet" type="text/css" href="css/bootstrap.css" />


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
                    <li><a href="MainPageLandlord.aspx">Home</a></li>


                    <li class="dropdown active">
                    <a class="dropdown-toggle" data-toggle="dropdown" href="#"> Flats <span class="caret"></span></a>
                        <ul class="dropdown-menu">
                          <li><a  href="FlatsAdd.aspx">Add Flat</a></li>
                          <li class="active"><a  href="FlatsUpdate.aspx">Update Flat</a></li>
                          <li class="disabled"><a href="#">Delete Flat</a></li>
                          <li><a href="Offers.aspx">Offers</a></li>
                        </ul>
                    </li>
                    <li><a href="#">Flats</a></li>
                    <li><a href="EditProfileLandlord.aspx">Edit Profile</a></li>
                    <li class="disabled"><a href="#">FAQ</a></li>
                    <li class="disabled"><a href="#">About us</a></li>
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
                <a href="EditProfileLandlord.aspx" style="color: black; text-decoration: none;"><asp:Label ID="WelcomeLabel" runat="server" Text="Welcome " class="hidden-xs"></asp:Label></a>
                  <asp:Button ID="LogOut" runat="server" OnClick="LogOut_Click" Text="Log Out" BackColor="#3497D9" CssClass="btn" ForeColor="White" />
                  
                <button class="btn navbar-btn btn-sm dropdown-toggle" type="button" data-toggle="dropdown" aria-haspopup="true" aria-expanded="true">Language <span class="caret"></span></button>

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


        <table style="margin: 100px auto">
          
            <tr>
                <td class="text-right">
                    <asp:Label ID="LabelChooseFlat" runat="server" Text="Choose your apartment:"></asp:Label>&nbsp;
                </td>
                <td class="auto-style71" colspan="2">
                    <asp:DropDownList ID="DropDownList1" runat="server" DataTextField="Address" DataValueField="Id" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Width="150px">
                    </asp:DropDownList>
                    <br />
                </td>
                <td class="text-center" colspan="3" rowspan="3">
                    <asp:Label ID="LabelAvailable" runat="server" Text="Apartment is available from:" style="vertical-align: auto" ></asp:Label>&nbsp;
                </td>
                <td class="auto-style59" rowspan="4">
                    <asp:Calendar ID="Calendar1" runat="server" OnDayRender="Calendar1_DayRender"></asp:Calendar>
                </td>
            </tr>
            <tr>
                <td class="text-right">
                    <asp:Label ID="LabelApartmentId" runat="server" Text="Apartment ID:"></asp:Label>&nbsp;
                </td>
                <td class="auto-style71" colspan="2">
                    <asp:Label ID="LabelId" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="text-right">
                    <asp:Label ID="LabelRent" runat="server" Text="Enter new rent:"></asp:Label>&nbsp;
                </td>
                <td class="auto-style72" colspan="2">
                    <asp:TextBox ID="TextBoxRent" runat="server" Width="150px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="text-right">
                    <asp:Label ID="LabelDeposit" runat="server" Text="Enter new deposit:"></asp:Label>&nbsp;
                </td>
                <td class="auto-style64" colspan="3">
                    <asp:TextBox ID="TextBoxDeposit" runat="server" Width="150px"></asp:TextBox>
                </td>
                <td class="text-center" colspan="2">
                    <asp:Label ID="LabelStatus" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="text-right">
                    <asp:Label ID="LabelDescription" runat="server" Text="Enter new description:"></asp:Label>&nbsp;
                </td>
                <td class="auto-style64" colspan="3">
                    <asp:TextBox ID="TextBoxDescription" runat="server" Height="161px" MaxLength="500" TextMode="MultiLine" Width="275px"></asp:TextBox>
                </td>
                <td class="auto-style64" colspan="2">
                    &nbsp;</td>
                <td class="auto-style52">
                    <asp:Label ID="LabelStatusUpdated" runat="server" Visible="False"></asp:Label>
                    <asp:Button ID="ButtonReopen" runat="server" OnClick="ButtonReopen_Click" Text="Reopen appartment" />
                    </td>
            </tr>
            <tr>
                <td class="auto-style61">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorRent" ValidationGroup="UpdateFlat" runat="server" ControlToValidate="TextBoxRent" ErrorMessage="Enter a rent amount" ForeColor="Red"></asp:RequiredFieldValidator>
                    <br />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorDeposit" ValidationGroup="UpdateFlat" runat="server" ControlToValidate="TextBoxDeposit" ErrorMessage="Enter a deposit amount" ForeColor="Red"></asp:RequiredFieldValidator>
                    <br />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorDescription" ValidationGroup="UpdateFlat" runat="server" ControlToValidate="TextBoxDescription" ErrorMessage="Enter a description" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
                <td class="auto-style73">
                    <asp:Label ID="LabelUpdated" runat="server" Visible="False"></asp:Label>
                    <br />
                    <asp:Button ID="ButtonUpdate" ValidationGroup = "UpdateFlat" runat="server" OnClick="ButtonUpdate_Click" Text="Update" />
                </td>
                <td class="auto-style73">
                    &nbsp;</td>
                <td class="auto-style62" colspan="2">
                                <asp:RegularExpressionValidator ID="RegularExpressionValidatorDeposit" ValidationGroup='valGroup1' runat="server" ControlToValidate="TextBoxDeposit" ValidationExpression="^[1-9][0-9]*(\.[0-9]+)?|0+\.[0-9]*[1-9][0-9]*$." ErrorMessage="Only positive numbers are allowed"></asp:RegularExpressionValidator>
                            <br />
                                <asp:RegularExpressionValidator ID="RegularExpressionValidatorDeposit0" ValidationGroup='valGroup1' runat="server" ControlToValidate="TextBoxRent" ValidationExpression="^[1-9][0-9]*(\.[0-9]+)?|0+\.[0-9]*[1-9][0-9]*$." ErrorMessage="Only positive numbers are allowed"></asp:RegularExpressionValidator>
                </td>
                <td class="auto-style62" colspan="2">
                                &nbsp;</td>
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
