Public Class Registrations
    Private Sub Registrations_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ScheduleDataSet.tblRegistrations' table. You can move, or remove it, as needed.
        Me.TblRegistrationsTableAdapter.Fill(Me.ScheduleDataSet.tblRegistrations)
        Me.TblStudentsTableAdapter.Fill(Me.ScheduleDataSet.tblStudents)
        loaditems()

    End Sub
    Sub loaditems()
        Dim students = From s In ScheduleDataSet.tblStudents
                       Select s.LastName
        For Each lname In students
            ComboBox1.Items.Add(lname)
        Next
    End Sub
    Private Sub TblRegistrationsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TblRegistrationsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TblRegistrationsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ScheduleDataSet)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Add this voucher to the vouchers table
        Dim newReg As ScheduleDataSet.tblRegistrationsRow
        newReg = ScheduleDataSet.tblRegistrations.NewtblRegistrationsRow
        newReg.ClassID = 1
        newReg.StudentID = 1
        newReg.PeriodID = 1
        newReg.TeacherID = 1
        ScheduleDataSet.tblRegistrations.AddtblRegistrationsRow(newReg)

        Me.Validate()
        Me.TblRegistrationsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ScheduleDataSet)
    End Sub
End Class