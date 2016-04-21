<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FlatsDetailsLandlord.aspx.cs" Inherits="FlatsDetailsLandlord" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <script type="text/javascript">
 setTimeout(function () {
 document.getElementById("myMap").innerHTML =
 '<iframe width="300" id="iframe" height="300" frameborder="0" scrolling="no" marginheight="0" marginwidth="0" src="'
 + document.getElementById("loc").value + '"></iframe>';
 }, 1000);
 
 </script>

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
.auto-style21 {
            width: 249px;
            height: 192px;
        }
        .auto-style25 {
            height: 192px;
            text-align: right;
            width: 714px;
        }
        .auto-style45 {
            width: 250px;
            height: 192px;
        }
        .auto-style48 {
            height: 16px;
            text-align: center;
        }
        .auto-style1 {
            width: 1499px;
            height: 439px;
            margin-bottom: 427px;
        }
        .auto-style50 {
            height: 122px;
            text-align: center;
        }
        .auto-style51 {
            height: 122px;
            text-align: center;
            width: 714px;
        }
        .auto-style52 {
            height: 186px;
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style21">
              <a href="MainPageLandlord.aspx">      <asp:Image ID="Image3" runat="server" Height="158px" ImageUrl="http://www.homesapp.ca/images/home-5-256.png" Width="190px" /> </a>
                </td>
                <td class="auto-style25">
                    <br />
                </td>
                <td class="auto-style45">
                    <a href="EditProfile.aspx"><asp:Label ID="WelcomeLabel" runat="server" Text="Welcome " ></asp:Label></a>
                </td>
                <td class="auto-style45">
                    <asp:Button ID="LogOut" runat="server" OnClick="LogOut_Click" Text="Log Out" BackColor="#3497D9" CssClass="btn" ForeColor="White" />
                    <br />
                </td>
            </tr>
            <tr>
                <td class="auto-style48" colspan="4">
                    <asp:Button ID="ButtonHome" runat="server" Text="Home" BackColor="#3497D9" OnClick="ButtonHome_Click" Width="200px" CssClass="btn" ForeColor="White" />
                    <asp:Button ID="ButtonFlats0" runat="server" Text="Flats" BackColor="#3497D9" OnClick="ButtonFlats_Click" Width="200px" CssClass="btn" ForeColor="White" />
                    <asp:Button ID="ButtonProfile0" runat="server" Text="Edit Profile" BackColor="#3497D9" OnClick="ButtonProfile_Click" Width="200px" CssClass="btn" ForeColor="White" />
                </td>
            </tr>
            <tr>
                <td class="auto-style50" rowspan="2">
                    &nbsp;</td>
<td class="auto-style51" rowspan="2">
                    <asp:FormView ID="FormView1" runat="server" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" DataKeyNames="Id" ForeColor="Black" GridLines="Both" Width="622px" Height="210px">
                        <EditItemTemplate>
                            Id:
                            <asp:Label ID="IdLabel1" runat="server" Text='<%# Eval("Id") %>' />
                            <br />
                            LandlordEmail:
                            <asp:TextBox ID="LandlordEmailTextBox" runat="server" Text='<%# Bind("LandlordEmail") %>' />
                            <br />
                            Type:
                            <asp:TextBox ID="TypeTextBox" runat="server" Text='<%# Bind("Type") %>' />
                            <br />
                            Address:
                            <asp:TextBox ID="AddressTextBox" runat="server" Text='<%# Bind("Address") %>' />
                            <br />
                            PostCode:
                            <asp:TextBox ID="PostCodeTextBox" runat="server" Text='<%# Bind("PostCode") %>' />
                            <br />
                            City:
                            <asp:TextBox ID="CityTextBox" runat="server" Text='<%# Bind("City") %>' />
                            <br />
                            Rent:
                            <asp:TextBox ID="RentTextBox" runat="server" Text='<%# Bind("Rent") %>' />
                            <br />
                            Deposit:
                            <asp:TextBox ID="DepositTextBox" runat="server" Text='<%# Bind("Deposit") %>' />
                            <br />
                            AvailableFrom:
                            <asp:TextBox ID="AvailableFromTextBox" runat="server" Text='<%# Bind("AvailableFrom") %>' />
                            <br />
                            DateOfCreation:
                            <asp:TextBox ID="DateOfCreationTextBox" runat="server" Text='<%# Bind("DateOfCreation") %>' />
                            <br />
                            Description:
                            <asp:TextBox ID="DescriptionTextBox" runat="server" Text='<%# Bind("Description") %>' />
                            <br />
             
                            <asp:LinkButton ID="UpdateButton" runat="server" BackColor="#3497D9" ForeColor="White" CausesValidation="True" CommandName="Update" Text="Update" CssClass="btn"/>
                            &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" BackColor="#3497D9" ForeColor="White" CausesValidation="False" CommandName="Cancel" Text="Cancel" CssClass="btn"/>
                        </EditItemTemplate>
                        <EditRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                        <FooterStyle BackColor="#CCCCCC" />
                        <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                        <InsertItemTemplate>
                            LandlordEmail:
                            <asp:TextBox ID="LandlordEmailTextBox" runat="server" Text='<%# Bind("LandlordEmail") %>' />
                            <br />
                            Type:
                            <asp:TextBox ID="TypeTextBox" runat="server" Text='<%# Bind("Type") %>' />
                            <br />
                            Address:
                            <asp:TextBox ID="AddressTextBox" runat="server" Text='<%# Bind("Address") %>' />
                            <br />
                            PostCode:
                            <asp:TextBox ID="PostCodeTextBox" runat="server" Text='<%# Bind("PostCode") %>' />
                            <br />
                            City:
                            <asp:TextBox ID="CityTextBox" runat="server" Text='<%# Bind("City") %>' />
                            <br />
                            Rent:
                            <asp:TextBox ID="RentTextBox" runat="server" Text='<%# Bind("Rent") %>' />
                            <br />
                            Deposit:
                            <asp:TextBox ID="DepositTextBox" runat="server" Text='<%# Bind("Deposit") %>' />
                            <br />
                            AvailableFrom:
                            <asp:TextBox ID="AvailableFromTextBox" runat="server" Text='<%# Bind("AvailableFrom") %>' />
                            <br />
                            DateOfCreation:
                            <asp:TextBox ID="DateOfCreationTextBox" runat="server" Text='<%# Bind("DateOfCreation") %>' />
                            <br />
                            Description:
                            <asp:TextBox ID="DescriptionTextBox" runat="server" Text='<%# Bind("Description") %>' />
                            <br />
                            
                            <asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insert" />
                            &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancel" />
                        </InsertItemTemplate>
                        <ItemTemplate>
                            Id:
                            <asp:Label ID="IdLabel" runat="server" Text='<%# Eval("Id") %>' />
                            <br />
                            LandlordEmail:
                            <asp:Label ID="LandlordEmailLabel" runat="server" Text='<%# Bind("LandlordEmail") %>' />
                            <br />
                            Type:
                            <asp:Label ID="TypeLabel" runat="server" Text='<%# Bind("Type") %>' />
                            <br />
                            Address:
                            <asp:Label ID="AddressLabel" runat="server" Text='<%# Bind("Address") %>' />
                            <br />
                            PostCode:
                            <asp:Label ID="PostCodeLabel" runat="server" Text='<%# Bind("PostCode") %>' />
                            <br />
                            City:
                            <asp:Label ID="CityLabel" runat="server" Text='<%# Bind("City") %>' />
                            <br />
                            Rent:
                            <asp:Label ID="RentLabel" runat="server" Text='<%# Bind("Rent") %>' />
                            <br />

                            Deposit:
                            <asp:Label ID="DepositLabel" runat="server" Text='<%# Bind("Deposit") %>' />
                            <br />
                            AvailableFrom:
                            <asp:Label ID="AvailableFromLabel" runat="server" Text='<%# Bind("AvailableFrom") %>' />
                            <br />
                            DateOfCreation:
                            <asp:Label ID="DateOfCreationLabel" runat="server" Text='<%# Bind("DateOfCreation") %>' />
                            <br />
                            Description:
                            <asp:Label ID="DescriptionLabel" runat="server" Text='<%# Bind("Description") %>' />
                            <br />
                           <br />
                            <br />  
               

                        </ItemTemplate>
                        <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
                        <RowStyle BackColor="White" />
                    </asp:FormView>
                </td>
                <td class="auto-style52">
                    

                    <input type="hidden" runat="server" id="loc" />
 <div id="myMap"></div>

                            </td>
                <td class="auto-style50" rowspan="2">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style50">
                    
                    <asp:Label ID="LabelGoogleMaps" runat="server" Text="Google can't find the address" Visible="False"></asp:Label>

                            </td>
            </tr>
            <tr>
                <td class="auto-style48" colspan="4">
                    &nbsp;</td>
            </tr>
            </table>
    
    </div>
    </form>
</body>
</html>
