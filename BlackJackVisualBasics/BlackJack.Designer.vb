<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BlackJack
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BlackJack))
        Me.DealCards = New System.Windows.Forms.Button()
        Me.Hitbtn = New System.Windows.Forms.Button()
        Me.Standbtn = New System.Windows.Forms.Button()
        Me.Resetbtn = New System.Windows.Forms.Button()
        Me.dealerscorelabel = New System.Windows.Forms.Label()
        Me.playerscorelabel = New System.Windows.Forms.Label()
        Me.Doubledownbtn = New System.Windows.Forms.Button()
        Me.wagerlabel = New System.Windows.Forms.Label()
        Me.moneylabel = New System.Windows.Forms.Label()
        Me.GameScreenPanel = New System.Windows.Forms.Panel()
        Me.WinnerNotificationLabel = New System.Windows.Forms.Label()
        Me.CoinsImage = New System.Windows.Forms.PictureBox()
        Me.BlackJackLogo = New System.Windows.Forms.PictureBox()
        Me.Playercard3 = New System.Windows.Forms.PictureBox()
        Me.DealerCard1 = New System.Windows.Forms.PictureBox()
        Me.DealerCard2 = New System.Windows.Forms.PictureBox()
        Me.DealerCard3 = New System.Windows.Forms.PictureBox()
        Me.PlayerCard2 = New System.Windows.Forms.PictureBox()
        Me.PlayerCard1 = New System.Windows.Forms.PictureBox()
        Me.MainMenuPanel = New System.Windows.Forms.Panel()
        Me.PressStartLabel = New System.Windows.Forms.Label()
        Me.GameLogo = New System.Windows.Forms.PictureBox()
        Me.Startbtn = New System.Windows.Forms.Button()
        Me.GameScreenPanel.SuspendLayout()
        CType(Me.CoinsImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BlackJackLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Playercard3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DealerCard1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DealerCard2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DealerCard3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlayerCard2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlayerCard1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainMenuPanel.SuspendLayout()
        CType(Me.GameLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DealCards
        '
        Me.DealCards.BackColor = System.Drawing.SystemColors.HighlightText
        Me.DealCards.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DealCards.Location = New System.Drawing.Point(11, 406)
        Me.DealCards.Name = "DealCards"
        Me.DealCards.Size = New System.Drawing.Size(125, 35)
        Me.DealCards.TabIndex = 0
        Me.DealCards.Text = "Deal Cards "
        Me.DealCards.UseVisualStyleBackColor = False
        '
        'Hitbtn
        '
        Me.Hitbtn.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Hitbtn.Enabled = False
        Me.Hitbtn.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hitbtn.Location = New System.Drawing.Point(321, 440)
        Me.Hitbtn.Name = "Hitbtn"
        Me.Hitbtn.Size = New System.Drawing.Size(125, 35)
        Me.Hitbtn.TabIndex = 1
        Me.Hitbtn.Text = "Hit"
        Me.Hitbtn.UseVisualStyleBackColor = False
        '
        'Standbtn
        '
        Me.Standbtn.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Standbtn.Enabled = False
        Me.Standbtn.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Standbtn.Location = New System.Drawing.Point(452, 440)
        Me.Standbtn.Name = "Standbtn"
        Me.Standbtn.Size = New System.Drawing.Size(125, 35)
        Me.Standbtn.TabIndex = 2
        Me.Standbtn.Text = "Stand"
        Me.Standbtn.UseVisualStyleBackColor = False
        '
        'Resetbtn
        '
        Me.Resetbtn.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Resetbtn.Enabled = False
        Me.Resetbtn.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Resetbtn.Location = New System.Drawing.Point(891, 406)
        Me.Resetbtn.Name = "Resetbtn"
        Me.Resetbtn.Size = New System.Drawing.Size(125, 35)
        Me.Resetbtn.TabIndex = 3
        Me.Resetbtn.Text = "Reset "
        Me.Resetbtn.UseVisualStyleBackColor = False
        '
        'dealerscorelabel
        '
        Me.dealerscorelabel.AutoSize = True
        Me.dealerscorelabel.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dealerscorelabel.ForeColor = System.Drawing.Color.Transparent
        Me.dealerscorelabel.Location = New System.Drawing.Point(578, 144)
        Me.dealerscorelabel.Name = "dealerscorelabel"
        Me.dealerscorelabel.Size = New System.Drawing.Size(147, 29)
        Me.dealerscorelabel.TabIndex = 4
        Me.dealerscorelabel.Text = "Dealer Hand"
        Me.dealerscorelabel.Visible = False
        '
        'playerscorelabel
        '
        Me.playerscorelabel.AutoSize = True
        Me.playerscorelabel.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.playerscorelabel.ForeColor = System.Drawing.Color.Transparent
        Me.playerscorelabel.Location = New System.Drawing.Point(23, 144)
        Me.playerscorelabel.Name = "playerscorelabel"
        Me.playerscorelabel.Size = New System.Drawing.Size(140, 29)
        Me.playerscorelabel.TabIndex = 6
        Me.playerscorelabel.Text = "PlayerHand"
        '
        'Doubledownbtn
        '
        Me.Doubledownbtn.BackColor = System.Drawing.SystemColors.HighlightText
        Me.Doubledownbtn.Enabled = False
        Me.Doubledownbtn.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Doubledownbtn.Location = New System.Drawing.Point(583, 440)
        Me.Doubledownbtn.Name = "Doubledownbtn"
        Me.Doubledownbtn.Size = New System.Drawing.Size(125, 35)
        Me.Doubledownbtn.TabIndex = 9
        Me.Doubledownbtn.Text = "Double Down"
        Me.Doubledownbtn.UseVisualStyleBackColor = False
        '
        'wagerlabel
        '
        Me.wagerlabel.AutoSize = True
        Me.wagerlabel.Font = New System.Drawing.Font("Times New Roman", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wagerlabel.ForeColor = System.Drawing.Color.White
        Me.wagerlabel.Location = New System.Drawing.Point(856, 130)
        Me.wagerlabel.Name = "wagerlabel"
        Me.wagerlabel.Size = New System.Drawing.Size(152, 37)
        Me.wagerlabel.TabIndex = 10
        Me.wagerlabel.Text = "Wager: 50"
        '
        'moneylabel
        '
        Me.moneylabel.AutoSize = True
        Me.moneylabel.Font = New System.Drawing.Font("Times New Roman", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.moneylabel.ForeColor = System.Drawing.Color.White
        Me.moneylabel.Location = New System.Drawing.Point(727, 34)
        Me.moneylabel.Name = "moneylabel"
        Me.moneylabel.Size = New System.Drawing.Size(128, 37)
        Me.moneylabel.TabIndex = 11
        Me.moneylabel.Text = "Pot: 200"
        '
        'GameScreenPanel
        '
        Me.GameScreenPanel.BackColor = System.Drawing.Color.DarkGreen
        Me.GameScreenPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GameScreenPanel.Controls.Add(Me.WinnerNotificationLabel)
        Me.GameScreenPanel.Controls.Add(Me.CoinsImage)
        Me.GameScreenPanel.Controls.Add(Me.BlackJackLogo)
        Me.GameScreenPanel.Controls.Add(Me.Playercard3)
        Me.GameScreenPanel.Controls.Add(Me.DealerCard1)
        Me.GameScreenPanel.Controls.Add(Me.DealerCard2)
        Me.GameScreenPanel.Controls.Add(Me.DealerCard3)
        Me.GameScreenPanel.Controls.Add(Me.PlayerCard2)
        Me.GameScreenPanel.Controls.Add(Me.PlayerCard1)
        Me.GameScreenPanel.Controls.Add(Me.moneylabel)
        Me.GameScreenPanel.Controls.Add(Me.playerscorelabel)
        Me.GameScreenPanel.Controls.Add(Me.wagerlabel)
        Me.GameScreenPanel.Controls.Add(Me.dealerscorelabel)
        Me.GameScreenPanel.Controls.Add(Me.Standbtn)
        Me.GameScreenPanel.Controls.Add(Me.Doubledownbtn)
        Me.GameScreenPanel.Controls.Add(Me.Hitbtn)
        Me.GameScreenPanel.Controls.Add(Me.DealCards)
        Me.GameScreenPanel.Controls.Add(Me.Resetbtn)
        Me.GameScreenPanel.Location = New System.Drawing.Point(0, 0)
        Me.GameScreenPanel.Name = "GameScreenPanel"
        Me.GameScreenPanel.Size = New System.Drawing.Size(1030, 496)
        Me.GameScreenPanel.TabIndex = 12
        '
        'WinnerNotificationLabel
        '
        Me.WinnerNotificationLabel.AutoSize = True
        Me.WinnerNotificationLabel.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WinnerNotificationLabel.Location = New System.Drawing.Point(289, 399)
        Me.WinnerNotificationLabel.Name = "WinnerNotificationLabel"
        Me.WinnerNotificationLabel.Size = New System.Drawing.Size(0, 29)
        Me.WinnerNotificationLabel.TabIndex = 20
        '
        'CoinsImage
        '
        Me.CoinsImage.Image = CType(resources.GetObject("CoinsImage.Image"), System.Drawing.Image)
        Me.CoinsImage.Location = New System.Drawing.Point(861, 3)
        Me.CoinsImage.Name = "CoinsImage"
        Me.CoinsImage.Size = New System.Drawing.Size(155, 124)
        Me.CoinsImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.CoinsImage.TabIndex = 19
        Me.CoinsImage.TabStop = False
        '
        'BlackJackLogo
        '
        Me.BlackJackLogo.Image = CType(resources.GetObject("BlackJackLogo.Image"), System.Drawing.Image)
        Me.BlackJackLogo.Location = New System.Drawing.Point(321, -1)
        Me.BlackJackLogo.Name = "BlackJackLogo"
        Me.BlackJackLogo.Size = New System.Drawing.Size(322, 142)
        Me.BlackJackLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BlackJackLogo.TabIndex = 18
        Me.BlackJackLogo.TabStop = False
        '
        'Playercard3
        '
        Me.Playercard3.InitialImage = CType(resources.GetObject("Playercard3.InitialImage"), System.Drawing.Image)
        Me.Playercard3.Location = New System.Drawing.Point(296, 191)
        Me.Playercard3.Name = "Playercard3"
        Me.Playercard3.Size = New System.Drawing.Size(107, 199)
        Me.Playercard3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Playercard3.TabIndex = 17
        Me.Playercard3.TabStop = False
        '
        'DealerCard1
        '
        Me.DealerCard1.InitialImage = CType(resources.GetObject("DealerCard1.InitialImage"), System.Drawing.Image)
        Me.DealerCard1.Location = New System.Drawing.Point(618, 191)
        Me.DealerCard1.Name = "DealerCard1"
        Me.DealerCard1.Size = New System.Drawing.Size(107, 199)
        Me.DealerCard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.DealerCard1.TabIndex = 16
        Me.DealerCard1.TabStop = False
        Me.DealerCard1.Visible = False
        '
        'DealerCard2
        '
        Me.DealerCard2.InitialImage = CType(resources.GetObject("DealerCard2.InitialImage"), System.Drawing.Image)
        Me.DealerCard2.Location = New System.Drawing.Point(762, 191)
        Me.DealerCard2.Name = "DealerCard2"
        Me.DealerCard2.Size = New System.Drawing.Size(107, 199)
        Me.DealerCard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.DealerCard2.TabIndex = 15
        Me.DealerCard2.TabStop = False
        Me.DealerCard2.Visible = False
        '
        'DealerCard3
        '
        Me.DealerCard3.InitialImage = CType(resources.GetObject("DealerCard3.InitialImage"), System.Drawing.Image)
        Me.DealerCard3.Location = New System.Drawing.Point(891, 191)
        Me.DealerCard3.Name = "DealerCard3"
        Me.DealerCard3.Size = New System.Drawing.Size(107, 199)
        Me.DealerCard3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.DealerCard3.TabIndex = 14
        Me.DealerCard3.TabStop = False
        Me.DealerCard3.Visible = False
        '
        'PlayerCard2
        '
        Me.PlayerCard2.InitialImage = CType(resources.GetObject("PlayerCard2.InitialImage"), System.Drawing.Image)
        Me.PlayerCard2.Location = New System.Drawing.Point(162, 191)
        Me.PlayerCard2.Name = "PlayerCard2"
        Me.PlayerCard2.Size = New System.Drawing.Size(107, 199)
        Me.PlayerCard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PlayerCard2.TabIndex = 13
        Me.PlayerCard2.TabStop = False
        '
        'PlayerCard1
        '
        Me.PlayerCard1.InitialImage = CType(resources.GetObject("PlayerCard1.InitialImage"), System.Drawing.Image)
        Me.PlayerCard1.Location = New System.Drawing.Point(28, 191)
        Me.PlayerCard1.Name = "PlayerCard1"
        Me.PlayerCard1.Size = New System.Drawing.Size(107, 199)
        Me.PlayerCard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PlayerCard1.TabIndex = 12
        Me.PlayerCard1.TabStop = False
        '
        'MainMenuPanel
        '
        Me.MainMenuPanel.BackColor = System.Drawing.Color.DarkGreen
        Me.MainMenuPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MainMenuPanel.Controls.Add(Me.PressStartLabel)
        Me.MainMenuPanel.Controls.Add(Me.GameLogo)
        Me.MainMenuPanel.Controls.Add(Me.Startbtn)
        Me.MainMenuPanel.Location = New System.Drawing.Point(0, 0)
        Me.MainMenuPanel.Name = "MainMenuPanel"
        Me.MainMenuPanel.Size = New System.Drawing.Size(1030, 492)
        Me.MainMenuPanel.TabIndex = 12
        '
        'PressStartLabel
        '
        Me.PressStartLabel.AutoSize = True
        Me.PressStartLabel.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PressStartLabel.Location = New System.Drawing.Point(429, 440)
        Me.PressStartLabel.Name = "PressStartLabel"
        Me.PressStartLabel.Size = New System.Drawing.Size(210, 26)
        Me.PressStartLabel.TabIndex = 2
        Me.PressStartLabel.Text = "Press Start to Play!"
        '
        'GameLogo
        '
        Me.GameLogo.Image = CType(resources.GetObject("GameLogo.Image"), System.Drawing.Image)
        Me.GameLogo.Location = New System.Drawing.Point(259, 23)
        Me.GameLogo.Name = "GameLogo"
        Me.GameLogo.Size = New System.Drawing.Size(497, 300)
        Me.GameLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GameLogo.TabIndex = 1
        Me.GameLogo.TabStop = False
        '
        'Startbtn
        '
        Me.Startbtn.ImageKey = "(none)"
        Me.Startbtn.Location = New System.Drawing.Point(470, 376)
        Me.Startbtn.Name = "Startbtn"
        Me.Startbtn.Size = New System.Drawing.Size(125, 40)
        Me.Startbtn.TabIndex = 0
        Me.Startbtn.Text = "Start"
        Me.Startbtn.UseVisualStyleBackColor = True
        '
        'BlackJack
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1029, 488)
        Me.Controls.Add(Me.GameScreenPanel)
        Me.Controls.Add(Me.MainMenuPanel)
        Me.Name = "BlackJack"
        Me.Text = "BlackJack"
        Me.GameScreenPanel.ResumeLayout(False)
        Me.GameScreenPanel.PerformLayout()
        CType(Me.CoinsImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BlackJackLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Playercard3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DealerCard1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DealerCard2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DealerCard3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlayerCard2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlayerCard1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainMenuPanel.ResumeLayout(False)
        Me.MainMenuPanel.PerformLayout()
        CType(Me.GameLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DealCards As Button
    Friend WithEvents Hitbtn As Button
    Friend WithEvents Standbtn As Button
    Friend WithEvents Resetbtn As Button
    Friend WithEvents dealerscorelabel As Label
    Friend WithEvents playerscorelabel As Label
    Friend WithEvents Doubledownbtn As Button
    Friend WithEvents wagerlabel As Label
    Friend WithEvents moneylabel As Label
    Friend WithEvents GameScreenPanel As Panel
    Friend WithEvents MainMenuPanel As Panel
    Friend WithEvents Startbtn As Button
    Friend WithEvents DealerCard2 As PictureBox
    Friend WithEvents DealerCard3 As PictureBox
    Friend WithEvents PlayerCard2 As PictureBox
    Friend WithEvents PlayerCard1 As PictureBox
    Friend WithEvents Playercard3 As PictureBox
    Friend WithEvents DealerCard1 As PictureBox
    Friend WithEvents CoinsImage As PictureBox
    Friend WithEvents BlackJackLogo As PictureBox
    Friend WithEvents GameLogo As PictureBox
    Friend WithEvents WinnerNotificationLabel As Label
    Friend WithEvents PressStartLabel As Label
End Class
