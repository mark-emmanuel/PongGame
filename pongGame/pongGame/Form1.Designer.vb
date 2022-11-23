<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Ball = New System.Windows.Forms.PictureBox()
        Me.LeftPaddle = New System.Windows.Forms.PictureBox()
        Me.RightPaddle = New System.Windows.Forms.PictureBox()
        Me.LeftPaddleTimer = New System.Windows.Forms.Timer(Me.components)
        Me.RightPaddleTimer = New System.Windows.Forms.Timer(Me.components)
        Me.BallTimer = New System.Windows.Forms.Timer(Me.components)
        Me.LeftPlayerScore = New System.Windows.Forms.Label()
        Me.RightPlayerScore = New System.Windows.Forms.Label()
        Me.StartGameLabel = New System.Windows.Forms.Label()
        Me.flashOnTimer = New System.Windows.Forms.Timer(Me.components)
        Me.flashOffTimer = New System.Windows.Forms.Timer(Me.components)
        Me.scoreTitle = New System.Windows.Forms.Label()
        CType(Me.Ball, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LeftPaddle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RightPaddle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Ball
        '
        Me.Ball.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Ball.Image = CType(resources.GetObject("Ball.Image"), System.Drawing.Image)
        Me.Ball.Location = New System.Drawing.Point(311, 174)
        Me.Ball.Name = "Ball"
        Me.Ball.Size = New System.Drawing.Size(50, 50)
        Me.Ball.TabIndex = 0
        Me.Ball.TabStop = False
        '
        'LeftPaddle
        '
        Me.LeftPaddle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.LeftPaddle.Image = CType(resources.GetObject("LeftPaddle.Image"), System.Drawing.Image)
        Me.LeftPaddle.Location = New System.Drawing.Point(12, 127)
        Me.LeftPaddle.Name = "LeftPaddle"
        Me.LeftPaddle.Size = New System.Drawing.Size(30, 100)
        Me.LeftPaddle.TabIndex = 1
        Me.LeftPaddle.TabStop = False
        '
        'RightPaddle
        '
        Me.RightPaddle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RightPaddle.Image = CType(resources.GetObject("RightPaddle.Image"), System.Drawing.Image)
        Me.RightPaddle.Location = New System.Drawing.Point(742, 141)
        Me.RightPaddle.Name = "RightPaddle"
        Me.RightPaddle.Size = New System.Drawing.Size(30, 100)
        Me.RightPaddle.TabIndex = 2
        Me.RightPaddle.TabStop = False
        '
        'LeftPaddleTimer
        '
        Me.LeftPaddleTimer.Interval = 1
        '
        'RightPaddleTimer
        '
        Me.RightPaddleTimer.Interval = 1
        '
        'BallTimer
        '
        Me.BallTimer.Interval = 1
        '
        'LeftPlayerScore
        '
        Me.LeftPlayerScore.AutoSize = True
        Me.LeftPlayerScore.Font = New System.Drawing.Font("Showcard Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LeftPlayerScore.ForeColor = System.Drawing.Color.White
        Me.LeftPlayerScore.Location = New System.Drawing.Point(334, 322)
        Me.LeftPlayerScore.Name = "LeftPlayerScore"
        Me.LeftPlayerScore.Size = New System.Drawing.Size(27, 30)
        Me.LeftPlayerScore.TabIndex = 3
        Me.LeftPlayerScore.Text = "0"
        '
        'RightPlayerScore
        '
        Me.RightPlayerScore.AutoSize = True
        Me.RightPlayerScore.Font = New System.Drawing.Font("Showcard Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RightPlayerScore.ForeColor = System.Drawing.Color.White
        Me.RightPlayerScore.Location = New System.Drawing.Point(414, 322)
        Me.RightPlayerScore.Name = "RightPlayerScore"
        Me.RightPlayerScore.Size = New System.Drawing.Size(27, 30)
        Me.RightPlayerScore.TabIndex = 4
        Me.RightPlayerScore.Text = "0"
        '
        'StartGameLabel
        '
        Me.StartGameLabel.AutoSize = True
        Me.StartGameLabel.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.StartGameLabel.Font = New System.Drawing.Font("Showcard Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.StartGameLabel.ForeColor = System.Drawing.Color.Red
        Me.StartGameLabel.Location = New System.Drawing.Point(236, 9)
        Me.StartGameLabel.Name = "StartGameLabel"
        Me.StartGameLabel.Size = New System.Drawing.Size(295, 30)
        Me.StartGameLabel.TabIndex = 5
        Me.StartGameLabel.Text = "PRESS SPACE TO START"
        '
        'flashOnTimer
        '
        Me.flashOnTimer.Enabled = True
        Me.flashOnTimer.Interval = 1000
        '
        'flashOffTimer
        '
        Me.flashOffTimer.Interval = 1000
        '
        'scoreTitle
        '
        Me.scoreTitle.AutoSize = True
        Me.scoreTitle.Font = New System.Drawing.Font("Showcard Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.scoreTitle.ForeColor = System.Drawing.Color.White
        Me.scoreTitle.Location = New System.Drawing.Point(367, 334)
        Me.scoreTitle.Name = "scoreTitle"
        Me.scoreTitle.Size = New System.Drawing.Size(45, 15)
        Me.scoreTitle.TabIndex = 6
        Me.scoreTitle.Text = "SCORE"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(784, 361)
        Me.Controls.Add(Me.scoreTitle)
        Me.Controls.Add(Me.StartGameLabel)
        Me.Controls.Add(Me.RightPlayerScore)
        Me.Controls.Add(Me.LeftPlayerScore)
        Me.Controls.Add(Me.RightPaddle)
        Me.Controls.Add(Me.LeftPaddle)
        Me.Controls.Add(Me.Ball)
        Me.DoubleBuffered = True
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.Ball, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LeftPaddle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RightPaddle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Ball As PictureBox
    Friend WithEvents LeftPaddle As PictureBox
    Friend WithEvents RightPaddle As PictureBox
    Friend WithEvents LeftPaddleTimer As Timer
    Friend WithEvents RightPaddleTimer As Timer
    Friend WithEvents BallTimer As Timer
    Friend WithEvents LeftPlayerScore As Label
    Friend WithEvents RightPlayerScore As Label
    Friend WithEvents StartGameLabel As Label
    Friend WithEvents flashOnTimer As Timer
    Friend WithEvents flashOffTimer As Timer
    Friend WithEvents scoreTitle As Label
End Class
