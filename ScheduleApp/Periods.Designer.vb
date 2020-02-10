<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Periods
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Periods))
        Dim IDLabel As System.Windows.Forms.Label
        Dim PeriodNumberLabel As System.Windows.Forms.Label
        Dim ClassTimeLabel As System.Windows.Forms.Label
        Me.ScheduleDataSet = New ScheduleApp.ScheduleDataSet()
        Me.TblPeriodsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblPeriodsTableAdapter = New ScheduleApp.ScheduleDataSetTableAdapters.tblPeriodsTableAdapter()
        Me.TableAdapterManager = New ScheduleApp.ScheduleDataSetTableAdapters.TableAdapterManager()
        Me.TblPeriodsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.TblPeriodsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.PeriodNumberTextBox = New System.Windows.Forms.TextBox()
        Me.ClassTimeTextBox = New System.Windows.Forms.TextBox()
        IDLabel = New System.Windows.Forms.Label()
        PeriodNumberLabel = New System.Windows.Forms.Label()
        ClassTimeLabel = New System.Windows.Forms.Label()
        CType(Me.ScheduleDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblPeriodsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblPeriodsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TblPeriodsBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'ScheduleDataSet
        '
        Me.ScheduleDataSet.DataSetName = "ScheduleDataSet"
        Me.ScheduleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblPeriodsBindingSource
        '
        Me.TblPeriodsBindingSource.DataMember = "tblPeriods"
        Me.TblPeriodsBindingSource.DataSource = Me.ScheduleDataSet
        '
        'TblPeriodsTableAdapter
        '
        Me.TblPeriodsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblPeriodsTableAdapter = Me.TblPeriodsTableAdapter
        Me.TableAdapterManager.tblRegistrationsTableAdapter = Nothing
        Me.TableAdapterManager.tblRoomsTableAdapter = Nothing
        Me.TableAdapterManager.tblStudentsTableAdapter = Nothing
        Me.TableAdapterManager.tblSubjectsTableAdapter = Nothing
        Me.TableAdapterManager.tblTeachersTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ScheduleApp.ScheduleDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblPeriodsBindingNavigator
        '
        Me.TblPeriodsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TblPeriodsBindingNavigator.BindingSource = Me.TblPeriodsBindingSource
        Me.TblPeriodsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TblPeriodsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TblPeriodsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TblPeriodsBindingNavigatorSaveItem})
        Me.TblPeriodsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TblPeriodsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TblPeriodsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TblPeriodsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TblPeriodsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TblPeriodsBindingNavigator.Name = "TblPeriodsBindingNavigator"
        Me.TblPeriodsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TblPeriodsBindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.TblPeriodsBindingNavigator.TabIndex = 0
        Me.TblPeriodsBindingNavigator.Text = "BindingNavigator1"
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
        'TblPeriodsBindingNavigatorSaveItem
        '
        Me.TblPeriodsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TblPeriodsBindingNavigatorSaveItem.Image = CType(resources.GetObject("TblPeriodsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TblPeriodsBindingNavigatorSaveItem.Name = "TblPeriodsBindingNavigatorSaveItem"
        Me.TblPeriodsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.TblPeriodsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(73, 40)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(21, 13)
        IDLabel.TabIndex = 1
        IDLabel.Text = "ID:"
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblPeriodsBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(159, 37)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IDTextBox.TabIndex = 2
        '
        'PeriodNumberLabel
        '
        PeriodNumberLabel.AutoSize = True
        PeriodNumberLabel.Location = New System.Drawing.Point(73, 66)
        PeriodNumberLabel.Name = "PeriodNumberLabel"
        PeriodNumberLabel.Size = New System.Drawing.Size(80, 13)
        PeriodNumberLabel.TabIndex = 3
        PeriodNumberLabel.Text = "Period Number:"
        '
        'PeriodNumberTextBox
        '
        Me.PeriodNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblPeriodsBindingSource, "PeriodNumber", True))
        Me.PeriodNumberTextBox.Location = New System.Drawing.Point(159, 63)
        Me.PeriodNumberTextBox.Name = "PeriodNumberTextBox"
        Me.PeriodNumberTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PeriodNumberTextBox.TabIndex = 4
        '
        'ClassTimeLabel
        '
        ClassTimeLabel.AutoSize = True
        ClassTimeLabel.Location = New System.Drawing.Point(73, 92)
        ClassTimeLabel.Name = "ClassTimeLabel"
        ClassTimeLabel.Size = New System.Drawing.Size(61, 13)
        ClassTimeLabel.TabIndex = 5
        ClassTimeLabel.Text = "Class Time:"
        '
        'ClassTimeTextBox
        '
        Me.ClassTimeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblPeriodsBindingSource, "ClassTime", True))
        Me.ClassTimeTextBox.Location = New System.Drawing.Point(159, 89)
        Me.ClassTimeTextBox.Name = "ClassTimeTextBox"
        Me.ClassTimeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ClassTimeTextBox.TabIndex = 6
        '
        'Periods
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(PeriodNumberLabel)
        Me.Controls.Add(Me.PeriodNumberTextBox)
        Me.Controls.Add(ClassTimeLabel)
        Me.Controls.Add(Me.ClassTimeTextBox)
        Me.Controls.Add(Me.TblPeriodsBindingNavigator)
        Me.Name = "Periods"
        Me.Text = "Periods"
        CType(Me.ScheduleDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblPeriodsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblPeriodsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TblPeriodsBindingNavigator.ResumeLayout(False)
        Me.TblPeriodsBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ScheduleDataSet As ScheduleDataSet
    Friend WithEvents TblPeriodsBindingSource As BindingSource
    Friend WithEvents TblPeriodsTableAdapter As ScheduleDataSetTableAdapters.tblPeriodsTableAdapter
    Friend WithEvents TableAdapterManager As ScheduleDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblPeriodsBindingNavigator As BindingNavigator
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
    Friend WithEvents TblPeriodsBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents PeriodNumberTextBox As TextBox
    Friend WithEvents ClassTimeTextBox As TextBox
End Class
