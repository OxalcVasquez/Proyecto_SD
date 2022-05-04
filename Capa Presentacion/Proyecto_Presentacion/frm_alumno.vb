Imports Proyecto_LogicaNegocio
Imports Proyecto_Entidades
Public Class frm_alumno
    Dim bandera As Boolean
    Dim obj_e_alumno As New Entidad_alumno
    Dim obj_alumno As New Alumno
    Private Sub frm_alumno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.chk_sexo.Text = "Masculino"
        Me.chk_sexo.Checked = True
        habilitar_ingreso(False)
        txt_dni.Enabled = True
        Me.btn_nuevo.Enabled = True
        Me.btn_grabar.Enabled = False
        Me.btn_modificar.Enabled = False
        Me.btn_eliminar.Enabled = False
        Me.btn_salir.Enabled = True
        Me.btn_cancelar.Enabled = True

        refrescar_grilla()
        llenar_combos()
    End Sub

    Private Sub chkSexo_CheckedChanged(sender As Object, e As EventArgs) Handles chk_sexo.CheckedChanged
        If Me.chk_sexo.Checked = True Then
            chk_sexo.Text = "Masculino"
        Else
            chk_sexo.Text = "Femenino"

        End If
    End Sub

    Sub habilitar_ingreso(estado As Boolean)
        Me.txt_dni.Enabled = estado
        Me.txt_apepat.Enabled = estado
        Me.txt_apemat.Enabled = estado
        Me.txt_nombres.Enabled = estado
        Me.chk_sexo.Enabled = estado
        Me.cbo_semestre.Enabled = estado
        Me.btn_cancelar.Enabled = estado

    End Sub

    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        habilitar_ingreso(True)
        limpiar_ingreso()
        txt_dni.Select()
        Me.btn_nuevo.Enabled = False
        Me.btn_grabar.Enabled = True
        Me.btn_modificar.Enabled = False
        Me.btn_eliminar.Enabled = False
        Me.btn_salir.Enabled = True
        Me.btn_cancelar.Enabled = True
        bandera = True

    End Sub
    Sub limpiar_ingreso()
        Me.txt_dni.Clear()
        Me.txt_apepat.Clear()
        Me.txt_apemat.Clear()
        Me.txt_nombres.Clear()
        Me.chk_sexo.Checked = True
        'Me.cbo_semestre.SelectedIndex = 0

    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Me.btn_nuevo.Enabled = True
        Me.btn_grabar.Enabled = False
        Me.btn_modificar.Enabled = False
        Me.btn_eliminar.Enabled = False
        Me.btn_salir.Enabled = True
        Me.btn_cancelar.Enabled = True
        habilitar_ingreso(False)
    End Sub

    Private Sub btn_grabar_Click(sender As Object, e As EventArgs) Handles btn_grabar.Click

        Try
            obj_e_alumno.p_nombres = txt_nombres.Text
            obj_e_alumno.p_dni = txt_dni.Text
            obj_e_alumno.p_ape_paterno = txt_apepat.Text
            obj_e_alumno.p_ape_materno = txt_apemat.Text
            obj_e_alumno.p_sexo = chk_sexo.Text.Substring(0, 1)
            obj_e_alumno.p_fecha_nacimiento = dtp_fecnac.Value
            obj_e_alumno.p_escuela_id = cbo_escuela.SelectedValue
            obj_e_alumno.p_semestre_ingreso = cbo_semestre.SelectedValue

            If bandera Then
                'Insertar
                obj_alumno.insertar_alumno(obj_e_alumno)

            Else
                'Modificar
                obj_e_alumno.p_alumno_id = lbl_codigo.Text
                obj_alumno.modificar_alumno(obj_e_alumno)

            End If
            MsgBox("Actualización exitosa")
            refrescar_grilla()
        Catch ex As Exception

        End Try
        Me.btn_nuevo.Enabled = True
        Me.btn_grabar.Enabled = False
        Me.btn_modificar.Enabled = False
        Me.btn_eliminar.Enabled = False
        Me.btn_salir.Enabled = True
        Me.btn_cancelar.Enabled = False
        habilitar_ingreso(False)

    End Sub


    Private Sub btn_modificar_Click(sender As Object, e As EventArgs) Handles btn_modificar.Click
        bandera = False
    End Sub

    Public Sub refrescar_grilla()
        dgv_alumnos.DataSource = obj_alumno.listar_alumnos

        With dgv_alumnos
            .Columns(0).Width = 50
            .Columns(0).HeaderText = "Codigo"
            .Columns(1).Width = 100
            .Columns(1).HeaderText = "A. Paterno"
            .Columns(2).Width = 100
            .Columns(2).HeaderText = "A. Materno"
            .Columns(3).Width = 100
            .Columns(3).HeaderText = "Nombres"
            .Columns(4).Width = 100
            .Columns(4).HeaderText = "Sexo"
            .Columns(5).Width = 100
            .Columns(5).HeaderText = "F. Nac."
            .Columns(6).Width = 100
            .Columns(6).HeaderText = "Sem. Ingreso"
            .Columns(7).Width = 100
            .Columns(7).HeaderText = "DNI"
            .Columns(8).Width = 100
            .Columns(8).HeaderText = "Escuela ID"
            .ReadOnly = True
            .RowHeadersVisible = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect

        End With

    End Sub

    Public Sub llenar_combos()
        Dim obj_semestre As New Semestre
        Dim obj_escuela As New Escuela

        With cbo_semestre
            .DataSource = obj_semestre.listar_semestres
            .DisplayMember = "semestre_id"
            .ValueMember = "semestre_id"
            .DropDownStyle = ComboBoxStyle.DropDownList

        End With
        With cbo_escuela
            .DataSource = obj_escuela.listar_escuelas
            .DisplayMember = "nombre_escuela"
            .ValueMember = "escuela_id"
            .DropDownStyle = ComboBoxStyle.DropDownList

        End With
    End Sub

    Private Sub dgv_alumnos_SelectionChanged(sender As Object, e As EventArgs) Handles dgv_alumnos.SelectionChanged
        Try
            Dim obj_escuela As New Escuela
            Dim v_cod_esc As Integer
            lbl_codigo.Text = Me.dgv_alumnos.CurrentRow.Cells(0).Value
            txt_apepat.Text = Me.dgv_alumnos.CurrentRow.Cells(1).Value
            txt_apemat.Text = Me.dgv_alumnos.CurrentRow.Cells(2).Value
            txt_nombres.Text = Me.dgv_alumnos.CurrentRow.Cells(3).Value
            If Me.dgv_alumnos.CurrentRow.Cells(4).Value.Equals("M") Then
                chk_sexo.Checked = True
            Else
                chk_sexo.Checked = False
            End If
            dtp_fecnac.Value = Me.dgv_alumnos.CurrentRow.Cells(5).Value
            cbo_semestre.Text = Me.dgv_alumnos.CurrentRow.Cells(6).Value
            txt_dni.Text = Me.dgv_alumnos.CurrentRow.Cells(7).Value
            v_cod_esc = Me.dgv_alumnos.CurrentRow.Cells(8).Value
            cbo_escuela.Text = obj_escuela.listar_escuela(v_cod_esc).p_nombre_escuela
            habilitar_ingreso(True)
            btn_modificar.Enabled = True
            btn_eliminar.Enabled = True


        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Try

            Dim v_alumno_id As Integer
            v_alumno_id = lbl_codigo.Text
            obj_alumno.eliminar_alumno(v_alumno_id)
            MsgBox("Eliminación exitosa")
            refrescar_grilla()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click

    End Sub
End Class
