
Partial Class Default2
    Inherits System.Web.UI.Page

    Protected Sub DropDownList1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList1.SelectedIndexChanged

        Xml1.DocumentSource = Server.MapPath("App_Data/" & DropDownList1.SelectedValue & ".xml")
        Xml1.TransformSource = Xml1.TransformSource =Server.MapPath("App_Data/XSLTFile.xsl")
    End Sub
End Class
