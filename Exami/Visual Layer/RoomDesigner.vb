Public Class RoomDesigner

    Dim preview As RoomPreview

    Private Sub Button1_Click() Handles CreateRoomButton.Click
        ' We hide the size stuff
        RowLabel.Visible = False
        ColumnLabel.Visible = False
        CreateRoomButton.Visible = False
        RowNumericUpDown.Visible = False
        ColumnNumericUpDown.Visible = False

        ' Show the options of the room designer
        CancelButton.Visible = True
        SaveButton.Visible = True

        ' Create our beautiful way to design rooms !
        preview = New RoomPreview(RowNumericUpDown.Value, ColumnNumericUpDown.Value)
    End Sub

    Private Sub RoomDesigner_Closed() Handles Me.Closed
        ExamiForm.Show()
        ExamiForm.UpdateAvailaibleFiles()
    End Sub

    Private Sub CancelButton_Click() Handles CancelButton.Click
        Dim response = MsgBox("Are you sure you don't want to save ? All your work will be lost.", MsgBoxStyle.OkCancel)

        If response = MsgBoxResult.Ok Then
            Me.Close()
            ExamiForm.Show()
        End If
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        Dim result = InputBox("Enter the name of the room.")

        If result = "" Then
            MsgBox("Invalid name, try something longer !")
            Return
        ElseIf result.Contains(".") Or result.Contains("/") Or result.Contains("\") Then
            MsgBox("Do not use special characters.")
            Return
        End If

        ' Save the room
        DataAccessLayer.DD.SaveRoom(preview, IO.Path.Combine(ExamiForm.WorkingFolder, result + ".dd"))

        ' Go back tothe main form
        Me.Close()
        ExamiForm.Show()
    End Sub

End Class


Class RoomPreview
    Inherits Room

    Dim tablesButtons As RoomTable(,)
    Public selectedTable As RoomTable

    Sub New(rowNb, colNb)
        MyBase.New(rowNb, colNb)
        ReDim tablesButtons(rowNb, colNb)
        SetRectangle(True, 0, 0, rowNb - 1, colNb - 1)
    End Sub

    Protected Overrides Sub SetAvailable(row As Byte, col As Byte, value As Boolean)
        MyBase.SetAvailable(row, col, value)
        If tablesButtons(row, col) Is Nothing Then
            tablesButtons(row, col) = New RoomTable(row, col, Me, value)
        Else
            tablesButtons(row, col).Available = value
        End If
    End Sub
End Class


Class RoomTable
    Inherits Button

    Private _available As Boolean
    Public row, col As Byte
    Public roomPreviewParent As RoomPreview

    Sub New(row As Byte, col As Byte, roomPreviewParent As RoomPreview, available As Boolean)
        MyBase.New()
        With Me
            .Available = available
            .row = row
            .col = col
            .roomPreviewParent = roomPreviewParent
        End With

        ' We navigate col by col and changing row at the and of the column
        TabIndex = col * roomPreviewParent.LastRow + row
        Text = New Place(row, col).ToString()
        Size = New Size(81, 50)  ' goldratio4ever
        Location = New Point(12 + col * (Width + 6), 12 + row * (Height + 6))

        ' We add meto the form and allow events to be triggered or whatever the word is
        RoomDesigner.Controls.Add(Me)
        AddHandler Me.Click, AddressOf ButtonClicked

    End Sub

    Private Sub ButtonClicked()
        If roomPreviewParent.selectedTable Is Nothing Then
            roomPreviewParent.selectedTable = Me
            ForeColor = Color.MediumPurple
        Else
            Dim row2 = roomPreviewParent.selectedTable.row
            Dim col2 = roomPreviewParent.selectedTable.col

            roomPreviewParent.ChangeAvailaible(row, col, row2, col2)
            roomPreviewParent.selectedTable = Nothing
        End If
    End Sub

    Public Property Available() As Boolean
        Get
            Return _available
        End Get
        Set(ByVal value As Boolean)
            ForeColor = Color.Black
            If value Then
                BackColor = Color.GreenYellow
            Else
                BackColor = Color.OrangeRed
            End If
            _available = value
        End Set
    End Property

End Class