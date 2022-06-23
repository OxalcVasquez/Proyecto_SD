Imports Proyecto_LogicaNegocio
Imports Proyecto_Entidades

Public Class WebForm1
    Inherits System.Web.UI.Page
    Dim obj_evento As New Evento
    Dim obj_actividad As New Actividad
    Dim obj_inscripcion As New Inscripcion

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        refrescar_grilla_inscripcion()
        num_cuotas.Visible = False
        lbl_nro_cuotas.Visible = False
        If Not IsPostBack Then
            cbo_eventos.DataSource = obj_evento.listar_eventos_vigentes()
            cbo_eventos.DataTextField = "nombre_evento"
            cbo_eventos.DataValueField = "evento_id"
            cbo_eventos.DataBind()
            refrescar_grilla_actividad(cbo_eventos.SelectedValue)

        End If
    End Sub

    Public Sub refrescar_grilla_detalle(ByVal ins_id As Integer)
        Me.dgv_detalle.DataSource = obj_inscripcion.listar_actividades_inscripcion(ins_id)
        Me.dgv_detalle.DataBind()


    End Sub

    Public Sub refrescar_grilla_inscripcion()
        If txt_dni_consulta.Text.Equals("") Then
            Me.dgv_inscripciones.DataSource = obj_inscripcion.listar_inscripcion()
        Else
            Me.dgv_inscripciones.DataSource = obj_inscripcion.listar_inscripcion_alumno(txt_dni_consulta.Text)
        End If

        Me.dgv_inscripciones.DataBind()

    End Sub

    Public Sub refrescar_grilla_actividad(ByVal evento_id As String)

        Me.dgv_actividades.DataSource = obj_actividad.listar_actividades_evento(evento_id)

        Me.dgv_actividades.DataBind()

    End Sub

    Protected Sub cbo_tipo_pago_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_tipo_pago.SelectedIndexChanged
        If cbo_tipo_pago.SelectedValue.Equals("D") Then
            num_cuotas.Visible = True
            lbl_nro_cuotas.Visible = True
        Else
            num_cuotas.Visible = False
            lbl_nro_cuotas.Visible = False
        End If
    End Sub

    Protected Sub cbo_eventos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_eventos.SelectedIndexChanged
        refrescar_grilla_actividad(cbo_eventos.SelectedValue)

    End Sub

    Protected Sub dgv_inscripciones_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dgv_inscripciones.SelectedIndexChanged

        Dim id_inscripcion As Integer
        id_inscripcion = 0
        id_inscripcion = Me.dgv_inscripciones.SelectedRow.Cells(1).Text
        refrescar_grilla_detalle(id_inscripcion)

    End Sub



    Protected Sub btn_buscar_estudiante_Click(sender As Object, e As EventArgs) Handles btn_buscar_estudiante.Click
        Dim obj_alumno As New Alumno
        Dim obj_e_alumno = obj_alumno.listar_alumnos_dni(txt_dni.Text)
        Dim obj_insscripcion As New Inscripcion

        If obj_e_alumno.p_alumno_id > 0 Then
            If obj_insscripcion.verificar_inscripcion_evento(cbo_eventos.SelectedValue, obj_e_alumno.p_alumno_id) Then
                lbl_estudiante.Text = obj_e_alumno.p_nombres & " " & obj_e_alumno.p_ape_paterno & " " & obj_e_alumno.p_ape_materno
            Else
                MsgBox("El alumno ya se encuentra registrado en este evento")
                txt_dni_consulta.Text = txt_dni.Text
                txt_dni.Text = ""
                lbl_estudiante.Text = ""


            End If
        Else
            MsgBox("El DNI ingresado no esta registrado")
        End If
    End Sub

    Protected Sub btn_consulta_Click(sender As Object, e As EventArgs) Handles btn_consulta.Click
        refrescar_grilla_inscripcion()

    End Sub

    Protected Sub btn_grabar_Click(sender As Object, e As EventArgs) Handles btn_grabar.Click
        num_cuotas.Text = "0"
        Dim obj_inscripcion As New Inscripcion
            Dim obj_e_inscripcion As New Entidad_inscripcion
            Dim obj_alumno As New Alumno
            Dim obj_e_alumno = obj_alumno.listar_alumnos_dni(txt_dni.Text)
            Dim lista_detalles As New List(Of Entidad_detalle_inscripcion)
        If obj_e_alumno.p_alumno_id > 0 Then
            If obj_inscripcion.verificar_inscripcion_evento(cbo_eventos.SelectedValue, obj_e_alumno.p_alumno_id) Then
                obj_e_inscripcion.p_tipo_pago = cbo_tipo_pago.SelectedValue
                obj_e_inscripcion.p_numero_cuotas = num_cuotas.Text
                obj_e_inscripcion.p_alumno_id = obj_e_alumno.p_alumno_id
                obj_e_inscripcion.p_estado = True
                obj_e_inscripcion.p_evento_id = cbo_eventos.SelectedValue
                Dim numSeleccionado As Integer
                numSeleccionado = 0
                If dgv_actividades.Rows.Count > 0 Then

                    For Each Fila As GridViewRow In dgv_actividades.Rows
                        Dim obj_e_detalle As New Entidad_detalle_inscripcion
                        If Not Fila Is Nothing Then
                            Dim result As CheckBox = CType(Fila.FindControl("chkActividad"), CheckBox)
                            If result.Checked Then
                                obj_e_detalle.p_actividad_id = Fila.Cells(1).Text
                                numSeleccionado = numSeleccionado + 1
                            End If
                        End If
                        lista_detalles.Add(obj_e_detalle)
                    Next
                End If
                If numSeleccionado > 0 Then
                    obj_inscripcion.insertar_inscripcion(obj_e_inscripcion, lista_detalles)
                    MsgBox("Su inscripción ha sido registrada exitosamente")

                Else
                    MsgBox("Por favor seleccione al menos una actividad")
                End If
            Else
                MsgBox("El alumno ya se encuentra registrado en este evento")
                txt_dni_consulta.Text = txt_dni.Text
                txt_dni.Text = ""

            End If
        Else
            MsgBox("El DNI ingresado no esta registrado")

        End If
        refrescar_grilla_inscripcion()


    End Sub

    Protected Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Dim obj_inscripcion As New Inscripcion
        Dim id_inscripcion As Integer
        id_inscripcion = 0
        Try
            If dgv_inscripciones.SelectedRow IsNot Nothing Then
                id_inscripcion = Me.dgv_inscripciones.SelectedRow.Cells(1).Text
                obj_inscripcion.eliminar_inscripcion(id_inscripcion)
                MsgBox("Se actualizo el estado de su inscripcion")
                refrescar_grilla_inscripcion()
            Else
                MsgBox("No ha seleccioando ninguna inscripcion")


            End If

        Catch ex As Exception
            MsgBox(ex)

        End Try
    End Sub
End Class