<%@ Page Language="VB" AutoEventWireup="false" CodeFile="RecuperarPassword.aspx.vb" Inherits="RecuperarPassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div align="left" style="height: 240px; width: 434px; background-color: lightblue; padding:20px">
        Question :<br />
        <asp:DropDownList ID="DropDownList1" runat="server" Height="41px" Width="271px">
        </asp:DropDownList>
        <br />
        Answer :<br />
        <asp:TextBox ID="Answer" runat="server" Height="16px" Width="247px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="Answer" ErrorMessage="RequiredFieldValidator">* Insert asnwer</asp:RequiredFieldValidator>
        <br />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Height="37px" Text="Button" Width="158px" />
            </div>
    </form>
</body>
</html>
