Imports Accord.Vision.Detection
Imports Accord.Vision.Detection.Cascades
Imports AForge.Video
Imports AForge.Video.DirectShow
Imports System.IO
Imports AForge
Imports System.Drawing.Imaging
Imports System.Runtime.Serialization.Formatters.Binary

Public Class UserControlDaftar
    Dim w As Integer = 50
    Dim AMBILWEBCAM As PictureBox
    'Dim imgFrame As Image(Of Bgr, Byte) 'Dim vidCapture As Capture
    'Dim imgGray As Image(Of Gray, Byte)
    Dim pctwajah As PictureBox
    Dim gbr_Rata(,) As Double
    Dim gbrDipilih As Bitmap
    Dim AppIdleAMBILWEBCAM As Object
    Dim videoDevices As FilterInfoCollection
    Dim videosource As VideoCaptureDevice
    Dim TampilVideo As AForge.Controls.VideoSourcePlayer
    Dim idM, idS, idSdh As Integer
    Dim valM, valS, valSdh As Double
    Dim TMP_wajah, TMP_fitur As Bitmap
    Dim videosourceplayer1 As New AForge.Controls.VideoSourcePlayer
    Dim _PctWajah() As PictureBox
    Dim pctwajahpeng As PictureBox = New PictureBox
    Dim indexgbr As Integer = 0
    Sub hidupkanWebcam(Tmp As PictureBox, TmpWajah As PictureBox, player As AForge.Controls.VideoSourcePlayer)
        Try

            AMBILWEBCAM = Tmp
            pctwajah = TmpWajah
            TampilVideo = player
            videoDevices = New FilterInfoCollection(FilterCategory.VideoInputDevice)
            videosource = New VideoCaptureDevice(videoDevices(0).MonikerString)
            TampilVideo.SignalToStop()
            TampilVideo.WaitForStop()
            TampilVideo.VideoSource = videosource
            TampilVideo.Start()
            AddHandler Application.Idle, AddressOf AppIdle
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

    End Sub
    Sub matikanWebCam()
        RemoveHandler Application.Idle, AddressOf AppIdle
        AMBILWEBCAM = Nothing
        pctwajah = Nothing
        TampilVideo.SignalToStop()
        TampilVideo.WaitForStop()
        TampilVideo.Stop()
    End Sub
    Public Sub AppIdle(ByVal sender As System.Object, ByVal e As System.EventArgs)

        AMBILWEBCAM.Image = TampilVideo.GetCurrentVideoFrame
        Try
            Dim detector As HaarObjectDetector
            Dim cascade As New FaceHaarCascade
            detector = New HaarObjectDetector(cascade, 30)
            detector.SearchMode = ObjectDetectorSearchMode.Average
            detector.ScalingFactor = 1.5
            detector.ScalingMode = ObjectDetectorScalingMode.GreaterToSmaller
            detector.UseParallelProcessing = True
            detector.Suppression = 3
            Dim faceObjects As Rectangle() = detector.ProcessFrame(AMBILWEBCAM.Image)
            Dim g As Graphics = Graphics.FromImage(AMBILWEBCAM.Image)
            For Each face In faceObjects
                Dim CropImage = New Bitmap(face.Width, face.Height)
                Using grp = Graphics.FromImage(CropImage)
                    grp.DrawImage(AMBILWEBCAM.Image, New Rectangle(0, 0, face.Width, face.Height), face, GraphicsUnit.Pixel)
                End Using
                pctwajah.Image = CropImage
                g.DrawRectangle(Pens.Red, face)
                If Not IsNothing(pctwajahpeng.Image) Then
                    TMP_wajah = New Bitmap(pctwajahpeng.Image)
                    Dim gbrKirim As Bitmap = pctwajah.Image
                End If
            Next
        Catch ex As Exception
            'TxtPesan.Text = "Error : " & (ex.Message)
        End Try
    End Sub

    Private Sub UserControlDaftar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReDim _PctWajah(2)
        _PctWajah(0) = PictureBoxWajah1
        _PctWajah(1) = PictureBoxWajah2
        _PctWajah(2) = PictureBoxWajah3
        hidupkanWebcam(PictureBoxWebcam, pctwajahpeng, videosourceplayer1)
        If File.Exists("ListUser") Then
            LoadListUser()
        Else
            _listUser = New listUser
        End If
    End Sub
    Private Sub btncapture_Click(sender As Object, e As EventArgs) Handles btncapture.Click
        If Not IsNothing(pctwajahpeng.Image) And indexgbr < 3 Then
            _PctWajah(indexgbr).Image = pctwajahpeng.Image
            indexgbr += 1
        End If
    End Sub
    Private Sub btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        If Not TextBoxSandi.Text = TextBoxSandiUlang.Text Then
            MessageBox.Show("Password dan konfirmasi tidak sama", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf (indexgbr < 3) Then
            MessageBox.Show("Anda Belum Memasukkan 3 inputan wajah anda")
        ElseIf (TextBoxNama.Text = "" Or TextBoxSandi.Text = "" Or TextBoxUID.Text = "") Then
            MessageBox.Show("Semua field wajib di isi")
        Else
            _listUser.Tambah(TextBoxUID.Text, TextBoxNama.Text, TextBoxSandi.Text, PictureBoxWajah1.Image, PictureBoxWajah2.Image, PictureBoxWajah3.Image)
            simpanListUser()
        End If
    End Sub

    Private Sub btnkembali_Click(sender As Object, e As EventArgs) Handles btnkembali.Click
        matikanWebCam()
        FormUtama.MenuLogin()
    End Sub
End Class