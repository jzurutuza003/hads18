﻿<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Profesor.aspx.vb" Inherits="Profesor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
         <div align="center" style="background-color: #C0C0C0; font-size: xx-large" >
                <strong>PROFESOR<br />GESTIÓN WEB DE TAREAS-DEDICACIÓN</strong></div>
        <div style="font-size: xx-large; margin-left: 2px;" align="center">
       
            <asp:HyperLink ID="Tareas" runat="server" ForeColor="#3366FF" style="text-decoration: underline" NavigateUrl="~/TareasProfesor.aspx">Tareas</asp:HyperLink>
            &nbsp;&nbsp;&nbsp;
            <asp:HyperLink ID="Grupos" runat="server" ForeColor="#3366FF" style="text-decoration: underline">Grupos</asp:HyperLink>
            &nbsp;&nbsp;&nbsp;
            <asp:HyperLink ID="Asignaturas" runat="server" ForeColor="#3366FF" style="text-decoration: underline">Asignaturas</asp:HyperLink>
        &nbsp;&nbsp;&nbsp;
            <asp:HyperLink ID="HyperLink1" runat="server" ForeColor="#3366FF" NavigateUrl="~/ImportarTareas.aspx">Importar tareas</asp:HyperLink>
        </div>
    </form>
</body>
</html>
