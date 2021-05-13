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
    Public Board()() As Box = {
        New Box(2) {New Box, New Box, New Box},
        New Box(2) {New Box, New Box, New Box},
        New Box(2) {New Box, New Box, New Box}
    }

    'Monday 3/5/21
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim y = 1
        For Each i In Board
            Dim x = 1
            For Each k In i
                With k
                    .Size = New Size(112, 112)
                    .Location = New Point(107 + (118 * x), -80 + (118 * y))
                End With
                Controls.Add(k)
                x += 1
            Next
            y += 1
        Next

    End Sub

    'Wednesday 5/5/21
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For Each i In Board
            For Each k In i
                k.Text = ""
            Next
        Next
        Box.Tem = False
    End Sub
End Class

'Sunday 2/5/21
Public Class Box
    Inherits Button

    Public Shared Tem As Boolean

    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles Me.Click
        If (Me.Text = "") Then
            If Tem Then
                Me.Text = "O"
                Tem = False
            Else Tem = True
                Me.Text = "X"
            End If
            CheckWin()
        End If
    End Sub
    'Wednesday 5/5/21
    Public Shared Sub CheckWin()
        'Checks for any winstate of the middle Tile
        Dim y = 0
        For Each i In Form1.Board
            Dim x = 0
            For Each k In i
                If (x = 1 And y = 1) Then
                    Dim l = -1
                    While l <= 1
                        If (k.Text = "X" Or k.Text = "O") Then
                            'checks the winstates of the middle tile
                            If (Form1.Board(0)(l + 1).Text = k.Text And Form1.Board(2)((l * -1) + 1).Text = k.Text) Then
                                MsgBox("WIN")
                                Exit Sub
                            End If
                        End If
                        l += 1
                    End While
                    If (k.Text = "X" Or k.Text = "O") Then
                        If (Form1.Board(1)(0).Text = k.Text And Form1.Board(1)(2).Text = k.Text) Then
                            MsgBox("WIN")
                            Exit Sub
                        End If
                    End If
                End If
                x += 1
            Next
            y += 1
        Next

        If Form1.Board(0)(0).Text = "X" Or Form1.Board(0)(0).Text = "O" Then
            If ((Form1.Board(0)(0).Text = Form1.Board(0)(1).Text) And Form1.Board(0)(2).Text = Form1.Board(0)(1).Text) Then
                MsgBox("WIN")
                Exit Sub
            End If
            If ((Form1.Board(0)(0).Text = Form1.Board(1)(0).Text) And Form1.Board(2)(0).Text = Form1.Board(1)(0).Text) Then
                MsgBox("WIN")
                Exit Sub
            End If
        End If
        If (Form1.Board(2)(2).Text = "X" Or Form1.Board(2)(2).Text = "O") Then
            If ((Form1.Board(0)(2).Text = Form1.Board(1)(2).Text) And Form1.Board(2)(2).Text = Form1.Board(1)(2).Text) Then
                MsgBox("WIN")
                Exit Sub
            End If
            If ((Form1.Board(2)(0).Text = Form1.Board(2)(1).Text) And Form1.Board(2)(2).Text = Form1.Board(2)(1).Text) Then
                MsgBox("WIN")
                Exit Sub
            End If
        End If
    End Sub

    Public Sub Check()

    End Sub


End Class

Public Class AI
    Public Sub AnalyseBoard()
        Dim y = 0
        For Each i In Form1.Board
            Dim x = 0
            For Each k In i
                If (x = 1 And y = 1) Then
                    Dim l = -1
                    While l <= 1
                        If (k.Text = "X" Or k.Text = "O") Then
                            'checks the winstates of the middle tile
                            If (Form1.Board(0)(l + 1).Text = k.Text And Form1.Board(2)((l * -1) + 1).Text = k.Text) Then
                                MsgBox("WIN")
                                Exit Sub
                            End If
                        End If
                        l += 1
                    End While
                    If (k.Text = "X" Or k.Text = "O") Then
                        If (Form1.Board(1)(0).Text = k.Text And Form1.Board(1)(2).Text = k.Text) Then
                            MsgBox("WIN")
                            Exit Sub
                        End If
                    End If
                End If
                x += 1
            Next
            y += 1
        Next
    End Sub
End Class