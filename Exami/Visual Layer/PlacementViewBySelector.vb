Public Class PlacementViewBySelector
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



End Class
