<%@ Page Language="C#" AutoEventWireup="true" CodeFile="EditProfileStudent.aspx.cs" Inherits="EditProfileStudent" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Edit Profile</title>

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
       
        .auto-style70 {
            width: 116px;
            text-align: right;
            height: 44px;
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
        .auto-style80 {
            width: 145px;
            height: 44px;
        }
        .auto-style81 {
            width: 187px;
            height: 44px;
        }
        .auto-style83 {
            text-align: center;
            height: 45px;
            width: 116px;
        }
                 
          
        .auto-style84 {
            width: 187px;
            height: 44px;
            text-align: right;
        }
                 
          
        </style>
</head>
<body>
    <form id="form1" runat="server">
    <nav class="navbar navbar-default navbar-fixed-top">
        <div class="container-fluid">

            <div class="navbar-header pull-left">

                <a class="pull-left" href="MainPageStudent.aspx">
                    <img src="images/home.png" height="48px" width="48px" /></a>

                <ul class="nav navbar-nav collapse navbar-collapse" id="myNavbar">
                    <li><a href="MainPageStudent.aspx"><b class="cream">Home</b></a></li>
                    <li><a href="WishList.aspx"><b class="cream">Wish List</b></a></li>
                    <li class="active"><a href="EditProfileStudent.aspx"><b>Edit Profile</b></a></li>
                    <li class="disabled inactive"><a href="#"><b class="cream">FAQ</b></a></li>
                    <li class="disabled inactive"><a href="#"><b class="cream">About us</b></a></li>
                </ul>

                &nbsp;
                &nbsp;
                &nbsp;

                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target="#myNavbar">
                    <span class="sr-only"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>

                </button>


            </div>

            <div class="navbar-header pull-right">

                <a href="EditProfileStudent.aspx"><asp:Label class="hidden-xs cream" Font-Bold="True" ID="WelcomeLabel" runat="server" Text="Welcome " style="text-decoration: none;"></asp:Label></a>
                            
                <asp:Button ID="LogOut" runat="server" OnClick="LogOut_Click" Text="Log Out" CssClass="btn btn-sm button2" ForeColor="#9f4e3e" Font-Bold="True" />
                    
                <button class="btn navbar-btn btn-sm dropdown-toggle button2" type="button" data-toggle="dropdown" aria-haspopup="true" aria-expanded="true"><b>Language </b><span class="caret"></span></button>

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
                            <td class="auto-style77" colspan="5" style="color: #FF0000">
                    <h1 class="auto-style78">
                        <asp:Label ID="Label1" runat="server" ForeColor="#9F4E3E" Text="EDIT PROFILE"></asp:Label>
                                </h1>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style70">Name:&nbsp;</td>
                            <td class="auto-style80">
                                <asp:TextBox ID="TextBoxName" runat="server" Width="95%"></asp:TextBox>
                            </td>
                            <td class="auto-style80">
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ValidationGroup="GroupEdit" runat="server" ControlToValidate="TextBoxName" ErrorMessage="Field required" ForeColor="Red"></asp:RequiredFieldValidator>
                            </td>
                            <td class="auto-style84">
                                <asp:Label ID="LabelChildren" runat="server" Text="Number of children:"></asp:Label>&nbsp;
                            </td>
                            <td class="auto-style80">
                                <asp:TextBox ID="TextBoxChildren" runat="server" TextMode="Number"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style70">
                                <asp:Label ID="LabelSurname" runat="server" Text="Surname:"></asp:Label>&nbsp;
                                
                            </td>
                            <td class="auto-style80">
                                <asp:TextBox ID="TextBoxContactAndSurname" runat="server" Width="95%"></asp:TextBox>
                            </td>
                            <td class="auto-style80">
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ValidationGroup="GroupEdit" runat="server" ControlToValidate="TextBoxContactAndSurname" ErrorMessage="Field required" ForeColor="Red"></asp:RequiredFieldValidator>
                            </td>
                            <td class="auto-style84">
                                <asp:Label ID="LabelPets" runat="server" Text="Do you have any pets?"></asp:Label>&nbsp;
                            </td>
                            <td class="auto-style80">
                                <asp:CheckBox ID="CheckBoxPets" runat="server"  />
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style70">Address:&nbsp;</td>
                            <td class="auto-style80">
                                <asp:TextBox ID="TextBoxAddress" runat="server" Width="95%"></asp:TextBox>
                            </td>
                            <td class="auto-style80">
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ValidationGroup="GroupEdit" runat="server" ControlToValidate="TextBoxAddress" ErrorMessage="Field required" ForeColor="Red"></asp:RequiredFieldValidator>
                            </td>
                            <td class="auto-style84">
                                <asp:Label ID="LabelDisability" runat="server" Text="Do you have a disability?"></asp:Label>&nbsp;
                            </td>
                            <td class="auto-style80">
                                <asp:CheckBox ID="CheckBoxDisability" runat="server" />
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style70">Post Code:&nbsp;</td>
                            <td class="auto-style80">
                                <asp:TextBox ID="TextBoxPostCode" runat="server" Width="95%"></asp:TextBox>
                            </td>
                            <td class="auto-style80">
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" ValidationGroup="GroupEdit" runat="server" ControlToValidate="TextBoxPostCode" ErrorMessage="Field required" ForeColor="Red"></asp:RequiredFieldValidator>
                            </td>
                            <td class="auto-style84">
                                <asp:Label ID="LabelChildren0" runat="server" Text="Number of cohabitors:"></asp:Label>&nbsp;
                            </td>
                            <td class="auto-style80">
                                <asp:TextBox ID="TextBoxCohabitors" runat="server" TextMode="Number"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style70">City:&nbsp;</td>
                            <td class="auto-style80">
                                <asp:TextBox ID="TextBoxCity" runat="server" Width="95%"></asp:TextBox>
                            </td>
                            <td class="auto-style80">
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" ValidationGroup="GroupEdit" runat="server" ControlToValidate="TextBoxCity" ErrorMessage="Field required" ForeColor="Red"></asp:RequiredFieldValidator>
                            </td>
                            <td class="auto-style81">
                                &nbsp;</td>
                            <td class="auto-style80">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style70">Country:&nbsp;</td>
                            <td class="auto-style80">
                                <asp:TextBox ID="TextBoxCountry" runat="server" Width="95%"></asp:TextBox>
                            </td>
                            <td class="auto-style80">
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" ValidationGroup="GroupEdit" runat="server" ControlToValidate="TextBoxCountry" ErrorMessage="Field required" ForeColor="Red"></asp:RequiredFieldValidator>
                            </td>
                            <td class="auto-style81">
                                &nbsp;</td>
                            <td class="auto-style80">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style70">Phone:&nbsp;</td>
                            <td class="auto-style80">
                                <asp:TextBox ID="TextBoxPhone" runat="server" Width="95%"></asp:TextBox>
                            </td>
                            <td class="auto-style80">
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" ValidationGroup="GroupEdit" runat="server" ControlToValidate="TextBoxPhone" ErrorMessage="Field required" ForeColor="Red"></asp:RequiredFieldValidator>
                            </td>
                            <td class="auto-style81">
                                <asp:RegularExpressionValidator ValidationGroup='GroupEdit' ID="RegularExpressionValidator3" runat="server" ControlToValidate="TextBoxPhone" ErrorMessage="Please enter a proper number" ForeColor="Red" ValidationExpression="^([0-9]{8,12})$"></asp:RegularExpressionValidator>
                                </td>
                            <td class="auto-style80">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style83">
                                &nbsp;</td>
                            <td class="auto-style72" colspan="3">
                                <asp:Label ID="LabelProfileEdit" runat="server"></asp:Label>
                                <br />
                                <asp:Button ID="ButtonEdit" ValidationGroup="GroupEdit" runat="server" OnClick="ButtonEdit_Click" Text="Edit" style="height: 29px" class="btn btn-sm button1"/>
                                <input id="ButtonClear" type="reset" value="Undo" class="btn btn-sm button1"/></td>
                            <td class="auto-style72">
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
