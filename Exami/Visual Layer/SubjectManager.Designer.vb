<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SubjectManager
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
        Me.SubjectListBox = New System.Windows.Forms.CheckedListBox()
        Me.SuspendLayout()
        '
        'SubjectListBox
        '
        Me.SubjectListBox.BackColor = System.Drawing.SystemColors.Window
        Me.SubjectListBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SubjectListBox.CheckOnClick = True
        Me.SubjectListBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SubjectListBox.Enabled = False
        Me.SubjectListBox.FormattingEnabled = True
        Me.SubjectListBox.HorizontalScrollbar = True
        Me.SubjectListBox.IntegralHeight = False
        Me.SubjectListBox.Items.AddRange(New Object() {"First select a folder", "Then convert the .vass files", "Select one or more classes", "And create the a class plan", "Finaly create the placement"})
        Me.SubjectListBox.Location = New System.Drawing.Point(0, 0)
        Me.SubjectListBox.Name = "SubjectListBox"
        Me.SubjectListBox.Size = New System.Drawing.Size(264, 238)
        Me.SubjectListBox.TabIndex = 3
        '
        'SubjectManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SubjectListBox)
        Me.Name = "SubjectManager"
        Me.Size = New System.Drawing.Size(264, 238)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SubjectListBox As CheckedListBox
End Class
