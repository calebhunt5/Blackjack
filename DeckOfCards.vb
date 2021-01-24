Public Class DeckOfCards
    'constants for cards in a deck, card per suit, and the number of suits
    Const IDX_MAX_DECK As Integer = 51
    Const CARDS_PER_SUIT As Integer = 13
    Const MAX_SUITS As Integer = 3

    'creation of the deck, and the index of the last card that was delt
    Public deck(51) As Card
    Private m_dealt As Integer

    Private suits() As String = {"Hearts", "Diamonds", "Clubs", "Spades"}

    'creation of event to show when deck is shuffled
    Public Event Shuffling(ByVal shuffleIDX As Integer)

    'public property to get and set denomination of index
    Public Property Denomination(i As Integer) As Integer
        Get
            Return deck(i).Denomination
        End Get
        Set(value As Integer)
            deck(i).Denomination = value
        End Set
    End Property

    'public property to get and set suit of a specific index
    Public Property Suit(i As Integer) As String
        Get
            Return deck(i).Suit
        End Get
        Set(value As String)
            deck(i).Suit = value
        End Set
    End Property

    'constructor with no parameters
    Sub New()
        'int to keep track of where we are in the deck
        Dim curDeckIDX As Integer = 0

        'first loop starts at 0 and goes to 51
        'to keep track of what card we are at in the deck overall
        While curDeckIDX <= IDX_MAX_DECK

            'second loop starts at 0 and goes to 3
            'to fill the deck with each suit
            For i As Integer = 0 To MAX_SUITS

                'third loop starts at 0 and goes to 12
                'to fill the suits with individual cards
                For j As Integer = 0 To CARDS_PER_SUIT - 1
                    'create new card object 
                    'because trying to edit the first index's properites while they are null doesn't compile
                    Dim tempCard As New Card

                    tempCard.Denomination = j + 1
                    tempCard.Suit = suits(i)

                    'adds temporary card to current index in the deck and increments current index in the deck
                    deck(curDeckIDX) = tempCard
                    curDeckIDX += 1
                Next 'end of third loop
            Next 'end of second loop
        End While 'end of first loop
    End Sub

    'returns a card from the deck
    Function Deal() As Card
        'returns top card in deck
        If m_dealt < deck.GetUpperBound(0) Then
            m_dealt += 1
        Else
            m_dealt = 0
        End If

        Return deck(m_dealt)
    End Function

    'returns the entire deck if needed
    Function ReturnAllCards() As Card()
        Return deck
    End Function

    'swaps two cards' positions in the deck
    Sub Swap(firstCardIDX As Integer, secondCardIDX As Integer)
        'copy of first card
        Dim tempCard As New Card
        tempCard = deck(firstCardIDX)

        'swaps cards
        deck(firstCardIDX) = deck(secondCardIDX)
        deck(secondCardIDX) = tempCard
    End Sub

    'shuffles the deck 2000 times
    Sub Shuffle()
        'creation of randomNumber
        Dim RNG As New Random
        Dim randomNumber As Integer

        'loop to shuffle 2000 times
        For i As Integer = 1 To 2000
            'loop shuffles all 52 cards
            For j As Integer = 0 To IDX_MAX_DECK
                'picks random card at index between 1 and 52 and swaps current card with that index
                randomNumber = RNG.Next(0, IDX_MAX_DECK + 1)
                Swap(j, randomNumber)
            Next

            'triggers shuffling event that returns current number of shuffles
            RaiseEvent Shuffling(i)
        Next
    End Sub
End Class