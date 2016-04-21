<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MainPageStudent.aspx.cs" Inherits="MainPageStudent" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
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
        .auto-style73 {
            text-align: center;
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
                    <a href="EditProfile.aspx"><asp:Label ID="WelcomeLabel" runat="server" Text="Welcome " Font-Size="12pt" ></asp:Label></a>
                </td>
                <td class="auto-style45">
                    <asp:Button ID="LogOut" runat="server" OnClick="ButtonLogOut_Click" Text="Log Out" BackColor="#3497D9" CssClass="btn" ForeColor="White" />
                    <br />
                </td>
            </tr>
            <tr>
                <td class="auto-style48" colspan="4">
                    <asp:Button ID="ButtonHome" runat="server" Text="Home" BackColor="#3497D9" ForeColor="White" OnClick="ButtonHome_Click" Width="200px" CssClass="btn" />
                    <asp:Button ID="ButtonWishList0" runat="server" Text="Wish List" BackColor="#3497D9" OnClick="ButtonWishList_Click" Width="200px" CssClass="btn" />
                    <asp:Button ID="ButtonProfile0" runat="server" Text="Edit Profile" BackColor="#3497D9" OnClick="ButtonProfile_Click" Width="200px" CssClass="btn" />
                </td>
            </tr>
            <tr>

                <td class="auto-style66">
                    <asp:Label ID="LabelMinRent" runat="server" Text="Min. Rent"></asp:Label>
                    <br />
                    <asp:TextBox ID="TextBoxMinRent" runat="server"></asp:TextBox>
                </td>

                <td colspan="2" class="auto-style72" rowspan="7">
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
    <div class="auto-style36">
    
    </div>
    </form>
</body>
</html>
