﻿
Imports System.Data.SqlClient

Public Class datos
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

End Class
