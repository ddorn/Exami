﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Settings))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.VersionLabel = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ChooseDataDirButton = New System.Windows.Forms.Button()
        Me.DataDirLabel = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ChooseSaveDirButton = New System.Windows.Forms.Button()
        Me.SaveDirLabel = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LinkLabel4 = New System.Windows.Forms.LinkLabel()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe Script", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(362, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 67)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Exami"
        '
        'VersionLabel
        '
        Me.VersionLabel.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.VersionLabel.AutoSize = True
        Me.VersionLabel.Location = New System.Drawing.Point(519, 49)
        Me.VersionLabel.Name = "VersionLabel"
        Me.VersionLabel.Size = New System.Drawing.Size(51, 20)
        Me.VersionLabel.TabIndex = 1
        Me.VersionLabel.Text = "v2.2.0"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabel1.LinkColor = System.Drawing.SystemColors.ControlText
        Me.LinkLabel1.Location = New System.Drawing.Point(715, 239)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(57, 20)
        Me.LinkLabel1.TabIndex = 2
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Icons8"
        Me.LinkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LinkLabel1.VisitedLinkColor = System.Drawing.SystemColors.ControlText
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(678, 139)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 32)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Thanks to"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabel2.LinkColor = System.Drawing.SystemColors.ControlText
        Me.LinkLabel2.Location = New System.Drawing.Point(688, 271)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(111, 20)
        Me.LinkLabel2.TabIndex = 5
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "StackOverflow"
        Me.LinkLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LinkLabel2.VisitedLinkColor = System.Drawing.SystemColors.ControlText
        '
        'LinkLabel3
        '
        Me.LinkLabel3.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabel3.LinkColor = System.Drawing.SystemColors.ControlText
        Me.LinkLabel3.Location = New System.Drawing.Point(712, 303)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(63, 20)
        Me.LinkLabel3.TabIndex = 6
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "Michael"
        Me.LinkLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LinkLabel3.VisitedLinkColor = System.Drawing.SystemColors.ControlText
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Data directory"
        '
        'ChooseDataDirButton
        '
        Me.ChooseDataDirButton.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ChooseDataDirButton.Location = New System.Drawing.Point(31, 173)
        Me.ChooseDataDirButton.Name = "ChooseDataDirButton"
        Me.ChooseDataDirButton.Size = New System.Drawing.Size(76, 28)
        Me.ChooseDataDirButton.TabIndex = 8
        Me.ChooseDataDirButton.Text = "Change"
        Me.ChooseDataDirButton.UseVisualStyleBackColor = True
        '
        'DataDirLabel
        '
        Me.DataDirLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.DataDirLabel.AutoSize = True
        Me.DataDirLabel.Location = New System.Drawing.Point(113, 177)
        Me.DataDirLabel.Name = "DataDirLabel"
        Me.DataDirLabel.Size = New System.Drawing.Size(131, 20)
        Me.DataDirLabel.TabIndex = 9
        Me.DataDirLabel.Text = "Path/To/Directory"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 224)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(190, 20)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Favorite save directory"
        '
        'ChooseSaveDirButton
        '
        Me.ChooseSaveDirButton.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ChooseSaveDirButton.Location = New System.Drawing.Point(31, 247)
        Me.ChooseSaveDirButton.Name = "ChooseSaveDirButton"
        Me.ChooseSaveDirButton.Size = New System.Drawing.Size(76, 28)
        Me.ChooseSaveDirButton.TabIndex = 11
        Me.ChooseSaveDirButton.Text = "Change"
        Me.ChooseSaveDirButton.UseVisualStyleBackColor = True
        '
        'SaveDirLabel
        '
        Me.SaveDirLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.SaveDirLabel.AutoSize = True
        Me.SaveDirLabel.Location = New System.Drawing.Point(113, 251)
        Me.SaveDirLabel.Name = "SaveDirLabel"
        Me.SaveDirLabel.Size = New System.Drawing.Size(131, 20)
        Me.SaveDirLabel.TabIndex = 12
        Me.SaveDirLabel.Text = "Path/To/Directory"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(747, 484)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(218, 20)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Made with love by Diego Dorn"
        '
        'LinkLabel4
        '
        Me.LinkLabel4.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LinkLabel4.AutoSize = True
        Me.LinkLabel4.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabel4.LinkColor = System.Drawing.SystemColors.ControlText
        Me.LinkLabel4.Location = New System.Drawing.Point(638, 207)
        Me.LinkLabel4.Name = "LinkLabel4"
        Me.LinkLabel4.Size = New System.Drawing.Size(210, 20)
        Me.LinkLabel4.TabIndex = 14
        Me.LinkLabel4.TabStop = True
        Me.LinkLabel4.Text = "Koonung Secondary College"
        Me.LinkLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LinkLabel4.VisitedLinkColor = System.Drawing.SystemColors.ControlText
        '
        'Settings
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(977, 513)
        Me.Controls.Add(Me.LinkLabel4)
        Me.Controls.Add(Me.LinkLabel3)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.SaveDirLabel)
        Me.Controls.Add(Me.ChooseSaveDirButton)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DataDirLabel)
        Me.Controls.Add(Me.ChooseDataDirButton)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.VersionLabel)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Settings"
        Me.Text = "Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents VersionLabel As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label4 As Label
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents LinkLabel3 As LinkLabel
    Friend WithEvents Label3 As Label
    Friend WithEvents ChooseDataDirButton As Button
    Friend WithEvents DataDirLabel As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ChooseSaveDirButton As Button
    Friend WithEvents SaveDirLabel As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents LinkLabel4 As LinkLabel
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
End Class
