Imports Accord.Imaging
Module Citra
    Function grayscale(ByVal img As Bitmap) As Bitmap
        Dim filter As AForge.Imaging.Filters.Grayscale = New AForge.Imaging.Filters.Grayscale(0.2125, 0.7154, 0.0721)
        Dim grayimg As Bitmap = filter.Apply(img)
        Return grayimg
    End Function
    Function resize(ByVal img As Bitmap) As Bitmap
        Dim filter As AForge.Imaging.Filters.ResizeBilinear = New AForge.Imaging.Filters.ResizeBilinear(30, 30)
        Dim newimg As Bitmap = filter.Apply(img)
        Return newimg
    End Function
    Function threshold(ByVal img As Bitmap) As Bitmap
        Dim filter As AForge.Imaging.Filters.Threshold = New AForge.Imaging.Filters.Threshold(100)
        Dim newimg As Bitmap = filter.Apply(img)
        Return newimg
    End Function

    Function prapengolahan(ByVal img As Bitmap) As Bitmap
        Return threshold(grayscale(resize(img)))
    End Function
    Function imgTovector(ByVal img As Bitmap) As Double()
        Dim hasil(img.Width * img.Height) As Double
        Dim pos As Integer = 0
        For i As Integer = 0 To img.Height - 1
            For j As Integer = 0 To img.Width - 1
                hasil(pos) = img.GetPixel(i, j).R
            Next
        Next
        Return hasil
    End Function
    Function converttoimgKov(ByVal img As List(Of Bitmap)) As Double(,)
        Dim hasil(img(0).Width * img(0).Height, img.Count - 1) As Double
        For i As Integer = 0 To img.Count - 1
            Dim tmpvektor() As Double = imgTovector(img(i))
            For j As Integer = 0 To tmpvektor.Length - 1
                hasil(j, i) = tmpvektor(j)
            Next
        Next
        Return hasil
    End Function
End Module
