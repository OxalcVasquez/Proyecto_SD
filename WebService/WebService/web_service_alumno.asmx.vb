Imports System.ComponentModel
Imports System.Web.Services
Imports System.Web.Services.Protocols

' Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente.
' <System.Web.Script.Services.ScriptService()> _
<System.Web.Services.WebService(Namespace:="http://tempuri.org/")> _
<System.Web.Services.WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<ToolboxItem(False)> _
Public Class web_service_alumno
    Inherits System.Web.Services.WebService
    Dim ds As New DataSet


    <WebMethod()>
    Public Function getDataAlumno() As DataSet
        Dim con As SqlClient.SqlConnection
        Dim adaptador As SqlClient.SqlDataAdapter
        Dim comando As SqlClient.SqlCommand

        con = New SqlClient.SqlConnection("Server=localhost;Database=bd_semana_ingenieria;User Id=Sa;Password=12345;")
        adaptador = New SqlClient.SqlDataAdapter("select * from alumno", con)
        adaptador.Fill(ds)
        Return ds
    End Function

End Class