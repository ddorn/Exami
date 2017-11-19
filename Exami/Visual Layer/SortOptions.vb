Public Class SortOptions

    Public Event SortChanged()

    Public GroupClasses As Boolean = True
    Public Snake As Boolean = True

    Private _sortby As SortBy = SortBy.Name
    Public Property Sort() As SortBy
        Get
            Return _sortby
        End Get
        Private Set(ByVal value As SortBy)
            _sortby = value

            If value = SortBy.Name Then
                AzSortButton.BackgroundImage = My.Resources.sortAZ
            Else
                AzSortButton.BackgroundImage = My.Resources.noSortAz
            End If

            If value = SortBy.Number Then
                NumSortAllButton.BackgroundImage = My.Resources.sortNum
            Else
                NumSortAllButton.BackgroundImage = My.Resources.noSortNum
            End If

            RaiseEvent SortChanged()
        End Set
    End Property

    Private Sub ShuffleButton_Click() Handles ShuffleButton.Click
        Me.Sort = SortBy.Shuffle
    End Sub

    Private Sub NumSortAllButton_Click() Handles NumSortAllButton.Click
        Me.Sort = SortBy.Number
    End Sub

    Private Sub AzSortButton_Click() Handles AzSortButton.Click
        Me.Sort = SortBy.Name
    End Sub

    Private Sub GroupClassesButton_Click() Handles GroupClassesButton.Click
        Me.GroupClasses = Not Me.GroupClasses
        If GroupClasses Then
            GroupClassesButton.BackgroundImage = My.Resources.group
            GroupClassesButton.Tag = "Ungroup classes"
        Else
            GroupClassesButton.BackgroundImage = My.Resources.no_group
            GroupClassesButton.Tag = "Group Students by classes"
        End If
        RaiseEvent SortChanged()
    End Sub

    Private Sub SnakeButton_Click() Handles SnakeButton.Click
        Me.Snake = Not Me.Snake
        If Snake Then
            SnakeButton.BackgroundImage = My.Resources.snake
            SnakeButton.Tag = "Click to place the students front to back in every column"
        Else
            SnakeButton.BackgroundImage = My.Resources.noSnake
            SnakeButton.Tag = "Click to place the students in a snake patern: front to back the back to front"
        End If
        RaiseEvent SortChanged()
    End Sub

End Class
