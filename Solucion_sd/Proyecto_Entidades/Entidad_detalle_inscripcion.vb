Public Class Entidad_detalle_inscripcion
    Private detalle_id As Integer
    Private inscripcion_id As Integer
    Private actividad_id As Integer
    Private estado_asistencia As Boolean
    Public Property p_detalle_id() As Integer
        Get
            Return detalle_id
        End Get
        Set(ByVal value As Integer)
            detalle_id = value
        End Set
    End Property
    Public Property p_inscripcion_id() As Integer
        Get
            Return inscripcion_id
        End Get
        Set(ByVal value As Integer)
            inscripcion_id = value
        End Set
    End Property
    Public Property p_actividad_id() As Integer
        Get
            Return actividad_id
        End Get
        Set(ByVal value As Integer)
            actividad_id = value
        End Set
    End Property
    Public Property p_estado_asistencia() As Boolean
        Get
            Return estado_asistencia
        End Get
        Set(ByVal value As Boolean)
            estado_asistencia = value
        End Set
    End Property
End Class
