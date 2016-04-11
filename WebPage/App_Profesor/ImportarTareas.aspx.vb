Imports System.Data

Imports System.Data.SqlClient

Imports System.Xml
Imports DB


Partial Class Default2

    Inherits System.Web.UI.Page

    Dim s As String = "OrdenadoCodigo.xsl"
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If (IsPostBack = False) Then
            Dim dataset As DataSet = New DataSet
            Dim tabla As DataTable = New DataTable
            Dim adap As SqlDataAdapter
            Dim reader As SqlDataReader

            DB.conectar()
            reader = DB.asignaturasProfesor(Session("correo"))
            While reader.Read() = True
                DropDownList1.Items.Add(reader.Item("codigoasig"))
            End While
            adap = tareasGenericas()
            adap.Fill(dataset, "tareas")
            Xml1.DocumentSource = Server.MapPath("../App_Data/" & DropDownList1.SelectedValue & ".xml")
            Xml1.TransformSource = Server.MapPath("../App_Data/" & s)
            Session.Add("set", dataset)
            Session.Add("adap", adap)

        End If
    End Sub
    Protected Sub Page_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
        cerrarconexion()
    End Sub
    Protected Sub DropDownList1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList1.SelectedIndexChanged

        Xml1.DocumentSource = Server.MapPath("../App_Data/" & DropDownList1.SelectedValue & ".xml")
        Xml1.TransformSource = Server.MapPath("../App_Data/" & s)

        Label1.Text = ""

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim documento As XmlDocument = New XmlDocument
        ' Dim LasTareas As XmlNodeList

        Dim tabla As DataTable = New DataTable
        Dim dataset As DataSet = New DataSet
        Dim adap As SqlDataAdapter
        Dim linea As DataRow
        Dim comando As SqlCommandBuilder
        'dataset = Session("set")



        'documento.Load(Server.MapPath("App_Data/" & DropDownList1.SelectedValue & ".xml"))

        'LasTareas = documento.GetElementsByTagName("tarea")

        dataset.ReadXml(Server.MapPath("../App_Data/" & DropDownList1.SelectedValue & ".xml"))

        dataset.Tables(0).TableName = "tarea"
        tabla = dataset.Tables("tarea")
        tabla.Columns(0).ColumnName = "Codigo"
        tabla.Columns(1).ColumnName = "Descripcion"
        tabla.Columns(2).ColumnName = "HEstimadas"
        tabla.Columns(3).ColumnName = "Explotacion"
        tabla.Columns(4).ColumnName = "TipoTarea"
        tabla.Columns.Add(New DataColumn("CodAsig"))
        For Each t As DataRow In tabla.Rows
            t.Item(5) = DropDownList1.SelectedValue

        Next


        'Dim b As Integer
        'Dim bool As Boolean
        'For Each p As XmlElement
        ' In LasTareas
        'linea = tabla.NewRow()
        'linea("Codigo") = p.ChildNodes(0).InnerText
        'linea("Descripcion") = p.ChildNodes(1).InnerText
        'linea("CodAsig") = DropDownList1.SelectedValue
        'b = p.ChildNodes(2).InnerText
        'linea("HEstimadas") = b
        'bool = p.ChildNodes(3).InnerText
        'If (bool.Equals("true")) Then
        ' linea("Explotacion") = 1
        'Else
        'linea("Explotacion") = 0
        'End If
        '
        ' linea("TipoTarea") = p.ChildNodes(4).InnerText
        'tabla.Rows.Add(linea)

        '  Next
        Try

            adap = Session("adap")
            comando = New SqlCommandBuilder(adap)
            adap.Update(dataset, "tarea")

            dataset.AcceptChanges()
            Label1.Text = "El xml ha sido importado"
        Catch ex As Exception
            Label1.Text = "Alguna de las tareas del xml ya existia en la BD"
        End Try
    End Sub
    Protected Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Xml1.DocumentSource = Server.MapPath("../App_Data/" & DropDownList1.SelectedValue & ".xml")
        Xml1.TransformSource = Server.MapPath("../App_Data/OrdenadoDescripcion.xsl")
    End Sub
    Protected Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        Xml1.DocumentSource = Server.MapPath("../App_Data/" & DropDownList1.SelectedValue & ".xml")
        Xml1.TransformSource = Server.MapPath("../App_Data/OrdenadoHEstimadas.xsl")
    End Sub
    Protected Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Xml1.DocumentSource = Server.MapPath("../App_Data/" & DropDownList1.SelectedValue & ".xml")
        Xml1.TransformSource = Server.MapPath("../App_Data/OrdenadoCodigo.xsl")
    End Sub
End Class
