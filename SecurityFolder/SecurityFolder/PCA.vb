Imports Accord.Math
Imports Accord.Math.Decompositions
Imports Accord.Statistics
Imports Accord.Statistics.Analysis
Imports Accord.Math.Comparers
Public Class PCA
    Structure Wajah
        Dim nama As String
        Dim matrikskovarian(,) As Double
        Dim finaldata(,) As Double
        Dim tmpi As Integer
    End Structure
    Dim data As New List(Of Wajah)
    Sub adddata(ByVal someface As List(Of Bitmap), ByVal nama As String)
        Dim matrikskov(,) As Double = converttoimgKov(someface)
        Dim mean() As Double = matrikskov.Mean()
        Dim dataadjust(,) As Double = matrikskov.Subtract(mean)
        Dim cov(,) As Double = dataadjust.Covariance()
        Dim evd = New EigenvalueDecomposition(cov)
        Dim eigenval() As Double = evd.RealEigenvalues
        Dim eigenvector(,) As Double = evd.Eigenvectors
        Dim urut(eigenvector.GetLength(1)) As Double
        Dim nilaimax(eigenvector.GetLength(1) - 1) As Double
        Dim max As Double = -100
        Dim tmpi As Integer = 0
        Dim sum As Double = 0
        For i As Integer = 0 To eigenvector.GetLength(1) - 1
            For j As Integer = 0 To eigenvector.GetLength(0) - 1
                Application.DoEvents()
                sum += Math.Round(eigenvector(j, i), 5)
            Next
            urut(i) = sum
            nilaimax(i) = sum
            sum = 0
        Next
        Array.Sort(nilaimax)
        For ii As Integer = 0 To nilaimax.Count - 1
            For iii As Integer = 0 To urut.Count - 1
                If urut(iii) = nilaimax(ii) Then
                    For j As Integer = 0 To eigenvector.GetLength(0) - 1
                        Dim tmp As Double
                        tmp = eigenvector(j, ii)
                        eigenvector(j, ii) = eigenvector(j, iii)
                        eigenvector(j, iii) = tmp
                    Next
                    Exit For
                End If
            Next
        Next
        'Dim eigenvectorbaru(eigenvector.GetLength(0) - 1, eigenvector.GetLength(1) - 1) As Double ComparerDirection.Descending)
        Dim finaldata(,) As Double = dataadjust.Multiply(eigenvector)
        For i As Integer = 0 To finaldata.GetLength(1) - 1
            For j As Integer = 0 To finaldata.GetLength(0) - 1
                Application.DoEvents()
                sum += Math.Round(finaldata(j, i), 5)
            Next
            If sum > max Then
                max = sum
                tmpi = i
            End If
            sum = 0
        Next
        Dim tmpdata As New Wajah
        tmpdata.matrikskovarian = matrikskov
        tmpdata.finaldata = finaldata
        tmpdata.nama = nama
        tmpdata.tmpi = tmpi
        data.Add(tmpdata)
    End Sub
    Function ambildata(ByVal index As Integer) As Wajah
        If index > data.Count - 1 Then
            Return New Wajah
        Else
            Return data(index)
        End If
    End Function
    Function getratavektor() As Double(,)
        Dim hasil(data(0).finaldata.GetLength(0) - 1, 0) As Double
        For j As Integer = 0 To data(0).finaldata.GetLength(0) - 1
            Dim rata As Double = 0
            For i As Integer = 0 To data.Count - 1
                Dim tmpi As Integer = data(i).tmpi
                rata += data(i).finaldata(j, tmpi)
            Next
            rata /= data.Count
            hasil(j, 0) = rata
        Next
        Return hasil
    End Function
    Function bandingwajah(ByVal WajahInputan As Bitmap) As String
    Dim hasil As String = ""
        WajahInputan = Citra.grayscale(Citra.resize(WajahInputan))
    Dim tmp2 As New List(Of Bitmap)
        tmp2.Add(WajahInputan)
    Dim matriks(,) As Double = converttoimgKov(tmp2)
    'kurangi dengan rata rata matriks
    Dim ratavektor(,) As Double = getratavektor()
    Dim matrikpengurangan(,) As Double = matriks.Subtract(ratavektor)
    'cari nilai eigen terkecil
    Dim min As Integer = 1000
    Dim stringhasil As String = ""
        For i As Integer = 0 To data.Count - 1
    Dim total As Double = 0

    Dim tmpi As Integer = data(i).tmpi
            For j As Integer = 0 To matriks.GetLength(1) - 1
                total += Math.Pow(matrikpengurangan(j, 0) - data(i).finaldata(j, tmpi), 2)
            Next
            total = Math.Sqrt(total)

            stringhasil &= total & "==" & data(i).nama & vbNewLine
            If total < min Then
                min = total
                hasil = data(i).nama
            End If
        Next
        Dim nilaiambang As Integer = 100
        If min < nilaiambang Then
            Return "Login Diterima|" & hasil
        Else
            Return "Login Di tolak"
        End If
        'Return hasil & min & vbNewLine & stringhasil End Function
    End Function
End Class
