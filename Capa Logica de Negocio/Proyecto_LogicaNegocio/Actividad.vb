Imports Proyecto_Datos
Imports Proyecto_Entidades
Public Class Actividad
    Private objconexion As New Sql_server

    Public Function insertar_activdad(ByVal obj_e_activdad As Entidad_actividad) As Boolean
        Try
            Dim sql As String
            sql = "insert into actividad values('" & obj_e_activdad.p_tipo & "','" & obj_e_activdad.p_nombre & "','" & obj_e_activdad.p_descripcion & "','" & obj_e_activdad.p_fecha & "','" & obj_e_activdad.p_h_inicio & "','" & obj_e_activdad.p_h_fin & "','" & obj_e_activdad.p_tiene_costo & "'," & obj_e_activdad.p_evento_id & ")"
            objconexion.actualizarSQL(sql)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function modificar_actividad(ByVal obj_e_activdad As Entidad_actividad) As Boolean
        Try
            Dim sql As String
            sql = "update actividad set tipo = '" & obj_e_activdad.p_tipo & "', nombre = '" & obj_e_activdad.p_nombre & "' , fecha = '" & obj_e_activdad.p_fecha & "' ,h_inicio  = '" & obj_e_activdad.p_h_inicio & "' ,h_fin = '" & obj_e_activdad.p_h_fin & "' ,tiene_costo  = '" & obj_e_activdad.p_tiene_costo & "' , evento_id = " & obj_e_activdad.p_evento_id & " where actividad_id =" & obj_e_activdad.p_actividad_id
            objconexion.actualizarSQL(sql)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function eliminar_actividad(ByVal acti_id As Integer) As Boolean
        Try
            Dim sql As String
            sql = "delete from actividad where actividad_id=" & acti_id
            objconexion.actualizarSQL(sql)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function listar_actividades() As DataTable
        Dim sql As String
        sql = "select * from actividad"
        Return objconexion.consultaSQL(sql)
    End Function

    Public Function listar_actividades_evento(ByVal even_id As Integer) As DataTable
        Dim sql As String
        sql = "select * from Actividad where evento_id=" & even_id
        Return objconexion.consultaSQL(sql)
    End Function

End Class
