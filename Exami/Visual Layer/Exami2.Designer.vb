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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Exami2))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.SubjectManager1 = New Exami.SubjectManager()
        Me.RoomManager1 = New Exami.RoomManager()
        Me.PlacementBoxes1 = New Exami.PlacementBoxes()
        Me.SelectFolderButton = New System.Windows.Forms.Button()
        Me.PrintAllButton = New System.Windows.Forms.Button()
        Me.SaveAllButton = New System.Windows.Forms.Button()
        Me.MakePlacementButton = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusBar = New System.Windows.Forms.StatusStrip()
        Me.HoverStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GeneralStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.ReloadFolderButton = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenButton = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PlacementViewBySelector1 = New Exami.PlacementViewBySelector()
        Me.SettingsButton = New System.Windows.Forms.Button()
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
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 52)
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
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.PlacementBoxes1)
        Me.SplitContainer1.Panel2MinSize = 100
        Me.SplitContainer1.Size = New System.Drawing.Size(1178, 479)
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
        Me.SplitContainer2.Size = New System.Drawing.Size(254, 479)
        Me.SplitContainer2.SplitterDistance = 210
        Me.SplitContainer2.TabIndex = 21
        Me.SplitContainer2.TabStop = False
        '
        'SubjectManager1
        '
        Me.SubjectManager1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SubjectManager1.Location = New System.Drawing.Point(3, 3)
        Me.SubjectManager1.Name = "SubjectManager1"
        Me.SubjectManager1.Size = New System.Drawing.Size(246, 202)
        Me.SubjectManager1.TabIndex = 21
        '
        'RoomManager1
        '
        Me.RoomManager1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RoomManager1.Location = New System.Drawing.Point(0, 0)
        Me.RoomManager1.MinimumSize = New System.Drawing.Size(254, 0)
        Me.RoomManager1.Name = "RoomManager1"
        Me.RoomManager1.Padding = New System.Windows.Forms.Padding(3)
        Me.RoomManager1.Size = New System.Drawing.Size(254, 263)
        Me.RoomManager1.TabIndex = 22
        '
        'PlacementBoxes1
        '
        Me.PlacementBoxes1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PlacementBoxes1.Location = New System.Drawing.Point(0, 0)
        Me.PlacementBoxes1.Name = "PlacementBoxes1"
        Me.PlacementBoxes1.Size = New System.Drawing.Size(916, 479)
        Me.PlacementBoxes1.TabIndex = 23
        '
        'SelectFolderButton
        '
        Me.SelectFolderButton.Image = CType(resources.GetObject("SelectFolderButton.Image"), System.Drawing.Image)
        Me.SelectFolderButton.Location = New System.Drawing.Point(12, 12)
        Me.SelectFolderButton.Name = "SelectFolderButton"
        Me.SelectFolderButton.Size = New System.Drawing.Size(148, 34)
        Me.SelectFolderButton.TabIndex = 0
        Me.SelectFolderButton.Tag = "Select the folder containing the .vass files"
        Me.SelectFolderButton.Text = "Select Folder"
        Me.SelectFolderButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.SelectFolderButton.UseVisualStyleBackColor = True
        '
        'PrintAllButton
        '
        Me.PrintAllButton.Enabled = False
        Me.PrintAllButton.Location = New System.Drawing.Point(365, 12)
        Me.PrintAllButton.Name = "PrintAllButton"
        Me.PrintAllButton.Size = New System.Drawing.Size(76, 34)
        Me.PrintAllButton.TabIndex = 5
        Me.PrintAllButton.Tag = "Print the complete placement : every room, subject and class"
        Me.PrintAllButton.Text = "Print all"
        Me.PrintAllButton.UseVisualStyleBackColor = True
        '
        'SaveAllButton
        '
        Me.SaveAllButton.Enabled = False
        Me.SaveAllButton.Location = New System.Drawing.Point(282, 12)
        Me.SaveAllButton.Name = "SaveAllButton"
        Me.SaveAllButton.Size = New System.Drawing.Size(77, 34)
        Me.SaveAllButton.TabIndex = 4
        Me.SaveAllButton.Tag = "Save the whole placement in a file."
        Me.SaveAllButton.Text = "Save all"
        Me.SaveAllButton.UseVisualStyleBackColor = True
        '
        'MakePlacementButton
        '
        Me.MakePlacementButton.Enabled = False
        Me.MakePlacementButton.Image = CType(resources.GetObject("MakePlacementButton.Image"), System.Drawing.Image)
        Me.MakePlacementButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MakePlacementButton.Location = New System.Drawing.Point(447, 12)
        Me.MakePlacementButton.Name = "MakePlacementButton"
        Me.MakePlacementButton.Size = New System.Drawing.Size(168, 34)
        Me.MakePlacementButton.TabIndex = 6
        Me.MakePlacementButton.Tag = "Make the placement with the selected classes and classerooms"
        Me.MakePlacementButton.Text = "&Make placement"
        Me.MakePlacementButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.MakePlacementButton.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.TextBox1.Cursor = System.Windows.Forms.Cursors.Default
        Me.TextBox1.Location = New System.Drawing.Point(921, 16)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(2, 26)
        Me.TextBox1.TabIndex = 12
        Me.TextBox1.TabStop = False
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
        Me.StatusBar.Location = New System.Drawing.Point(0, 531)
        Me.StatusBar.Name = "StatusBar"
        Me.StatusBar.Size = New System.Drawing.Size(1178, 30)
        Me.StatusBar.TabIndex = 0
        Me.StatusBar.Text = "StatusStrip1"
        '
        'HoverStatusLabel
        '
        Me.HoverStatusLabel.Name = "HoverStatusLabel"
        Me.HoverStatusLabel.Size = New System.Drawing.Size(952, 25)
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
        'ReloadFolderButton
        '
        Me.ReloadFolderButton.Image = CType(resources.GetObject("ReloadFolderButton.Image"), System.Drawing.Image)
        Me.ReloadFolderButton.Location = New System.Drawing.Point(159, 12)
        Me.ReloadFolderButton.Name = "ReloadFolderButton"
        Me.ReloadFolderButton.Size = New System.Drawing.Size(34, 34)
        Me.ReloadFolderButton.TabIndex = 2
        Me.ReloadFolderButton.UseVisualStyleBackColor = True
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.DefaultExt = "mp"
        Me.SaveFileDialog1.Filter = "Placement files|*.mp"
        Me.SaveFileDialog1.Title = "Choose a file to save the placement"
        '
        'OpenButton
        '
        Me.OpenButton.Location = New System.Drawing.Point(199, 12)
        Me.OpenButton.Name = "OpenButton"
        Me.OpenButton.Size = New System.Drawing.Size(77, 34)
        Me.OpenButton.TabIndex = 3
        Me.OpenButton.Tag = "Open a placement I previously did"
        Me.OpenButton.Text = "Open"
        Me.OpenButton.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.DefaultExt = "mp"
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Filter = "Placement files|*.mp"
        Me.OpenFileDialog1.Title = "Choose a placement to open"
        '
        'PrintDialog1
        '
        Me.PrintDialog1.AllowSelection = True
        Me.PrintDialog1.AllowSomePages = True
        Me.PrintDialog1.Document = Me.PrintDocument1
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintDocument1
        '
        Me.PrintDocument1.OriginAtMargins = True
        '
        'PlacementViewBySelector1
        '
        Me.PlacementViewBySelector1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PlacementViewBySelector1.Location = New System.Drawing.Point(929, 8)
        Me.PlacementViewBySelector1.MinimumSize = New System.Drawing.Size(237, 43)
        Me.PlacementViewBySelector1.Name = "PlacementViewBySelector1"
        Me.PlacementViewBySelector1.Size = New System.Drawing.Size(237, 43)
        Me.PlacementViewBySelector1.TabIndex = 20
        '
        'SettingsButton
        '
        Me.SettingsButton.BackgroundImage = CType(resources.GetObject("SettingsButton.BackgroundImage"), System.Drawing.Image)
        Me.SettingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SettingsButton.Location = New System.Drawing.Point(621, 12)
        Me.SettingsButton.Name = "SettingsButton"
        Me.SettingsButton.Size = New System.Drawing.Size(34, 34)
        Me.SettingsButton.TabIndex = 7
        Me.SettingsButton.UseVisualStyleBackColor = True
        '
        'Exami2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1178, 561)
        Me.Controls.Add(Me.SettingsButton)
        Me.Controls.Add(Me.OpenButton)
        Me.Controls.Add(Me.ReloadFolderButton)
        Me.Controls.Add(Me.PlacementViewBySelector1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.MakePlacementButton)
        Me.Controls.Add(Me.SaveAllButton)
        Me.Controls.Add(Me.PrintAllButton)
        Me.Controls.Add(Me.SelectFolderButton)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.StatusBar)
        Me.MinimumSize = New System.Drawing.Size(940, 400)
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
    Friend WithEvents PrintAllButton As Button
    Friend WithEvents SaveAllButton As Button
    Friend WithEvents MakePlacementButton As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents StatusBar As StatusStrip
    Friend WithEvents HoverStatusLabel As ToolStripStatusLabel
    Friend WithEvents GeneralStatusLabel As ToolStripStatusLabel
    Friend WithEvents RoomManager1 As Exami.RoomManager
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents SubjectManager1 As SubjectManager
    Friend WithEvents PlacementViewBySelector1 As PlacementViewBySelector
    Friend WithEvents PlacementBoxes1 As PlacementBoxes
    Friend WithEvents ReloadFolderButton As Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents OpenButton As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents SettingsButton As Button
End Class
