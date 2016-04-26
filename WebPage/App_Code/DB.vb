Imports Microsoft.VisualBasic
Imports System.Data.SqlClient
Imports System.Data

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


    Public Shared Function insertar(ByVal DNI As Integer, ByVal nombre As String, ByVal apellidoUno As String, ByVal apellidoDos As String, ByVal password As String, ByVal correo As String, ByVal pregunta As String, ByVal respuesta As String) As String
        Dim confirmado As Integer = 1

        Dim st = "insert into Usuarios (email,nombre, pregunta, respuesta, dni,confirmado, grupo, tipo, pass ) values ('" & correo & " ','" & nombre & " ','" & pregunta & " ','" & respuesta & " ','" & DNI & " ', '" & confirmado & "', '1', 'A', '" & password & " ')"
        Dim numregs As Integer
        Try
            comando = New SqlCommand(st, conexion)

            numregs = comando.ExecuteNonQuery()
        Catch e As Exception
            Return 0
        End Try

        Return numregs
    End Function

    Public Shared Function loguearse(ByVal user As String, ByVal pass As String) As String
        Dim st = "Select tipo From Usuarios Where email='" & user & "' and pass='" & pass & "'"
        comando = New SqlCommand(st, conexion)
        Dim numregs As SqlDataReader
        Dim s As String
        Try
            numregs = comando.ExecuteReader
            numregs.Read()
            s = numregs.Item("tipo")



        Catch ex As Exception
            Return ex.Message
        End Try
        Return s
    End Function
    Public Shared Function pregunta(ByVal correo As String) As SqlDataReader

        Dim st = "Select * From Usuarios Where Correo='" & correo & "'"
        comando = New SqlCommand(st, conexion)
        Return (comando.ExecuteReader())

    End Function
    Public Shared Function asignaturas() As SqlDataReader
        Dim st = "Select codigo From Asignaturas"
        comando = New SqlCommand(st, conexion)
        Return (comando.ExecuteReader())
    End Function
    Public Shared Function tareas(ByVal asignatura As String) As SqlDataAdapter

        Dim h As SqlDataAdapter
        Dim sql As SqlCommand
        cerrarconexion()


        sql = New SqlCommand("updateTarea", conexion)
        Dim st = "Select * From TareasGenericas Where CodAsig='" & asignatura & "'and Explotacion='1'"
        h = New SqlDataAdapter(st, conexion)

        h.UpdateCommand = sql


        Return h
    End Function
    Public Shared Function tareas2(ByVal asignatura As String) As SqlDataAdapter

        Dim h As SqlDataAdapter
        Dim sql As SqlCommand
        cerrarconexion()


        sql = New SqlCommand("updateTarea", conexion)
        Dim st = "Select * From TareasGenericas Where CodAsig='" & asignatura & "'"
        h = New SqlDataAdapter(st, conexion)

        h.UpdateCommand = sql


        Return h
    End Function
    Public Shared Function getCommand() As SqlCommand


        Dim sql As SqlCommand
        cerrarconexion()


        sql = New SqlCommand("updateTarea", conexion)



        Return sql
    End Function
    Public Shared Function asignaturasProfesor(ByVal correo As String) As SqlDataReader

        Dim h As SqlDataReader
        Dim sql As SqlCommand




        Dim st = " Select P.codigoasig FROM GruposClase  P  inner join  ProfesoresGrupo H  On P.codigo = H.codigogrupo WHERE (H.email ='" & correo & "')"
        sql = New SqlCommand(st, conexion)


        h = sql.ExecuteReader

        Return h
    End Function

    Public Shared Function tareasGenericas() As SqlDataAdapter

        Dim h As SqlDataAdapter
        Dim sql As SqlCommand
        cerrarconexion()



        Dim st = "Select * From TareasGenericas"
        h = New SqlDataAdapter(st, conexion)




        Return h
    End Function
    Public Shared Function tareasEstudiante(ByVal asignatura As String, ByVal correo As String) As SqlDataAdapter

        Dim sql As SqlCommand

        cerrarconexion()
        Dim j As SqlDataAdapter

        sql = New SqlCommand("insertarr", conexion)
        sql.CommandType = CommandType.StoredProcedure


        Dim st = "Select * From EstudiantesTareas Where Email='" & correo & "'"
        j = New SqlDataAdapter(st, conexion)

        j.InsertCommand = sql




        Return j
    End Function
    Public Shared Function cambiarContraseña(ByVal pass As String, ByVal correo As String) As Integer
        Dim s As Integer
        Dim st = "Update  Usuarios Set pass='" & pass & "'Where email='" & correo & "'"
        Try
            comando = New SqlCommand(st, conexion)
            s = comando.ExecuteNonQuery()
        Catch ex As Exception
            Return 0
        End Try

        Return s


    End Function




End Class
