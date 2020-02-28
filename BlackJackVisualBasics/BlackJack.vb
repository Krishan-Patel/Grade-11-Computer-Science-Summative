Public Class BlackJack
    Dim playerscore As Integer = 0
    Dim dealerscore As Integer = 0
    Dim moneypot As Integer = 200
    Dim wager As Integer = 50
    Dim cardcount As Integer = 0
    Public Declare Sub Sleep Lib "kernel32" Alias "Sleep" (ByVal dwMilliseconds As Long)

    ' Here I create an array of images stored in the proejct resource folder, the images in the array are that of the numeric cards and the ace card.
    'I chose to not use the face cards and to only use one suit as the face cards have the same value as the 10 card and using all the suits would have made the program more complicated.
    Dim cardimages() As Image = {My.Resources._2C, My.Resources._3C, My.Resources._4C, My.Resources._5C, My.Resources._6C, My.Resources._7C, My.Resources._8C, My.Resources._9C, My.Resources._10C, My.Resources.AC}


    'This is an event handler for when the project is loaded, the program contains two "screens", to achieve this I chose to use two panels instead of creating an addition form
    ' You can view the different panels using the document outline window and rearranging which one is on top (keybind for document outline is ctrl + alt + t)
    ' What the event handler does is make sure that the startup screen is always the first screen that shows regardless of how the screens are arranged in the document outline.
    Private Sub GameScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MainMenuPanel.Visible = True
        GameScreenPanel.Visible = False
    End Sub


    ' This a procedure that uses the native rnd function from Vb and is able to generate a number from 2 to 11, which is the range for the card values in the game 2 being the 2 card and 11 being the ace
    Public Function RandomNumber() As Integer

        Dim rRnd As New Random

        Return rRnd.Next(2, 12) 'this range given (2,12) is intentional as the way the number is determiend using (2,11) doesn't include 11 as a output
    End Function


    'This is a procedure that is called when the game has ended, and a winner has been determined. The purpose of the procedure is to disable the buttons so that the 
    'player can't continue pressing the buttons after an outcome has already been determined. The procedure also has a parameter called winner this is a boolean or true false
    'condition and determines whether the player won or not and update their pot accordingly. It also makes the dealers cards visible so that the player can see how they
    ' won or lost.
    Public Sub gameover(winner As Boolean)
        If winner = True Then
            moneypot = moneypot + wager
            moneylabel.Text = "Pot: " & moneypot
        ElseIf winner = False Then
            moneypot = moneypot - wager
            moneylabel.Text = "Pot: " & moneypot
        Else
            moneylabel.Text = "Pot: " & moneypot
        End If
        Hitbtn.Enabled = False
        Standbtn.Enabled = False
        DealerCard1.Visible = True
        DealerCard2.Visible = True
        DealerCard3.Visible = True
        dealerscorelabel.Visible = True
    End Sub


    'This is procedure that checks if either the dealer or player has "busted", the term busted means that the sum of their card values exceeds 21, this procedure
    ' is called on every turn except the first one where the highest possible score is 21, the procedures checks to see if on side has gotten blackjack (21) or busted 
    'as those are both conditions for the game being over. If the condition are meant the procedure gameoever is called with true for player, win false for player loss
    ' and vbnull for a draw
    Public Sub CheckBust()
        If playerscore > 21 And dealerscore > 21 Then
            WinnerNotificationLabel.Text = "Draw!"
            gameover(vbNull)
        ElseIf playerscore = 21 And dealerscore = 21 Then
            WinnerNotificationLabel.Text = "Draw!"
            gameover(vbNull)
        ElseIf playerscore > 21 Then
            WinnerNotificationLabel.Text = "You have busted, Better Luck Next Time!"
            gameover(False)
        ElseIf dealerscore > 21 Then
            WinnerNotificationLabel.Text = "Dealer busted, You have won!"
            gameover(True)
        ElseIf playerscore = 21 Then
            WinnerNotificationLabel.Text = "BlackJack! You have won"
            gameover(True)
        ElseIf dealerscore = 21 Then
            WinnerNotificationLabel.Text = "Dealer BlackJack! You have lost"
            gameover(False)
        End If

    End Sub


    'This is a procedure that Is called every time a card is draw for the player and the dealer, the procedure takes the value drawn from the random number generator
    ' and displays a card from the cardimage list with the corresponding value. it uses the global variable card counters to know which picturebox the image should be
    'place in and player as boolean to known whether the card is for the player or the dealer.
    Public Sub displaycard(player As Boolean)
        If cardcount = 0 Then
            If player = True Then
                PlayerCard1.Image = cardimages(RandomNumber() - 2)
            Else
                DealerCard1.Image = cardimages(RandomNumber() - 2) ' when indexing for the card in the list the idex is = the card value - 2, this is because the idex                                               
            End If                                                 ' for the array has a range of 0-10 while the number values has a range from 2-12 so the 2 card would
        ElseIf cardcount = 1 Then                                  ' have an index of 0 , 3 would have index of 1 etc.
            If player = True Then
                PlayerCard2.Image = cardimages(RandomNumber() - 2)
            Else
                DealerCard2.Image = cardimages(RandomNumber() - 2)
            End If
        ElseIf cardcount = 2 Then
            If player = True Then
                Playercard3.Image = cardimages(RandomNumber() - 2)
            Else
                DealerCard3.Image = cardimages(RandomNumber() - 2)
            End If
        End If
    End Sub


    ' This procedure is simmilar to checkbust as its purpose is to determine a winner, the difference between the two procedures is that checkbust is excecuted for every 
    'turn after the first one, this procedure is only excecuted when the player stands therefore the game has ended and a winner needs to be determined or when the 
    'maximum number of cards has been draw (3)
    Public Sub checkwinner()
        If dealerscore <= 21 And playerscore <= 21 Then
            If playerscore > dealerscore Then
                WinnerNotificationLabel.Text = "You have Won!"
                gameover(True)
            ElseIf playerscore = dealerscore Then
                WinnerNotificationLabel.Text = "Draw"
                gameover(vbNull)
            Else
                WinnerNotificationLabel.Text = "You Have Lost!"
                gameover(False)
            End If
        Else
            CheckBust() ' the outisde if statment is only there because of the way the procedure is called by one of the event handlers and ensures that the outcome
        End If          ' determined is correct as for the > = < conditions to be checked both parties must have a score less than or = to 21
    End Sub


    'This is an event handler for the first round or action in the game where a card is dealt to the dealer and the player the dealers cards remain invisible until the
    'game is over. The sleep function is required as the numbers are generated using the time, therefore without the sleep acting as a pause the numbers would be the same
    'for the player and the dealer.
    Private Sub DealCards_Click(sender As Object, e As EventArgs) Handles DealCards.Click
        playerscore = RandomNumber()
        displaycard(True)
        Sleep(125)
        dealerscore = RandomNumber()
        displaycard(False)
        playerscorelabel.Text = "Player Hand: " & playerscore
        dealerscorelabel.Text = "Dealer Hand: " & dealerscore
        Hitbtn.Enabled = True
        Standbtn.Enabled = True
        Resetbtn.Enabled = True
        Doubledownbtn.Enabled = True
        DealCards.Enabled = False
        cardcount = cardcount + 1
    End Sub


    'This procedure deals an addition card to the player and dealer it also updates the dealer and player scores 
    Private Sub Hitbtn_Click(sender As Object, e As EventArgs) Handles Hitbtn.Click
        playerscore = RandomNumber() + playerscore
        displaycard(True)
        Sleep(125)
        dealerscore = RandomNumber() + dealerscore
        displaycard(False)
        playerscorelabel.Text = "Player Hand: " & playerscore
        dealerscorelabel.Text = "Dealer Hand: " & dealerscore
        CheckBust()
        cardcount = cardcount + 1
        If cardcount = 3 Then
            Hitbtn.Enabled = False
            checkwinner()
        End If
        Doubledownbtn.Enabled = False
    End Sub


    'This event handler is for when the player decides to stand and an ouutcome needs to be determined 
    Private Sub Standbtn_Click(sender As Object, e As EventArgs) Handles Standbtn.Click
        checkwinner()
    End Sub


    'This event handler resets the game completely, and allows for the player to play another round, The difference between this and gameover is the gameover procedure
    'is for when the game has been decided and a winner determined and gameover disables the player from continuing to play as the game is over. Reset will reset the game
    'and essentially start a new one.
    Private Sub Resetbtn_Click(sender As Object, e As EventArgs) Handles Resetbtn.Click
        DealCards.Enabled = True
        playerscore = 0
        dealerscore = 0
        playerscorelabel.Text = "Player Hand:"
        dealerscorelabel.Text = "Dealer Hand"
        dealerscorelabel.Visible = False
        WinnerNotificationLabel.Text = ""
        wager = 50
        wagerlabel.Text = "Wager: " & wager
        DealCards.Enabled = True
        Hitbtn.Enabled = False
        Standbtn.Enabled = False
        cardcount = 0
        PlayerCard1.Image = My.Resources.flippedcard
        PlayerCard2.Image = My.Resources.flippedcard
        Playercard3.Image = My.Resources.flippedcard
        DealerCard1.Image = Nothing
        DealerCard1.Visible = False
        DealerCard2.Image = Nothing
        DealerCard2.Visible = False
        DealerCard3.Image = Nothing
        DealerCard3.Visible = False
    End Sub


    'This event handler doubles the players wager for that specific round and can only be done after the first card is dealt and becomes disabled once addition cards
    ' are delt.
    Private Sub Doubledownbtn_Click(sender As Object, e As EventArgs) Handles Doubledownbtn.Click
        wager = wager * 2
        wagerlabel.Text = "Wager: " & wager
        Doubledownbtn.Enabled = False
    End Sub


    'This procedure is for the startup panel, where the is a start button that brings the user into the game screen
    Private Sub StartBtn_Click(sender As Object, e As EventArgs) Handles Startbtn.Click
        GameScreenPanel.Visible = True
        MainMenuPanel.Visible = False
        PlayerCard1.Image = My.Resources.flippedcard
        PlayerCard2.Image = My.Resources.flippedcard
        Playercard3.Image = My.Resources.flippedcard
    End Sub

End Class
