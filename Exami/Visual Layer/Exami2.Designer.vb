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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Exami2))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.SubjectTreeManager1 = New Exami.SubjectTreeManager()
        Me.RoomManager1 = New Exami.RoomManager()
        Me.PlacementBoxes1 = New Exami.PlacementBoxes()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusBar = New System.Windows.Forms.StatusStrip()
        Me.HoverStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GeneralStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenButton = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.AddStudentButton = New System.Windows.Forms.Button()
        Me.SettingsButton = New System.Windows.Forms.Button()
        Me.ReloadFolderButton = New System.Windows.Forms.Button()
        Me.MakePlacementButton = New System.Windows.Forms.Button()
        Me.SelectFolderButton = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SaveAllButton = New System.Windows.Forms.Button()
        Me.PrintAllButton = New System.Windows.Forms.Button()
        Me.SortOptions1 = New Exami.SortOptions()
        Me.OptionsSelector1 = New Exami.OptionsSelector()
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
        Me.SplitContainer2.Panel1.Controls.Add(Me.SubjectTreeManager1)
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
        'SubjectTreeManager1
        '
        Me.SubjectTreeManager1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SubjectTreeManager1.Location = New System.Drawing.Point(3, 3)
        Me.SubjectTreeManager1.Name = "SubjectTreeManager1"
        Me.SubjectTreeManager1.Size = New System.Drawing.Size(246, 202)
        Me.SubjectTreeManager1.TabIndex = 38
        '
        'RoomManager1
        '
        Me.RoomManager1.AutoSize = True
        Me.RoomManager1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.RoomManager1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RoomManager1.Location = New System.Drawing.Point(0, 0)
        Me.RoomManager1.MinimumSize = New System.Drawing.Size(254, 0)
        Me.RoomManager1.Name = "RoomManager1"
        Me.RoomManager1.Padding = New System.Windows.Forms.Padding(3)
        Me.RoomManager1.Size = New System.Drawing.Size(254, 263)
        Me.RoomManager1.TabIndex = 0
        '
        'PlacementBoxes1
        '
        Me.PlacementBoxes1.AutoScroll = True
        Me.PlacementBoxes1.AutoSize = True
        Me.PlacementBoxes1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.PlacementBoxes1.Location = New System.Drawing.Point(0, 0)
        Me.PlacementBoxes1.Name = "PlacementBoxes1"
        Me.PlacementBoxes1.Size = New System.Drawing.Size(0, 0)
        Me.PlacementBoxes1.TabIndex = 0
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
        Me.OpenButton.TabIndex = 2
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
        'AddStudentButton
        '
        Me.AddStudentButton.BackgroundImage = Global.Exami.My.Resources.Resources.add_student
        Me.AddStudentButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.AddStudentButton.Enabled = False
        Me.AddStudentButton.Location = New System.Drawing.Point(449, 12)
        Me.AddStudentButton.Name = "AddStudentButton"
        Me.AddStudentButton.Size = New System.Drawing.Size(34, 34)
        Me.AddStudentButton.TabIndex = 9
        Me.AddStudentButton.Tag = "Add someone to this placement"
        Me.AddStudentButton.UseVisualStyleBackColor = True
        '
        'SettingsButton
        '
        Me.SettingsButton.BackgroundImage = CType(resources.GetObject("SettingsButton.BackgroundImage"), System.Drawing.Image)
        Me.SettingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SettingsButton.Location = New System.Drawing.Point(569, 12)
        Me.SettingsButton.Name = "SettingsButton"
        Me.SettingsButton.Size = New System.Drawing.Size(34, 34)
        Me.SettingsButton.TabIndex = 6
        Me.SettingsButton.Tag = "Open the settings"
        Me.SettingsButton.UseVisualStyleBackColor = True
        '
        'ReloadFolderButton
        '
        Me.ReloadFolderButton.Image = CType(resources.GetObject("ReloadFolderButton.Image"), System.Drawing.Image)
        Me.ReloadFolderButton.Location = New System.Drawing.Point(159, 12)
        Me.ReloadFolderButton.Name = "ReloadFolderButton"
        Me.ReloadFolderButton.Size = New System.Drawing.Size(34, 34)
        Me.ReloadFolderButton.TabIndex = 1
        Me.ReloadFolderButton.Tag = "Reload the selected folder"
        Me.ReloadFolderButton.UseVisualStyleBackColor = True
        '
        'MakePlacementButton
        '
        Me.MakePlacementButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MakePlacementButton.Enabled = False
        Me.MakePlacementButton.Image = CType(resources.GetObject("MakePlacementButton.Image"), System.Drawing.Image)
        Me.MakePlacementButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MakePlacementButton.Location = New System.Drawing.Point(282, 12)
        Me.MakePlacementButton.Name = "MakePlacementButton"
        Me.MakePlacementButton.Size = New System.Drawing.Size(168, 34)
        Me.MakePlacementButton.TabIndex = 5
        Me.MakePlacementButton.Tag = "Make the placement with the selected classes and classerooms"
        Me.MakePlacementButton.Text = "&Make placement"
        Me.MakePlacementButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.MakePlacementButton.UseVisualStyleBackColor = True
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
        'SaveAllButton
        '
        Me.SaveAllButton.BackgroundImage = CType(resources.GetObject("SaveAllButton.BackgroundImage"), System.Drawing.Image)
        Me.SaveAllButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SaveAllButton.Enabled = False
        Me.SaveAllButton.Location = New System.Drawing.Point(489, 12)
        Me.SaveAllButton.Name = "SaveAllButton"
        Me.SaveAllButton.Size = New System.Drawing.Size(34, 34)
        Me.SaveAllButton.TabIndex = 37
        Me.SaveAllButton.Tag = "Save the whole seating plan"
        Me.SaveAllButton.UseVisualStyleBackColor = True
        '
        'PrintAllButton
        '
        Me.PrintAllButton.BackgroundImage = CType(resources.GetObject("PrintAllButton.BackgroundImage"), System.Drawing.Image)
        Me.PrintAllButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PrintAllButton.Enabled = False
        Me.PrintAllButton.Location = New System.Drawing.Point(529, 12)
        Me.PrintAllButton.Name = "PrintAllButton"
        Me.PrintAllButton.Size = New System.Drawing.Size(34, 34)
        Me.PrintAllButton.TabIndex = 36
        Me.PrintAllButton.Tag = "Print the whole seating plan"
        Me.PrintAllButton.UseVisualStyleBackColor = True
        '
        'SortOptions1
        '
        Me.SortOptions1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SortOptions1.AutoSize = True
        Me.SortOptions1.Enabled = False
        Me.SortOptions1.Location = New System.Drawing.Point(609, 8)
        Me.SortOptions1.Name = "SortOptions1"
        Me.SortOptions1.Size = New System.Drawing.Size(386, 40)
        Me.SortOptions1.TabIndex = 10
        Me.SortOptions1.Tag = "Options to change how students are placed"
        '
        'OptionsSelector1
        '
        Me.OptionsSelector1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OptionsSelector1.AutoSize = True
        Me.OptionsSelector1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.OptionsSelector1.Enabled = False
        Me.OptionsSelector1.Location = New System.Drawing.Point(1001, 8)
        Me.OptionsSelector1.Name = "OptionsSelector1"
        Me.OptionsSelector1.Size = New System.Drawing.Size(174, 48)
        Me.OptionsSelector1.TabIndex = 8
        '
        'Exami2
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1178, 561)
        Me.Controls.Add(Me.SaveAllButton)
        Me.Controls.Add(Me.SortOptions1)
        Me.Controls.Add(Me.PrintAllButton)
        Me.Controls.Add(Me.AddStudentButton)
        Me.Controls.Add(Me.OptionsSelector1)
        Me.Controls.Add(Me.SettingsButton)
        Me.Controls.Add(Me.OpenButton)
        Me.Controls.Add(Me.ReloadFolderButton)
        Me.Controls.Add(Me.MakePlacementButton)
        Me.Controls.Add(Me.SelectFolderButton)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.StatusBar)
        Me.MinimumSize = New System.Drawing.Size(940, 400)
        Me.Name = "Exami2"
        Me.Text = "Exami2"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.Panel2.PerformLayout()
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
    Friend WithEvents MakePlacementButton As Button
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents StatusBar As StatusStrip
    Friend WithEvents HoverStatusLabel As ToolStripStatusLabel
    Friend WithEvents GeneralStatusLabel As ToolStripStatusLabel
    Friend WithEvents RoomManager1 As Exami.RoomManager
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents PlacementBoxes1 As PlacementBoxes
    Friend WithEvents ReloadFolderButton As Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents OpenButton As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents SettingsButton As Button
    Friend WithEvents OptionsSelector1 As OptionsSelector
    Friend WithEvents AddStudentButton As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents SortOptions1 As SortOptions
    Friend WithEvents SaveAllButton As Button
    Friend WithEvents PrintAllButton As Button
    Friend WithEvents SubjectTreeManager1 As SubjectTreeManager
End Class
