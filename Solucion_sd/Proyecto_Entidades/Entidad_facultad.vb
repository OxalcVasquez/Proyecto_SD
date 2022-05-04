Public Class Entidad_facultad
    Private facultad_id As Integer
    Private nombre_facultad As String
    Public Property p_nombre_facultad() As String
        Get
            Return nombre_facultad
        End Get
        Set(ByVal value As String)
            nombre_facultad = value
        End Set
    End Property
    Public Property p_facultad_id() As Integer
        Get
            Return facultad_id
        End Get
        Set(ByVal value As Integer)
            facultad_id = value
        End Set
    End Property

End Class
