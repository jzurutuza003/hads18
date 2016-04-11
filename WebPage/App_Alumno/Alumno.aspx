<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Alumno.aspx.vb" Inherits="Profesor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
         <div align="center" style="background-color: #C0C0C0; font-size: xx-large" >
                <strong>ALUMNO<br />GESTIÓN WEB DE TAREAS-DEDICACIÓN</strong></div>
        <div style="font-size: xx-large; margin-left: 2px;" align="center">
       
            <asp:HyperLink ID="Tareas" runat="server" ForeColor="#3366FF" style="text-decoration: underline" NavigateUrl="TareasAlumno.aspx">Tareas genericas</asp:HyperLink>
            &nbsp;&nbsp;&nbsp;
            <asp:HyperLink ID="Grupos" runat="server" ForeColor="#3366FF" style="text-decoration: underline">Tareas propias</asp:HyperLink>
            &nbsp;&nbsp;&nbsp;
            <asp:HyperLink ID="Asignaturas" runat="server" ForeColor="#3366FF" style="text-decoration: underline">Grupos</asp:HyperLink>
        </div>
    </form>
</body>
</html>
