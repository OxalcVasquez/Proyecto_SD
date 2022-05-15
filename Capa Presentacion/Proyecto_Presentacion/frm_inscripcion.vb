Imports Proyecto_LogicaNegocio
Imports Proyecto_Entidades
Public Class frm_inscripcion
    Private Sub frm_inscripcion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenar_cbo_evento()
        llenar_cbo_tipo()
        refrescar_grilla_actividad(cbo_eventos.SelectedValue)
        refrescar_grilla_inscripcion()



    End Sub

    Public Sub refrescar_grilla_actividad(ByVal evento_id As Integer)
        Dim obj_actividad As New Actividad
        dgv_actividades.DataSource = obj_actividad.listar_actividades_evento(evento_id)
        'Dim dt As DataTable = DirectCast(dgv_actividades.DataSource, DataTable)
        'dt.Columns.Add(New DataColumn("Inscripcion", GetType(Boolean)))

        'dgv_actividades.DataSource = dt


        With dgv_actividades
            .Columns(0).Width = 30
            .Columns(0).HeaderText = "ID"
            .Columns(1).Width = 80
            .Columns(1).HeaderText = "Tipo"
            .Columns(2).Width = 120
            .Columns(2).HeaderText = "Nombre"
            .Columns(3).Width = 150
            .Columns(3).HeaderText = "Descripcion"
            .Columns(4).Width = 70
            .Columns(4).HeaderText = "Fecha"
            .Columns(5).Width = 60
            .Columns(5).HeaderText = "Inicio"
            .Columns(6).Width = 60
            .Columns(6).HeaderText = "Fin"
            .Columns(7).Visible = False
            .Columns(8).HeaderText = "Costo"
            .Columns(8).Width = 50
            .RowHeadersVisible = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect

        End With
        If dgv_actividades.Columns.Count < 10 Then
            Dim columnCheckBox As New DataGridViewCheckBoxColumn

            columnCheckBox.HeaderText = "Inscribirse"
            columnCheckBox.Name = "chkInscribirse"
            With dgv_actividades
                .Columns.Add(columnCheckBox)
                .Columns(9).Width = 60
                '.ReadOnly = True
                .Columns(9).ReadOnly = False
            End With

        End If
        'dgv_actividades.DataSource = dt

    End Sub

    Public Sub refrescar_grilla_inscripcion()
        Dim obj_inscripcion As New Inscripcion
        If txt_dni_consulta.Text.Equals("") Then
            dgv_inscripciones.DataSource = obj_inscripcion.listar_inscripcion()
        Else
            dgv_inscripciones.DataSource = obj_inscripcion.listar_inscripcion_alumno(txt_dni_consulta.Text)
        End If

        With dgv_inscripciones
            .Columns(0).Width = 30
            .Columns(0).HeaderText = "ID"
            .Columns(1).Width = 130
            .Columns(1).HeaderText = "Fecha y Hora Inscripcion"
            .Columns(2).Visible = False
            .Columns(3).Width = 100
            .Columns(3).HeaderText = "Tipo Pago"
            .Columns(4).Width = 50
            .Columns(4).HeaderText = "Cuotas"
            .Columns(5).Visible = False
            .Columns(6).Width = 80
            .Columns(6).HeaderText = "Estado Ins."
            .Columns(7).Visible = False
            .Columns(8).Width = 150
            .Columns(8).HeaderText = "Evento"
            .Columns(9).Width = 80
            .Columns(9).HeaderText = "DNI"
            .Columns(10).Width = 200
            .Columns(10).HeaderText = "Alumno"
            .ReadOnly = True
            .RowHeadersVisible = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect

        End With


    End Sub

    Public Sub refrescar_grilla_detalle(ByVal ins_id As Integer)
        Dim obj_inscripcion As New Inscripcion
        dgv_detalle.DataSource = obj_inscripcion.listar_actividades_inscripcion(ins_id)

        With dgv_detalle
            .Columns(0).Width = 30
            .Columns(0).HeaderText = "ID"
            .Columns(1).Width = 60
            .Columns(1).HeaderText = "Inscripcion"
            .Columns(2).Visible = False
            .Columns(3).Visible = False
            .Columns(4).Width = 100
            .Columns(4).HeaderText = "Actividad"
            .ReadOnly = True
            .RowHeadersVisible = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect

        End With


    End Sub


    Public Sub llenar_cbo_tipo()
        Dim dt As DataTable = New DataTable("Tabla")

        dt.Columns.Add("Valor")
        dt.Columns.Add("Descripcion")

        Dim dr As DataRow

        dr = dt.NewRow()
        dr("Valor") = "E"
        dr("Descripcion") = "Efectivo"
        dt.Rows.Add(dr)

        dr = dt.NewRow()
        dr("Valor") = "D"
        dr("Descripcion") = "Diferido"
        dt.Rows.Add(dr)

        cbo_tipo_pago.DataSource = dt
        cbo_tipo_pago.ValueMember = "Valor"
        cbo_tipo_pago.DisplayMember = "Descripcion"
        cbo_tipo_pago.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub



    Public Sub llenar_cbo_evento()
        Dim obj_evento As New Evento
        With cbo_eventos
            .DataSource = obj_evento.listar_eventos_vigentes
            .DisplayMember = "nombre_evento"
            .ValueMember = "evento_id"
            .DropDownStyle = ComboBoxStyle.DropDownList

        End With
    End Sub

    Private Sub cbo_eventos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_eventos.SelectedIndexChanged
        If Not TypeOf cbo_eventos.SelectedValue Is DataRowView Then
            dgv_actividades.Columns.RemoveAt(9)
            refrescar_grilla_actividad(cbo_eventos.SelectedValue)

        End If

    End Sub

    Private Sub txt_dni_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_dni.KeyPress

        If AscW(e.KeyChar) = CInt(Keys.Enter) Then
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

                End If
            Else
                MsgBox("El DNI ingresado no esta registrado")
                frm_alumno.Show()
            End If

        End If

    End Sub



    Private Sub cbo_tipo_pago_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_tipo_pago.SelectedIndexChanged
        If Not TypeOf cbo_tipo_pago.SelectedValue Is DataRowView Then
            If cbo_tipo_pago.SelectedValue.Equals("D") Then
                num_cuotas.Visible = True
                lbl_nro_cuotas.Visible = True
            Else
                num_cuotas.Visible = False
                lbl_nro_cuotas.Visible = False
            End If

        End If
    End Sub

    Private Sub btn_grabar_Click(sender As Object, e As EventArgs) Handles btn_grabar.Click
        Try
            Dim obj_inscripcion As New Inscripcion
            Dim obj_e_inscripcion As New Entidad_inscripcion
            Dim obj_alumno As New Alumno
            Dim obj_e_alumno = obj_alumno.listar_alumnos_dni(txt_dni.Text)
            Dim lista_detalles As New List(Of Entidad_detalle_inscripcion)
            If obj_e_alumno.p_alumno_id > 0 Then
                If obj_inscripcion.verificar_inscripcion_evento(cbo_eventos.SelectedValue, obj_e_alumno.p_alumno_id) Then
                    obj_e_inscripcion.p_tipo_pago = cbo_tipo_pago.SelectedValue
                    obj_e_inscripcion.p_numero_cuotas = num_cuotas.Value
                    obj_e_inscripcion.p_alumno_id = obj_e_alumno.p_alumno_id
                    obj_e_inscripcion.p_estado = True
                    obj_e_inscripcion.p_evento_id = cbo_eventos.SelectedValue
                    Dim numSeleccionado As Integer
                    numSeleccionado = 0
                    If dgv_actividades.Rows.Count > 0 Then

                        For Each Fila As DataGridViewRow In dgv_actividades.Rows
                            Dim obj_e_detalle As New Entidad_detalle_inscripcion
                            If Not Fila Is Nothing Then
                                If Fila.Cells(9).Value Then
                                    obj_e_detalle.p_actividad_id = Fila.Cells(0).Value
                                    numSeleccionado = numSeleccionado + 1
                                End If
                            End If
                            lista_detalles.Add(obj_e_detalle)
                        Next
                    End If
                    If numSeleccionado > 0 Then
                        obj_inscripcion.insertar_inscripcion(obj_e_inscripcion, lista_detalles)
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
                frm_alumno.Show()
            End If

        Catch ex As Exception
            MsgBox(ex)
        End Try

    End Sub

    Private Sub txt_dni_consultaKeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_dni_consulta.KeyPress

        If AscW(e.KeyChar) = CInt(Keys.Enter) Then
            refrescar_grilla_inscripcion()

        End If

    End Sub





    Private Sub dgv_inscripcion_SelectionChanged(sender As Object, e As EventArgs) Handles dgv_inscripciones.SelectionChanged
        Try

            Dim id_inscripcion As Integer
            id_inscripcion = 0
            id_inscripcion = Me.dgv_inscripciones.CurrentRow.Cells(0).Value
            refrescar_grilla_detalle(id_inscripcion)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Dim obj_inscripcion As New Inscripcion
        Dim id_inscripcion As Integer
        id_inscripcion = 0
        Try
            If dgv_inscripciones.CurrentRow IsNot Nothing Then
                id_inscripcion = Me.dgv_inscripciones.CurrentRow.Cells(0).Value
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

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class