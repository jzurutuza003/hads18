<%@ Page Language="VB" AutoEventWireup="false" CodeFile="ExportarTareas.aspx.vb" Inherits="Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
         <div align="center" style="background-color: #C0C0C0; font-size: xx-large" >
                <strong>PROFESOR<br />EXPORTAR TAREAS GENERICAS</strong></div>
    
    </div>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Selecciona la asignatura a exportar:"></asp:Label>
        <br />
        <br />
            <asp:DropDownList ID="DropDownList1" runat="server" Height="16px" Width="206px" AutoPostBack="True" CausesValidation="True" DataMember="DefaultView">
            </asp:DropDownList>
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Height="64px" Text="Exportar XML" Width="198px" />
        <br />
        <br />
        <asp:Label ID="Label2" runat="server"></asp:Label>
        <br />
        <br />
        <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/Profesor.aspx">Menú profesor</asp:LinkButton>
        <br />
    </form>
</body>
</html>
