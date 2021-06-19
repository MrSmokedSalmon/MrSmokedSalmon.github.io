Imports System.Runtime.CompilerServices

Public Module MyExtensions
    <Extension()>
    Public Sub Add(Of T)(ByRef arr As T(), item As T)
        Array.Resize(arr, arr.Length + 1)
        arr(arr.Length - 1) = item
    End Sub

    <Extension()>
    Function RemoveAt(Of T)(ByVal arr As T(), ByVal index As Integer) As T()
        Dim uBound = arr.GetUpperBound(0)
        Dim lBound = arr.GetLowerBound(0)
        Dim arrLen = uBound - lBound

        If index < lBound OrElse index > uBound Then
            Throw New ArgumentOutOfRangeException(
            String.Format("Index must be from {0} to {1}.", lBound, uBound))

        Else
            'create an array 1 element less than the input array
            Dim outArr(arrLen - 1) As T
            'copy the first part of the input array
            Array.Copy(arr, 0, outArr, 0, index)
            'then copy the second part of the input array
            Array.Copy(arr, index + 1, outArr, index, uBound - index)

            Return outArr
        End If
    End Function
End Module

Public Class Form1
    Public midGame = False

    Public path As String = (My.Application.Info.DirectoryPath).Replace("Builds\net5.0-windows", "")

    Public AccessX As Image = WinFormsApp1.My.Resources.X
    Public AccessO As Image = WinFormsApp1.My.Resources.O

    'Declaring Objects
    Public Button = New ResetButton

    '2D Jagged array that acts as the board
    Public Board()() As Box = {
        New Box(2) {New Box, New Box, New Box},
        New Box(2) {New Box, New Box, New Box},
        New Box(2) {New Box, New Box, New Box}
    }

    ' For Colours
    Public X = Image.FromFile(path & "\Images and Stuff\X.png")
    Public O = Image.FromFile(path & "\Images and Stuff\O.png")
    Public CurImage As Image = X
    Public Colours4Buttons() As Color = {
        Color.White,
        Color.Black,
        Color.Red,
        Color.Green,
        Color.Blue,
        Color.Yellow,
        Color.Orange,
        Color.Pink,
        Color.Purple,
        Color.Brown
    }



    'Monday 3/5/21
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetBoard()
        ColourPreview.Image = CurImage
        Timer1.Start()
    End Sub

    Public Sub SetBoard()
        'Controls.Clear()

        Dim y = 1
        '22/05/21
        With Button
            .Size = New Size(70, 264)
            .Location = New Point(37, 93)
            .Text = "Reset Board"
        End With
        Controls.Add(Button)

        For Each i In Board
            Dim x = 1
            For Each k In i
                With k
                    .Size = New Size(112, 112)
                    .Location = New Point(17 + (118 * x), -80 + (118 * y))
                    .Image = WinFormsApp1.My.Resources.Blank
                End With
                Controls.Add(k)
                x += 1
            Next
            y += 1
        Next

    End Sub

    '22/05/21
    Public Sub Reset()
        For Each i In Board
            For Each k In i
                k.Tag = ""
                k.Image = WinFormsApp1.My.Resources.Blank
            Next
        Next
        Box.Tem = False
        midGame = False
    End Sub

    ' For Colours
    Private Overloads Sub Update()
        ColourPreview.Image = ApplyFilter(CurImage, 255, Red.Value,
                                          Green.Value, Blue.Value,
                                          Passes.Value)
    End Sub

    ' For Colours
    Private Sub AppToBack_CheckedChanged(sender As Object, e As EventArgs) Handles AppToBack.CheckedChanged
        Update()
    End Sub

    ' For Colours
    ' This function is credited to 
    Public Function ApplyFilter(Image As Bitmap, Alpha As Single,
                                Red As Single, Green As Single,
                                Blue As Single, Passes As Single)

        Dim Background As Color = Color.FromArgb(0, 255, 255, 255)

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
                    If Image.GetPixel(x, y) = Background Then
                        Output.SetPixel(x, y, Color.FromArgb(155, NRed, NGreen, NBlue))
                    Else
                        Output.SetPixel(x, y, Color.FromArgb(255, NRed, NGreen, NBlue))
                    End If
                Else
                        Output.SetPixel(x, y, Color.FromArgb(Image.GetPixel(x, y).A, NRed, NGreen, NBlue))
                End If

                x += 1
            End While
            y += 1
        End While

        Return Output
    End Function

    ' For Colours
    Private Sub Save_Click(sender As Object, e As EventArgs) Handles Save.Click
        If ImageSelect.SelectedItem = "X" Then
            AccessX = ColourPreview.Image
        ElseIf ImageSelect.SelectedItem = "O" Then
            AccessO = ColourPreview.Image
        End If
    End Sub

    ' For Colours
    Private Sub ImageSelect_SelectedValueChanged(sender As Object, e As EventArgs) Handles ImageSelect.TextChanged
        If ImageSelect.SelectedItem = "X" Then
            ColourPreview.Image = X
            CurImage = X
        ElseIf ImageSelect.SelectedItem = "O" Then
            ColourPreview.Image = O
            CurImage = O
        End If
    End Sub

    ' For Colours
    Private Sub HexApp_Click(sender As Object, e As EventArgs) Handles HexApp.Click
        Dim HexCode = HexCodeBox.Text
        Dim HexNums = "0123456789ABCDEF"

        Dim Red1 = Char.ToUpper(HexCode.ElementAt(1))
        Dim Red16 = Char.ToUpper(HexCode.ElementAt(0))
        Dim SetRed As Integer

        Dim Green1 = Char.ToUpper(HexCode.ElementAt(3))
        Dim Green16 = Char.ToUpper(HexCode.ElementAt(2))
        Dim SetGreen As Integer

        Dim Blue1 = Char.ToUpper(HexCode.ElementAt(5))
        Dim Blue16 = Char.ToUpper(HexCode.ElementAt(4))
        Dim SetBlue As Integer

        SetRed = (HexNums.IndexOf(Red16) * 16) + HexNums.IndexOf(Red1)
        SetGreen = (HexNums.IndexOf(Green16) * 16) + HexNums.IndexOf(Green1)
        SetBlue = (HexNums.IndexOf(Blue16) * 16) + HexNums.IndexOf(Blue1)

        Red.Value = SetRed
        Green.Value = SetGreen
        Blue.Value = SetBlue
    End Sub

    ' For Colours
    Private Sub HexRef_Click(sender As Object, e As EventArgs) Handles HexRef.Click
        Dim HexCode As String
        If Red.Value < 16 Then
            HexCode = "0" & Hex(Red.Value)
        Else
            HexCode = Hex(Red.Value)
        End If
        If Green.Value < 16 Then
            HexCode = HexCode & "0" & Hex(Green.Value)
        Else
            HexCode = HexCode & Hex(Green.Value)
        End If
        If Blue.Value < 16 Then
            HexCode = HexCode & "0" & Hex(Blue.Value)
        Else
            HexCode = HexCode & Hex(Blue.Value)
        End If
        HexCodeBox.Text = HexCode
    End Sub

    ' For Colours
    Private Sub Reeset_Click(sender As Object, e As EventArgs) Handles Reeset.Click
        Red.Value = 1
        Green.Value = 1
        Blue.Value = 1
        Passes.Value = 1

        ColourPreview.Image = X
    End Sub

    ' For Colours
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Update()

        Red.Value = TrackBar1.Value
        Green.Value = TrackBar2.Value
        Blue.Value = TrackBar3.Value
        Passes.Value = TrackBar4.Value
    End Sub

    Private Sub White_Click(sender As Object, e As EventArgs) Handles White.Click
        TrackBar1.Value = 255
        TrackBar2.Value = 255
        TrackBar3.Value = 255
        TrackBar4.Value = 1
    End Sub

    Private Sub Black_Click(sender As Object, e As EventArgs) Handles Black.Click
        TrackBar1.Value = 95
        TrackBar2.Value = 95
        TrackBar3.Value = 95
        TrackBar4.Value = 1
    End Sub

    Private Sub Red1_Click(sender As Object, e As EventArgs) Handles Red1.Click
        TrackBar1.Value = 255
        TrackBar2.Value = 30
        TrackBar3.Value = 45
        TrackBar4.Value = 1
    End Sub

    Private Sub Green1_Click(sender As Object, e As EventArgs) Handles Green1.Click
        TrackBar1.Value = 35
        TrackBar2.Value = 255
        TrackBar3.Value = 65
        TrackBar4.Value = 1
    End Sub

    Private Sub Blue1_Click(sender As Object, e As EventArgs) Handles Blue1.Click
        TrackBar1.Value = 20
        TrackBar2.Value = 130
        TrackBar3.Value = 255
        TrackBar4.Value = 1
    End Sub

    Private Sub Yellow_Click(sender As Object, e As EventArgs) Handles Yellow.Click
        TrackBar1.Value = 255
        TrackBar2.Value = 245
        TrackBar3.Value = 20
        TrackBar4.Value = 1
    End Sub

    Private Sub Orange_Click(sender As Object, e As EventArgs) Handles Orange.Click
        TrackBar1.Value = 255
        TrackBar2.Value = 95
        TrackBar3.Value = 1
        TrackBar4.Value = 2
    End Sub

    Private Sub Pink_Click(sender As Object, e As EventArgs) Handles Pink.Click
        TrackBar1.Value = 195
        TrackBar2.Value = 60
        TrackBar3.Value = 160
        TrackBar4.Value = 2
    End Sub

    Private Sub Purple_Click(sender As Object, e As EventArgs) Handles Purple.Click
        TrackBar1.Value = 195
        TrackBar2.Value = 60
        TrackBar3.Value = 160
        TrackBar4.Value = 1
    End Sub

    Private Sub Brown_Click(sender As Object, e As EventArgs) Handles Brown.Click
        TrackBar1.Value = 255
        TrackBar2.Value = 175
        TrackBar3.Value = 110
        TrackBar4.Value = 1
    End Sub
End Class

Public Class ResetButton
    Inherits Button

    '22/05/21
    Public Sub Button1_Click(sender As Object,
                             e As EventArgs) Handles Me.Click
        If (Form1.midGame = True) Then
            If (MsgBox("Are you sure you want to start a new game?",
                       4, "Are you sure?") = 6) Then
                Form1.Reset()
            End If
        Else
            Form1.Reset()
        End If
    End Sub
End Class

'Sunday 2/5/21
Public Class Box
    Inherits Button

    Public Shared Tem As Boolean

    Public Sub Button1_Click(sender As Object,
                             e As EventArgs) Handles Me.Click
        'I have got a base for allowing more user customisation (commented out

        If (Me.Tag = "") Then
            Form1.midGame = True
            If Tem Then
                Me.Tag = "O"
                Me.Image = Form1.AccessO
                'Me.Image = Image.FromFile(Form1.path & sp & "\O.png")
                Tem = False
            Else Tem = True
                Me.Tag = "X"
                Me.Image = Form1.AccessX
                'Me.Image = Image.FromFile(Form1.path & sp & "\X.png")
            End If
            If CheckWin() = True Then
                EndGame(Form1.Board)
                MsgBox("WIN")
                Form1.midGame = False
            End If
            Dim x As Integer
            For Each i In Form1.Board
                For Each k In i
                    If k.Tag = "X" Or k.Tag = "O" Then
                        x += 1
                    End If
                Next
            Next
            If x = 9 Then
                MsgBox("TIE")
                Form1.midGame = False
            End If
        End If
    End Sub

    Public Shared Sub EndGame(k As Box()())
        For Each i In k
            For Each n In i
                n.Tag = "."
            Next
        Next
    End Sub

    'Wednesday 5/5/21
    Public Shared Function CheckWin()
        'Checks for any winstate of the middle Tile
        Dim y = 0
        For Each i In Form1.Board
            Dim x = 0
            For Each k In i
                If (x = 1 And y = 1) Then
                    Dim l = -1
                    While l <= 1
                        If (k.Tag = "X" Or k.Tag = "O") Then
                            'checks the winstates of the middle tile
                            If Form1.Board(0)(l + 1).Tag = k.Tag And Form1.Board(2)((l * -1) + 1).Tag = k.Tag Then
                                Return True
                                Exit Function
                            End If
                        End If
                        l += 1
                    End While
                    If (k.Tag = "X" Or k.Tag = "O") Then
                        If Form1.Board(1)(0).Tag = k.Tag And Form1.Board(1)(2).Tag = k.Tag Then
                            Return True
                            Exit Function
                        End If
                    End If
                End If
                x += 1
            Next
            y += 1
        Next

        'Beefy code that is hard to read
        'Would want to make this into a function or a sub routine
        If Form1.Board(0)(0).Tag = "X" Or Form1.Board(0)(0).Tag = "O" Then
            If ((Form1.Board(0)(0).Tag = Form1.Board(0)(1).Tag) And Form1.Board(0)(2).Tag = Form1.Board(0)(1).Tag) Then
                Return True
                Exit Function
            End If
            If ((Form1.Board(0)(0).Tag = Form1.Board(1)(0).Tag) And Form1.Board(2)(0).Tag = Form1.Board(1)(0).Tag) Then
                Return True
                Exit Function
            End If
        End If
        If (Form1.Board(2)(2).Tag = "X" Or Form1.Board(2)(2).Tag = "O") Then
            If ((Form1.Board(0)(2).Tag = Form1.Board(1)(2).Tag) And Form1.Board(2)(2).Tag = Form1.Board(1)(2).Tag) Then
                Return True
                Exit Function
            End If
            If ((Form1.Board(2)(0).Tag = Form1.Board(2)(1).Tag) And Form1.Board(2)(2).Tag = Form1.Board(2)(1).Tag) Then
                Return True
                Exit Function
            End If
        End If
        Return False
    End Function
End Class