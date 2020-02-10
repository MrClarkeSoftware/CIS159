Public Class Form1
    Private Sub RegistrationsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrationsToolStripMenuItem.Click
        Registrations.ShowDialog()
    End Sub

    Private Sub PeriodsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PeriodsToolStripMenuItem.Click
        Periods.ShowDialog()
    End Sub

    Private Sub StudentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StudentsToolStripMenuItem.Click
        Students.ShowDialog()
    End Sub
End Class
