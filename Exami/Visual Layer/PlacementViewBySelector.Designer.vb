<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PlacementViewBySelector
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'AllCheckBox
        '
        Me.AllCheckBox.AutoSize = True
        Me.AllCheckBox.Location = New System.Drawing.Point(152, 21)
        Me.AllCheckBox.Name = "AllCheckBox"
        Me.AllCheckBox.Size = New System.Drawing.Size(52, 24)
        Me.AllCheckBox.TabIndex = 22
        Me.AllCheckBox.Text = "All"
        Me.AllCheckBox.UseVisualStyleBackColor = True
        '
        'SubjectCheckBox
        '
        Me.SubjectCheckBox.AutoSize = True
        Me.SubjectCheckBox.Checked = True
        Me.SubjectCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.SubjectCheckBox.Location = New System.Drawing.Point(152, 0)
        Me.SubjectCheckBox.Name = "SubjectCheckBox"
        Me.SubjectCheckBox.Size = New System.Drawing.Size(89, 24)
        Me.SubjectCheckBox.TabIndex = 21
        Me.SubjectCheckBox.Text = "Subject"
        Me.SubjectCheckBox.UseVisualStyleBackColor = True
        '
        'RoomCheckBox
        '
        Me.RoomCheckBox.AutoSize = True
        Me.RoomCheckBox.Location = New System.Drawing.Point(72, 21)
        Me.RoomCheckBox.Name = "RoomCheckBox"
        Me.RoomCheckBox.Size = New System.Drawing.Size(78, 24)
        Me.RoomCheckBox.TabIndex = 20
        Me.RoomCheckBox.Text = "Room"
        Me.RoomCheckBox.UseVisualStyleBackColor = True
        '
        'ClassCheckBox
        '
        Me.ClassCheckBox.AutoSize = True
        Me.ClassCheckBox.Checked = True
        Me.ClassCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ClassCheckBox.Location = New System.Drawing.Point(72, 0)
        Me.ClassCheckBox.Name = "ClassCheckBox"
        Me.ClassCheckBox.Size = New System.Drawing.Size(74, 24)
        Me.ClassCheckBox.TabIndex = 19
        Me.ClassCheckBox.Text = "Class"
        Me.ClassCheckBox.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 20)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "View by"
        '
        'PlacementViewBySelector
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.AllCheckBox)
        Me.Controls.Add(Me.SubjectCheckBox)
        Me.Controls.Add(Me.RoomCheckBox)
        Me.Controls.Add(Me.ClassCheckBox)
        Me.Controls.Add(Me.Label2)
        Me.MinimumSize = New System.Drawing.Size(237, 43)
        Me.Name = "PlacementViewBySelector"
        Me.Size = New System.Drawing.Size(237, 43)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents AllCheckBox As CheckBox
    Private WithEvents SubjectCheckBox As CheckBox
    Private WithEvents RoomCheckBox As CheckBox
    Private WithEvents ClassCheckBox As CheckBox
    Private WithEvents Label2 As Label
End Class
