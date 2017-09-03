<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Exami2
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.SelectFolderButton = New System.Windows.Forms.Button()
        Me.ConvertFolderButton = New System.Windows.Forms.Button()
        Me.PrintAllButton = New System.Windows.Forms.Button()
        Me.SaveAllButton = New System.Windows.Forms.Button()
        Me.MakePlacementButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PlacementOptionsCheckedListBox = New System.Windows.Forms.CheckedListBox()
        Me.ViewByComboBox = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusBar = New System.Windows.Forms.StatusStrip()
        Me.HoverStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GeneralStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.RoomManager1 = New Exami.RoomManager()
        Me.PlacementBox3 = New Exami.PlacementBox()
        Me.PlacementBox2 = New Exami.PlacementBox()
        Me.PlacementBox1 = New Exami.PlacementBox()
        Me.SubjectManager1 = New Exami.SubjectManager()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.StatusBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 60)
        Me.SplitContainer1.MinimumSize = New System.Drawing.Size(100, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Panel1MinSize = 254
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.PlacementBox3)
        Me.SplitContainer1.Panel2.Controls.Add(Me.PlacementBox2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.PlacementBox1)
        Me.SplitContainer1.Panel2MinSize = 100
        Me.SplitContainer1.Size = New System.Drawing.Size(1202, 508)
        Me.SplitContainer1.SplitterDistance = 254
        Me.SplitContainer1.SplitterIncrement = 3
        Me.SplitContainer1.SplitterWidth = 8
        Me.SplitContainer1.TabIndex = 7
        Me.SplitContainer1.TabStop = False
        '
        'SplitContainer2
        '
        Me.SplitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.SubjectManager1)
        Me.SplitContainer2.Panel1.Padding = New System.Windows.Forms.Padding(3)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.RoomManager1)
        Me.SplitContainer2.Size = New System.Drawing.Size(254, 508)
        Me.SplitContainer2.SplitterDistance = 233
        Me.SplitContainer2.TabIndex = 0
        Me.SplitContainer2.TabStop = False
        '
        'SelectFolderButton
        '
        Me.SelectFolderButton.Location = New System.Drawing.Point(12, 14)
        Me.SelectFolderButton.Name = "SelectFolderButton"
        Me.SelectFolderButton.Size = New System.Drawing.Size(123, 34)
        Me.SelectFolderButton.TabIndex = 0
        Me.SelectFolderButton.Tag = "Select the folder containing the .vass files"
        Me.SelectFolderButton.Text = "Select Folder"
        Me.SelectFolderButton.UseVisualStyleBackColor = True
        '
        'ConvertFolderButton
        '
        Me.ConvertFolderButton.Enabled = False
        Me.ConvertFolderButton.Location = New System.Drawing.Point(141, 14)
        Me.ConvertFolderButton.Name = "ConvertFolderButton"
        Me.ConvertFolderButton.Size = New System.Drawing.Size(123, 34)
        Me.ConvertFolderButton.TabIndex = 1
        Me.ConvertFolderButton.Tag = "Convert the selected folder to be able to use it in the app"
        Me.ConvertFolderButton.Text = "Convert Folder"
        Me.ConvertFolderButton.UseVisualStyleBackColor = True
        '
        'PrintAllButton
        '
        Me.PrintAllButton.Enabled = False
        Me.PrintAllButton.Location = New System.Drawing.Point(270, 14)
        Me.PrintAllButton.Name = "PrintAllButton"
        Me.PrintAllButton.Size = New System.Drawing.Size(76, 34)
        Me.PrintAllButton.TabIndex = 2
        Me.PrintAllButton.Tag = "Print the complete placement : every room, subject and class"
        Me.PrintAllButton.Text = "Print all"
        Me.PrintAllButton.UseVisualStyleBackColor = True
        '
        'SaveAllButton
        '
        Me.SaveAllButton.Enabled = False
        Me.SaveAllButton.Location = New System.Drawing.Point(352, 14)
        Me.SaveAllButton.Name = "SaveAllButton"
        Me.SaveAllButton.Size = New System.Drawing.Size(77, 34)
        Me.SaveAllButton.TabIndex = 3
        Me.SaveAllButton.Tag = "Save the whole placement in a file."
        Me.SaveAllButton.Text = "Save all"
        Me.SaveAllButton.UseVisualStyleBackColor = True
        '
        'MakePlacementButton
        '
        Me.MakePlacementButton.Enabled = False
        Me.MakePlacementButton.Location = New System.Drawing.Point(435, 14)
        Me.MakePlacementButton.Name = "MakePlacementButton"
        Me.MakePlacementButton.Size = New System.Drawing.Size(135, 34)
        Me.MakePlacementButton.TabIndex = 4
        Me.MakePlacementButton.Tag = "Make the placement with the selected classes and classerooms"
        Me.MakePlacementButton.Text = "Make placement"
        Me.MakePlacementButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(627, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 20)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Placement options:"
        '
        'PlacementOptionsCheckedListBox
        '
        Me.PlacementOptionsCheckedListBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PlacementOptionsCheckedListBox.BackColor = System.Drawing.SystemColors.Control
        Me.PlacementOptionsCheckedListBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PlacementOptionsCheckedListBox.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.PlacementOptionsCheckedListBox.FormattingEnabled = True
        Me.PlacementOptionsCheckedListBox.Items.AddRange(New Object() {"Group subjects", "Group classes"})
        Me.PlacementOptionsCheckedListBox.Location = New System.Drawing.Point(777, 12)
        Me.PlacementOptionsCheckedListBox.Name = "PlacementOptionsCheckedListBox"
        Me.PlacementOptionsCheckedListBox.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.PlacementOptionsCheckedListBox.Size = New System.Drawing.Size(142, 42)
        Me.PlacementOptionsCheckedListBox.TabIndex = 5
        '
        'ViewByComboBox
        '
        Me.ViewByComboBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ViewByComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ViewByComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ViewByComboBox.Items.AddRange(New Object() {"All", "Class", "Subject", "Class and subject", "Room", "Class and room", "Class Room and subject"})
        Me.ViewByComboBox.Location = New System.Drawing.Point(1002, 18)
        Me.ViewByComboBox.Name = "ViewByComboBox"
        Me.ViewByComboBox.Size = New System.Drawing.Size(188, 28)
        Me.ViewByComboBox.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(933, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 20)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "View by"
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.TextBox1.Cursor = System.Windows.Forms.Cursors.Default
        Me.TextBox1.Location = New System.Drawing.Point(925, 18)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(2, 26)
        Me.TextBox1.TabIndex = 12
        Me.TextBox1.TabStop = False
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox2.BackColor = System.Drawing.SystemColors.ControlDark
        Me.TextBox2.Cursor = System.Windows.Forms.Cursors.Default
        Me.TextBox2.Location = New System.Drawing.Point(619, 18)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(2, 26)
        Me.TextBox2.TabIndex = 13
        Me.TextBox2.TabStop = False
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(0, 25)
        '
        'StatusBar
        '
        Me.StatusBar.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.StatusBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel2, Me.HoverStatusLabel, Me.GeneralStatusLabel})
        Me.StatusBar.Location = New System.Drawing.Point(0, 568)
        Me.StatusBar.Name = "StatusBar"
        Me.StatusBar.Size = New System.Drawing.Size(1202, 30)
        Me.StatusBar.TabIndex = 0
        Me.StatusBar.Text = "StatusStrip1"
        '
        'HoverStatusLabel
        '
        Me.HoverStatusLabel.Name = "HoverStatusLabel"
        Me.HoverStatusLabel.Size = New System.Drawing.Size(976, 25)
        Me.HoverStatusLabel.Spring = True
        Me.HoverStatusLabel.Text = "Hover a control for help"
        Me.HoverStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.HoverStatusLabel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'GeneralStatusLabel
        '
        Me.GeneralStatusLabel.Name = "GeneralStatusLabel"
        Me.GeneralStatusLabel.Size = New System.Drawing.Size(211, 25)
        Me.GeneralStatusLabel.Text = "Made with love by Diego"
        Me.GeneralStatusLabel.ToolTipText = "ok"
        '
        'FolderBrowserDialog1
        '
        Me.FolderBrowserDialog1.SelectedPath = "C:\Users\diego\Documents\Programation\Exami\Data"
        '
        'RoomManager1
        '
        Me.RoomManager1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RoomManager1.Location = New System.Drawing.Point(0, 0)
        Me.RoomManager1.MinimumSize = New System.Drawing.Size(254, 0)
        Me.RoomManager1.Name = "RoomManager1"
        Me.RoomManager1.Padding = New System.Windows.Forms.Padding(3)
        Me.RoomManager1.Size = New System.Drawing.Size(254, 269)
        Me.RoomManager1.TabIndex = 1
        '
        'PlacementBox3
        '
        Me.PlacementBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PlacementBox3.Location = New System.Drawing.Point(625, 0)
        Me.PlacementBox3.MinimumSize = New System.Drawing.Size(242, 2)
        Me.PlacementBox3.Name = "PlacementBox3"
        Me.PlacementBox3.Size = New System.Drawing.Size(298, 508)
        Me.PlacementBox3.Students = Nothing
        Me.PlacementBox3.TabIndex = 2
        Me.PlacementBox3.Title = "Name"
        '
        'PlacementBox2
        '
        Me.PlacementBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PlacementBox2.Location = New System.Drawing.Point(310, 0)
        Me.PlacementBox2.MinimumSize = New System.Drawing.Size(242, 2)
        Me.PlacementBox2.Name = "PlacementBox2"
        Me.PlacementBox2.Size = New System.Drawing.Size(309, 508)
        Me.PlacementBox2.Students = Nothing
        Me.PlacementBox2.TabIndex = 1
        Me.PlacementBox2.Title = "Name"
        '
        'PlacementBox1
        '
        Me.PlacementBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PlacementBox1.Location = New System.Drawing.Point(3, 0)
        Me.PlacementBox1.MinimumSize = New System.Drawing.Size(242, 2)
        Me.PlacementBox1.Name = "PlacementBox1"
        Me.PlacementBox1.Size = New System.Drawing.Size(301, 508)
        Me.PlacementBox1.Students = Nothing
        Me.PlacementBox1.TabIndex = 0
        Me.PlacementBox1.Title = "Name"
        '
        'SubjectManager1
        '
        Me.SubjectManager1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SubjectManager1.Location = New System.Drawing.Point(3, 3)
        Me.SubjectManager1.Name = "SubjectManager1"
        Me.SubjectManager1.Size = New System.Drawing.Size(246, 225)
        Me.SubjectManager1.TabIndex = 3
        '
        'Exami2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1202, 598)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ViewByComboBox)
        Me.Controls.Add(Me.PlacementOptionsCheckedListBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MakePlacementButton)
        Me.Controls.Add(Me.SaveAllButton)
        Me.Controls.Add(Me.PrintAllButton)
        Me.Controls.Add(Me.ConvertFolderButton)
        Me.Controls.Add(Me.SelectFolderButton)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.StatusBar)
        Me.MinimumSize = New System.Drawing.Size(1187, 56)
        Me.Name = "Exami2"
        Me.Text = "Exami2"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.StatusBar.ResumeLayout(False)
        Me.StatusBar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents SelectFolderButton As Button
    Friend WithEvents ConvertFolderButton As Button
    Friend WithEvents PrintAllButton As Button
    Friend WithEvents SaveAllButton As Button
    Friend WithEvents MakePlacementButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PlacementOptionsCheckedListBox As CheckedListBox
    Friend WithEvents ViewByComboBox As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents StatusBar As StatusStrip
    Friend WithEvents PlacementBox2 As PlacementBox
    Friend WithEvents PlacementBox1 As PlacementBox
    Friend WithEvents HoverStatusLabel As ToolStripStatusLabel
    Friend WithEvents GeneralStatusLabel As ToolStripStatusLabel
    Friend WithEvents PlacementBox3 As PlacementBox
    Friend WithEvents RoomManager1 As Exami.RoomManager
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents SubjectManager1 As SubjectManager
End Class
