<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ASPDotNetCRUDApplication.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 47%;
            height: 172px;
        }
        .auto-style3 {
            width: 17px;
        }
        .auto-style4 {
            width: 124px;
        }
        .auto-style6 {
            color: #33CCFF;
            font-size: x-large;
        }
        .auto-style8 {
            width: 51px;
        }
        .auto-style9 {
            width: 69%;
        }
        .auto-style10 {
            text-align: center;
        }
        .auto-style11 {
            width: 268435264px;
        }
        .auto-style12 {
            width: 188px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <center>
                <table class="auto-style1" align="center">
                    <caption class="auto-style6">
                        <strong>CRUD Operations</strong></caption>
                    <tr>
                        <td class="auto-style8">Name</td>
                        <td class="auto-style3">:</td>
                        <td class="auto-style4">
                            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                        </td>
                        <td class="auto-style12">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style8">Address</td>
                        <td class="auto-style3">:</td>
                        <td class="auto-style4">
                            <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
                        </td>
                        <td class="auto-style12">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style8">Email</td>
                        <td class="auto-style3">:</td>
                        <td class="auto-style4">
                            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                        </td>
                        <td class="auto-style12">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style8">&nbsp;</td>
                        <td class="auto-style3">&nbsp;</td>
                        <td class="auto-style4" colspan="2">
                            <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click"  />
                            <asp:Button ID="btnUpdate" runat="server" OnClick="btnUpdate_Click" Text="Update" />
                            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" />

                        </td>
                        <td>
                            <asp:Label ID="lblMsg" runat="server" ForeColor="#66FF66"></asp:Label>
                        </td>
                    </tr>
                </table>
            </center>
        </div>
    <table class="auto-style9">
        <tr >
            <td class="auto-style10" colspan="3">
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ClassConnectionString %>" SelectCommand="SELECT * FROM [Employee]"></asp:SqlDataSource>
            </td>
            <td class="auto-style11">
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Caption="Data Collection" CaptionAlign="Top" CellPadding="4" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None">
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <Columns>
                        <asp:BoundField DataField="FirstName" HeaderText="FirstName" SortExpression="FirstName" />
                        <asp:BoundField DataField="Address" HeaderText="Address" SortExpression="Address" />
                        <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
                    </Columns>
                    <EditRowStyle BackColor="#999999" />
                    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#E9E7E2" />
                    <SortedAscendingHeaderStyle BackColor="#506C8C" />
                    <SortedDescendingCellStyle BackColor="#FFFDF8" />
                    <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
    </form>
    </body>
</html>
