Imports Accord.Vision.Detection
Imports Accord.Vision.Detection.Cascades
Imports AForge.Video
Imports AForge.Video.DirectShow
Imports System.IO
Imports System.Drawing.Imaging
Public Class UserControlLogin
    Dim w As Integer = 50
    Dim AMBILWEBCAM As PictureBox
    'Dim imgFrame As Image(Of Bgr, Byte) 'Dim vidCapture As Capture
    'Dim imgGray As Image(Of Gray, Byte) Dim pctwajah As PictureBox
    Dim gbr_Rata(,) As Double
    Dim gbrDipilih As Bitmap
    Dim AppIdleAMBILWEBCAM As Object
    Dim videoDevices As FilterInfoCollection
    Dim videosource As VideoCaptureDevice
    Dim TampilVideo As AForge.Controls.VideoSourcePlayer
    Dim Namafile As String = "JarBackPro.net"
    Dim idM, idS, idSdh As Integer
    Dim valM, valS, valSdh As Double
    Dim TMP_wajah, TMP_fitur As Bitmap
    Dim videosourceplayer1 As New AForge.Controls.VideoSourcePlayer
    Private Sub UserControlLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hidupkanWebcam(PctWebcamPeng, PctWajahPeng, videosourceplayer1)
        If File.Exists("ListUser") Then
            LoadListUser()
        Else
            _listUser = New listUser

        End If

    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        'matikanWebCam()
        Dim _pca As New PCA
        Dim listdata As New List(Of Image)
        For i As Integer = 0 To _listUser.getcount - 1
            _pca.adddata(_listUser.getlistuserimager(i),
            _listUser.getlistuser(i).Nama)
        Next

        Dim banding As String = _pca.bandingwajah(PctWajahPeng.Image)
        If banding.Split("|")(0) = "Login Diterima" Then

            MsgBox(banding.Split("|")(0) & " sebagai " & banding.Split("|")(1))

            username = banding.Split("|")(1)
            matikanWebCam()

            FormUtama.MenuUtama()

        Else

            MsgBox("Login Ditolak, Silahkan Coba Lagi")
        End If

    End Sub
    Private Sub IconButton1_Click_1(sender As Object, e As EventArgs) Handles IconButton1.Click
        matikanWebCam()
        FormUtama.Daftar()
    End Sub
    Sub matikanWebCam()
        RemoveHandler Application.Idle, AddressOf AppIdle
        AMBILWEBCAM = Nothing
        pctwajah = Nothing
        TampilVideo.SignalToStop()
        TampilVideo.WaitForStop()
        TampilVideo.Stop()

    End Sub
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
                If Not IsNothing(PctWajahPeng.Image) Then
                    TMP_wajah = New Bitmap(PctWajahPeng.Image)
                    Dim gbrKirim As Bitmap = pctwajah.Image
                End If
            Next
        Catch ex As Exception
            'TxtPesan.Text = "Error : " & (ex.Message)
        End Try
    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        FormLoginAlternatif.Show()
    End Sub
End Class
