<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Registro.aspx.vb" Inherits="Registro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    </head>
<body>
    <form id="form1" runat="server">
    <div  style="padding: 20px; height: 617px; width: 434px; background-color: lightblue;">
        <asp:Label ID="Label1" runat="server"></asp:Label>
        <br />
        <br />
        DNI:&nbsp;
        <asp:TextBox ID="DNI" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="DNI">* Necesario DNI</asp:RequiredFieldValidator>
        <br />
        <br />
        Nombre:&nbsp;
        <asp:TextBox ID="Nombre" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="Nombre">* Necesario Nombre</asp:RequiredFieldValidator>
        <br />
        <br />
        1º Apellido:&nbsp;
        <asp:TextBox ID="ApellidoUno" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="ApellidoUno">* Necesario Apellido</asp:RequiredFieldValidator>
        <br />
        <br />
        2º Apellido:&nbsp;
        <asp:TextBox ID="ApellidoDos" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="ApellidoDos">* Necesario Apellido</asp:RequiredFieldValidator>
        <br />
        <br />
        Contraseña:
        <asp:TextBox ID="Password" runat="server" TextMode="Password"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="Password">* Necesario Contraseña</asp:RequiredFieldValidator>
        <br />
        <br />
        Confimración contraseña:&nbsp;
        <asp:TextBox ID="PasswordDos" runat="server" TextMode="Password"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="PasswordDos">* Necesario Confirmación</asp:RequiredFieldValidator>
        <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Las contraseñas no coinciden" ControlToCompare="Password" ControlToValidate="PasswordDos"></asp:CompareValidator>
        <br />
        <br />
        Correo:&nbsp;
        <asp:TextBox ID="Correo" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="Correo">* Necesario Correo</asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="RegularExpressionValidator" ControlToValidate="Correo" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">* Necesario Correo Válido</asp:RegularExpressionValidator>
        <br />
        <br />
        Pregunta seguridad:&nbsp; <asp:TextBox ID="Pregunta" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="Pregunta">* Necesario Pregunta</asp:RequiredFieldValidator>
        <br />
        <br />
        Respuesta seguridad:&nbsp;
        <asp:TextBox ID="Respuesta" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ErrorMessage="RequiredFieldValidator" ControlToValidate="Respuesta">* Necesario Respuesta</asp:RequiredFieldValidator>
        <br />
        <br />
        <br />
        <asp:Button ID="Enviar" runat="server" Height="51px" Text="REGISTRARSE" Width="210px" />
        <asp:Button ID="Button1" runat="server" Text="<-Atras" CausesValidation="False" />
        </div>
    </form>
</body>
</html>
