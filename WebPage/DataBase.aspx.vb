Imports System.Data.SqlClient

Public Class DataBase

    Private Shared conexion As New SqlConnection
    Private Shared comando As New SqlCommand
    Private Shared _catalog As Object

    Public Shared Function conectar() As String
        Try
            conexion.ConnectionString = "Server=tcp:zuru95.database.windows.net,1433;Database=zuru95;User ID=zuru95@zuru95;Password={your_password_here};Encrypt=True;TrustServerCertificate=False;Connection Timeout=30"
            conexion.Open()
        Catch ex As Exception
            Return "ERROR DE CONEXIÓN: " + ex.Message
        End Try
        Return "CONEXION OK"
    End Function
    Public Shared Function insertar(ByVal Nombre As String, ByVal Apellido1 As String, ByVal Contraseña As String, ByVal Correo As String, ByVal Pregunta As String, ByVal Respuesta As String, ByVal Apellido2 As String, ByVal DNI As String) As String
        Dim st = "insert into tabla (Nombre,Apellido1,Contraseña,Correo,Pregunta,Respuesta,Apellido2,DNI) values ('" & Nombre & "" & Apellido1 & "" & Contraseña & "" & Correo & "" & Pregunta & "" & Respuesta & "" & Apellido2 & "" & DNI & " ')"
        Dim numregs As Integer
        comando = New SqlCommand(st, conexion)
        Try
            numregs =
            comando.ExecuteNonQuery()
        Catch ex As Exception
            Return ex.Message
        End Try
        Return (numregs & " registro(s) insertado(s) en la BD ")
    End Function
End Class

