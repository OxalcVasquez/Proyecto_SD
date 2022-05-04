Public Class Entidad_alumno
    Private alumno_id As Integer
    Private dni As String
    Private ape_paterno As String
    Private ape_materno As String
    Private nombres As String
    Private sexo As String
    Private fecha_nacimiento As Date
    Private semestre_ingreso As String
    Private escuela_id As Integer

    Public Property p_alumno_id() As Integer
        Get
            Return alumno_id
        End Get
        Set(ByVal value As Integer)
            alumno_id = value
        End Set
    End Property
    Public Property p_dni() As String
        Get
            Return dni
        End Get
        Set(ByVal value As String)
            dni = value
        End Set
    End Property
    Public Property p_ape_paterno() As String
        Get
            Return ape_paterno
        End Get
        Set(ByVal value As String)
            ape_paterno = value
        End Set
    End Property
    Public Property p_ape_materno() As String
        Get
            Return ape_materno
        End Get
        Set(ByVal value As String)
            ape_materno = value
        End Set
    End Property
    Public Property p_nombres() As String
        Get
            Return nombres
        End Get
        Set(ByVal value As String)
            nombres = value
        End Set
    End Property

    Public Property p_sexo() As String
        Get
            Return sexo
        End Get
        Set(ByVal value As String)
            sexo = value
        End Set
    End Property
    Public Property p_fecha_nacimiento() As Date
        Get
            Return fecha_nacimiento
        End Get
        Set(ByVal value As Date)
            fecha_nacimiento = value
        End Set
    End Property
    Public Property p_semestre_ingreso() As String
        Get
            Return semestre_ingreso
        End Get
        Set(ByVal value As String)
            semestre_ingreso = value
        End Set
    End Property
    Public Property p_escuela_id() As Integer
        Get
            Return escuela_id
        End Get
        Set(ByVal value As Integer)
            escuela_id = value
        End Set
    End Property

End Class
