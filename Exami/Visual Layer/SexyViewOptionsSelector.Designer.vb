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
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
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
        Me.GroupBox2.Controls.Add(Me.RadioButton3)
        Me.GroupBox2.Controls.Add(Me.RadioButton2)
        Me.GroupBox2.Controls.Add(Me.RadioButton1)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 131)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(244, 192)
        Me.GroupBox2.TabIndex = 29
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "View sorted by"
        '
        'RadioButton3
        '
        Me.RadioButton3.Image = Global.Exami.My.Resources.Resources.sorttable
        Me.RadioButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadioButton3.Location = New System.Drawing.Point(23, 137)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(215, 50)
        Me.RadioButton3.TabIndex = 31
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Table"
        Me.RadioButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.Checked = True
        Me.RadioButton2.Image = Global.Exami.My.Resources.Resources.sortAzSmall
        Me.RadioButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadioButton2.Location = New System.Drawing.Point(23, 25)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(215, 50)
        Me.RadioButton2.TabIndex = 30
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Name"
        Me.RadioButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.Image = Global.Exami.My.Resources.Resources.sortNum
        Me.RadioButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.RadioButton1.Location = New System.Drawing.Point(23, 81)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(215, 50)
        Me.RadioButton1.TabIndex = 29
        Me.RadioButton1.Text = "Student number"
        Me.RadioButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackgroundImage = Global.Exami.My.Resources.Resources.eye
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(213, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(34, 34)
        Me.Button1.TabIndex = 1
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(23, 383)
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
        Me.Label2.Location = New System.Drawing.Point(0, 363)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 20)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Note:"
        '
        'SexyViewOptionsSelector
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "SexyViewOptionsSelector"
        Me.Size = New System.Drawing.Size(250, 500)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Private WithEvents AllCheckBox As CheckBox
    Private WithEvents SubjectCheckBox As CheckBox
    Private WithEvents RoomCheckBox As CheckBox
    Private WithEvents ClassCheckBox As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
