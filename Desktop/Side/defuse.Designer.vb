<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.nameLabel = New System.Windows.Forms.Label()
        Me.instructionsLabel = New System.Windows.Forms.Label()
        Me.blueButton = New System.Windows.Forms.Button()
        Me.redButton = New System.Windows.Forms.Button()
        Me.yellowButton = New System.Windows.Forms.Button()
        Me.scoreLabel = New System.Windows.Forms.Label()
        Me.highScoreLabel = New System.Windows.Forms.Label()
        Me.timer = New System.Windows.Forms.Timer(Me.components)
        Me.timerLabel = New System.Windows.Forms.Label()
        Me.startButton = New System.Windows.Forms.Button()
        Me.warningLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'nameLabel
        '
        Me.nameLabel.AutoSize = True
        Me.nameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameLabel.Location = New System.Drawing.Point(122, 9)
        Me.nameLabel.Name = "nameLabel"
        Me.nameLabel.Size = New System.Drawing.Size(247, 31)
        Me.nameLabel.TabIndex = 0
        Me.nameLabel.Text = "Defuse the Bomb!"
        Me.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'instructionsLabel
        '
        Me.instructionsLabel.AutoSize = True
        Me.instructionsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.instructionsLabel.Location = New System.Drawing.Point(124, 40)
        Me.instructionsLabel.Name = "instructionsLabel"
        Me.instructionsLabel.Size = New System.Drawing.Size(233, 20)
        Me.instructionsLabel.TabIndex = 1
        Me.instructionsLabel.Text = "Cut a wire to defuse the bomb..."
        Me.instructionsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'blueButton
        '
        Me.blueButton.BackColor = System.Drawing.Color.DodgerBlue
        Me.blueButton.BackgroundImage = CType(resources.GetObject("blueButton.BackgroundImage"), System.Drawing.Image)
        Me.blueButton.Location = New System.Drawing.Point(109, 151)
        Me.blueButton.Name = "blueButton"
        Me.blueButton.Size = New System.Drawing.Size(56, 83)
        Me.blueButton.TabIndex = 2
        Me.blueButton.UseVisualStyleBackColor = False
        '
        'redButton
        '
        Me.redButton.BackColor = System.Drawing.Color.Red
        Me.redButton.BackgroundImage = CType(resources.GetObject("redButton.BackgroundImage"), System.Drawing.Image)
        Me.redButton.Location = New System.Drawing.Point(203, 151)
        Me.redButton.Name = "redButton"
        Me.redButton.Size = New System.Drawing.Size(56, 83)
        Me.redButton.TabIndex = 3
        Me.redButton.UseVisualStyleBackColor = False
        '
        'yellowButton
        '
        Me.yellowButton.BackColor = System.Drawing.Color.Yellow
        Me.yellowButton.BackgroundImage = CType(resources.GetObject("yellowButton.BackgroundImage"), System.Drawing.Image)
        Me.yellowButton.Location = New System.Drawing.Point(301, 151)
        Me.yellowButton.Name = "yellowButton"
        Me.yellowButton.Size = New System.Drawing.Size(56, 83)
        Me.yellowButton.TabIndex = 4
        Me.yellowButton.UseVisualStyleBackColor = False
        '
        'scoreLabel
        '
        Me.scoreLabel.AutoSize = True
        Me.scoreLabel.Location = New System.Drawing.Point(13, 74)
        Me.scoreLabel.Name = "scoreLabel"
        Me.scoreLabel.Size = New System.Drawing.Size(47, 13)
        Me.scoreLabel.TabIndex = 5
        Me.scoreLabel.Text = "Score: 0"
        '
        'highScoreLabel
        '
        Me.highScoreLabel.AutoSize = True
        Me.highScoreLabel.Location = New System.Drawing.Point(370, 74)
        Me.highScoreLabel.Name = "highScoreLabel"
        Me.highScoreLabel.Size = New System.Drawing.Size(72, 13)
        Me.highScoreLabel.TabIndex = 6
        Me.highScoreLabel.Text = "High Score: 0"
        '
        'timer
        '
        Me.timer.Enabled = True
        Me.timer.Interval = 10000
        '
        'timerLabel
        '
        Me.timerLabel.AutoSize = True
        Me.timerLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timerLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.timerLabel.Location = New System.Drawing.Point(219, 69)
        Me.timerLabel.Name = "timerLabel"
        Me.timerLabel.Size = New System.Drawing.Size(0, 31)
        Me.timerLabel.TabIndex = 7
        '
        'startButton
        '
        Me.startButton.Location = New System.Drawing.Point(193, 74)
        Me.startButton.Name = "startButton"
        Me.startButton.Size = New System.Drawing.Size(75, 23)
        Me.startButton.TabIndex = 8
        Me.startButton.Text = "START"
        Me.startButton.UseVisualStyleBackColor = True
        '
        'warningLabel
        '
        Me.warningLabel.AutoSize = True
        Me.warningLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.warningLabel.ForeColor = System.Drawing.Color.Red
        Me.warningLabel.Location = New System.Drawing.Point(34, 289)
        Me.warningLabel.Name = "warningLabel"
        Me.warningLabel.Size = New System.Drawing.Size(0, 37)
        Me.warningLabel.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(454, 363)
        Me.Controls.Add(Me.warningLabel)
        Me.Controls.Add(Me.startButton)
        Me.Controls.Add(Me.timerLabel)
        Me.Controls.Add(Me.highScoreLabel)
        Me.Controls.Add(Me.scoreLabel)
        Me.Controls.Add(Me.yellowButton)
        Me.Controls.Add(Me.redButton)
        Me.Controls.Add(Me.blueButton)
        Me.Controls.Add(Me.instructionsLabel)
        Me.Controls.Add(Me.nameLabel)
        Me.Name = "Form1"
        Me.Text = "Defuse the Bomb!"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents nameLabel As Label
    Friend WithEvents instructionsLabel As Label
    Friend WithEvents blueButton As Button
    Friend WithEvents redButton As Button
    Friend WithEvents yellowButton As Button
    Friend WithEvents scoreLabel As Label
    Friend WithEvents highScoreLabel As Label
    Friend WithEvents timer As Timer
    Friend WithEvents timerLabel As Label
    Friend WithEvents startButton As Button
    Friend WithEvents warningLabel As Label
End Class
