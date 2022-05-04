Imports System.Data.SqlClient
Public Class Sql_server
    Private obj_conexion As New SqlConnection
    Private obj_cadena As New SqlConnectionStringBuilder
    'Constructor
    Sub New()
        With obj_cadena
            .DataSource = "localhost"
            .IntegratedSecurity = True 'Me identifico con usuario de SQL Server -> False
            '.UserID = ""
            '.Password = ""
            .InitialCatalog = "bd_semana_ingenieria"
        End With
        obj_conexion.ConnectionString = obj_cadena.ToString
    End Sub

    Public ReadOnly Property p_conexion() As SqlConnection
        Get
            Return obj_conexion
        End Get
    End Property

    Public Function conectar() As Boolean
        Try
            obj_conexion.Open()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Sub desconectar()
        Try
            obj_conexion.Close()
        Catch ex As Exception
        End Try
    End Sub
    'Actualizacion : insert, delete, update
    'Recuperacion : select
    Public Function consultaSQL(ByVal sentencia As String) As DataTable
        Dim obj_adaptar As New SqlDataAdapter(sentencia, p_conexion)
        Dim obj_tabla As New DataTable
        obj_adaptar.Fill(obj_tabla)
        Return obj_tabla
    End Function
    Public Sub actualizarSQL(ByVal sentencia As String)
        Dim obj_comando As New SqlCommand()
        obj_comando.CommandType = CommandType.Text
        obj_comando.CommandText = sentencia
        obj_comando.Connection = p_conexion
        conectar()
        obj_comando.ExecuteNonQuery()
        desconectar()
    End Sub

End Class
