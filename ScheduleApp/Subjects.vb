Public Class Subjects
    Private Sub TblSubjectsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TblSubjectsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TblSubjectsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ScheduleDataSet)

    End Sub

    Private Sub Subjects_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ScheduleDataSet.tblSubjects' table. You can move, or remove it, as needed.
        Me.TblSubjectsTableAdapter.Fill(Me.ScheduleDataSet.tblSubjects)

    End Sub
End Class