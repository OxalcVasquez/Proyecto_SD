Public Class Entidad_evento
    Private evento_id As Integer
    Private nombre_evento As String
    Private tipo_evento As String
    Private semestre_id As String

    Public Property p_evento_id() As Integer
        Get
            Return evento_id
        End Get
        Set(ByVal value As Integer)
            evento_id = value
        End Set
    End Property
    Public Property p_nombre_evento() As String
        Get
            Return nombre_evento
        End Get
        Set(ByVal value As String)
            nombre_evento = value
        End Set
    End Property
    Public Property p_tipo_evento() As String
        Get
            Return tipo_evento
        End Get
        Set(ByVal value As String)
            tipo_evento = value
        End Set
    End Property
    Public Property p_semestre_id() As String
        Get
            Return semestre_id
        End Get
        Set(ByVal value As String)
            semestre_id = value
        End Set
    End Property

End Class
