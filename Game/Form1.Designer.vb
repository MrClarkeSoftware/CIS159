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
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ScoreLabel = New System.Windows.Forms.Label()
        Me.B3 = New System.Windows.Forms.PictureBox()
        Me.B2 = New System.Windows.Forms.PictureBox()
        Me.B1 = New System.Windows.Forms.PictureBox()
        Me.Ghost2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Ghost1 = New System.Windows.Forms.PictureBox()
        Me.Wall2 = New System.Windows.Forms.PictureBox()
        Me.Wall4 = New System.Windows.Forms.PictureBox()
        Me.Wall3 = New System.Windows.Forms.PictureBox()
        Me.Wall1 = New System.Windows.Forms.PictureBox()
        Me.Avatar = New System.Windows.Forms.PictureBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.B3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.B2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.B1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ghost2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ghost1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Wall2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Wall4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Wall3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Wall1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Avatar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'ScoreLabel
        '
        Me.ScoreLabel.AutoSize = True
        Me.ScoreLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ScoreLabel.Location = New System.Drawing.Point(24, 388)
        Me.ScoreLabel.Name = "ScoreLabel"
        Me.ScoreLabel.Size = New System.Drawing.Size(39, 13)
        Me.ScoreLabel.TabIndex = 11
        Me.ScoreLabel.Text = "Label1"
        '
        'B3
        '
        Me.B3.Image = Global.WindowsApp1.My.Resources.Resources.Bullet
        Me.B3.Location = New System.Drawing.Point(600, 388)
        Me.B3.Name = "B3"
        Me.B3.Size = New System.Drawing.Size(18, 10)
        Me.B3.TabIndex = 14
        Me.B3.TabStop = False
        '
        'B2
        '
        Me.B2.Image = Global.WindowsApp1.My.Resources.Resources.Bullet
        Me.B2.Location = New System.Drawing.Point(527, 391)
        Me.B2.Name = "B2"
        Me.B2.Size = New System.Drawing.Size(18, 10)
        Me.B2.TabIndex = 13
        Me.B2.TabStop = False
        '
        'B1
        '
        Me.B1.Image = Global.WindowsApp1.My.Resources.Resources.Bullet1
        Me.B1.Location = New System.Drawing.Point(456, 388)
        Me.B1.Name = "B1"
        Me.B1.Size = New System.Drawing.Size(22, 13)
        Me.B1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.B1.TabIndex = 12
        Me.B1.TabStop = False
        '
        'Ghost2
        '
        Me.Ghost2.Image = Global.WindowsApp1.My.Resources.Resources.ghost
        Me.Ghost2.Location = New System.Drawing.Point(40, 288)
        Me.Ghost2.Name = "Ghost2"
        Me.Ghost2.Size = New System.Drawing.Size(38, 37)
        Me.Ghost2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Ghost2.TabIndex = 10
        Me.Ghost2.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.WindowsApp1.My.Resources.Resources.wall
        Me.PictureBox4.Location = New System.Drawing.Point(24, 35)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(10, 306)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 9
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.WindowsApp1.My.Resources.Resources.wall
        Me.PictureBox3.Location = New System.Drawing.Point(485, 33)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(10, 306)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 8
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.WindowsApp1.My.Resources.Resources.wall
        Me.PictureBox2.Location = New System.Drawing.Point(24, 331)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(471, 10)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApp1.My.Resources.Resources.wall
        Me.PictureBox1.Location = New System.Drawing.Point(24, 33)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(471, 10)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Ghost1
        '
        Me.Ghost1.Image = Global.WindowsApp1.My.Resources.Resources.ghost
        Me.Ghost1.Location = New System.Drawing.Point(40, 288)
        Me.Ghost1.Name = "Ghost1"
        Me.Ghost1.Size = New System.Drawing.Size(38, 37)
        Me.Ghost1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Ghost1.TabIndex = 5
        Me.Ghost1.TabStop = False
        '
        'Wall2
        '
        Me.Wall2.Image = Global.WindowsApp1.My.Resources.Resources.wall
        Me.Wall2.Location = New System.Drawing.Point(175, 264)
        Me.Wall2.Name = "Wall2"
        Me.Wall2.Size = New System.Drawing.Size(92, 14)
        Me.Wall2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Wall2.TabIndex = 4
        Me.Wall2.TabStop = False
        '
        'Wall4
        '
        Me.Wall4.Image = Global.WindowsApp1.My.Resources.Resources.wall
        Me.Wall4.Location = New System.Drawing.Point(328, 137)
        Me.Wall4.Name = "Wall4"
        Me.Wall4.Size = New System.Drawing.Size(10, 141)
        Me.Wall4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Wall4.TabIndex = 3
        Me.Wall4.TabStop = False
        '
        'Wall3
        '
        Me.Wall3.Image = Global.WindowsApp1.My.Resources.Resources.wall
        Me.Wall3.Location = New System.Drawing.Point(246, 137)
        Me.Wall3.Name = "Wall3"
        Me.Wall3.Size = New System.Drawing.Size(92, 14)
        Me.Wall3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Wall3.TabIndex = 2
        Me.Wall3.TabStop = False
        '
        'Wall1
        '
        Me.Wall1.Image = Global.WindowsApp1.My.Resources.Resources.wall
        Me.Wall1.Location = New System.Drawing.Point(175, 137)
        Me.Wall1.Name = "Wall1"
        Me.Wall1.Size = New System.Drawing.Size(10, 141)
        Me.Wall1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Wall1.TabIndex = 1
        Me.Wall1.TabStop = False
        '
        'Avatar
        '
        Me.Avatar.Image = Global.WindowsApp1.My.Resources.Resources.Pac1
        Me.Avatar.Location = New System.Drawing.Point(40, 241)
        Me.Avatar.Name = "Avatar"
        Me.Avatar.Size = New System.Drawing.Size(38, 37)
        Me.Avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Avatar.TabIndex = 0
        Me.Avatar.TabStop = False
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.B3)
        Me.Controls.Add(Me.B2)
        Me.Controls.Add(Me.B1)
        Me.Controls.Add(Me.ScoreLabel)
        Me.Controls.Add(Me.Ghost2)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Ghost1)
        Me.Controls.Add(Me.Wall2)
        Me.Controls.Add(Me.Wall4)
        Me.Controls.Add(Me.Wall3)
        Me.Controls.Add(Me.Wall1)
        Me.Controls.Add(Me.Avatar)
        Me.Name = "Form1"
        Me.Text = "Sample"
        CType(Me.B3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.B2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.B1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ghost2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ghost1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Wall2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Wall4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Wall3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Wall1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Avatar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Avatar As PictureBox
    Friend WithEvents Wall1 As PictureBox
    Friend WithEvents Wall3 As PictureBox
    Friend WithEvents Wall4 As PictureBox
    Friend WithEvents Wall2 As PictureBox
    Friend WithEvents Ghost1 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Ghost2 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ScoreLabel As Label
    Friend WithEvents B1 As PictureBox
    Friend WithEvents B2 As PictureBox
    Friend WithEvents B3 As PictureBox
    Friend WithEvents Timer2 As Timer
End Class
