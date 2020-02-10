Public Class Periods
    Private Sub TblPeriodsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TblPeriodsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TblPeriodsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ScheduleDataSet)

    End Sub

    Private Sub Periods_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ScheduleDataSet.tblPeriods' table. You can move, or remove it, as needed.
        Me.TblPeriodsTableAdapter.Fill(Me.ScheduleDataSet.tblPeriods)

    End Sub
End Class