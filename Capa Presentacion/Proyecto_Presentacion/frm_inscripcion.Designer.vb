<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_inscripcion
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
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_grabar = New System.Windows.Forms.Button()
        Me.cbo_eventos = New System.Windows.Forms.ComboBox()
        Me.txt_dni = New System.Windows.Forms.TextBox()
        Me.lbl_codigo = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_estudiante = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbo_tipo_pago = New System.Windows.Forms.ComboBox()
        Me.lbl_nro_cuotas = New System.Windows.Forms.Label()
        Me.num_cuotas = New System.Windows.Forms.NumericUpDown()
        Me.dgv_actividades = New System.Windows.Forms.DataGridView()
        Me.groupbox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgv_inscripciones = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_dni_consulta = New System.Windows.Forms.TextBox()
        Me.dgv_detalle = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.num_cuotas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_actividades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.groupbox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_inscripciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_detalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Location = New System.Drawing.Point(986, 389)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(128, 33)
        Me.btn_eliminar.TabIndex = 20
        Me.btn_eliminar.Text = "Eliminar"
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'btn_grabar
        '
        Me.btn_grabar.Location = New System.Drawing.Point(1268, 313)
        Me.btn_grabar.Name = "btn_grabar"
        Me.btn_grabar.Size = New System.Drawing.Size(128, 33)
        Me.btn_grabar.TabIndex = 19
        Me.btn_grabar.Text = "Grabar"
        Me.btn_grabar.UseVisualStyleBackColor = True
        '
        'cbo_eventos
        '
        Me.cbo_eventos.FormattingEnabled = True
        Me.cbo_eventos.Location = New System.Drawing.Point(160, 91)
        Me.cbo_eventos.Name = "cbo_eventos"
        Me.cbo_eventos.Size = New System.Drawing.Size(278, 24)
        Me.cbo_eventos.TabIndex = 17
        '
        'txt_dni
        '
        Me.txt_dni.Location = New System.Drawing.Point(160, 144)
        Me.txt_dni.Name = "txt_dni"
        Me.txt_dni.Size = New System.Drawing.Size(278, 22)
        Me.txt_dni.TabIndex = 16
        '
        'lbl_codigo
        '
        Me.lbl_codigo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_codigo.Location = New System.Drawing.Point(160, 18)
        Me.lbl_codigo.Name = "lbl_codigo"
        Me.lbl_codigo.Size = New System.Drawing.Size(135, 35)
        Me.lbl_codigo.TabIndex = 15
        Me.lbl_codigo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(22, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 35)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Evento"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(22, 131)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 35)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "DNI Estudiante"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(9, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 35)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Inscripcion ID"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_estudiante
        '
        Me.lbl_estudiante.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_estudiante.Location = New System.Drawing.Point(160, 188)
        Me.lbl_estudiante.Name = "lbl_estudiante"
        Me.lbl_estudiante.Size = New System.Drawing.Size(314, 28)
        Me.lbl_estudiante.TabIndex = 24
        Me.lbl_estudiante.Text = "Datos estudiante"
        Me.lbl_estudiante.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(157, 231)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 35)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Tipo pago"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbo_tipo_pago
        '
        Me.cbo_tipo_pago.FormattingEnabled = True
        Me.cbo_tipo_pago.Location = New System.Drawing.Point(160, 282)
        Me.cbo_tipo_pago.Name = "cbo_tipo_pago"
        Me.cbo_tipo_pago.Size = New System.Drawing.Size(154, 24)
        Me.cbo_tipo_pago.TabIndex = 26
        '
        'lbl_nro_cuotas
        '
        Me.lbl_nro_cuotas.Location = New System.Drawing.Point(351, 231)
        Me.lbl_nro_cuotas.Name = "lbl_nro_cuotas"
        Me.lbl_nro_cuotas.Size = New System.Drawing.Size(75, 35)
        Me.lbl_nro_cuotas.TabIndex = 27
        Me.lbl_nro_cuotas.Text = "Nro Cuotas"
        Me.lbl_nro_cuotas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbl_nro_cuotas.Visible = False
        '
        'num_cuotas
        '
        Me.num_cuotas.Location = New System.Drawing.Point(354, 283)
        Me.num_cuotas.Name = "num_cuotas"
        Me.num_cuotas.Size = New System.Drawing.Size(120, 22)
        Me.num_cuotas.TabIndex = 28
        Me.num_cuotas.Visible = False
        '
        'dgv_actividades
        '
        Me.dgv_actividades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_actividades.Location = New System.Drawing.Point(6, 21)
        Me.dgv_actividades.Name = "dgv_actividades"
        Me.dgv_actividades.RowHeadersWidth = 51
        Me.dgv_actividades.RowTemplate.Height = 24
        Me.dgv_actividades.Size = New System.Drawing.Size(910, 243)
        Me.dgv_actividades.TabIndex = 0
        '
        'groupbox2
        '
        Me.groupbox2.Controls.Add(Me.GroupBox3)
        Me.groupbox2.Controls.Add(Me.lbl_estudiante)
        Me.groupbox2.Controls.Add(Me.Label1)
        Me.groupbox2.Controls.Add(Me.num_cuotas)
        Me.groupbox2.Controls.Add(Me.btn_grabar)
        Me.groupbox2.Controls.Add(Me.Label2)
        Me.groupbox2.Controls.Add(Me.lbl_nro_cuotas)
        Me.groupbox2.Controls.Add(Me.Label3)
        Me.groupbox2.Controls.Add(Me.cbo_tipo_pago)
        Me.groupbox2.Controls.Add(Me.lbl_codigo)
        Me.groupbox2.Controls.Add(Me.Label4)
        Me.groupbox2.Controls.Add(Me.txt_dni)
        Me.groupbox2.Controls.Add(Me.cbo_eventos)
        Me.groupbox2.Location = New System.Drawing.Point(12, 32)
        Me.groupbox2.Name = "groupbox2"
        Me.groupbox2.Size = New System.Drawing.Size(1430, 352)
        Me.groupbox2.TabIndex = 30
        Me.groupbox2.TabStop = False
        Me.groupbox2.Text = "Datos Inscripción"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dgv_actividades)
        Me.GroupBox3.Location = New System.Drawing.Point(480, 21)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(933, 284)
        Me.GroupBox3.TabIndex = 29
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Actividades del Evento"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.dgv_detalle)
        Me.GroupBox1.Controls.Add(Me.btn_eliminar)
        Me.GroupBox1.Controls.Add(Me.dgv_inscripciones)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txt_dni_consulta)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 390)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1437, 445)
        Me.GroupBox1.TabIndex = 31
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Inscripciones Registradas"
        '
        'dgv_inscripciones
        '
        Me.dgv_inscripciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_inscripciones.Location = New System.Drawing.Point(25, 80)
        Me.dgv_inscripciones.Name = "dgv_inscripciones"
        Me.dgv_inscripciones.RowHeadersWidth = 51
        Me.dgv_inscripciones.RowTemplate.Height = 24
        Me.dgv_inscripciones.Size = New System.Drawing.Size(1089, 291)
        Me.dgv_inscripciones.TabIndex = 19
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(13, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 35)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "DNI Estudiante"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_dni_consulta
        '
        Me.txt_dni_consulta.Location = New System.Drawing.Point(151, 40)
        Me.txt_dni_consulta.Name = "txt_dni_consulta"
        Me.txt_dni_consulta.Size = New System.Drawing.Size(278, 22)
        Me.txt_dni_consulta.TabIndex = 18
        '
        'dgv_detalle
        '
        Me.dgv_detalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_detalle.Location = New System.Drawing.Point(1143, 80)
        Me.dgv_detalle.Name = "dgv_detalle"
        Me.dgv_detalle.RowHeadersWidth = 51
        Me.dgv_detalle.RowTemplate.Height = 24
        Me.dgv_detalle.Size = New System.Drawing.Size(253, 291)
        Me.dgv_detalle.TabIndex = 20
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(1140, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(117, 16)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Detalle Inscripción"
        '
        'frm_inscripcion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1461, 858)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.groupbox2)
        Me.Name = "frm_inscripcion"
        Me.Text = "frm_inscripcion"
        CType(Me.num_cuotas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_actividades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.groupbox2.ResumeLayout(False)
        Me.groupbox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv_inscripciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_detalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_eliminar As Button
    Friend WithEvents btn_grabar As Button
    Friend WithEvents cbo_eventos As ComboBox
    Friend WithEvents txt_dni As TextBox
    Friend WithEvents lbl_codigo As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_estudiante As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cbo_tipo_pago As ComboBox
    Friend WithEvents lbl_nro_cuotas As Label
    Friend WithEvents num_cuotas As NumericUpDown
    Friend WithEvents dgv_actividades As DataGridView
    Friend WithEvents groupbox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents dgv_inscripciones As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_dni_consulta As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents dgv_detalle As DataGridView
End Class
