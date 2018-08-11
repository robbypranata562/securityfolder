Public Class FormUtama

    Public Sub MenuUtama()
        Dim UCUtama As New UserControlUtama
        PanelControl.Controls.RemoveAt(0)
        PanelControl.Controls.Add(UCUtama)
    End Sub

    Public Sub MenuLogin()
        Dim UCUtama As New UserControlUtama
        PanelControl.Controls.RemoveAt(0)
        PanelControl.Controls.Add(UCUtama)
    End Sub

    Public Sub Daftar()
        Dim UCUtama As New UserControlUtama
        PanelControl.Controls.RemoveAt(0)
        PanelControl.Controls.Add(UCUtama)
    End Sub

    Public Sub Profil()
        Dim UCUtama As New UserControlUtama
        PanelControl.Controls.RemoveAt(0)
        PanelControl.Controls.Add(UCUtama)
    End Sub


    Private Sub FormUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim UCLogin As New UserControlLogin2
        UCLogin.TopLevel = False
        PanelControl.Controls.Add(UCLogin)
    End Sub
End Class
