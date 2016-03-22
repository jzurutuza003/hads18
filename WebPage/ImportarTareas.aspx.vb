Imports System.Data

Imports System.Data.SqlClient

Imports System.Xml
Imports DB


Partial Class Default2

    Inherits System.Web.UI.Page


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
            Xml1.DocumentSource = Server.MapPath("App_Data/" & DropDownList1.SelectedValue & ".xml")
            Xml1.TransformSource = Server.MapPath("App_Data/XSLTFile.xsl")
            Session.Add("set", dataset)
            Session.Add("adap", adap)

        End If
    End Sub
    Protected Sub Page_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
        cerrarconexion()
    End Sub
    Protected Sub DropDownList1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList1.SelectedIndexChanged

        Xml1.DocumentSource = Server.MapPath("App_Data/" & DropDownList1.SelectedValue & ".xml")
        Xml1.TransformSource = Server.MapPath("App_Data/XSLTFile.xsl")

        Label1.Text = ""

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

        LasTareas = documento.GetElementsByTagName("tarea")



        Dim b As Integer
        Dim bool As Boolean
        For Each p As XmlElement
            In LasTareas
            linea = tabla.NewRow()
            linea("Codigo") = p.ChildNodes(0).InnerText
            linea("Descripcion") = p.ChildNodes(1).InnerText
            linea("CodAsig") = DropDownList1.SelectedValue
            b = p.ChildNodes(2).InnerText
            linea("HEstimadas") = b
            bool = p.ChildNodes(3).InnerText
            If (bool.Equals("true")) Then
                linea("Explotacion") = 1
            Else
                linea("Explotacion") = 0
            End If

            linea("TipoTarea") = p.ChildNodes(4).InnerText
            tabla.Rows.Add(linea)

        Next
        Try
            adap = Session("adap")
            comando = New SqlCommandBuilder(adap)

            adap.Update(dataset, "tareas")
            dataset.AcceptChanges()
            Label1.Text = "El xml ha sido importado"
        Catch ex As Exception
            Label1.Text = "Alguna de las tareas del xml ya existia en la BD"
        End Try
    End Sub
End Class
