<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SortOptions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SortOptions))
        Me.SnakeButton = New System.Windows.Forms.Button()
        Me.SaveAllButton = New System.Windows.Forms.Button()
        Me.PrintAllButton = New System.Windows.Forms.Button()
        Me.ShuffleButton = New System.Windows.Forms.Button()
        Me.NumSortAllButton = New System.Windows.Forms.Button()
        Me.AzSortButton = New System.Windows.Forms.Button()
        Me.GroupClassesButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'SnakeButton
        '
        Me.SnakeButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.SnakeButton.BackgroundImage = Global.Exami.My.Resources.Resources.snake2
        Me.SnakeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SnakeButton.Location = New System.Drawing.Point(243, 3)
        Me.SnakeButton.Name = "SnakeButton"
        Me.SnakeButton.Size = New System.Drawing.Size(34, 34)
        Me.SnakeButton.TabIndex = 36
        Me.SnakeButton.Tag = "Students are placed in a snake pattern in the class"
        Me.SnakeButton.UseVisualStyleBackColor = True
        '
        'SaveAllButton
        '
        Me.SaveAllButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.SaveAllButton.BackgroundImage = CType(resources.GetObject("SaveAllButton.BackgroundImage"), System.Drawing.Image)
        Me.SaveAllButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SaveAllButton.Location = New System.Drawing.Point(3, 3)
        Me.SaveAllButton.Name = "SaveAllButton"
        Me.SaveAllButton.Size = New System.Drawing.Size(34, 34)
        Me.SaveAllButton.TabIndex = 35
        Me.SaveAllButton.Tag = "Save the whole seating plan"
        Me.SaveAllButton.UseVisualStyleBackColor = True
        '
        'PrintAllButton
        '
        Me.PrintAllButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PrintAllButton.BackgroundImage = CType(resources.GetObject("PrintAllButton.BackgroundImage"), System.Drawing.Image)
        Me.PrintAllButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PrintAllButton.Location = New System.Drawing.Point(43, 3)
        Me.PrintAllButton.Name = "PrintAllButton"
        Me.PrintAllButton.Size = New System.Drawing.Size(34, 34)
        Me.PrintAllButton.TabIndex = 34
        Me.PrintAllButton.Tag = "Print the whole seating plan"
        Me.PrintAllButton.UseVisualStyleBackColor = True
        '
        'ShuffleButton
        '
        Me.ShuffleButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ShuffleButton.BackgroundImage = CType(resources.GetObject("ShuffleButton.BackgroundImage"), System.Drawing.Image)
        Me.ShuffleButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ShuffleButton.Location = New System.Drawing.Point(83, 3)
        Me.ShuffleButton.Name = "ShuffleButton"
        Me.ShuffleButton.Size = New System.Drawing.Size(34, 34)
        Me.ShuffleButton.TabIndex = 33
        Me.ShuffleButton.Tag = "Shuffle all the students"
        Me.ShuffleButton.UseVisualStyleBackColor = True
        '
        'NumSortAllButton
        '
        Me.NumSortAllButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.NumSortAllButton.BackgroundImage = CType(resources.GetObject("NumSortAllButton.BackgroundImage"), System.Drawing.Image)
        Me.NumSortAllButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.NumSortAllButton.Location = New System.Drawing.Point(123, 3)
        Me.NumSortAllButton.Name = "NumSortAllButton"
        Me.NumSortAllButton.Size = New System.Drawing.Size(34, 34)
        Me.NumSortAllButton.TabIndex = 32
        Me.NumSortAllButton.Tag = "Sort sudents by their number"
        Me.NumSortAllButton.UseVisualStyleBackColor = True
        '
        'AzSortButton
        '
        Me.AzSortButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.AzSortButton.BackgroundImage = CType(resources.GetObject("AzSortButton.BackgroundImage"), System.Drawing.Image)
        Me.AzSortButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.AzSortButton.Location = New System.Drawing.Point(163, 3)
        Me.AzSortButton.Name = "AzSortButton"
        Me.AzSortButton.Size = New System.Drawing.Size(34, 34)
        Me.AzSortButton.TabIndex = 31
        Me.AzSortButton.Tag = "Sort all the students by alphabetical order"
        Me.AzSortButton.UseVisualStyleBackColor = True
        '
        'GroupClassesButton
        '
        Me.GroupClassesButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupClassesButton.BackgroundImage = Global.Exami.My.Resources.Resources.group
        Me.GroupClassesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupClassesButton.Location = New System.Drawing.Point(203, 3)
        Me.GroupClassesButton.Name = "GroupClassesButton"
        Me.GroupClassesButton.Size = New System.Drawing.Size(34, 34)
        Me.GroupClassesButton.TabIndex = 30
        Me.GroupClassesButton.Tag = "Ungroup classes"
        Me.GroupClassesButton.UseVisualStyleBackColor = True
        '
        'SortOptions
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.Controls.Add(Me.SnakeButton)
        Me.Controls.Add(Me.SaveAllButton)
        Me.Controls.Add(Me.PrintAllButton)
        Me.Controls.Add(Me.ShuffleButton)
        Me.Controls.Add(Me.NumSortAllButton)
        Me.Controls.Add(Me.AzSortButton)
        Me.Controls.Add(Me.GroupClassesButton)
        Me.Name = "SortOptions"
        Me.Size = New System.Drawing.Size(280, 40)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SaveAllButton As Button
    Friend WithEvents PrintAllButton As Button
    Friend WithEvents ShuffleButton As Button
    Friend WithEvents NumSortAllButton As Button
    Friend WithEvents AzSortButton As Button
    Friend WithEvents GroupClassesButton As Button
    Friend WithEvents SnakeButton As Button
End Class
