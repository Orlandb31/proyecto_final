Public Class UserData
    Private gID As Integer
    Private gEmail As String
    Private gTipo As String

    Public Property ID As Integer
        Get
            Return gID
        End Get
        Set(ByVal value As Integer)
            gID = value
        End Set
    End Property

    Public Property Email As String
        Get
            Return gEmail
        End Get
        Set(ByVal value As String)
            gEmail = value
        End Set
    End Property

    Public Property Tipo As String
        Get
            Return gTipo
        End Get
        Set(ByVal value As String)
            gTipo = value
        End Set
    End Property

End Class

