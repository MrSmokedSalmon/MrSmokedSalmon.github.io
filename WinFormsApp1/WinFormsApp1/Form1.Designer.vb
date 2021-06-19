<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TrackBar4 = New System.Windows.Forms.TrackBar()
        Me.TrackBar3 = New System.Windows.Forms.TrackBar()
        Me.TrackBar2 = New System.Windows.Forms.TrackBar()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.HexApp = New System.Windows.Forms.Button()
        Me.HexRef = New System.Windows.Forms.Button()
        Me.HexCodeBox = New System.Windows.Forms.TextBox()
        Me.ImageSelect = New System.Windows.Forms.DomainUpDown()
        Me.Save = New System.Windows.Forms.Button()
        Me.AppToBack = New System.Windows.Forms.CheckBox()
        Me.Passes = New System.Windows.Forms.NumericUpDown()
        Me.Blue = New System.Windows.Forms.NumericUpDown()
        Me.Green = New System.Windows.Forms.NumericUpDown()
        Me.Red = New System.Windows.Forms.NumericUpDown()
        Me.ColourPreview = New System.Windows.Forms.Button()
        Me.Reeset = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.White = New System.Windows.Forms.Button()
        Me.Black = New System.Windows.Forms.Button()
        Me.Green1 = New System.Windows.Forms.Button()
        Me.Red1 = New System.Windows.Forms.Button()
        Me.Yellow = New System.Windows.Forms.Button()
        Me.Blue1 = New System.Windows.Forms.Button()
        Me.Pink = New System.Windows.Forms.Button()
        Me.Orange = New System.Windows.Forms.Button()
        Me.Brown = New System.Windows.Forms.Button()
        Me.Purple = New System.Windows.Forms.Button()
        CType(Me.TrackBar4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Passes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Blue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Green, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Red, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TrackBar4
        '
        Me.TrackBar4.Location = New System.Drawing.Point(499, 209)
        Me.TrackBar4.Maximum = 4
        Me.TrackBar4.Minimum = 1
        Me.TrackBar4.Name = "TrackBar4"
        Me.TrackBar4.Size = New System.Drawing.Size(331, 45)
        Me.TrackBar4.TabIndex = 34
        Me.TrackBar4.Value = 1
        '
        'TrackBar3
        '
        Me.TrackBar3.Location = New System.Drawing.Point(499, 158)
        Me.TrackBar3.Maximum = 255
        Me.TrackBar3.Minimum = 1
        Me.TrackBar3.Name = "TrackBar3"
        Me.TrackBar3.Size = New System.Drawing.Size(331, 45)
        Me.TrackBar3.TabIndex = 33
        Me.TrackBar3.TickFrequency = 5
        Me.TrackBar3.Value = 127
        '
        'TrackBar2
        '
        Me.TrackBar2.Location = New System.Drawing.Point(499, 107)
        Me.TrackBar2.Maximum = 255
        Me.TrackBar2.Minimum = 1
        Me.TrackBar2.Name = "TrackBar2"
        Me.TrackBar2.Size = New System.Drawing.Size(331, 45)
        Me.TrackBar2.TabIndex = 32
        Me.TrackBar2.TickFrequency = 5
        Me.TrackBar2.Value = 127
        '
        'TrackBar1
        '
        Me.TrackBar1.Location = New System.Drawing.Point(499, 56)
        Me.TrackBar1.Maximum = 255
        Me.TrackBar1.Minimum = 1
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(331, 45)
        Me.TrackBar1.TabIndex = 31
        Me.TrackBar1.TickFrequency = 5
        Me.TrackBar1.Value = 127
        '
        'HexApp
        '
        Me.HexApp.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.HexApp.Location = New System.Drawing.Point(502, 259)
        Me.HexApp.Name = "HexApp"
        Me.HexApp.Size = New System.Drawing.Size(25, 25)
        Me.HexApp.TabIndex = 30
        Me.HexApp.Text = "✔"
        Me.HexApp.UseVisualStyleBackColor = True
        '
        'HexRef
        '
        Me.HexRef.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.HexRef.Location = New System.Drawing.Point(738, 259)
        Me.HexRef.Name = "HexRef"
        Me.HexRef.Size = New System.Drawing.Size(25, 25)
        Me.HexRef.TabIndex = 29
        Me.HexRef.Text = "⟲"
        Me.HexRef.UseVisualStyleBackColor = True
        '
        'HexCodeBox
        '
        Me.HexCodeBox.Location = New System.Drawing.Point(528, 260)
        Me.HexCodeBox.Name = "HexCodeBox"
        Me.HexCodeBox.Size = New System.Drawing.Size(209, 23)
        Me.HexCodeBox.TabIndex = 28
        '
        'ImageSelect
        '
        Me.ImageSelect.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ImageSelect.Items.Add("X")
        Me.ImageSelect.Items.Add("O")
        Me.ImageSelect.Location = New System.Drawing.Point(500, 329)
        Me.ImageSelect.Name = "ImageSelect"
        Me.ImageSelect.Size = New System.Drawing.Size(256, 34)
        Me.ImageSelect.TabIndex = 27
        Me.ImageSelect.Text = "X"
        Me.ImageSelect.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Save
        '
        Me.Save.Location = New System.Drawing.Point(635, 290)
        Me.Save.Name = "Save"
        Me.Save.Size = New System.Drawing.Size(121, 32)
        Me.Save.TabIndex = 26
        Me.Save.Text = "Save"
        Me.Save.UseVisualStyleBackColor = True
        '
        'AppToBack
        '
        Me.AppToBack.AutoSize = True
        Me.AppToBack.Location = New System.Drawing.Point(528, 369)
        Me.AppToBack.Name = "AppToBack"
        Me.AppToBack.Size = New System.Drawing.Size(139, 19)
        Me.AppToBack.TabIndex = 25
        Me.AppToBack.Text = "Apply To Background"
        Me.AppToBack.UseVisualStyleBackColor = True
        '
        'Passes
        '
        Me.Passes.Enabled = False
        Me.Passes.Location = New System.Drawing.Point(836, 209)
        Me.Passes.Maximum = New Decimal(New Integer() {4, 0, 0, 0})
        Me.Passes.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Passes.Name = "Passes"
        Me.Passes.Size = New System.Drawing.Size(54, 23)
        Me.Passes.TabIndex = 24
        Me.Passes.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Blue
        '
        Me.Blue.Enabled = False
        Me.Blue.Location = New System.Drawing.Point(836, 158)
        Me.Blue.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.Blue.Name = "Blue"
        Me.Blue.Size = New System.Drawing.Size(54, 23)
        Me.Blue.TabIndex = 23
        Me.Blue.Value = New Decimal(New Integer() {125, 0, 0, 0})
        '
        'Green
        '
        Me.Green.Enabled = False
        Me.Green.Location = New System.Drawing.Point(836, 107)
        Me.Green.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.Green.Name = "Green"
        Me.Green.Size = New System.Drawing.Size(54, 23)
        Me.Green.TabIndex = 22
        Me.Green.Value = New Decimal(New Integer() {125, 0, 0, 0})
        '
        'Red
        '
        Me.Red.Enabled = False
        Me.Red.Location = New System.Drawing.Point(836, 56)
        Me.Red.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.Red.Name = "Red"
        Me.Red.Size = New System.Drawing.Size(54, 23)
        Me.Red.TabIndex = 21
        Me.Red.Value = New Decimal(New Integer() {125, 0, 0, 0})
        '
        'ColourPreview
        '
        Me.ColourPreview.BackColor = System.Drawing.SystemColors.Control
        Me.ColourPreview.Location = New System.Drawing.Point(769, 267)
        Me.ColourPreview.Name = "ColourPreview"
        Me.ColourPreview.Size = New System.Drawing.Size(121, 121)
        Me.ColourPreview.TabIndex = 20
        Me.ColourPreview.UseVisualStyleBackColor = False
        '
        'Reeset
        '
        Me.Reeset.Location = New System.Drawing.Point(508, 290)
        Me.Reeset.Name = "Reeset"
        Me.Reeset.Size = New System.Drawing.Size(121, 32)
        Me.Reeset.TabIndex = 35
        Me.Reeset.Text = "Reset ↺"
        Me.Reeset.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 50
        '
        'White
        '
        Me.White.BackColor = System.Drawing.Color.White
        Me.White.Location = New System.Drawing.Point(528, 12)
        Me.White.Name = "White"
        Me.White.Size = New System.Drawing.Size(24, 24)
        Me.White.TabIndex = 36
        Me.White.UseVisualStyleBackColor = False
        '
        'Black
        '
        Me.Black.BackColor = System.Drawing.Color.Black
        Me.Black.Location = New System.Drawing.Point(558, 12)
        Me.Black.Name = "Black"
        Me.Black.Size = New System.Drawing.Size(24, 24)
        Me.Black.TabIndex = 37
        Me.Black.UseVisualStyleBackColor = False
        '
        'Green1
        '
        Me.Green1.BackColor = System.Drawing.Color.Green
        Me.Green1.Location = New System.Drawing.Point(618, 12)
        Me.Green1.Name = "Green1"
        Me.Green1.Size = New System.Drawing.Size(24, 24)
        Me.Green1.TabIndex = 39
        Me.Green1.UseVisualStyleBackColor = False
        '
        'Red1
        '
        Me.Red1.BackColor = System.Drawing.Color.Red
        Me.Red1.Location = New System.Drawing.Point(588, 12)
        Me.Red1.Name = "Red1"
        Me.Red1.Size = New System.Drawing.Size(24, 24)
        Me.Red1.TabIndex = 38
        Me.Red1.UseVisualStyleBackColor = False
        '
        'Yellow
        '
        Me.Yellow.BackColor = System.Drawing.Color.Yellow
        Me.Yellow.Location = New System.Drawing.Point(678, 12)
        Me.Yellow.Name = "Yellow"
        Me.Yellow.Size = New System.Drawing.Size(24, 24)
        Me.Yellow.TabIndex = 41
        Me.Yellow.UseVisualStyleBackColor = False
        '
        'Blue1
        '
        Me.Blue1.BackColor = System.Drawing.Color.Blue
        Me.Blue1.Location = New System.Drawing.Point(648, 12)
        Me.Blue1.Name = "Blue1"
        Me.Blue1.Size = New System.Drawing.Size(24, 24)
        Me.Blue1.TabIndex = 40
        Me.Blue1.UseVisualStyleBackColor = False
        '
        'Pink
        '
        Me.Pink.BackColor = System.Drawing.Color.Pink
        Me.Pink.Location = New System.Drawing.Point(739, 12)
        Me.Pink.Name = "Pink"
        Me.Pink.Size = New System.Drawing.Size(24, 24)
        Me.Pink.TabIndex = 43
        Me.Pink.UseVisualStyleBackColor = False
        '
        'Orange
        '
        Me.Orange.BackColor = System.Drawing.Color.Orange
        Me.Orange.Location = New System.Drawing.Point(708, 12)
        Me.Orange.Name = "Orange"
        Me.Orange.Size = New System.Drawing.Size(24, 24)
        Me.Orange.TabIndex = 42
        Me.Orange.UseVisualStyleBackColor = False
        '
        'Brown
        '
        Me.Brown.BackColor = System.Drawing.Color.Brown
        Me.Brown.Location = New System.Drawing.Point(798, 12)
        Me.Brown.Name = "Brown"
        Me.Brown.Size = New System.Drawing.Size(24, 24)
        Me.Brown.TabIndex = 45
        Me.Brown.UseVisualStyleBackColor = False
        '
        'Purple
        '
        Me.Purple.BackColor = System.Drawing.Color.Purple
        Me.Purple.Location = New System.Drawing.Point(769, 12)
        Me.Purple.Name = "Purple"
        Me.Purple.Size = New System.Drawing.Size(24, 24)
        Me.Purple.TabIndex = 44
        Me.Purple.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(911, 450)
        Me.Controls.Add(Me.Brown)
        Me.Controls.Add(Me.Purple)
        Me.Controls.Add(Me.Pink)
        Me.Controls.Add(Me.Orange)
        Me.Controls.Add(Me.Yellow)
        Me.Controls.Add(Me.Blue1)
        Me.Controls.Add(Me.Green1)
        Me.Controls.Add(Me.Red1)
        Me.Controls.Add(Me.Black)
        Me.Controls.Add(Me.White)
        Me.Controls.Add(Me.Reeset)
        Me.Controls.Add(Me.TrackBar4)
        Me.Controls.Add(Me.TrackBar3)
        Me.Controls.Add(Me.TrackBar2)
        Me.Controls.Add(Me.TrackBar1)
        Me.Controls.Add(Me.HexApp)
        Me.Controls.Add(Me.HexRef)
        Me.Controls.Add(Me.HexCodeBox)
        Me.Controls.Add(Me.ImageSelect)
        Me.Controls.Add(Me.Save)
        Me.Controls.Add(Me.AppToBack)
        Me.Controls.Add(Me.Passes)
        Me.Controls.Add(Me.Blue)
        Me.Controls.Add(Me.Green)
        Me.Controls.Add(Me.Red)
        Me.Controls.Add(Me.ColourPreview)
        Me.Name = "Form1"
        Me.Text = "Naughts and Crosses"
        CType(Me.TrackBar4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Passes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Blue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Green, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Red, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TrackBar4 As TrackBar
    Friend WithEvents TrackBar3 As TrackBar
    Friend WithEvents TrackBar2 As TrackBar
    Friend WithEvents TrackBar1 As TrackBar
    Friend WithEvents HexApp As Button
    Friend WithEvents HexRef As Button
    Friend WithEvents HexCodeBox As TextBox
    Friend WithEvents ImageSelect As DomainUpDown
    Friend WithEvents Save As Button
    Friend WithEvents AppToBack As CheckBox
    Friend WithEvents Passes As NumericUpDown
    Friend WithEvents Blue As NumericUpDown
    Friend WithEvents Green As NumericUpDown
    Friend WithEvents Red As NumericUpDown
    Friend WithEvents ColourPreview As Button
    Friend WithEvents Reeset As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents White As Button
    Friend WithEvents Black As Button
    Friend WithEvents Green1 As Button
    Friend WithEvents Red1 As Button
    Friend WithEvents Yellow As Button
    Friend WithEvents Blue1 As Button
    Friend WithEvents Pink As Button
    Friend WithEvents Orange As Button
    Friend WithEvents Brown As Button
    Friend WithEvents Purple As Button
End Class
