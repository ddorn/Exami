Imports Exami

''' <summary>
''' This control let the user select set of flags for the GroupType enumeration.
''' </summary>
Public Class OptionsSelector

    Public CurrentViewBy As GroupBy = GroupBy.None

    Public Event OptionsChanged()

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
        CurrentViewBy = CurrentViewBy Xor GroupBy.Subject
    End Sub

    Private Sub ClassCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles ClassCheckBox.CheckedChanged
        CurrentViewBy = CurrentViewBy Xor GroupBy.Classe
    End Sub

    Private Sub RoomCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles RoomCheckBox.CheckedChanged
        CurrentViewBy = CurrentViewBy Xor GroupBy.Room
    End Sub


End Class
