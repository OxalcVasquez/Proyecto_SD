Imports Proyecto_LogicaNegocio
Imports Proyecto_Entidades
Public Class frm_semestre
    Dim bandera As Boolean
    Dim obj_e_semestre As New Entidad_semestre
    Dim obj_semestre As New Semestre
    Private Sub frm_semestre_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refrescar_grilla()
    End Sub

    Public Sub refrescar_grilla()
        Dim obj_semestre As New Semestre
        dgv_semestres.DataSource = obj_semestre.listar_semestres
        With dgv_semestres
            .Columns(0).Width = 120
            .Columns(0).HeaderText = "Codigo"
            .Columns(1).Width = 120
            .Columns(1).HeaderText = "Fec. Inicio"
            .Columns(2).Width = 120
            .Columns(2).HeaderText = "Fec. Fin"
            .Columns(3).Width = 120
            .Columns(3).HeaderText = "Estado"
            .ReadOnly = True
            .RowHeadersVisible = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
        End With
    End Sub

    Private Sub dgv_semestres_SelectionChanged(sender As Object, e As EventArgs) Handles dgv_semestres.SelectionChanged
        Try
            txt_semestre.Text = Me.dgv_semestres.CurrentRow.Cells(0).Value
            dtp_inicio.Value = Me.dgv_semestres.CurrentRow.Cells(1).Value
            dtp_fin.Value = Me.dgv_semestres.CurrentRow.Cells(2).Value
            chk_estado.Checked = Me.dgv_semestres.CurrentRow.Cells(3).Value

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_grabar_Click(sender As Object, e As EventArgs) Handles btn_grabar.Click
        Try
            obj_e_semestre.p_semestre_id = txt_semestre.Text
            obj_e_semestre.p_f_inicio = dtp_inicio.Value
            obj_e_semestre.p_f_fin = dtp_fin.Value
            obj_e_semestre.p_estado = chk_estado.Checked
            If bandera Then
                'Insertar
                obj_semestre.insertar_semestre(obj_e_semestre)
            Else
                'Modificar
                obj_semestre.modificar_semestre(obj_e_semestre)

            End If
            MsgBox("Actualización exitosa")
            refrescar_grilla()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        bandera = True
    End Sub

    Private Sub btn_modificar_Click(sender As Object, e As EventArgs) Handles btn_modificar.Click
        bandera = False
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Try
            Dim v_semestre_id As String
            v_semestre_id = txt_semestre.Text
            obj_semestre.eliminar_semestre(v_semestre_id)
            MsgBox("Eliminación exitosa")
            refrescar_grilla()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Hide()
    End Sub
End Class