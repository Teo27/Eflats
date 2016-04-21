<%@ Page Language="C#" AutoEventWireup="true" CodeFile="EditProfileStudent.aspx.cs" Inherits="EditProfileStudent" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
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
            width: 116px;
            text-align: right;
            height: 44px;
        }
        .auto-style72 {
            text-align: center;
            height: 45px;
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
            width: 187px;
            height: 44px;
        }
        .auto-style83 {
            text-align: center;
            height: 45px;
            width: 116px;
        }
        .auto-style85 {
            height: 192px;
            text-align: right;
        }      
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
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style21">
              <a href="MainPageStudent.aspx">      <asp:Image ID="Image2" runat="server" Height="158px" ImageUrl="http://www.homesapp.ca/images/home-5-256.png" Width="190px" /> </a>
                </td>
                <td class="auto-style85">
                    
                    <a href="EditProfile.aspx"><asp:Label ID="WelcomeLabel" runat="server" Text="Welcome " ></asp:Label></a>
                    
                </td>
                <td class="auto-style25" colspan="2">
                    <asp:Button ID="LogOut" runat="server" OnClick="LogOut_Click" Text="Log Out" BackColor="#3497D9" CssClass="btn" ForeColor="White" />
                    <br />
                </td>
            </tr>
            <tr>
                <td class="auto-style79" colspan="4">
                    <asp:Button ID="ButtonHome" runat="server" Text="Home" BackColor="#3497D9" OnClick="ButtonHome_Click" Width="200px" CssClass="btn" ForeColor="White" />
                    <asp:Button ID="ButtonWishList" runat="server" Text="Wish List" BackColor="#3497D9" OnClick="ButtonWishList_Click" Width="200px" CssClass="btn" ForeColor="White" />
                    <asp:Button ID="ButtonProfile" runat="server" Text="Edit Profile" BackColor="#3497D9" OnClick="ButtonProfile_Click" Width="200px" CssClass="btn" ForeColor="White" />
                </td>
            </tr>
            <tr>
                <td class="auto-style11">
                </td>
                <td colspan="2" class="auto-style76">
                    <table class="auto-style51">
                        <tr>
                            <td class="auto-style77" colspan="5" style="color: #FF0000">
                    <h1 class="auto-style78">
                        <asp:Label ID="Label1" runat="server" ForeColor="Black" Text="EDIT PROFILE"></asp:Label>
                                </h1>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style70">Name:</td>
                            <td class="auto-style80">
                                <asp:TextBox ID="TextBoxName" runat="server" Width="95%"></asp:TextBox>
                            </td>
                            <td class="auto-style80">
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ValidationGroup="GroupEdit" runat="server" ControlToValidate="TextBoxName" ErrorMessage="Field required" ForeColor="Red"></asp:RequiredFieldValidator>
                            </td>
                            <td class="auto-style81">
                                <asp:Label ID="LabelChildren" runat="server" Text="Enter the number of children you have"></asp:Label>
                            </td>
                            <td class="auto-style80">
                                <asp:TextBox ID="TextBoxChildren" runat="server" TextMode="Number"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style70">
                                <asp:Label ID="LabelSurname" runat="server" Text="Surname:"></asp:Label>
                                <br />
                            </td>
                            <td class="auto-style80">
                                <asp:TextBox ID="TextBoxContactAndSurname" runat="server" Width="95%"></asp:TextBox>
                            </td>
                            <td class="auto-style80">
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ValidationGroup="GroupEdit" runat="server" ControlToValidate="TextBoxContactAndSurname" ErrorMessage="Field required" ForeColor="Red"></asp:RequiredFieldValidator>
                            </td>
                            <td class="auto-style81">
                                <asp:Label ID="LabelPets" runat="server" Text="Do you have any pets?"></asp:Label>
                            </td>
                            <td class="auto-style80">
                                <asp:CheckBox ID="CheckBoxPets" runat="server"  />
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style70">Address:</td>
                            <td class="auto-style80">
                                <asp:TextBox ID="TextBoxAddress" runat="server" Width="95%"></asp:TextBox>
                            </td>
                            <td class="auto-style80">
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ValidationGroup="GroupEdit" runat="server" ControlToValidate="TextBoxAddress" ErrorMessage="Field required" ForeColor="Red"></asp:RequiredFieldValidator>
                            </td>
                            <td class="auto-style81">
                                <asp:Label ID="LabelDisability" runat="server" Text="Do you have a disability?"></asp:Label>
                            </td>
                            <td class="auto-style80">
                                <asp:CheckBox ID="CheckBoxDisability" runat="server" />
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style70">Post Code:</td>
                            <td class="auto-style80">
                                <asp:TextBox ID="TextBoxPostCode" runat="server" Width="95%"></asp:TextBox>
                            </td>
                            <td class="auto-style80">
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" ValidationGroup="GroupEdit" runat="server" ControlToValidate="TextBoxPostCode" ErrorMessage="Field required" ForeColor="Red"></asp:RequiredFieldValidator>
                            </td>
                            <td class="auto-style81">
                                <asp:Label ID="LabelChildren0" runat="server" Text="Number of cohabitors:"></asp:Label>
                            </td>
                            <td class="auto-style80">
                                <asp:TextBox ID="TextBoxCohabitors" runat="server" TextMode="Number"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style70">City:</td>
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
                            <td class="auto-style70">Country:</td>
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
                            <td class="auto-style70">Phone:</td>
                            <td class="auto-style80">
                                <asp:TextBox ID="TextBoxPhone" runat="server" Width="95%"></asp:TextBox>
                            </td>
                            <td class="auto-style80">
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" ValidationGroup="GroupEdit" runat="server" ControlToValidate="TextBoxPhone" ErrorMessage="Field required" ForeColor="Red"></asp:RequiredFieldValidator>
                            </td>
                            <td class="auto-style81">
                                &nbsp;</td>
                            <td class="auto-style80">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style83">
                                &nbsp;</td>
                            <td class="auto-style72" colspan="3">
                                <asp:Label ID="LabelProfileEdit" runat="server"></asp:Label>
                                <br />
                                <asp:Button ID="ButtonEdit" ValidationGroup="GroupEdit" runat="server" OnClick="ButtonEdit_Click" Text="Edit" style="height: 29px" />
                                <input id="ButtonClear" type="reset" value="Undo" /></td>
                            <td class="auto-style72">
                                &nbsp;</td>
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
