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
        Me.Passes = New System.Windows.Forms.NumericUpDown()
        Me.AppToBack = New System.Windows.Forms.CheckBox()
        Me.Reset = New System.Windows.Forms.Button()
        Me.Save = New System.Windows.Forms.Button()
        Me.ImageSelect = New System.Windows.Forms.DomainUpDown()
        Me.HexCodeBox = New System.Windows.Forms.TextBox()
        Me.HexRef = New System.Windows.Forms.Button()
        Me.HexApp = New System.Windows.Forms.Button()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.TrackBar2 = New System.Windows.Forms.TrackBar()
        Me.TrackBar3 = New System.Windows.Forms.TrackBar()
        Me.TrackBar4 = New System.Windows.Forms.TrackBar()
        CType(Me.Red, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Green, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Blue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Passes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ColourPreview
        '
        Me.ColourPreview.BackColor = System.Drawing.SystemColors.Control
        Me.ColourPreview.Location = New System.Drawing.Point(282, 227)
        Me.ColourPreview.Name = "ColourPreview"
        Me.ColourPreview.Size = New System.Drawing.Size(121, 121)
        Me.ColourPreview.TabIndex = 3
        Me.ColourPreview.UseVisualStyleBackColor = False
        '
        'Red
        '
        Me.Red.Location = New System.Drawing.Point(256, 27)
        Me.Red.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.Red.Name = "Red"
        Me.Red.Size = New System.Drawing.Size(54, 23)
        Me.Red.TabIndex = 4
        Me.Red.Value = New Decimal(New Integer() {125, 0, 0, 0})
        '
        'Green
        '
        Me.Green.Location = New System.Drawing.Point(256, 78)
        Me.Green.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.Green.Name = "Green"
        Me.Green.Size = New System.Drawing.Size(54, 23)
        Me.Green.TabIndex = 5
        Me.Green.Value = New Decimal(New Integer() {125, 0, 0, 0})
        '
        'Blue
        '
        Me.Blue.Location = New System.Drawing.Point(256, 127)
        Me.Blue.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.Blue.Name = "Blue"
        Me.Blue.Size = New System.Drawing.Size(54, 23)
        Me.Blue.TabIndex = 6
        Me.Blue.Value = New Decimal(New Integer() {125, 0, 0, 0})
        '
        'Passes
        '
        Me.Passes.Location = New System.Drawing.Point(256, 180)
        Me.Passes.Maximum = New Decimal(New Integer() {4, 0, 0, 0})
        Me.Passes.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Passes.Name = "Passes"
        Me.Passes.Size = New System.Drawing.Size(54, 23)
        Me.Passes.TabIndex = 7
        Me.Passes.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'AppToBack
        '
        Me.AppToBack.AutoSize = True
        Me.AppToBack.Location = New System.Drawing.Point(41, 329)
        Me.AppToBack.Name = "AppToBack"
        Me.AppToBack.Size = New System.Drawing.Size(139, 19)
        Me.AppToBack.TabIndex = 8
        Me.AppToBack.Text = "Apply To Background"
        Me.AppToBack.UseVisualStyleBackColor = True
        '
        'Reset
        '
        Me.Reset.Location = New System.Drawing.Point(12, 250)
        Me.Reset.Name = "Reset"
        Me.Reset.Size = New System.Drawing.Size(121, 32)
        Me.Reset.TabIndex = 9
        Me.Reset.Text = "Reset ↺"
        Me.Reset.UseVisualStyleBackColor = True
        '
        'Save
        '
        Me.Save.Location = New System.Drawing.Point(148, 250)
        Me.Save.Name = "Save"
        Me.Save.Size = New System.Drawing.Size(121, 32)
        Me.Save.TabIndex = 10
        Me.Save.Text = "Save"
        Me.Save.UseVisualStyleBackColor = True
        '
        'ImageSelect
        '
        Me.ImageSelect.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ImageSelect.Items.Add("X")
        Me.ImageSelect.Items.Add("O")
        Me.ImageSelect.Location = New System.Drawing.Point(13, 289)
        Me.ImageSelect.Name = "ImageSelect"
        Me.ImageSelect.Size = New System.Drawing.Size(256, 34)
        Me.ImageSelect.TabIndex = 12
        Me.ImageSelect.Text = "X"
        Me.ImageSelect.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'HexCodeBox
        '
        Me.HexCodeBox.Location = New System.Drawing.Point(41, 220)
        Me.HexCodeBox.Name = "HexCodeBox"
        Me.HexCodeBox.Size = New System.Drawing.Size(209, 23)
        Me.HexCodeBox.TabIndex = 13
        '
        'HexRef
        '
        Me.HexRef.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.HexRef.Location = New System.Drawing.Point(251, 219)
        Me.HexRef.Name = "HexRef"
        Me.HexRef.Size = New System.Drawing.Size(25, 25)
        Me.HexRef.TabIndex = 14
        Me.HexRef.Text = "⟲"
        Me.HexRef.UseVisualStyleBackColor = True
        '
        'HexApp
        '
        Me.HexApp.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.HexApp.Location = New System.Drawing.Point(15, 219)
        Me.HexApp.Name = "HexApp"
        Me.HexApp.Size = New System.Drawing.Size(25, 25)
        Me.HexApp.TabIndex = 15
        Me.HexApp.Text = "✔"
        Me.HexApp.UseVisualStyleBackColor = True
        '
        'TrackBar1
        '
        Me.TrackBar1.Location = New System.Drawing.Point(12, 16)
        Me.TrackBar1.Maximum = 255
        Me.TrackBar1.Minimum = 1
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(238, 45)
        Me.TrackBar1.TabIndex = 16
        Me.TrackBar1.Value = 1
        '
        'TrackBar2
        '
        Me.TrackBar2.Location = New System.Drawing.Point(12, 67)
        Me.TrackBar2.Maximum = 255
        Me.TrackBar2.Minimum = 1
        Me.TrackBar2.Name = "TrackBar2"
        Me.TrackBar2.Size = New System.Drawing.Size(238, 45)
        Me.TrackBar2.TabIndex = 17
        Me.TrackBar2.Value = 1
        '
        'TrackBar3
        '
        Me.TrackBar3.Location = New System.Drawing.Point(12, 118)
        Me.TrackBar3.Maximum = 255
        Me.TrackBar3.Minimum = 1
        Me.TrackBar3.Name = "TrackBar3"
        Me.TrackBar3.Size = New System.Drawing.Size(238, 45)
        Me.TrackBar3.TabIndex = 18
        Me.TrackBar3.Value = 1
        '
        'TrackBar4
        '
        Me.TrackBar4.Location = New System.Drawing.Point(12, 169)
        Me.TrackBar4.Maximum = 4
        Me.TrackBar4.Minimum = 1
        Me.TrackBar4.Name = "TrackBar4"
        Me.TrackBar4.Size = New System.Drawing.Size(238, 45)
        Me.TrackBar4.TabIndex = 19
        Me.TrackBar4.Value = 1
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(407, 351)
        Me.Controls.Add(Me.TrackBar4)
        Me.Controls.Add(Me.TrackBar3)
        Me.Controls.Add(Me.TrackBar2)
        Me.Controls.Add(Me.TrackBar1)
        Me.Controls.Add(Me.HexApp)
        Me.Controls.Add(Me.HexRef)
        Me.Controls.Add(Me.HexCodeBox)
        Me.Controls.Add(Me.ImageSelect)
        Me.Controls.Add(Me.Save)
        Me.Controls.Add(Me.Reset)
        Me.Controls.Add(Me.AppToBack)
        Me.Controls.Add(Me.Passes)
        Me.Controls.Add(Me.Blue)
        Me.Controls.Add(Me.Green)
        Me.Controls.Add(Me.Red)
        Me.Controls.Add(Me.ColourPreview)
        Me.Name = "Form2"
        Me.Text = "Colour Customisation"
        CType(Me.Red, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Green, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Blue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Passes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ColourPreview As Button
    Friend WithEvents Red As NumericUpDown
    Friend WithEvents Green As NumericUpDown
    Friend WithEvents Blue As NumericUpDown
    Friend WithEvents Passes As NumericUpDown
    Friend WithEvents AppToBack As CheckBox
    Friend WithEvents Reset As Button
    Friend WithEvents Save As Button
    Friend WithEvents ImageSelect As DomainUpDown
    Friend WithEvents HexCodeBox As TextBox
    Friend WithEvents HexRef As Button
    Friend WithEvents HexApp As Button
    Friend WithEvents TrackBar1 As TrackBar
    Friend WithEvents TrackBar2 As TrackBar
    Friend WithEvents TrackBar3 As TrackBar
    Friend WithEvents TrackBar4 As TrackBar
End Class
