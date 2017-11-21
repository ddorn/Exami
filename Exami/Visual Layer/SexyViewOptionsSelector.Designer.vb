<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SexyViewOptionsSelector
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
        Me.AllCheckBox = New System.Windows.Forms.CheckBox()
        Me.SubjectCheckBox = New System.Windows.Forms.CheckBox()
        Me.RoomCheckBox = New System.Windows.Forms.CheckBox()
        Me.ClassCheckBox = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.SortTableButton = New System.Windows.Forms.RadioButton()
        Me.SortAzButton = New System.Windows.Forms.RadioButton()
        Me.SortNumButton = New System.Windows.Forms.RadioButton()
        Me.ViewButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ShowNumbersButton = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'AllCheckBox
        '
        Me.AllCheckBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AllCheckBox.AutoSize = True
        Me.AllCheckBox.Location = New System.Drawing.Point(131, 48)
        Me.AllCheckBox.Name = "AllCheckBox"
        Me.AllCheckBox.Size = New System.Drawing.Size(52, 24)
        Me.AllCheckBox.TabIndex = 26
        Me.AllCheckBox.Text = "All"
        Me.AllCheckBox.UseVisualStyleBackColor = True
        '
        'SubjectCheckBox
        '
        Me.SubjectCheckBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SubjectCheckBox.AutoSize = True
        Me.SubjectCheckBox.Checked = True
        Me.SubjectCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.SubjectCheckBox.Location = New System.Drawing.Point(131, 25)
        Me.SubjectCheckBox.Name = "SubjectCheckBox"
        Me.SubjectCheckBox.Size = New System.Drawing.Size(89, 24)
        Me.SubjectCheckBox.TabIndex = 25
        Me.SubjectCheckBox.Text = "Subject"
        Me.SubjectCheckBox.UseVisualStyleBackColor = True
        '
        'RoomCheckBox
        '
        Me.RoomCheckBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RoomCheckBox.AutoSize = True
        Me.RoomCheckBox.Location = New System.Drawing.Point(23, 48)
        Me.RoomCheckBox.Name = "RoomCheckBox"
        Me.RoomCheckBox.Size = New System.Drawing.Size(78, 24)
        Me.RoomCheckBox.TabIndex = 24
        Me.RoomCheckBox.Text = "Room"
        Me.RoomCheckBox.UseVisualStyleBackColor = True
        '
        'ClassCheckBox
        '
        Me.ClassCheckBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ClassCheckBox.AutoSize = True
        Me.ClassCheckBox.Checked = True
        Me.ClassCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ClassCheckBox.Location = New System.Drawing.Point(23, 25)
        Me.ClassCheckBox.Name = "ClassCheckBox"
        Me.ClassCheckBox.Size = New System.Drawing.Size(74, 24)
        Me.ClassCheckBox.TabIndex = 23
        Me.ClassCheckBox.Text = "Class"
        Me.ClassCheckBox.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.SubjectCheckBox)
        Me.GroupBox1.Controls.Add(Me.AllCheckBox)
        Me.GroupBox1.Controls.Add(Me.ClassCheckBox)
        Me.GroupBox1.Controls.Add(Me.RoomCheckBox)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 43)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(244, 82)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "View groupped by"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.SortTableButton)
        Me.GroupBox2.Controls.Add(Me.SortAzButton)
        Me.GroupBox2.Controls.Add(Me.SortNumButton)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 131)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(244, 192)
        Me.GroupBox2.TabIndex = 29
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "View sorted by"
        '
        'SortTableButton
        '
        Me.SortTableButton.Image = Global.Exami.My.Resources.Resources.sorttable
        Me.SortTableButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SortTableButton.Location = New System.Drawing.Point(23, 137)
        Me.SortTableButton.Name = "SortTableButton"
        Me.SortTableButton.Size = New System.Drawing.Size(215, 50)
        Me.SortTableButton.TabIndex = 31
        Me.SortTableButton.TabStop = True
        Me.SortTableButton.Text = "Table"
        Me.SortTableButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.SortTableButton.UseVisualStyleBackColor = True
        '
        'SortAzButton
        '
        Me.SortAzButton.Checked = True
        Me.SortAzButton.Image = Global.Exami.My.Resources.Resources.sortAzSmall
        Me.SortAzButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SortAzButton.Location = New System.Drawing.Point(23, 25)
        Me.SortAzButton.Name = "SortAzButton"
        Me.SortAzButton.Size = New System.Drawing.Size(215, 50)
        Me.SortAzButton.TabIndex = 30
        Me.SortAzButton.TabStop = True
        Me.SortAzButton.Text = "Name"
        Me.SortAzButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.SortAzButton.UseVisualStyleBackColor = True
        '
        'SortNumButton
        '
        Me.SortNumButton.Image = Global.Exami.My.Resources.Resources.sortNum
        Me.SortNumButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SortNumButton.Location = New System.Drawing.Point(23, 81)
        Me.SortNumButton.Name = "SortNumButton"
        Me.SortNumButton.Size = New System.Drawing.Size(215, 50)
        Me.SortNumButton.TabIndex = 29
        Me.SortNumButton.Text = "Student number"
        Me.SortNumButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.SortNumButton.UseVisualStyleBackColor = True
        '
        'ViewButton
        '
        Me.ViewButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ViewButton.BackgroundImage = Global.Exami.My.Resources.Resources.eye
        Me.ViewButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ViewButton.FlatAppearance.BorderSize = 0
        Me.ViewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ViewButton.Location = New System.Drawing.Point(213, 3)
        Me.ViewButton.Name = "ViewButton"
        Me.ViewButton.Size = New System.Drawing.Size(34, 34)
        Me.ViewButton.TabIndex = 1
        Me.ViewButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(22, 461)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(224, 106)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Here, nothing changes the way students are seated. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "It only changes the way you " &
    "see the placement on the screen."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(-1, 441)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 20)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Note:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ShowNumbersButton)
        Me.GroupBox3.Location = New System.Drawing.Point(3, 329)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(244, 53)
        Me.GroupBox3.TabIndex = 32
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Show and Print"
        '
        'ShowNumbersButton
        '
        Me.ShowNumbersButton.AutoSize = True
        Me.ShowNumbersButton.Checked = True
        Me.ShowNumbersButton.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ShowNumbersButton.Location = New System.Drawing.Point(3, 22)
        Me.ShowNumbersButton.Name = "ShowNumbersButton"
        Me.ShowNumbersButton.Size = New System.Drawing.Size(158, 24)
        Me.ShowNumbersButton.TabIndex = 0
        Me.ShowNumbersButton.Text = "Student numbers"
        Me.ShowNumbersButton.UseVisualStyleBackColor = True
        '
        'SexyViewOptionsSelector
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ViewButton)
        Me.Name = "SexyViewOptionsSelector"
        Me.Size = New System.Drawing.Size(250, 567)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ViewButton As Button
    Private WithEvents AllCheckBox As CheckBox
    Private WithEvents SubjectCheckBox As CheckBox
    Private WithEvents RoomCheckBox As CheckBox
    Private WithEvents ClassCheckBox As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents SortNumButton As RadioButton
    Friend WithEvents SortTableButton As RadioButton
    Friend WithEvents SortAzButton As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents ShowNumbersButton As CheckBox
End Class
