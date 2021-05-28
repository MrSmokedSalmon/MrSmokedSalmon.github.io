Public Class Form2
    Public X = Image.FromFile(Form1.path & "Images and Stuff\X.png")
    Public O = Image.FromFile(Form1.path & "Images and Stuff\O.png")

    Public CurImage As Image = X

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ColourPreview.Image = CurImage
    End Sub

    Private Sub Red_ValueChanged(sender As Object, e As EventArgs) Handles Red.ValueChanged
        ColourPreview.Image = ApplyFilter(CurImage, 255, Red.Value,
                                          Green.Value, Blue.Value,
                                          Passes.Value)
    End Sub

    Private Sub AppToBack_CheckedChanged(sender As Object, e As EventArgs) Handles AppToBack.CheckedChanged
        ColourPreview.Image = ApplyFilter(CurImage, 255, Red.Value,
                                          Green.Value, Blue.Value,
                                          Passes.Value)
    End Sub

    Private Sub Green_ValueChanged(sender As Object, e As EventArgs) Handles Green.ValueChanged
        ColourPreview.Image = ApplyFilter(CurImage, 255, Red.Value,
                                          Green.Value, Blue.Value,
                                          Passes.Value)
    End Sub

    Private Sub Blue_ValueChanged(sender As Object, e As EventArgs) Handles Blue.ValueChanged
        ColourPreview.Image = ApplyFilter(CurImage, 255, Red.Value,
                                          Green.Value, Blue.Value,
                                          Passes.Value)
    End Sub

    Private Sub Passes_ValueChanged(sender As Object, e As EventArgs) Handles Passes.ValueChanged
        ColourPreview.Image = ApplyFilter(CurImage, 255, Red.Value,
                                          Green.Value, Blue.Value,
                                          Passes.Value)
    End Sub

    Public Function ApplyFilter(Image As Bitmap, Alpha As Single,
                                Red As Single, Green As Single,
                                Blue As Single, Passes As Single)

        Dim r1 As Single
        Dim g1 As Single
        Dim b1 As Single

        Dim r2 As Single
        Dim g2 As Single
        Dim b2 As Single

        Dim Colour = Color.FromArgb(255, Red, Green, Blue)

        Dim Output = DirectCast(Image.Clone(), Bitmap)

        Dim y = 1
        While y < Image.Height
            Dim x = 1
            While x < Image.Width
                'MsgBox(x)
                If x >= Image.Width Then
                    MsgBox(x)
                End If
                r1 = Image.GetPixel(x, y).R / 255
                'MsgBox(Image.GetPixel(x, y).R / 255)
                g1 = Image.GetPixel(x, y).G / 255
                'MsgBox(Image.GetPixel(x, y).G / 255)
                b1 = Image.GetPixel(x, y).B / 255
                'MsgBox(Image.GetPixel(x, y).B / 255)

                r2 = Red / 255
                g2 = Green / 255
                b2 = Blue / 255

                Dim NRed As Integer = ((r1 * r2) * Passes) * 255
                If NRed > 255 Then
                    NRed = 255
                End If
                Dim NGreen As Integer = ((g1 * g2) * Passes) * 255
                If NGreen > 255 Then
                    NGreen = 255
                End If
                Dim NBlue As Integer = ((b1 * b2) * Passes) * 255
                If NBlue > 255 Then
                    NBlue = 255
                End If

                If AppToBack.Checked = True Then
                    Output.SetPixel(x, y, Color.FromArgb(255, NRed, NGreen, NBlue))
                Else
                    Output.SetPixel(x, y, Color.FromArgb(Image.GetPixel(x, y).A, NRed, NGreen, NBlue))
                End If

                x += 1
            End While
            y += 1
        End While

        Return Output
    End Function

    Private Sub Reset_Click(sender As Object, e As EventArgs) Handles Reset.Click
        Red.Value = 1
        Green.Value = 1
        Blue.Value = 1
        Passes.Value = 1

        ColourPreview.Image = X
    End Sub

    Private Sub Save_Click(sender As Object, e As EventArgs) Handles Save.Click
        If ImageSelect.SelectedItem = "X" Then
            Form1.AccessX = ColourPreview.Image
        ElseIf ImageSelect.SelectedItem = "O" Then
            Form1.AccessO = ColourPreview.Image
        End If
    End Sub

    Private Sub ImageSelect_SelectedValueChanged(sender As Object, e As EventArgs) Handles ImageSelect.TextChanged
        If ImageSelect.SelectedItem = "X" Then
            ColourPreview.Image = X
            CurImage = X
        ElseIf ImageSelect.SelectedItem = "O" Then
            ColourPreview.Image = O
            CurImage = O
        End If
    End Sub

    Private Sub HexApp_Click(sender As Object, e As EventArgs) Handles HexApp.Click
        Dim HexCode = HexCodeBox.Text
        Dim HexNums = "0123456789ABCDEF"

        Dim Red1 = HexCode.ElementAt(1)
        Dim Red16 = HexCode.ElementAt(0)
        Dim SetRed As Integer

        Dim Green1 = HexCode.ElementAt(3)
        Dim Green16 = HexCode.ElementAt(2)
        Dim SetGreen As Integer

        Dim Blue1 = HexCode.ElementAt(5)
        Dim Blue16 = HexCode.ElementAt(4)
        Dim SetBlue As Integer

        SetRed = (HexNums.IndexOf(Red16) * 16) + HexNums.IndexOf(Red1)
        SetGreen = (HexNums.IndexOf(Green16) * 16) + HexNums.IndexOf(Green1)
        SetBlue = (HexNums.IndexOf(Blue16) * 16) + HexNums.IndexOf(Blue1)

        Red.Value = SetRed
        Green.Value = SetGreen
        Blue.Value = SetBlue
    End Sub

    Private Sub HexRef_Click(sender As Object, e As EventArgs) Handles HexRef.Click
        Dim HexCode = ""
        If Red.Value < 16 Then
            HexCode = "0" & Hex(Red.Value)
        Else
            HexCode = Hex(Red.Value)
        End If
        If Red.Value < 16 Then
            HexCode = HexCode & "0" & Hex(Green.Value)
        Else
            HexCode = HexCode & Hex(Green.Value)
        End If
        If Red.Value < 16 Then
            HexCode = HexCode & "0" & Hex(Blue.Value)
        Else
            HexCode = HexCode & Hex(Blue.Value)
        End If
        HexCodeBox.Text = HexCode
    End Sub
End Class