<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Frmproduct.aspx.cs" Inherits="sep30mng.Frmproduct" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lblfrst" runat="server" Text="enter first name"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtfrst" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lbllast" runat="server" Text="Enter lastname"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtlast" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lbldob" runat="server" Text="enter date of birth"></asp:Label>
&nbsp;&nbsp;
        <asp:TextBox ID="txtdob" runat="server" OnTextChanged="txtdob_TextChanged" ReadOnly="True"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Calendar ID="c1" runat="server" BackColor="White" BorderColor="#3366CC" BorderWidth="1px" CellPadding="1" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#003399" Height="200px" Width="220px">
            <DayHeaderStyle BackColor="#99CCCC" ForeColor="#336666" Height="1px" />
            <NextPrevStyle Font-Size="8pt" ForeColor="#CCCCFF" />
            <OtherMonthDayStyle ForeColor="#999999" />
            <SelectedDayStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
            <SelectorStyle BackColor="#99CCCC" ForeColor="#336666" />
            <TitleStyle BackColor="#003399" BorderColor="#3366CC" BorderWidth="1px" Font-Bold="True" Font-Size="10pt" ForeColor="#CCCCFF" Height="25px" />
            <TodayDayStyle BackColor="#99CCCC" ForeColor="White" />
            <WeekendDayStyle BackColor="#CCCCFF" />
        </asp:Calendar>
        <br />
        <br />
        <asp:Label ID="lblcity" runat="server" Text="enter city"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtcity" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblstate" runat="server" Text="enter state"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtstate" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnsignup" runat="server" OnClick="btnsignup_Click" Text="signup" />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/welcome.aspx">viewcart</asp:LinkButton>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <div>
        </div>
    </form>
</body>
</html>
