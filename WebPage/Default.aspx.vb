Imports System
Imports DB
Imports System.Web.Security
Partial Class _Default
    Inherits System.Web.UI.Page


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim result As String
        result = conectar()

    End Sub


    Protected Sub Page_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
        cerrarconexion()
    End Sub


    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Login.Click
        Dim s As String
        Dim wrapper As New Simple3Des(Pass.Text)
        Dim cipherText As String = wrapper.EncryptData(Email.Text)
        s = loguearse(Email.Text, cipherText)
        If s.Equals("P") Then
            If (Email.Text.Equals("vadillo@ehu.es")) Then
                Session.Add("Tipo", "P")
                Session.Add("Correo", Email.Text)
                FormsAuthentication.RedirectFromLoginPage("vadillo@ehu.es", True)
                Dim Arra As ArrayList
                Application.Lock()
                Arra = Application.Contents("Profesores")
                Arra.Add(Email.Text)
                Application.Contents("Profesores") = Arra
                Application.UnLock()
                Response.Redirect("App_Profesor/Profesor.aspx")
            Else

                Session.Add("Tipo", "P")
                Session.Add("Correo", Email.Text)
                FormsAuthentication.RedirectFromLoginPage("P", True)
                Dim Arra As ArrayList
                Application.Lock()
                Arra = Application.Contents("Profesores")
                Arra.Add(Email.Text)
                Application.Contents("Profesores") = Arra
                Application.UnLock()
                Response.Redirect("App_Profesor/Profesor.aspx")
            End If
        Else
                If (s.Equals("A")) Then
                Session.Add("Tipo", "A")
                Session.Add("Correo", Email.Text)
                FormsAuthentication.RedirectFromLoginPage("A", True)
                Dim Arra As ArrayList
                Application.Lock()

                Arra = Application.Contents("Alumnos")
                Arra.Add(Email.Text)
                Application.Contents("Alumnos") = Arra
                Application.UnLock()

                Response.Redirect("App_Alumno/Alumno.aspx")
            Else
                Label1.Text = "Correo/password incorrectos"
            End If
        End If

    End Sub
    Protected Sub Email_TextChanged(sender As Object, e As EventArgs) Handles Email.TextChanged

    End Sub
End Class
