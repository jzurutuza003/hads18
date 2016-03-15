Imports System.Data
Imports System.Data.SqlClient
Imports DB
Partial Class Default2
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If (Session.Contents("Añadido")) Then
            Dim tabla As DataTable
            Dim sett As DataSet
            Dim adapter As SqlDataAdapter
            adapter = Session("Genericas")
            sett = Session("Dataset")
            tabla = sett.Tables("TareasGenericas")
            tabla.Rows.RemoveAt(GridView1.SelectedIndex)
            adapter.Update(sett, "TareasGenericas")
            sett.AcceptChanges()


        End If
        If (IsPostBack) Then
        Else


            Dim result As String
        cerrarconexion()
        result = conectar()
        Dim p As SqlDataReader
        p = DB.asignaturas()


        While p.Read() = True
            DropDownList1.Items.Add(p.Item("codigo"))

        End While
        Session.Add("Asig", DropDownList1.SelectedValue)
        End If
    End Sub
    Protected Sub Page_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
        cerrarconexion()
    End Sub
    Protected Sub DropDownList1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList1.SelectedIndexChanged

    End Sub
    Protected Sub GridView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GridView1.SelectedIndexChanged
        Session.Add("Tarea", GridView1.SelectedRow.Cells.Item(1).Text)
        Response.Redirect("InstanciarTarea.aspx")
    End Sub
    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim check As ArrayList
        Dim p As Integer
        Dim h As SqlDataAdapter

        Dim tabla As DataTable
        Dim Dataset As DataSet = New DataSet
        Dim columna As DataColumn
        h = DB.tareas(DropDownList1.SelectedValue)
        h.Fill(Dataset, "TareasGenericas")
        columna = New DataColumn
        Session.Add("Genericas", h)
        Session.Add("Dataset", Dataset)
        tabla = Dataset.Tables("TareasGenericas")
        check = New ArrayList
        p = 0
        While (p < 6)
            check.Add(tabla.Columns.Item(p))
            p = p + 1
        End While

        tabla.Columns.Add()
        tabla.Columns.RemoveAt(6)
        tabla.Columns.Remove(check.Item(2))
        tabla.Columns.Remove(check.Item(4))
        If Not CheckBox1.Checked Then
            tabla.Columns.Remove(check.Item(0))
        End If
        If Not CheckBox2.Checked Then
            tabla.Columns.Remove(check.Item(1))
        End If
        If Not CheckBox3.Checked Then
            tabla.Columns.Remove(check.Item(3))
        End If
        If Not CheckBox4.Checked Then
            tabla.Columns.Remove(check.Item(5))
        End If

        GridView1.DataSource = Dataset.Tables("TareasGenericas")
        GridView1.DataBind()

        GridView1.Visible = True
    End Sub


End Class
