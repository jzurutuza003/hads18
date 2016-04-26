<%@ Page Language="VB" AutoEventWireup="false" CodeFile="coordinador.aspx.vb" Inherits="App_Coordinador_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
                     <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" DataSourceID="Asignaturas" DataTextField="codigo" DataValueField="codigo" Height="20px" Width="170px">
                     </asp:DropDownList>
                     <asp:SqlDataSource ID="Asignaturas" runat="server" ConnectionString="<%$ ConnectionStrings:zuru95ConnectionString2 %>" SelectCommand="SELECT [codigo] FROM [Asignaturas]"></asp:SqlDataSource>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Dedicación media" />
        <br />
        <br />
        Media de dedicaciones -&gt;
        <asp:Label ID="Label1" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
