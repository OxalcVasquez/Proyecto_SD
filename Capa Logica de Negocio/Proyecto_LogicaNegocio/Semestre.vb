Imports Proyecto_Datos
Imports Proyecto_Entidades
Public Class Semestre
    Private objconexion As New Sql_server
    Public Function insertar_semestre(ByVal obj_e_semestre As Entidad_semestre) As Boolean
        Try
            Dim sql As String
            sql = "insert into semestre values('" & obj_e_semestre.p_semestre_id & "','" & obj_e_semestre.p_f_inicio & "','" & obj_e_semestre.p_f_fin & "','" & obj_e_semestre.p_estado & "')"
            objconexion.actualizarSQL(sql)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Function modificar_semestre(ByVal obj_e_semestre As Entidad_semestre) As Boolean
        Try
            Dim sql As String
            sql = "update semestre set f_inicio='" & obj_e_semestre.p_f_inicio & "', f_fin = '" & obj_e_semestre.p_f_fin & "', estado = '" & obj_e_semestre.p_estado & "' where semestre_id='" & obj_e_semestre.p_semestre_id & "'"
            objconexion.actualizarSQL(sql)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Function eliminar_semestre(ByVal sem_id As String) As Boolean
        Try
            Dim sql As String
            sql = "delete from semestre where semestre_id='" & sem_id & "'"
            objconexion.actualizarSQL(sql)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function listar_semestres() As DataTable
        Dim sql As String
        sql = "select * from semestre"
        Return objconexion.consultaSQL(sql)
    End Function

    Public Function listar_semestre(ByVal sem_id As String) As Entidad_semestre
        Dim sql As String
        sql = "select * from semestre where semestre_id='" & sem_id & "'"
        Dim dt As DataTable
        dt = objconexion.consultaSQL(sql)
        Dim fila As DataRow
        fila = dt.Rows(0) 'dt.Rows(dt.Rows.Count - 1)
        Dim obj_e_semestre As New Entidad_semestre
        obj_e_semestre.p_semestre_id = fila("semestre_id")
        obj_e_semestre.p_f_inicio = fila("f_inicio")
        obj_e_semestre.p_f_fin = fila("f_fin")
        obj_e_semestre.p_estado = fila("estado")
        Return obj_e_semestre
    End Function

End Class
