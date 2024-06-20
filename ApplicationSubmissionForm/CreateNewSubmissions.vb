Imports System.Reflection.Emit

Public Class CreateNewSubmissions
    Dim hh, mm, ss As Integer
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TextBox5.Text = Format(hh, "00:") & Format(mm, "00:") & Format(ss, "00")
        ss = ss + 1
        If ss > 59 Then
            ss = 0
            mm = mm + 1
        End If
        If mm > 59 Then
            mm = 0
            hh = hh + 1
        End If
        If hh > 23 Then
            ss = 0
            mm = 0
            hh = 0
            TextBox5.Text = "00:00:00"
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Button1.Text = "TOGGLE STOPWATCH" Then
            Timer1.Start()
            Button1.Text = "Stop"
        Else
            Timer1.Stop()
            Button1.Text = "TOGGLE STOPWATCH"
        End If

    End Sub
End Class