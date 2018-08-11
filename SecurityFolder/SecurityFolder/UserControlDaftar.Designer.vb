<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControlDaftar
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
        Me.btncapture = New FontAwesome.Sharp.IconButton()
        Me.btnsimpan = New FontAwesome.Sharp.IconButton()
        Me.TextBoxUID = New System.Windows.Forms.TextBox()
        Me.TextBoxSandi = New System.Windows.Forms.TextBox()
        Me.TextBoxSandiUlang = New System.Windows.Forms.TextBox()
        Me.TextBoxNama = New System.Windows.Forms.TextBox()
        Me.PictureBoxWajah1 = New System.Windows.Forms.PictureBox()
        Me.PictureBoxWajah2 = New System.Windows.Forms.PictureBox()
        Me.PictureBoxWajah3 = New System.Windows.Forms.PictureBox()
        Me.PictureBoxWebcam = New System.Windows.Forms.PictureBox()
        Me.btnkembali = New FontAwesome.Sharp.IconButton()
        CType(Me.PictureBoxWajah1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxWajah2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxWajah3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxWebcam, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btncapture
        '
        Me.btncapture.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btncapture.IconChar = FontAwesome.Sharp.IconChar.Star
        Me.btncapture.IconColor = System.Drawing.Color.Black
        Me.btncapture.IconSize = 16
        Me.btncapture.Location = New System.Drawing.Point(13, 461)
        Me.btncapture.Name = "btncapture"
        Me.btncapture.Rotation = 0.0R
        Me.btncapture.Size = New System.Drawing.Size(75, 23)
        Me.btncapture.TabIndex = 0
        Me.btncapture.Text = "IconButton1"
        Me.btncapture.UseVisualStyleBackColor = True
        '
        'btnsimpan
        '
        Me.btnsimpan.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnsimpan.IconChar = FontAwesome.Sharp.IconChar.Star
        Me.btnsimpan.IconColor = System.Drawing.Color.Black
        Me.btnsimpan.IconSize = 16
        Me.btnsimpan.Location = New System.Drawing.Point(95, 461)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Rotation = 0.0R
        Me.btnsimpan.Size = New System.Drawing.Size(75, 23)
        Me.btnsimpan.TabIndex = 1
        Me.btnsimpan.Text = "IconButton1"
        Me.btnsimpan.UseVisualStyleBackColor = True
        '
        'TextBoxUID
        '
        Me.TextBoxUID.Location = New System.Drawing.Point(514, 12)
        Me.TextBoxUID.Name = "TextBoxUID"
        Me.TextBoxUID.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxUID.TabIndex = 2
        '
        'TextBoxSandi
        '
        Me.TextBoxSandi.Location = New System.Drawing.Point(514, 64)
        Me.TextBoxSandi.Name = "TextBoxSandi"
        Me.TextBoxSandi.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxSandi.TabIndex = 3
        '
        'TextBoxSandiUlang
        '
        Me.TextBoxSandiUlang.Location = New System.Drawing.Point(514, 90)
        Me.TextBoxSandiUlang.Name = "TextBoxSandiUlang"
        Me.TextBoxSandiUlang.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxSandiUlang.TabIndex = 4
        '
        'TextBoxNama
        '
        Me.TextBoxNama.Location = New System.Drawing.Point(513, 38)
        Me.TextBoxNama.Name = "TextBoxNama"
        Me.TextBoxNama.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxNama.TabIndex = 5
        '
        'PictureBoxWajah1
        '
        Me.PictureBoxWajah1.Location = New System.Drawing.Point(408, 12)
        Me.PictureBoxWajah1.Name = "PictureBoxWajah1"
        Me.PictureBoxWajah1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBoxWajah1.TabIndex = 6
        Me.PictureBoxWajah1.TabStop = False
        '
        'PictureBoxWajah2
        '
        Me.PictureBoxWajah2.Location = New System.Drawing.Point(408, 68)
        Me.PictureBoxWajah2.Name = "PictureBoxWajah2"
        Me.PictureBoxWajah2.Size = New System.Drawing.Size(100, 50)
        Me.PictureBoxWajah2.TabIndex = 7
        Me.PictureBoxWajah2.TabStop = False
        '
        'PictureBoxWajah3
        '
        Me.PictureBoxWajah3.Location = New System.Drawing.Point(408, 124)
        Me.PictureBoxWajah3.Name = "PictureBoxWajah3"
        Me.PictureBoxWajah3.Size = New System.Drawing.Size(100, 50)
        Me.PictureBoxWajah3.TabIndex = 8
        Me.PictureBoxWajah3.TabStop = False
        '
        'PictureBoxWebcam
        '
        Me.PictureBoxWebcam.Location = New System.Drawing.Point(13, 25)
        Me.PictureBoxWebcam.Name = "PictureBoxWebcam"
        Me.PictureBoxWebcam.Size = New System.Drawing.Size(133, 117)
        Me.PictureBoxWebcam.TabIndex = 9
        Me.PictureBoxWebcam.TabStop = False
        '
        'btnkembali
        '
        Me.btnkembali.Flip = FontAwesome.Sharp.FlipOrientation.Normal
        Me.btnkembali.IconChar = FontAwesome.Sharp.IconChar.Star
        Me.btnkembali.IconColor = System.Drawing.Color.Black
        Me.btnkembali.IconSize = 16
        Me.btnkembali.Location = New System.Drawing.Point(176, 461)
        Me.btnkembali.Name = "btnkembali"
        Me.btnkembali.Rotation = 0.0R
        Me.btnkembali.Size = New System.Drawing.Size(75, 23)
        Me.btnkembali.TabIndex = 10
        Me.btnkembali.Text = "IconButton1"
        Me.btnkembali.UseVisualStyleBackColor = True
        '
        'UserControlDaftar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(626, 496)
        Me.Controls.Add(Me.btnkembali)
        Me.Controls.Add(Me.PictureBoxWebcam)
        Me.Controls.Add(Me.PictureBoxWajah3)
        Me.Controls.Add(Me.PictureBoxWajah2)
        Me.Controls.Add(Me.PictureBoxWajah1)
        Me.Controls.Add(Me.TextBoxNama)
        Me.Controls.Add(Me.TextBoxSandiUlang)
        Me.Controls.Add(Me.TextBoxSandi)
        Me.Controls.Add(Me.TextBoxUID)
        Me.Controls.Add(Me.btnsimpan)
        Me.Controls.Add(Me.btncapture)
        Me.Name = "UserControlDaftar"
        Me.Text = "Registration"
        CType(Me.PictureBoxWajah1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxWajah2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxWajah3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxWebcam, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btncapture As FontAwesome.Sharp.IconButton
    Friend WithEvents btnsimpan As FontAwesome.Sharp.IconButton
    Friend WithEvents TextBoxUID As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxSandi As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxSandiUlang As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxNama As System.Windows.Forms.TextBox
    Friend WithEvents PictureBoxWajah1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBoxWajah2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBoxWajah3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBoxWebcam As System.Windows.Forms.PictureBox
    Friend WithEvents btnkembali As FontAwesome.Sharp.IconButton
End Class
