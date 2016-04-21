<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Offers.aspx.cs" Inherits="Offers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
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
        .auto-style50 {
            height: 608px;
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style21">
              <a href="MainPageLandlord.aspx">      <asp:Image ID="Image3" runat="server" Height="158px" ImageUrl="http://www.homesapp.ca/images/home-5-256.png" Width="190px" /> </a>
                </td>
                <td class="auto-style25"></td>
                <td class="auto-style49">
                    <a href="EditProfile.aspx"><asp:Label ID="WelcomeLabel" runat="server" Text="Welcome " Font-Size="12pt" ></asp:Label></a>
                    <br />
                </td>
                <td class="auto-style45">
                    <asp:Button ID="LogOut" runat="server" OnClick="ButtonLogOut_Click" Text="Log Out" BackColor="#3497D9" CssClass="btn" ForeColor="White" />
                    <br />
                </td>
            </tr>
            <tr>
                <td class="auto-style48" colspan="4">
                    <asp:Button ID="ButtonHome" runat="server" Text="Home" BackColor="#3497D9" OnClick="ButtonHome_Click" Width="200px" CssClass="btn" />
                    <asp:Button ID="ButtonFlats0" runat="server" Text="Flats" BackColor="#3497D9" OnClick="ButtonFlats_Click" Width="200px" CssClass="btn" />
                    <asp:Button ID="ButtonProfile0" runat="server" Text="Edit Profile" BackColor="#3497D9" OnClick="ButtonProfile_Click" Width="200px" CssClass="btn" />
                </td>
            </tr>
            <tr>
                <td class="auto-style11">
                    &nbsp;</td>

                <td colspan="2" class="auto-style50">
                          <asp:Label ID="LabelNoOffers" runat="server" Text="You do not have any offers." Visible="False"></asp:Label>
                          <asp:GridView ID="GridViewAllFlats"   runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="Id"  ForeColor="#333333" GridLines="None" Width="100%" HorizontalAlign="Center"  >
                              <AlternatingRowStyle BackColor="White" HorizontalAlign="Center" />
                              <Columns>
                                  <asp:BoundField DataField="FlatId" HeaderText="FlatId" InsertVisible="False"  SortExpression="FlatId" ReadOnly="True" />
                                  
                                  <asp:BoundField DataField="StudentEmail" HeaderText="Student Email" SortExpression="StudentEmail" /> 
                                  <asp:BoundField DataField="DateOfOffer" HeaderText="Date Of Offer" SortExpression="DateOfOffer" /> 
                                  <asp:BoundField DataField="DateOfConfirmation" HeaderText="Date Of Confirmation" SortExpression="DateOfConfirmation"> 
                                  </asp:BoundField>

                                  
                         

                                                                                  

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
                </td>
                <td class="auto-style47"></td>
            </tr>
            </table>
    <div class="auto-style36">
    
    </div>
    </form>
</body>
</html>
