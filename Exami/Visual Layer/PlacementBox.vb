''' <summary>
''' This control is intended to show AND modify a placement (or a part of), providing fuctions to save, print, shuffle and sort the students.
''' </summary>
Public Class PlacementBox

    Private places As New List(Of Place)
    Private students As StudentGroup

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

    ''' <summary>
    ''' Set the places and students of the box. The two list must have the same length.
    ''' This actualize the screen.
    ''' </summary>
    ''' <param name="students">List of the students of this part of the placement</param>
    ''' <param name="places">List of the ascoiated places</param>
    Public Sub SetContents(students As StudentGroup, places As List(Of Place))

        ' Better to warn you know that let you debug the code in some other place. You should thank Diego from the 4/09/2017
        If places.Count <> students.Count Then
            MsgBox("This should not happen. the students and room list length are different in PlacementBox.SetContent.")
        End If

        Me.places = places
        Me.students = students

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

        For pos = 0 To students.Count - 1
            ' We set the place of the student... in case of
            students.allStudents(pos).place = places(pos)

            ' The place then the name, aligned
            Dim line = places(pos).ToString & vbTab & students.allStudents(pos).ToString

            PlacementTextBox.AppendText(line)
            PlacementTextBox.AppendText(vbNewLine)  ' Only one line is a bit... stupid
        Next

    End Sub

    ''' <summary>
    ''' Shuffle the places and keep the students in the same order. Thus They are at a random place now.
    ''' Updates the screen.
    ''' </summary>
    Private Sub Shuffle() Handles ShuffleButton.Click
        Helper.Shuffle(Of Place)(places)
        UpdateDisplay()
    End Sub

    ''' <summary>
    ''' Sort the places and leave the students as they are so they are by alphabetical order now.
    ''' Updates the screen.
    ''' </summary>
    Private Sub AzButton_Click() Handles AzButton.Click
        places.Sort()
        UpdateDisplay()
    End Sub

End Class
