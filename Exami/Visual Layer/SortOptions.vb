﻿Public Class SortOptions

    Public Event SortChanged()

    Public GroupClasses As Boolean = True

    Private _sortby As SortBy = SortBy.Name
    Public Property Sort() As SortBy
        Get
            Return _sortby
        End Get
        Private Set(ByVal value As SortBy)
            _sortby = value
            RaiseEvent SortChanged()
        End Set
    End Property

    Private Sub ShuffleButton_Click() Handles ShuffleButton.Click
        Me.Sort = SortBy.Shuffle
    End Sub

    Private Sub NumSortAllButton_Click() Handles NumSortAllButton.Click
        Me.Sort = SortBy.Number
    End Sub

    Private Sub AzSortButton_Click(sender As Object, e As EventArgs) Handles AzSortButton.Click
        Me.Sort = SortBy.Name
    End Sub

    Private Sub GroupClassesButton_Click(sender As Object, e As EventArgs) Handles GroupClassesButton.Click
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

End Class
