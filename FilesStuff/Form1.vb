Public Class Form1
    Dim index As Integer
    Dim count As Integer
    Dim peopleArray(100) As Person

    Structure Person
        Public Name As String
        Public Email As String
        Public IsStudent As Boolean
    End Structure

    Public Sub show(i As Integer)
        NameTextBox.Text = peopleArray(i).Name
        emailTextBox.Text = peopleArray(i).Email
        StudentCheckBox.Checked = peopleArray(i).IsStudent
    End Sub
    Public Sub clear()
        NameTextBox.Text = ""
        emailTextBox.Text = ""
        StudentCheckBox.Checked = False
        NameTextBox.Focus()
    End Sub
    Private Sub FirstButton_Click(sender As Object, e As EventArgs) Handles FirstButton.Click
        index = 0
        show(index)
    End Sub

    Private Sub LastButton_Click(sender As Object, e As EventArgs) Handles LastButton.Click
        index = count - 1
        show(index)
    End Sub

    Private Sub PrevButton_Click(sender As Object, e As EventArgs) Handles PrevButton.Click
        If index > 0 Then
            index = index - 1
            show(index)
        End If
    End Sub
    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click
        If index < count - 1 Then
            index = index + 1
            show(index)
        End If
    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        Dim p As Person
        p.Name = NameTextBox.Text
        p.Email = emailTextBox.Text
        p.IsStudent = StudentCheckBox.Checked
        peopleArray(count) = p
        count = count + 1
        index = count - 1
        clear()

    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        Dim outFile As IO.StreamWriter
        outFile = IO.File.CreateText("people.txt")

        For idx = 0 To count - 1
            outFile.Write(peopleArray(idx).Name)
            outFile.Write(",")
            outFile.Write(peopleArray(idx).Email)
            outFile.Write(",")
            outFile.Write(peopleArray(idx).IsStudent)
            outFile.WriteLine()
        Next
        outFile.Close()
        ReadFile()
    End Sub
    Sub ReadFile()
        Dim inFile As IO.StreamReader
        inFile = IO.File.OpenText("people.txt")
        fileTextBox.Text = inFile.ReadToEnd
        inFile.Close()
    End Sub

    Sub ReadData()
        If IO.File.Exists("people.txt") Then
            Dim inFile As IO.StreamReader
            inFile = IO.File.OpenText("people.txt")
            Dim line As String
            Dim data() As String

            index = 0
            count = 0
            Do While inFile.Peek <> -1
                Dim p As New Person

                line = inFile.ReadLine
                data = line.Split(",")

                'Put the data from the file into the structure
                'Check the length to not try to read more than was in the file
                If data.Length > 0 Then p.Name = data(0)
                If data.Length > 1 Then p.Email = data(1)
                If data.Length > 2 Then Boolean.TryParse(data(2), p.IsStudent)

                peopleArray(index) = p
                count = count + 1

            Loop
            inFile.Close()
        End If
        index = 0
        show(index)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class
