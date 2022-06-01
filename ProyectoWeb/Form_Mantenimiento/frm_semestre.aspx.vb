Imports Proyecto_LogicaNegocio
Imports Proyecto_Entidades
Public Class frm_semestre
    Inherits System.Web.UI.Page
    Private obj_semestre As New Semestre
    Private obj_e_semestre As New Entidad_semestre

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        refrescar_grilla()
    End Sub
    Public Sub refrescar_grilla()
        Me.dgv_semestre.DataSource = obj_semestre.listar_semestres()
        Me.dgv_semestre.DataBind()

    End Sub

    Protected Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        limpiar()
    End Sub

    Public Sub limpiar()
        txt_codigo.Text = ""
    End Sub

    Protected Sub btn_grabar_Click(sender As Object, e As EventArgs) Handles btn_grabar.Click
        Try
            obj_e_semestre.p_semestre_id = txt_codigo.Text
            obj_e_semestre.p_estado = chk_estado.Checked
            obj_e_semestre.p_f_inicio = cal_inicio.SelectedDate
            obj_e_semestre.p_f_fin = cal_fin.SelectedDate
            obj_semestre.insertar_semestre(obj_e_semestre)
            refrescar_grilla()
            limpiar()
        Catch ex As Exception

        End Try
    End Sub

    Protected Sub btn_modificar_Click(sender As Object, e As EventArgs) Handles btn_modificar.Click
        Try
            obj_e_semestre.p_semestre_id = txt_codigo.Text
            obj_e_semestre.p_estado = chk_estado.Checked
            obj_e_semestre.p_f_inicio = cal_inicio.SelectedDate
            obj_e_semestre.p_f_fin = cal_fin.SelectedDate
            obj_semestre.modificar_semestre(obj_e_semestre)
            refrescar_grilla()
            limpiar()
        Catch ex As Exception

        End Try
    End Sub

    Protected Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Try
            obj_semestre.eliminar_semestre(txt_codigo.Text)
            refrescar_grilla()
            limpiar()
        Catch ex As Exception

        End Try
    End Sub

    Protected Sub dgv_semestre_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dgv_semestre.SelectedIndexChanged
        Try
            txt_codigo.Text = dgv_semestre.SelectedRow.Cells(1).Text
            cal_inicio.SelectedDate = dgv_semestre.SelectedRow.Cells(2).Text
            cal_fin.SelectedDate = dgv_semestre.SelectedRow.Cells(3).Text
            chk_estado.Checked = dgv_semestre.SelectedRow.Cells(4).Text

        Catch ex As Exception
        End Try

    End Sub

    Protected Sub chk_estado_CheckedChanged(sender As Object, e As EventArgs) Handles chk_estado.CheckedChanged

    End Sub
End Class