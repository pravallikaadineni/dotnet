<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="webformsproject.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="HI ! WELCOME TO THE PAGE"></asp:Label>
        <br />
        <br />
        <br />
        <asp:ImageButton ID="ImageButton1" runat="server" Height="244px" ImageUrl="~/images/aits pic.jpg" Width="472px" />
        <br />
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Select the below options to see the deatails"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnstud" runat="server" OnClick="btnstud_Click" Text="student details" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
&nbsp;<asp:Button ID="btnsub" runat="server" OnClick="btnsub_Click" Text="subject details" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
&nbsp;<asp:Button ID="btncls" runat="server" OnClick="btncls_Click" Text="class details" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <br />
        <br />
        <div>
        </div>
    </form>
</body>
</html>
