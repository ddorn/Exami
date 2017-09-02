Public Class PlacementBox

    Public Event SaveClick()
    Public Event PrintClick()
    Public Event ShuffleClick()
    Public Event AzOrderClick()
    Public Event GroupByClassClick()

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        RaiseEvent SaveClick()
    End Sub
    Private Sub PrintButton_Click(sender As Object, e As EventArgs) Handles PrintButton.Click
        RaiseEvent PrintClick()
    End Sub
    Private Sub ShuffleButton_Click(sender As Object, e As EventArgs) Handles ShuffleButton.Click
        RaiseEvent ShuffleClick()
    End Sub
    Private Sub AzButton_Click(sender As Object, e As EventArgs) Handles AzButton.Click
        RaiseEvent AzOrderClick()
    End Sub
    Private Sub ByClassButton_Click(sender As Object, e As EventArgs) Handles ByClassButton.Click
        RaiseEvent GroupByClassClick()
    End Sub

    Public Property Title() As String
        Get
            Return NameLabel.Text
        End Get
        Set(ByVal value As String)
            NameLabel.Text = value
            Invalidate()
        End Set
    End Property

    Private _students As StudentGroup
    ''' <summary>
    ''' The group of students actually in the group.
    ''' </summary>
    ''' <returns></returns>
    Public Property Students() As StudentGroup
        Get
            Return _students
        End Get
        Set(ByVal value As StudentGroup)
            _students = value
        End Set
    End Property


End Class
