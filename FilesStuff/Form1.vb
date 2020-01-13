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
End Class
