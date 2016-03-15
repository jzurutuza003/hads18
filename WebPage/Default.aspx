<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 240px">
    <form id="form1" runat="server">
    <div align="center">
    
        INICIAR SESIÓN<br />
        <br />
        E-mail:&nbsp; <asp:TextBox ID="Email" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        Password: <asp:TextBox ID="Pass" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Login" runat="server" Height="27px" Text="LOGIN" Width="98px" />
        <br />
        <br />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="Email" ErrorMessage="RequiredFieldValidator">* Correo requerido</asp:RequiredFieldValidator>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="Pass" ErrorMessage="RequiredFieldValidator">* Password requerido</asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="Email" ErrorMessage="RegularExpressionValidator" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">* Formato de correo invalido</asp:RegularExpressionValidator>
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
