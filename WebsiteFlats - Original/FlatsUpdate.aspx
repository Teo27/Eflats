<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FlatsUpdate.aspx.cs" Inherits="FlatsUpdate" %>

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
            width: 643px;
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
            height: 27px;
        }
        .auto-style52 {
            height: 27px;
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
        .auto-style55 {
            height: 192px;
            width: 498px;
        }
        .auto-style56 {
            height: 27px;
            width: 498px;
            text-align: right;
        }
        .auto-style57 {
            width: 249px;
            height: 30px;
        }
        .auto-style58 {
            height: 30px;
            width: 498px;
            text-align: right;
        }
        .auto-style59 {
            height: 30px;
        }
        .auto-style60 {
            width: 249px;
            height: 118px;
        }
        .auto-style61 {
            height: 118px;
            width: 498px;
            text-align: right;
        }
        .auto-style62 {
            height: 118px;
        }
        .auto-style64 {
            height: 27px;
            width: 643px;
        }
        .auto-style65 {
            height: 30px;
            width: 156px;
        }
        .auto-style66 {
            width: 288px;
            height: 30px;
            text-align: right;
        }
        .auto-style67 {
            height: 27px;
            width: 156px;
        }
        .auto-style68 {
            height: 118px;
            width: 156px;
        }
        .auto-style69 {
            height: 27px;
            width: 643px;
            text-align: right;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        &nbsp;<table class="auto-style1">
            <tr>
                <td class="auto-style21">
                 <a href="MainPageLandlord.aspx">   <asp:Image ID="Image3" runat="server" Height="158px" ImageUrl="http://www.homesapp.ca/images/home-5-256.png" Width="190px" /> </a>
                </td>
                <td class="auto-style55">&nbsp;</td>
                <td class="auto-style25" colspan="3"></td>
                <td class="auto-style54">
                    <a href="EditProfile.aspx"><asp:Label ID="WelcomeLabel" runat="server" Text="Welcome " ></asp:Label></a>
                    <br />
                </td>
                <td class="auto-style45">
                    <asp:Button ID="LogOut0" runat="server" OnClick="LogOut_Click" Text="Log Out" BackColor="#3497D9" CssClass="btn" ForeColor="White" />
                </td>
            </tr>
            <tr>
                <td class="auto-style53" colspan="7">
                    <asp:Button ID="ButtonHome" runat="server" Text="Home" BackColor="#3497D9" OnClick="ButtonHome_Click" Width="200px" CssClass="btn" ForeColor="White" />
                    <asp:Button ID="ButtonFlats0" runat="server" Text="Flats" BackColor="#3497D9" OnClick="ButtonFlats_Click" Width="200px" CssClass="btn" ForeColor="White" />
                    <asp:Button ID="ButtonProfile0" runat="server" Text="Edit Profile" BackColor="#3497D9" OnClick="ButtonProfile_Click" Width="200px" CssClass="btn" ForeColor="White" />
                </td>
            </tr>
            <tr>
                <td class="auto-style57" rowspan="2">
                </td>
                <td class="auto-style58">
                    <asp:Label ID="LabelChooseFlat" runat="server" Text="Please choose your apartment:"></asp:Label>
                </td>
                <td class="auto-style65">
                    <asp:DropDownList ID="DropDownList1" runat="server" DataTextField="Address" DataValueField="Id" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                    </asp:DropDownList>
                    <br />
                </td>
                <td class="auto-style66" colspan="2" rowspan="2">
                    <asp:Label ID="LabelAvailable" runat="server" Text="Apartment is available from:"></asp:Label>
                </td>
                <td class="auto-style59" rowspan="2">
                    <asp:Calendar ID="Calendar1" runat="server" OnDayRender="Calendar1_DayRender"></asp:Calendar>
                </td>
                <td class="auto-style59" rowspan="2"></td>
            </tr>
            <tr>
                <td class="auto-style58">
                    <asp:Label ID="LabelApartmentId" runat="server" Text="Apartment ID:"></asp:Label>
                </td>
                <td class="auto-style65">
                    <asp:Label ID="LabelId" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style51">
                </td>
                <td class="auto-style56">
                    <asp:Label ID="LabelRent" runat="server" Text="Please enter new rent amount:"></asp:Label>
                </td>
                <td class="auto-style67">
                    <asp:TextBox ID="TextBoxRent" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style69" colspan="2">
                    <asp:Label ID="LabelStatus" runat="server"></asp:Label>
                </td>
                <td class="auto-style52">
                    <asp:Label ID="LabelStatusUpdated" runat="server" Visible="False"></asp:Label>
                    <asp:Button ID="ButtonReopen" runat="server" OnClick="ButtonReopen_Click" Text="Reopen appartment" />
                </td>
                <td class="auto-style52"></td>
            </tr>
            <tr>
                <td class="auto-style51">
                </td>
                <td class="auto-style56">
                    <asp:Label ID="LabelDeposit" runat="server" Text="Please enter new deposit amount:"></asp:Label>
                </td>
                <td class="auto-style64" colspan="3">
                    <asp:TextBox ID="TextBoxDeposit" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style52">
                    &nbsp;</td>
                <td class="auto-style52"></td>
            </tr>
            <tr>
                <td class="auto-style51">
                </td>
                <td class="auto-style56">
                    <asp:Label ID="LabelDescription" runat="server" Text="Please enter new description:"></asp:Label>
                </td>
                <td class="auto-style64" colspan="3">
                    <asp:TextBox ID="TextBoxDescription" runat="server" Height="161px" MaxLength="500" TextMode="MultiLine" Width="513px"></asp:TextBox>
                </td>
                <td class="auto-style52">
                    &nbsp;</td>
                <td class="auto-style52"></td>
            </tr>
            <tr>
                <td class="auto-style60">
                    </td>
                <td class="auto-style61">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorRent" ValidationGroup="UpdateFlat" runat="server" ControlToValidate="TextBoxRent" ErrorMessage="Please enter a rent amount" ForeColor="Red"></asp:RequiredFieldValidator>
                    <br />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorDeposit" ValidationGroup="UpdateFlat" runat="server" ControlToValidate="TextBoxDeposit" ErrorMessage="Please enter a deposit amount" ForeColor="Red"></asp:RequiredFieldValidator>
                    <br />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorDescription" ValidationGroup="UpdateFlat" runat="server" ControlToValidate="TextBoxDescription" ErrorMessage="Please enter a description" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
                <td class="auto-style68">
                    <asp:Label ID="LabelUpdated" runat="server" Visible="False"></asp:Label>
                    <br />
                    <asp:Button ID="ButtonUpdate" ValidationGroup = "UpdateFlat" runat="server" OnClick="ButtonUpdate_Click" Text="Update" />
                </td>
                <td class="auto-style62">
                                <asp:RegularExpressionValidator ID="RegularExpressionValidatorDeposit" ValidationGroup='valGroup1' runat="server" ControlToValidate="TextBoxDeposit" ValidationExpression="^[1-9][0-9]*(\.[0-9]+)?|0+\.[0-9]*[1-9][0-9]*$." ErrorMessage="Only positive numbers are allowed"></asp:RegularExpressionValidator>
                            <br />
                                <asp:RegularExpressionValidator ID="RegularExpressionValidatorDeposit0" ValidationGroup='valGroup1' runat="server" ControlToValidate="TextBoxRent" ValidationExpression="^[1-9][0-9]*(\.[0-9]+)?|0+\.[0-9]*[1-9][0-9]*$." ErrorMessage="Only positive numbers are allowed"></asp:RegularExpressionValidator>
                </td>
                <td class="auto-style62" colspan="2">
                    &nbsp;</td>
                <td class="auto-style62"></td>
            </tr>
            </table>
    <div class="auto-style36">
    
    </div>
    </form>
</body>
</html>
