<%@ Page Language="C#" AutoEventWireup="true" CodeFile="WishList.aspx.cs" Inherits="WishList" %>

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
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style21">
              <a href="MainPageStudent.aspx">      <asp:Image ID="Image3" runat="server" Height="158px" ImageUrl="http://www.homesapp.ca/images/home-5-256.png" Width="190px" /> </a>
                </td>
                <td class="auto-style25"></td>
                <td class="auto-style49">
                    <a href="EditProfile.aspx"><asp:Label ID="WelcomeLabel" runat="server" Text="Welcome " ></asp:Label></a>
                    <br />
                </td>
                <td class="auto-style45">
                    <asp:Button ID="LogOut" runat="server" OnClick="LogOut_Click" Text="Log Out" BackColor="#3497D9" CssClass="btn" ForeColor="White" />
                    <br />
                </td>
            </tr>
            <tr>
                <td class="auto-style48" colspan="4">
                    <asp:Button ID="ButtonHome" runat="server" Text="Home" BackColor="#3497D9" OnClick="ButtonHome_Click" Width="200px" CssClass="btn" ForeColor="White" />
                    <asp:Button ID="ButtonWishList0" runat="server" Text="Wish List" BackColor="#3497D9" OnClick="ButtonWishList_Click" Width="200px" CssClass="btn" ForeColor="White" />
                    <asp:Button ID="ButtonProfile0" runat="server" Text="Edit Profile" BackColor="#3497D9" OnClick="ButtonProfile_Click" Width="200px" CssClass="btn" ForeColor="White" />
                </td>
            </tr>
            <tr>
                <td class="auto-style11">
                    &nbsp;</td>
                <td colspan="2" class="auto-style47">
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
                <td class="auto-style47">&nbsp;</td>
            </tr>
            </table>
    <div class="auto-style36">
    
    </div>
    </form>
</body>
</html>
