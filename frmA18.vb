Public Class frmA18
    'only five cards can be held in a hand
    Const MAX_CARD_COUNT As Integer = 5

    'variables and objects for player and dealer
    Dim gameNum As Integer = 1
    Dim player As Hand
    Dim dealer As Hand
    Dim dealerSecondCard As Card

    'uses deck's events just shuffle
    Dim WithEvents deck As DeckOfCards

    'initialize player, dealer, and deck 
    'deals first two cards to player and dealer
    Private Sub frmA18_Load(sender As Object, e As EventArgs) Handles Me.Load
        player = New Hand()
        dealer = New Hand()
        deck = New DeckOfCards()

        NewHand()

        txtStatus.Text = ""
    End Sub

    'starts next game
    Private Sub btnNewHand_Click(sender As Object, e As EventArgs) Handles btnNewHand.Click
        If dealer.cardCount <> 1 Then
            NewHand()
        End If
    End Sub

    'dealer keeps getting cards while player stays where they are
    Private Sub btnHold_Click(sender As Object, e As EventArgs) Handles btnHold.Click
        If player.score <= 21 And dealer.cardCount = 2 Then
            Hold()
        End If
    End Sub

    'player gets cards and dealer gets cards until game ends
    Private Sub btnHit_Click(sender As Object, e As EventArgs) Handles btnHit.Click
        If player.cardCount < MAX_CARD_COUNT And player.score < 21 And dealer.cardCount = 2 Then
            DealPlayer()
        End If

        If player.cardCount < 5 Or player.score >= 21 Then
            Hold()
        End If
    End Sub

    'deals cards to dealer until his score is above 17 and the player holds
    Sub Hold()
        'reveals card in list box  and text box that was displayed as "?"
        lstDealer.Items(1) = dealerSecondCard.identifyCard
        txtDealer.Text = CStr(dealer.score)

        'dealer gets cards until score is over 17, number of cards is 5, or player busts
        Do While player.score <= 21 And dealer.score < 17 And dealer.cardCount < MAX_CARD_COUNT
            DealDealer()
        Loop

        'output results of game to list box and txtStatus
        txtStatus.Text = DetermineResult()
        lstHistory.Items.Add("Game #" & gameNum & " - " & DetermineResult())
        gameNum += 1
    End Sub

    'finds who one hand with if statements and returns string of results
    Function DetermineResult() As String
        Dim result As String = ""

        'first checks if either busted
        If player.score > 21 Then
            result = "You Busted - Dealer Wins"
        ElseIf dealer.score > 21 Then
            result = "Dealer Busted - You Win"
        Else
            'sees if max cards was reached by both or either player
            If player.cardCount = MAX_CARD_COUNT And dealer.cardCount = MAX_CARD_COUNT Then
                result = "Max Cards - Push"
            ElseIf player.cardCount = MAX_CARD_COUNT Then
                result = "Max Cards - You Win"
            ElseIf dealer.cardCount = MAX_CARD_COUNT Then
                result = "Max Cards - Dealer Wins"
            Else
                'finds winner based on score
                If player.score > dealer.score Then
                    result = "You Win"
                ElseIf dealer.score > player.score Then
                    result = "Dealer Win"
                Else
                    result = "Same Score - Push"
                End If
            End If
        End If

        'returns who won and how
        Return result
    End Function

    'starts next game
    Sub NewHand()
        'empties both hands
        player.clear()
        dealer.clear()

        'empties both displays
        lstPlayer.Items.Clear()
        lstDealer.Items.Clear()

        'empties both score txt boxes
        txtPlayer.Text = ""
        txtDealer.Text = ""

        'empties status txt box
        txtStatus.Text = ""

        'shuffles the deck 
        deck.Shuffle()

        'deals first two cards to each person and doesn't display dealer's second card
        DealPlayer()
        DealDealer()
        DealPlayer()
        DealDealer()
    End Sub

    'gives player more cards and displays that
    Sub DealPlayer()
        Dim newCard As Card
        newCard = deck.Deal

        player.Deal(newCard)

        lstPlayer.Items.Add(newCard.identifyCard)
        txtPlayer.Text = CStr(player.score)
    End Sub

    'gives dealer more cards and displays if not the second card
    Sub DealDealer()
        Dim newCard As Card
        newCard = deck.Deal

        dealer.Deal(newCard)

        'if new hand then hide one of the dealer's card
        If lstDealer.Items.Count = 1 Then
            dealerSecondCard = newCard

            lstDealer.Items.Add("?")
            txtDealer.Text = "?"
        Else
            'display card is not second card
            lstDealer.Items.Add(newCard.identifyCard)
            txtDealer.Text = CStr(dealer.score)
        End If
    End Sub

    'displays when deck is shuffling
    Private Sub deck_Shuffling(shuffleIDX As Integer) Handles deck.Shuffling
        txtStatus.Text = "Shuffling pass: " & shuffleIDX & " of 2000"
    End Sub
End Class
