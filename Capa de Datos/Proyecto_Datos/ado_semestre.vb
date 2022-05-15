Imports Proyecto_Entidades
Imports System.Data.SqlClient

Public Class ado_semestre
    Dim obj_comando As New SqlCommand 'Se utiliza para actualizar una tabla (sentencia sql, proc alm)
    Dim obj_conexion As New Sql_server

    Public Function insert_semestre(ByVal objeto As Entidad_semestre) As String
        Try
            obj_comando.CommandType = CommandType.StoredProcedure
            obj_comando.CommandText = "pa_insert_semestre"
            obj_comando.Parameters.Add("@semestre_id", SqlDbType.Char, 6).Value = objeto.p_semestre_id
            obj_comando.Parameters.Add("@f_inicio", SqlDbType.Date).Value = objeto.p_f_inicio
            obj_comando.Parameters.Add("@f_fin", SqlDbType.Date).Value = objeto.p_f_fin
            obj_comando.Parameters.Add("@estado", SqlDbType.Bit).Value = objeto.p_estado

            obj_comando.Connection = obj_conexion.p_conexion
            obj_conexion.conectar()
            obj_comando.ExecuteNonQuery()
            obj_conexion.desconectar()
            Return "Correcto"
        Catch ex As Exception
            Return ex.ToString
        End Try
    End Function

    Public Function modificar_semestre(ByVal objeto As Entidad_semestre) As Boolean
        Try
            obj_comando.CommandType = CommandType.StoredProcedure
            obj_comando.CommandText = "pa_modificar_semestre"
            obj_comando.Parameters.Add("@semestre_id", SqlDbType.Char, 6).Value = objeto.p_semestre_id
            obj_comando.Parameters.Add("@f_inicio", SqlDbType.Date).Value = objeto.p_f_inicio
            obj_comando.Parameters.Add("@f_fin", SqlDbType.Date).Value = objeto.p_f_fin
            obj_comando.Parameters.Add("@estado", SqlDbType.Bit).Value = objeto.p_estado

            obj_comando.Connection = obj_conexion.p_conexion
            obj_conexion.conectar()
            obj_comando.ExecuteNonQuery()
            obj_conexion.desconectar()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function eliminar_semestre(ByVal sem_id As String) As Boolean
        Try
            obj_comando.CommandType = CommandType.StoredProcedure
            obj_comando.CommandText = "pa_eliminar_semestre"
            obj_comando.Parameters.Add("@semestre_id", SqlDbType.Char, 6).Value = sem_id
            obj_comando.Connection = obj_conexion.p_conexion
            obj_conexion.conectar()
            obj_comando.ExecuteNonQuery()
            obj_conexion.desconectar()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
End Class
