<%@ Application Language="VB" %>

<script runat="server">

    Sub Application_Start(ByVal sender As Object, ByVal e As EventArgs)
        ' Code that runs on application startup
        Dim Alumnos As New ArrayList
        Dim Profesores As New ArrayList
        Application.Contents("Alumnos") = Alumnos
        Application.Contents("Profesores") = Profesores
    End Sub

    Sub Application_End(ByVal sender As Object, ByVal e As EventArgs)
        ' Code that runs on application shutdown
    End Sub

    Sub Application_Error(ByVal sender As Object, ByVal e As EventArgs)
        ' Code that runs when an unhandled error occurs
    End Sub

    Sub Session_Start(ByVal sender As Object, ByVal e As EventArgs)
        ' Code that runs when a new session is started
    End Sub

    Sub Session_End(ByVal sender As Object, ByVal e As EventArgs)
        Application.Lock()
        Dim s As String
        Dim a As New ArrayList
        s = Session("Tipo")
        If (s.Equals("P")) Then
            a = Application.Contents("Profesores")
            s = Session("Correo")
            a.Remove(s)
            Application.Contents("Profesores") = a
        ElseIf s.Equals("A") Then
            a = Application.Contents("Alumnos")
            s = Session("Correo")
            a.Remove(s)
            Application.Contents("Alumnos") = a
        Else

        End If

        Application.UnLock()

        ' Code that runs when a session ends. 
        ' Note: The Session_End event is raised only when the sessionstate mode
        ' is set to InProc in the Web.config file. If session mode is set to StateServer 
        ' or SQLServer, the event is not raised.
    End Sub

</script>