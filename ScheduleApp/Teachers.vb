Public Class Teachers
    Private Sub TblTeachersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TblTeachersBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TblTeachersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ScheduleDataSet)

    End Sub

    Private Sub Teachers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ScheduleDataSet.tblTeachers' table. You can move, or remove it, as needed.
        Me.TblTeachersTableAdapter.Fill(Me.ScheduleDataSet.tblTeachers)

    End Sub
End Class