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
        'Label1
        '
        Me.EmptyFolderLabel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.EmptyFolderLabel.AutoSize = True
        Me.EmptyFolderLabel.Location = New System.Drawing.Point(138, 168)
        Me.EmptyFolderLabel.Name = "Label1"
        Me.EmptyFolderLabel.Size = New System.Drawing.Size(142, 20)
        Me.EmptyFolderLabel.TabIndex = 1
        Me.EmptyFolderLabel.Text = "No data files found"
        '
        'SubjectTreeManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.EmptyFolderLabel)
        Me.Controls.Add(Me.TreeView1)
        Me.Name = "SubjectTreeManager"
        Me.Size = New System.Drawing.Size(420, 361)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TreeView1 As TreeView
    Friend WithEvents EmptyFolderLabel As Label
End Class
