<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_actividad
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
        Me.dgv_actividades = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbl_codigo = New System.Windows.Forms.Label()
        Me.dth_fin = New System.Windows.Forms.DateTimePicker()
        Me.dth_inicio = New System.Windows.Forms.DateTimePicker()
        Me.chl_costo = New System.Windows.Forms.CheckBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtp_fecha = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_descripcion = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbo_evento = New System.Windows.Forms.ComboBox()
        Me.cbo_tipo = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.btn_modificar = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_grabar = New System.Windows.Forms.Button()
        Me.btn_agregar = New System.Windows.Forms.Button()
        CType(Me.dgv_actividades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv_actividades
        '
        Me.dgv_actividades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_actividades.Location = New System.Drawing.Point(12, 358)
        Me.dgv_actividades.Name = "dgv_actividades"
        Me.dgv_actividades.RowHeadersWidth = 51
        Me.dgv_actividades.RowTemplate.Height = 24
        Me.dgv_actividades.Size = New System.Drawing.Size(776, 150)
        Me.dgv_actividades.TabIndex = 39
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbl_codigo)
        Me.GroupBox1.Controls.Add(Me.dth_fin)
        Me.GroupBox1.Controls.Add(Me.dth_inicio)
        Me.GroupBox1.Controls.Add(Me.chl_costo)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.dtp_fecha)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txt_descripcion)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cbo_evento)
        Me.GroupBox1.Controls.Add(Me.cbo_tipo)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txt_nombre)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 14)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(776, 265)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Información Actividad"
        '
        'lbl_codigo
        '
        Me.lbl_codigo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_codigo.Location = New System.Drawing.Point(145, 18)
        Me.lbl_codigo.Name = "lbl_codigo"
        Me.lbl_codigo.Size = New System.Drawing.Size(135, 35)
        Me.lbl_codigo.TabIndex = 20
        Me.lbl_codigo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dth_fin
        '
        Me.dth_fin.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dth_fin.Location = New System.Drawing.Point(513, 227)
        Me.dth_fin.Name = "dth_fin"
        Me.dth_fin.ShowUpDown = True
        Me.dth_fin.Size = New System.Drawing.Size(120, 22)
        Me.dth_fin.TabIndex = 19
        '
        'dth_inicio
        '
        Me.dth_inicio.AccessibleDescription = "dth_fin"
        Me.dth_inicio.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dth_inicio.Location = New System.Drawing.Point(513, 178)
        Me.dth_inicio.Name = "dth_inicio"
        Me.dth_inicio.ShowUpDown = True
        Me.dth_inicio.Size = New System.Drawing.Size(120, 22)
        Me.dth_inicio.TabIndex = 18
        '
        'chl_costo
        '
        Me.chl_costo.AutoSize = True
        Me.chl_costo.Location = New System.Drawing.Point(145, 226)
        Me.chl_costo.Name = "chl_costo"
        Me.chl_costo.Size = New System.Drawing.Size(47, 20)
        Me.chl_costo.TabIndex = 17
        Me.chl_costo.Text = "No"
        Me.chl_costo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chl_costo.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(19, 227)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 23)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Tiene Costo"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(407, 227)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 23)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "H. Fin"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(407, 182)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 23)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "H. Inicio"
        '
        'dtp_fecha
        '
        Me.dtp_fecha.Location = New System.Drawing.Point(145, 177)
        Me.dtp_fecha.Name = "dtp_fecha"
        Me.dtp_fecha.Size = New System.Drawing.Size(235, 22)
        Me.dtp_fecha.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(19, 177)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 23)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Fecha"
        '
        'txt_descripcion
        '
        Me.txt_descripcion.Location = New System.Drawing.Point(513, 64)
        Me.txt_descripcion.Name = "txt_descripcion"
        Me.txt_descripcion.Size = New System.Drawing.Size(232, 22)
        Me.txt_descripcion.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(407, 67)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 23)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Descripcion"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(19, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 23)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Actividad ID"
        '
        'cbo_evento
        '
        Me.cbo_evento.FormattingEnabled = True
        Me.cbo_evento.Location = New System.Drawing.Point(513, 124)
        Me.cbo_evento.Name = "cbo_evento"
        Me.cbo_evento.Size = New System.Drawing.Size(232, 24)
        Me.cbo_evento.TabIndex = 7
        '
        'cbo_tipo
        '
        Me.cbo_tipo.FormattingEnabled = True
        Me.cbo_tipo.Location = New System.Drawing.Point(145, 124)
        Me.cbo_tipo.Name = "cbo_tipo"
        Me.cbo_tipo.Size = New System.Drawing.Size(235, 24)
        Me.cbo_tipo.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(407, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 23)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Evento"
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(145, 64)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(235, 22)
        Me.txt_nombre.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(19, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tipo Actividad"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(19, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'btn_salir
        '
        Me.btn_salir.Location = New System.Drawing.Point(650, 305)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(138, 33)
        Me.btn_salir.TabIndex = 44
        Me.btn_salir.Text = "Salir"
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'btn_modificar
        '
        Me.btn_modificar.Location = New System.Drawing.Point(301, 305)
        Me.btn_modificar.Name = "btn_modificar"
        Me.btn_modificar.Size = New System.Drawing.Size(128, 33)
        Me.btn_modificar.TabIndex = 43
        Me.btn_modificar.Text = "Modificar"
        Me.btn_modificar.UseVisualStyleBackColor = True
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Location = New System.Drawing.Point(451, 305)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(128, 33)
        Me.btn_eliminar.TabIndex = 42
        Me.btn_eliminar.Text = "Eliminar"
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'btn_grabar
        '
        Me.btn_grabar.Location = New System.Drawing.Point(157, 305)
        Me.btn_grabar.Name = "btn_grabar"
        Me.btn_grabar.Size = New System.Drawing.Size(128, 33)
        Me.btn_grabar.TabIndex = 41
        Me.btn_grabar.Text = "Grabar"
        Me.btn_grabar.UseVisualStyleBackColor = True
        '
        'btn_agregar
        '
        Me.btn_agregar.Location = New System.Drawing.Point(12, 305)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(128, 33)
        Me.btn_agregar.TabIndex = 40
        Me.btn_agregar.Text = "Agregar"
        Me.btn_agregar.UseVisualStyleBackColor = True
        '
        'frm_actividad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(802, 520)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_modificar)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.btn_grabar)
        Me.Controls.Add(Me.btn_agregar)
        Me.Controls.Add(Me.dgv_actividades)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frm_actividad"
        Me.Text = "Mantenimiento Actividad"
        CType(Me.dgv_actividades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgv_actividades As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbo_evento As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dtp_fecha As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_descripcion As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents dth_inicio As DateTimePicker
    Friend WithEvents chl_costo As CheckBox
    Friend WithEvents dth_fin As DateTimePicker
    Friend WithEvents lbl_codigo As Label
    Friend WithEvents cbo_tipo As ComboBox
    Friend WithEvents btn_salir As Button
    Friend WithEvents btn_modificar As Button
    Friend WithEvents btn_eliminar As Button
    Friend WithEvents btn_grabar As Button
    Friend WithEvents btn_agregar As Button
End Class
