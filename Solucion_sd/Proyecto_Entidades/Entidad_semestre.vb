Public Class Entidad_semestre
    Private semestre_id As String
    Private f_inicio As Date
    Private f_fin As Date
    Private estado As Boolean

    Public Property p_semestre_id() As String
        Get
            Return semestre_id
        End Get
        Set(ByVal value As String)
            semestre_id = value
        End Set
    End Property
    Public Property p_f_inicio() As Date
        Get
            Return f_inicio
        End Get
        Set(ByVal value As Date)
            f_inicio = value
        End Set
    End Property
    Public Property p_f_fin() As Date
        Get
            Return f_fin
        End Get
        Set(ByVal value As Date)
            f_fin = value
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


End Class
