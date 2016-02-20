Imports DB
Imports System.Data.SqlClient

Partial Class RecuperarPassword
    Inherits System.Web.UI.Page
    Dim Pregunta As String
    Dim Respuesta As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim result As String
        result = conectar()

    End Sub


    Protected Sub Page_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
        cerrarconexion()
    End Sub
    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim p As SqlDataReader
        Try
            p = DB.pregunta(TextBox2.Text)


            If p.Read() = False Then
                Label1.Text = "No existe el correo"
            Else
                Pregunta = p.Item("Pregunta")
                Session.Add("Respuesta", p.Item("Respuesta"))
                TextBox1.Text = Pregunta
                Session.Add("Correo", TextBox2.Text)
            End If
        Catch ex As Exception
            Label1.Text = "Ha ocurrido un error en el servidor"
        End Try

    End Sub
    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Answer.Text = "" Then
            Label1.Text = "Escriba una respuesta por favor"
        Else
            If Answer.Text.ToString.Equals(Session.Contents("Respuesta").ToString) Then
                Response.Redirect("CambiarContraseña.aspx")

            Else
                Label1.Text = Session.Contents("Respuesta")
            End If
        End If
    End Sub
    Protected Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Response.Redirect("Default.aspx")
    End Sub
End Class
