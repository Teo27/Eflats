<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FlatsAdd.aspx.cs" Inherits="FlatsAdd" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Flat Add</title>

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
        .auto-style43 {
            width: 265px;
        }
        .auto-style45 {
            width: 144px;
            text-align: center;
        }
       
        .auto-style54 {
            width: 175px;
            text-align: right;
        }
        .auto-style56 {
            height: 26px;
        }
       
        .auto-style59 {
            width: 265px;
            text-align: center;
        }
        .auto-style60 {
            width: 236px;
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
                    <a class="dropdown-toggle" data-toggle="dropdown" href="#" > Flats <span class="caret"></span></a>
                        <ul class="dropdown-menu">
                          <li class="active"><a  href="FlatsAdd.aspx">Add Flat</a></li>
                          <li><a  href="FlatsUpdate.aspx">Update Flat</a></li>
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


       
                    <table  style="margin: 100px auto;">
                        <tr>
                            <td class="auto-style54">Type:&nbsp;</td>
                            <td class="auto-style43">
                                <asp:DropDownList ID="DropdownType" runat="server" Width="95%">
                                    <asp:ListItem Value="0">Please choose</asp:ListItem>
                                    <asp:ListItem Value="Room">Room</asp:ListItem>
                                    <asp:ListItem Value="Apartment">Apartment</asp:ListItem>
                                    <asp:ListItem Value="House">House</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                            <td class="auto-style45" rowspan="6">Available</td>
                            <td rowspan="6" class="auto-style60">
                                <asp:Calendar ID="Calendar1" runat="server"  OnDayRender="Calendar1_DayRender" OnSelectionChanged="Calendar1_SelectionChanged">
                                </asp:Calendar>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style54">Address:&nbsp;</td>
                            <td class="auto-style43">
                                <asp:TextBox ID="TextBoxAddress" runat="server" Width="95%"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style54">Post Code:&nbsp;</td>
                            <td class="auto-style43">
                                <asp:TextBox ID="TextBoxPostCode" runat="server" Width="95%"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style54">Rent:&nbsp;</td>
                            <td class="auto-style43">
                                <asp:TextBox ID="TextBoxRent" runat="server" Width="95%"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style54">Deposit:&nbsp;</td>
                            <td class="auto-style43">
                                <asp:TextBox ID="TextBoxDeposit" runat="server" Width="95%"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style54">City:&nbsp;</td>
                            <td class="auto-style43">
                                <asp:TextBox ID="TextBoxCity" runat="server" Width="95%"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style54">
                                Description:&nbsp;</td>
                            <td class="auto-style59">
                            <asp:TextBox ID="TextBoxDescription" runat="server" maxlength="500" wrap="true" TextMode="MultiLine" Height="152px" Width="95%" style = "resize:none"></asp:TextBox>
                            &nbsp;&nbsp;</td>
                            <td colspan="2">
                                <asp:RequiredFieldValidator ID="RequiredFieldValidatorType" ValidationGroup='valGroup1' runat="server" ControlToValidate="DropdownType" ErrorMessage="Please select a type" ForeColor="Red" InitialValue="0"></asp:RequiredFieldValidator>
                                <br />
                                <asp:RequiredFieldValidator ID="RequiredFieldValidatorAddress" ValidationGroup='valGroup1' runat="server" ControlToValidate="TextBoxAddress" ErrorMessage="Please enter address" ForeColor="Red"></asp:RequiredFieldValidator>
                                <br />
                                <asp:RequiredFieldValidator ID="RequiredFieldValidatorPostCode" ValidationGroup='valGroup1' runat="server" ControlToValidate="TextBoxPostCode" ErrorMessage="Please enter post code" ForeColor="Red"></asp:RequiredFieldValidator>
                                <br />
                                <asp:RequiredFieldValidator ID="RequiredFieldValidatorRent" ValidationGroup='valGroup1' runat="server" ControlToValidate="TextBoxRent" ErrorMessage="Please enter monthly rent amount" ForeColor="Red"></asp:RequiredFieldValidator>
                                <br />
                                <asp:RequiredFieldValidator ID="RequiredFieldValidatorDeposit" ValidationGroup='valGroup1' runat="server" ControlToValidate="TextBoxDeposit" ErrorMessage="Please enter deposit amount" ForeColor="Red"></asp:RequiredFieldValidator>
                                <br />
                                <asp:RequiredFieldValidator ID="RequiredFieldValidatorAddress0" ValidationGroup='valGroup1' runat="server" ControlToValidate="TextBoxCity" ErrorMessage="Please enter city" ForeColor="Red"></asp:RequiredFieldValidator>
                                <br />
                                <asp:RequiredFieldValidator ID="RequiredFieldValidatorAddress1" ValidationGroup='valGroup1' runat="server" ControlToValidate="TextBoxDate" ErrorMessage="Please select date" ForeColor="Red"></asp:RequiredFieldValidator>
                                <br />
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" ValidationGroup='valGroup1' runat="server" ControlToValidate="TextBoxPostCode" ErrorMessage="Please enter proper Danish post code" ValidationExpression="^([0-9]{4})$" ForeColor="Red"></asp:RegularExpressionValidator>
                                <br />
                                <asp:TextBox ID="TextBoxDate" runat="server" Visible="False"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style56">
                                <br />
                                <br />
                            </td>
                            <td class="auto-style56">
                                <asp:Label ID="LabelAddFlat" runat="server"></asp:Label>
                                <br />
                                <asp:Button ID="ButtonAddFlat" ValidationGroup='valGroup1' runat="server" OnClick="ButtonAddFlat_Click" Text="Add flat" />
                                <asp:Button ID="ButtonClear" runat="server" OnClick="ButtonClear_Click" Text="Clear" />
                            </td>
                            <td colspan="2" id="LabelAnswerNo" class="auto-style56">
                                <asp:RegularExpressionValidator ID="RegularExpressionValidatorRent" ValidationGroup='valGroup1' runat="server" ControlToValidate="TextBoxRent" ValidationExpression="^[1-9][0-9]*(\.[0-9]+)?|0+\.[0-9]*[1-9][0-9]*$." ErrorMessage="Only positive numbers are allowed" ForeColor="Red"></asp:RegularExpressionValidator>
                                <br />
                                <asp:RegularExpressionValidator ID="RegularExpressionValidatorDeposit" ValidationGroup='valGroup1' runat="server" ControlToValidate="TextBoxDeposit" ValidationExpression="^[1-9][0-9]*(\.[0-9]+)?|0+\.[0-9]*[1-9][0-9]*$." ErrorMessage="Only positive numbers are allowed" ForeColor="Red"></asp:RegularExpressionValidator>
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
