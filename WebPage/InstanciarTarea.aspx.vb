Imports System.Data
Imports System.Data.SqlClient
Imports DB
Partial Class Default2
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim j As SqlDataAdapter

        Dim h As DataSet = New DataSet
        Dim result As String
        cerrarconexion()
        result = conectar()


        TextBox1.Text = Session.Contents("Correo")
        TextBox2.Text = Session.Contents("Tarea")

        j = tareasEstudiante(Session.Contents("Tarea"), Session.Contents("Correo"))
        j.Fill(h, "TareasEstudiante")
        Session.Add("Data", h)
        GridView1.DataSource = h.Tables("TareasEstudiante")
        GridView1.DataBind()

        GridView1.Visible = True
        Session.Add("adapter", j)
    End Sub
    Protected Sub Page_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
        cerrarconexion()
    End Sub
    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim h As DataSet
        Dim table As DataTable
        Dim row As DataRow
        Dim adapter As SqlDataAdapter

        h = Session.Contents("Data")
        table = h.Tables("TareasEstudiante")
        row = table.NewRow
        row("Email") = TextBox1.Text
        row("CodTarea") = TextBox2.Text
        row("HEstimadas") = TextBox3.Text
        row("HReales") = TextBox4.Text
        table.Rows.Add(row)
        adapter = Session.Contents("adapter")
        adapter.Update(h, "TareasEstudiante")
        h.AcceptChanges()
        Session.Add("Añadido", True)
        Response.Redirect("TareasAlumno.aspx")
    End Sub
End Class
