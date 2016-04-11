Imports System.Data
Imports System.Data.SqlClient
Imports DB
Partial Class Default2
    Inherits System.Web.UI.Page
    Dim h As DataSet
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim j As SqlDataAdapter

        h = New DataSet
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

        Dim table As DataTable
        Dim row As DataRow
        Dim adapter As SqlDataAdapter
        Dim sql As SqlCommand

        Label1.Text = h.Tables("TareasEstudiante").Columns.Count


        Try
            table = h.Tables("TareasEstudiante")

            row = table.NewRow()
            Dim a As Integer = TextBox3.Text
            Dim b As Integer = TextBox4.Text
            row("Email") = TextBox1.Text
            row("CodTarea") = TextBox2.Text
            row("HEstimadas") = a
            row("HReales") = b
            table.Rows.Add(row)
            adapter = Session.Contents("adapter")
            sql = adapter.InsertCommand
            sql.Parameters.AddWithValue("Email", New SqlParameter).Value = TextBox1.Text
            sql.Parameters.AddWithValue("CodTarea", New SqlParameter).Value = TextBox2.Text
            sql.Parameters.AddWithValue("HEstimadas", New SqlParameter).Value = a
            sql.Parameters.AddWithValue("HReales", New SqlParameter).Value = b
            adapter.InsertCommand = sql


            GridView1.DataSource = h.Tables("TareasEstudiante")
            GridView1.DataBind()


            adapter.Update(h, "TareasEstudiante")
            h.AcceptChanges()
            Session.Add("Añadidoo", True)
            Label1.Text = "Instancia insertada en la BD"
        Catch excep As Exception
            Label1.Text = "Ya existe una instancia de esa tarea"
        End Try

    End Sub
End Class
