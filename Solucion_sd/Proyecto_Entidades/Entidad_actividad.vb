Public Class Entidad_actividad

    Private actividad_id As Integer
    Private tipo As String
    Private nombre As String
    Private descripcion As String
    Private fecha As Date
    Private h_inicio As Date
    Private h_fin As Date
    Private costo As Double
    Private evento_id As Integer

    Public Property p_actividad_id() As Integer
        Get
            Return actividad_id
        End Get
        Set(ByVal value As Integer)
            actividad_id = value
        End Set
    End Property
    Public Property p_tipo() As String
        Get
            Return tipo
        End Get
        Set(ByVal value As String)
            tipo = value
        End Set
    End Property
    Public Property p_nombre() As String
        Get
            Return nombre
        End Get
        Set(ByVal value As String)
            nombre = value
        End Set
    End Property
    Public Property p_descripcion() As String
        Get
            Return descripcion
        End Get
        Set(ByVal value As String)
            descripcion = value
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
    Public Property p_h_inicio() As Date
        Get
            Return h_inicio
        End Get
        Set(ByVal value As Date)
            h_inicio = value
        End Set
    End Property
    Public Property p_h_fin() As Date
        Get
            Return h_fin
        End Get
        Set(ByVal value As Date)
            h_fin = value
        End Set
    End Property
    Public Property p_tiene_costo() As Double
        Get
            Return costo
        End Get
        Set(ByVal value As Double)
            costo = value
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
