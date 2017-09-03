Public Class PlacementViewBySelector

    Public CurrentViewBy As ViewBy = ViewBy.None

    Private Sub AllCheckBox_CheckedChanged() Handles AllCheckBox.Click
        ' We just set erything to the same value

        ClassCheckBox.Checked = AllCheckBox.Checked
        RoomCheckBox.Checked = AllCheckBox.Checked
        SubjectCheckBox.Checked = AllCheckBox.Checked
    End Sub

    Private Sub SelectAllCheckBoxIfNeeded() Handles SubjectCheckBox.Click, RoomCheckBox.Click, ClassCheckBox.Click
        If SubjectCheckBox.Checked And RoomCheckBox.Checked And ClassCheckBox.Checked Then
            AllCheckBox.Checked = True
        Else
            AllCheckBox.Checked = False
        End If
    End Sub

    ' Change of state

    Private Sub SubjectCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles SubjectCheckBox.CheckedChanged
        CurrentViewBy = CurrentViewBy Xor ViewBy.Subject
    End Sub

    Private Sub ClassCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles ClassCheckBox.CheckedChanged
        CurrentViewBy = CurrentViewBy Xor ViewBy.Classe
    End Sub

    Private Sub RoomCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles RoomCheckBox.CheckedChanged
        CurrentViewBy = CurrentViewBy Xor ViewBy.Room
    End Sub
End Class
