
Partial Class InsertarTarea
    Inherits System.Web.UI.Page

    Protected Sub AñadirTarea_Click(sender As Object, e As EventArgs) Handles AñadirTarea.Click
        insertar.Insert()
    End Sub
End Class
