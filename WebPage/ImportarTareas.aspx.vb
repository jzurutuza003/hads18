Imports System.Data

Imports System.Data.SqlClient

Imports System.Xml
Imports DB


Partial Class Default2

    Inherits System.Web.UI.Page


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If (IsPostBack = False) Then
            Dim adap As SqlDataAdapter
            Dim dataset As DataSet
            dataset = New DataSet()
            adap = tareasGenericas()
            adap.Fill(dataset, "tareas")

            Session.Add("set", dataset)
            Session.Add("adap", adap)

        End If
    End Sub
    Protected Sub DropDownList1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList1.SelectedIndexChanged

        Xml1.DocumentSource = Server.MapPath("App_Data/" & DropDownList1.SelectedValue & ".xml")
        Xml1.TransformSource = Server.MapPath("App_Data/XSLTFile.xsl")



    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim documento As XmlDocument = New XmlDocument
        Dim LasTareas As XmlNodeList
        Dim tabla As DataTable = New DataTable
        Dim dataset As DataSet = New DataSet
        Dim adap As SqlDataAdapter
        Dim linea As DataRow
        Dim comando As SqlCommandBuilder
        dataset = Session("set")
        tabla = dataset.Tables("tareas")
        documento.Load(Server.MapPath("App_Data/" & DropDownList1.SelectedValue & ".xml"))

        LasTareas = documento.GetElementsByTagName("Tarea")
        linea = tabla.NewRow

        For i = 0 To LasTareas.Count - 1

            linea("Codigo") = LasTareas(i).ChildNodes(0).Value
            linea("Descripcion") = LasTareas(i).ChildNodes(1).Value
            linea("CodAsig") = DropDownList1.SelectedValue
            linea("HEstimadas") = LasTareas(i).ChildNodes(2).Value

            If (LasTareas(i).ChildNodes(3).Value.Equals("true")) Then
                linea("Explotacion") = 1
            Else
                linea("Explotacion") = 0
            End If

            linea("TipoTarea") = LasTareas(i).ChildNodes(4).Value
            tabla.Rows.Add(linea)

        Next
        adap = Session("adap")
        comando = New SqlCommandBuilder(adap)
        adap.Update(dataset, "tarea")
        dataset.AcceptChanges()

    End Sub
End Class
