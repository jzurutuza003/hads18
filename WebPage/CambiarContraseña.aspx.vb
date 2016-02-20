Imports DB
Partial Class Default2
    Inherits System.Web.UI.Page
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim result As String
        result = conectar()

    End Sub


    Protected Sub Page_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
        cerrarconexion()
    End Sub
    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim s As Integer
        s = cambiarContraseña(TextBox1.Text, Session.Contents("Correo"))
        If s = 1 Then
            Response.Redirect("Default.aspx")
        Else
            Label1.Text = "Ha ocurrido un error"
        End If
    End Sub
End Class
