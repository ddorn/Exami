Imports Exami

''' <summary>
''' This control let the user select set of flags for the GroupType enumeration.
''' </summary>
Public Class OptionsSelector

    Public CurrentViewBy As ViewBy = ViewBy.None
    Public GroupClasses As Boolean = True

    Public Event OptionsChanged()
    Public Event SaveAll()
    Public Event PrintAll()

    Private _sortby As SortBy = SortBy.Name
    Public Property Sort() As SortBy
        Get
            Return _sortby
        End Get
        Private Set(ByVal value As SortBy)
            _sortby = value
            RaiseEvent OptionsChanged()
        End Set
    End Property

    ' Change for the All box

    ''' <summary>
    ''' Change all the boxes when the user clicks the All box.
    ''' </summary>
    Private Sub AllCheckBox_CheckedChanged() Handles AllCheckBox.Click
        ' We just set everything to the same value

        ClassCheckBox.Checked = AllCheckBox.Checked
        RoomCheckBox.Checked = AllCheckBox.Checked
        SubjectCheckBox.Checked = AllCheckBox.Checked
        RaiseEvent OptionsChanged()

    End Sub

    ''' <summary>
    ''' Checks the All box if all other boxes are checked, else unchecks it.
    ''' </summary>
    Private Sub SelectAllCheckBoxIfNeeded() Handles SubjectCheckBox.Click, RoomCheckBox.Click, ClassCheckBox.Click

        ' If and only if they are all checked
        If SubjectCheckBox.Checked And RoomCheckBox.Checked And ClassCheckBox.Checked Then
            AllCheckBox.Checked = True
        Else
            AllCheckBox.Checked = False
        End If
        RaiseEvent OptionsChanged()
    End Sub

    ' Change of state

    Private Sub SubjectCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles SubjectCheckBox.CheckedChanged
        ' The xor operation adds a flag
        CurrentViewBy = CurrentViewBy Xor ViewBy.Subject
    End Sub

    Private Sub ClassCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles ClassCheckBox.CheckedChanged
        CurrentViewBy = CurrentViewBy Xor ViewBy.Classe
    End Sub

    Private Sub RoomCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles RoomCheckBox.CheckedChanged
        CurrentViewBy = CurrentViewBy Xor ViewBy.Room
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles SaveAllButton.Click
        RaiseEvent SaveAll()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles PrintAllButton.Click
        RaiseEvent PrintAll()
    End Sub

    Private Sub ShuffleButton_Click() Handles ShuffleButton.Click
        Me.Sort = SortBy.Shuffle
    End Sub

    Private Sub NumSortAllButton_Click() Handles NumSortAllButton.Click
        Me.Sort = SortBy.Number
    End Sub

    Private Sub AzSortButton_Click(sender As Object, e As EventArgs) Handles AzSortButton.Click
        Me.Sort = SortBy.Name
    End Sub

    Private Sub SettingsButton_Click(sender As Object, e As EventArgs) Handles GroupClassesButton.Click
        Me.GroupClasses = Not Me.GroupClasses
        If GroupClasses Then
            GroupClassesButton.BackgroundImage = My.Resources.GroupByClassTrue
            GroupClassesButton.Tag = "Ungroup classes"
        Else
            GroupClassesButton.BackgroundImage = My.Resources.GroupByClassFalse
            GroupClassesButton.Tag = "Group Students by classes"
        End If
        RaiseEvent OptionsChanged()
    End Sub

End Class
