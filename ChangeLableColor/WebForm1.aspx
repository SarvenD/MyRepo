<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ChangeLableColor.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            You can change the color of this label:
            <asp:Label ID="lblChangingColor" runat="server" Font-Bold="true" Font-Size="30pt" Text="Label"></asp:Label>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Change Color" OnClick="btn1_click" />
        </div>
        <asp:Panel ID="Panel1" runat="server">
            <asp:Button ID="Button2" runat="server" BackColor="Yellow" Height="50px" OnClick="btn2_click" Width="50px"/>
            <asp:Button ID="Button3" runat="server" BackColor="Red" Height="50px" OnClick="btn3_click" Width="50px"/>
            <asp:Button ID="Button4" runat="server" BackColor="Green" Height="50px" OnClick="btn4_click" Width="50px" />
            &nbsp;
            <asp:Button ID="btnSetColor" runat="server" Text="Select" OnClick="btnSetColor_click" />
        </asp:Panel>
    </form>
</body>
</html>
