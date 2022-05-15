Imports Proyecto_Entidades
Imports System.Data.SqlClient
Public Class ado_inscripcion
    Dim obj_comando As New SqlCommand 'Se utiliza para actualizar una tabla (sentencia sql, proc alm)
    Dim obj_conexion As New Sql_server
    Dim obj_transaccion As SqlTransaction


    Public Sub insert_inscripcion(ByVal objeto As Entidad_inscripcion, ByVal det_inscripcion As List(Of Entidad_detalle_inscripcion))
        Try
            obj_conexion.conectar()

            obj_transaccion = obj_conexion.p_conexion.BeginTransaction()

            obj_comando.CommandType = CommandType.StoredProcedure
            obj_comando.CommandText = "pa_insert_inscripcion"
            obj_comando.Parameters.Add("@tipo_pago", SqlDbType.VarChar, 1).Value = objeto.p_tipo_pago
            obj_comando.Parameters.Add("@numero_cuotas", SqlDbType.Int).Value = objeto.p_numero_cuotas
            obj_comando.Parameters.Add("@alumno_id", SqlDbType.Int).Value = objeto.p_alumno_id
            obj_comando.Parameters.Add("@estado", SqlDbType.Bit).Value = objeto.p_estado
            obj_comando.Parameters.Add("@evento_id", SqlDbType.Int).Value = objeto.p_evento_id
            obj_comando.Connection = obj_conexion.p_conexion
            obj_comando.Transaction = obj_transaccion
            obj_comando.ExecuteNonQuery()

            For Each obj_detalle As Entidad_detalle_inscripcion In det_inscripcion
                If obj_detalle.p_actividad_id > 0 Then
                    obj_comando.Parameters.Clear()
                    obj_comando.CommandType = CommandType.StoredProcedure
                    obj_comando.CommandText = "pa_insertar_detalle_inscripcion"
                    obj_comando.Parameters.Add("@actividad_id", SqlDbType.Int).Value = obj_detalle.p_actividad_id
                    obj_comando.Connection = obj_conexion.p_conexion
                    obj_comando.Transaction = obj_transaccion
                    obj_comando.ExecuteNonQuery()
                End If
            Next
            obj_transaccion.Commit()

            obj_conexion.desconectar()
        Catch ex As Exception
            obj_transaccion.Rollback()
            MsgBox(ex.Message)
        End Try


    End Sub

    Public Sub eliminar_inscripcion_pa(ByVal insc_id As Integer)
        Try
            obj_comando.CommandType = CommandType.StoredProcedure
            obj_comando.CommandText = "pa_eliminar_inscripcion"
            obj_comando.Parameters.Add("@insc_id", SqlDbType.Int, 0).Value = insc_id
            obj_comando.Connection = obj_conexion.p_conexion
            obj_conexion.conectar()
            obj_comando.ExecuteNonQuery()
            obj_conexion.desconectar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class
