Imports Proyecto_LogicaNegocio
Imports Proyecto_Entidades
Public Class frm_facultad

    Dim bandera As Boolean
    Dim obj_e_facultad As New Entidad_facultad
    Dim obj_facultad As New Facultad



    Private Sub txt_nombre_TextChanged(sender As Object, e As EventArgs) Handles txt_nombre.TextChanged

    End Sub



    Private Sub frm_facultad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refrescar_grilla()

    End Sub

    Public Sub refrescar_grilla()
        Dim obj_facultad As New Facultad
        dgv_facultades.DataSource = obj_facultad.listar_facultades
        With dgv_facultades
            .Columns(0).Width = 50
            .Columns(0).HeaderText = "Codigo"
            .Columns(1).Width = 400
            .Columns(1).HeaderText = "Nombre de facultad"
            .ReadOnly = True
            .RowHeadersVisible = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
        End With
    End Sub

    Private Sub dgv_facultades_SelectionChanged(sender As Object, e As EventArgs) Handles dgv_facultades.SelectionChanged
        Try
            Dim obj_facultad As New Facultad
            lbl_codigo.Text = Me.dgv_facultades.CurrentRow.Cells(0).Value
            txt_nombre.Text = Me.dgv_facultades.CurrentRow.Cells(1).Value
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
            obj_e_facultad.p_nombre_facultad = txt_nombre.Text
            If bandera Then
                'Insertar
                obj_facultad.insertar_facultad(obj_e_facultad)
            Else
                'Modificar
                obj_e_facultad.p_facultad_id = lbl_codigo.Text
                obj_facultad.modificar_facultad(obj_e_facultad)
            End If
            MsgBox("Actualización exitosa")
            refrescar_grilla()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Try

            Dim v_facultad_id As Integer
            v_facultad_id = lbl_codigo.Text
            obj_facultad.eliminar_facultad(v_facultad_id)
            MsgBox("Eliminación exitosa")
            refrescar_grilla()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Hide()
    End Sub
End Class