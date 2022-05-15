Imports Proyecto_LogicaNegocio
Imports Proyecto_Entidades

Public Class frm_evento
    Dim bandera As Boolean
    Dim obj_e_evento As New Entidad_evento
    Dim obj_evento As New Evento

    Private Sub frm_evento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refrescar_grilla()
        llenar_cbo_semestre()
        llenar_cbo_tipo()

    End Sub

    Public Sub refrescar_grilla()
        dgv_eventos.DataSource = obj_evento.listar_eventos
        With dgv_eventos
            .Columns(0).Width = 50
            .Columns(0).HeaderText = "Codigo"
            .Columns(1).Width = 200
            .Columns(1).HeaderText = "Nombre de evento"
            .Columns(2).Width = 200
            .Columns(2).HeaderText = "Tipo de evento"
            .Columns(3).Width = 200
            .Columns(3).HeaderText = "Semestre"
            .ReadOnly = True
            .RowHeadersVisible = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect

        End With

    End Sub

    Public Sub llenar_cbo_semestre()
        Dim obj_semestre As New Semestre
        With cbo_semestre
            .DataSource = obj_semestre.listar_semestres
            .DisplayMember = "semestre_id"
            .ValueMember = "semestre_id"
            .DropDownStyle = ComboBoxStyle.DropDownList

        End With
    End Sub

    Public Sub llenar_cbo_tipo()
        Dim dt As DataTable = New DataTable("Tabla")

        dt.Columns.Add("Valor")
        dt.Columns.Add("Descripcion")

        Dim dr As DataRow

        dr = dt.NewRow()
        dr("Valor") = "C"
        dr("Descripcion") = "Congreso"
        dt.Rows.Add(dr)

        dr = dt.NewRow()
        dr("Valor") = "A"
        dr("Descripcion") = "Aniversario"
        dt.Rows.Add(dr)

        cbo_tipo.DataSource = dt
        cbo_tipo.ValueMember = "Valor"
        cbo_tipo.DisplayMember = "Descripcion"
        cbo_tipo.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub



    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        bandera = True
    End Sub

    Private Sub btn_modificar_Click(sender As Object, e As EventArgs) Handles btn_modificar.Click
        bandera = False
    End Sub

    Private Sub btn_grabar_Click(sender As Object, e As EventArgs) Handles btn_grabar.Click
        Try
            obj_e_evento.p_nombre_evento = txt_nombre.Text
            obj_e_evento.p_tipo_evento = cbo_tipo.SelectedValue
            obj_e_evento.p_semestre_id = cbo_semestre.SelectedValue
            If bandera Then
                'Insertar
                obj_evento.insertar_evento(obj_e_evento)
            Else
                'Modificar
                obj_e_evento.p_evento_id = lbl_codigo.Text
                obj_evento.modificar_evento(obj_e_evento)

            End If
            MsgBox("Actualización exitosa")
            refrescar_grilla()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Try

            Dim v_evento_id As Integer
            v_evento_id = lbl_codigo.Text
            obj_evento.eliminar_evento(v_evento_id)
            MsgBox("Eliminación exitosa")
            refrescar_grilla()
        Catch ex As Exception

        End Try

    End Sub


    Private Sub dgv_eventos_SelectionChanged(sender As Object, e As EventArgs) Handles dgv_eventos.SelectionChanged
        Try
            lbl_codigo.Text = Me.dgv_eventos.CurrentRow.Cells(0).Value
            txt_nombre.Text = Me.dgv_eventos.CurrentRow.Cells(1).Value
            Dim tipo As String
            If Me.dgv_eventos.CurrentRow.Cells(2).Value.Equals("C") Then
                tipo = "Congreso"
            Else
                tipo = "Aniversario"

            End If
            cbo_tipo.Text = tipo
            cbo_semestre.Text = Me.dgv_eventos.CurrentRow.Cells(3).Value

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Hide()
    End Sub


End Class