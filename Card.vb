Public Class Card
    'member variables for suit and number of card face cards are refered to by number
    Private m_denom As Integer
    Private m_suit As String

    'property of m_denom member variable created read and write
    Public Property Denomination() As Integer
        Get
            Return m_denom
        End Get
        Set(value As Integer)
            m_denom = value
        End Set
    End Property

    'm_suit read and write property
    Public Property Suit() As String
        Get
            Return m_suit
        End Get
        Set(value As String)
            m_suit = value
        End Set
    End Property

    'read only score property for card based on face value or number of denomination
    Public ReadOnly Property Score() As Integer
        Get
            If m_denom >= 10 Then
                Return 10
            Else
                Return m_denom
            End If
        End Get
    End Property

    'creates string to describe card in english
    Function identifyCard() As String
        If m_denom > 10 Or m_denom = 1 Then
            Dim face As String = ""

            Select Case m_denom
                Case 1
                    face = "Ace"
                Case 11
                    face = "Jack"
                Case 12
                    face = "Queen"
                Case 13
                    face = "King"
            End Select

            Return face & " of " & m_suit
        Else
            Return m_denom & " of " & m_suit
        End If
    End Function
End Class
