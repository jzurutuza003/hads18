Imports DB

Partial Class Registro
    Inherits System.Web.UI.Page



    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim result As String
        result = conectar()
        Label1.Text = result
    End Sub


    Protected Sub Page_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
        cerrarconexion()
    End Sub

    Protected Sub Insertar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Enviar.Click
        Dim result As String
        result = insertar(DNI.Text, Nombre.Text, ApellidoUno.Text, ApellidoDos.Text, Password.Text, Correo.Text, Pregunta.Text, Respuesta.Text)
        If result = 1 Then
            Response.Redirect("Default.aspx")
        Else
            Label1.Text = "No se ha podido registrar"
        End If
    End Sub
    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Response.Redirect("Default.aspx")
    End Sub
End Class
