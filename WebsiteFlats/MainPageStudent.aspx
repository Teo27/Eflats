<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MainPageStudent.aspx.cs" Inherits="MainPageStudent" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Main Page</title>
        <meta http-equiv="X-UA_Compatible" content="IE=edge" />
        <meta name="viewport" content="width=device-width, initial-scale=1" />
        <link rel="stylesheet" type="text/css" href="css/bootstrap.css" />
    
     <link rel="stylesheet" type="text/css" href="css/Colouring.css" />
    <style type="text/css">
        .Initial
        {
             display: block;
             padding: 4px 18px 4px 18px;
             float: left;
             background: #ffffde no-repeat right top;
             color: #9f4e3e;
             font-weight: bold;
        }
       
        .Clicked
        {
             float: left;
             display: block;
             background: #9f4e3e no-repeat right top;
             padding: 4px 18px 4px 18px;
             font-weight: bold;
             color: #ffffde;
             border-width:1px;
        }
      
        
.navbar-collapse.in,
        .navbar-collapse.collapsing {
            clear: left;
        }
        .auto-style78 {
            width: 250px;
            height: 122px;
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
                    <li class="active"><a href="MainPageStudent.aspx"><b>Home</b></a></li>
                    <li><a href="WishList.aspx"><b class="cream">Wish List</b></a></li>
                    <li><a href="EditProfileStudent.aspx"><b class="cream">Edit Profile</b></a></li>
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







    
        <table style="margin: 50px auto;width:75%">
            <tr >
                
                <td class="auto-style78">
                    
                    <asp:Label ID="LabelMinRent" runat="server" Text="Min. Rent"></asp:Label>
                    <br />
                    <asp:TextBox ID="TextBoxMinRent" runat="server"></asp:TextBox>
                   
                </td>
               
                <td class="auto-style78">
                    <asp:Label ID="LabelMaxRent" runat="server" Text="Max. Rent"></asp:Label>
                    <br />
                    <asp:TextBox ID="TextBoxMaxRent" runat="server"></asp:TextBox>
                </td>
               
                <td class="auto-style78">
                    <asp:Label ID="LabelMinDeposit" runat="server" Text="Min. Deposit"></asp:Label>
                    <br />
                    <asp:TextBox ID="TextBoxMinDeposit" runat="server"></asp:TextBox>
                </td>
               
                <td class="auto-style78">
                    <asp:Label ID="LabelMaxDeposit" runat="server" Text="Max. Deposit"></asp:Label>
                    <br />
                    <asp:TextBox ID="TextBoxMaxDeposit" runat="server"></asp:TextBox>
                </td>
               
                <td class="auto-style78">
                    <asp:Label ID="LabelCity" runat="server" Text="City:"></asp:Label>
                    <br />
                    <asp:TextBox ID="TextBoxCity" runat="server"></asp:TextBox>
                </td>
               
                <td class="auto-style78">
                    <br />
                    <asp:Button ID="ButtonSearchFlats" runat="server" OnClick="ButtonSearchFlats_Click" Text="Search" class="btn btn-sm button1"/>
                </td>
               
            </tr>
            <tr>

                <td class="auto-style72" colspan="6">
                    <asp:Button BorderStyle="None" ID="Tab1" CssClass="Initial" runat="server" OnClick="Tab1_Click" Text="All Flats" />
                    <asp:Button BorderStyle="None" ID="Tab2" CssClass="Initial" runat="server" OnClick="Tab2_Click" Text="Most Recent" />
                    <asp:Button BorderStyle="None" ID="Tab3" CssClass="Initial" runat="server" OnClick="Tab3_Click" Text="Open Flats" />
                    
                     
                     
                    <asp:MultiView ID="MainView" runat="server">
            <asp:View ID="View1" runat="server">
              
                <br />
                     <br />
                      
                          <asp:Label ID="LabelFlats" runat="server" Text="No flats available" Visible="False"></asp:Label>
              
                
                     
                      
                          <asp:GridView ID="GridViewAllFlats" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="Id" ForeColor="#9f4e3e" BorderWidth="1px" GridLines="None" HorizontalAlign="Center" OnPageIndexChanging="gridViewAllFlats_PageIndexChanging" onrowcommand="GridViewAllFlats_RowCommand" HeaderStyle-CssClass="HeaderStyle" Width="100%">
                              <AlternatingRowStyle BackColor="White" HorizontalAlign="Center" />
                              <Columns>
                                  <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" />
                                  <asp:BoundField DataField="Address" HeaderText="Address" />
                                  <asp:BoundField DataField="Rent" HeaderText="Rent" />
                                  <asp:BoundField DataField="Deposit" HeaderText="Deposit" />
                                  <asp:ButtonField ButtonType="Button" CommandName="View" Text="View" ControlStyle-CssClass="btn btn-sm button1"/>
                                  <asp:TemplateField>
                                      <ItemTemplate>
                                          <asp:Button ID="ButtonAdd" runat="server" CommandArgument="<%# Container.DataItemIndex %>" CommandName="Add" Text="Add" Width="80" class="btn btn-sm button1"/>
                                          <asp:Button ID="ButtonRemove" runat="server" CommandArgument="<%# Container.DataItemIndex %>" CommandName="Remove" Text="Remove" Width="80" class="btn btn-sm button1"/>
                                      </ItemTemplate>
                                  </asp:TemplateField>
                              </Columns>
                              <EditRowStyle BackColor="#7C6F57" HorizontalAlign="Center" />
                              <EmptyDataRowStyle HorizontalAlign="Center" />
                              <FooterStyle BackColor="#9f4e3e" Font-Bold="True" ForeColor="#ffffde" />
                              <HeaderStyle BackColor="#9f4e3e" Font-Bold="True" ForeColor="#ffffde" />
                              <PagerStyle BackColor="#9f4e3e" ForeColor="#ffffde" HorizontalAlign="Center" />
                              <RowStyle BackColor="#ffffde" HorizontalAlign="Center" />
                              <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" HorizontalAlign="Center" />
                              <SortedAscendingCellStyle BackColor="#F8FAFA" HorizontalAlign="Center" />
                              <SortedAscendingHeaderStyle BackColor="#246B61" HorizontalAlign="Center" />
                              <SortedDescendingCellStyle BackColor="#D4DFE1" HorizontalAlign="Center" />
                              <SortedDescendingHeaderStyle BackColor="#15524A" HorizontalAlign="Center" />
                                <AlternatingRowStyle BackColor="#fafad9" />
                          </asp:GridView>
                      
                  
            </asp:View>
            <asp:View ID="View2" runat="server"><br /><br />

                <asp:GridView ID="GridViewMostRecent" OnPageIndexChanging ="gridViewMostRecent_PageIndexChanging"  runat="server" AllowPaging="True" AllowSorting="False" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="Id" ForeColor="#9f4e3e" GridLines="None" HorizontalAlign="Center" onrowcommand="GridViewMostRecent_RowCommand" Width="100%" HeaderStyle-CssClass="HeaderStyle" BorderWidth="1px">
                    <AlternatingRowStyle BackColor="White" HorizontalAlign="Center"  />
                    <Columns>
                        <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True"  />
                        <asp:BoundField DataField="Address" HeaderText="Address"  />
                        <asp:BoundField DataField="Rent" HeaderText="Rent"  />
                        <asp:BoundField DataField="Deposit" HeaderText="Deposit"  />
                        <asp:ButtonField ButtonType="Button" CommandName="View" Text="View" ControlStyle-CssClass="btn btn-sm button1" />
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:Button ID="ButtonAdd" runat="server" CommandArgument="<%# Container.DataItemIndex %>" CommandName="Add" Text="Add" Width="80" class="btn btn-sm button1"/>
                                <asp:Button ID="ButtonRemove" runat="server" CommandArgument="<%# Container.DataItemIndex %>" CommandName="Remove" Text="Remove" Width="80" class="btn btn-sm button1"/>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                    <EditRowStyle BackColor="#7C6F57" HorizontalAlign="Center"  />
                    <EmptyDataRowStyle HorizontalAlign="Center" />
                    <FooterStyle BackColor="#9f4e3e" Font-Bold="True" ForeColor="#ffffde" />
                    <HeaderStyle BackColor="#9f4e3e" Font-Bold="True" ForeColor="#ffffde" />
                    <PagerStyle BackColor="#9f4e3e" ForeColor="#ffffde" HorizontalAlign="Center" />
                    <RowStyle BackColor="#ffffde" HorizontalAlign="Center"  />
                    <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" HorizontalAlign="Center" />
                    <SortedAscendingCellStyle BackColor="#F8FAFA" HorizontalAlign="Center" />
                    <SortedAscendingHeaderStyle BackColor="#246B61" HorizontalAlign="Center" />
                    <SortedDescendingCellStyle BackColor="#D4DFE1" HorizontalAlign="Center" />
                    <SortedDescendingHeaderStyle BackColor="#15524A" HorizontalAlign="Center" />
                      <AlternatingRowStyle BackColor="#fafad9" />
                </asp:GridView>
            </asp:View>


<asp:View ID="View3" runat="server">

<br /><br />
                <asp:GridView ID="GridViewOpen" OnPageIndexChanging ="gridViewOpen_PageIndexChanging" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="Id" ForeColor="#9f4e3e" GridLines="None" HorizontalAlign="Center" onrowcommand="GridViewOpen_RowCommand" Width="100%" HeaderStyle-CssClass="HeaderStyle" BorderWidth="1px">
                    <AlternatingRowStyle BackColor="White" HorizontalAlign="Center"  />
                    <Columns>
                        <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True"  />
                        <asp:BoundField DataField="Address" HeaderText="Address"  />
                        <asp:BoundField DataField="Rent" HeaderText="Rent" />
                        <asp:BoundField DataField="Deposit" HeaderText="Deposit"  />
                        <asp:ButtonField ButtonType="Button" CommandName="View" Text="View" ControlStyle-CssClass="btn btn-sm button1"/>
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:Button ID="ButtonAdd" runat="server" CommandArgument="<%# Container.DataItemIndex %>" CommandName="Add" Text="Add" Width="80" class="btn btn-sm button1"/>
                                <asp:Button ID="ButtonRemove" runat="server" CommandArgument="<%# Container.DataItemIndex %>" CommandName="Remove" Text="Remove" Width="80" class="btn btn-sm button1"/>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                    <EditRowStyle BackColor="#7C6F57" HorizontalAlign="Center"  />
                    <EmptyDataRowStyle HorizontalAlign="Center" />
                    <FooterStyle BackColor="#9f4e3e" Font-Bold="True" ForeColor="#ffffde" />
                    <HeaderStyle BackColor="#9f4e3e" Font-Bold="True" ForeColor="#ffffde" />
                    <PagerStyle BackColor="#9f4e3e" ForeColor="#ffffde" HorizontalAlign="Center" />
                    <RowStyle BackColor="#ffffde" HorizontalAlign="Center"  />
                    <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" HorizontalAlign="Center" />
                    <SortedAscendingCellStyle BackColor="#F8FAFA" HorizontalAlign="Center" />
                    <SortedAscendingHeaderStyle BackColor="#246B61" HorizontalAlign="Center" />
                    <SortedDescendingCellStyle BackColor="#D4DFE1" HorizontalAlign="Center" />
                    <SortedDescendingHeaderStyle BackColor="#15524A" HorizontalAlign="Center" />
                      <AlternatingRowStyle BackColor="#fafad9" />
                </asp:GridView>
            </asp:View>






          </asp:MultiView>

            
                </td>
               
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
