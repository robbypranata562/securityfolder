Public Class listUser
    <Serializable()>
    Structure ListUser
        Dim UID As String
        Dim Nama As String
        Dim password As String
        Dim gbr1 As Bitmap
        Dim gbr2 As Bitmap
        Dim gbr3 As Bitmap
    End Structure
    Dim _ListUser As List(Of ListUser)
    Sub New()
        _ListUser = New List(Of ListUser)
    End Sub

    Public Sub Tambah(ByVal UID As String, ByVal nama As String, ByVal password As String, ByVal gbr1 As Bitmap,
                       ByVal gbr2 As Bitmap, ByVal gbr3 As Bitmap)

        For Each A As ListUser In _ListUser
            If A.UID = UID Then
                MsgBox("UID Telah Terdaftar")
                Exit Sub
            End If
        Next
        Dim tmplistuser As ListUser
        tmplistuser.UID = UID
        tmplistuser.password = password
        tmplistuser.gbr1 = gbr1
        tmplistuser.gbr2 = gbr2
        tmplistuser.gbr3 = gbr3
        _ListUser.Add(tmplistuser)
        MessageBox.Show("Data Anda Telah Tersimpan")
    End Sub

    Function getlistuser(ByVal index As Integer) As ListUser
        Return _ListUser(index)
    End Function

    Function getlistuserimager(ByVal index As Integer) As List(Of Bitmap)
        Dim hasil As New List(Of Bitmap)
        Return hasil
    End Function
    Function getcount()
        Return _ListUser.Count
    End Function
End Class
