<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RoomManager
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RoomManager))
        Me.RenameRoomButton = New System.Windows.Forms.Button()
        Me.RoomsListBox = New System.Windows.Forms.CheckedListBox()
        Me.ModifyRoomButton = New System.Windows.Forms.Button()
        Me.CopyRoomButton = New System.Windows.Forms.Button()
        Me.CreateRoomButton = New System.Windows.Forms.Button()
        Me.DeleteRoomButton = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.WarnImage = New System.Windows.Forms.PictureBox()
        Me.EmptyFolderLabel = New System.Windows.Forms.Label()
        CType(Me.WarnImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RenameRoomButton
        '
        Me.RenameRoomButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.RenameRoomButton.BackgroundImage = CType(resources.GetObject("RenameRoomButton.BackgroundImage"), System.Drawing.Image)
        Me.RenameRoomButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RenameRoomButton.Enabled = False
        Me.RenameRoomButton.Location = New System.Drawing.Point(202, 210)
        Me.RenameRoomButton.Name = "RenameRoomButton"
        Me.RenameRoomButton.Size = New System.Drawing.Size(42, 42)
        Me.RenameRoomButton.TabIndex = 13
        Me.RenameRoomButton.Tag = "Rename the selected room"
        Me.RenameRoomButton.UseVisualStyleBackColor = True
        '
        'RoomsListBox
        '
        Me.RoomsListBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RoomsListBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RoomsListBox.CheckOnClick = True
        Me.RoomsListBox.Enabled = False
        Me.RoomsListBox.FormattingEnabled = True
        Me.RoomsListBox.HorizontalScrollbar = True
        Me.RoomsListBox.IntegralHeight = False
        Me.RoomsListBox.Items.AddRange(New Object() {"Select a folder to see rooms"})
        Me.RoomsListBox.Location = New System.Drawing.Point(0, 0)
        Me.RoomsListBox.Name = "RoomsListBox"
        Me.RoomsListBox.Size = New System.Drawing.Size(254, 204)
        Me.RoomsListBox.TabIndex = 7
        '
        'ModifyRoomButton
        '
        Me.ModifyRoomButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.ModifyRoomButton.BackgroundImage = CType(resources.GetObject("ModifyRoomButton.BackgroundImage"), System.Drawing.Image)
        Me.ModifyRoomButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ModifyRoomButton.Location = New System.Drawing.Point(154, 210)
        Me.ModifyRoomButton.Name = "ModifyRoomButton"
        Me.ModifyRoomButton.Size = New System.Drawing.Size(42, 42)
        Me.ModifyRoomButton.TabIndex = 12
        Me.ModifyRoomButton.Tag = "Modify the selected room"
        Me.ModifyRoomButton.UseVisualStyleBackColor = True
        '
        'CopyRoomButton
        '
        Me.CopyRoomButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.CopyRoomButton.BackgroundImage = CType(resources.GetObject("CopyRoomButton.BackgroundImage"), System.Drawing.Image)
        Me.CopyRoomButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CopyRoomButton.Enabled = False
        Me.CopyRoomButton.Location = New System.Drawing.Point(106, 210)
        Me.CopyRoomButton.Name = "CopyRoomButton"
        Me.CopyRoomButton.Size = New System.Drawing.Size(42, 42)
        Me.CopyRoomButton.TabIndex = 11
        Me.CopyRoomButton.Tag = "Create a copy of the selected rooms"
        Me.CopyRoomButton.UseVisualStyleBackColor = True
        '
        'CreateRoomButton
        '
        Me.CreateRoomButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.CreateRoomButton.BackgroundImage = CType(resources.GetObject("CreateRoomButton.BackgroundImage"), System.Drawing.Image)
        Me.CreateRoomButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CreateRoomButton.Enabled = False
        Me.CreateRoomButton.Location = New System.Drawing.Point(10, 210)
        Me.CreateRoomButton.Name = "CreateRoomButton"
        Me.CreateRoomButton.Size = New System.Drawing.Size(42, 42)
        Me.CreateRoomButton.TabIndex = 8
        Me.CreateRoomButton.Tag = "Create a new classroom with a custom disposition"
        Me.CreateRoomButton.UseVisualStyleBackColor = True
        '
        'DeleteRoomButton
        '
        Me.DeleteRoomButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.DeleteRoomButton.BackgroundImage = CType(resources.GetObject("DeleteRoomButton.BackgroundImage"), System.Drawing.Image)
        Me.DeleteRoomButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.DeleteRoomButton.Enabled = False
        Me.DeleteRoomButton.Location = New System.Drawing.Point(58, 210)
        Me.DeleteRoomButton.Name = "DeleteRoomButton"
        Me.DeleteRoomButton.Size = New System.Drawing.Size(42, 42)
        Me.DeleteRoomButton.TabIndex = 9
        Me.DeleteRoomButton.Tag = "Delete the selected rooms"
        Me.DeleteRoomButton.UseVisualStyleBackColor = True
        '
        'WarnImage
        '
        Me.WarnImage.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.WarnImage.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.WarnImage.BackgroundImage = Global.Exami.My.Resources.Resources.argh
        Me.WarnImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.WarnImage.Location = New System.Drawing.Point(81, 58)
        Me.WarnImage.Name = "WarnImage"
        Me.WarnImage.Size = New System.Drawing.Size(96, 96)
        Me.WarnImage.TabIndex = 15
        Me.WarnImage.TabStop = False
        Me.WarnImage.Tag = "You need to select a new folder"
        '
        'EmptyFolderLabel
        '
        Me.EmptyFolderLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.EmptyFolderLabel.AutoSize = True
        Me.EmptyFolderLabel.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.EmptyFolderLabel.Location = New System.Drawing.Point(66, 157)
        Me.EmptyFolderLabel.Name = "EmptyFolderLabel"
        Me.EmptyFolderLabel.Size = New System.Drawing.Size(122, 20)
        Me.EmptyFolderLabel.TabIndex = 14
        Me.EmptyFolderLabel.Tag = "You need to select a new folder"
        Me.EmptyFolderLabel.Text = "No rooms found"
        '
        'RoomManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.WarnImage)
        Me.Controls.Add(Me.EmptyFolderLabel)
        Me.Controls.Add(Me.RenameRoomButton)
        Me.Controls.Add(Me.RoomsListBox)
        Me.Controls.Add(Me.ModifyRoomButton)
        Me.Controls.Add(Me.CopyRoomButton)
        Me.Controls.Add(Me.CreateRoomButton)
        Me.Controls.Add(Me.DeleteRoomButton)
        Me.MinimumSize = New System.Drawing.Size(254, 0)
        Me.Name = "RoomManager"
        Me.Size = New System.Drawing.Size(254, 255)
        Me.Tag = "You need to select a new folder"
        CType(Me.WarnImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RenameRoomButton As Button
    Friend WithEvents RoomsListBox As CheckedListBox
    Friend WithEvents ModifyRoomButton As Button
    Friend WithEvents CopyRoomButton As Button
    Friend WithEvents CreateRoomButton As Button
    Friend WithEvents DeleteRoomButton As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents WarnImage As PictureBox
    Friend WithEvents EmptyFolderLabel As Label
End Class
