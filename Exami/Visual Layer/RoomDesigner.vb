Public Class RoomDesigner

    Dim preview As RoomPreview

    Private Sub CreateRoomButton_Click() Handles CreateRoomButton.Click

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
        Exami2.Show()
        Exami2.ReloadWorkingFolder()
    End Sub

    Private Sub CancelButton_Click() Handles CancelButton.Click
        Dim response = MsgBox("Are you sure you don't want to save ? All your work will be lost.", MsgBoxStyle.OkCancel)

        If response = MsgBoxResult.Ok Then
            Me.Close()
            Exami2.Show()
        End If
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        Dim result As String

        ' We ask until you answer niark
        Dim prompt = "What is the name of this room ?"
        While Not File.IsValidFileName(result)
            result = InputBox(prompt)
            prompt = "It is an invalid file name, try an other name for this room"
        End While

        ' Save the room
        If Not DataAccessLayer.DD.TrySaveRoom(preview, IO.Path.Combine(Exami2.WorkingFolder, result + ".dd")) Then
            MsgBox("Error while saving the room. The name could be invalid, or you don have write access here...")
            Return
        End If

        ' Go back tothe main form
        Me.Close()
        Exami2.Show()
    End Sub

End Class

''' <summary>
''' A room that displays its tables on the screen. Uses <c>RoomTable</c> to display one place.
''' </summary>
Class RoomPreview
    Inherits Room

    Dim tablesButtons As RoomTable(,)
    Public selectedTable As RoomTable

    ''' <summary>
    ''' Create a new Room with <paramref name="rowNb"/> rows and <paramref name="colNb"/> columns
    ''' </summary>
    ''' <param name="rowNb">The number of rows</param>
    ''' <param name="colNb">The nmber of columns</param>
    Sub New(rowNb As Byte, colNb As Byte)
        MyBase.New(rowNb, colNb)
        ReDim tablesButtons(rowNb, colNb)
        SetRectangle(True, 0, 0, rowNb - 1, colNb - 1)
    End Sub

    ''' <summary>
    ''' Set the availability of a place, actualing the buttons and the arrays.
    ''' </summary>
    ''' <param name="row">The row of the table. Starts at zero</param>
    ''' <param name="col">The column of the table, stars at zero</param>
    ''' <param name="value">The availability of the place</param>
    ''' <exception cref="IndexOutOfRangeException">If row or col is out of the bounds of the array / room</exception>
    Protected Overrides Sub SetAvailable(row As Byte, col As Byte, value As Boolean)
        MyBase.SetAvailable(row, col, value)
        If tablesButtons(row, col) Is Nothing Then
            tablesButtons(row, col) = New RoomTable(row, col, Me, value)
        Else
            tablesButtons(row, col).Available = value
        End If
    End Sub
End Class


''' <summary>
''' One table for the RoomPreview. Shows the availability of a place with pride !
''' </summary>
Class RoomTable
    Inherits Button

    Const sep = 0
    Private _available As Boolean
    Public row, col As Byte
    Public roomPreviewParent As RoomPreview

    ''' <summary>
    ''' Initialise a new RoomTable with a given availability.
    ''' </summary>
    ''' <param name="row">The row of the table (starts at 0)</param>
    ''' <param name="col">The col of the table (starts at 0)</param>
    ''' <param name="roomPreviewParent">The RoomPreview object of which this table belongs</param>
    ''' <param name="available">The availability of the table</param>
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
        Location = New Point(12 + col * (Width + sep), 12 + row * (Height + sep))

        ' We add me to the form and allow events to be triggered or whatever the word is
        RoomDesigner.Controls.Add(Me)
        AddHandler Me.Click, AddressOf ButtonClicked

    End Sub

    ''' <summary>
    ''' Performs the click in the button.
    ''' Modify availability in the roomPreviewParent.
    ''' </summary>
    Private Sub ButtonClicked()
        ' If there is no previously selected button
        If roomPreviewParent.selectedTable Is Nothing Then
            ' It is this one !
            roomPreviewParent.selectedTable = Me
            ' Show it with some purple
            ForeColor = Color.MediumPurple
        Else
            ' If there is already one
            Dim row2 = roomPreviewParent.selectedTable.row
            Dim col2 = roomPreviewParent.selectedTable.col

            ' Change the rectangle of the preview 
            roomPreviewParent.ChangeAvailaible(row, col, row2, col2)
            ' And reset the previously selected button 
            roomPreviewParent.selectedTable = Nothing
        End If
    End Sub

    ''' <summary>
    ''' Get or set the availability of this table.
    ''' Sets the colors too ! :D Coloooooors
    ''' </summary>
    ''' <returns>The availability of the table</returns>
    Public Property Available() As Boolean
        Get
            Return _available
        End Get

        Set(ByVal value As Boolean)
            ' If it is purple aka. selected we reset it
            ForeColor = Color.Black

            ' Such beautiful colors, NEVER CHANGE THE ORANGE
            If value Then
                BackColor = Color.GreenYellow
            Else
                BackColor = Color.OrangeRed
            End If

            ' Yeah, of course
            _available = value
        End Set
    End Property

End Class