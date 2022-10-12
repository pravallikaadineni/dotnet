<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="userregistration.aspx.cs" Inherits="sep30demo.userregistration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            Select from the list<asp:DropDownList ID="DropDownList1" runat="server" Height="21px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" style="margin-left: 35px" AutoPostBack="True">
                <asp:ListItem>PersonalDetails</asp:ListItem>
                <asp:ListItem>EducationDetails</asp:ListItem>
                <asp:ListItem>BankDetails</asp:ListItem>
            </asp:DropDownList>
            <asp:Button ID="btnsubmit" runat="server" OnClick="Button1_Click" style="margin-left: 59px" Text="Submit" Width="122px" />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
        </div>
        <asp:MultiView ID="Userdata" runat="server">
            <br />
            <br />
            <asp:View ID="PersonalDetails" runat="server">
                Enter the first name&nbsp;&nbsp;
                <asp:TextBox ID="txtfirst" runat="server" MaxLength="20"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" BackColor="White" BorderColor="#99FF66" BorderStyle="Groove" ControlToValidate="txtfirst" ErrorMessage="it is mandatory" ForeColor="Red"></asp:RequiredFieldValidator>
                <br />
                enter the address&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtlast" runat="server" TextMode="MultiLine"></asp:TextBox>
                <br />
                enter mobile no&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtmobile" runat="server" MaxLength="10" TextMode="Number"></asp:TextBox>
                <br />
                enter age&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
&nbsp;
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox1" ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>
                &nbsp;&nbsp;
                <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="RangeValidator" MaximumValue="60" MinimumValue="16"></asp:RangeValidator>
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
                upload resume&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
                <br />
                <asp:FileUpload ID="FileUpload1" runat="server" AllowMultiple="True" />
                &nbsp;&nbsp;
                <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="submit" />
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </asp:View>
            <br />
            <br />
            <asp:View ID="EducationDetails" runat="server">
                Enter the Educational Details
            </asp:View>
            <br />
            <br />
            <br />
            <asp:View ID="BankDetails" runat="server">
                Enter the Bank Details
            </asp:View>
            <br />
            <br />
            <br />
        </asp:MultiView>
    </form>
    <p>
&nbsp;</p>
</body>
</html>