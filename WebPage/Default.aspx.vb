﻿Imports DB
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles Pass.TextChanged

    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim result As String
        result = conectar()

    End Sub


    Protected Sub Page_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
        cerrarconexion()
    End Sub


    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Login.Click
        Dim s As String
        s = loguearse(Email.Text, Pass.Text)
        If s.Equals("P") Then
            Session.Add("Correo", Email.Text)
            Response.Redirect("Profesor.aspx")
        Else
            If (s.Equals("A")) Then
                Session.Add("Correo", Email.Text)
                Response.Redirect("Alumno.aspx")
            Else
                Label1.Text = "Correo/password incorrectos"
            End If
        End If

    End Sub
    Protected Sub Email_TextChanged(sender As Object, e As EventArgs) Handles Email.TextChanged

    End Sub
End Class
