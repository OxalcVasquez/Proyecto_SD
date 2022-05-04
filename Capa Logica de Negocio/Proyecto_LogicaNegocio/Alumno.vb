Imports Proyecto_Datos
Imports Proyecto_Entidades
Public Class Alumno
    Private objconexion As New Sql_server

    Public Function insertar_alumno(ByVal obj_e_alumno As Entidad_alumno) As Boolean
        Try
            Dim sql As String
            sql = "insert into alumno values((select max(alumno_id) + 1 from alumno),'" & obj_e_alumno.p_ape_paterno & "','" & obj_e_alumno.p_ape_materno & "','" & obj_e_alumno.p_nombres & "','" & obj_e_alumno.p_sexo & "','" & obj_e_alumno.p_fecha_nacimiento & "','" & obj_e_alumno.p_semestre_ingreso & "','" & obj_e_alumno.p_dni & "'," & obj_e_alumno.p_escuela_id & ")"
            objconexion.actualizarSQL(sql)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function modificar_alumno(ByVal obj_e_alumno As Entidad_alumno) As Boolean
        Try
            Dim sql As String
            sql = "update alumno set ape_paterno = '" & obj_e_alumno.p_ape_paterno & "', ape_materno = '" & obj_e_alumno.p_ape_materno & "' , nombres = '" & obj_e_alumno.p_nombres & "' ,sexo  = '" & obj_e_alumno.p_sexo & "' ,fecha_nacimiento = '" & obj_e_alumno.p_fecha_nacimiento & "' ,semestre_ingreso  = '" & obj_e_alumno.p_semestre_ingreso & "' , dni = '" & obj_e_alumno.p_dni & "' where alumno_id =" & obj_e_alumno.p_alumno_id
            objconexion.actualizarSQL(sql)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function eliminar_alumno(ByVal alum_id As Integer) As Boolean
        Try
            Dim sql As String
            sql = "delete from alumno where alumno_id=" & alum_id
            objconexion.actualizarSQL(sql)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function listar_alumnos() As DataTable
        Dim sql As String
        sql = "select * from alumno"
        Return objconexion.consultaSQL(sql)
    End Function


End Class
