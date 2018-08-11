Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Security.AccessControl

Public Class UserControlUtama
    Dim _Listfolder As ListFolder
    Sub kuncifolder(ByVal alamat As String)

        Dim perintah As String = "Attrib +s +h +r " & ListView1.SelectedItems(0).Text
        Shell(perintah)
        Dim fs As FileSystemSecurity = File.GetAccessControl(alamat)
        fs.AddAccessRule(New FileSystemAccessRule(Environment.UserName, FileSystemRights.FullControl, AccessControlType.Deny))
        File.SetAccessControl(alamat, fs)
    End Sub

    Sub bukakuncifolder(ByVal alamat As String)
        Dim fs As FileSystemSecurity = File.GetAccessControl(alamat)
        fs.RemoveAccessRule(New FileSystemAccessRule(Environment.UserName,FileSystemRights.FullControl, AccessControlType.Deny))
        File.SetAccessControl(alamat, fs)
        Dim perintah As String = "Attrib -s -h -r " & ListView1.SelectedItems(0).Text
        Shell(perintah)
    End Sub

    Private Sub UserControlUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If File.Exists("Listfolder") Then
            LoadListFolder()
            tampilkankeListview()
        Else
            _Listfolder = New ListFolder
        End If
    End Sub

    Private Sub ToolStrip3_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        If ListView1.SelectedItems().Count > 0 Then kuncifolder(ListView1.SelectedItems(0).Text)
        _Listfolder.setStatus(ListView1.SelectedItems(0).Index, "Terkunci")
        simpanListFolder()
        tampilkankeListview()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        If FolderBrowserDialog1.ShowDialog = DialogResult.OK Then
            ListView1.Items.Add(FolderBrowserDialog1.SelectedPath.ToString)
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add("Tidak Terkunci")
            _Listfolder.Tambah(FolderBrowserDialog1.SelectedPath.ToString, "Tidak Terkunci")
            If File.Exists("ListFolder") Then
                File.Delete("ListFolder")
            End If
            simpanListFolder()

        End If

    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        If Not ListView1.SelectedItems(0) Is Nothing Then
            _Listfolder.hapus(ListView1.SelectedItems(0).Index)
            simpanListFolder()
            tampilkankeListview()
        End If
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        If ListView1.SelectedItems().Count > 0 Then
            bukakuncifolder(ListView1.SelectedItems(0).Text)
            _Listfolder.setStatus(ListView1.SelectedItems(0).Index, "Tidak Terkunci ")
            simpanListFolder()
            tampilkankeListview()
        End If

    End Sub

    Sub simpanListFolder()
        If File.Exists(username) Then
            File.Delete(username)
        End If
        Dim FS As New FileStream(username, FileMode.Append)
        Dim BF As New BinaryFormatter
        BF.Serialize(FS, _Listfolder)
        FS.Close()
    End Sub
    Sub LoadListFolder()
        If File.Exists(username) Then
            Dim FS As New FileStream(username, FileMode.Open)
            Dim BF As New BinaryFormatter
            _Listfolder = BF.Deserialize(FS)
            FS.Close()
        Else
            _Listfolder = New ListFolder
        End If
    End Sub
    Sub tampilkankeListview()
        ListView1.Items.Clear()
        For i As Integer = 0 To _Listfolder.jumlah - 1
            ListView1.Items.Add(_Listfolder.getAlamat(i))
            ListView1.Items(ListView1.Items.Count -1).SubItems.Add(_Listfolder.getStatus(i))
        Next
    End Sub
End Class