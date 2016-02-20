<%@ Page Language="VB" AutoEventWireup="false" CodeFile="CambiarContraseña.aspx.vb" Inherits="Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>CambiarContraseña</title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 240px; width: 434px; background-color: lightblue; padding: 20px">
    
        <asp:Label ID="Label1" runat="server" Text="Escriba la nueva contraseña:"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Escriba la contraseña" ControlToValidate="TextBox1"></asp:RequiredFieldValidator>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Vuelva a escribir la contraseña:"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox1" ControlToValidate="TextBox2" ErrorMessage="Las contraseñas no coinciden"></asp:CompareValidator>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Escriba la comfirmacion" ControlToValidate="TextBox2"></asp:RequiredFieldValidator>
        <br />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Comfirmar" />
    
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
    
    </div>
    </form>
</body>
</html>
