<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Register" %>

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
            margin-bottom: 331px;
        }
        .auto-style11 {
            width: 249px;
            height: 362px;
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
        .auto-style50 {
            height: 362px;
            width: 250px;
        }
        .auto-style51 {
            width: 994px;
            height: 353px;
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
        .auto-style76 {
            height: 362px;
        }
        .auto-style77 {
            text-align: left;
            height: 44px;
        }
        .auto-style78 {
            font-size: xx-large;
            text-align: center;
        }
        .auto-style79 {
            height: 58px;
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
            width: 209px;
        }
        .auto-style86 {
            width: 209px;
            text-align: right;
        }
        .auto-style87 {
            text-align: center;
        }
        .auto-style88 {
            width: 209px;
            height: 39px;
        }
        .auto-style89 {
            height: 39px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style21">
              <a href="Register.aspx">      <asp:Image ID="Image2" runat="server" Height="158px" ImageUrl="http://www.homesapp.ca/images/home-5-256.png" Width="190px" /> </a>
                </td>
                <td class="auto-style25">
                    <h1 class="auto-style78">&nbsp;</h1>
                </td>
                <td class="auto-style25" colspan="2">
                    <br />
                </td>
            </tr>
            <tr>
                <td class="auto-style79" colspan="4">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style11">
                </td>
                <td colspan="2" class="auto-style76">
                    <table class="auto-style51">
                        <tr>
                            <td class="auto-style77" colspan="4" style="color: #FF0000">
                    <h1 class="auto-style78">
                        <asp:Label ID="LabelRegister" runat="server" Font-Size="20pt" ForeColor="Black" Text="REGISTER"></asp:Label>
                                </h1>
                            </td>
                            <td class="auto-style87" colspan="2">
                    <asp:Label ID="LabelLogIn" runat="server" Font-Size="20pt" Text="LOG IN" Font-Bold="True"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style77" colspan="4" style="color: #FF0000">&nbsp;</td>
                            <td class="auto-style84"></td>
                            <td></td>
                        </tr>
                        <tr>
                            <td class="auto-style74">Email:</td>
                            <td class="auto-style81">
                                <asp:TextBox ID="TextBoxEmail" runat="server" Width="95%"></asp:TextBox>
                            </td>
                            <td class="auto-style70">Name:</td>
                            <td class="auto-style80">
                                <asp:TextBox ID="TextBoxName" runat="server" Width="95%"></asp:TextBox>
                            </td>
                            <td class="auto-style86">E-mail:</td>
                            <td>
                    <asp:TextBox ID="TextBoxEmailLogin" runat="server" Width="95%"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style74">Password:</td>
                            <td class="auto-style81">
                                <asp:TextBox ID="TextBoxPassword" runat="server" TextMode="Password" Width="95%" ></asp:TextBox>
                            </td>
                            <td class="auto-style70">
                                <asp:Label ID="LabelSurname" runat="server" Text="Surname:"></asp:Label>
                                <br />
                                <asp:Label ID="LabelContactPerson" runat="server" Text="Contact Person:" Visible="False"></asp:Label>
                            </td>
                            <td class="auto-style80">
                                <asp:TextBox ID="TextBoxSurnameAndContact" runat="server" Width="95%" ></asp:TextBox>
                            </td>
                            <td class="auto-style86">Password:</td>
                            <td>
                    <asp:TextBox ID="TextBoxPasswordLogin" runat="server" TextMode="Password" Width="95%" ></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style74">Confirm Password:</td>
                            <td class="auto-style81">
                                <asp:TextBox ID="TextBoxConfirmPassword" runat="server" TextMode="Password" Width="95%"></asp:TextBox>
                            </td>
                            <td class="auto-style70">Address:</td>
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
                            <td class="auto-style74">You are a:</td>
                            <td class="auto-style81">
                                <asp:DropDownList ID="DropDownListType" runat="server" OnSelectedIndexChanged="DropDownListType_SelectedIndexChanged" >
                                    <asp:ListItem Value="0">Please Select</asp:ListItem>
                                    <asp:ListItem Value="Student">Student</asp:ListItem>
                                    <asp:ListItem Value="Landlord">Landlord</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                            <td class="auto-style70">Post Code:</td>
                            <td class="auto-style80">
                                <asp:TextBox ID="TextBoxPostCode" runat="server" Width="95%"></asp:TextBox>
                            </td>
                            <td colspan="2" rowspan="2">
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
                            <td class="auto-style70">City:</td>
                            <td class="auto-style80">
                                <asp:TextBox ID="TextBoxCity" runat="server" Width="95%"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style70">Country:</td>
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
                            <td class="auto-style70">Phone:</td>
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
                </td>
                <td class="auto-style50"></td>
            </tr>
            </table>
    <div class="auto-style36">
    
    </div>
    </form>
</body>
</html>
