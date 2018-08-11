Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Module ModuleGlobal
    Public _listUser As listUser
    Public username As String

    Function cekFile(ByVal path As String, ByVal tampilpesan As Boolean, Optional pesan As String = "") As Boolean
        If System.IO.File.Exists(path) Then
            If Not pesan = "" Then
                MessageBox.Show(pesan, "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            Return True
        Else
            Return False
        End If
    End Function
    Function cekFolder(ByVal path As String, ByVal tampilpesan As Boolean, Optional pesan As String = "") As Boolean
        If System.IO.Directory.Exists(path) Then
            If Not pesan = "" Then
                MessageBox.Show(pesan, "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            Return True
        Else
            Return False
        End If
    End Function
    Sub simpan(ByVal path As String, ByVal data As Object)
        Dim FS As New FileStream(path, FileMode.Append)
        Dim BF As New BinaryFormatter
        BF.Serialize(FS, data)
        FS.Close()
        MessageBox.Show("Selesai Menyimpan")
    End Sub
    Public Sub simpanListUser()
        If File.Exists("ListUser") Then
            File.Delete("ListUser")
        End If
        Dim FS As New FileStream("ListUser", FileMode.Append)
        Dim BF As New BinaryFormatter
        BF.Serialize(FS, _listUser)
        FS.Close()
        MessageBox.Show("Selesai Menyimpan")
    End Sub
    Public Sub LoadListUser()
        Dim FS As New FileStream("ListUser", FileMode.Open)
        Dim BF As New BinaryFormatter
        _listUser = BF.Deserialize(FS)
        FS.Close()
    End Sub
End Module
