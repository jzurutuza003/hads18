Imports System.Web.Services
Imports System.ComponentModel
Imports System.Data.SqlClient


' Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente.
' <System.Web.Script.Services.ScriptService()> _
<System.Web.Services.WebService(Namespace:="http://tempuri.org/")> _
<System.Web.Services.WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<ToolboxItem(False)> _
Public Class dedicaciones
    Inherits System.Web.Services.WebService

    <WebMethod()>
    Public Function obtenerDedicaciones(Asignatura As String) As String
        Dim st = "select avg(HReales) From EstudiantesTareas A inner join TareasGenericas T on A.CodTarea=T.Codigo where T.CodAsig='" & Asignatura & "' Group By T.CodAsig"
        Dim conexion As New SqlConnection
        Dim comando As New SqlCommand
        Dim numregs As String
        conexion.ConnectionString = "Server=tcp:zuru95.database.windows.net,1433;Database=zuru95;User ID=zuru95@zuru95;Password=Koalahads18;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"
        conexion.Open()

        comando = New SqlCommand(st, conexion)

        numregs = comando.ExecuteScalar

        conexion.Close()
        Return numregs
    End Function

End Class