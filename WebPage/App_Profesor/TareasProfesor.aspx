<%@ Page Language="VB" AutoEventWireup="false" CodeFile="TareasProfesor.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
         <div align="center" style="background-color: #C0C0C0; font-size: xx-large" >
                <strong>PROFESOR<br />GESTIÓN DE TAREAS GENÉRICAS</strong></div>
         <div  >
       
             Seleccionar asignatura:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
             <asp:Button ID="NuevaTarea" runat="server" Height="27px" Text="Nueva Tarea" Width="170px"/>
             <br />
             <br />
             <asp:ScriptManager ID="ScriptManager1" runat="server">
             </asp:ScriptManager>
             <br />
             <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                 <ContentTemplate>
                     <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" DataSourceID="Asignaturas" DataTextField="codigo" DataValueField="codigo" Height="20px" Width="170px">
                     </asp:DropDownList>
<br />
                     <asp:SqlDataSource ID="Asignaturas" runat="server" ConnectionString="<%$ ConnectionStrings:zuru95ConnectionString2 %>" SelectCommand="SELECT [codigo] FROM [Asignaturas]"></asp:SqlDataSource>
<br />
                     <asp:GridView ID="GridView1" runat="server" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="Codigo" DataSourceID="Tabla" Width="498px">
                         <Columns>
                             <asp:CommandField ButtonType="Button" ShowEditButton="True" />
                             <asp:BoundField DataField="Codigo" HeaderText="Codigo" ReadOnly="True" SortExpression="Codigo" />
                             <asp:BoundField DataField="Descripcion" HeaderText="Descripcion" SortExpression="Descripcion" />
                             <asp:BoundField DataField="HEstimadas" HeaderText="HEstimadas" SortExpression="HEstimadas" />
                             <asp:CheckBoxField DataField="Explotacion" HeaderText="Explotacion" SortExpression="Explotacion" />
                         </Columns>
                     </asp:GridView>
                     <asp:SqlDataSource ID="Tabla" runat="server" ConnectionString="<%$ ConnectionStrings:zuru95ConnectionString %>" DeleteCommand="DELETE FROM [TareasGenericas] WHERE [Codigo] = @Codigo" InsertCommand="INSERT INTO [TareasGenericas] ([Codigo], [Descripcion], [HEstimadas], [Explotacion]) VALUES (@Codigo, @Descripcion, @HEstimadas, @Explotacion)" SelectCommand="SELECT [Codigo], [Descripcion], [HEstimadas], [Explotacion] FROM [TareasGenericas] WHERE ([CodAsig] = @CodAsig)" UpdateCommand="UPDATE [TareasGenericas] SET [Descripcion] = @Descripcion, [HEstimadas] = @HEstimadas, [Explotacion] = @Explotacion WHERE [Codigo] = @Codigo">
                         <DeleteParameters>
                             <asp:Parameter Name="Codigo" Type="String" />
                         </DeleteParameters>
                         <InsertParameters>
                             <asp:Parameter Name="Codigo" Type="String" />
                             <asp:Parameter Name="Descripcion" Type="String" />
                             <asp:Parameter Name="HEstimadas" Type="Int32" />
                             <asp:Parameter Name="Explotacion" Type="Boolean" />
                         </InsertParameters>
                         <SelectParameters>
                             <asp:ControlParameter ControlID="DropDownList1" Name="CodAsig" PropertyName="SelectedValue" Type="String" />
                         </SelectParameters>
                         <UpdateParameters>
                             <asp:Parameter Name="Descripcion" Type="String" />
                             <asp:Parameter Name="HEstimadas" Type="Int32" />
                             <asp:Parameter Name="Explotacion" Type="Boolean" />
                             <asp:Parameter Name="Codigo" Type="String" />
                         </UpdateParameters>
                     </asp:SqlDataSource>
<br />
<br />
<br />
<br />
                 </ContentTemplate>
             </asp:UpdatePanel>
             <br />
             <asp:LinkButton ID="LinkButton1" runat="server">Cerrar Sesión</asp:LinkButton>
             <br />
       
        </div>
    </form>
</body>
</html>
