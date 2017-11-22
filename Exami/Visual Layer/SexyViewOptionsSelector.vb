Public Class SexyViewOptionsSelector
    Public Event OptionsChanged()
    Public Event NewStatusMsg(msg As String)

    ' =========== ' 
    '  Expansion  '
    ' =========== '

    Public ForceExpantion As Boolean = False
    Public showNumbers As Boolean = True
    Public sortedBy As SeeSortedBy = SeeSortedBy.Alpha

    Private _Expanded As Boolean
    Public Property Expanded() As Boolean
        Get
            Return _Expanded
        End Get
        Set(ByVal value As Boolean)
            If value Then
                Expand()
            Else
                Contract()
            End If
        End Set
    End Property


    Private Sub Expand() Handles ViewButton.MouseEnter, ViewButton.Enter
        If _Expanded Then
            Return
        End If

        _Expanded = True
        Dim prevRight = Me.Right
        ' Big size
        Size = New Size(250, 567)
        Me.BorderStyle = BorderStyle.FixedSingle
        ' But we want to keep the right anchor
        Me.Left = prevRight - Width
    End Sub

    Private Sub Contract() Handles ViewButton.MouseLeave, ViewButton.Leave
        If Not _Expanded Or ForceExpantion Then
            Return
        End If

        _Expanded = False
        Dim prevRight = Me.Right
        BorderStyle = BorderStyle.None
        Size = New Size(40, 40)
        Me.Left = prevRight - Width
    End Sub

    Private Sub SexyViewOptionsSelector_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Expanded = False
    End Sub

    ' =========== ' 
    '  Group  By  '
    ' =========== '

    Public CurrentGroupBy As GroupBy = GroupBy.None

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
        CurrentGroupBy = CurrentGroupBy Xor GroupBy.Subject
    End Sub
    Private Sub ClassCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles ClassCheckBox.CheckedChanged
        CurrentGroupBy = CurrentGroupBy Xor GroupBy.Classe
    End Sub
    Private Sub RoomCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles RoomCheckBox.CheckedChanged
        CurrentGroupBy = CurrentGroupBy Xor GroupBy.Room
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ViewButton.Click
        ForceExpantion = Not ForceExpantion
        If ForceExpantion Then
            RaiseEvent NewStatusMsg("View options pinned.")
        Else
            RaiseEvent NewStatusMsg("View options unpinned")
        End If
    End Sub

    Private Sub ShowNumbersButton_CheckedChanged() Handles ShowNumbersButton.CheckedChanged
        showNumbers = ShowNumbersButton.Checked
        RaiseEvent OptionsChanged()
    End Sub

    ReadOnly Property Options
        Get
            Return New PlacementViewOptions(Me.CurrentGroupBy, Me.sortedBy, Me.showNumbers)
        End Get
    End Property


    Private Sub SortAzButton_CheckedChanged(sender As Object, e As EventArgs) Handles SortAzButton.Click
        sortedBy = SeeSortedBy.Alpha
        RaiseEvent OptionsChanged()
    End Sub
    Private Sub SortTableButton_CheckedChanged(sender As Object, e As EventArgs) Handles SortTableButton.Click
        sortedBy = SeeSortedBy.Table
        RaiseEvent OptionsChanged()
    End Sub
    Private Sub SortNumButton_CheckedChanged(sender As Object, e As EventArgs) Handles SortNumButton.Click
        sortedBy = SeeSortedBy.Number
        RaiseEvent OptionsChanged()
    End Sub
End Class