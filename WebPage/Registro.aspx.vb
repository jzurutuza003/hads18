Imports DB

Partial Class Registro
    Inherits System.Web.UI.Page


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim result As String
        result = conectar()
        Label1.Text = result
    End Sub
    Protected Sub Insertar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim r As Registro

        r.g
    End Sub

End Class