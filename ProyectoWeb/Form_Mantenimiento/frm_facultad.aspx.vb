Imports Proyecto_LogicaNegocio
Imports Proyecto_Entidades
Public Class frm_facultad
    Inherits System.Web.UI.Page

    Private obj_facultad As New Facultad
    Private obj_e_facultad As New Entidad_facultad

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        refrescar_grilla()

    End Sub

    Public Sub refrescar_grilla()
        Me.dgv_facultad.DataSource = obj_facultad.listar_facultades()
        Me.dgv_facultad.DataBind()

    End Sub

    Public Sub limpiar()
        lbl_codigo_facultad.Text = ""
        txt_nombre_facultad.Text = ""
    End Sub

    Protected Sub dgv_facultad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dgv_facultad.SelectedIndexChanged
        Try
            lbl_codigo_facultad.Text = dgv_facultad.SelectedRow.Cells(1).Text
            txt_nombre_facultad.Text = dgv_facultad.SelectedRow.Cells(2).Text

        Catch ex As Exception

        End Try
    End Sub

    Protected Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        Try
            limpiar()

        Catch ex As Exception

        End Try
    End Sub

    Protected Sub btn_grabar_Click(sender As Object, e As EventArgs) Handles btn_grabar.Click
        Try
            obj_e_facultad.p_nombre_facultad = txt_nombre_facultad.Text
            obj_facultad.insertar_facultad(obj_e_facultad)
            refrescar_grilla()
            limpiar()

        Catch ex As Exception

        End Try
    End Sub

    Protected Sub btn_modificar_Click(sender As Object, e As EventArgs) Handles btn_modificar.Click
        Try
            obj_e_facultad.p_facultad_id = lbl_codigo_facultad.Text
            obj_e_facultad.p_nombre_facultad = txt_nombre_facultad.Text
            obj_facultad.modificar_facultad(obj_e_facultad)
            refrescar_grilla()
            limpiar()

        Catch ex As Exception

        End Try
    End Sub

    Protected Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click

        obj_facultad.eliminar_facultad(lbl_codigo_facultad.Text)
        refrescar_grilla()
        limpiar()
    End Sub
End Class