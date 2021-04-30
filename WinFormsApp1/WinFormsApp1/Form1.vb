Imports System.Runtime.CompilerServices

Public Module MyExtensions
    <Extension()>
    Public Sub Add(Of T)(ByRef arr As T(), item As T)
        Array.Resize(arr, arr.Length + 1)
        arr(arr.Length - 1) = item
    End Sub
End Module

Public Class Form1
    Public Board()() As Box = {
        New Box(2) {New Box, New Box, New Box},
        New Box(2) {New Box, New Box, New Box},
        New Box(2) {New Box, New Box, New Box}
    }

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim y = 1
        For Each i In Board
            Dim x = 1
            For Each k In i
                With k
                    .Size = New Size(112, 112)
                    .Location = New Point(107 + (118 * x), -80 + (118 * y))
                    .Team = ""
                End With
                Controls.Add(k)
                x += 1
            Next
            y += 1
        Next

    End Sub
End Class

Public Class Box
    Inherits Button

    Public Shared Tem As Boolean

    Private teem As String

    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles Me.Click
        If Tem Then
            Me.Text = "O"
            Tem = False
        Else Tem = True
            Me.Text = "X"
        End If
        Check()
    End Sub

    Public Sub Check()
        Dim y = 0
        For Each i In Form1.Board
            Dim x = 0
            For Each k In i
                If (k.Location.X = 343 And k.Location.Y = 156) Then
                    If (Form1.Board(y - 1)(x - 1).Text = k.Text And Form1.Board(y + 1)(x + 1).Text = k.Text) Then
                        MsgBox("Win")
                    End If
                End If
                x += 1
                'MsgBox(x)
            Next
            y += 1
            'MsgBox(y)
        Next
    End Sub

    Public Property Team As String
        Get
            Return teem
        End Get
        Set(ByVal value As String)
            teem = value
        End Set
    End Property
End Class
