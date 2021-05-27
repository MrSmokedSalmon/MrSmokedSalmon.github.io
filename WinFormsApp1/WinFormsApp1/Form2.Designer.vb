<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ColourPreview = New System.Windows.Forms.Button()
        Me.Red = New System.Windows.Forms.NumericUpDown()
        Me.Green = New System.Windows.Forms.NumericUpDown()
        Me.Blue = New System.Windows.Forms.NumericUpDown()
        CType(Me.Red, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Green, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Blue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ColourPreview
        '
        Me.ColourPreview.BackColor = System.Drawing.SystemColors.Control
        Me.ColourPreview.Location = New System.Drawing.Point(12, 101)
        Me.ColourPreview.Name = "ColourPreview"
        Me.ColourPreview.Size = New System.Drawing.Size(121, 121)
        Me.ColourPreview.TabIndex = 3
        Me.ColourPreview.UseVisualStyleBackColor = False
        '
        'Red
        '
        Me.Red.Location = New System.Drawing.Point(12, 12)
        Me.Red.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.Red.Name = "Red"
        Me.Red.Size = New System.Drawing.Size(121, 23)
        Me.Red.TabIndex = 4
        '
        'Green
        '
        Me.Green.Location = New System.Drawing.Point(12, 43)
        Me.Green.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.Green.Name = "Green"
        Me.Green.Size = New System.Drawing.Size(121, 23)
        Me.Green.TabIndex = 5
        '
        'Blue
        '
        Me.Blue.Location = New System.Drawing.Point(12, 72)
        Me.Blue.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.Blue.Name = "Blue"
        Me.Blue.Size = New System.Drawing.Size(121, 23)
        Me.Blue.TabIndex = 6
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Blue)
        Me.Controls.Add(Me.Green)
        Me.Controls.Add(Me.Red)
        Me.Controls.Add(Me.ColourPreview)
        Me.Name = "Form2"
        CType(Me.Red, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Green, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Blue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ColourPreview As Button
    Friend WithEvents Red As NumericUpDown
    Friend WithEvents Green As NumericUpDown
    Friend WithEvents Blue As NumericUpDown
End Class
