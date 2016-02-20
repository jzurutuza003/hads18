Imports Microsoft.VisualBasic
Imports System.Data.SqlClient


Public Class DB

    Private Shared conexion As New SqlConnection
    Private Shared comando As New SqlCommand
    Private Shared _catalog As Object



    Public Shared Function conectar() As String
        Try
            conexion.ConnectionString = "Server=tcp:zuru95.database.windows.net,1433;Database=zuru95;User ID=zuru95@zuru95;Password=Koalahads18;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"
            conexion.Open()
        Catch ex As Exception
            Return "ERROR DE CONEXIÓN: " + ex.Message
        End Try
        Return "CONEXION OK"
    End Function

    Public Shared Sub cerrarconexion()
        conexion.Close()
    End Sub

    Public Shared Function insertar(ByVal DNI As String, ByVal nombre As String, ByVal apellidoUno As String, ByVal apellidoDos As String, ByVal password As String, ByVal correo As String, ByVal pregunta As String, ByVal respuesta As String) As String
        Dim st = "insert into Usuarios (Nombre, Apellido1, Contraseña, Correo, Pregunta, Respuesta, Apellido2, DNI) values ('" & nombre & " ','" & apellidoUno & " ','" & password & " ','" & correo & " ','" & pregunta & " ', '" & respuesta & " ', '" & apellidoDos & " ', '" & DNI & " ')"
        Dim numregs As Integer
        Try
            comando = New SqlCommand(st, conexion)

            numregs = comando.ExecuteNonQuery()
        Catch ex As Exception
            Return 0
        End Try
        Return numregs
    End Function

    Public Shared Function loguearse(ByVal user As String, ByVal pass As String) As Integer
        Dim st = "Select count(*) From Usuarios Where Correo='" & user & "' and Contraseña='" & pass & "'"
        comando = New SqlCommand(st, conexion)
        Dim numregs As Integer
        Try
            numregs = comando.ExecuteScalar()


        Catch ex As Exception
            Return ex.Message
        End Try
        Return numregs
    End Function
    Public Shared Function pregunta(ByVal correo As String) As SqlDataReader

        Dim st = "Select * From Usuarios Where Correo='" & correo & "'"
        comando = New SqlCommand(st, conexion)
        Return (comando.ExecuteReader())

    End Function
    Public Shared Function cambiarContraseña(ByVal pass As String, ByVal correo As String) As Integer
        Dim s As Integer
        Dim st = "Update  Usuarios Set Contraseña='" & pass & "'Where Correo='" & correo & "'"
        Try
            comando = New SqlCommand(st, conexion)
            s = comando.ExecuteNonQuery()
        Catch ex As Exception
            Return 0
        End Try

        Return s


    End Function
End Class
