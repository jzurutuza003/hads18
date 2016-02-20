Imports DB
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim result As String
        result = conectar()

    End Sub


    Protected Sub Page_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
        cerrarconexion()
    End Sub


    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim s As Integer
        s = loguearse(TextBox1.Text, TextBox2.Text)
        If s = 1 Then
            Label3.Text = "Ok"
            Response.Redirect("WebApplication/inicio.html")
        Else
            Label3.Text = "No existe"
        End If

    End Sub
End Class
