Public Class SexyViewOptionsSelector
    Public Event OptionsChanged()
    Public Event NewStatusMsg(msg As String)
    ' =========== ' 
    '  Expansion  '
    ' =========== '

    Public ForceExpantion As Boolean = False

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


    Private Sub Expand() Handles Me.MouseEnter, Me.Enter, Button1.MouseEnter, Button1.MouseEnter
        If _Expanded Then
            Return
        End If

        _Expanded = True
        Dim prevRight = Me.Right
        ' Big size
        Size = New Size(250, 500)
        Me.BorderStyle = BorderStyle.FixedSingle
        ' But we want to keep the right anchor
        Me.Left = prevRight - Width
    End Sub

    Private Sub Contract()
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

    Public CurrentViewBy As ViewBy = ViewBy.None

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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ForceExpantion = Not ForceExpantion
    End Sub
End Class
