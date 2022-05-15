Imports Proyecto_Datos
Imports Proyecto_Entidades
Public Class Inscripcion
    Private objconexion As New Sql_server
    Private obj_ado_inscripcion As New ado_inscripcion


    Public Sub insertar_inscripcion(ByVal objeto As Entidad_inscripcion, ByVal det_inscripcion As List(Of Entidad_detalle_inscripcion))
        Try
            obj_ado_inscripcion.insert_inscripcion(objeto, det_inscripcion)
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Public Sub eliminar_inscripcion(ByVal ins_id As Integer)
        Try
            obj_ado_inscripcion.eliminar_inscripcion_pa(ins_id)
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub


    Public Function listar_inscripcion() As DataTable
        Dim sql As String
        sql = "select i.*, e.nombre_evento ,a.dni,concat(a.nombres,' ',a.ape_paterno,' ',a.ape_materno) as alumno from inscripcion i
                inner join alumno a on i.alumno_id  = a.alumno_id
                inner join evento e on i.evento_id   = e.evento_id"
        Return objconexion.consultaSQL(sql)
    End Function

    Public Function listar_inscripcion_alumno(ByVal dni As String) As DataTable
        Dim sql As String
        sql = "select i.*, e.nombre_evento ,a.dni,concat(a.nombres,' ',a.ape_paterno,' ',a.ape_materno) as alumno from inscripcion i
                inner join alumno a on i.alumno_id  = a.alumno_id
                inner join evento e on i.evento_id   = e.evento_id
                where a.dni = '" & dni & "' "
        Return objconexion.consultaSQL(sql)
    End Function

    Public Function listar_actividades_inscripcion(ByVal ins_id As Integer) As DataTable
        Dim sql As String
        sql = "select di.*, a.nombre as actividad from Detalle_inscripcion di 
        inner join actividad a on di.actividad_id = a.actividad_id
        where inscripcion_id = " & ins_id
        Return objconexion.consultaSQL(sql)
    End Function

    Public Function listar_actividades_detalle() As DataTable
        Dim sql As String
        sql = "select di.*, a.nombre as actividad from Detalle_inscripcion di 
        inner join actividad a on di.actividad_id = a.actividad_id"
        Return objconexion.consultaSQL(sql)
    End Function

    Public Function verificar_inscripcion_evento(ByVal even_id As Integer, ByVal al_id As Integer) As Boolean
        Dim sql As String
        sql = "select * from Inscripcion where evento_id = " & even_id & " and alumno_id = " & al_id & " and estado = 1"
        Return objconexion.consultaSQL(sql).Rows.Count() = 0
    End Function


End Class
