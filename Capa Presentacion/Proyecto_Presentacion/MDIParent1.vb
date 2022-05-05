Imports System.Windows.Forms

Public Class MDIParent1

    Private Sub Mostrar_frm_alumno(ByVal sender As Object, ByVal e As EventArgs) Handles NewWindowToolStripMenuItem.Click
        frm_alumno.Show()
    End Sub

    Private Sub EscuelasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EscuelasToolStripMenuItem.Click
        frm_escuela.Show()
    End Sub

    Private Sub GestiónFacultadesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestiónFacultadesToolStripMenuItem.Click
        frm_facultad.Show()
    End Sub

    Private Sub GestiónSemestreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestiónSemestreToolStripMenuItem.Click
        frm_semestre.Show()
    End Sub

    Private Sub RegistroActivdadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistroActivdadToolStripMenuItem.Click
        frm_actividad.Show()
    End Sub
    Private Sub RegistroEventoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistroEventoToolStripMenuItem.Click
        frm_evento.Show()
    End Sub
End Class
