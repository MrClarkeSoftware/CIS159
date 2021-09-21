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
        'ScoreLabel
        '
        Me.ScoreLabel.AutoSize = True
        Me.ScoreLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ScoreLabel.Location = New System.Drawing.Point(36, 597)
        Me.ScoreLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ScoreLabel.Name = "ScoreLabel"
        Me.ScoreLabel.Size = New System.Drawing.Size(57, 20)
        Me.ScoreLabel.TabIndex = 11
        Me.ScoreLabel.Text = "Label1"
        '
        'B1
        '
        Me.B1.Image = Global.WindowsApp1.My.Resources.Resources.Bullet1
        Me.B1.Location = New System.Drawing.Point(684, 597)
        Me.B1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.B1.Name = "B1"
        Me.B1.Size = New System.Drawing.Size(33, 20)
        Me.B1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.B1.TabIndex = 12
        Me.B1.TabStop = False
        Me.B1.Tag = "B1"
        '
        'Ghost2
        '
        Me.Ghost2.Image = Global.WindowsApp1.My.Resources.Resources.ghost
        Me.Ghost2.Location = New System.Drawing.Point(60, 443)
        Me.Ghost2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Ghost2.Name = "Ghost2"
        Me.Ghost2.Size = New System.Drawing.Size(57, 57)
        Me.Ghost2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Ghost2.TabIndex = 10
        Me.Ghost2.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.WindowsApp1.My.Resources.Resources.wall
        Me.PictureBox4.Location = New System.Drawing.Point(36, 54)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(15, 471)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 9
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.WindowsApp1.My.Resources.Resources.wall
        Me.PictureBox3.Location = New System.Drawing.Point(728, 51)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(15, 471)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 8
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.WindowsApp1.My.Resources.Resources.wall
        Me.PictureBox2.Location = New System.Drawing.Point(36, 509)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(706, 15)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApp1.My.Resources.Resources.wall
        Me.PictureBox1.Location = New System.Drawing.Point(36, 51)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(706, 15)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Ghost1
        '
        Me.Ghost1.Image = Global.WindowsApp1.My.Resources.Resources.ghost
        Me.Ghost1.Location = New System.Drawing.Point(60, 443)
        Me.Ghost1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Ghost1.Name = "Ghost1"
        Me.Ghost1.Size = New System.Drawing.Size(57, 57)
        Me.Ghost1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Ghost1.TabIndex = 5
        Me.Ghost1.TabStop = False
        '
        'Wall2
        '
        Me.Wall2.Image = Global.WindowsApp1.My.Resources.Resources.wall
        Me.Wall2.Location = New System.Drawing.Point(262, 406)
        Me.Wall2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Wall2.Name = "Wall2"
        Me.Wall2.Size = New System.Drawing.Size(138, 22)
        Me.Wall2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Wall2.TabIndex = 4
        Me.Wall2.TabStop = False
        '
        'Wall4
        '
        Me.Wall4.Image = Global.WindowsApp1.My.Resources.Resources.wall
        Me.Wall4.Location = New System.Drawing.Point(492, 211)
        Me.Wall4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Wall4.Name = "Wall4"
        Me.Wall4.Size = New System.Drawing.Size(15, 217)
        Me.Wall4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Wall4.TabIndex = 3
        Me.Wall4.TabStop = False
        '
        'Wall3
        '
        Me.Wall3.Image = Global.WindowsApp1.My.Resources.Resources.wall
        Me.Wall3.Location = New System.Drawing.Point(369, 211)
        Me.Wall3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Wall3.Name = "Wall3"
        Me.Wall3.Size = New System.Drawing.Size(138, 22)
        Me.Wall3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Wall3.TabIndex = 2
        Me.Wall3.TabStop = False
        '
        'Wall1
        '
        Me.Wall1.Image = Global.WindowsApp1.My.Resources.Resources.wall
        Me.Wall1.Location = New System.Drawing.Point(262, 211)
        Me.Wall1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Wall1.Name = "Wall1"
        Me.Wall1.Size = New System.Drawing.Size(15, 217)
        Me.Wall1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Wall1.TabIndex = 1
        Me.Wall1.TabStop = False
        '
        'Avatar
        '
        Me.Avatar.BackColor = System.Drawing.Color.Transparent
        Me.Avatar.Image = Global.WindowsApp1.My.Resources.Resources.Pac1
        Me.Avatar.Location = New System.Drawing.Point(60, 371)
        Me.Avatar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Avatar.Name = "Avatar"
        Me.Avatar.Size = New System.Drawing.Size(57, 57)
        Me.Avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Avatar.TabIndex = 0
        Me.Avatar.TabStop = False
        Me.Avatar.Tag = "avatar"
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackgroundImage = Global.WindowsApp1.My.Resources.Resources.pokedownload
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1200, 692)
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
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.Text = "Sample"
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
    Friend WithEvents Timer2 As Timer
End Class
