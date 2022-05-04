Public Class frm_alumno

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
        Me.btn_nuevo.Enabled = True
        Me.btn_grabar.Enabled = False
        Me.btn_modificar.Enabled = False
        Me.btn_eliminar.Enabled = False
        Me.btn_salir.Enabled = True
        Me.btn_cancelar.Enabled = False
        habilitar_ingreso(False)
    End Sub

    Private Sub txt_dni_TextChanged(sender As Object, e As EventArgs) Handles txt_dni.TextChanged, txt_dni.KeyPress

        '9:01

    End Sub
End Class
