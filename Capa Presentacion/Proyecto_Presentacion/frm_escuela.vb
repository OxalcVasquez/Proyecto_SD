Imports Proyecto_LogicaNegocio
Imports Proyecto_Entidades

Public Class frm_escuela

    Dim bandera As Boolean


    Private Sub frm_escuela_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenar_cbo_facultad()

    End Sub


    Public Sub refrescar_grilla()
        Dim obj_escuela As New Escuela
        dgv_escuelas.DataSource = obj_escuela.listar_escuelas
        With dgv_escuelas
            .Columns(0).Width = 50
            .Columns(0).HeaderText = "Codigo"
            .Columns(1).Width = 400
            .Columns(1).HeaderText = "Nombre de escuela"
            .Columns(2).Width = 100
            .Columns(2).HeaderText = "Codigo Facultad"
            .ReadOnly = True
            .RowHeadersVisible = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect

        End With

    End Sub

    Public Sub llenar_cbo_facultad()
        Dim obj_facultad As New Facultad
        With cbo_facultad
            .DataSource = obj_facultad.listar_facultades
            .DisplayMember = "nombre_facultad"
            .ValueMember = "facultad_id"
            .DropDownStyle = ComboBoxStyle.DropDownList

        End With
    End Sub

    Private Sub dgv_escuelas_SelectionChanged(sender As Object, e As EventArgs) Handles dgv_escuelas.SelectionChanged
        Try
            Dim obj_facultad As New Facultad
            Dim v_codfac As Integer
            lbl_codigo.Text = Me.dgv_escuelas.CurrentRow.Cells(0).Value
            txt_nombre.Text = Me.dgv_escuelas.CurrentRow.Cells(1).Value
            v_codfac = Me.dgv_escuelas.CurrentRow.Cells(2).Value
            cbo_facultad.Text = obj_facultad.listar_facultad(v_codfac).p_nombre_facultad

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
            Dim obj_escuela As New Escuela
            Dim obj_e_escuela As New Entidad_escuela
            obj_e_escuela.p_nombre_escuela = txt_nombre.Text
            obj_e_escuela.p_facultad_id = cbo_facultad.SelectedValue
            If bandera Then
                'Insertar
                obj_escuela.insertar_escuela(obj_e_escuela)
            Else
                'Modificar
                obj_e_escuela.p_escuela_id = lbl_codigo.Text
                obj_escuela.modificar_escuela(obj_e_escuela)

            End If
            MsgBox("Actualización exitosa")
            refrescar_grilla()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Try
            Dim obj_escuela As New Escuela
            Dim v_escuela_id As Integer
            v_escuela_id = lbl_codigo.Text
            obj_escuela.eliminar_escuela(v_escuela_id)
            MsgBox("Eliminación exitosa")
            refrescar_grilla()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Dispose()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

End Class