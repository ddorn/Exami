Public Class RoomManager

    Public Event CreateRoom()
    Public Event NewStatusMessage(msg As String)
    Public Event SelectionChanged()

    ' Tutorial shown until somthing is selected
    Dim helperRoomList = New String() {
            "Once you've selected a folder",
            "You can create a classroom",
            "By clicking the + button",
            "Then select it",
            "And create a placement"
        }
    ''' <summary> 
    ''' The folder from where the rooms are shown
    ''' </summary>
    Dim folderPath As String

    ' Conversion between path and names

    Private Function RoomNameToPath(roomName As String) As String
        Return IO.Path.Combine(folderPath, roomName + ".dd")
    End Function
    Private Function PathToRoomName(path As String) As String
        Return IO.Path.GetFileNameWithoutExtension(path)
    End Function

    ' Update visible rooms

    ''' <summary>
    ''' Reload the folder to update the list of availaible rooms
    ''' </summary>
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
        CopyRoomButton.Enabled = thereIsRoomsInTheFolder
        ModifyRoomButton.Enabled = False
        RenameRoomButton.Enabled = thereIsRoomsInTheFolder

    End Sub

    ' ============= '
    ' Button clicks '
    ' ============= '

    ''' <summary>
    ''' Show the RoomDesigner
    ''' </summary>
    Private Sub CreateRoomButton_Click() Handles CreateRoomButton.Click
        RaiseEvent CreateRoom()
    End Sub

    ''' <summary>
    ''' Delete the selected rooms, with a confirmation prompt to the user
    ''' </summary>
    Private Sub DeleteRoomButton_Click() Handles DeleteRoomButton.Click
        Dim delCount = RoomsListBox.CheckedIndices.Count

        If delCount = 0 Then
            RaiseEvent NewStatusMessage("Deleting zero rooms is a bit pointless, isn't it ?")
            Return
        End If

        If DialogResult.No = MsgBox(String.Format("You are going to delete {0} room templates. This action is NOT reversible. Are you sure to continue ?", delCount), MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2) Then
            Return
        End If

        Dim succes = delCount
        For Each file In GetSelectedRoomFiles()
            Try
                My.Computer.FileSystem.DeleteFile(file, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.SendToRecycleBin, FileIO.UICancelOption.DoNothing)
            Catch ex As Exception
                succes -= 1
            End Try
        Next

        RaiseEvent NewStatusMessage(String.Format("{0}/{1} rooms were moved to the recycle bin.", succes, delCount))
        UpdateRoomList()
    End Sub

    ''' <summary>
    ''' Delete the curently checked rooms.
    ''' </summary>
    Private Sub CopyRoomButton_Click(sender As Object, e As EventArgs) Handles CopyRoomButton.Click

        Dim toCopy = CheckedNumber()
        Dim succes = toCopy

        ' Forech selected room path
        For Each file In GetSelectedRoomFiles()
            ' we add " - copy" to it
            Dim newFileName = IO.Path.Combine(IO.Path.GetDirectoryName(file), IO.Path.GetFileNameWithoutExtension(file) + " - copy.dd")

            ' And we copy it
            Try
                My.Computer.FileSystem.CopyFile(file, newFileName)
            Catch ex As Exception
                succes -= 1
            End Try
        Next

        'Don't forget to show the new rooms
        UpdateRoomList()

        RaiseEvent NewStatusMessage(String.Format("{0}/{1} rooms were copied", succes, toCopy))

    End Sub

    ''' <summary>
    ''' Rename the selected room.
    ''' </summary>
    Private Sub RenameRoomButton_Click() Handles RenameRoomButton.Click
        If CheckedNumber() <> 1 Then
            MsgBox("You can rename rooms only one by one.")
            RaiseEvent NewStatusMessage("You can rename rooms only one by one")
            Return
        End If

        ' There is exactly one so it is index 0
        Dim currentFileName = GetSelectedRoomFiles()(0)

        Dim newName As String = InputBox("Choose the new name for " + PathToRoomName(currentFileName))

        ' If the name i not valid, say it and do nothing
        If Not File.IsValidFileName(newName) Then
            RaiseEvent NewStatusMessage("I can't rename the room, the name is invalid")
            Return
        End If

        Try
            My.Computer.FileSystem.RenameFile(currentFileName, newName + ".dd")
            RaiseEvent NewStatusMessage(String.Format("{0} where renamed to {1}", PathToRoomName(currentFileName), newName))
        Catch ex As Exception
            RaiseEvent NewStatusMessage("The rename has failed for an unknown reason.")
        End Try

        UpdateRoomList()

    End Sub

    ''' <summary>
    ''' Tell the world that the checked rooms has changed
    ''' </summary>
    Private Sub SelectionChange() Handles RoomsListBox.ItemCheck
        RaiseEvent SelectionChanged()
    End Sub

    ' ============== '
    ' Public methods ' 
    ' ============== '

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

    ''' <summary>
    ''' Get a list of the file paths of the selected rooms. Thie list can be empty.
    ''' </summary>
    Public Function GetSelectedRoomFiles() As List(Of String)
        Dim roomFiles = New List(Of String)

        For Each item In RoomsListBox.CheckedItems
            roomFiles.Add(RoomNameToPath(item))
        Next

        Return roomFiles
    End Function

    ''' <summary>
    ''' The number of checked rooms
    ''' </summary>
    Public Function CheckedNumber() As Integer
        Return RoomsListBox.CheckedIndices.Count
    End Function

End Class
