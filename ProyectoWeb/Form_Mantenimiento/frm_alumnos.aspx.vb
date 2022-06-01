Imports Proyecto_LogicaNegocio
Imports Proyecto_Entidades
Public Class frm_alumnos
    Inherits System.Web.UI.Page
    Private obj_escuela As New Escuela 'Capa Logica
    Private obj_semestre As New Semestre
    Private obj_alumno As New Alumno
    Private obj_e_alumno As New Entidad_alumno

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        refrescar_grilla()
        'isPostBack false primera carga
        If Not IsPostBack Then
            cbo_escuela.DataSource = obj_escuela.listar_escuelas()
            cbo_escuela.DataTextField = "nombre_escuela"
            cbo_escuela.DataValueField = "escuela_id"
            cbo_escuela.DataBind()


            cbo_semestre.DataSource = obj_semestre.listar_semestres()
            cbo_semestre.DataTextField = "semestre_id"
            cbo_semestre.DataValueField = "semestre_id"
            cbo_semestre.DataBind()
        End If
    End Sub

    Protected Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        limpiar()
    End Sub

    Public Sub limpiar()
        lbl_codigo.Text = ""
        txt_dni.Text = ""
        txt_nombres.Text = ""
        txt_paterno.Text = ""
        txt_materno.Text = ""
        txt_sexo.Text = ""
        cbo_semestre.SelectedIndex = 0
        cbo_escuela.SelectedIndex = 0

    End Sub
    Public Sub refrescar_grilla()
        Me.dgv_alumnos.DataSource = obj_alumno.listar_alumnos()
        Me.dgv_alumnos.DataBind()

    End Sub

    Protected Sub dgv_alumnos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dgv_alumnos.SelectedIndexChanged
        Try
            lbl_codigo.Text = dgv_alumnos.SelectedRow.Cells(1).Text
            txt_paterno.Text = dgv_alumnos.SelectedRow.Cells(2).Text
            txt_materno.Text = dgv_alumnos.SelectedRow.Cells(3).Text
            txt_nombres.Text = dgv_alumnos.SelectedRow.Cells(4).Text
            txt_sexo.Text = dgv_alumnos.SelectedRow.Cells(5).Text
            cal_fecha.SelectedDate = dgv_alumnos.SelectedValue(6).Text
            cbo_semestre.SelectedItem.Text = dgv_alumnos.SelectedRow.Cells(7).Text
            txt_dni.Text = dgv_alumnos.SelectedRow.Cells(8).Text
            Dim cod_esc As Integer = dgv_alumnos.SelectedRow.Cells(9).Text
            cbo_escuela.SelectedItem.Text = obj_escuela.listar_escuela(cod_esc).p_nombre_escuela

        Catch ex As Exception

        End Try
    End Sub

    Protected Sub btn_grabar_Click(sender As Object, e As EventArgs) Handles btn_grabar.Click
        Try
            obj_e_alumno.p_ape_materno = txt_materno.Text
            obj_e_alumno.p_ape_paterno = txt_paterno.Text
            obj_e_alumno.p_nombres = txt_nombres.Text
            obj_e_alumno.p_sexo = txt_sexo.Text
            obj_e_alumno.p_dni = txt_dni.Text
            obj_e_alumno.p_fecha_nacimiento = cal_fecha.SelectedDate
            obj_e_alumno.p_semestre_ingreso = cbo_semestre.SelectedValue
            obj_e_alumno.p_escuela_id = cbo_escuela.SelectedValue
            obj_alumno.insertar_alumno(obj_e_alumno)
            refrescar_grilla()
            limpiar()

        Catch ex As Exception

        End Try
    End Sub

    Protected Sub btn_modificar_Click(sender As Object, e As EventArgs) Handles btn_modificar.Click
        Try
            obj_e_alumno.p_alumno_id = lbl_codigo.Text
            obj_e_alumno.p_ape_materno = txt_materno.Text
            obj_e_alumno.p_ape_paterno = txt_paterno.Text
            obj_e_alumno.p_nombres = txt_nombres.Text
            obj_e_alumno.p_sexo = txt_sexo.Text
            obj_e_alumno.p_dni = txt_dni.Text
            obj_e_alumno.p_fecha_nacimiento = cal_fecha.SelectedDate
            obj_e_alumno.p_semestre_ingreso = cbo_semestre.SelectedValue
            obj_e_alumno.p_escuela_id = cbo_escuela.SelectedValue
            obj_alumno.modificar_alumno(obj_e_alumno)
            refrescar_grilla()
            limpiar()

        Catch ex As Exception

        End Try
    End Sub

    Protected Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Try
            obj_alumno.eliminar_alumno(lbl_codigo.Text)
            refrescar_grilla()
            limpiar()

        Catch ex As Exception

        End Try
    End Sub
End Class