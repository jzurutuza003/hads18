Imports System.Data
Imports System.Data.SqlClient
Imports System.Xml
Imports DB
Partial Class Default2
    Inherits System.Web.UI.Page
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If (IsPostBack) Then
        Else


            Dim dataset As DataSet = New DataSet
            Dim tabla As DataTable = New DataTable
            Dim adap As SqlDataAdapter
            Dim reader As SqlDataReader

            DB.conectar()
            reader = DB.asignaturasProfesor(Session("correo"))
            While reader.Read() = True
                DropDownList1.Items.Add(reader.Item("codigoasig"))
            End While
            adap = DB.tareas2(DropDownList1.Items(0).Value)
            adap.Fill(dataset, "tareas")
            tabla = dataset.Tables("tareas")
            GridView1.DataSource = tabla
            GridView1.DataBind()
            GridView1.Visible = True
            Session.Add("set", dataset)
            Session.Add("adap", adap)

        End If
    End Sub
    Protected Sub Page_Unload(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Unload
        cerrarconexion()
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dataset As DataSet = New DataSet
        Dim tabla As DataTable = New DataTable
        Dim adap As SqlDataAdapter

        Dim documento As XmlDocument = New XmlDocument()
        Dim tareas As XmlElement
        dataset = Session("set")
        adap = Session("adap")
        tabla = dataset.Tables("tareas")

        documento.AppendChild(documento.CreateXmlDeclaration("1.0", "utf-8", "no"))
        tareas = documento.CreateElement("tareas")

        documento.AppendChild(tareas)


        For Each p As DataRow In tabla.Rows
            Dim tarea, codigo, descripcion, hestimadas, explotacion, tipotarea As XmlElement

            tarea = documento.CreateElement("tarea")
            codigo = documento.CreateElement("codigo")
            descripcion = documento.CreateElement("descripcion")
            hestimadas = documento.CreateElement("hestimadas")
            explotacion = documento.CreateElement("explotacion")
            tipotarea = documento.CreateElement("tipotarea")

            codigo.AppendChild(documento.CreateTextNode(p.Item(0)))
            descripcion.AppendChild(documento.CreateTextNode(p.Item(1)))
            hestimadas.AppendChild(documento.CreateTextNode(p.Item(3)))
            explotacion.AppendChild(documento.CreateTextNode(p.Item(4).ToString))
            tipotarea.AppendChild(documento.CreateTextNode(p.Item(5)))



            tarea.AppendChild(codigo)
            tarea.AppendChild(descripcion)
            tarea.AppendChild(hestimadas)
            tarea.AppendChild(explotacion)
            tarea.AppendChild(tipotarea)

            tareas.AppendChild(tarea)
        Next
        documento.Save(Server.MapPath("Output_Data/" & DropDownList1.SelectedValue & ".xml"))
        documento.Load(Server.MapPath("Output_Data/" & DropDownList1.SelectedValue & ".xml"))

        Dim LasTareas As XmlNodeList = documento.GetElementsByTagName("tareas")
        Dim atributo As XmlElement = LasTareas.Item(0)
        atributo.SetAttribute("xmlns:has", "http://ji.ehu.es/has")

        documento.Save(Server.MapPath("Output_Data/" & DropDownList1.SelectedValue & ".xml"))
        Label2.Text = "El documento xml se ha creado en la carpeta Output_Data"


    End Sub
    Protected Sub DropDownList1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList1.SelectedIndexChanged
        Dim dataset As DataSet = New DataSet
        Dim tabla As DataTable = New DataTable
        Dim adap As SqlDataAdapter

        adap = DB.tareas2(DropDownList1.SelectedValue)
        adap.Fill(dataset, "tareas")
        tabla = dataset.Tables("tareas")
        GridView1.DataSource = tabla
        GridView1.DataBind()
        GridView1.Visible = True
        Session.Add("set", dataset)
        Session.Add("adap", adap)
        Label2.Text = ""
    End Sub
End Class
