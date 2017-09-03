Public Class PlacementBox

    Public Property Title() As String
        Get
            Return NameLabel.Text
        End Get
        Set(ByVal value As String)
            NameLabel.Text = value
            Invalidate()
        End Set
    End Property

    Private students As StudentGroup
    ''' <summary>
    ''' Set the students of this box and actualize the display.
    ''' </summary>
    Public Sub SetStudents(students As StudentGroup)
        Me.students = students
    End Sub



End Class
