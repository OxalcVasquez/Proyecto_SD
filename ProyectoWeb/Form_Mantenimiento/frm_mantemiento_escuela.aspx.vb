Imports Proyecto_LogicaNegocio
Imports Proyecto_Entidades


Public Class frm_mantemiento_escuela
    Inherits System.Web.UI.Page
    Private obj_escuela As New Escuela 'Capa Logica
    Private obj_facultad As New Facultad
    Private obj_e_escuela As New Entidad_escuela

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        refrescar_grilla()
        'isPostBack false primera carga
        If Not IsPostBack Then
            cbo_facultad.DataSource = obj_facultad.listar_facultades()
            cbo_facultad.DataTextField = "nombre_facultad"
            cbo_facultad.DataValueField = "facultad_id"
            cbo_facultad.DataBind()
        End If

    End Sub

    Public Sub refrescar_grilla()
        Me.dgv_escuelas.DataSource = obj_escuela.listar_escuelas()
        Me.dgv_escuelas.DataBind()

    End Sub

    Public Sub limpiar()
        lbl_codigo.Text = ""
        txt_nombre.Text = ""
        cbo_facultad.SelectedIndex = 0

    End Sub

    Protected Sub dgv_escuelas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dgv_escuelas.SelectedIndexChanged
        Try
            lbl_codigo.Text = dgv_escuelas.SelectedRow.Cells(1).Text
            txt_nombre.Text = dgv_escuelas.SelectedRow.Cells(2).Text
            Dim cod_fac As Integer = dgv_escuelas.SelectedRow.Cells(3).Text
            cbo_facultad.SelectedItem.Text = obj_facultad.listar_facultad(cod_fac).p_nombre_facultad




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
            obj_e_escuela.p_nombre_escuela = txt_nombre.Text
            obj_e_escuela.p_facultad_id = cbo_facultad.SelectedValue
            lbl_codigo.Text = obj_escuela.insertar_escuela(obj_e_escuela)
            refrescar_grilla()
            limpiar()

        Catch ex As Exception

        End Try
    End Sub

    Protected Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Try

            obj_e_escuela.p_escuela_id = lbl_codigo.Text
            obj_escuela.eliminar_escuela(obj_e_escuela)
            MsgBox("Escuela eliminada con éxito")
            refrescar_grilla()
            limpiar()
        Catch ex As Exception

        End Try
    End Sub

    Protected Sub btn_modificar_Click(sender As Object, e As EventArgs) Handles btn_modificar.Click
        Try
            obj_e_escuela.p_escuela_id = lbl_codigo.Text
            obj_e_escuela.p_nombre_escuela = txt_nombre.Text
            obj_e_escuela.p_facultad_id = cbo_facultad.SelectedValue
            lbl_codigo.Text = obj_escuela.modificar_escuela(obj_e_escuela)
            MsgBox("Escuela modificada con éxito")
            refrescar_grilla()
            limpiar()

        Catch ex As Exception

        End Try
    End Sub
End Class