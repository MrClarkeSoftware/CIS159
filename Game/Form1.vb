Public Class Form1
    Dim facingLeft As Boolean
    Dim facingUp As Boolean
    Dim points(99) As Point
    Dim pacIndex As Integer
    Dim ghostIndex As Integer
    Dim ghostDirection As Integer
    Dim pacdirection As String = "E"

    Dim r As New Random

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.Left
                movehorizontal(-10, Avatar)
                ChangeDirection(Avatar, "W")
            Case Keys.Right
                ChangeDirection(Avatar, "E")
                movehorizontal(10, Avatar)
            Case Keys.Up
                ChangeDirection(Avatar, "N")
                movevertical(-10, Avatar)
            Case Keys.Down
                ChangeDirection(Avatar, "S")
                movevertical(10, Avatar)
        End Select
        points(pacIndex) = Avatar.Location
        pacIndex = pacIndex + 1
        pacIndex = pacIndex Mod 100

        'start ghost after 20 moves
        If pacIndex > 20 Then
            Timer1.Enabled = True
        End If
        Me.Refresh()
    End Sub
    Sub ChangeDirection(p As PictureBox, dir As String)
        'No change in direction
        If pacdirection = dir Then Return

        'Get back to facing right
        Select Case pacdirection
            Case "W"
                p.Image.RotateFlip(RotateFlipType.RotateNoneFlipX)
            Case "N"
                p.Image.RotateFlip(RotateFlipType.Rotate90FlipNone)
            Case "S"
                p.Image.RotateFlip(RotateFlipType.Rotate270FlipNone)
        End Select

        Select Case dir
            Case "W"
                p.Image.RotateFlip(RotateFlipType.RotateNoneFlipX)
            Case "N"
                p.Image.RotateFlip(RotateFlipType.Rotate270FlipNone)
            Case "S"
                p.Image.RotateFlip(RotateFlipType.Rotate90FlipNone)
        End Select
        pacdirection = dir

    End Sub
    Function move(distx As Integer, disty As Integer, p As PictureBox) As Boolean
        Dim previous As Point = p.Location

        p.Location = New Point(p.Location.X + distx, p.Location.Y + disty)
        'If we ran into a wall put the previous location back
        If CollidesWithWall(p) Then
            p.Location = previous
            Return False
        End If

        Return True

    End Function
    Function movehorizontal(dist As Integer, p As PictureBox) As Boolean
        Dim previous As Point = p.Location

        p.Location = New Point(p.Location.X + dist, p.Location.Y)
        'If we ran into a wall put the previous location back
        If CollidesWithWall(p) Then
            p.Location = previous
            Return False
        End If

        Return True
    End Function

    Function movevertical(dist As Integer, p As PictureBox) As Boolean
        Dim previous As Point = p.Location
        p.Location = New Point(p.Location.X, p.Location.Y + dist)
        'If we ran into a wall put the previous location back
        If CollidesWithWall(p) Then
            p.Location = previous
            Return False
        End If
        Return True
    End Function

    Function CollidesWithWall(p As PictureBox) As Boolean
        For Each PictureBox In Me.Controls
            If PictureBox IsNot p AndAlso p.Bounds.IntersectsWith(PictureBox.Bounds) Then
                CollidesWithWall = True
                Dim s As String
                s = p.Name.ToLower & PictureBox.name.tolower
                Debug.Print(s)
                If s.Contains("avatar") And s.Contains("ghost") Then
                    MsgBox("You lose!")
                    ResetGame()
                End If
                Return True
            End If
        Next

        Return False
    End Function
    Sub ResetGame()
        Avatar.Location = New Point(40, 240)
        pacIndex = 0
        Timer1.Enabled = False
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.BackColor = Color.Black
        Ghost1.Location = points(ghostIndex)
        ghostIndex += 1
        ghostIndex = ghostIndex Mod 100
        If ghostDirection = 0 Then
            If Not movehorizontal(10, Ghost2) Then
                ghostDirection = r.Next(0, 4)
            End If
        End If
        If ghostDirection = 1 Then
            If Not movehorizontal(-10, Ghost2) Then
                ghostDirection = r.Next(0, 4)
            End If
        End If
        If ghostDirection = 2 Then
            If Not movevertical(10, Ghost2) Then
                ghostDirection = r.Next(0, 4)
            End If
        End If
        If ghostDirection = 3 Then
            If Not movevertical(-10, Ghost2) Then
                ghostDirection = r.Next(0, 4)
            End If
        End If
    End Sub
End Class
