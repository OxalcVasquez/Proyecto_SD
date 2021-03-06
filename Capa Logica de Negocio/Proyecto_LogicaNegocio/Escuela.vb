Imports Proyecto_Datos
Imports Proyecto_Entidades
Public Class Escuela
    Private objconexion As New Sql_server
    Private obj_adoescuela As New ado_escuela

    'Public Function insertar_escuela(ByVal obj_e_escuela As Entidad_escuela) As Boolean
    '    Try
    '        Dim sql As String
    '        sql = "insert into Escuela values((select max(escuela_id) + 1 from escuela),'" & obj_e_escuela.p_nombre_escuela & "'," & obj_e_escuela.p_facultad_id & ")"
    '        objconexion.actualizarSQL(sql)
    '        Return True
    '    Catch ex As Exception
    '        Return False
    '    End Try
    'End Function

    'Public Function insertar_escuela(ByVal obj_e_escuela As Entidad_escuela) As Boolean
    '    Try
    '        obj_adoescuela.insert_escuela(obj_e_escuela)
    '        Return True
    '    Catch ex As Exception
    '        Return False
    '    End Try
    'End Function
    Public Function insertar_escuela(ByVal obj_e_escuela As Entidad_escuela) As Integer
        Try
            Return obj_adoescuela.insert_escuela_1(obj_e_escuela)
        Catch ex As Exception
            Return -1
        End Try
    End Function

    'Public Function modificar_escuela(ByVal obj_e_escuela As Entidad_escuela) As Boolean
    '    Try
    '        Dim sql As String
    '        sql = "update escuela set nombre_escuela='" & obj_e_escuela.p_nombre_escuela & "', facultad_id = " & obj_e_escuela.p_facultad_id & " where escuela_id=" & obj_e_escuela.p_escuela_id
    '        objconexion.actualizarSQL(sql)
    '        Return True
    '    Catch ex As Exception
    '        Return False
    '    End Try
    'End Function

    Public Function modificar_escuela(ByVal obj_e_escuela As Entidad_escuela) As Boolean
        Try
            obj_adoescuela.modificar_escuela_pa(obj_e_escuela)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    'Public Function eliminar_escuela(ByVal esc_id As Integer) As Boolean
    '    Try
    '        Dim sql As String
    '        sql = "delete from escuela where escuela_id=" & esc_id
    '        objconexion.actualizarSQL(sql)
    '        Return True
    '    Catch ex As Exception
    '        Return False
    '    End Try
    'End Function

    Public Function eliminar_escuela(ByVal obj_e_escuela As Entidad_escuela) As Boolean
        Try
            obj_adoescuela.eliminar_escuela_pa(obj_e_escuela.p_escuela_id)
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

    Public Function listar_escuela(ByVal codigo As Integer) As Entidad_escuela
        Dim sql As String
        sql = "select * from escuela where escuela_id=" & codigo
        Dim dt As DataTable
        dt = objconexion.consultaSQL(sql)
        Dim fila As DataRow
        fila = dt.Rows(0) 'dt.Rows(dt.Rows.Count - 1)
        Dim obj_e_escuela As New Entidad_escuela
        obj_e_escuela.p_escuela_id = fila("escuela_id")
        obj_e_escuela.p_nombre_escuela = fila("nombre_escuela")
        obj_e_escuela.p_facultad_id = fila("facultad_id")


        Return obj_e_escuela
    End Function
End Class
