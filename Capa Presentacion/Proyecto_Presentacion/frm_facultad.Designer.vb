<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_facultad
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_codigo = New System.Windows.Forms.Label()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.btn_modificar = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_grabar = New System.Windows.Forms.Button()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.dgv_facultades = New System.Windows.Forms.DataGridView()
        CType(Me.dgv_facultades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(62, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(185, 35)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Nombre de Facultad"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(62, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(185, 35)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Código de Facultad"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_codigo
        '
        Me.lbl_codigo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_codigo.Location = New System.Drawing.Point(283, 44)
        Me.lbl_codigo.Name = "lbl_codigo"
        Me.lbl_codigo.Size = New System.Drawing.Size(135, 35)
        Me.lbl_codigo.TabIndex = 5
        Me.lbl_codigo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(283, 96)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(245, 22)
        Me.txt_nombre.TabIndex = 6
        '
        'btn_salir
        '
        Me.btn_salir.Location = New System.Drawing.Point(537, 157)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(105, 33)
        Me.btn_salir.TabIndex = 15
        Me.btn_salir.Text = "Salir"
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'btn_modificar
        '
        Me.btn_modificar.Location = New System.Drawing.Point(263, 157)
        Me.btn_modificar.Name = "btn_modificar"
        Me.btn_modificar.Size = New System.Drawing.Size(95, 33)
        Me.btn_modificar.TabIndex = 14
        Me.btn_modificar.Text = "Modificar"
        Me.btn_modificar.UseVisualStyleBackColor = True
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Location = New System.Drawing.Point(391, 157)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(95, 33)
        Me.btn_eliminar.TabIndex = 13
        Me.btn_eliminar.Text = "Eliminar"
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'btn_grabar
        '
        Me.btn_grabar.Location = New System.Drawing.Point(152, 157)
        Me.btn_grabar.Name = "btn_grabar"
        Me.btn_grabar.Size = New System.Drawing.Size(95, 33)
        Me.btn_grabar.TabIndex = 12
        Me.btn_grabar.Text = "Grabar"
        Me.btn_grabar.UseVisualStyleBackColor = True
        '
        'btn_agregar
        '
        Me.btn_agregar.Location = New System.Drawing.Point(38, 157)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(95, 33)
        Me.btn_agregar.TabIndex = 11
        Me.btn_agregar.Text = "Agregar"
        Me.btn_agregar.UseVisualStyleBackColor = True
        '
        'dgv_facultades
        '
        Me.dgv_facultades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_facultades.Location = New System.Drawing.Point(38, 209)
        Me.dgv_facultades.Name = "dgv_facultades"
        Me.dgv_facultades.RowHeadersWidth = 51
        Me.dgv_facultades.RowTemplate.Height = 24
        Me.dgv_facultades.Size = New System.Drawing.Size(604, 238)
        Me.dgv_facultades.TabIndex = 16
        '
        'frm_facultad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(672, 472)
        Me.Controls.Add(Me.dgv_facultades)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_modificar)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.btn_grabar)
        Me.Controls.Add(Me.btn_agregar)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.lbl_codigo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frm_facultad"
        Me.Text = "Mantenimiento Facultad"
        CType(Me.dgv_facultades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_codigo As Label
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents btn_salir As Button
    Friend WithEvents btn_modificar As Button
    Friend WithEvents btn_eliminar As Button
    Friend WithEvents btn_grabar As Button
    Friend WithEvents btn_agregar As Button
    Friend WithEvents dgv_facultades As DataGridView
End Class
