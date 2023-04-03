<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        components = New ComponentModel.Container()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        picPlayer = New PictureBox()
        picAir = New PictureBox()
        picGround = New PictureBox()
        tmrRight = New Timer(components)
        Timer1 = New Timer(components)
        Timer2 = New Timer(components)
        tmrUp = New Timer(components)
        tmrLeft = New Timer(components)
        tmrGameLogic = New Timer(components)
        tmrGravity = New Timer(components)
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        Label1 = New Label()
        scoreLabel = New Label()
        PictureBox4 = New PictureBox()
        PictureBox5 = New PictureBox()
        PictureBox6 = New PictureBox()
        PictureBox7 = New PictureBox()
        PictureBox8 = New PictureBox()
        CType(picPlayer, ComponentModel.ISupportInitialize).BeginInit()
        CType(picAir, ComponentModel.ISupportInitialize).BeginInit()
        CType(picGround, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' picPlayer
        ' 
        picPlayer.BackColor = Color.Transparent
        picPlayer.BackgroundImage = My.Resources.Resources.sky
        picPlayer.Image = CType(resources.GetObject("picPlayer.Image"), Image)
        picPlayer.Location = New Point(29, 357)
        picPlayer.Name = "picPlayer"
        picPlayer.Size = New Size(94, 97)
        picPlayer.SizeMode = PictureBoxSizeMode.StretchImage
        picPlayer.TabIndex = 0
        picPlayer.TabStop = False
        ' 
        ' picAir
        ' 
        picAir.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        picAir.Location = New Point(12, 11)
        picAir.Name = "picAir"
        picAir.Size = New Size(1184, 532)
        picAir.TabIndex = 1
        picAir.TabStop = False
        ' 
        ' picGround
        ' 
        picGround.BackColor = Color.FromArgb(CByte(128), CByte(64), CByte(64))
        picGround.Location = New Point(12, 549)
        picGround.Name = "picGround"
        picGround.Size = New Size(1184, 114)
        picGround.TabIndex = 2
        picGround.TabStop = False
        ' 
        ' tmrRight
        ' 
        ' 
        ' tmrUp
        ' 
        ' 
        ' tmrLeft
        ' 
        ' 
        ' tmrGameLogic
        ' 
        ' 
        ' tmrGravity
        ' 
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(196, 456)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(147, 32)
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        PictureBox1.Tag = "bound"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Location = New Point(465, 284)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(147, 32)
        PictureBox2.TabIndex = 4
        PictureBox2.TabStop = False
        PictureBox2.Tag = "bound"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Location = New Point(861, 314)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(147, 32)
        PictureBox3.TabIndex = 5
        PictureBox3.TabStop = False
        PictureBox3.Tag = "bound"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(59, 51)
        Label1.Name = "Label1"
        Label1.Size = New Size(64, 25)
        Label1.TabIndex = 6
        Label1.Text = "Points:"
        ' 
        ' scoreLabel
        ' 
        scoreLabel.AutoSize = True
        scoreLabel.Location = New Point(171, 54)
        scoreLabel.Name = "scoreLabel"
        scoreLabel.Size = New Size(63, 25)
        scoreLabel.TabIndex = 7
        scoreLabel.Text = "Label2"
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackColor = Color.Yellow
        PictureBox4.Location = New Point(258, 257)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(38, 37)
        PictureBox4.TabIndex = 8
        PictureBox4.TabStop = False
        PictureBox4.Tag = "coin"
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackColor = Color.Yellow
        PictureBox5.Location = New Point(465, 241)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(38, 37)
        PictureBox5.TabIndex = 9
        PictureBox5.TabStop = False
        PictureBox5.Tag = "coin"
        ' 
        ' PictureBox6
        ' 
        PictureBox6.BackColor = Color.Yellow
        PictureBox6.Location = New Point(29, 506)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(38, 37)
        PictureBox6.TabIndex = 10
        PictureBox6.TabStop = False
        PictureBox6.Tag = "coin"
        ' 
        ' PictureBox7
        ' 
        PictureBox7.BackColor = Color.Yellow
        PictureBox7.Location = New Point(196, 413)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(38, 37)
        PictureBox7.TabIndex = 11
        PictureBox7.TabStop = False
        PictureBox7.Tag = "coin"
        ' 
        ' PictureBox8
        ' 
        PictureBox8.BackColor = Color.Red
        PictureBox8.Location = New Point(394, 510)
        PictureBox8.Name = "PictureBox8"
        PictureBox8.Size = New Size(150, 75)
        PictureBox8.TabIndex = 12
        PictureBox8.TabStop = False
        PictureBox8.Tag = "gameover"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(192))
        ClientSize = New Size(1208, 675)
        Controls.Add(PictureBox8)
        Controls.Add(PictureBox7)
        Controls.Add(PictureBox6)
        Controls.Add(PictureBox5)
        Controls.Add(PictureBox4)
        Controls.Add(scoreLabel)
        Controls.Add(Label1)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(picPlayer)
        Controls.Add(picAir)
        Controls.Add(picGround)
        Name = "Form1"
        Text = "Form1"
        TransparencyKey = Color.Transparent
        CType(picPlayer, ComponentModel.ISupportInitialize).EndInit()
        CType(picAir, ComponentModel.ISupportInitialize).EndInit()
        CType(picGround, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents picPlayer As PictureBox
    Friend WithEvents picAir As PictureBox
    Friend WithEvents picGround As PictureBox
    Friend WithEvents tmrRight As Timer
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents tmrUp As Timer
    Friend WithEvents tmrLeft As Timer
    Friend WithEvents tmrGameLogic As Timer
    Friend WithEvents tmrGravity As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents scoreLabel As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
End Class
