﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.PlacementTextBox = New System.Windows.Forms.RichTextBox()
        Me.TitleLabel = New System.Windows.Forms.TextBox()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.SortNumberButton = New System.Windows.Forms.Button()
        Me.AzButton = New System.Windows.Forms.Button()
        Me.TableSortButton = New System.Windows.Forms.Button()
        Me.PrintButton = New System.Windows.Forms.Button()
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
        'SortNumberButton
        '
        Me.SortNumberButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.SortNumberButton.BackgroundImage = CType(resources.GetObject("SortNumberButton.BackgroundImage"), System.Drawing.Image)
        Me.SortNumberButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SortNumberButton.Enabled = False
        Me.SortNumberButton.Location = New System.Drawing.Point(148, 347)
        Me.SortNumberButton.Name = "SortNumberButton"
        Me.SortNumberButton.Size = New System.Drawing.Size(42, 42)
        Me.SortNumberButton.TabIndex = 9
        Me.SortNumberButton.Tag = "Place students in alphabetic order"
        Me.SortNumberButton.UseVisualStyleBackColor = True
        '
        'AzButton
        '
        Me.AzButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.AzButton.BackgroundImage = CType(resources.GetObject("AzButton.BackgroundImage"), System.Drawing.Image)
        Me.AzButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.AzButton.Enabled = False
        Me.AzButton.Location = New System.Drawing.Point(196, 347)
        Me.AzButton.Name = "AzButton"
        Me.AzButton.Size = New System.Drawing.Size(42, 42)
        Me.AzButton.TabIndex = 4
        Me.AzButton.Tag = "Place students in alphabetic order"
        Me.AzButton.UseVisualStyleBackColor = True
        '
        'TableSortButton
        '
        Me.TableSortButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.TableSortButton.BackgroundImage = Global.Exami.My.Resources.Resources.sorttable
        Me.TableSortButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TableSortButton.Enabled = False
        Me.TableSortButton.Location = New System.Drawing.Point(100, 347)
        Me.TableSortButton.Name = "TableSortButton"
        Me.TableSortButton.Size = New System.Drawing.Size(42, 42)
        Me.TableSortButton.TabIndex = 3
        Me.TableSortButton.Tag = "See students sorted by table"
        Me.TableSortButton.UseVisualStyleBackColor = True
        '
        'PrintButton
        '
        Me.PrintButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.PrintButton.BackColor = System.Drawing.SystemColors.Control
        Me.PrintButton.BackgroundImage = CType(resources.GetObject("PrintButton.BackgroundImage"), System.Drawing.Image)
        Me.PrintButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PrintButton.Location = New System.Drawing.Point(52, 347)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(42, 42)
        Me.PrintButton.TabIndex = 2
        Me.PrintButton.Tag = "Print this part of the placement"
        Me.PrintButton.UseVisualStyleBackColor = True
        '
        'PlacementBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SortNumberButton)
        Me.Controls.Add(Me.TitleLabel)
        Me.Controls.Add(Me.PlacementTextBox)
        Me.Controls.Add(Me.AzButton)
        Me.Controls.Add(Me.TableSortButton)
        Me.Controls.Add(Me.PrintButton)
        Me.MinimumSize = New System.Drawing.Size(242, 2)
        Me.Name = "PlacementBox"
        Me.Size = New System.Drawing.Size(290, 392)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PrintButton As Button
    Friend WithEvents AzButton As Button
    Friend WithEvents PlacementTextBox As RichTextBox
    Friend WithEvents TitleLabel As TextBox
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents SortNumberButton As Button
    Friend WithEvents TableSortButton As Button
End Class
