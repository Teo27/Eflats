<%@ Page Language="C#" AutoEventWireup="true" CodeFile="WishList.aspx.cs" Inherits="WishList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Wish List</title>
        <meta http-equiv="X-UA_Compatible" content="IE=edge" />
        <meta name="viewport" content="width=device-width, initial-scale=1" />
        <link rel="stylesheet" type="text/css" href="css/bootstrap.css" />
    <style type="text/css">
               
.auto-style1 {
            width: 1499px;
            height: 439px;
            margin-bottom: 427px;
        }
        .auto-style11 {
            width: 249px;
            height: 608px;
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
        .auto-style45 {
            width: 250px;
            height: 192px;
        }
        .auto-style47 {
            height: 608px;
        }
        .auto-style48 {
            height: 16px;
            text-align: center;
        }
        .auto-style49 {
            width: 250px;
            height: 192px;
            text-align: right;
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
                    <li class="active"><a href="WishList.aspx">Wish List</a></li>
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
                            
                <asp:Button ID="ButtonLogOut" runat="server" OnClick="LogOut_Click" Text="Log Out" BackColor="#3497D9" CssClass="btn" ForeColor="White" />
                    
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
    



        <table style="margin: 100px auto">
            
            <tr>
                
                <td>
                    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" CellPadding="4"  ForeColor="#333333" GridLines="None" Width="100%"  onrowcommand="GridView1_RowCommand">
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                            <asp:BoundField DataField="FlatId" HeaderText="FlatId" SortExpression="FlatId">
                            </asp:BoundField>
                            <asp:BoundField DataField="Address" HeaderText="Address" SortExpression="Address" />
                            <asp:BoundField DataField="QueueNumber" HeaderText="QueueNumber" SortExpression="QueueNumber"/>
                       

                            <asp:ButtonField ButtonType="Button" CommandName="Remove" Text="Remove" />

                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:Button ID="ButtonAccept" runat="server" CommandName="Accept" Text="Accept" Visible="False" CommandArgument='<%# Container.DataItemIndex %>'/>
                                <asp:Button ID="ButtonDeny" runat="server" CommandName="Deny" Text="Deny" Visible="False" CommandArgument='<%# Container.DataItemIndex %>' />
                            </ItemTemplate>                
                         </asp:TemplateField>

                        </Columns>
                        <EditRowStyle BackColor="#7C6F57" />
                        <FooterStyle BackColor="#3497d9" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#3497d9" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#3497d9" ForeColor="White" HorizontalAlign="Center" />
                        <RowStyle BackColor="#E3EAEB" HorizontalAlign="Center" />
                        <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                        <SortedAscendingCellStyle BackColor="#F8FAFA" HorizontalAlign="Center" />
                        <SortedAscendingHeaderStyle BackColor="#246B61" />
                        <SortedDescendingCellStyle BackColor="#D4DFE1" />
                        <SortedDescendingHeaderStyle BackColor="#15524A" />
                    </asp:GridView>
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
