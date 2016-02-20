<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Login.aspx.vb" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    </head>
<body style="height: 590px; width: 1783px">
    <form id="form1" runat="server">
    <div align="left" style="height: 589px; width: 1546px;"; width: 574px">
    
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        Correo:&nbsp;&nbsp;
        <asp:TextBox ID="Correo" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="Correo">* Necesario Correo</asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="RegularExpressionValidator" ControlToValidate="Correo" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">* Necesario Correo Válido</asp:RegularExpressionValidator>
        <br />
        <br />
        Contraseña:&nbsp; <asp:TextBox ID="Password" runat="server" TextMode="Password"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="Password">* Necesario Password</asp:RequiredFieldValidator>
        <br />
    
        <br />
        <asp:Button ID="Enviar" runat="server" Height="55px" Text="ENTRAR" Width="182px" />
        <br />
        <br />
        <asp:LinkButton ID="Link" runat="server" href="Registro.aspx">Registrarse</asp:LinkButton>
    
    </div>
    </form>
</body>
</html>
