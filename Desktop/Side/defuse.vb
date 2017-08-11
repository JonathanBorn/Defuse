Public Class Form1

    Shared score As Integer = CInt(0)
    Shared highScore As Integer = CInt(0)
    Shared message As String = "BOOM! You cut the wrong wire..."
    Shared time As Integer = 10

    Private Sub blueButton_Click(sender As Object, e As EventArgs) Handles blueButton.Click
        Dim bomb As Integer = CInt(Math.Ceiling(Rnd() * 3))
        Dim scoreText As String = CStr(scoreLabel.Text)
        Dim highScoreText As String = CStr(highScoreLabel.Text)

        If bomb = 1 Then
            timer.Stop()
            If MessageBox.Show(message, "BOOM!", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                time = 10
                timerLabel.Text = CStr(time)
                timer.Start()
            Else
                End
            End If

            If score > highScore Then
                highScore = score
                highScoreText = "High Score: " + CStr(highScore)
                highScoreLabel.Text = highScoreText
            End If

            score = 0
            scoreText = "Score: 0"
            scoreLabel.Text = scoreText
        Else
            score = score + 1
            scoreText = "Score: " + CStr(score) 
            scoreLabel.Text = scoreText
        End If
    End Sub

    Private Sub redButton_Click(sender As Object, e As EventArgs) Handles redButton.Click
        Dim bomb As Integer = CInt(Math.Ceiling(Rnd() * 3))
        Dim scoreText As String = CStr(scoreLabel.Text)
        Dim highScoreText As String = CStr(highScoreLabel.Text)

        If bomb = 2 Then
            timer.Stop()
            If MessageBox.Show(message, "BOOM!", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                time = 10
                timerLabel.Text = CStr(time)
                timer.Start()
            Else
                End
            End If

            If score > highScore Then
                highScore = score
                highScoreText = "High Score: " + CStr(highScore)
                highScoreLabel.Text = highScoreText
            End If

            score = 0
            scoreText = "Score: 0"
            scoreLabel.Text = scoreText
        Else
            score = score + 1
            scoreText = "Score: " + CStr(score)
            scoreLabel.Text = scoreText
        End If
    End Sub

    Private Sub yellowButton_Click(sender As Object, e As EventArgs) Handles yellowButton.Click
        Dim bomb As Integer = CInt(Math.Ceiling(Rnd() * 3))
        Dim scoreText As String = CStr(scoreLabel.Text)
        Dim highScoreText As String = CStr(highScoreLabel.Text)

        If bomb = 3 Then
            timer.Stop()
            If MessageBox.Show(message, "BOOM!", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                time = 10
                timerLabel.Text = CStr(time)
                timer.Start()
            Else
                End
            End If

            If score > highScore Then
                highScore = score
                highScoreText = "High Score: " + CStr(highScore)
                highScoreLabel.Text = highScoreText
            End If

            score = 0
            scoreText = "Score: 0"
            scoreLabel.Text = scoreText
        Else
            score = score + 1
            scoreText = "Score: " + CStr(score)
            scoreLabel.Text = scoreText
        End If
    End Sub

    Private Sub timer_Tick(sender As Object, e As EventArgs) Handles timer.Tick
        time = time - 1
        timerLabel.Text = CStr(time)

        If time = 3 Then
            warningLabel.Text = "HURRY! Time is almost up!"
        End If

        If time = 0 Then
            timer.Stop()
            If MessageBox.Show("BOOM! Time ran out", "BOOM!", MessageBoxButtons.RetryCancel) = DialogResult.Retry Then
                time = 10
                timerLabel.Text = CStr(time)
                timer.Start()
            Else
                End
            End If
        End If
    End Sub

    Private Sub startButton_Click(sender As Object, e As EventArgs) Handles startButton.Click
        blueButton.Enabled = True
        redButton.Enabled = True
        yellowButton.Enabled = True

        timerLabel.Text = CStr(time)

        timer.Interval = 1000
        timer.Start()

        startButton.Visible = False
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        blueButton.Enabled = False
        redButton.Enabled = False
        yellowButton.Enabled = False
    End Sub
End Class
