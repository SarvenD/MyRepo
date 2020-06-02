<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="EnableDisable_ChangeWidth_TextBox.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            You can Enable and Disable this text box : 
            <asp:TextBox ID="txtEnableDisable" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnEnableDisable" runat="server" Text="Enable/Disable" OnClick="btnEnableDisable_click"/>
            <br />
            <asp:TextBox ID="TextBox1" runat="server" Width="117px"></asp:TextBox>
            <asp:Button ID="btnChangeWidth" runat="server" Text="Change Width" OnClick="btnChangeWidth_click" />
        </div>
    </form>
</body>
</html>
