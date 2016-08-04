Public Class Question
    Dim _Text As String
    Dim _A As String
    Dim _B As String
    Dim _C As String
    Dim _D As String
    Dim _Correct As Byte
    Dim _Answer As SByte = -1
    Dim _Help As String
    Dim _Time As Byte
    Dim _Category As QCategory
    Dim _ID As Integer
    Dim _HelpShown As Boolean = False


    Public Enum QCategory As Byte
        Algebra
        Altro
        Aritmetica
        Arte
        Attualità
        Chimica
        Cultura
        Curiosità
        Elettronica
        Filosofia
        Fisica
        Geografia
        Grammatica
        Informatica
        Letteratura
        Meccanica
        Passatempo
        Religione
        Sanità
        Scienza
        Sport
        Storia
        Svago
    End Enum

    Public Property HelpShown() As Boolean
        Get
            Return _HelpShown
        End Get
        Set(value As Boolean)
            _HelpShown = value
        End Set
    End Property

    Public Property UserAnswer() As SByte
        Get
            Return _Answer
        End Get
        Set(value As SByte)
            _Answer = value
        End Set
    End Property

    Public Property Text() As String
        Get
            Return _Text
        End Get
        Set(value As String)
            _Text = value
        End Set
    End Property

    Public Property A() As String
        Get
            Return _A
        End Get
        Set(value As String)
            _A = value
        End Set
    End Property

    Public Property B() As String
        Get
            Return _B
        End Get
        Set(value As String)
            _B = value
        End Set
    End Property

    Public Property C() As String
        Get
            Return _C
        End Get
        Set(value As String)
            _C = value
        End Set
    End Property

    Public Property D() As String
        Get
            Return _D
        End Get
        Set(value As String)
            _D = value
        End Set
    End Property

    Public Property Correct() As Byte
        Get
            Return _Correct
        End Get
        Set(value As Byte)
            _Correct = value
        End Set
    End Property

    Public Property Help() As String
        Get
            Return _Help
        End Get
        Set(value As String)
            _Help = value
        End Set
    End Property

    Public Property Time() As Byte
        Get
            Return _Time
        End Get
        Set(value As Byte)
            _Time = value
        End Set
    End Property

    Public Property Category() As QCategory
        Get
            Return _Category
        End Get
        Set(value As QCategory)
            _Category = value
        End Set
    End Property

    Public Property ID() As Integer
        Get
            Return _ID
        End Get
        Set(value As Integer)
            _ID = value
        End Set
    End Property
End Class

