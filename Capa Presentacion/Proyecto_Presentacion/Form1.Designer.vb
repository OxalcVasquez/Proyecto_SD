<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_alumno
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbo_semestre = New System.Windows.Forms.ComboBox()
        Me.dtp_fecnac = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chk_sexo = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_nombres = New System.Windows.Forms.TextBox()
        Me.txt_apemat = New System.Windows.Forms.TextBox()
        Me.txt_apepat = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_dni = New System.Windows.Forms.TextBox()
        Me.lblDni = New System.Windows.Forms.Label()
        Me.btn_nuevo = New System.Windows.Forms.Button()
        Me.btn_grabar = New System.Windows.Forms.Button()
        Me.btn_modificar = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.txt_consulta = New System.Windows.Forms.TextBox()
        Me.dgv_alumnos = New System.Windows.Forms.DataGridView()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_alumnos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cbo_semestre)
        Me.GroupBox1.Controls.Add(Me.dtp_fecnac)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.chk_sexo)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_nombres)
        Me.GroupBox1.Controls.Add(Me.txt_apemat)
        Me.GroupBox1.Controls.Add(Me.txt_apepat)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_dni)
        Me.GroupBox1.Controls.Add(Me.lblDni)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(776, 243)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Información del Alumno"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(368, 194)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(117, 23)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Semestre Ingreso"
        '
        'cbo_semestre
        '
        Me.cbo_semestre.FormattingEnabled = True
        Me.cbo_semestre.Location = New System.Drawing.Point(491, 193)
        Me.cbo_semestre.Name = "cbo_semestre"
        Me.cbo_semestre.Size = New System.Drawing.Size(260, 24)
        Me.cbo_semestre.TabIndex = 12
        '
        'dtp_fecnac
        '
        Me.dtp_fecnac.Location = New System.Drawing.Point(491, 143)
        Me.dtp_fecnac.Name = "dtp_fecnac"
        Me.dtp_fecnac.Size = New System.Drawing.Size(260, 22)
        Me.dtp_fecnac.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(377, 143)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(163, 23)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Fec. Nacimiento"
        '
        'chk_sexo
        '
        Me.chk_sexo.AutoSize = True
        Me.chk_sexo.Location = New System.Drawing.Point(184, 143)
        Me.chk_sexo.Name = "chk_sexo"
        Me.chk_sexo.Size = New System.Drawing.Size(60, 20)
        Me.chk_sexo.TabIndex = 9
        Me.chk_sexo.Text = "Sexo"
        Me.chk_sexo.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(24, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(163, 23)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Sexo Alumno"
        '
        'txt_nombres
        '
        Me.txt_nombres.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_nombres.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt_nombres.Location = New System.Drawing.Point(582, 104)
        Me.txt_nombres.Name = "txt_nombres"
        Me.txt_nombres.Size = New System.Drawing.Size(169, 22)
        Me.txt_nombres.TabIndex = 7
        '
        'txt_apemat
        '
        Me.txt_apemat.Location = New System.Drawing.Point(380, 104)
        Me.txt_apemat.Name = "txt_apemat"
        Me.txt_apemat.Size = New System.Drawing.Size(169, 22)
        Me.txt_apemat.TabIndex = 6
        '
        'txt_apepat
        '
        Me.txt_apepat.Location = New System.Drawing.Point(184, 104)
        Me.txt_apepat.Name = "txt_apepat"
        Me.txt_apepat.Size = New System.Drawing.Size(169, 22)
        Me.txt_apepat.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(588, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(163, 23)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Nombres"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(377, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(163, 23)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Apellido Materno"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(181, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(163, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Apellido Paterno"
        '
        'txt_dni
        '
        Me.txt_dni.Location = New System.Drawing.Point(184, 36)
        Me.txt_dni.Name = "txt_dni"
        Me.txt_dni.Size = New System.Drawing.Size(169, 22)
        Me.txt_dni.TabIndex = 1
        '
        'lblDni
        '
        Me.lblDni.Location = New System.Drawing.Point(15, 36)
        Me.lblDni.Name = "lblDni"
        Me.lblDni.Size = New System.Drawing.Size(163, 23)
        Me.lblDni.TabIndex = 0
        Me.lblDni.Text = "DNI Alumno"
        '
        'btn_nuevo
        '
        Me.btn_nuevo.Location = New System.Drawing.Point(12, 261)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(100, 34)
        Me.btn_nuevo.TabIndex = 14
        Me.btn_nuevo.Text = "Nuevo"
        Me.btn_nuevo.UseVisualStyleBackColor = True
        '
        'btn_grabar
        '
        Me.btn_grabar.Location = New System.Drawing.Point(118, 261)
        Me.btn_grabar.Name = "btn_grabar"
        Me.btn_grabar.Size = New System.Drawing.Size(100, 34)
        Me.btn_grabar.TabIndex = 15
        Me.btn_grabar.Text = "Grabar"
        Me.btn_grabar.UseVisualStyleBackColor = True
        '
        'btn_modificar
        '
        Me.btn_modificar.Location = New System.Drawing.Point(225, 261)
        Me.btn_modificar.Name = "btn_modificar"
        Me.btn_modificar.Size = New System.Drawing.Size(100, 34)
        Me.btn_modificar.TabIndex = 16
        Me.btn_modificar.Text = "Modificar"
        Me.btn_modificar.UseVisualStyleBackColor = True
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Location = New System.Drawing.Point(331, 261)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(85, 34)
        Me.btn_eliminar.TabIndex = 17
        Me.btn_eliminar.Text = "Eliminar"
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'btn_salir
        '
        Me.btn_salir.Location = New System.Drawing.Point(688, 261)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(100, 34)
        Me.btn_salir.TabIndex = 18
        Me.btn_salir.Text = "Salir"
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'txt_consulta
        '
        Me.txt_consulta.Location = New System.Drawing.Point(12, 301)
        Me.txt_consulta.Name = "txt_consulta"
        Me.txt_consulta.Size = New System.Drawing.Size(776, 22)
        Me.txt_consulta.TabIndex = 14
        '
        'dgv_alumnos
        '
        Me.dgv_alumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_alumnos.Location = New System.Drawing.Point(12, 329)
        Me.dgv_alumnos.Name = "dgv_alumnos"
        Me.dgv_alumnos.RowHeadersWidth = 51
        Me.dgv_alumnos.RowTemplate.Height = 24
        Me.dgv_alumnos.Size = New System.Drawing.Size(776, 178)
        Me.dgv_alumnos.TabIndex = 19
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Location = New System.Drawing.Point(566, 261)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(100, 34)
        Me.btn_cancelar.TabIndex = 20
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'frm_alumno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 519)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.dgv_alumnos)
        Me.Controls.Add(Me.txt_consulta)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.btn_nuevo)
        Me.Controls.Add(Me.btn_modificar)
        Me.Controls.Add(Me.btn_grabar)
        Me.Name = "frm_alumno"
        Me.Text = "Mantenimientos de Alumnos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv_alumnos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cbo_semestre As ComboBox
    Friend WithEvents dtp_fecnac As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents chk_sexo As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_nombres As TextBox
    Friend WithEvents txt_apemat As TextBox
    Friend WithEvents txt_apepat As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_dni As TextBox
    Friend WithEvents lblDni As Label
    Friend WithEvents btn_nuevo As Button
    Friend WithEvents btn_grabar As Button
    Friend WithEvents btn_modificar As Button
    Friend WithEvents btn_eliminar As Button
    Friend WithEvents btn_salir As Button
    Friend WithEvents txt_consulta As TextBox
    Friend WithEvents dgv_alumnos As DataGridView
    Friend WithEvents btn_cancelar As Button
End Class
