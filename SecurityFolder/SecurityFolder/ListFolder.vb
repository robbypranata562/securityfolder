Public Class ListFolder
    <Serializable()>
    Structure ListFolder
        Dim AlamatFolder As String
        Dim Status As String
    End Structure

    Dim _ListFolder As List(Of ListFolder)
    Sub New()
        _ListFolder = New List(Of ListFolder)
    End Sub
    Sub hapus(ByVal index As Integer)
        If _ListFolder.Count - 1 = 0 Then
            MessageBox.Show("Tidak Ada Folder di dalam daftar")
        Else
            _ListFolder.Remove(_ListFolder(index))
        End If
    End Sub

    Public Sub Tambah(ByVal alamatfolder As String, ByVal status As String)
        For Each A As ListFolder In _ListFolder

            If A.AlamatFolder = alamatfolder Then
                MsgBox("Folder Telah ada dalam Daftar!")
                Exit Sub
            End If
        Next
        Dim TmpListfolder As ListFolder
        TmpListfolder.AlamatFolder = alamatfolder
        TmpListfolder.Status = status
        _ListFolder.Add(TmpListfolder)
    End Sub

    Function getAlamat(ByVal index As Integer) As String
        If index < 0 Then
            Return "Tidak Ada"
        Else
            Return _ListFolder(index).AlamatFolder
        End If
    End Function
    Function jumlah() As Integer
        Return _ListFolder.Count
    End Function

    Function getStatus(ByVal index As Integer) As String
        If index < 0 Or _ListFolder.Count = 0 Then
            Return "Tidak Ada"
        Else
            Return _ListFolder(index).Status
        End If
    End Function
    Sub setAlamat(ByVal index As Integer, ByVal alamat As String)
        If index < 0 Then
            MsgBox("Tidak Ada")
        Else
            Dim tmpList As ListFolder
            tmpList.AlamatFolder = alamat
            tmpList.Status = _ListFolder(index).Status
            _ListFolder(index) = tmpList
        End If
    End Sub
    Sub setStatus(ByVal index As Integer, ByVal status As String)
        If index < 0 Then
            MsgBox("Tidak Ada")
        Else
            Dim tmpList As ListFolder
            tmpList.AlamatFolder = _ListFolder(index).AlamatFolder
            tmpList.Status = status
            _ListFolder(index) = tmpList
        End If
    End Sub
End Class
