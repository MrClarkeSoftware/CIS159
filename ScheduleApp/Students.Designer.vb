<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Students
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Students))
        Dim IDLabel As System.Windows.Forms.Label
        Dim LastNameLabel As System.Windows.Forms.Label
        Dim FirstNameLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim StudentIDLabel As System.Windows.Forms.Label
        Me.ScheduleDataSet = New ScheduleApp.ScheduleDataSet()
        Me.TblStudentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblStudentsTableAdapter = New ScheduleApp.ScheduleDataSetTableAdapters.tblStudentsTableAdapter()
        Me.TableAdapterManager = New ScheduleApp.ScheduleDataSetTableAdapters.TableAdapterManager()
        Me.TblStudentsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.TblStudentsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.StudentIDTextBox = New System.Windows.Forms.TextBox()
        IDLabel = New System.Windows.Forms.Label()
        LastNameLabel = New System.Windows.Forms.Label()
        FirstNameLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        StudentIDLabel = New System.Windows.Forms.Label()
        CType(Me.ScheduleDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblStudentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblStudentsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TblStudentsBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'ScheduleDataSet
        '
        Me.ScheduleDataSet.DataSetName = "ScheduleDataSet"
        Me.ScheduleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblStudentsBindingSource
        '
        Me.TblStudentsBindingSource.DataMember = "tblStudents"
        Me.TblStudentsBindingSource.DataSource = Me.ScheduleDataSet
        '
        'TblStudentsTableAdapter
        '
        Me.TblStudentsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblPeriodsTableAdapter = Nothing
        Me.TableAdapterManager.tblRegistrationsTableAdapter = Nothing
        Me.TableAdapterManager.tblRoomsTableAdapter = Nothing
        Me.TableAdapterManager.tblStudentsTableAdapter = Me.TblStudentsTableAdapter
        Me.TableAdapterManager.tblSubjectsTableAdapter = Nothing
        Me.TableAdapterManager.tblTeachersTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ScheduleApp.ScheduleDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblStudentsBindingNavigator
        '
        Me.TblStudentsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TblStudentsBindingNavigator.BindingSource = Me.TblStudentsBindingSource
        Me.TblStudentsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TblStudentsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TblStudentsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TblStudentsBindingNavigatorSaveItem})
        Me.TblStudentsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TblStudentsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TblStudentsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TblStudentsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TblStudentsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TblStudentsBindingNavigator.Name = "TblStudentsBindingNavigator"
        Me.TblStudentsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TblStudentsBindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.TblStudentsBindingNavigator.TabIndex = 0
        Me.TblStudentsBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 15)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'TblStudentsBindingNavigatorSaveItem
        '
        Me.TblStudentsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TblStudentsBindingNavigatorSaveItem.Image = CType(resources.GetObject("TblStudentsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TblStudentsBindingNavigatorSaveItem.Name = "TblStudentsBindingNavigatorSaveItem"
        Me.TblStudentsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.TblStudentsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(66, 74)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(21, 13)
        IDLabel.TabIndex = 1
        IDLabel.Text = "ID:"
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStudentsBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(133, 71)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IDTextBox.TabIndex = 2
        '
        'LastNameLabel
        '
        LastNameLabel.AutoSize = True
        LastNameLabel.Location = New System.Drawing.Point(66, 100)
        LastNameLabel.Name = "LastNameLabel"
        LastNameLabel.Size = New System.Drawing.Size(61, 13)
        LastNameLabel.TabIndex = 3
        LastNameLabel.Text = "Last Name:"
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStudentsBindingSource, "LastName", True))
        Me.LastNameTextBox.Location = New System.Drawing.Point(133, 97)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.LastNameTextBox.TabIndex = 4
        '
        'FirstNameLabel
        '
        FirstNameLabel.AutoSize = True
        FirstNameLabel.Location = New System.Drawing.Point(66, 126)
        FirstNameLabel.Name = "FirstNameLabel"
        FirstNameLabel.Size = New System.Drawing.Size(60, 13)
        FirstNameLabel.TabIndex = 5
        FirstNameLabel.Text = "First Name:"
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStudentsBindingSource, "FirstName", True))
        Me.FirstNameTextBox.Location = New System.Drawing.Point(133, 123)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FirstNameTextBox.TabIndex = 6
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(66, 152)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(35, 13)
        EmailLabel.TabIndex = 7
        EmailLabel.Text = "Email:"
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStudentsBindingSource, "Email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(133, 149)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(100, 20)
        Me.EmailTextBox.TabIndex = 8
        '
        'StudentIDLabel
        '
        StudentIDLabel.AutoSize = True
        StudentIDLabel.Location = New System.Drawing.Point(66, 178)
        StudentIDLabel.Name = "StudentIDLabel"
        StudentIDLabel.Size = New System.Drawing.Size(61, 13)
        StudentIDLabel.TabIndex = 9
        StudentIDLabel.Text = "Student ID:"
        '
        'StudentIDTextBox
        '
        Me.StudentIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStudentsBindingSource, "StudentID", True))
        Me.StudentIDTextBox.Location = New System.Drawing.Point(133, 175)
        Me.StudentIDTextBox.Name = "StudentIDTextBox"
        Me.StudentIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.StudentIDTextBox.TabIndex = 10
        '
        'Students
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(LastNameLabel)
        Me.Controls.Add(Me.LastNameTextBox)
        Me.Controls.Add(FirstNameLabel)
        Me.Controls.Add(Me.FirstNameTextBox)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(StudentIDLabel)
        Me.Controls.Add(Me.StudentIDTextBox)
        Me.Controls.Add(Me.TblStudentsBindingNavigator)
        Me.Name = "Students"
        Me.Text = "Students"
        CType(Me.ScheduleDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblStudentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblStudentsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TblStudentsBindingNavigator.ResumeLayout(False)
        Me.TblStudentsBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ScheduleDataSet As ScheduleDataSet
    Friend WithEvents TblStudentsBindingSource As BindingSource
    Friend WithEvents TblStudentsTableAdapter As ScheduleDataSetTableAdapters.tblStudentsTableAdapter
    Friend WithEvents TableAdapterManager As ScheduleDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblStudentsBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents TblStudentsBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents LastNameTextBox As TextBox
    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents StudentIDTextBox As TextBox
End Class
