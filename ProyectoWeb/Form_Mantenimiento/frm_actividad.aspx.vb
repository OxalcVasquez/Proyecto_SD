Imports Proyecto_LogicaNegocio
Imports Proyecto_Entidades
Public Class frm_actividad
    Inherits System.Web.UI.Page
    Private obj_actividad As New Actividad 'Capa Logica
    Private obj_e_actividad As New Entidad_actividad
    Private obj_evento As New Evento

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        refrescar_grilla()
        'isPostBack false primera carga
        If Not IsPostBack Then
            cbo_evento.DataSource = obj_evento.listar_eventos()
            cbo_evento.DataTextField = "nombre_evento"
            cbo_evento.DataValueField = "evento_id"
            cbo_evento.DataBind()
        End If
    End Sub

    Public Sub refrescar_grilla()
        Me.dgv_actividad.DataSource = obj_actividad.listar_actividades()
        Me.dgv_actividad.DataBind()
    End Sub

    Protected Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        limpiar()

    End Sub
    Public Sub limpiar()
        lbl_codigo.Text = ""
        txt_actividad.Text = ""
        txt_descripcion.Text = ""
        txt_costo.Text = ""
        txt_hfin.Text = ""
        txt_hinicio.Text = ""
        txt_tipo.Text = ""
        cbo_evento.SelectedIndex = 0

    End Sub
    Protected Sub dgv_actividad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dgv_actividad.SelectedIndexChanged
        Try
            lbl_codigo.Text = dgv_actividad.SelectedRow.Cells(1).Text
            txt_tipo.Text = dgv_actividad.SelectedRow.Cells(2).Text
            txt_actividad.Text = dgv_actividad.SelectedRow.Cells(3).Text
            txt_descripcion.Text = dgv_actividad.SelectedRow.Cells(4).Text
            cal_fecha.SelectedDate = dgv_actividad.SelectedRow.Cells(5).Text
            txt_hinicio.Text = dgv_actividad.SelectedRow.Cells(6).Text
            txt_hfin.Text = dgv_actividad.SelectedRow.Cells(7).Text
            Dim cod_evento As Integer = dgv_actividad.SelectedRow.Cells(8).Text
            cbo_evento.SelectedItem.Text = obj_evento.listar_evento(cod_evento).p_nombre_evento
            txt_costo.Text = dgv_actividad.SelectedRow.Cells(9).Text

        Catch ex As Exception

        End Try
    End Sub

    Protected Sub btn_grabar_Click(sender As Object, e As EventArgs) Handles btn_grabar.Click
        Try
            obj_e_actividad.p_tipo = txt_tipo.Text
            obj_e_actividad.p_nombre = txt_actividad.Text
            obj_e_actividad.p_descripcion = txt_descripcion.Text
            obj_e_actividad.p_fecha = cal_fecha.SelectedDate
            obj_e_actividad.p_h_inicio = txt_hinicio.Text
            obj_e_actividad.p_h_fin = txt_hfin.Text
            obj_e_actividad.p_tiene_costo = txt_costo.Text
            obj_e_actividad.p_evento_id = cbo_evento.SelectedValue

            obj_actividad.insertar_activdad(obj_e_actividad)


            refrescar_grilla()
            limpiar()

        Catch ex As Exception

        End Try
    End Sub

    Protected Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Try


            obj_actividad.eliminar_actividad(lbl_codigo.Text)


            refrescar_grilla()
            limpiar()

        Catch ex As Exception

        End Try
    End Sub

    Protected Sub btn_modificar_Click(sender As Object, e As EventArgs) Handles btn_modificar.Click
        Try
            obj_e_actividad.p_actividad_id = lbl_codigo.Text
            obj_e_actividad.p_tipo = txt_tipo.Text
            obj_e_actividad.p_nombre = txt_actividad.Text
            obj_e_actividad.p_descripcion = txt_descripcion.Text
            obj_e_actividad.p_fecha = cal_fecha.SelectedDate
            obj_e_actividad.p_h_inicio = txt_hinicio.Text
            obj_e_actividad.p_h_fin = txt_hfin.Text
            obj_e_actividad.p_tiene_costo = txt_costo.Text
            obj_e_actividad.p_evento_id = cbo_evento.SelectedValue

            obj_actividad.modificar_actividad(obj_e_actividad)


            refrescar_grilla()
            limpiar()

        Catch ex As Exception

        End Try
    End Sub
End Class