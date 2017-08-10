<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RoomDesigner
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.RowNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.ColumnNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.RowLabel = New System.Windows.Forms.Label()
        Me.ColumnLabel = New System.Windows.Forms.Label()
        Me.CreateRoomButton = New System.Windows.Forms.Button()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.CancelButton = New System.Windows.Forms.Button()
        CType(Me.RowNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColumnNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RowNumericUpDown
        '
        Me.RowNumericUpDown.Location = New System.Drawing.Point(527, 246)
        Me.RowNumericUpDown.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.RowNumericUpDown.Name = "RowNumericUpDown"
        Me.RowNumericUpDown.Size = New System.Drawing.Size(120, 26)
        Me.RowNumericUpDown.TabIndex = 0
        Me.RowNumericUpDown.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'ColumnNumericUpDown
        '
        Me.ColumnNumericUpDown.Location = New System.Drawing.Point(527, 278)
        Me.ColumnNumericUpDown.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.ColumnNumericUpDown.Name = "ColumnNumericUpDown"
        Me.ColumnNumericUpDown.Size = New System.Drawing.Size(120, 26)
        Me.ColumnNumericUpDown.TabIndex = 1
        Me.ColumnNumericUpDown.Value = New Decimal(New Integer() {7, 0, 0, 0})
        '
        'RowLabel
        '
        Me.RowLabel.AutoSize = True
        Me.RowLabel.Location = New System.Drawing.Point(404, 248)
        Me.RowLabel.Name = "RowLabel"
        Me.RowLabel.Size = New System.Drawing.Size(120, 20)
        Me.RowLabel.TabIndex = 2
        Me.RowLabel.Text = "Number of rows"
        '
        'ColumnLabel
        '
        Me.ColumnLabel.AutoSize = True
        Me.ColumnLabel.Location = New System.Drawing.Point(378, 280)
        Me.ColumnLabel.Name = "ColumnLabel"
        Me.ColumnLabel.Size = New System.Drawing.Size(146, 20)
        Me.ColumnLabel.TabIndex = 3
        Me.ColumnLabel.Text = "Number of columns"
        '
        'CreateRoomButton
        '
        Me.CreateRoomButton.Location = New System.Drawing.Point(653, 246)
        Me.CreateRoomButton.Name = "CreateRoomButton"
        Me.CreateRoomButton.Size = New System.Drawing.Size(169, 58)
        Me.CreateRoomButton.TabIndex = 4
        Me.CreateRoomButton.Text = "&Create Room"
        Me.CreateRoomButton.UseVisualStyleBackColor = True
        '
        'SaveButton
        '
        Me.SaveButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaveButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.SaveButton.Location = New System.Drawing.Point(1092, 542)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(98, 36)
        Me.SaveButton.TabIndex = 1000
        Me.SaveButton.Text = "&Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        Me.SaveButton.Visible = False
        '
        'CancelButton
        '
        Me.CancelButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelButton.Location = New System.Drawing.Point(988, 542)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(98, 36)
        Me.CancelButton.TabIndex = 1001
        Me.CancelButton.Text = "&Cancel"
        Me.CancelButton.UseVisualStyleBackColor = True
        Me.CancelButton.Visible = False
        '
        'RoomDesigner
        '
        Me.AcceptButton = Me.CreateRoomButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1202, 590)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.CreateRoomButton)
        Me.Controls.Add(Me.ColumnLabel)
        Me.Controls.Add(Me.RowLabel)
        Me.Controls.Add(Me.ColumnNumericUpDown)
        Me.Controls.Add(Me.RowNumericUpDown)
        Me.Name = "RoomDesigner"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Room Designer"
        CType(Me.RowNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColumnNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RowNumericUpDown As NumericUpDown
    Friend WithEvents ColumnNumericUpDown As NumericUpDown
    Friend WithEvents RowLabel As Label
    Friend WithEvents ColumnLabel As Label
    Friend WithEvents CreateRoomButton As Button
    Friend WithEvents SaveButton As Button
    Friend WithEvents CancelButton As Button
End Class
