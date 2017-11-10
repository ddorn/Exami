<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OptionsSelector
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OptionsSelector))
        Me.AllCheckBox = New System.Windows.Forms.CheckBox()
        Me.SubjectCheckBox = New System.Windows.Forms.CheckBox()
        Me.RoomCheckBox = New System.Windows.Forms.CheckBox()
        Me.ClassCheckBox = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SaveAllButton = New System.Windows.Forms.Button()
        Me.PrintAllButton = New System.Windows.Forms.Button()
        Me.ShuffleButton = New System.Windows.Forms.Button()
        Me.NumSortAllButton = New System.Windows.Forms.Button()
        Me.AzSortButton = New System.Windows.Forms.Button()
        Me.GroupClassesButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'AllCheckBox
        '
        Me.AllCheckBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AllCheckBox.AutoSize = True
        Me.AllCheckBox.Location = New System.Drawing.Point(468, 21)
        Me.AllCheckBox.Name = "AllCheckBox"
        Me.AllCheckBox.Size = New System.Drawing.Size(52, 24)
        Me.AllCheckBox.TabIndex = 22
        Me.AllCheckBox.Text = "All"
        Me.AllCheckBox.UseVisualStyleBackColor = True
        '
        'SubjectCheckBox
        '
        Me.SubjectCheckBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SubjectCheckBox.AutoSize = True
        Me.SubjectCheckBox.Checked = True
        Me.SubjectCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.SubjectCheckBox.Location = New System.Drawing.Point(468, 0)
        Me.SubjectCheckBox.Name = "SubjectCheckBox"
        Me.SubjectCheckBox.Size = New System.Drawing.Size(89, 24)
        Me.SubjectCheckBox.TabIndex = 21
        Me.SubjectCheckBox.Text = "Subject"
        Me.SubjectCheckBox.UseVisualStyleBackColor = True
        '
        'RoomCheckBox
        '
        Me.RoomCheckBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RoomCheckBox.AutoSize = True
        Me.RoomCheckBox.Location = New System.Drawing.Point(388, 21)
        Me.RoomCheckBox.Name = "RoomCheckBox"
        Me.RoomCheckBox.Size = New System.Drawing.Size(78, 24)
        Me.RoomCheckBox.TabIndex = 20
        Me.RoomCheckBox.Text = "Room"
        Me.RoomCheckBox.UseVisualStyleBackColor = True
        '
        'ClassCheckBox
        '
        Me.ClassCheckBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ClassCheckBox.AutoSize = True
        Me.ClassCheckBox.Checked = True
        Me.ClassCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ClassCheckBox.Location = New System.Drawing.Point(388, 0)
        Me.ClassCheckBox.Name = "ClassCheckBox"
        Me.ClassCheckBox.Size = New System.Drawing.Size(74, 24)
        Me.ClassCheckBox.TabIndex = 19
        Me.ClassCheckBox.Text = "Class"
        Me.ClassCheckBox.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(256, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 20)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "View grouped by"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(248, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(2, 23)
        Me.Label1.TabIndex = 25
        '
        'SaveAllButton
        '
        Me.SaveAllButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaveAllButton.BackgroundImage = CType(resources.GetObject("SaveAllButton.BackgroundImage"), System.Drawing.Image)
        Me.SaveAllButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SaveAllButton.Location = New System.Drawing.Point(6, 4)
        Me.SaveAllButton.Name = "SaveAllButton"
        Me.SaveAllButton.Size = New System.Drawing.Size(34, 34)
        Me.SaveAllButton.TabIndex = 29
        Me.SaveAllButton.Tag = "Save the whole seating plan"
        Me.SaveAllButton.UseVisualStyleBackColor = True
        '
        'PrintAllButton
        '
        Me.PrintAllButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PrintAllButton.BackgroundImage = CType(resources.GetObject("PrintAllButton.BackgroundImage"), System.Drawing.Image)
        Me.PrintAllButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PrintAllButton.Location = New System.Drawing.Point(46, 4)
        Me.PrintAllButton.Name = "PrintAllButton"
        Me.PrintAllButton.Size = New System.Drawing.Size(34, 34)
        Me.PrintAllButton.TabIndex = 28
        Me.PrintAllButton.Tag = "Print the whole seating plan"
        Me.PrintAllButton.UseVisualStyleBackColor = True
        '
        'ShuffleButton
        '
        Me.ShuffleButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ShuffleButton.BackgroundImage = CType(resources.GetObject("ShuffleButton.BackgroundImage"), System.Drawing.Image)
        Me.ShuffleButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ShuffleButton.Location = New System.Drawing.Point(86, 4)
        Me.ShuffleButton.Name = "ShuffleButton"
        Me.ShuffleButton.Size = New System.Drawing.Size(34, 34)
        Me.ShuffleButton.TabIndex = 27
        Me.ShuffleButton.Tag = "Shuffle all the students"
        Me.ShuffleButton.UseVisualStyleBackColor = True
        '
        'NumSortAllButton
        '
        Me.NumSortAllButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NumSortAllButton.BackgroundImage = CType(resources.GetObject("NumSortAllButton.BackgroundImage"), System.Drawing.Image)
        Me.NumSortAllButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.NumSortAllButton.Location = New System.Drawing.Point(126, 4)
        Me.NumSortAllButton.Name = "NumSortAllButton"
        Me.NumSortAllButton.Size = New System.Drawing.Size(34, 34)
        Me.NumSortAllButton.TabIndex = 26
        Me.NumSortAllButton.Tag = "Sort sudents by their number"
        Me.NumSortAllButton.UseVisualStyleBackColor = True
        '
        'AzSortButton
        '
        Me.AzSortButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AzSortButton.BackgroundImage = CType(resources.GetObject("AzSortButton.BackgroundImage"), System.Drawing.Image)
        Me.AzSortButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.AzSortButton.Location = New System.Drawing.Point(166, 4)
        Me.AzSortButton.Name = "AzSortButton"
        Me.AzSortButton.Size = New System.Drawing.Size(34, 34)
        Me.AzSortButton.TabIndex = 24
        Me.AzSortButton.Tag = "Sort all the students by alphabetical order"
        Me.AzSortButton.UseVisualStyleBackColor = True
        '
        'GroupClassesButton
        '
        Me.GroupClassesButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupClassesButton.BackgroundImage = Global.Exami.My.Resources.Resources.GroupByClassTrue
        Me.GroupClassesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupClassesButton.Location = New System.Drawing.Point(206, 4)
        Me.GroupClassesButton.Name = "GroupClassesButton"
        Me.GroupClassesButton.Size = New System.Drawing.Size(34, 34)
        Me.GroupClassesButton.TabIndex = 23
        Me.GroupClassesButton.Tag = "Ungroup classes"
        Me.GroupClassesButton.UseVisualStyleBackColor = True
        '
        'OptionsSelector
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SaveAllButton)
        Me.Controls.Add(Me.PrintAllButton)
        Me.Controls.Add(Me.ShuffleButton)
        Me.Controls.Add(Me.NumSortAllButton)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AzSortButton)
        Me.Controls.Add(Me.GroupClassesButton)
        Me.Controls.Add(Me.AllCheckBox)
        Me.Controls.Add(Me.SubjectCheckBox)
        Me.Controls.Add(Me.RoomCheckBox)
        Me.Controls.Add(Me.ClassCheckBox)
        Me.Controls.Add(Me.Label2)
        Me.MinimumSize = New System.Drawing.Size(237, 43)
        Me.Name = "OptionsSelector"
        Me.Size = New System.Drawing.Size(556, 43)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents AllCheckBox As CheckBox
    Private WithEvents SubjectCheckBox As CheckBox
    Private WithEvents RoomCheckBox As CheckBox
    Private WithEvents ClassCheckBox As CheckBox
    Private WithEvents Label2 As Label
    Friend WithEvents GroupClassesButton As Button
    Friend WithEvents AzSortButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents NumSortAllButton As Button
    Friend WithEvents ShuffleButton As Button
    Friend WithEvents PrintAllButton As Button
    Friend WithEvents SaveAllButton As Button
End Class
