<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Button ID="GetButton" runat="server" OnClick="GetButton_Click" Text="GET" Height="24px" Width="81px" />
        <asp:Button ID="PostButton" runat="server" OnClick="PostButton_Click" Text="POST" Height="24px" Width="81px" />
        <asp:Button ID="PutButton" runat="server" OnClick="PutButton_Click" Text="PUT" Height="24px" Width="81px" />
    </form>
</body>
</html>
