Public Class Project
    Dim _Name As String
    Dim _Questions As New List(Of Question)
    Dim _ErrorPunish As Boolean
    Dim _Author As String
    Dim _Contributors() As String
    Dim _PointsRemovedOnError As Single
    Dim _Helps As Integer
    Dim _Simulation As Boolean
    Dim _Password As String

    Public Property Password() As String
        Get
            Return _Password
        End Get
        Set(value As String)
            _Password = value
        End Set
    End Property
    Public Property Simulation() As Boolean
        Get
            Return _Simulation

        End Get
        Set(value As Boolean)
            _Simulation = value
        End Set
    End Property
    Public Property Helps() As Integer
        Get
            Return _Helps
        End Get
        Set(value As Integer)
            _Helps = value
        End Set
    End Property

    Public Property PointsRemovedOnError() As Single
        Get
            Return _PointsRemovedOnError
        End Get
        Set(value As Single)
            _PointsRemovedOnError = value
        End Set
    End Property

    Public Property ErrorPunishment() As Boolean
        Get
            Return _ErrorPunish
        End Get
        Set(value As Boolean)
            _ErrorPunish = value
        End Set
    End Property

    Public Property Author() As String
        Get
            Return _Author
        End Get
        Set(value As String)
            _Author = value
        End Set
    End Property

    Public Property Contributors() As String()
        Get
            Return _Contributors
        End Get
        Set(value As String())
            _Contributors = value
        End Set
    End Property

    Public Property Name() As String
        Get
            Return _Name
        End Get
        Set(value As String)
            _Name = value
        End Set
    End Property

    Public Property Questions() As List(Of Question)
        Get
            Return _Questions
        End Get
        Set(value As List(Of Question))
            _Questions = value
        End Set
    End Property

    Public ReadOnly Property Count() As Integer
        Get
            Return Questions.Count
        End Get
    End Property
End Class
