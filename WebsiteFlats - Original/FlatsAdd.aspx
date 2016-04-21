<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FlatsAdd.aspx.cs" Inherits="FlatsAdd" %>

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
            width: 1432px;
            height: 439px;
        }
        .auto-style21 {
            width: 238px;
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
        .auto-style42 {
            width: 100%;
        }
        .auto-style43 {
            width: 265px;
        }
        .auto-style45 {
            width: 176px;
            text-align: center;
        }
        .auto-style50 {
            width: 239px;
            height: 192px;
        }
        .auto-style51 {
            width: 238px;
        }
        .auto-style54 {
            width: 175px;
            text-align: right;
        }
        .auto-style56 {
            height: 26px;
        }
        .auto-style57 {
            text-align: center;
        }
        .auto-style59 {
            width: 265px;
            text-align: center;
        }
        .auto-style60 {
            width: 239px;
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
                  <a href="MainPageLandlord.aspx">  <asp:Image ID="Image3" runat="server" Height="158px" ImageUrl="http://www.homesapp.ca/images/home-5-256.png" Width="190px" /></a>
                </td>
                <td class="auto-style25"></td>
                <td class="auto-style60">
                    <br />
                    <a href="EditProfile.aspx"><asp:Label ID="WelcomeLabel" runat="server" Text="Welcome " ></asp:Label></a>
                </td>
                <td class="auto-style50">
                    <asp:Button ID="LogOut" runat="server" OnClick="LogOut_Click" Text="Log Out" BackColor="#3497D9" CssClass="btn" ForeColor="White" />
                    <br />
                </td>
            </tr>
            <tr>
                <td class="auto-style57" colspan="4">
                    <asp:Button ID="ButtonHome" runat="server" Text="Home" BackColor="#3497D9" OnClick="ButtonHome_Click" Width="200px" CssClass="btn" ForeColor="White" />
                    <asp:Button ID="ButtonFlats0" runat="server" Text="Flats" BackColor="#3497D9" OnClick="ButtonFlats_Click" Width="200px" CssClass="btn" ForeColor="White" />
                    <asp:Button ID="ButtonProfile0" runat="server" Text="Edit Profile" BackColor="#3497D9" OnClick="ButtonProfile_Click" Width="200px" CssClass="btn" ForeColor="White" />
                </td>
            </tr>
            <tr>
                <td class="auto-style51">
                    &nbsp;</td>
                <td colspan="2">
                    <br />
                    <br />
                    <table class="auto-style42">
                        <tr>
                            <td class="auto-style54">Type</td>
                            <td class="auto-style43">
                                <asp:DropDownList ID="DropdownType" runat="server" Width="95%">
                                    <asp:ListItem Value="0">Please choose</asp:ListItem>
<asp:ListItem Value="Room">Room</asp:ListItem>
                                    <asp:ListItem Value="Apartment">Apartment</asp:ListItem>
                                    <asp:ListItem Value="House">House</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                            <td class="auto-style45" rowspan="6">Available</td>
                            <td rowspan="6">
                                <asp:Calendar ID="Calendar1" runat="server"  OnDayRender="Calendar1_DayRender" OnSelectionChanged="Calendar1_SelectionChanged">
                                </asp:Calendar>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style54">Address</td>
                            <td class="auto-style43">
                                <asp:TextBox ID="TextBoxAddress" runat="server" Width="95%"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style54">Post Code</td>
                            <td class="auto-style43">
                                <asp:TextBox ID="TextBoxPostCode" runat="server" Width="95%"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style54">Rent</td>
                            <td class="auto-style43">
                                <asp:TextBox ID="TextBoxRent" runat="server" Width="95%"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style54">Deposit</td>
                            <td class="auto-style43">
                                <asp:TextBox ID="TextBoxDeposit" runat="server" Width="95%"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style54">City</td>
                            <td class="auto-style43">
                                <asp:TextBox ID="TextBoxCity" runat="server" Width="95%"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style54">
                                Description</td>
                            <td class="auto-style59">
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:TextBox ID="TextBoxDescription" runat="server" maxlength="500" wrap="true" TextMode="MultiLine" Height="100px" Width="250px"></asp:TextBox>
                            </td>
                            <td>
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
                            </td>
                            <td>
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
                    <br />
                    <br />
                    <br />
                    <br />
                </td>
            </tr>
            </table>
    <div class="auto-style36">
    
    </div>
    </form>
</body>
</html>
