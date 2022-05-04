Imports Proyecto_LogicaNegocio
Imports Proyecto_Entidades
Public Class frm_actividad

    Dim bandera As Boolean
    Dim obj_e_actividad As New Entidad_actividad
    Dim obj_actividad As New Actividad
    Private Sub frm_actividad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refrescar_grilla()
        llenar_cbo_evento()
    End Sub

    Public Sub refrescar_grilla()
        Dim obj_actividad As New Actividad
        dgv_actividades.DataSource = obj_actividad.listar_actividades
        With dgv_actividades
            .Columns(0).Width = 50
            .Columns(0).HeaderText = "Codigo"
            .Columns(1).Width = 100
            .Columns(1).HeaderText = "Tipo"
            .Columns(2).Width = 100
            .Columns(2).HeaderText = "Nombre"
            .Columns(3).Width = 100
            .Columns(3).HeaderText = "Descripcion"
            .Columns(4).Width = 100
            .Columns(4).HeaderText = "Fecha"
            .Columns(5).Width = 100
            .Columns(5).HeaderText = "H. Inicio"
            .Columns(6).Width = 100
            .Columns(6).HeaderText = "H. Fin"
            .Columns(7).Width = 100
            .Columns(7).HeaderText = "Tiene Costo"
            .Columns(8).Width = 100
            .Columns(8).HeaderText = "Evento ID"
            .ReadOnly = True
            .RowHeadersVisible = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect

        End With

    End Sub

    Public Sub llenar_cbo_evento()
        Dim obj_evento As New Evento
        With cbo_evento
            .DataSource = obj_evento.listar_eventos
            .DisplayMember = "nombre_evento"
            .ValueMember = "evento_id"
            .DropDownStyle = ComboBoxStyle.DropDownList

        End With
    End Sub

    Private Sub dgv_actividades_SelectionChanged(sender As Object, e As EventArgs) Handles dgv_actividades.SelectionChanged
        Try
            Dim obj_evento As New Evento
            Dim v_cod_eve As Integer
            lbl_codigo.Text = Me.dgv_actividades.CurrentRow.Cells(0).Value
            txt_tipo.Text = Me.dgv_actividades.CurrentRow.Cells(1).Value
            txt_nombre.Text = Me.dgv_actividades.CurrentRow.Cells(2).Value
            txt_descripcion.Text = Me.dgv_actividades.CurrentRow.Cells(3).Value
            dtp_fecha.Value = Me.dgv_actividades.CurrentRow.Cells(4).Value
            dth_inicio.Value = Me.dgv_actividades.CurrentRow.Cells(5).Value
            dth_fin.Value = Me.dgv_actividades.CurrentRow.Cells(6).Value
            chl_costo.Checked = Me.dgv_actividades.CurrentRow.Cells(7).Value
            v_cod_eve = Me.dgv_actividades.CurrentRow.Cells(8).Value
            cbo_evento.Text = obj_evento.listar_evento(v_cod_eve).p_nombre_evento

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        bandera = True
    End Sub

    Private Sub btn_modificar_Click(sender As Object, e As EventArgs) Handles btn_modificar.Click
        bandera = False
    End Sub

    Private Sub btn_grabar_Click(sender As Object, e As EventArgs) Handles btn_grabar.Click
        Try
            obj_e_actividad.p_nombre = txt_nombre.Text
            obj_e_actividad.p_tipo = txt_tipo.Text
            obj_e_actividad.p_descripcion = txt_descripcion.Text
            obj_e_actividad.p_fecha = dtp_fecha.Value
            obj_e_actividad.p_h_inicio = dth_inicio.Value
            obj_e_actividad.p_h_fin = dth_fin.Value
            obj_e_actividad.p_tiene_costo = chl_costo.Checked
            obj_e_actividad.p_evento_id = cbo_evento.SelectedValue
            If bandera Then
                'Insertar
                obj_actividad.insertar_activdad(obj_e_actividad)

            Else
                'Modificar
                obj_e_actividad.p_actividad_id = lbl_codigo.Text
                obj_actividad.modificar_actividad(obj_e_actividad)


            End If
            MsgBox("Actualización exitosa")
            refrescar_grilla()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Try

            Dim v_actividad_id As Integer
            v_actividad_id = lbl_codigo.Text
            obj_actividad.eliminar_actividad(v_actividad_id)
            MsgBox("Eliminación exitosa")
            refrescar_grilla()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class