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
        CType(Me.Red, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Green, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Blue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Passes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ColourPreview
        '
        Me.ColourPreview.BackColor = System.Drawing.SystemColors.Control
        Me.ColourPreview.Location = New System.Drawing.Point(148, 9)
        Me.ColourPreview.Name = "ColourPreview"
        Me.ColourPreview.Size = New System.Drawing.Size(121, 121)
        Me.ColourPreview.TabIndex = 3
        Me.ColourPreview.UseVisualStyleBackColor = False
        '
        'Red
        '
        Me.Red.Location = New System.Drawing.Point(12, 10)
        Me.Red.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.Red.Name = "Red"
        Me.Red.Size = New System.Drawing.Size(121, 23)
        Me.Red.TabIndex = 4
        Me.Red.Value = New Decimal(New Integer() {125, 0, 0, 0})
        '
        'Green
        '
        Me.Green.Location = New System.Drawing.Point(12, 41)
        Me.Green.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.Green.Name = "Green"
        Me.Green.Size = New System.Drawing.Size(121, 23)
        Me.Green.TabIndex = 5
        Me.Green.Value = New Decimal(New Integer() {125, 0, 0, 0})
        '
        'Blue
        '
        Me.Blue.Location = New System.Drawing.Point(12, 70)
        Me.Blue.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.Blue.Name = "Blue"
        Me.Blue.Size = New System.Drawing.Size(121, 23)
        Me.Blue.TabIndex = 6
        Me.Blue.Value = New Decimal(New Integer() {125, 0, 0, 0})
        '
        'Passes
        '
        Me.Passes.Location = New System.Drawing.Point(12, 99)
        Me.Passes.Maximum = New Decimal(New Integer() {4, 0, 0, 0})
        Me.Passes.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Passes.Name = "Passes"
        Me.Passes.Size = New System.Drawing.Size(121, 23)
        Me.Passes.TabIndex = 7
        Me.Passes.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'AppToBack
        '
        Me.AppToBack.AutoSize = True
        Me.AppToBack.Location = New System.Drawing.Point(12, 130)
        Me.AppToBack.Name = "AppToBack"
        Me.AppToBack.Size = New System.Drawing.Size(139, 19)
        Me.AppToBack.TabIndex = 8
        Me.AppToBack.Text = "Apply To Background"
        Me.AppToBack.UseVisualStyleBackColor = True
        '
        'Reset
        '
        Me.Reset.Location = New System.Drawing.Point(12, 155)
        Me.Reset.Name = "Reset"
        Me.Reset.Size = New System.Drawing.Size(121, 32)
        Me.Reset.TabIndex = 9
        Me.Reset.Text = "Reset ↺"
        Me.Reset.UseVisualStyleBackColor = True
        '
        'Save
        '
        Me.Save.Location = New System.Drawing.Point(148, 155)
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
        Me.ImageSelect.Location = New System.Drawing.Point(12, 193)
        Me.ImageSelect.Name = "ImageSelect"
        Me.ImageSelect.Size = New System.Drawing.Size(256, 34)
        Me.ImageSelect.TabIndex = 12
        Me.ImageSelect.Text = "Team to Change"
        Me.ImageSelect.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'HexCodeBox
        '
        Me.HexCodeBox.Location = New System.Drawing.Point(174, 131)
        Me.HexCodeBox.Name = "HexCodeBox"
        Me.HexCodeBox.Size = New System.Drawing.Size(72, 23)
        Me.HexCodeBox.TabIndex = 13
        '
        'HexRef
        '
        Me.HexRef.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.HexRef.Location = New System.Drawing.Point(246, 130)
        Me.HexRef.Name = "HexRef"
        Me.HexRef.Size = New System.Drawing.Size(25, 25)
        Me.HexRef.TabIndex = 14
        Me.HexRef.Text = "⟲"
        Me.HexRef.UseVisualStyleBackColor = True
        '
        'HexApp
        '
        Me.HexApp.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.HexApp.Location = New System.Drawing.Point(148, 130)
        Me.HexApp.Name = "HexApp"
        Me.HexApp.Size = New System.Drawing.Size(25, 25)
        Me.HexApp.TabIndex = 15
        Me.HexApp.Text = "✔"
        Me.HexApp.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(280, 239)
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
End Class
