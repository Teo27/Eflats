<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ErrorPage.aspx.cs" Inherits="ErrorPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Error</title>
    <style type="text/css">
        
        .auto-style11 {
            height: 608px;
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
   
        .auto-style1 {
            width: 300px;
            height: 300px;
            
        }

    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            
            
            <tr>
                <td class="auto-style11">
                    <br />
                    <asp:Label ID="LabelError" runat="server" Font-Size="180pt" Text="Error"></asp:Label>
                </td>

            </tr>
          </table>
    
    </form>
</body>
</html>
