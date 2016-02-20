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
            Correo:<br />
            <asp:TextBox ID="TextBox2" runat="server" Width="247px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" Text="Buscar" />
            <br />
        Question :<br />
            <asp:TextBox ID="TextBox1" runat="server" ReadOnly="True" Width="246px"></asp:TextBox>
        <br />
        Answer :<br />
        <asp:TextBox ID="Answer" runat="server" Height="16px" Width="247px"></asp:TextBox>
  
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button3" runat="server" Text="<-Atras" />
        <asp:Button ID="Button1" runat="server" Height="37px" Text="Button" Width="158px" />
            <br />
&nbsp;&nbsp;&nbsp;
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
            </div>
    </form>
</body>
</html>
