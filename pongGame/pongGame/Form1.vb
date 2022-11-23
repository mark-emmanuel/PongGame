''' <summary>
''' Author: Mark Emmanuel A00388114
''' Author: purpleshirtednerd - Followed youtube tutorial as base.
''' 
''' the user can play using the Q and A keys.
''' the ball should speed up after each hit to make it 
''' more challenging. 
''' </summary>
Public Class Form1

    Dim BallTopSpeed, BallLeftSpeed, RPaddleSpeed, LPaddleSpeed As Decimal

    ''' <summary>
    ''' This allows the user to control the move the paddle 
    ''' using the up and down arrow keys for the right paddle.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Randomize()
        Dim X As Decimal
        '''RIGHT PADDLE MOVEMENT
        If e.KeyCode = Keys.Q Then   ' Keypress for the right paddle to move up
            If RightPaddle.Top > 2 Then  ' Check to see if paddle has room to move up
                RightPaddleTimer.Enabled = True
                RPaddleSpeed = -Math.Abs(RPaddleSpeed)  'Set paddle speed to be negative
            End If
        End If

        If e.KeyCode = Keys.A Then  ' Keypress for the right paddle to move down
            If RightPaddle.Top + RightPaddle.Height < Me.Height - 20 Then  ' Check to see if paddle has room to move down
                RightPaddleTimer.Enabled = True
                RPaddleSpeed = Math.Abs(RPaddleSpeed)  'Set paddle speed to be positive
            End If
        End If


        ''' GENERAL BALL MOVEMENT
        If e.KeyCode = Keys.Space Then ' Space is used to start the game
            StartGameLabel.Text = "" ' Start game text disappears when game starts
            If BallTimer.Enabled = False Then
                Randomize()
                X = Rnd()  ' x will be decimal from .001 to .999
                If X < 0.5 Then  '  Serve up or down... 50/50
                    BallTopSpeed = -1 * BallTopSpeed ' Dirction change for ball

                End If
                X = Rnd()  ' x will be decimal from .001 to .999
                If X < 0.5 Then  '  Serve right or left... 50/50
                    BallLeftSpeed = -1 * BallTopSpeed ' Direction change for ball
                End If
                BallTimer.Enabled = True
            End If
        End If
    End Sub

    ''' <summary>
    ''' This stops the right paddle from leaving the screen
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub RightPaddleTimer_Tick(sender As Object, e As EventArgs) Handles RightPaddleTimer.Tick
        RightPaddle.Top += RPaddleSpeed  'Move the paddle up or down

        If RPaddleSpeed < 0 Then 'if the paddle is going up
            If RightPaddle.Top < 2 Then  ' is the top of the paddle near the top of the form?
                RightPaddleTimer.Enabled = False  ' if so don't let it run off the top of the form
            Else
                RightPaddle.Top += RPaddleSpeed  'Move the paddle up
            End If
        End If

        If RPaddleSpeed > 0 Then 'if the paddle is going down
            If RightPaddle.Top + RightPaddle.Height > Me.Height - 40 Then  ' is the bottom of the paddle near the bottom of hte form?
                RightPaddleTimer.Enabled = False  ' if so don't let it run off the bottom of the form
            Else
                RightPaddle.Top += RPaddleSpeed  'Move the paddle down
            End If
        End If

    End Sub

    ''' <summary>
    ''' This stops the left paddle from leaving the screen
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub LeftPaddleTimer_Tick(sender As Object, e As EventArgs) Handles LeftPaddleTimer.Tick

        LeftPaddle.Top += LPaddleSpeed
        If LPaddleSpeed < 0 Then 'if the paddle is going up
            If LeftPaddle.Top < 2 Then  ' is the top of the paddle near the top of the form?
                LeftPaddleTimer.Enabled = False  ' if so don't let it run off the top of the form
            Else
                LeftPaddle.Top += LPaddleSpeed  'Move the paddle up
            End If
        End If

        If LPaddleSpeed > 0 Then 'if the paddle is going down
            If LeftPaddle.Top + RightPaddle.Height > Me.Height - 40 Then ' is the bottom of the paddle near the bottom of hte form?
                LeftPaddleTimer.Enabled = False  ' if so don't let it run off the bottom of the form
            Else
                LeftPaddle.Top += LPaddleSpeed  'Move the paddle up
            End If
        End If
    End Sub

    ''' <summary>
    ''' Flashing on text for start screen.
    ''' This is done by linking the timers to the label
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub flashOnTimer_Tick(sender As Object, e As EventArgs) Handles flashOnTimer.Tick
        StartGameLabel.Visible = True
        flashOnTimer.Enabled = False
        flashOffTimer.Enabled = True
    End Sub

    ''' <summary>
    ''' Flashing off text for start screen
    ''' This is done by linking the timers to the label
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub flashOffTimer_Tick(sender As Object, e As EventArgs) Handles flashOffTimer.Tick
        StartGameLabel.Visible = False
        flashOnTimer.Enabled = True
        flashOffTimer.Enabled = False
    End Sub

    ''' <summary>
    ''' Checks for the ball hitting either paddle.
    ''' Checks for the ball hitting the top/bottom of the screen.
    ''' Method for when ball goes past a paddle.
    ''' Computer control for the left paddle.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BallTimer_Tick(sender As Object, e As EventArgs) Handles BallTimer.Tick
        Dim gameOver
        '''COMPUTER CONTROL FOR THE LEFT PADDLE
        If LeftPaddle.Top > 2 Then  ' Check to see if paddle has room to move up
            If Ball.Top <= LeftPaddle.Top Then
                LeftPaddleTimer.Enabled = True
                LPaddleSpeed = -Math.Abs(LPaddleSpeed)  'Set paddle speed to be negative
            End If
        End If

        If LeftPaddle.Top + LeftPaddle.Height < Me.Height - 20 Then  ' Check to see if paddle has room to move down
            If Ball.Top >= LeftPaddle.Top Then
                LeftPaddleTimer.Enabled = True
                LPaddleSpeed = Math.Abs(LPaddleSpeed)  'Set paddle speed to be positive
            End If
        End If

        Ball.Top += BallTopSpeed   'Move the ball up or down
        Ball.Left += BallLeftSpeed  'Move the ball left or right




        '''CHECKS FOR THE BALL HITTING THE TOP/BOTTOM OF THE SCREEN
        'Hits the top
        If Ball.Top < 2 Then  'if the ball is near the top of the form
            BallTopSpeed = -1 * BallTopSpeed 'bounce off the top (or send the ball down)
        End If

        'hits the bottem
        If Ball.Top > Me.Height - 80 Then  'if the ball is near the bottom of the form
            BallTopSpeed = -1 * BallTopSpeed  'bounce off the bottom (or send the ball up)

        End If


        '''TESTS IF THE BALL HITS THE RIGHT PADDLE
        If Math.Abs(Ball.Right - RightPaddle.Left) < BallLeftSpeed / 2 + 1 Then
            If Ball.Top < RightPaddle.Bottom Then
                If Ball.Bottom > RightPaddle.Top Then
                    If BallTopSpeed < 8 Then ' Max speed set to 8
                        BallLeftSpeed = -1 * (BallLeftSpeed * 1.2) ' Speeds the ball up after direction change
                        BallTopSpeed = 1.2 * BallTopSpeed
                    Else
                        BallLeftSpeed = -1 * BallLeftSpeed ' Once ball reaches max speed, keeps it constant
                        BallTopSpeed = BallTopSpeed
                    End If
                End If
            End If
        End If

        '''TESTS IF THE BALL HITS THE LEFT PADDLE
        If Math.Abs(Ball.Left - LeftPaddle.Right) < Math.Abs(BallLeftSpeed / 2) + 1 Then
            If Ball.Top < LeftPaddle.Bottom Then
                If Ball.Bottom > LeftPaddle.Top Then
                    If BallTopSpeed < 8 Then ' Max speed set to 8
                        BallLeftSpeed = -1 * (BallLeftSpeed * 1.2) ' Speeds the ball up after direction change
                        BallTopSpeed = 1.2 * BallTopSpeed
                    Else
                        BallLeftSpeed = -1 * BallLeftSpeed ' Once ball reaches max speed, keeps it constant
                        BallTopSpeed = BallTopSpeed
                    End If
                End If
            End If
        End If

        ''' METHOD FOR WHEN BALL GOES PAST A PADDLE
        'Check for when ball goes past right paddle
        If Ball.Left > Me.Width Then   ' If ball went off the right side
            BallTimer.Enabled = False  ' Stop this timer
            Ball.Left = 0.5 * Me.Width - 20  ' Place the ball halfway through the width of the screen
            Ball.Top = 0.5 * Me.Height - 40  ' Place the ball halfway through the height Of the screen
            LeftPlayerScore.Text = 1 + Val(LeftPlayerScore.Text) ' Score for left player
            StartGameLabel.Text = "PRESS SPACE TO START" ' Start game text
            BallTopSpeed = 4 ' Resets ball speed to 4 when it goes off screen
            BallLeftSpeed = 4
            If Val(LeftPlayerScore.Text) = 5 Then ' Score limit
                StartGameLabel.Text = "Computer Won!"
                My.Computer.Audio.Play(My.Resources.sound, AudioPlayMode.WaitToComplete) ' Plays winning sound
                gameOver = MsgBox("The Computer Won, would you like to retry?", MsgBoxStyle.YesNo)
                If gameOver = 7 Then ' 7 is link to user clicking "no"
                    End
                Else
                    LeftPlayerScore.Text = 0 ' Reset scores
                    RightPlayerScore.Text = 0
                End If
            End If
        End If

        'Check for when ball goes past left paddle
        If Ball.Left < 0 Then   ' If ball went off the left side
            BallTimer.Enabled = False  ' Stop this timer
            Ball.Left = 0.5 * Me.Width - 20  ' Place the ball halfway through the width of the screen
            Ball.Top = 0.5 * Me.Height - 40  ' Place the ball halfway through the height Of the screen
            RightPlayerScore.Text = 1 + Val(RightPlayerScore.Text) ' Score for right player
            StartGameLabel.Text = "PRESS SPACE TO START" ' Start game text
            BallTopSpeed = 4 ' Resets ball speed to 4 when it goes off screen
            BallLeftSpeed = 4
            If Val(RightPlayerScore.Text) = 5 Then ' Score limit
                StartGameLabel.Text = "You Won!"
                My.Computer.Audio.Play(My.Resources.sound, AudioPlayMode.WaitToComplete) ' Plays winning sound
                gameOver = MsgBox("You Won, would you like to play again?", MsgBoxStyle.YesNo)
                If gameOver = 7 Then ' 7 is link to user clicking "no"
                    End
                Else
                    LeftPlayerScore.Text = 0 ' Reset scores
                    RightPlayerScore.Text = 0
                End If
            End If
        End If
    End Sub



    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.Q Then  ' Stops right paddle upward movement
            RightPaddleTimer.Enabled = False

        End If
        If e.KeyCode = Keys.A Then  ' Stops right paddle downward movement
            RightPaddleTimer.Enabled = False

        End If
    End Sub

    ''' <summary>
    ''' All intial values required to display correctly.
    ''' Including inital ball/paddle speed.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LeftPaddle.BackColor = Color.Transparent
        RightPaddle.BackColor = Color.Transparent
        Ball.BackColor = Color.Transparent
        StartGameLabel.BackColor = Color.Transparent
        LeftPlayerScore.BackColor = Color.Transparent
        RightPlayerScore.BackColor = Color.Transparent
        scoreTitle.BackColor = Color.Transparent
        BallTopSpeed = 4 '  Ball moves up or down in increments of 4 
        BallLeftSpeed = 4 ' Ball moves left or right in increments of  4
        RPaddleSpeed = 5  ' Right paddle moves in increments of 5
        LPaddleSpeed = 5  ' Left paddle moves in increments of 5
    End Sub
End Class
