<%@ Page Language="C#" AutoEventWireup="true" CodeFile="programProfilePage.aspx.cs" Inherits="programProfilePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align: center">
    
        <asp:Image ID="Image1" runat="server" ImageUrl="~/myIPSlogo.png" />
        <br />
        <strong>
        <br class="auto-style1" />
        <span class="auto-style1">&nbsp;<asp:Button ID="Button5" runat="server" Text="Student Page" />
        <br />
        Program Profile Page<br />
        </span></strong>
    
    </div>
        <p style="text-align: center">
            <asp:Button ID="Button1" runat="server" Height="177px" Text="program1" Width="237px" />
        </p>
        <p style="text-align: center">
            <asp:Button ID="Button2" runat="server" Height="177px" Text="program2" Width="237px" />
        </p>
        <p style="text-align: center">
            <asp:Button ID="Button3" runat="server" Height="177px" Text="program3" Width="237px" />
        </p>
        <p style="text-align: center">
            <asp:Button ID="Button4" runat="server" Height="177px" Text="program4" Width="237px" />
        </p>
    </form>
</body>
</html>
 