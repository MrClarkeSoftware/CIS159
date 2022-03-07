Public Class Form1

    Dim r As New Random

    Sub LeftRight(obj As PictureBox)
        Dim index As Integer
        Dim points(6) As Point
        points(0) = New Point(-5, 0)
        points(1) = New Point(-5, 0)
        points(2) = New Point(5, 0)
        points(3) = New Point(5, 0)
        points(4) = New Point(0, 5)
        points(5) = New Point(0, -5)
        'Don't change after here
        Integer.TryParse(obj.Tag, index)
        '  obj.Location = New Point(obj.Location.X + points(index).X, obj.Location.Y + points(index).Y)
        movexy(points(index).X, points(index).Y, obj)
        index = (index + 1) Mod points.Length
        obj.Tag = index
    End Sub
    Public Sub Collision(obj1 As PictureBox, obj2 As PictureBox)
        Label1.Text = obj1.Name & "," & obj2.Name
        obj2.Visible = False
    End Sub
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

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
        LeftRight(Ghost1)
        LeftRight(Ghost2)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        SetControls(Me.Controls)
    End Sub
End Class
