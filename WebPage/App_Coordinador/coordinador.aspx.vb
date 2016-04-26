
Partial Class App_Coordinador_Default
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dedicaci As New dedicaciones.dedicaciones
        Dim dedicacion As String = dedicaci.obtenerDedicaciones(DropDownList1.SelectedValue)
        If dedicacion = Nothing Then
            Label1.Text = 0
        Else
            Label1.Text = dedicacion
        End If


    End Sub
End Class
