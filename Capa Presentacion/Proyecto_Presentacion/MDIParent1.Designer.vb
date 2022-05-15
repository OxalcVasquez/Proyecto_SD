<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDIParent1
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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.WindowsMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewWindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EscuelasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestiónFacultadesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestiónSemestreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EventosYActividadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistroActivdadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistroEventoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.InscribirseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InscripcionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.WindowsMenu, Me.EventosYActividadToolStripMenuItem, Me.InscribirseToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.MdiWindowListItem = Me.WindowsMenu
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(843, 28)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'WindowsMenu
        '
        Me.WindowsMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewWindowToolStripMenuItem, Me.EscuelasToolStripMenuItem, Me.GestiónFacultadesToolStripMenuItem, Me.GestiónSemestreToolStripMenuItem})
        Me.WindowsMenu.Name = "WindowsMenu"
        Me.WindowsMenu.Size = New System.Drawing.Size(130, 24)
        Me.WindowsMenu.Text = "Mantenimientos"
        '
        'NewWindowToolStripMenuItem
        '
        Me.NewWindowToolStripMenuItem.Name = "NewWindowToolStripMenuItem"
        Me.NewWindowToolStripMenuItem.Size = New System.Drawing.Size(215, 26)
        Me.NewWindowToolStripMenuItem.Text = "Gestión Alumnos"
        '
        'EscuelasToolStripMenuItem
        '
        Me.EscuelasToolStripMenuItem.Name = "EscuelasToolStripMenuItem"
        Me.EscuelasToolStripMenuItem.Size = New System.Drawing.Size(215, 26)
        Me.EscuelasToolStripMenuItem.Text = "Gestión Escuelas"
        '
        'GestiónFacultadesToolStripMenuItem
        '
        Me.GestiónFacultadesToolStripMenuItem.Name = "GestiónFacultadesToolStripMenuItem"
        Me.GestiónFacultadesToolStripMenuItem.Size = New System.Drawing.Size(215, 26)
        Me.GestiónFacultadesToolStripMenuItem.Text = "Gestión Facultades"
        '
        'GestiónSemestreToolStripMenuItem
        '
        Me.GestiónSemestreToolStripMenuItem.Name = "GestiónSemestreToolStripMenuItem"
        Me.GestiónSemestreToolStripMenuItem.Size = New System.Drawing.Size(215, 26)
        Me.GestiónSemestreToolStripMenuItem.Text = "Gestión Semestre"
        '
        'EventosYActividadToolStripMenuItem
        '
        Me.EventosYActividadToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistroActivdadToolStripMenuItem, Me.RegistroEventoToolStripMenuItem})
        Me.EventosYActividadToolStripMenuItem.Name = "EventosYActividadToolStripMenuItem"
        Me.EventosYActividadToolStripMenuItem.Size = New System.Drawing.Size(150, 24)
        Me.EventosYActividadToolStripMenuItem.Text = "Eventos y actividad"
        '
        'RegistroActivdadToolStripMenuItem
        '
        Me.RegistroActivdadToolStripMenuItem.Name = "RegistroActivdadToolStripMenuItem"
        Me.RegistroActivdadToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.RegistroActivdadToolStripMenuItem.Text = "Registro activdad"
        '
        'RegistroEventoToolStripMenuItem
        '
        Me.RegistroEventoToolStripMenuItem.Name = "RegistroEventoToolStripMenuItem"
        Me.RegistroEventoToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.RegistroEventoToolStripMenuItem.Text = "Registro evento"
        '
        'StatusStrip
        '
        Me.StatusStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 532)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip.Size = New System.Drawing.Size(843, 26)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(54, 20)
        Me.ToolStripStatusLabel.Text = "Estado"
        '
        'InscribirseToolStripMenuItem
        '
        Me.InscribirseToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InscripcionToolStripMenuItem})
        Me.InscribirseToolStripMenuItem.Name = "InscribirseToolStripMenuItem"
        Me.InscribirseToolStripMenuItem.Size = New System.Drawing.Size(89, 24)
        Me.InscribirseToolStripMenuItem.Text = "Inscribirse"
        '
        'InscripcionToolStripMenuItem
        '
        Me.InscripcionToolStripMenuItem.Name = "InscripcionToolStripMenuItem"
        Me.InscripcionToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.InscripcionToolStripMenuItem.Text = "Inscripcion"
        '
        'MDIParent1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(843, 558)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MDIParent1"
        Me.Text = "Formulario Principal"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents WindowsMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents NewWindowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EscuelasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestiónFacultadesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestiónSemestreToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EventosYActividadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistroActivdadToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistroEventoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InscribirseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InscripcionToolStripMenuItem As ToolStripMenuItem
End Class
