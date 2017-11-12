<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddStudentForm
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
        Me.AddStudentButton = New System.Windows.Forms.Button()
        Me.CancelAddButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.StudentNumberTextBox = New System.Windows.Forms.TextBox()
        Me.ClassComboBox = New System.Windows.Forms.ComboBox()
        Me.FirstNameFailButton = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LastNameFailButton = New System.Windows.Forms.Button()
        Me.StudentNumberFailButton = New System.Windows.Forms.Button()
        Me.ClassFailButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'AddStudentButton
        '
        Me.AddStudentButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AddStudentButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.AddStudentButton.Location = New System.Drawing.Point(176, 556)
        Me.AddStudentButton.Name = "AddStudentButton"
        Me.AddStudentButton.Size = New System.Drawing.Size(129, 42)
        Me.AddStudentButton.TabIndex = 1
        Me.AddStudentButton.Text = "Add student"
        Me.AddStudentButton.UseVisualStyleBackColor = True
        '
        'CancelAddButton
        '
        Me.CancelAddButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CancelAddButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CancelAddButton.Location = New System.Drawing.Point(311, 556)
        Me.CancelAddButton.Name = "CancelAddButton"
        Me.CancelAddButton.Size = New System.Drawing.Size(75, 42)
        Me.CancelAddButton.TabIndex = 2
        Me.CancelAddButton.Text = "Cancel"
        Me.CancelAddButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 248)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "First name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 289)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Last name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 330)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Student number"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 371)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 20)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Class"
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.Location = New System.Drawing.Point(207, 245)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(179, 26)
        Me.FirstNameTextBox.TabIndex = 9
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.Location = New System.Drawing.Point(207, 286)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(179, 26)
        Me.LastNameTextBox.TabIndex = 11
        '
        'StudentNumberTextBox
        '
        Me.StudentNumberTextBox.Location = New System.Drawing.Point(207, 327)
        Me.StudentNumberTextBox.MaxLength = 9
        Me.StudentNumberTextBox.Name = "StudentNumberTextBox"
        Me.StudentNumberTextBox.Size = New System.Drawing.Size(179, 26)
        Me.StudentNumberTextBox.TabIndex = 12
        '
        'ClassComboBox
        '
        Me.ClassComboBox.FormattingEnabled = True
        Me.ClassComboBox.Location = New System.Drawing.Point(207, 368)
        Me.ClassComboBox.Name = "ClassComboBox"
        Me.ClassComboBox.Size = New System.Drawing.Size(179, 28)
        Me.ClassComboBox.TabIndex = 14
        '
        'FirstNameFailButton
        '
        Me.FirstNameFailButton.BackgroundImage = Global.Exami.My.Resources.Resources.huh
        Me.FirstNameFailButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.FirstNameFailButton.Location = New System.Drawing.Point(159, 237)
        Me.FirstNameFailButton.Name = "FirstNameFailButton"
        Me.FirstNameFailButton.Size = New System.Drawing.Size(42, 42)
        Me.FirstNameFailButton.TabIndex = 15
        Me.FirstNameFailButton.UseVisualStyleBackColor = True
        Me.FirstNameFailButton.Visible = False
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.Exami.My.Resources.Resources.add_student
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Enabled = False
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(146, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(128, 128)
        Me.Button1.TabIndex = 0
        Me.Button1.TabStop = False
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LastNameFailButton
        '
        Me.LastNameFailButton.BackgroundImage = Global.Exami.My.Resources.Resources.huh
        Me.LastNameFailButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.LastNameFailButton.Location = New System.Drawing.Point(159, 278)
        Me.LastNameFailButton.Name = "LastNameFailButton"
        Me.LastNameFailButton.Size = New System.Drawing.Size(42, 42)
        Me.LastNameFailButton.TabIndex = 16
        Me.LastNameFailButton.UseVisualStyleBackColor = True
        Me.LastNameFailButton.Visible = False
        '
        'StudentNumberFailButton
        '
        Me.StudentNumberFailButton.BackgroundImage = Global.Exami.My.Resources.Resources.huh
        Me.StudentNumberFailButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.StudentNumberFailButton.Location = New System.Drawing.Point(159, 319)
        Me.StudentNumberFailButton.Name = "StudentNumberFailButton"
        Me.StudentNumberFailButton.Size = New System.Drawing.Size(42, 42)
        Me.StudentNumberFailButton.TabIndex = 17
        Me.StudentNumberFailButton.UseVisualStyleBackColor = True
        Me.StudentNumberFailButton.Visible = False
        '
        'ClassFailButton
        '
        Me.ClassFailButton.BackgroundImage = Global.Exami.My.Resources.Resources.huh
        Me.ClassFailButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClassFailButton.Location = New System.Drawing.Point(159, 360)
        Me.ClassFailButton.Name = "ClassFailButton"
        Me.ClassFailButton.Size = New System.Drawing.Size(42, 42)
        Me.ClassFailButton.TabIndex = 18
        Me.ClassFailButton.Tag = "You need to select a class."
        Me.ClassFailButton.UseVisualStyleBackColor = True
        Me.ClassFailButton.Visible = False
        '
        'AddStudentForm
        '
        Me.AcceptButton = Me.AddStudentButton
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.CancelButton = Me.CancelAddButton
        Me.ClientSize = New System.Drawing.Size(398, 610)
        Me.ControlBox = False
        Me.Controls.Add(Me.ClassFailButton)
        Me.Controls.Add(Me.StudentNumberFailButton)
        Me.Controls.Add(Me.LastNameFailButton)
        Me.Controls.Add(Me.FirstNameFailButton)
        Me.Controls.Add(Me.ClassComboBox)
        Me.Controls.Add(Me.StudentNumberTextBox)
        Me.Controls.Add(Me.LastNameTextBox)
        Me.Controls.Add(Me.FirstNameTextBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CancelAddButton)
        Me.Controls.Add(Me.AddStudentButton)
        Me.Controls.Add(Me.Button1)
        Me.MaximumSize = New System.Drawing.Size(420, 666)
        Me.MinimumSize = New System.Drawing.Size(420, 666)
        Me.Name = "AddStudentForm"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Exami - Add a student"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents AddStudentButton As Button
    Friend WithEvents CancelAddButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents LastNameTextBox As TextBox
    Friend WithEvents StudentNumberTextBox As TextBox
    Friend WithEvents ClassComboBox As ComboBox
    Friend WithEvents FirstNameFailButton As Button
    Friend WithEvents LastNameFailButton As Button
    Friend WithEvents StudentNumberFailButton As Button
    Friend WithEvents ClassFailButton As Button
End Class
