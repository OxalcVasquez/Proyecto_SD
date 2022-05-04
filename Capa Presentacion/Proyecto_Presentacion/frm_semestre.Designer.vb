<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_semestre
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chk_estado = New System.Windows.Forms.CheckBox()
        Me.dtp_fin = New System.Windows.Forms.DateTimePicker()
        Me.dtp_inicio = New System.Windows.Forms.DateTimePicker()
        Me.txt_semestre = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgv_semestres = New System.Windows.Forms.DataGridView()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.btn_modificar = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_grabar = New System.Windows.Forms.Button()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_semestres, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chk_estado)
        Me.GroupBox1.Controls.Add(Me.dtp_fin)
        Me.GroupBox1.Controls.Add(Me.dtp_inicio)
        Me.GroupBox1.Controls.Add(Me.txt_semestre)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(655, 195)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Información Semestre"
        '
        'chk_estado
        '
        Me.chk_estado.AutoSize = True
        Me.chk_estado.Location = New System.Drawing.Point(125, 131)
        Me.chk_estado.Name = "chk_estado"
        Me.chk_estado.Size = New System.Drawing.Size(75, 20)
        Me.chk_estado.TabIndex = 7
        Me.chk_estado.Text = "Vigente"
        Me.chk_estado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chk_estado.UseVisualStyleBackColor = True
        '
        'dtp_fin
        '
        Me.dtp_fin.Location = New System.Drawing.Point(438, 80)
        Me.dtp_fin.Name = "dtp_fin"
        Me.dtp_fin.Size = New System.Drawing.Size(200, 22)
        Me.dtp_fin.TabIndex = 6
        '
        'dtp_inicio
        '
        Me.dtp_inicio.Location = New System.Drawing.Point(125, 79)
        Me.dtp_inicio.Name = "dtp_inicio"
        Me.dtp_inicio.Size = New System.Drawing.Size(200, 22)
        Me.dtp_inicio.TabIndex = 5
        '
        'txt_semestre
        '
        Me.txt_semestre.Location = New System.Drawing.Point(125, 33)
        Me.txt_semestre.Name = "txt_semestre"
        Me.txt_semestre.Size = New System.Drawing.Size(180, 22)
        Me.txt_semestre.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(19, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 23)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Estado"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(331, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Fec. Fin"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(19, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Fec. Inicio"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(19, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Semestre ID"
        '
        'dgv_semestres
        '
        Me.dgv_semestres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_semestres.Location = New System.Drawing.Point(12, 263)
        Me.dgv_semestres.Name = "dgv_semestres"
        Me.dgv_semestres.RowHeadersWidth = 51
        Me.dgv_semestres.RowTemplate.Height = 24
        Me.dgv_semestres.Size = New System.Drawing.Size(655, 164)
        Me.dgv_semestres.TabIndex = 1
        '
        'btn_salir
        '
        Me.btn_salir.Location = New System.Drawing.Point(562, 209)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(105, 33)
        Me.btn_salir.TabIndex = 20
        Me.btn_salir.Text = "Salir"
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'btn_modificar
        '
        Me.btn_modificar.Location = New System.Drawing.Point(218, 213)
        Me.btn_modificar.Name = "btn_modificar"
        Me.btn_modificar.Size = New System.Drawing.Size(95, 33)
        Me.btn_modificar.TabIndex = 19
        Me.btn_modificar.Text = "Modificar"
        Me.btn_modificar.UseVisualStyleBackColor = True
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Location = New System.Drawing.Point(323, 213)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(95, 33)
        Me.btn_eliminar.TabIndex = 18
        Me.btn_eliminar.Text = "Eliminar"
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'btn_grabar
        '
        Me.btn_grabar.Location = New System.Drawing.Point(117, 213)
        Me.btn_grabar.Name = "btn_grabar"
        Me.btn_grabar.Size = New System.Drawing.Size(95, 33)
        Me.btn_grabar.TabIndex = 17
        Me.btn_grabar.Text = "Grabar"
        Me.btn_grabar.UseVisualStyleBackColor = True
        '
        'btn_agregar
        '
        Me.btn_agregar.Location = New System.Drawing.Point(12, 213)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(95, 33)
        Me.btn_agregar.TabIndex = 16
        Me.btn_agregar.Text = "Agregar"
        Me.btn_agregar.UseVisualStyleBackColor = True
        '
        'frm_semestre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(679, 450)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_modificar)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.btn_grabar)
        Me.Controls.Add(Me.btn_agregar)
        Me.Controls.Add(Me.dgv_semestres)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frm_semestre"
        Me.Text = "Mantenimiento Semestre"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv_semestres, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dgv_semestres As DataGridView
    Friend WithEvents txt_semestre As TextBox
    Friend WithEvents chk_estado As CheckBox
    Friend WithEvents dtp_fin As DateTimePicker
    Friend WithEvents dtp_inicio As DateTimePicker
    Friend WithEvents btn_salir As Button
    Friend WithEvents btn_modificar As Button
    Friend WithEvents btn_eliminar As Button
    Friend WithEvents btn_grabar As Button
    Friend WithEvents btn_agregar As Button
End Class
