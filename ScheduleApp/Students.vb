Public Class Students
    Private Sub TblStudentsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TblStudentsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TblStudentsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ScheduleDataSet)

    End Sub

    Private Sub Students_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ScheduleDataSet.tblStudents' table. You can move, or remove it, as needed.
        Me.TblStudentsTableAdapter.Fill(Me.ScheduleDataSet.tblStudents)

    End Sub
End Class