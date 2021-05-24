Imports System.Runtime.CompilerServices

Public Module MyExtensions
    <Extension()>
    Public Sub Add(Of T)(ByRef arr As T(), item As T)
        Array.Resize(arr, arr.Length + 1)
        arr(arr.Length - 1) = item
    End Sub
End Module

Public Class Form1
    'Monday 3/5/21
    Public midGame = False
    Public Button As ResetButton = New ResetButton

    Public Board()() As Box = {
        New Box(2) {New Box, New Box, New Box},
        New Box(2) {New Box, New Box, New Box},
        New Box(2) {New Box, New Box, New Box}
    }

    'Monday 3/5/21
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetBoard()
    End Sub

    Public Sub SetBoard()
        Controls.Clear()

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
                    .Location = New Point(107 + (118 * x), -80 + (118 * y))
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
End Class

Public Class ResetButton
    Inherits Button

    '22/05/21
    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles Me.Click
        If (Form1.midGame = True) Then
            If (MsgBox("Are you sure you want to start a new game?", 4, "Are you sure?") = 6) Then
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

    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles Me.Click
        'Base for allowing more user customisation
        'Dim sp = "D:\School\Software Design and Development\Major Project\MrSmokedSalmon.github.io\WinFormsApp1\WinFormsApp1\Images and Stuff\X.png"

        If (Me.Tag = "") Then
            Form1.midGame = True
            If Tem Then
                Me.Tag = "O"
                Me.Image = WinFormsApp1.My.Resources.O
                Tem = False
            Else Tem = True
                Me.Tag = "X"
                Me.Image = WinFormsApp1.My.Resources.X
                If CheckWin() = True Then
                    EndGame(Form1.Board)
                    MsgBox("WIN sdhjabdjh")
                    Form1.midGame = False
                End If
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
                            If (Form1.Board(0)(l + 1).Tag = k.Tag And Form1.Board(2)((l * -1) + 1).Tag = k.Tag) Then
                                Return True
                                Exit Function
                            End If
                        End If
                        l += 1
                    End While
                    If (k.Tag = "X" Or k.Tag = "O") Then
                        If (Form1.Board(1)(0).Tag = k.Tag And Form1.Board(1)(2).Tag = k.Tag) Then
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