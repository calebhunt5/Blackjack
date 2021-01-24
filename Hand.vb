Public Class Hand
    'only five cards can be held in a hand
    Const MAX_CARD_COUNT As Integer = 5

    'member variables for cards and number of cards
    Dim m_cards(5) As Card
    Dim m_cardCount As Integer = 0

    'read only max_card_count
    Public ReadOnly Property maxCardCount() As Integer
        Get
            Return MAX_CARD_COUNT
        End Get
    End Property

    'read card cound
    Public ReadOnly Property cardCount() As Integer
        Get
            Return m_cardCount
        End Get
    End Property

    'read cards in hand with index of card
    Public ReadOnly Property card(i As Integer) As Card
        Get
            Return m_cards(i)
        End Get
    End Property

    'read only score that is calculated between all cards in hand
    Public ReadOnly Property score() As Integer
        Get
            Dim handScore As Integer = 0
            Dim hasAce As Boolean

            'every card adds value
            For Each curCard In m_cards
                handScore = handScore + curCard.Score

                If curCard.Denomination = 1 Then
                    hasAce = True
                End If
            Next

            'adds value if nessecary for ace
            If handScore < 12 And hasAce Then
                handScore += 10
            End If

            Return handScore
        End Get
    End Property

    'gives a new card to the hand
    Sub Deal(newCard As Card)
        If m_cardCount < MAX_CARD_COUNT Then
            m_cardCount += 1
            m_cards(m_cardCount - 1) = newCard
        End If
    End Sub

    'empties hand
    Sub clear()
        Dim blankCard As New Card

        m_cardCount = 0

        For i As Integer = 0 To m_cards.GetUpperBound(0)
            m_cards(i) = blankCard
        Next
    End Sub
End Class
