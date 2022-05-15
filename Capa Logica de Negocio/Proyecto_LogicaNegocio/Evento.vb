Imports Proyecto_Datos
Imports Proyecto_Entidades
Public Class Evento
    Private objconexion As New Sql_server

    Public Function insertar_evento(ByVal obj_e_evento As Entidad_evento) As Boolean
        Try
            Dim sql As String
            sql = "insert into evento values((select max(evento_id) + 1 from evento),'" & obj_e_evento.p_nombre_evento & "','" & obj_e_evento.p_tipo_evento & "','" & obj_e_evento.p_semestre_id & "')"
            objconexion.actualizarSQL(sql)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function modificar_evento(ByVal obj_e_evento As Entidad_evento) As Boolean
        Try
            Dim sql As String
            sql = "update evento set nombre_evento='" & obj_e_evento.p_nombre_evento & "', tipo_evento = '" & obj_e_evento.p_tipo_evento & "', semestre_id = '" & obj_e_evento.p_semestre_id & "' where evento_id=" & obj_e_evento.p_evento_id
            objconexion.actualizarSQL(sql)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function eliminar_evento(ByVal even_id As Integer) As Boolean
        Try
            Dim sql As String
            sql = "delete from evento where evento_id=" & even_id
            objconexion.actualizarSQL(sql)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function listar_eventos() As DataTable
        Dim sql As String
        sql = "select * from evento"
        Return objconexion.consultaSQL(sql)
    End Function
    Public Function listar_eventos_vigentes() As DataTable
        Dim sql As String
        sql = "select * from evento e inner join semestre s on e.semestre_id = s.semestre_id where s.estado = 1"
        Return objconexion.consultaSQL(sql)
    End Function

    Public Function listar_evento(ByVal even_id As Integer) As Entidad_evento
        Dim sql As String
        sql = "select * from evento where evento_id=" & even_id
        Dim dt As DataTable
        dt = objconexion.consultaSQL(sql)
        Dim fila As DataRow
        fila = dt.Rows(0) 'dt.Rows(dt.Rows.Count - 1)
        Dim obj_e_evento As New Entidad_evento
        obj_e_evento.p_evento_id = fila("evento_id")
        obj_e_evento.p_nombre_evento = fila("nombre_evento")
        obj_e_evento.p_tipo_evento = fila("tipo_evento")
        obj_e_evento.p_semestre_id = fila("semestre_id")
        Return obj_e_evento
    End Function
End Class
