<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MainPageStudent.aspx.cs" Inherits="MainPageStudent" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Main Page</title>
        <meta http-equiv="X-UA_Compatible" content="IE=edge" />
        <meta name="viewport" content="width=device-width, initial-scale=1" />
        <link rel="stylesheet" type="text/css" href="css/bootstrap.css" />
    <style type="text/css">
        .auto-style1 {
            width: 1499px;
            height: 919px;
            margin-bottom: 427px;
        }
        .auto-style21 {
            width: 249px;
            height: 190px;
        }
        .auto-style25 {
            height: 190px;
        }
        .auto-style36 {
            margin-bottom: 61px;
        }
        .Initial
        {
             display: block;
             padding: 4px 18px 4px 18px;
             float: left;
             background: #c7b4b4 no-repeat right top;
             color: Black;
             font-weight: bold;
        }
        .Initial:hover
        {
             color: Black;
             background: #808080 no-repeat right top;
        }
        .Clicked
        {
             float: left;
             display: block;
             background: #3497d9 no-repeat right top;
             padding: 4px 18px 4px 18px;
             color: Black;
             font-weight: bold;
             color: White;
        }
        .auto-style45 {
            width: 250px;
            height: 190px;
        }
        .auto-style48 {
            height: 53px;
            text-align: center;
        }
        
        .auto-style49 {
            width: 250px;
            height: 190px;
            text-align: right;
        }
        .auto-style66 {
            width: 152px;
        }
        .auto-style72 {
            height: 718px;
        }
        
.navbar-collapse.in,
        .navbar-collapse.collapsing {
            clear: left;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
    
        
        <%--<nav class="navbar navbar-default navbar-fixed-top">
        <div class="container-fluid">

            <div class="navbar-header pull-left">

                <a class="pull-left" href="MainPageStudent.aspx">
                    <img src="images/home.png" height="48px" width="48px" /></a>

                <ul class="nav navbar-nav collapse navbar-collapse" id="myNavbar">
                    <li class="active"><a href="MainPageStudent.aspx">Main Page</a></li>
                    <li><a href="Wish List.aspx">WishList</a></li>
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
    </nav>--%>







    <div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style48" colspan="3">
                    &nbsp;</td>
            </tr>
            <tr>

                <td class="auto-style66">
                    <asp:Label ID="LabelMinRent" runat="server" Text="Min. Rent"></asp:Label>
                    <br />
                    <asp:TextBox ID="TextBoxMinRent" runat="server"></asp:TextBox>
                </td>

                <td class="auto-style72" rowspan="7">
                    <asp:Button BorderStyle="None" ID="Tab1" CssClass="Initial" runat="server" OnClick="Tab1_Click" Text="All Flats" />
                    <asp:Button BorderStyle="None" ID="Tab2" CssClass="Initial" runat="server" OnClick="Tab2_Click" Text="Most Recent" />
                    <asp:Button BorderStyle="None" ID="Tab3" CssClass="Initial" runat="server" OnClick="Tab3_Click" Text="Open Flats" />
                    
                     
                      
                    <asp:MultiView ID="MainView" runat="server">
            <asp:View ID="View1" runat="server">
              

                     
                      
                          <asp:Label ID="LabelFlats" runat="server" Text="No flats available" Visible="False"></asp:Label>
              

                     
                      
                          <asp:GridView ID="GridViewAllFlats" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="Id" ForeColor="#333333" GridLines="None" HorizontalAlign="Center" OnPageIndexChanging="gridViewAllFlats_PageIndexChanging" onrowcommand="GridViewAllFlats_RowCommand" Width="100%">
                              <AlternatingRowStyle BackColor="White" HorizontalAlign="Center" />
                              <Columns>
                                  <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" />
                                  <asp:BoundField DataField="Address" HeaderText="Address" />
                                  <asp:BoundField DataField="Rent" HeaderText="Rent" />
                                  <asp:BoundField DataField="Deposit" HeaderText="Deposit" />
                                  <asp:ButtonField ButtonType="Button" CommandName="View" Text="View" />
                                  <asp:TemplateField>
                                      <ItemTemplate>
                                          <asp:Button ID="ButtonAdd" runat="server" CommandArgument="<%# Container.DataItemIndex %>" CommandName="Add" Text="Add" Width="80" />
                                          <asp:Button ID="ButtonRemove" runat="server" CommandArgument="<%# Container.DataItemIndex %>" CommandName="Remove" Text="Remove" Width="80" />
                                      </ItemTemplate>
                                  </asp:TemplateField>
                              </Columns>
                              <EditRowStyle BackColor="#7C6F57" HorizontalAlign="Center" />
                              <EmptyDataRowStyle HorizontalAlign="Center" />
                              <FooterStyle BackColor="#3497d9" Font-Bold="True" ForeColor="White" />
                              <HeaderStyle BackColor="#3497d9" Font-Bold="True" ForeColor="White" />
                              <PagerStyle BackColor="#3497d9" ForeColor="White" HorizontalAlign="Center" />
                              <RowStyle BackColor="#E3EAEB" HorizontalAlign="Center" />
                              <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" HorizontalAlign="Center" />
                              <SortedAscendingCellStyle BackColor="#F8FAFA" HorizontalAlign="Center" />
                              <SortedAscendingHeaderStyle BackColor="#246B61" HorizontalAlign="Center" />
                              <SortedDescendingCellStyle BackColor="#D4DFE1" HorizontalAlign="Center" />
                              <SortedDescendingHeaderStyle BackColor="#15524A" HorizontalAlign="Center" />
                          </asp:GridView>
                      
                  
            </asp:View>
            <asp:View ID="View2" runat="server">
                <asp:GridView ID="GridViewMostRecent" OnPageIndexChanging ="gridViewMostRecent_PageIndexChanging"  runat="server" AllowPaging="True" AllowSorting="False" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="Id" ForeColor="#333333" GridLines="None" HorizontalAlign="Center" onrowcommand="GridViewMostRecent_RowCommand" Width="100%">
                    <AlternatingRowStyle BackColor="White" HorizontalAlign="Center" Font-Bold="True" />
                    <Columns>
                        <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True"  />
                        <asp:BoundField DataField="Address" HeaderText="Address"  />
                        <asp:BoundField DataField="Rent" HeaderText="Rent"  />
                        <asp:BoundField DataField="Deposit" HeaderText="Deposit"  />
                        <asp:ButtonField ButtonType="Button" CommandName="View" Text="View" />
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:Button ID="ButtonAdd" runat="server" CommandArgument="<%# Container.DataItemIndex %>" CommandName="Add" Text="Add" Width="80" />
                                <asp:Button ID="ButtonRemove" runat="server" CommandArgument="<%# Container.DataItemIndex %>" CommandName="Remove" Text="Remove" Width="80" />
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                    <EditRowStyle BackColor="#7C6F57" HorizontalAlign="Center" Font-Bold="True" />
                    <EmptyDataRowStyle HorizontalAlign="Center" />
                    <FooterStyle BackColor="#3497d9" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#3497d9" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#3497d9" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#E3EAEB" HorizontalAlign="Center" Font-Bold="True" />
                    <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" HorizontalAlign="Center" />
                    <SortedAscendingCellStyle BackColor="#F8FAFA" HorizontalAlign="Center" />
                    <SortedAscendingHeaderStyle BackColor="#246B61" HorizontalAlign="Center" />
                    <SortedDescendingCellStyle BackColor="#D4DFE1" HorizontalAlign="Center" />
                    <SortedDescendingHeaderStyle BackColor="#15524A" HorizontalAlign="Center" />
                </asp:GridView>
            </asp:View>


<asp:View ID="View3" runat="server">
                <asp:GridView ID="GridViewOpen" OnPageIndexChanging ="gridViewOpen_PageIndexChanging" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="Id" ForeColor="#333333" GridLines="None" HorizontalAlign="Center" onrowcommand="GridViewOpen_RowCommand" Width="100%">
                    <AlternatingRowStyle BackColor="White" HorizontalAlign="Center" Font-Bold="True" />
                    <Columns>
                        <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True"  />
                        <asp:BoundField DataField="Address" HeaderText="Address"  />
                        <asp:BoundField DataField="Rent" HeaderText="Rent" />
                        <asp:BoundField DataField="Deposit" HeaderText="Deposit"  />
                        <asp:ButtonField ButtonType="Button" CommandName="View" Text="View" />
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:Button ID="ButtonAdd" runat="server" CommandArgument="<%# Container.DataItemIndex %>" CommandName="Add" Text="Add" Width="80" />
                                <asp:Button ID="ButtonRemove" runat="server" CommandArgument="<%# Container.DataItemIndex %>" CommandName="Remove" Text="Remove" Width="80" />
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                    <EditRowStyle BackColor="#7C6F57" HorizontalAlign="Center" Font-Bold="True" />
                    <EmptyDataRowStyle HorizontalAlign="Center" />
                    <FooterStyle BackColor="#3497d9" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#3497d9" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#3497d9" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#E3EAEB" HorizontalAlign="Center" Font-Bold="True" />
                    <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" HorizontalAlign="Center" />
                    <SortedAscendingCellStyle BackColor="#F8FAFA" HorizontalAlign="Center" />
                    <SortedAscendingHeaderStyle BackColor="#246B61" HorizontalAlign="Center" />
                    <SortedDescendingCellStyle BackColor="#D4DFE1" HorizontalAlign="Center" />
                    <SortedDescendingHeaderStyle BackColor="#15524A" HorizontalAlign="Center" />
                </asp:GridView>
            </asp:View>






          </asp:MultiView>

            
                </td>
                <td class="auto-style72" rowspan="7"></td>
            </tr>
            <tr>

                <td class="auto-style66">
                    <asp:Label ID="LabelMaxRent" runat="server" Text="Max. Rent"></asp:Label>
                    <br />
                    <asp:TextBox ID="TextBoxMaxRent" runat="server"></asp:TextBox>
                </td>

            </tr>
            <tr>

                <td class="auto-style66">
                    <asp:Label ID="LabelMinDeposit" runat="server" Text="Min. Deposit"></asp:Label>
                    <br />
                    <asp:TextBox ID="TextBoxMinDeposit" runat="server"></asp:TextBox>
                </td>

            </tr>
            <tr>

                <td class="auto-style66">
                    <asp:Label ID="LabelMaxDeposit" runat="server" Text="Max. Deposit"></asp:Label>
                    <br />
                    <asp:TextBox ID="TextBoxMaxDeposit" runat="server"></asp:TextBox>
                </td>

            </tr>
            <tr>

                <td class="auto-style66">
                    <asp:Label ID="LabelCity" runat="server" Text="City:"></asp:Label>
                    <br />
                    <asp:TextBox ID="TextBoxCity" runat="server"></asp:TextBox>
                    <br />
                </td>

            </tr>
            <tr>

                <td class="auto-style66">
                    <asp:Button ID="ButtonSearchFlats" runat="server" OnClick="ButtonSearchFlats_Click" Text="Search" />
                </td>

            </tr>
            <tr>

                <td class="auto-style66">
                    &nbsp;</td>

            </tr>
            </table>
    



<%--<nav class="navbar navbar-default navbar-fixed-bottom">
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
    </nav>--%>

       </form>

    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js"></script>
    <script>window.jQuery || document.write('<script src="jquery/jquery-1.11.3.min.js"><\/script>')</script>
    <script src="js/bootstrap.min.js"></script>
</body>
</html>
