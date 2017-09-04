Public Class PlacementBox

    Private places As New List(Of Place)
    Private students As StudentGroup

    Public Property Title() As String
        Get
            Return TitleLabel.Text
        End Get
        Set(ByVal value As String)
            TitleLabel.Text = value
            Invalidate()
        End Set
    End Property

    Public Sub SetContents(students As StudentGroup, places As List(Of Place))
        Me.places = places
        Me.students = students

        ' Enable the options
        Me.AzButton.Enabled = True
        Me.ShuffleButton.Enabled = True

        ' And updat everything
        Me.UpdateDisplay()
    End Sub

    Private Sub UpdateDisplay()

        Me.PlacementTextBox.ResetText()
        Dim placementText As String = ""

        For pos = 0 To students.Count - 1
            students.allStudents(pos).place = places(pos)

            Dim line = places(pos).ToString & vbTab & students.allStudents(pos).ToString

            PlacementTextBox.AppendText(line)
            PlacementTextBox.AppendText(vbNewLine)
        Next

        '        TextBox.Text = placementText
        ' Highlighting sections

        Return
        For iLine = 0 To PlacementTextBox.Lines.Length - 1
            PlacementTextBox.SelectionStart = PlacementTextBox.GetFirstCharIndexFromLine(iLine)
            PlacementTextBox.SelectionLength = PlacementTextBox.Lines(iLine).Length

            If PlacementTextBox.Lines(iLine).StartsWith(" ") And False Then
                PlacementTextBox.SelectionStart += 1
                PlacementTextBox.SelectionLength -= 2
                PlacementTextBox.SelectionFont = New Font(PlacementTextBox.SelectionFont, FontStyle.Bold)

                If PlacementTextBox.Lines(iLine).StartsWith("  ") Then
                    PlacementTextBox.SelectionStart += 1
                    PlacementTextBox.SelectionLength -= 2
                    PlacementTextBox.SelectionFont = New Font(PlacementTextBox.SelectionFont, FontStyle.Bold Or FontStyle.Underline)

                    If PlacementTextBox.Lines(iLine).StartsWith("   ") Then
                        PlacementTextBox.SelectionStart += 1
                        PlacementTextBox.SelectionLength -= 2
                        PlacementTextBox.SelectionAlignment = HorizontalAlignment.Center
                    End If
                End If
            End If
        Next

        PlacementTextBox.SelectionStart = 0
        PlacementTextBox.SelectionLength = 0

    End Sub

    Private Sub ShuffleButton_Click(sender As Object, e As EventArgs) Handles ShuffleButton.Click
        Helper.Shuffle(Of Place)(Me.places)
        UpdateDisplay()
    End Sub

    Private Sub AzButton_Click(sender As Object, e As EventArgs) Handles AzButton.Click
        Me.places.Sort()
        UpdateDisplay()
    End Sub
End Class
