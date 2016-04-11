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
            Session.Add("Correo", Email.Text)
            FormsAuthentication.RedirectFromLoginPage("P", True)
            Response.Redirect("App_Profesor/Profesor.aspx")

        Else
            If (s.Equals("A")) Then
                Session.Add("Correo", Email.Text)
                FormsAuthentication.RedirectFromLoginPage("A", True)
                Response.Redirect("App_Alumno/Alumno.aspx")
            Else
                Label1.Text = "Correo/password incorrectos"
            End If
        End If

    End Sub
    Protected Sub Email_TextChanged(sender As Object, e As EventArgs) Handles Email.TextChanged

    End Sub
End Class
