﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.emailTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.StudentCheckBox = New System.Windows.Forms.CheckBox()
        Me.FirstButton = New System.Windows.Forms.Button()
        Me.LastButton = New System.Windows.Forms.Button()
        Me.PrevButton = New System.Windows.Forms.Button()
        Me.NextButton = New System.Windows.Forms.Button()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.fileTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name:"
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(87, 26)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NameTextBox.TabIndex = 1
        '
        'emailTextBox
        '
        Me.emailTextBox.Location = New System.Drawing.Point(87, 62)
        Me.emailTextBox.Name = "emailTextBox"
        Me.emailTextBox.Size = New System.Drawing.Size(100, 20)
        Me.emailTextBox.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Email:"
        '
        'StudentCheckBox
        '
        Me.StudentCheckBox.AutoSize = True
        Me.StudentCheckBox.Location = New System.Drawing.Point(87, 106)
        Me.StudentCheckBox.Name = "StudentCheckBox"
        Me.StudentCheckBox.Size = New System.Drawing.Size(63, 17)
        Me.StudentCheckBox.TabIndex = 4
        Me.StudentCheckBox.Text = "Student"
        Me.StudentCheckBox.UseVisualStyleBackColor = True
        '
        'FirstButton
        '
        Me.FirstButton.Location = New System.Drawing.Point(28, 147)
        Me.FirstButton.Name = "FirstButton"
        Me.FirstButton.Size = New System.Drawing.Size(75, 23)
        Me.FirstButton.TabIndex = 5
        Me.FirstButton.Text = "First"
        Me.FirstButton.UseVisualStyleBackColor = True
        '
        'LastButton
        '
        Me.LastButton.Location = New System.Drawing.Point(274, 147)
        Me.LastButton.Name = "LastButton"
        Me.LastButton.Size = New System.Drawing.Size(75, 23)
        Me.LastButton.TabIndex = 6
        Me.LastButton.Text = "Last"
        Me.LastButton.UseVisualStyleBackColor = True
        '
        'PrevButton
        '
        Me.PrevButton.Location = New System.Drawing.Point(109, 147)
        Me.PrevButton.Name = "PrevButton"
        Me.PrevButton.Size = New System.Drawing.Size(75, 23)
        Me.PrevButton.TabIndex = 7
        Me.PrevButton.Text = "Previous"
        Me.PrevButton.UseVisualStyleBackColor = True
        '
        'NextButton
        '
        Me.NextButton.Location = New System.Drawing.Point(193, 147)
        Me.NextButton.Name = "NextButton"
        Me.NextButton.Size = New System.Drawing.Size(75, 23)
        Me.NextButton.TabIndex = 8
        Me.NextButton.Text = "Next"
        Me.NextButton.UseVisualStyleBackColor = True
        '
        'AddButton
        '
        Me.AddButton.Location = New System.Drawing.Point(203, 100)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(75, 23)
        Me.AddButton.TabIndex = 9
        Me.AddButton.Text = "Add"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'SaveButton
        '
        Me.SaveButton.Location = New System.Drawing.Point(112, 197)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(75, 23)
        Me.SaveButton.TabIndex = 10
        Me.SaveButton.Text = "Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'fileTextBox
        '
        Me.fileTextBox.Location = New System.Drawing.Point(429, 25)
        Me.fileTextBox.Multiline = True
        Me.fileTextBox.Name = "fileTextBox"
        Me.fileTextBox.Size = New System.Drawing.Size(296, 279)
        Me.fileTextBox.TabIndex = 11
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(28, 197)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Read"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(367, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.fileTextBox)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.NextButton)
        Me.Controls.Add(Me.PrevButton)
        Me.Controls.Add(Me.LastButton)
        Me.Controls.Add(Me.FirstButton)
        Me.Controls.Add(Me.StudentCheckBox)
        Me.Controls.Add(Me.emailTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "FileStuff"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents emailTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents StudentCheckBox As CheckBox
    Friend WithEvents FirstButton As Button
    Friend WithEvents LastButton As Button
    Friend WithEvents PrevButton As Button
    Friend WithEvents NextButton As Button
    Friend WithEvents AddButton As Button
    Friend WithEvents SaveButton As Button
    Friend WithEvents fileTextBox As TextBox
    Friend WithEvents Button1 As Button
End Class
