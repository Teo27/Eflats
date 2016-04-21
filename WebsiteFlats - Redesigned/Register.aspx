<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Register/Log In</title>

    <meta http-equiv="X-UA_Compatible" content="IE=edge" />

    <meta name="viewport" content="width=device-width, initial-scale=1" />

    <link rel="stylesheet" type="text/css" href="css/bootstrap.css" />


    <style type="text/css">


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
            width: 93px;
            text-align: right;
            height: 44px;
        }
        .auto-style72 {
            text-align: center;
            height: 39px;
        }
        .auto-style74 {
            width: 205px;
            text-align: right;
            height: 44px;
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
            width: 140px;
            height: 44px;
        }
        .auto-style84 {
            width: 167px;
        }
        .auto-style86 {
            width: 167px;
            text-align: right;
        }
        .auto-style87 {
            text-align: center;
        }
        .auto-style88 {
            width: 167px;
            height: 39px;
        }
        .auto-style89 {
            height: 39px;
        }

                .navbar-collapse.in,
        .navbar-collapse.collapsing {
            clear: left;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">

    <nav class="navbar navbar-default navbar-fixed-top">
        <div class="container-fluid">

            <div class="navbar-header pull-left">

                <a class="pull-left" href="StartPage.aspx">
                    <img src="images/home.png" height="48px" width="48px" /></a>

                <ul class="nav navbar-nav collapse navbar-collapse" id="myNavbar">
                    <li class="active"><a href="Register.aspx">Login/Register</a></li>
                    <li class="disabled"><a href="#">FAQ</a></li>
                    <li class="disabled"><a href="#">About us</a></li>
                </ul>

                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target="#myNavbar">
                    <span class="sr-only"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>

                </button>

            </div>

            <div class="navbar-header pull-right">

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

            </div>
        </div>
    </nav>



    
       
                    <table style="margin: 50px auto">
                        <tr>
                            <td class="auto-style77" colspan="4" style="color: #FF0000">
                    <h1 class="auto-style78">
                        <asp:Label ID="LabelRegister" runat="server" Font-Size="20pt" ForeColor="Black" Text="REGISTER" Font-Bold="True"></asp:Label>
                                </h1>
                            </td>
                            <td class="auto-style87" colspan="2">
                    <asp:Label ID="LabelLogIn" runat="server" Font-Size="20pt" Text="LOG IN" Font-Bold="True" ForeColor="Black"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style77" colspan="4" style="color: #FF0000">&nbsp;</td>
                            <td class="auto-style84"></td>
                            <td></td>
                        </tr>
                        <tr>
                            <td class="auto-style74">Email:&nbsp;</td>
                            <td class="auto-style81">
                                <asp:TextBox ID="TextBoxEmail" runat="server" Width="95%"></asp:TextBox>
                            </td>
                            <td class="auto-style70">Name:&nbsp;</td>
                            <td class="auto-style80">
                                <asp:TextBox ID="TextBoxName" runat="server" Width="95%"></asp:TextBox>
                            </td>
                            <td class="auto-style86">E-mail:&nbsp;</td>
                            <td>
                    <asp:TextBox ID="TextBoxEmailLogin" runat="server" Width="95%"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style74">Password:&nbsp;</td>
                            <td class="auto-style81">
                                <asp:TextBox ID="TextBoxPassword" runat="server" TextMode="Password" Width="95%" ></asp:TextBox>
                            </td>
                            <td class="auto-style70">
                                <asp:Label ID="LabelSurname" runat="server" Text="Surname:"></asp:Label>&nbsp;
                                <br />
                                <asp:Label ID="LabelContactPerson" runat="server" Text="Contact Person:" Visible="False"></asp:Label>&nbsp;
                            </td>
                            <td class="auto-style80">
                                <asp:TextBox ID="TextBoxSurnameAndContact" runat="server" Width="95%" ></asp:TextBox>
                            </td>
                            <td class="auto-style86">Password:&nbsp;</td>
                            <td>
                    <asp:TextBox ID="TextBoxPasswordLogin" runat="server" TextMode="Password" Width="95%" ></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style74">Confirm Password:&nbsp;</td>
                            <td class="auto-style81">
                                <asp:TextBox ID="TextBoxConfirmPassword" runat="server" TextMode="Password" Width="95%"></asp:TextBox>
                            </td>
                            <td class="auto-style70">Address:&nbsp;</td>
                            <td class="auto-style80">
                                <asp:TextBox ID="TextBoxAddress" runat="server" Width="95%"></asp:TextBox>
                            </td>
                            <td class="auto-style84">
                                <asp:Label ID="LabelNotCorrect" runat="server" ForeColor="Red" Text="Email or password incorrect" Visible="False"></asp:Label>
                            </td>
                            <td>
                    <asp:Button ID="ButtonLogin" ValidationGroup='valGroup2' runat="server" Text="Login" OnClick="ButtonLogin_Click" />
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style74">You are a:&nbsp;</td>
                            <td class="auto-style81">
                                <asp:DropDownList ID="DropDownListType" runat="server" OnSelectedIndexChanged="DropDownListType_SelectedIndexChanged" >
                                    <asp:ListItem Value="0">Please Select</asp:ListItem>
                                    <asp:ListItem Value="Student">Student</asp:ListItem>
                                    <asp:ListItem Value="Landlord">Landlord</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                            <td class="auto-style70">Post Code:&nbsp;</td>
                            <td class="auto-style80">
                                <asp:TextBox ID="TextBoxPostCode" runat="server" Width="95%"></asp:TextBox>
                            </td>
                            <td rowspan="2" colspan="2">
                                <asp:RegularExpressionValidator ValidationGroup='valGroup2' ID="RegularExpressionValidatorEmail" runat="server" ControlToValidate="TextBoxEmailLogin" ErrorMessage="Please enter a proper email" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                                <br />
                    <asp:RequiredFieldValidator ValidationGroup='valGroup2' ID="RequiredFieldValidatorPassword" runat="server" ControlToValidate="TextBoxPasswordLogin" ErrorMessage="Please enter your password" ForeColor="Red"></asp:RequiredFieldValidator>
                                <br />
                                <asp:RequiredFieldValidator ValidationGroup='valGroup2' ID="RequiredFieldValidatorEmailLogin" runat="server" ControlToValidate="TextBoxEmailLogin" ErrorMessage="Please enter an email" ForeColor="Red"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2" rowspan="3">
                                <asp:RequiredFieldValidator ValidationGroup='valGroup1' ID="RequiredFieldValidatorEmailRegister" runat="server" ControlToValidate="TextBoxEmail" ErrorMessage="Please enter an email" ForeColor="Red"></asp:RequiredFieldValidator>
                                <br />
                                <asp:RegularExpressionValidator ValidationGroup='valGroup1' ID="RegularExpressionValidator2" runat="server" ControlToValidate="TextBoxEmail" ErrorMessage="Please enter a proper email" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                                <br />
                                <asp:RequiredFieldValidator ValidationGroup='valGroup1' ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBoxPassword" ErrorMessage="Please enter a password" ForeColor="Red"></asp:RequiredFieldValidator>
                                <br />
                                <asp:CompareValidator ValidationGroup='valGroup1' ID="CompareValidator1" runat="server" ControlToCompare="TextBoxPassword" ControlToValidate="TextBoxConfirmPassword" ErrorMessage="Please enter the same password" ForeColor="Red"></asp:CompareValidator>
                                <br />
                                <asp:RequiredFieldValidator ValidationGroup='valGroup1' ID="RequiredFieldValidator1" runat="server" ControlToValidate="DropDownListType" ErrorMessage="Please choose your type" ForeColor="Red" InitialValue="0"></asp:RequiredFieldValidator>
                                <br />
                                <asp:RegularExpressionValidator ValidationGroup='valGroup1' ID="RegularExpressionValidator3" runat="server" ControlToValidate="TextBoxPhone" ErrorMessage="Please enter a proper number" ForeColor="Red" ValidationExpression="^([0-9]{8,12})$"></asp:RegularExpressionValidator>
                                <br />
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ControlToValidate="TextBoxPassword" ErrorMessage="Password must contain at least 7 characters and a digit" ForeColor="Red" ValidationExpression="^.*(?=.{8,})(?=.*[\d]).*$"></asp:RegularExpressionValidator>
                            </td>
                            <td class="auto-style70">City:&nbsp;</td>
                            <td class="auto-style80">
                                <asp:TextBox ID="TextBoxCity" runat="server" Width="95%"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style70">Country:&nbsp;</td>
                            <td class="auto-style80">
                                <asp:TextBox ID="TextBoxCountry" runat="server" Width="95%"></asp:TextBox>
                            </td>
                            <td class="auto-style84" rowspan="2">
                                <asp:RequiredFieldValidator ID="RequiredFieldName" ValidationGroup='valGroup1' runat="server" ControlToValidate="TextBoxName" ErrorMessage="Please enter your name" ForeColor="Red"></asp:RequiredFieldValidator>
                                <br />
                                <asp:RequiredFieldValidator ID="RequiredFieldSurname" ValidationGroup='valGroup1' runat="server" ControlToValidate="TextBoxSurnameAndContact" ErrorMessage="Please enter your surname" ForeColor="Red"></asp:RequiredFieldValidator>
                                <br />
                                <asp:RequiredFieldValidator ID="RequiredFieldAdress" ValidationGroup='valGroup1' runat="server" ControlToValidate="TextBoxAddress" ErrorMessage="Please enter your address" ForeColor="Red"></asp:RequiredFieldValidator>
                                <br />
                                <asp:RequiredFieldValidator ID="RequiredFieldPostCode"  ValidationGroup='valGroup1' runat="server" ControlToValidate="TextBoxPostCode" ErrorMessage="Please enter your post code" ForeColor="Red"></asp:RequiredFieldValidator>
                            </td>
                            <td rowspan="2">
                                <asp:RequiredFieldValidator ID="RequiredFieldCity" ValidationGroup='valGroup1' runat="server" ControlToValidate="TextBoxCity" ErrorMessage="Please enter your city" ForeColor="Red"></asp:RequiredFieldValidator>
                                <br />
                                <asp:RequiredFieldValidator ID="RequiredFieldCountry" ValidationGroup='valGroup1' runat="server" ControlToValidate="TextBoxCountry" ErrorMessage="Please enter your country" ForeColor="Red"></asp:RequiredFieldValidator>
                                <br />
                                <asp:RequiredFieldValidator ID="RequiredFieldPhone" ValidationGroup='valGroup1' runat="server" ControlToValidate="TextBoxPhone" ErrorMessage="Please enter your phone" ForeColor="Red"></asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style70">Phone:&nbsp;</td>
                            <td class="auto-style80">
                                <asp:TextBox ID="TextBoxPhone" runat="server" Width="95%"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style72" colspan="2">
                                <asp:Button ID="ButtonRegister" ValidationGroup='valGroup1' runat="server" OnClick="ButtonRegister_Click" Text="Register" />
                                <asp:Button ID="ButtonClear" runat="server" OnClick="ButtonClear_Click" Text="Clear" />
                            </td>
                            <td class="auto-style72" colspan="2">
                                <asp:Label ID="LabelRegistration" runat="server"></asp:Label>
                                <br />
                            </td>
                            <td class="auto-style88"></td>
                            <td class="auto-style89"></td>
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
