Public Class Form1
    Dim moveSpeed As Integer = 15
    Dim isJumping As Boolean
    Dim coins As Integer

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.Right
                tmrRight.Start()
            Case Keys.Up
                tmrUp.Start()
                isJumping = True
            Case Keys.Left
                tmrLeft.Start()

        End Select
    End Sub

    Private Sub tmrRight_Tick(sender As Object, e As EventArgs) Handles tmrRight.Tick
        picPlayer.Left += moveSpeed
    End Sub

    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        Select Case e.KeyCode
            Case Keys.Right
                tmrRight.Stop()
            Case Keys.Up
                tmrUp.Stop()
                isJumping = False
            Case Keys.Left
                tmrLeft.Stop()
        End Select
    End Sub

    Private Sub tmrUp_Tick(sender As Object, e As EventArgs) Handles tmrUp.Tick
        picPlayer.Top -= moveSpeed
        tmrUp.Stop()
    End Sub

    Private Sub tmrLeft_Tick(sender As Object, e As EventArgs) Handles tmrLeft.Tick
        picPlayer.Left -= moveSpeed
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmrGameLogic.Start()
    End Sub

    Private Sub tmrGameLogic_Tick(sender As Object, e As EventArgs) Handles tmrGameLogic.Tick
        If picPlayer.Bounds.IntersectsWith(picAir.Bounds) Then
            If isJumping = False Then
                tmrGravity.Start()
            End If
        ElseIf picPlayer.Bounds.IntersectsWith(picGround.Bounds) Then
            tmrGravity.Stop()
        End If

        For Each b As Control In Me.Controls
            If TypeOf b Is PictureBox Then
                If b.Tag = "bound" Then
                    If picPlayer.Bounds.IntersectsWith(b.Bounds) Then
                        tmrGravity.Stop()
                    End If
                End If
                If b.Tag = "coin" Then
                    If b.Visible And picPlayer.Bounds.IntersectsWith(b.Bounds) Then
                        b.Visible = False
                        coins += 1
                        scoreLabel.Text = coins
                    End If
                End If
                If b.Visible And b.Tag = "gameover" And picPlayer.Bounds.IntersectsWith(b.Bounds) Then
                    MsgBox("Game Over")
                    coins = 0
                    scoreLabel.Text = coins
                    b.Visible = False
                End If
            End If
        Next
    End Sub

    Private Sub tmrGravity_Tick(sender As Object, e As EventArgs) Handles tmrGravity.Tick
        picPlayer.Top += moveSpeed
    End Sub


End Class
