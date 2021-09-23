Public Class Form1

    Dim r As New Random

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Me.BackColor = Color.Black
        Select Case e.KeyCode
            Case Keys.Left
                movexy(-10, 0, Avatar)
                ChangeDirection(Avatar, "W")
            Case Keys.Right
                ChangeDirection(Avatar, "E")
                movexy(10, 0, Avatar)
            Case Keys.Up
                ChangeDirection(Avatar, "N")
                movexy(0, -10, Avatar)
            Case Keys.Down
                ChangeDirection(Avatar, "S")
                movexy(-0, 10, Avatar)
            Case Keys.J

            Case Keys.Space
                ' Add(Avatar, B1, "direction", 10)
                ' Add(Avatar, B1, "N", 5)
                Add(Avatar, "jump", 5)
                Add(Ghost1, "follow", 5)
        End Select
        Me.Refresh()
    End Sub


    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Animate()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        SetControls(Me.Controls)
    End Sub
End Class
