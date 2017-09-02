Public Class RoomManager

    Public Event CreateRoom()
    Public Event NewStatusMessage(msg As String)

    ' Tutorial shown until somthing is selected
    Dim helperRoomList = New String() {
            "Once you've selectedthe folder",
            "You can create a classroom",
            "By clicking the + button",
            "Then select it",
            "And create a placement"
        }

    ''' <summary> 
    ''' The folder from where the rooms are shown
    ''' </summary>
    Dim folderPath As String

    ''' <summary>
    ''' The RoomManager will show the room of the given folder.
    ''' </summary>
    ''' <param name="path">The folder to get rooms.</param>
    Public Sub SetFolder(path As String)

        If path Is Nothing Or path = "" Then
            Return
        End If

        ' We update the folder
        folderPath = path
        ' And then what we know about it
        UpdateRoomList()
        ' If the folder is empty or not, we can always create a room
        CreateRoomButton.Enabled = True
    End Sub

    Private Function RoomNameToPath(roomName As String) As String
        Return IO.Path.Combine(folderPath, roomName)
    End Function
    Private Function PathToRoomName(path As String) As String
        Return IO.Path.GetFileNameWithoutExtension(path)
    End Function

    Private Sub UpdateRoomList()
        Dim thereIsRoomsInTheFolder As Boolean = False
        Dim rooms As String() = helperRoomList

        ' Getting the rooms or the tuto if there is not rooms or if the folder is empty

        If folderPath Is Nothing Or folderPath = "" Or Not IO.Directory.Exists(folderPath) Then
            ' The inital values are already whay we want
        Else
            rooms = File.GetFilesWithExtension(folderPath, ".dd")

            If rooms.GetUpperBound(0) > 0 Then
                ' We hace a non empty room list ! Cool
                thereIsRoomsInTheFolder = True
            Else
                ' If its empty wewant our tuto back
                rooms = helperRoomList
            End If
        End If

        ' Put rooms in the CheckedListBox

        RoomsListBox.BeginUpdate()
        RoomsListBox.Items.Clear()
        ' We add each file name (without folder/extension)
        For Each room In rooms
            room = PathToRoomName(room)
            RoomsListBox.Items.Add(room)
        Next
        RoomsListBox.EndUpdate()

        ' Enable buttons depending on the existence of rooms

        RoomsListBox.Enabled = thereIsRoomsInTheFolder
        DeleteRoomButton.Enabled = thereIsRoomsInTheFolder
        ModifyRoomButton.Enabled = thereIsRoomsInTheFolder
        CopyRoomButton.Enabled = thereIsRoomsInTheFolder
        RenameRoomButton.Enabled = thereIsRoomsInTheFolder

    End Sub

    Private Sub CreateRoomButton_Click(sender As Object, e As EventArgs) Handles CreateRoomButton.Click
        RaiseEvent CreateRoom()
    End Sub

    Private Sub DeleteRoomButton_Click(sender As Object, e As EventArgs) Handles DeleteRoomButton.Click
        Dim delCount = RoomsListBox.CheckedIndices.Count

        If delCount = 0 Then
            RaiseEvent NewStatusMessage("Deleting zero rooms is a bit pointless, isn't it ?")
            Return
        End If

        If MsgBox(String.Format("You are going to delete {0} room templates. This action is NOT reversible. Are you sure to continue ?", delCount), MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2) Then

        End If
    End Sub
End Class
