<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FlatsDetailsStudent.aspx.cs" Inherits="FlatsDetailsStudent" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Flat Details</title>
        <meta http-equiv="X-UA_Compatible" content="IE=edge" />
        <meta name="viewport" content="width=device-width, initial-scale=1" />
        <link rel="stylesheet" type="text/css" href="css/bootstrap.css" />
    <script type="text/javascript">
 setTimeout(function () {
 document.getElementById("myMap").innerHTML =
 '<iframe width="300" id="iframe" height="300" frameborder="0" scrolling="no" marginheight="0" marginwidth="0" src="'
 + document.getElementById("loc").value + '"></iframe>';
 }, 1000);
 
 </script>

    <style type="text/css">

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

                <a class="pull-left" href="MainPageStudent.aspx">
                    <img src="images/home.png" height="48px" width="48px" /></a>

                <ul class="nav navbar-nav collapse navbar-collapse" id="myNavbar">
                    <li><a href="MainPageStudent.aspx">Main Page</a></li>
                    <li><a href="WishList.aspx">WishList</a></li>
                    <li><a href="EditProfileStudent.aspx">Edit Profile</a></li>
                    <li class="disabled"><a href="#">FAQ</a></li>
                    <li class="disabled"><a href="#">About us</a></li>
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

                <a href="EditProfileStudent.aspx"><asp:Label class="hidden-xs" ID="WelcomeLabel" runat="server" Text="Welcome " style="color: black; text-decoration: none;"></asp:Label></a>
                            
                <asp:Button ID="Button1" runat="server" OnClick="LogOut_Click" Text="Log Out" BackColor="#3497D9" CssClass="btn" ForeColor="White" />
                    
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
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style48" colspan="4">
                    &nbsp;</td>
            </tr>
            <tr>
                
<td class="auto-style51">
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
       
                            Description:
                            <asp:Label ID="DescriptionLabel" runat="server" Text='<%# Bind("Description") %>' />
                            <br />
                           <br />
                            <br />


                            <asp:Label ID="LabelAddRemove" runat="server" Text='' /> 
                            <br> </br>
                            <asp:Button ID="ButtonAddFlat" runat="server" Text="Add" BackColor="#CCCCCC" CommandName="Add" OnClick="ButtonAddFlat_Click" Width="200px" />
                            <asp:Button ID="ButtonRemoveFlat" runat="server" Text="Remove" BackColor="#CCCCCC" OnClick="ButtonRemoveFlat_Click" Width="200px" />
                            
               

                        </ItemTemplate>
                        <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
                        <RowStyle BackColor="White" />
                    </asp:FormView>
                </td>
                <td class="auto-style50">
                    

                    <input type="hidden" runat="server" id="loc" />
 <div id="myMap"></div>

                            </td>
                <td class="auto-style50">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style48" colspan="4">
                    <asp:Label ID="LabelAddRemove" runat="server"></asp:Label>
                </td>
            </tr>
            </table>
    
    </div>
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
