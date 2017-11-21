<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SubjectTreeManager
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
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.EmptyFolderLabel = New System.Windows.Forms.Label()
        Me.WarnImage = New System.Windows.Forms.PictureBox()
        CType(Me.WarnImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TreeView1
        '
        Me.TreeView1.CheckBoxes = True
        Me.TreeView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView1.Location = New System.Drawing.Point(0, 0)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(420, 361)
        Me.TreeView1.TabIndex = 0
        '
        'EmptyFolderLabel
        '
        Me.EmptyFolderLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.EmptyFolderLabel.AutoSize = True
        Me.EmptyFolderLabel.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.EmptyFolderLabel.Location = New System.Drawing.Point(139, 199)
        Me.EmptyFolderLabel.Name = "EmptyFolderLabel"
        Me.EmptyFolderLabel.Size = New System.Drawing.Size(142, 20)
        Me.EmptyFolderLabel.TabIndex = 1
        Me.EmptyFolderLabel.Text = "No data files found"
        '
        'WarnImage
        '
        Me.WarnImage.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.WarnImage.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.WarnImage.BackgroundImage = Global.Exami.My.Resources.Resources.argh
        Me.WarnImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.WarnImage.Location = New System.Drawing.Point(0, 110)
        Me.WarnImage.Name = "WarnImage"
        Me.WarnImage.Size = New System.Drawing.Size(420, 86)
        Me.WarnImage.TabIndex = 2
        Me.WarnImage.TabStop = False
        '
        'SubjectTreeManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.WarnImage)
        Me.Controls.Add(Me.EmptyFolderLabel)
        Me.Controls.Add(Me.TreeView1)
        Me.Name = "SubjectTreeManager"
        Me.Size = New System.Drawing.Size(420, 361)
        CType(Me.WarnImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TreeView1 As TreeView
    Friend WithEvents EmptyFolderLabel As Label
    Friend WithEvents WarnImage As PictureBox
End Class
