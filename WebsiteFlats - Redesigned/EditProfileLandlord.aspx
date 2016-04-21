﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="EditProfileLandlord.aspx.cs" Inherits="EditProfile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Edit Profile</title>

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
        .auto-style72 {
            text-align: center;
            height: 45px;
        }
        .auto-style77 {
            text-align: left;
            height: 44px;
        }
        .auto-style78 {
            font-size: xx-large;
            text-align: center;
        }
        .auto-style82 {
            text-align: center;
            height: 45px;
            width: 187px;
        }
        .auto-style83 {
            text-align: center;
            height: 45px;
            width: 116px;
        }
                  
        .auto-style86 {
            text-align: right;
            height: 44px;
        }
        .auto-style87 {
            height: 44px;
        }
       
      
        </style>
</head>
<body>
         <form id="form1" runat="server">
   
              <nav class="navbar navbar-default ">
        <div class="container-fluid">

            <%-- STUFF ON LEFT SIDE --%>

            <div class="navbar-header pull-left">

                <a class="pull-left" href="MainPageLandlord.aspx">
                    <img src="images/home.png" height="48px" width="48px" /></a>

                <%-- LINKS WITH ID TO CONNECT WITH PHONE MENU --%>


                <ul class="nav navbar-nav collapse navbar-collapse" id="myNavbar">
                    <li><a href="MainPageLandlord.aspx">Home</a></li>


                    <li class="dropdown">
                    <a class="dropdown-toggle" data-toggle="dropdown" href="#"> Flats <span class="caret"></span></a>
                        <ul class="dropdown-menu">
                          <li><a  href="FlatsAdd.aspx">Add Flat</a></li>
                          <li><a  href="FlatsUpdate.aspx">Update Flat</a></li>
                          <li class="disabled"><a href="#">Delete Flat</a></li>
                          <li><a href="Offers.aspx">Offers</a></li>
                        </ul>
                    </li>
                    <li><a href="#">Flats</a></li>
                    <li class="active"><a href="EditProfileLandlord.aspx">Edit Profile</a></li>
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




 
      
                    <table  style="margin: auto;">
                        <tr>
                            <td class="auto-style77" colspan="4" style="color: #FF0000">
                    <h1 class="auto-style78">
                        <asp:Label ID="Label1" runat="server" ForeColor="Black" Text="EDIT PROFILE"></asp:Label>
                                </h1>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style86" colspan="2">Name:&nbsp;</td>
                            <td class="auto-style87" colspan="2">
                                <asp:TextBox ID="TextBoxName" runat="server" Width="65%"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ValidationGroup="GroupEdit" runat="server" ControlToValidate="TextBoxName" ErrorMessage="Field required" ForeColor="Red"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style86" colspan="2">
                                <asp:Label ID="LabelContactPerson" runat="server" Text="Contact Person:"></asp:Label>&nbsp;
                            </td>
                            <td class="auto-style87" colspan="2">
                                <asp:TextBox ID="TextBoxContactAndSurname" runat="server" Width="65%"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ValidationGroup="GroupEdit" runat="server" ControlToValidate="TextBoxContactAndSurname" ErrorMessage="Field required" ForeColor="Red"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style86" colspan="2">Address:&nbsp;</td>
                            <td class="auto-style87" colspan="2">
                                <asp:TextBox ID="TextBoxAddress" runat="server" Width="65%"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ValidationGroup="GroupEdit" runat="server" ControlToValidate="TextBoxAddress" ErrorMessage="Field required" ForeColor="Red"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style86" colspan="2">Post Code:&nbsp;</td>
                            <td class="auto-style87" colspan="2">
                                <asp:TextBox ID="TextBoxPostCode" runat="server" Width="65%"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" ValidationGroup="GroupEdit" runat="server" ControlToValidate="TextBoxPostCode" ErrorMessage="Field required" ForeColor="Red"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style86" colspan="2">City:&nbsp;</td>
                            <td class="auto-style87" colspan="2">
                                <asp:TextBox ID="TextBoxCity" runat="server" Width="65%"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" ValidationGroup="GroupEdit" runat="server" ControlToValidate="TextBoxCity" ErrorMessage="Field required" ForeColor="Red"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style86" colspan="2">Country:&nbsp;</td>
                            <td class="auto-style87" colspan="2">
                                <asp:TextBox ID="TextBoxCountry" runat="server" Width="65%"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" ValidationGroup="GroupEdit"  runat="server" ControlToValidate="TextBoxCountry" ErrorMessage="Field required" ForeColor="Red"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style86" colspan="2">Phone:&nbsp;</td>
                            <td class="auto-style87" colspan="2">
                                <asp:TextBox ID="TextBoxPhone" runat="server" Width="65%"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" ValidationGroup="GroupEdit" runat="server" ControlToValidate="TextBoxPhone" ErrorMessage="Field required" ForeColor="Red"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style83">
                                &nbsp;</td>
                            <td class="auto-style72">
                                &nbsp;</td>
                            <td class="auto-style82">
                                <asp:Label ID="LabelEditProfile" runat="server"></asp:Label>
                                <asp:Button ID="ButtonEdit" ValidationGroup="GroupEdit" runat="server" OnClick="ButtonEdit_Click" Text="Edit" style="height: 29px" />
                                <input id="ButtonClear" type="reset" value="Undo" /></td>
                            <td class="auto-style82">
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
