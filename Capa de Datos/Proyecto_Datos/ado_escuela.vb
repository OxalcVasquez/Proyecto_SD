Imports Proyecto_Entidades
Imports System.Data.SqlClient
Public Class ado_escuela
    Dim obj_comando As New SqlCommand 'Se utiliza para actualizar una tabla (sentencia sql, proc alm)
    Dim obj_conexion As New Sql_server

    Public Function insert_escuela(ByVal objeto As Entidad_escuela) As Boolean
        Try
            obj_comando.CommandType = CommandType.StoredProcedure
            obj_comando.CommandText = "pa_insert_escuela"
            obj_comando.Parameters.Add("@nombre_escuela", SqlDbType.VarChar, 100).Value = objeto.p_nombre_escuela
            obj_comando.Parameters.Add("@facid", SqlDbType.Int, 0).Value = objeto.p_facultad_id
            obj_comando.Connection = obj_conexion.p_conexion
            obj_conexion.conectar()
            obj_comando.ExecuteNonQuery()
            obj_conexion.desconectar()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function insert_escuela_1(ByVal objeto As Entidad_escuela) As Integer
        Try
            obj_comando.CommandType = CommandType.StoredProcedure
            obj_comando.CommandText = "pa_insert_escuela_1"
            obj_comando.Parameters.Add("@nombre_escuela", SqlDbType.VarChar, 100).Value = objeto.p_nombre_escuela
            obj_comando.Parameters.Add("@facid", SqlDbType.Int, 0).Value = objeto.p_facultad_id
            '----------------------Configurando un parametro de salida
            obj_comando.Parameters.Add("@id", SqlDbType.Int, 0).Value = 0
            obj_comando.Parameters.Item("@id").Direction = ParameterDirection.Output
            '---------------------------------------------------------
            obj_comando.Connection = obj_conexion.p_conexion
            obj_conexion.conectar()
            obj_comando.ExecuteNonQuery()
            Dim codigo As Integer = obj_comando.Parameters.Item("@id").Value
            obj_conexion.desconectar()
            Return codigo
        Catch ex As Exception
            Return -1
        End Try
    End Function

    Public Function modificar_escuela_pa(ByVal objeto As Entidad_escuela) As Boolean
        Try
            obj_comando.CommandType = CommandType.StoredProcedure
            obj_comando.CommandText = "pa_modificar_escuela"
            obj_comando.Parameters.Add("@esc_id", SqlDbType.Int, 0).Value = objeto.p_escuela_id
            obj_comando.Parameters.Add("@nombre_escuela", SqlDbType.VarChar, 100).Value = objeto.p_nombre_escuela
            obj_comando.Parameters.Add("@fac_id", SqlDbType.Int, 0).Value = objeto.p_facultad_id
            obj_comando.Connection = obj_conexion.p_conexion
            obj_conexion.conectar()
            obj_comando.ExecuteNonQuery()
            obj_conexion.desconectar()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function eliminar_escuela_pa(ByVal esc_id As Integer) As Boolean
        Try
            obj_comando.CommandType = CommandType.StoredProcedure
            obj_comando.CommandText = "pa_eliminar_escuela"
            obj_comando.Parameters.Add("@esc_id", SqlDbType.Int, 0).Value = esc_id
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
