Public Class Entidad_escuela
    Private escuela_id As Integer
    Private facultad_id As Integer
    Private nombre_escuela As String

    Public Property p_escuela_id() As Integer
        Get
            Return escuela_id
        End Get
        Set(ByVal value As Integer)
            escuela_id = value
        End Set
    End Property
    Public Property p_nombre_escuela() As String
        Get
            Return nombre_escuela
        End Get
        Set(ByVal value As String)
            nombre_escuela = value
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
