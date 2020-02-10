Public Class Rooms
    Private Sub TblRoomsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TblRoomsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TblRoomsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ScheduleDataSet)

    End Sub

    Private Sub Rooms_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ScheduleDataSet.tblRooms' table. You can move, or remove it, as needed.
        Me.TblRoomsTableAdapter.Fill(Me.ScheduleDataSet.tblRooms)

    End Sub
End Class