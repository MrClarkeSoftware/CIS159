<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Subjects
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Subjects))
        Dim IDLabel As System.Windows.Forms.Label
        Dim SubjectNameLabel As System.Windows.Forms.Label
        Dim DualLabel As System.Windows.Forms.Label
        Me.ScheduleDataSet = New ScheduleApp.ScheduleDataSet()
        Me.TblSubjectsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblSubjectsTableAdapter = New ScheduleApp.ScheduleDataSetTableAdapters.tblSubjectsTableAdapter()
        Me.TableAdapterManager = New ScheduleApp.ScheduleDataSetTableAdapters.TableAdapterManager()
        Me.TblSubjectsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.TblSubjectsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.SubjectNameTextBox = New System.Windows.Forms.TextBox()
        Me.DualCheckBox = New System.Windows.Forms.CheckBox()
        IDLabel = New System.Windows.Forms.Label()
        SubjectNameLabel = New System.Windows.Forms.Label()
        DualLabel = New System.Windows.Forms.Label()
        CType(Me.ScheduleDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblSubjectsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblSubjectsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TblSubjectsBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'ScheduleDataSet
        '
        Me.ScheduleDataSet.DataSetName = "ScheduleDataSet"
        Me.ScheduleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblSubjectsBindingSource
        '
        Me.TblSubjectsBindingSource.DataMember = "tblSubjects"
        Me.TblSubjectsBindingSource.DataSource = Me.ScheduleDataSet
        '
        'TblSubjectsTableAdapter
        '
        Me.TblSubjectsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblPeriodsTableAdapter = Nothing
        Me.TableAdapterManager.tblRegistrationsTableAdapter = Nothing
        Me.TableAdapterManager.tblRoomsTableAdapter = Nothing
        Me.TableAdapterManager.tblStudentsTableAdapter = Nothing
        Me.TableAdapterManager.tblSubjectsTableAdapter = Me.TblSubjectsTableAdapter
        Me.TableAdapterManager.tblTeachersTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ScheduleApp.ScheduleDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblSubjectsBindingNavigator
        '
        Me.TblSubjectsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TblSubjectsBindingNavigator.BindingSource = Me.TblSubjectsBindingSource
        Me.TblSubjectsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TblSubjectsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TblSubjectsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TblSubjectsBindingNavigatorSaveItem})
        Me.TblSubjectsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TblSubjectsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TblSubjectsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TblSubjectsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TblSubjectsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TblSubjectsBindingNavigator.Name = "TblSubjectsBindingNavigator"
        Me.TblSubjectsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TblSubjectsBindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.TblSubjectsBindingNavigator.TabIndex = 0
        Me.TblSubjectsBindingNavigator.Text = "BindingNavigator1"
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
        'TblSubjectsBindingNavigatorSaveItem
        '
        Me.TblSubjectsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TblSubjectsBindingNavigatorSaveItem.Image = CType(resources.GetObject("TblSubjectsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TblSubjectsBindingNavigatorSaveItem.Name = "TblSubjectsBindingNavigatorSaveItem"
        Me.TblSubjectsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.TblSubjectsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(94, 66)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(21, 13)
        IDLabel.TabIndex = 1
        IDLabel.Text = "ID:"
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSubjectsBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(177, 63)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(104, 20)
        Me.IDTextBox.TabIndex = 2
        '
        'SubjectNameLabel
        '
        SubjectNameLabel.AutoSize = True
        SubjectNameLabel.Location = New System.Drawing.Point(94, 92)
        SubjectNameLabel.Name = "SubjectNameLabel"
        SubjectNameLabel.Size = New System.Drawing.Size(77, 13)
        SubjectNameLabel.TabIndex = 3
        SubjectNameLabel.Text = "Subject Name:"
        '
        'SubjectNameTextBox
        '
        Me.SubjectNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblSubjectsBindingSource, "SubjectName", True))
        Me.SubjectNameTextBox.Location = New System.Drawing.Point(177, 89)
        Me.SubjectNameTextBox.Name = "SubjectNameTextBox"
        Me.SubjectNameTextBox.Size = New System.Drawing.Size(104, 20)
        Me.SubjectNameTextBox.TabIndex = 4
        '
        'DualLabel
        '
        DualLabel.AutoSize = True
        DualLabel.Location = New System.Drawing.Point(94, 120)
        DualLabel.Name = "DualLabel"
        DualLabel.Size = New System.Drawing.Size(32, 13)
        DualLabel.TabIndex = 5
        DualLabel.Text = "Dual:"
        '
        'DualCheckBox
        '
        Me.DualCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.TblSubjectsBindingSource, "Dual", True))
        Me.DualCheckBox.Location = New System.Drawing.Point(177, 115)
        Me.DualCheckBox.Name = "DualCheckBox"
        Me.DualCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.DualCheckBox.TabIndex = 6
        Me.DualCheckBox.Text = "CheckBox1"
        Me.DualCheckBox.UseVisualStyleBackColor = True
        '
        'Subjects
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(SubjectNameLabel)
        Me.Controls.Add(Me.SubjectNameTextBox)
        Me.Controls.Add(DualLabel)
        Me.Controls.Add(Me.DualCheckBox)
        Me.Controls.Add(Me.TblSubjectsBindingNavigator)
        Me.Name = "Subjects"
        Me.Text = "Subjects"
        CType(Me.ScheduleDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblSubjectsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblSubjectsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TblSubjectsBindingNavigator.ResumeLayout(False)
        Me.TblSubjectsBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ScheduleDataSet As ScheduleDataSet
    Friend WithEvents TblSubjectsBindingSource As BindingSource
    Friend WithEvents TblSubjectsTableAdapter As ScheduleDataSetTableAdapters.tblSubjectsTableAdapter
    Friend WithEvents TableAdapterManager As ScheduleDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblSubjectsBindingNavigator As BindingNavigator
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
    Friend WithEvents TblSubjectsBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents SubjectNameTextBox As TextBox
    Friend WithEvents DualCheckBox As CheckBox
End Class
