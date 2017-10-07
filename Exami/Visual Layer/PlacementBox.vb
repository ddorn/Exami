''' <summary>
''' This control is intended to show AND modify a placement (or a part of), providing fuctions to save, print, shuffle and sort the students.
''' </summary>
Public Class PlacementBox

    Private subPlacement As SubPlacement

    ''' <summary>
    ''' The title that is shown in bold underline of the box.
    ''' 
    ''' If there is some " - " in it, they will be converted in new lines. This is how Placement.GetNameAs is done.
    ''' </summary>
    Public Property Title() As String
        Get
            Return TitleLabel.Text
        End Get
        Set(ByVal value As String)
            value = value.Replace(" - ", vbNewLine)
            TitleLabel.Text = value
            Invalidate()
        End Set
    End Property
    Private Sub TitleLabel_TextChanged(sender As Object, e As EventArgs) Handles TitleLabel.TextChanged
        If TitleLabel.Text Is Nothing Or Me.subPlacement Is Nothing Then
            Return
        End If
        Me.subPlacement.name = TitleLabel.Text.Replace(vbNewLine, " - ")
    End Sub

    ''' <summary>
    ''' Set the places and students of the box. The two list must have the same length.
    ''' This actualize the screen.
    ''' </summary>
    ''' <param name="students">List of the students of this part of the placement</param>
    ''' <param name="places">List of the ascoiated places</param>
    Public Sub SetContents(ByRef subplacement As SubPlacement)
        Me.subPlacement = subplacement

        ' Enable the options
        AzButton.Enabled = True
        ShuffleButton.Enabled = True

        ' And updat everything
        UpdateDisplay()
    End Sub

    ''' <summary>
    ''' This DOES a placement and show it to the screen.
    ''' </summary>
    Private Sub UpdateDisplay()
        ' Yep, the placement is done here...
        ' I kmow it is supposed to be only displaying but well
        ' It just associate places and students in the order, for option in the order, just suffle/order the two lists as you want

        PlacementTextBox.ResetText()

        For pos = 0 To subPlacement.students.Count - 1
            ' We set the place of the student... in case of
            subPlacement.students.allStudents(pos).place = subPlacement.places(pos)

            ' The place then the name, aligned
            Dim line = subPlacement.places(pos).ToString & vbTab & subPlacement.students.allStudents(pos).ToString

            PlacementTextBox.AppendText(line)
            PlacementTextBox.AppendText(vbNewLine)  ' Only one line is a bit... stupid
        Next

    End Sub

    ''' <summary>
    ''' Shuffle the places and keep the students in the same order. Thus They are at a random place now.
    ''' Updates the screen.
    ''' </summary>
    Private Sub Shuffle() Handles ShuffleButton.Click
        Helper.Shuffle(Of Place)(subPlacement.places)
        UpdateDisplay()
    End Sub

    ''' <summary>
    ''' Sort the places and leave the students as they are so they are by alphabetical order now.
    ''' Updates the screen.
    ''' </summary>
    Private Sub AzButton_Click() Handles AzButton.Click
        subPlacement.places.Sort()
        UpdateDisplay()
    End Sub

End Class
