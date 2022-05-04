Imports Proyecto_Datos
Imports Proyecto_Entidades

Public Class Facultad
    Private objconexion As New Sql_server

    Public Function insertar_facultad(ByVal obj_e_facultad As Entidad_facultad) As Boolean
        Try
            Dim sql As String
            sql = "insert into facultad values((select max(facultad_id) + 1 from facultad),'" & obj_e_facultad.p_nombre_facultad & "')"
            objconexion.actualizarSQL(sql)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Function modificar_facultad(ByVal obj_e_facultad As Entidad_facultad) As Boolean
        Try
            Dim sql As String
            sql = "update facultad set nombre_facultad='" & obj_e_facultad.p_nombre_facultad & "' where facultad_id=" & obj_e_facultad.p_facultad_id
            objconexion.actualizarSQL(sql)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Function eliminar_facultad(ByVal fac_id As Integer) As Boolean
        Try
            Dim sql As String
            sql = "delete from facultad where facultad_id=" & fac_id
            objconexion.actualizarSQL(sql)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Function listar_facultades() As DataTable
        Dim sql As String
        sql = "select * from facultad"
        Return objconexion.consultaSQL(sql)
    End Function
    Public Function listar_facultad(ByVal codigo As Integer) As Entidad_facultad
        Dim sql As String
        sql = "select * from facultad where facultad_id=" & codigo
        Dim dt As DataTable
        dt = objconexion.consultaSQL(sql)
        Dim fila As DataRow
        fila = dt.Rows(0) 'dt.Rows(dt.Rows.Count - 1)
        Dim obj_e_facultad As New Entidad_facultad
        obj_e_facultad.p_facultad_id = fila("facultad_id")
        obj_e_facultad.p_nombre_facultad = fila("nombre_facultad")
        Return obj_e_facultad
    End Function
End Class
