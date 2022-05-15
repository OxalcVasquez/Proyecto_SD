Public Class Entidad_inscripcion
    Private inscripcion_id As Integer
    Private fecha As Date
    Private hora As Date
    Private tipo_pago As String
    Private numero_cuotas As Integer
    Private alumno_id As Integer
    Private estado As Boolean
    Private evento_id As Integer

    Public Property p_inscripcion_id() As Integer
        Get
            Return inscripcion_id
        End Get
        Set(ByVal value As Integer)
            inscripcion_id = value
        End Set
    End Property

    Public Property p_fecha() As Date
        Get
            Return fecha
        End Get
        Set(ByVal value As Date)
            fecha = value
        End Set
    End Property
    Public Property p_hora() As Date
        Get
            Return hora
        End Get
        Set(ByVal value As Date)
            hora = value
        End Set
    End Property
    Public Property p_tipo_pago() As String
        Get
            Return tipo_pago
        End Get
        Set(ByVal value As String)
            tipo_pago = value
        End Set
    End Property
    Public Property p_numero_cuotas() As Integer
        Get
            Return numero_cuotas
        End Get
        Set(ByVal value As Integer)
            numero_cuotas = value
        End Set
    End Property
    Public Property p_alumno_id() As Integer
        Get
            Return alumno_id
        End Get
        Set(ByVal value As Integer)
            alumno_id = value
        End Set
    End Property
    Public Property p_estado() As Boolean
        Get
            Return estado
        End Get
        Set(ByVal value As Boolean)
            estado = value
        End Set
    End Property
    Public Property p_evento_id() As Integer
        Get
            Return evento_id
        End Get
        Set(ByVal value As Integer)
            evento_id = value
        End Set
    End Property

End Class
