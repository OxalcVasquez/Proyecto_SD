Imports Proyecto_LogicaNegocio
Imports Proyecto_Entidades
Public Class frm_evento
    Inherits System.Web.UI.Page
    Private obj_semestre As New Semestre
    Private obj_evento As New Evento
    Private obj_e_evento As New Entidad_evento

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        refrescar_grilla()
        'isPostBack false primera carga
        If Not IsPostBack Then

            cbo_semestre.DataSource = obj_semestre.listar_semestres()
            cbo_semestre.DataTextField = "semestre_id"
            cbo_semestre.DataValueField = "semestre_id"
            cbo_semestre.DataBind()
        End If
    End Sub
    Public Sub refrescar_grilla()
        Me.dgv_eventos.DataSource = obj_evento.listar_eventos()
        Me.dgv_eventos.DataBind()

    End Sub
    Public Sub limpiar()
        lbl_codigo.Text = ""
        txt_evento.Text = ""
        txt_tipo.Text = ""

    End Sub

    Protected Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        Try
            limpiar()

        Catch ex As Exception

        End Try
    End Sub

    Protected Sub btn_grabar_Click(sender As Object, e As EventArgs) Handles btn_grabar.Click
        Try
            obj_e_evento.p_nombre_evento = txt_evento.Text
            obj_e_evento.p_tipo_evento = txt_tipo.Text
            obj_e_evento.p_semestre_id = cbo_semestre.SelectedValue
            obj_evento.insertar_evento(obj_e_evento)
            refrescar_grilla()
            limpiar()

        Catch ex As Exception

        End Try
    End Sub

    Protected Sub btn_modificar_Click(sender As Object, e As EventArgs) Handles btn_modificar.Click
        Try
            obj_e_evento.p_evento_id = lbl_codigo.Text
            obj_e_evento.p_nombre_evento = txt_evento.Text
            obj_e_evento.p_tipo_evento = txt_tipo.Text
            obj_e_evento.p_semestre_id = cbo_semestre.SelectedValue
            obj_evento.modificar_evento(obj_e_evento)
            refrescar_grilla()
            limpiar()

        Catch ex As Exception

        End Try
    End Sub

    Protected Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Try
            obj_evento.eliminar_evento(lbl_codigo.Text)
            refrescar_grilla()
            limpiar()

        Catch ex As Exception

        End Try
    End Sub

    Protected Sub dgv_eventos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dgv_eventos.SelectedIndexChanged
        Try
            lbl_codigo.Text = dgv_eventos.SelectedRow.Cells(1).Text
            txt_evento.Text = dgv_eventos.SelectedRow.Cells(2).Text
            txt_tipo.Text = dgv_eventos.SelectedRow.Cells(3).Text
            cbo_semestre.SelectedItem.Text = dgv_eventos.SelectedRow.Cells(4).Text
            cal_inicio.SelectedDate = dgv_eventos.SelectedRow.Cells(5).Text
            cal_fin.SelectedDate = dgv_eventos.SelectedRow.Cells(6).Text

        Catch ex As Exception

        End Try
    End Sub
End Class