<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControlLogin
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
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.PctWajahPeng = New System.Windows.Forms.PictureBox()
        Me.pctwajah = New System.Windows.Forms.PictureBox()
        Me.PctWebcamPeng = New System.Windows.Forms.PictureBox()
        Me.IconButton2 = New FontAwesome.Sharp.IconButton()
        CType(Me.PctWajahPeng, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctwajah, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PctWebcamPeng, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IconButton1
        '
        Me.IconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.Star
        Me.IconButton1.IconColor = System.Drawing.Color.Black
        Me.IconButton1.IconSize = 16
        Me.IconButton1.Location = New System.Drawing.Point(581, 424)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Rotation = 0.0R
        Me.IconButton1.Size = New System.Drawing.Size(75, 23)
        Me.IconButton1.TabIndex = 0
        Me.IconButton1.Text = "IconButton1"
        Me.IconButton1.UseVisualStyleBackColor = True
        '
        'PctWajahPeng
        '
        Me.PctWajahPeng.Location = New System.Drawing.Point(13, 13)
        Me.PctWajahPeng.Name = "PctWajahPeng"
        Me.PctWajahPeng.Size = New System.Drawing.Size(100, 50)
        Me.PctWajahPeng.TabIndex = 1
        Me.PctWajahPeng.TabStop = False
        '
        'pctwajah
        '
        Me.pctwajah.Location = New System.Drawing.Point(13, 70)
        Me.pctwajah.Name = "pctwajah"
        Me.pctwajah.Size = New System.Drawing.Size(100, 50)
        Me.pctwajah.TabIndex = 2
        Me.pctwajah.TabStop = False
        '
        'PctWebcamPeng
        '
        Me.PctWebcamPeng.Location = New System.Drawing.Point(120, 13)
        Me.PctWebcamPeng.Name = "PctWebcamPeng"
        Me.PctWebcamPeng.Size = New System.Drawing.Size(100, 50)
        Me.PctWebcamPeng.TabIndex = 3
        Me.PctWebcamPeng.TabStop = False
        '
        'IconButton2
        '
        Me.IconButton2.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton2.IconChar = FontAwesome.Sharp.IconChar.Star
        Me.IconButton2.IconColor = System.Drawing.Color.Black
        Me.IconButton2.IconSize = 16
        Me.IconButton2.Location = New System.Drawing.Point(500, 424)
        Me.IconButton2.Name = "IconButton2"
        Me.IconButton2.Rotation = 0.0R
        Me.IconButton2.Size = New System.Drawing.Size(75, 23)
        Me.IconButton2.TabIndex = 4
        Me.IconButton2.Text = "IconButton2"
        Me.IconButton2.UseVisualStyleBackColor = True
        '
        'UserControlLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(668, 459)
        Me.Controls.Add(Me.IconButton2)
        Me.Controls.Add(Me.PctWebcamPeng)
        Me.Controls.Add(Me.pctwajah)
        Me.Controls.Add(Me.PctWajahPeng)
        Me.Controls.Add(Me.IconButton1)
        Me.Name = "UserControlLogin"
        Me.Text = "UserControlLogin"
        CType(Me.PctWajahPeng, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctwajah, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PctWebcamPeng, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents PctWajahPeng As System.Windows.Forms.PictureBox
    Friend WithEvents pctwajah As System.Windows.Forms.PictureBox
    Friend WithEvents PctWebcamPeng As System.Windows.Forms.PictureBox
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
End Class
