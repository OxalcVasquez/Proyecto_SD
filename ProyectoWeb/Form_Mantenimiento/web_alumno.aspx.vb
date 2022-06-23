Public Class web_alumno
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ws As New ServiceReference1.web_service_alumnoSoapClient
        GridView1.DataSource = ws.getDataAlumno()
        GridView1.DataBind()





    End Sub
End Class