<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Registrations
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Registrations))
        Me.ScheduleDataSet = New ScheduleApp.ScheduleDataSet()
        Me.TblRegistrationsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblRegistrationsTableAdapter = New ScheduleApp.ScheduleDataSetTableAdapters.tblRegistrationsTableAdapter()
        Me.TableAdapterManager = New ScheduleApp.ScheduleDataSetTableAdapters.TableAdapterManager()
        Me.TblRegistrationsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.TblRegistrationsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.TblRegistrationsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TblStudentsTableAdapter = New ScheduleApp.ScheduleDataSetTableAdapters.tblStudentsTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.ScheduleDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblRegistrationsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblRegistrationsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TblRegistrationsBindingNavigator.SuspendLayout()
        CType(Me.TblRegistrationsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ScheduleDataSet
        '
        Me.ScheduleDataSet.DataSetName = "ScheduleDataSet"
        Me.ScheduleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblRegistrationsBindingSource
        '
        Me.TblRegistrationsBindingSource.DataMember = "tblRegistrations"
        Me.TblRegistrationsBindingSource.DataSource = Me.ScheduleDataSet
        '
        'TblRegistrationsTableAdapter
        '
        Me.TblRegistrationsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblPeriodsTableAdapter = Nothing
        Me.TableAdapterManager.tblRegistrationsTableAdapter = Me.TblRegistrationsTableAdapter
        Me.TableAdapterManager.tblRoomsTableAdapter = Nothing
        Me.TableAdapterManager.tblStudentsTableAdapter = Me.TblStudentsTableAdapter
        Me.TableAdapterManager.tblSubjectsTableAdapter = Nothing
        Me.TableAdapterManager.tblTeachersTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ScheduleApp.ScheduleDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblRegistrationsBindingNavigator
        '
        Me.TblRegistrationsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TblRegistrationsBindingNavigator.BindingSource = Me.TblRegistrationsBindingSource
        Me.TblRegistrationsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TblRegistrationsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TblRegistrationsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TblRegistrationsBindingNavigatorSaveItem})
        Me.TblRegistrationsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TblRegistrationsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TblRegistrationsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TblRegistrationsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TblRegistrationsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TblRegistrationsBindingNavigator.Name = "TblRegistrationsBindingNavigator"
        Me.TblRegistrationsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TblRegistrationsBindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.TblRegistrationsBindingNavigator.TabIndex = 0
        Me.TblRegistrationsBindingNavigator.Text = "BindingNavigator1"
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
        'TblRegistrationsBindingNavigatorSaveItem
        '
        Me.TblRegistrationsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TblRegistrationsBindingNavigatorSaveItem.Image = CType(resources.GetObject("TblRegistrationsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TblRegistrationsBindingNavigatorSaveItem.Name = "TblRegistrationsBindingNavigatorSaveItem"
        Me.TblRegistrationsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.TblRegistrationsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'TblRegistrationsDataGridView
        '
        Me.TblRegistrationsDataGridView.AutoGenerateColumns = False
        Me.TblRegistrationsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblRegistrationsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.TblRegistrationsDataGridView.DataSource = Me.TblRegistrationsBindingSource
        Me.TblRegistrationsDataGridView.Location = New System.Drawing.Point(69, 49)
        Me.TblRegistrationsDataGridView.Name = "TblRegistrationsDataGridView"
        Me.TblRegistrationsDataGridView.Size = New System.Drawing.Size(300, 220)
        Me.TblRegistrationsDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "StudentID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "StudentID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "ClassID"
        Me.DataGridViewTextBoxColumn3.HeaderText = "ClassID"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "PeriodID"
        Me.DataGridViewTextBoxColumn4.HeaderText = "PeriodID"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "TeacherID"
        Me.DataGridViewTextBoxColumn5.HeaderText = "TeacherID"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(435, 74)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 2
        '
        'TblStudentsTableAdapter
        '
        Me.TblStudentsTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(78, 346)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Registrations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TblRegistrationsDataGridView)
        Me.Controls.Add(Me.TblRegistrationsBindingNavigator)
        Me.Name = "Registrations"
        Me.Text = "Registrations"
        CType(Me.ScheduleDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblRegistrationsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblRegistrationsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TblRegistrationsBindingNavigator.ResumeLayout(False)
        Me.TblRegistrationsBindingNavigator.PerformLayout()
        CType(Me.TblRegistrationsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ScheduleDataSet As ScheduleDataSet
    Friend WithEvents TblRegistrationsBindingSource As BindingSource
    Friend WithEvents TblRegistrationsTableAdapter As ScheduleDataSetTableAdapters.tblRegistrationsTableAdapter
    Friend WithEvents TableAdapterManager As ScheduleDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblRegistrationsBindingNavigator As BindingNavigator
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
    Friend WithEvents TblRegistrationsBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents TblRegistrationsDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TblStudentsTableAdapter As ScheduleDataSetTableAdapters.tblStudentsTableAdapter
    Friend WithEvents Button1 As Button
End Class
