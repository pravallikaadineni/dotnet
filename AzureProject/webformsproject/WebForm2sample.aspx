<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2sample.aspx.cs" Inherits="webformsproject.WebForm2sample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="auto-style1">
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="RollNo" DataSourceID="SqlDataSource1" Height="463px" Width="953px" CssClass="auto-style2">
                <Columns>
                    <asp:BoundField DataField="RollNo" HeaderText="RollNo" ReadOnly="True" SortExpression="RollNo" />
                    <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                    <asp:BoundField DataField="DOB" HeaderText="DOB" SortExpression="DOB" />
                    <asp:BoundField DataField="ClassNo" HeaderText="ClassNo" SortExpression="ClassNo" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:RainbowSchoolConnectionString %>" SelectCommand="SELECT * FROM [Student] ORDER BY [RollNo]"></asp:SqlDataSource>
        </div>
        </div>
    </form>
</body>
</html>
