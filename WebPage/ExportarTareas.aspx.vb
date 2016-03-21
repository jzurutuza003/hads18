Imports System.Data
Imports System.Data.SqlClient
Imports System.Xml
Imports DB
Partial Class Default2
    Inherits System.Web.UI.Page



    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim settings As XmlWriterSettings = New XmlWriterSettings
        settings.Indent = True

        Dim writer As XmlWriter = XmlWriter.Create(Server.MapPath("Output_Data/" & DropDownList1.SelectedValue & ".xml"), settings)


        writer.WriteStartDocument()
        writer.WriteStartElement("tareas")

        For Each p As GridViewRow In GridView1.Rows

            writer.WriteStartElement("tarea")
            writer.WriteElementString("codigo", p.Cells.Item(0).Text)
            writer.WriteElementString("descripcion", p.Cells.Item(1).Text)
            writer.WriteElementString("hestimadas", p.Cells.Item(3).Text)
            writer.WriteElementString("explotacion", p.Cells.Item(4).Text)
            writer.WriteElementString("tipotarea", p.Cells.Item(5).Text)
            writer.WriteEndElement()

        Next

        writer.WriteEndElement()
        writer.WriteEndDocument()
        writer.Flush()

        writer.Close()



    End Sub
End Class
