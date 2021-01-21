Public Class Form1

    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        Dim intDivisor As Integer
        Dim intGuess As Integer
        Dim intIsPrime As Integer
        Dim intScore As Integer

        Do
            intGuess = Val(InputBox("Enter A Prime Number"))

            If intGuess < intDivisor Then
            Else

                ' Check If The Number Is Prime
                intDivisor = 1
                If intGuess <= 1 Then
                    intIsPrime = 0
                Else
                    Do
                        intDivisor = intDivisor + 1
                    Loop While intGuess Mod intDivisor <> 0
                    If intGuess = intDivisor Then
                        intIsPrime = 1
                        intScore = intScore + 1
                    Else
                        intIsPrime = 0
                    End If
                End If
                ' End Check
            End If

        Loop While intGuess = intDivisor
        MessageBox.Show("Score: " & intScore)

    End Sub
End Class
