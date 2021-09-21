﻿Module Module1
    Public pacdirection As String = "E"
    Dim objs As New Collection
    Dim controls As Control.ControlCollection
    Structure Record
        Dim p As PictureBox
        Dim dir As String
        Dim xdir As Integer
        Dim ydir As Integer
        Dim path As Point()
        Dim idx As Integer
        Dim repeat As Boolean
        Dim remove As Boolean
        Dim speed As Integer
    End Structure
    Public Sub SetControls(c As Control.ControlCollection)
        controls = c
    End Sub
    Public Sub Animate()
        For Each o As Record In objs
            Select Case o.dir.ToUpper
                Case "REMOVE"
                Case "DIRECTION"
                    movexy(o.xdir, o.ydir, o.p)
                Case "JUMP"
                    Dim idx As Integer
                    Integer.TryParse(o.p.Tag, idx)

                    movexy(o.path(idx).X, o.path(idx).Y, o.p)
                    If Not o.repeat And idx = o.path.GetUpperBound(0) Then
                        o.p.Tag = "REMOVE"
                    Else
                        o.p.Tag = idx + 1
                    End If

            End Select
        Next
        For Each o As Record In objs
            If o.p.Tag.ToString = "REMOVE" Then
                objs.Remove(o.p.Name)
                o.p.Tag = "0"
                If o.remove Then controls.Remove(o.p)
            End If
        Next
    End Sub
    Public Sub Add(o As PictureBox, dir As String, speed As Integer)
        Add(o, o, dir, speed)
    End Sub
    Public Sub Add(o As PictureBox, clone As PictureBox, dir As String, speed As Integer)
        Dim r As New Record
        Dim temp As New PictureBox
        temp.Tag = clone.Name
        temp.Width = clone.Width
        temp.Height = clone.Height
        temp.Image = clone.Image
        temp.Location = o.Location
        If dir.ToUpper = "JUMP" Then
            temp = o
        End If
        controls.Add(temp)
        r.p = temp
        r.dir = dir
        Select Case dir.ToUpper
            Case "DIRECTION"
                If pacdirection = "N" Then
                    r.xdir = 0
                    r.ydir = -speed
                End If
                If pacdirection = "S" Then
                    r.xdir = 0
                    r.ydir = speed
                End If
                If pacdirection = "E" Then
                    r.xdir = speed
                    r.ydir = 0
                End If
                If pacdirection = "W" Then
                    r.xdir = -speed
                    r.ydir = 0
                End If
            Case "N"
                r.dir = "DIRECTION"
                r.xdir = 0
                r.ydir = -speed
            Case "S"
                r.dir = "DIRECTION"
                r.xdir = 0
                r.ydir = speed
            Case "E"
                r.dir = "DIRECTION"
                r.xdir = speed
                r.ydir = 0
            Case "S"
                r.dir = "DIRECTION"
                r.xdir = -speed
                r.ydir = 0
            Case "JUMP"
                Dim jump(5) As Point
                jump(0) = New Point(0, -speed)
                jump(1) = New Point(0, -speed)
                jump(2) = New Point(0, -speed)
                jump(3) = New Point(0, speed)
                jump(4) = New Point(0, speed)
                jump(5) = New Point(0, speed)
                r.path = jump
                r.repeat = False
        End Select

        r.speed = speed
        If r.p.Name <> "" Then
            objs.Add(r, r.p.Name)
        Else
            objs.Add(r)
        End If
    End Sub


    Function getOther(both As String, n As String) As String
        Return both.Substring(both.IndexOf(n), n.Length)
    End Function
    Function CollidesWithWall(p As PictureBox) As Boolean
        'For Each other In controls
        '    If other IsNot p AndAlso p.Bounds.IntersectsWith(other.Bounds) Then
        '        CollidesWithWall = True
        '        Dim s As String
        '        s = p.Tag & "," & other.tag
        '        s = s.ToLower
        '        Debug.Print(s)
        '        If s.Contains("b1") And s.Contains(",0") Then Return False

        '        If s.Contains("b1") And s.Contains("ghost") Then
        '                controls.Remove(controls(other))
        '            End If
        '            Return True
        '    End If
        'Next

        Return False
    End Function
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

    Function movexy(distx As Integer, disty As Integer, p As PictureBox) As Boolean
        Dim previous As Point = p.Location

        p.Location = New Point(p.Location.X + distx, p.Location.Y + disty)
        'If we ran into a wall put the previous location back
        If CollidesWithWall(p) Then
            p.Location = previous
            Return False
        End If

        Return True

    End Function


End Module
