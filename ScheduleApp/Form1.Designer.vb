<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SchedulesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TeachersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RoomsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PeriodsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClassesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SchedulesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SchedulesToolStripMenuItem
        '
        Me.SchedulesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StudentsToolStripMenuItem, Me.TeachersToolStripMenuItem, Me.RoomsToolStripMenuItem, Me.PeriodsToolStripMenuItem, Me.ClassesToolStripMenuItem, Me.RegistrationsToolStripMenuItem})
        Me.SchedulesToolStripMenuItem.Name = "SchedulesToolStripMenuItem"
        Me.SchedulesToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.SchedulesToolStripMenuItem.Text = "Schedules"
        '
        'StudentsToolStripMenuItem
        '
        Me.StudentsToolStripMenuItem.Name = "StudentsToolStripMenuItem"
        Me.StudentsToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.StudentsToolStripMenuItem.Text = "Students"
        '
        'TeachersToolStripMenuItem
        '
        Me.TeachersToolStripMenuItem.Name = "TeachersToolStripMenuItem"
        Me.TeachersToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.TeachersToolStripMenuItem.Text = "Teachers"
        '
        'RoomsToolStripMenuItem
        '
        Me.RoomsToolStripMenuItem.Name = "RoomsToolStripMenuItem"
        Me.RoomsToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.RoomsToolStripMenuItem.Text = "Rooms"
        '
        'PeriodsToolStripMenuItem
        '
        Me.PeriodsToolStripMenuItem.Name = "PeriodsToolStripMenuItem"
        Me.PeriodsToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PeriodsToolStripMenuItem.Text = "Periods"
        '
        'ClassesToolStripMenuItem
        '
        Me.ClassesToolStripMenuItem.Name = "ClassesToolStripMenuItem"
        Me.ClassesToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ClassesToolStripMenuItem.Text = "Subjects"
        '
        'RegistrationsToolStripMenuItem
        '
        Me.RegistrationsToolStripMenuItem.Name = "RegistrationsToolStripMenuItem"
        Me.RegistrationsToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.RegistrationsToolStripMenuItem.Text = "Registrations"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Schedules"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SchedulesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StudentsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TeachersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RoomsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PeriodsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClassesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistrationsToolStripMenuItem As ToolStripMenuItem
End Class
