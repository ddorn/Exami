<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PlacementBox
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PlacementBox))
        Me.TextBox = New System.Windows.Forms.RichTextBox()
        Me.PrintButton = New System.Windows.Forms.Button()
        Me.ShuffleButton = New System.Windows.Forms.Button()
        Me.ByClassButton = New System.Windows.Forms.Button()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.AzButton = New System.Windows.Forms.Button()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TextBox
        '
        Me.TextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox.HideSelection = False
        Me.TextBox.Location = New System.Drawing.Point(0, 39)
        Me.TextBox.Name = "TextBox"
        Me.TextBox.ReadOnly = True
        Me.TextBox.RightMargin = 4
        Me.TextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.TextBox.Size = New System.Drawing.Size(242, 302)
        Me.TextBox.TabIndex = 0
        Me.TextBox.TabStop = False
        Me.TextBox.Text = ""
        Me.TextBox.WordWrap = False
        '
        'PrintButton
        '
        Me.PrintButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.PrintButton.BackColor = System.Drawing.SystemColors.Control
        Me.PrintButton.BackgroundImage = CType(resources.GetObject("PrintButton.BackgroundImage"), System.Drawing.Image)
        Me.PrintButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PrintButton.Location = New System.Drawing.Point(52, 347)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(42, 42)
        Me.PrintButton.TabIndex = 2
        Me.PrintButton.Tag = "Print this part of the placement"
        Me.PrintButton.UseVisualStyleBackColor = False
        '
        'ShuffleButton
        '
        Me.ShuffleButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.ShuffleButton.BackgroundImage = CType(resources.GetObject("ShuffleButton.BackgroundImage"), System.Drawing.Image)
        Me.ShuffleButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ShuffleButton.Location = New System.Drawing.Point(100, 347)
        Me.ShuffleButton.Name = "ShuffleButton"
        Me.ShuffleButton.Size = New System.Drawing.Size(42, 42)
        Me.ShuffleButton.TabIndex = 3
        Me.ShuffleButton.Tag = "Place the students in a random order"
        Me.ShuffleButton.UseVisualStyleBackColor = True
        '
        'ByClassButton
        '
        Me.ByClassButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.ByClassButton.BackgroundImage = CType(resources.GetObject("ByClassButton.BackgroundImage"), System.Drawing.Image)
        Me.ByClassButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ByClassButton.Location = New System.Drawing.Point(196, 347)
        Me.ByClassButton.Name = "ByClassButton"
        Me.ByClassButton.Size = New System.Drawing.Size(42, 42)
        Me.ByClassButton.TabIndex = 5
        Me.ByClassButton.Tag = "Group the students by class"
        Me.ByClassButton.UseVisualStyleBackColor = True
        '
        'SaveButton
        '
        Me.SaveButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.SaveButton.BackgroundImage = CType(resources.GetObject("SaveButton.BackgroundImage"), System.Drawing.Image)
        Me.SaveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SaveButton.Location = New System.Drawing.Point(4, 347)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(42, 42)
        Me.SaveButton.TabIndex = 1
        Me.SaveButton.Tag = "Save this part of the placement"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'AzButton
        '
        Me.AzButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.AzButton.BackgroundImage = CType(resources.GetObject("AzButton.BackgroundImage"), System.Drawing.Image)
        Me.AzButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.AzButton.Location = New System.Drawing.Point(148, 347)
        Me.AzButton.Name = "AzButton"
        Me.AzButton.Size = New System.Drawing.Size(42, 42)
        Me.AzButton.TabIndex = 4
        Me.AzButton.Tag = "Place students in alphabetic order"
        Me.AzButton.UseVisualStyleBackColor = True
        '
        'NameLabel
        '
        Me.NameLabel.Dock = System.Windows.Forms.DockStyle.Top
        Me.NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameLabel.Location = New System.Drawing.Point(0, 0)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(242, 36)
        Me.NameLabel.TabIndex = 6
        Me.NameLabel.Text = "Name"
        Me.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PlacementBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.NameLabel)
        Me.Controls.Add(Me.AzButton)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.ByClassButton)
        Me.Controls.Add(Me.ShuffleButton)
        Me.Controls.Add(Me.PrintButton)
        Me.Controls.Add(Me.TextBox)
        Me.MinimumSize = New System.Drawing.Size(242, 2)
        Me.Name = "PlacementBox"
        Me.Size = New System.Drawing.Size(242, 392)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TextBox As RichTextBox
    Friend WithEvents PrintButton As Button
    Friend WithEvents ShuffleButton As Button
    Friend WithEvents ByClassButton As Button
    Friend WithEvents SaveButton As Button
    Friend WithEvents AzButton As Button
    Friend WithEvents NameLabel As Label
End Class
