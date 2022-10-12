<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="sep30demo.login" Trace="true" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Panel ID="Label2" runat="server">
            <asp:Label ID="Label1" runat="server" Text="enter user id"></asp:Label>

            <asp:TextBox ID="txt1" runat="server" ToolTip="enter valid name"></asp:TextBox>
            <br />
            enter password
            <asp:TextBox ID="txt2" runat="server" OnTextChanged="TextBox3_TextChanged" TextMode="Password" ToolTip="enter valid password"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Button" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:LinkButton ID="LinkButton1" runat="server">LinkButton</asp:LinkButton>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:ImageButton ID="ImageButton2" runat="server" AlternateText="who r u" ImageUrl="~/images/IMG_9249.JPG" ToolTip="enter valid details" Width="103px" />
            <br />

        </asp:Panel>


    </form>
    
</body>
</html>
