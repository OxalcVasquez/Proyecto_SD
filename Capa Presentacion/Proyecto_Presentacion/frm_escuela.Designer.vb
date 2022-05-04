<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_escuela
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_codigo = New System.Windows.Forms.Label()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.cbo_facultad = New System.Windows.Forms.ComboBox()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.btn_grabar = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_modificar = New System.Windows.Forms.Button()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.dgv_escuelas = New System.Windows.Forms.DataGridView()
        CType(Me.dgv_escuelas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(36, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(185, 35)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código de Escuela"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(39, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(182, 35)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Facultad"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(36, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(185, 35)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nombre de Escuela"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_codigo
        '
        Me.lbl_codigo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_codigo.Location = New System.Drawing.Point(284, 30)
        Me.lbl_codigo.Name = "lbl_codigo"
        Me.lbl_codigo.Size = New System.Drawing.Size(135, 35)
        Me.lbl_codigo.TabIndex = 3
        Me.lbl_codigo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(287, 90)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(351, 22)
        Me.txt_nombre.TabIndex = 4
        '
        'cbo_facultad
        '
        Me.cbo_facultad.FormattingEnabled = True
        Me.cbo_facultad.Location = New System.Drawing.Point(284, 130)
        Me.cbo_facultad.Name = "cbo_facultad"
        Me.cbo_facultad.Size = New System.Drawing.Size(354, 24)
        Me.cbo_facultad.TabIndex = 5
        '
        'btn_agregar
        '
        Me.btn_agregar.Location = New System.Drawing.Point(36, 173)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(128, 33)
        Me.btn_agregar.TabIndex = 6
        Me.btn_agregar.Text = "Agregar"
        Me.btn_agregar.UseVisualStyleBackColor = True
        '
        'btn_grabar
        '
        Me.btn_grabar.Location = New System.Drawing.Point(170, 173)
        Me.btn_grabar.Name = "btn_grabar"
        Me.btn_grabar.Size = New System.Drawing.Size(128, 33)
        Me.btn_grabar.TabIndex = 7
        Me.btn_grabar.Text = "Grabar"
        Me.btn_grabar.UseVisualStyleBackColor = True
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Location = New System.Drawing.Point(448, 173)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(128, 33)
        Me.btn_eliminar.TabIndex = 8
        Me.btn_eliminar.Text = "Eliminar"
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'btn_modificar
        '
        Me.btn_modificar.Location = New System.Drawing.Point(314, 173)
        Me.btn_modificar.Name = "btn_modificar"
        Me.btn_modificar.Size = New System.Drawing.Size(128, 33)
        Me.btn_modificar.TabIndex = 9
        Me.btn_modificar.Text = "Modificar"
        Me.btn_modificar.UseVisualStyleBackColor = True
        '
        'btn_salir
        '
        Me.btn_salir.Location = New System.Drawing.Point(635, 173)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(138, 33)
        Me.btn_salir.TabIndex = 10
        Me.btn_salir.Text = "Salir"
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'dgv_escuelas
        '
        Me.dgv_escuelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_escuelas.Location = New System.Drawing.Point(36, 212)
        Me.dgv_escuelas.Name = "dgv_escuelas"
        Me.dgv_escuelas.RowHeadersWidth = 51
        Me.dgv_escuelas.RowTemplate.Height = 24
        Me.dgv_escuelas.Size = New System.Drawing.Size(737, 238)
        Me.dgv_escuelas.TabIndex = 11
        '
        'frm_escuela
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(802, 462)
        Me.Controls.Add(Me.dgv_escuelas)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_modificar)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.btn_grabar)
        Me.Controls.Add(Me.btn_agregar)
        Me.Controls.Add(Me.cbo_facultad)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.lbl_codigo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frm_escuela"
        Me.Text = "frm_escuela"
        CType(Me.dgv_escuelas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl_codigo As Label
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents cbo_facultad As ComboBox
    Friend WithEvents btn_agregar As Button
    Friend WithEvents btn_grabar As Button
    Friend WithEvents btn_eliminar As Button
    Friend WithEvents btn_modificar As Button
    Friend WithEvents btn_salir As Button
    Friend WithEvents dgv_escuelas As DataGridView
End Class
