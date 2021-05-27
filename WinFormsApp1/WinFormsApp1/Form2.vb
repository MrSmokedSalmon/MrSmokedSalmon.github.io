Public Class Form2
    Public X = Image.FromFile(Form1.path & "Images and Stuff\X.png")
    Public O = Image.FromFile(Form1.path & "Images and Stuff\O.png")

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ColourPreview.Image = X
        Red.Value = 1
        Green.Value = 1
        Blue.Value = 1
    End Sub

    Public Sub UpdateColorValue()
        If Red.Value < 1 Or Green.Value < 1 Or Blue.Value < 1 Then

        Else
            ColourPreview.Image = ApplyFilter(ColourPreview.Image, 255, Red.Value,
                                          Green.Value, Blue.Value)
        End If

        'Color.FromArgb(255, Red.Value, Green.Value, Blue.Value)
    End Sub

    Private Sub Red_ValueChanged(sender As Object, e As EventArgs) Handles Red.ValueChanged
        UpdateColorValue()
    End Sub

    Private Sub Green_ValueChanged(sender As Object, e As EventArgs) Handles Green.ValueChanged
        UpdateColorValue()
    End Sub

    Private Sub Blue_ValueChanged(sender As Object, e As EventArgs) Handles Blue.ValueChanged
        UpdateColorValue()
    End Sub

    Public Function ApplyFilter(Image As Bitmap, Alpha As Single,
                                Red As Single, Green As Single,
                                Blue As Single)

        Dim x = 1
        Dim y = 1

        Dim r1 As Single
        Dim g1 As Single
        Dim b1 As Single

        Dim r2 As Single
        Dim g2 As Single
        Dim b2 As Single

        Dim Colour = Color.FromArgb(255, Red, Green, Blue)

        Dim Output = DirectCast(Image.Clone(), Bitmap)

        While y <= Image.Height
            While x <= Image.Width
                r1 = Image.GetPixel(x, y).R / 255
                'MsgBox(Image.GetPixel(x, y).R / 255)
                g1 = Image.GetPixel(x, y).G / 255
                'MsgBox(Image.GetPixel(x, y).G / 255)
                b1 = Image.GetPixel(x, y).B / 255
                'MsgBox(Image.GetPixel(x, y).B / 255)

                r2 = Red / 255
                g2 = Green / 255
                b2 = Blue / 255

                Output.SetPixel(x, y, Color.FromArgb(255, (r1 * r2) * 255, (g1 * g2) * 255, (b1 * b2) * 255))

                x += 1
            End While
            y += 1
        End While

        Return Output
    End Function
End Class