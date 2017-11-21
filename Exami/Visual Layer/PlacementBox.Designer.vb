<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PlacementBox
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PlacementBox))
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Cucu", "bla", "bli", "", ""}, -1)
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Coucou")
        Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Caca")
        Me.PlacementTextBox = New System.Windows.Forms.RichTextBox()
        Me.TitleLabel = New System.Windows.Forms.TextBox()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.SeeByButton = New System.Windows.Forms.Button()
        Me.PrintButton = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.SuspendLayout()
        '
        'PlacementTextBox
        '
        Me.PlacementTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PlacementTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PlacementTextBox.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlacementTextBox.Location = New System.Drawing.Point(0, 71)
        Me.PlacementTextBox.Name = "PlacementTextBox"
        Me.PlacementTextBox.Size = New System.Drawing.Size(290, 270)
        Me.PlacementTextBox.TabIndex = 8
        Me.PlacementTextBox.Text = ""
        Me.PlacementTextBox.WordWrap = False
        '
        'TitleLabel
        '
        Me.TitleLabel.BackColor = System.Drawing.SystemColors.Control
        Me.TitleLabel.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TitleLabel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TitleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.TitleLabel.Location = New System.Drawing.Point(0, 0)
        Me.TitleLabel.Multiline = True
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(290, 65)
        Me.TitleLabel.TabIndex = 0
        Me.TitleLabel.TabStop = False
        Me.TitleLabel.Text = "Subject" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Teacher" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Room"
        Me.TitleLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TitleLabel.WordWrap = False
        '
        'PrintDialog1
        '
        Me.PrintDialog1.AllowSelection = True
        Me.PrintDialog1.AllowSomePages = True
        Me.PrintDialog1.Document = Me.PrintDocument1
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintDocument1
        '
        Me.PrintDocument1.OriginAtMargins = True
        '
        'SeeByButton
        '
        Me.SeeByButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.SeeByButton.BackgroundImage = Global.Exami.My.Resources.Resources.sortAZ
        Me.SeeByButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SeeByButton.Location = New System.Drawing.Point(145, 347)
        Me.SeeByButton.Name = "SeeByButton"
        Me.SeeByButton.Size = New System.Drawing.Size(42, 42)
        Me.SeeByButton.TabIndex = 3
        Me.SeeByButton.Tag = "See students sorted by table"
        Me.SeeByButton.UseVisualStyleBackColor = True
        '
        'PrintButton
        '
        Me.PrintButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.PrintButton.BackColor = System.Drawing.SystemColors.Control
        Me.PrintButton.BackgroundImage = CType(resources.GetObject("PrintButton.BackgroundImage"), System.Drawing.Image)
        Me.PrintButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PrintButton.Location = New System.Drawing.Point(97, 347)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(42, 42)
        Me.PrintButton.TabIndex = 2
        Me.PrintButton.Tag = "Print this part of the placement"
        Me.PrintButton.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.ListView1.AllowColumnReorder = True
        Me.ListView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HotTracking = True
        Me.ListView1.HoverSelection = True
        ListViewItem1.StateImageIndex = 0
        ListViewItem2.IndentCount = 1
        ListViewItem2.StateImageIndex = 0
        ListViewItem3.StateImageIndex = 0
        Me.ListView1.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3})
        Me.ListView1.Location = New System.Drawing.Point(3, 71)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(284, 270)
        Me.ListView1.TabIndex = 9
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'PlacementBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.TitleLabel)
        Me.Controls.Add(Me.PlacementTextBox)
        Me.Controls.Add(Me.SeeByButton)
        Me.Controls.Add(Me.PrintButton)
        Me.MinimumSize = New System.Drawing.Size(242, 2)
        Me.Name = "PlacementBox"
        Me.Size = New System.Drawing.Size(290, 392)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PrintButton As Button
    Friend WithEvents PlacementTextBox As RichTextBox
    Friend WithEvents TitleLabel As TextBox
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents SeeByButton As Button
    Friend WithEvents ListView1 As ListView
End Class
