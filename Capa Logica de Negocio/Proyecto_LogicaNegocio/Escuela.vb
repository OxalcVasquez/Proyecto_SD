Imports Proyecto_Datos
Imports Proyecto_Entidades
Public Class Escuela
    Private objconexion As New Sql_server
    Public Function insertar_escuela(ByVal obj_e_escuela As Entidad_escuela) As Boolean
        Try
            Dim sql As String
            sql = "insert into Escuela values((select max(escuela_id) + 1 from escuela),'" & obj_e_escuela.p_nombre_escuela & "'," & obj_e_escuela.p_facultad_id & ")"
            objconexion.actualizarSQL(sql)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function modificar_escuela(ByVal obj_e_escuela As Entidad_escuela) As Boolean
        Try
            Dim sql As String
            sql = "update escuela set nombre_escuela='" & obj_e_escuela.p_nombre_escuela & "', facultad_id = " & obj_e_escuela.p_facultad_id & " where escuela_id=" & obj_e_escuela.p_escuela_id
            objconexion.actualizarSQL(sql)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function eliminar_escuela(ByVal esc_id As Integer) As Boolean
        Try
            Dim sql As String
            sql = "delete from escuela where escuela_id=" & esc_id
            objconexion.actualizarSQL(sql)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function listar_escuelas() As DataTable
        Dim sql As String
        sql = "select * from escuela"
        Return objconexion.consultaSQL(sql)
    End Function


End Class
