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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.AddStudentButton = New System.Windows.Forms.Button()
        Me.CancelAddButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.FirstnameTextBox = New System.Windows.Forms.TextBox()
        Me.MiddleNameTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.StudentNumberTextBox = New System.Windows.Forms.TextBox()
        Me.SubjectComboBox = New System.Windows.Forms.ComboBox()
        Me.ClassComboBox = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
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
        'AddStudentButton
        '
        Me.AddStudentButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AddStudentButton.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.AddStudentButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.AddStudentButton.Location = New System.Drawing.Point(176, 522)
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
        Me.CancelAddButton.Location = New System.Drawing.Point(311, 522)
        Me.CancelAddButton.Name = "CancelAddButton"
        Me.CancelAddButton.Size = New System.Drawing.Size(75, 42)
        Me.CancelAddButton.TabIndex = 2
        Me.CancelAddButton.Text = "Cancel"
        Me.CancelAddButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 217)
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 253)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Middle name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 325)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Student number"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 361)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 20)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Subject"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 397)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 20)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Class"
        '
        'FirstnameTextBox
        '
        Me.FirstnameTextBox.Location = New System.Drawing.Point(207, 214)
        Me.FirstnameTextBox.Name = "FirstnameTextBox"
        Me.FirstnameTextBox.Size = New System.Drawing.Size(179, 26)
        Me.FirstnameTextBox.TabIndex = 9
        '
        'MiddleNameTextBox
        '
        Me.MiddleNameTextBox.Location = New System.Drawing.Point(207, 250)
        Me.MiddleNameTextBox.Name = "MiddleNameTextBox"
        Me.MiddleNameTextBox.Size = New System.Drawing.Size(179, 26)
        Me.MiddleNameTextBox.TabIndex = 10
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
        Me.StudentNumberTextBox.Location = New System.Drawing.Point(207, 322)
        Me.StudentNumberTextBox.Name = "StudentNumberTextBox"
        Me.StudentNumberTextBox.Size = New System.Drawing.Size(179, 26)
        Me.StudentNumberTextBox.TabIndex = 12
        '
        'SubjectComboBox
        '
        Me.SubjectComboBox.FormattingEnabled = True
        Me.SubjectComboBox.Location = New System.Drawing.Point(207, 358)
        Me.SubjectComboBox.Name = "SubjectComboBox"
        Me.SubjectComboBox.Size = New System.Drawing.Size(179, 28)
        Me.SubjectComboBox.TabIndex = 13
        '
        'ClassComboBox
        '
        Me.ClassComboBox.FormattingEnabled = True
        Me.ClassComboBox.Location = New System.Drawing.Point(207, 394)
        Me.ClassComboBox.Name = "ClassComboBox"
        Me.ClassComboBox.Size = New System.Drawing.Size(179, 28)
        Me.ClassComboBox.TabIndex = 14
        '
        'AddStudentForm
        '
        Me.AcceptButton = Me.AddStudentButton
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.CancelButton = Me.CancelAddButton
        Me.ClientSize = New System.Drawing.Size(398, 610)
        Me.ControlBox = False
        Me.Controls.Add(Me.ClassComboBox)
        Me.Controls.Add(Me.SubjectComboBox)
        Me.Controls.Add(Me.StudentNumberTextBox)
        Me.Controls.Add(Me.LastNameTextBox)
        Me.Controls.Add(Me.MiddleNameTextBox)
        Me.Controls.Add(Me.FirstnameTextBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
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
        Me.Text = "AddStudentForm"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents AddStudentButton As Button
    Friend WithEvents CancelAddButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents FirstnameTextBox As TextBox
    Friend WithEvents MiddleNameTextBox As TextBox
    Friend WithEvents LastNameTextBox As TextBox
    Friend WithEvents StudentNumberTextBox As TextBox
    Friend WithEvents SubjectComboBox As ComboBox
    Friend WithEvents ClassComboBox As ComboBox
End Class
