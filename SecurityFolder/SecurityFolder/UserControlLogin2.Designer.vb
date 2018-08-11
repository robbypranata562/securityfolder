<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControlLogin2
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
        Me.IconButton3 = New FontAwesome.Sharp.IconButton()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.IconButton4 = New FontAwesome.Sharp.IconButton()
        CType(Me.PctWajahPeng, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctwajah, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PctWebcamPeng, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IconButton1
        '
        Me.IconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.Star
        Me.IconButton1.IconColor = System.Drawing.Color.Black
        Me.IconButton1.IconSize = 16
        Me.IconButton1.Location = New System.Drawing.Point(774, 544)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Rotation = 0.0R
        Me.IconButton1.Size = New System.Drawing.Size(75, 23)
        Me.IconButton1.TabIndex = 0
        Me.IconButton1.Text = "IconButton1"
        Me.IconButton1.UseVisualStyleBackColor = True
        '
        'PctWajahPeng
        '
        Me.PctWajahPeng.Location = New System.Drawing.Point(693, 12)
        Me.PctWajahPeng.Name = "PctWajahPeng"
        Me.PctWajahPeng.Size = New System.Drawing.Size(156, 132)
        Me.PctWajahPeng.TabIndex = 1
        Me.PctWajahPeng.TabStop = False
        '
        'pctwajah
        '
        Me.pctwajah.Location = New System.Drawing.Point(693, 150)
        Me.pctwajah.Name = "pctwajah"
        Me.pctwajah.Size = New System.Drawing.Size(156, 139)
        Me.pctwajah.TabIndex = 2
        Me.pctwajah.TabStop = False
        '
        'PctWebcamPeng
        '
        Me.PctWebcamPeng.Location = New System.Drawing.Point(8, 12)
        Me.PctWebcamPeng.Name = "PctWebcamPeng"
        Me.PctWebcamPeng.Size = New System.Drawing.Size(679, 412)
        Me.PctWebcamPeng.TabIndex = 3
        Me.PctWebcamPeng.TabStop = False
        '
        'IconButton2
        '
        Me.IconButton2.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton2.IconChar = FontAwesome.Sharp.IconChar.Star
        Me.IconButton2.IconColor = System.Drawing.Color.Black
        Me.IconButton2.IconSize = 16
        Me.IconButton2.Location = New System.Drawing.Point(693, 544)
        Me.IconButton2.Name = "IconButton2"
        Me.IconButton2.Rotation = 0.0R
        Me.IconButton2.Size = New System.Drawing.Size(75, 23)
        Me.IconButton2.TabIndex = 4
        Me.IconButton2.Text = "IconButton2"
        Me.IconButton2.UseVisualStyleBackColor = True
        '
        'IconButton3
        '
        Me.IconButton3.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton3.IconChar = FontAwesome.Sharp.IconChar.Star
        Me.IconButton3.IconColor = System.Drawing.Color.Black
        Me.IconButton3.IconSize = 16
        Me.IconButton3.Location = New System.Drawing.Point(612, 544)
        Me.IconButton3.Name = "IconButton3"
        Me.IconButton3.Rotation = 0.0R
        Me.IconButton3.Size = New System.Drawing.Size(75, 23)
        Me.IconButton3.TabIndex = 5
        Me.IconButton3.Text = "IconButton3"
        Me.IconButton3.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.Location = New System.Drawing.Point(693, 295)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(156, 129)
        Me.PictureBox3.TabIndex = 6
        Me.PictureBox3.TabStop = False
        '
        'IconButton4
        '
        Me.IconButton4.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.IconButton4.IconChar = FontAwesome.Sharp.IconChar.Star
        Me.IconButton4.IconColor = System.Drawing.Color.Black
        Me.IconButton4.IconSize = 16
        Me.IconButton4.Location = New System.Drawing.Point(531, 544)
        Me.IconButton4.Name = "IconButton4"
        Me.IconButton4.Rotation = 0.0R
        Me.IconButton4.Size = New System.Drawing.Size(75, 23)
        Me.IconButton4.TabIndex = 7
        Me.IconButton4.Text = "IconButton4"
        Me.IconButton4.UseVisualStyleBackColor = True
        '
        'UserControlLogin2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(861, 579)
        Me.Controls.Add(Me.IconButton4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.IconButton3)
        Me.Controls.Add(Me.IconButton2)
        Me.Controls.Add(Me.PctWebcamPeng)
        Me.Controls.Add(Me.pctwajah)
        Me.Controls.Add(Me.PctWajahPeng)
        Me.Controls.Add(Me.IconButton1)
        Me.Name = "UserControlLogin2"
        Me.Text = "UserControlLogin2"
        CType(Me.PctWajahPeng, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctwajah, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PctWebcamPeng, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents PctWajahPeng As System.Windows.Forms.PictureBox
    Friend WithEvents pctwajah As System.Windows.Forms.PictureBox
    Friend WithEvents PctWebcamPeng As System.Windows.Forms.PictureBox
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton3 As FontAwesome.Sharp.IconButton
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents IconButton4 As FontAwesome.Sharp.IconButton
End Class
