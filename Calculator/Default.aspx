<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Calculator.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            width: 92px;
        }
        .auto-style3 {
            width: 104px;
        }
        .auto-style4 {
            width: 66px;
        }
        .auto-style5 {
            width: 80px;
        }
        .auto-style6 {
            width: 68px;
        }
        .auto-style7 {
            width: 65px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width:100%;">
                <tr>
                    <td class="auto-style5" colspan="4">
                        <asp:TextBox ID="txtBoxResult" runat="server" Height="39px" OnTextChanged="txtBoxResult_TextChanged" TextMode="MultiLine" Width="269px"></asp:TextBox>
                    </td>
                    <td class="auto-style4" colspan="3">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5" colspan="4">
                        <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" Text="Clear" Width="276px" />
                    </td>
                    <td class="auto-style4" colspan="3">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style7">
                        <asp:Button ID="btnSeven" runat="server" OnClick="btnSeven_Click" Text="7" Width="55px" />
                    </td>
                    <td class="auto-style6">
                        <asp:Button ID="btnEight" runat="server" OnClick="btnEight_Click" Text="8" Width="55px" />
                    </td>
                    <td class="auto-style6">
                        <asp:Button ID="btnNine" runat="server" OnClick="btnNine_Click" Text="9" Width="55px" />
                    </td>
                    <td>
                        <asp:Button ID="btnMultiply" runat="server" OnClick="btnMultiply_Click" Text="*" Width="55px" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style7">
                        <asp:Button ID="btnFour" runat="server" OnClick="btnFour_Click" Text="4" Width="55px" />
                    </td>
                    <td class="auto-style6">
                        <asp:Button ID="btnFive" runat="server" OnClick="btnFive_Click" Text="5" Width="55px" />
                    </td>
                    <td class="auto-style6">
                        <asp:Button ID="btnSix" runat="server" OnClick="btnSix_Click" Text="6" Width="55px" />
                    </td>
                    <td>
                        <asp:Button ID="btnDivide" runat="server" OnClick="btnDivide_Click" Text="/" Width="55px" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style7">
                        <asp:Button ID="btnOne" runat="server" OnClick="btnOne_Click" Text="1" Width="55px" />
                    </td>
                    <td class="auto-style6">
                        <asp:Button ID="btnTwo" runat="server" OnClick="btnTwo_Click" Text="2" Width="55px" />
                    </td>
                    <td class="auto-style6">
                        <asp:Button ID="btnThree" runat="server" OnClick="btnThree_Click" Text="3" Width="55px" />
                    </td>
                    <td>
                        <asp:Button ID="btnMinus" runat="server" OnClick="btnMinus_Click" Text="-" Width="55px" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style7">
                        <asp:Button ID="btnZero" runat="server" OnClick="btnZero_Click" Text="0" Width="74px" />
                    </td>
                    <td class="auto-style2" colspan="2">
                        <asp:Button ID="btnEqual" runat="server" OnClick="btnEqual_Click" Text="=" Width="125px" />
                    </td>
                    <td class="auto-style3" colspan="2">
                        <asp:Button ID="btnPlus" runat="server" OnClick="btnPlus_Click" Text="+" Width="55px" />
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
