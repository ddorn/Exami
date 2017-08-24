<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ExamiForm
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
        Me.ConvertButton = New System.Windows.Forms.Button()
        Me.FolderChooseWidget = New System.Windows.Forms.FolderBrowserDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PlacementButton = New System.Windows.Forms.Button()
        Me.ChooseFolderButton = New System.Windows.Forms.Button()
        Me.svListBox = New System.Windows.Forms.CheckedListBox()
        Me.ddListBox = New System.Windows.Forms.CheckedListBox()
        Me.CreateRoomButton = New System.Windows.Forms.Button()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.PlacementBox = New System.Windows.Forms.RichTextBox()
        Me.PrintButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ConvertButton
        '
        Me.ConvertButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ConvertButton.Enabled = False
        Me.ConvertButton.Location = New System.Drawing.Point(933, 286)
        Me.ConvertButton.Name = "ConvertButton"
        Me.ConvertButton.Size = New System.Drawing.Size(257, 33)
        Me.ConvertButton.TabIndex = 2
        Me.ConvertButton.Text = "&Convert all  .vass files"
        Me.ConvertButton.UseVisualStyleBackColor = True
        '
        'FolderChooseWidget
        '
        Me.FolderChooseWidget.SelectedPath = "C:\Users\diego\Documents\Programation\Exami\Data"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 126)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 20)
        Me.Label1.TabIndex = 2
        '
        'PlacementButton
        '
        Me.PlacementButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PlacementButton.Enabled = False
        Me.PlacementButton.Location = New System.Drawing.Point(1068, 533)
        Me.PlacementButton.Name = "PlacementButton"
        Me.PlacementButton.Size = New System.Drawing.Size(122, 45)
        Me.PlacementButton.TabIndex = 5
        Me.PlacementButton.Text = "&Get placement"
        Me.PlacementButton.UseVisualStyleBackColor = True
        '
        'ChooseFolderButton
        '
        Me.ChooseFolderButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChooseFolderButton.Location = New System.Drawing.Point(933, 12)
        Me.ChooseFolderButton.Name = "ChooseFolderButton"
        Me.ChooseFolderButton.Size = New System.Drawing.Size(257, 32)
        Me.ChooseFolderButton.TabIndex = 0
        Me.ChooseFolderButton.Text = "Choose &folder"
        Me.ChooseFolderButton.UseVisualStyleBackColor = True
        '
        'svListBox
        '
        Me.svListBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.svListBox.CheckOnClick = True
        Me.svListBox.Enabled = False
        Me.svListBox.FormattingEnabled = True
        Me.svListBox.HorizontalScrollbar = True
        Me.svListBox.IntegralHeight = False
        Me.svListBox.Items.AddRange(New Object() {"First select a folder", "Then convert the .vass files", "Select one or more classes", "And create the a class plan", "Finaly create the placement"})
        Me.svListBox.Location = New System.Drawing.Point(933, 50)
        Me.svListBox.Name = "svListBox"
        Me.svListBox.Size = New System.Drawing.Size(257, 230)
        Me.svListBox.TabIndex = 1
        '
        'ddListBox
        '
        Me.ddListBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ddListBox.CheckOnClick = True
        Me.ddListBox.Enabled = False
        Me.ddListBox.FormattingEnabled = True
        Me.ddListBox.HorizontalScrollbar = True
        Me.ddListBox.IntegralHeight = False
        Me.ddListBox.Items.AddRange(New Object() {"First select a folder", "Then create a room setup", "Select one or more classes", "Create the placement"})
        Me.ddListBox.Location = New System.Drawing.Point(933, 325)
        Me.ddListBox.Name = "ddListBox"
        Me.ddListBox.Size = New System.Drawing.Size(257, 202)
        Me.ddListBox.TabIndex = 3
        '
        'CreateRoomButton
        '
        Me.CreateRoomButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CreateRoomButton.Enabled = False
        Me.CreateRoomButton.Location = New System.Drawing.Point(933, 533)
        Me.CreateRoomButton.Name = "CreateRoomButton"
        Me.CreateRoomButton.Size = New System.Drawing.Size(129, 45)
        Me.CreateRoomButton.TabIndex = 4
        Me.CreateRoomButton.Text = "Create &room"
        Me.CreateRoomButton.UseVisualStyleBackColor = True
        '
        'SaveButton
        '
        Me.SaveButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaveButton.Location = New System.Drawing.Point(798, 533)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(129, 45)
        Me.SaveButton.TabIndex = 7
        Me.SaveButton.Text = "&Save the plan"
        Me.SaveButton.UseVisualStyleBackColor = True
        Me.SaveButton.Visible = False
        '
        'PlacementBox
        '
        Me.PlacementBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PlacementBox.BackColor = System.Drawing.SystemColors.Control
        Me.PlacementBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PlacementBox.HideSelection = False
        Me.PlacementBox.Location = New System.Drawing.Point(12, 12)
        Me.PlacementBox.Name = "PlacementBox"
        Me.PlacementBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.PlacementBox.Size = New System.Drawing.Size(780, 566)
        Me.PlacementBox.TabIndex = 9
        Me.PlacementBox.Text = "Made with love by Diego <3"
        '
        'PrintButton
        '
        Me.PrintButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PrintButton.Location = New System.Drawing.Point(798, 482)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(129, 45)
        Me.PrintButton.TabIndex = 10
        Me.PrintButton.Text = "&Print"
        Me.PrintButton.UseVisualStyleBackColor = True
        Me.PrintButton.Visible = False
        '
        'ExamiForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1202, 590)
        Me.Controls.Add(Me.PrintButton)
        Me.Controls.Add(Me.PlacementBox)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.CreateRoomButton)
        Me.Controls.Add(Me.ddListBox)
        Me.Controls.Add(Me.svListBox)
        Me.Controls.Add(Me.ChooseFolderButton)
        Me.Controls.Add(Me.PlacementButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ConvertButton)
        Me.Name = "ExamiForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Exami"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ConvertButton As Button
    Friend WithEvents FolderChooseWidget As FolderBrowserDialog
    Friend WithEvents SelectFolderButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PlacementButton As Button
    Friend WithEvents ChooseFolderButton As Button
    Friend WithEvents svListBox As CheckedListBox
    Friend WithEvents ddListBox As CheckedListBox
    Friend WithEvents CreateRoomButton As Button
    Friend WithEvents SaveButton As Button
    Friend WithEvents PlacementBox As RichTextBox
    Friend WithEvents PrintButton As Button
End Class
