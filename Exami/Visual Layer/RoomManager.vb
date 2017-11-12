''' <summary>
''' This control let the user manage the rooms of a folder. He can add, delete, modify rename and copy them.
''' This can be used to select rooms and the corresponding places.
''' </summary>
Public Class RoomManager

    Public Event CreateRoom()
    Public Event ModifyRoom(roomFileName As String)
    Public Event NewStatusMessage(msg As String)
    Public Event SelectionChanged(checkedCount As Integer)

    ' Tutorial shown until somthing is selected
    Dim helperRoomList = New String() {
            "There is no rooms in this folder",
            "Try to select an other",
            "Or create a room with the green +"
        }
    ''' <summary> 
    ''' The folder from where the rooms are shown
    ''' </summary>
    Dim folderPath As String

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()


        ' Add any initialization after the InitializeComponent() call.
        UpdateRoomList()

    End Sub

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
            ' The inital values are already what we want
        Else
            rooms = File.GetFilesWithExtension(folderPath, ".dd")

            If rooms.GetUpperBound(0) >= 0 Then
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
        ModifyRoomButton.Enabled = thereIsRoomsInTheFolder
        RenameRoomButton.Enabled = thereIsRoomsInTheFolder

    End Sub

    ' ============= '
    ' Button clicks '
    ' ============= '

    ''' <summary>
    ''' Send an event to show the RoomDesigner
    ''' </summary>
    Private Sub CreateRoomButton_Click() Handles CreateRoomButton.Click
        RaiseEvent CreateRoom()
    End Sub

    ''' <summary>
    ''' Send an event to show the RoomDesigner with a room already selected.
    ''' </summary>
    Private Sub ModifyRoomButton_Click() Handles ModifyRoomButton.Click

        ' Warn if there is more than one room selected (or zero)
        If CheckedCount() <> 1 Then
            RaiseEvent NewStatusMessage("Check only one room to modify it.")
            Return
        End If

        ' There is exactly one so its index is 0
        Dim currentFileName = GetSelectedRoomPaths()(0)

        RaiseEvent ModifyRoom(currentFileName)
    End Sub

    ''' <summary>
    ''' Delete the selected rooms, with a confirmation prompt to the user
    ''' </summary>
    Private Sub DeleteRoomButton_Click() Handles DeleteRoomButton.Click
        Dim delCount = RoomsListBox.CheckedIndices.Count

        ' Nothing selected (= to delete)

        If delCount = 0 Then
            RaiseEvent NewStatusMessage("Deleting zero rooms is a bit pointless, isn't it ?")
            Return
        End If

        ' User doesn't confirm

        If DialogResult.No = MsgBox(String.Format("You are going to delete {0} room templates. This action is NOT reversible. Are you sure to continue ?", delCount), MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2) Then
            RaiseEvent NewStatusMessage("Nothing was deleted")
            Return
        End If

        ' Delete each file one by one

        Dim succes = delCount
        For Each file In GetSelectedRoomPaths()
            Try
                My.Computer.FileSystem.DeleteFile(file, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.SendToRecycleBin, FileIO.UICancelOption.DoNothing)
            Catch ex As Exception
                ' We have supposed that every file would be deleted but was obviously it didn't worked here
                succes -= 1
            End Try
        Next

        ' For pural of the sentence

        If succes < 2 Then
            RaiseEvent NewStatusMessage(String.Format("{0} room out of {1} was moved to the recycle bin.", succes, delCount))
        Else
            RaiseEvent NewStatusMessage(String.Format("{0} rooms out of {1} were moved to the recycle bin.", succes, delCount))
        End If

        UpdateRoomList()
    End Sub

    ''' <summary>
    ''' Delete the curently checked rooms.
    ''' </summary>
    Private Sub CopyRoomButton_Click(sender As Object, e As EventArgs) Handles CopyRoomButton.Click

        Dim toCopy = CheckedCount()
        Dim succes = toCopy

        ' We copy each file one by one 

        For Each file In GetSelectedRoomPaths()
            ' first we add " - copy" to it
            Dim newFileName = IO.Path.Combine(IO.Path.GetDirectoryName(file), IO.Path.GetFileNameWithoutExtension(file) + " - copy.dd")

            ' And we copy it to the new name
            Try
                My.Computer.FileSystem.CopyFile(file, newFileName)
            Catch ex As Exception
                ' We have supposed that they will all work but well... not this one
                succes -= 1
            End Try
        Next

        ' To cases to have a good english

        If succes < 2 Then
            RaiseEvent NewStatusMessage(String.Format("{0} room out of {1} was copied", succes, toCopy))
        Else
            RaiseEvent NewStatusMessage(String.Format("{0} rooms out of {1} were copied", succes, toCopy))
        End If

        'Don't forget to show the new rooms
        UpdateRoomList()

    End Sub

    ''' <summary>
    ''' Rename the selected room.
    ''' 
    ''' This warns the user is there is more than one selected room.
    ''' </summary>
    Private Sub RenameRoomButton_Click() Handles RenameRoomButton.Click

        ' Warn if there is more than one room selected (or zero)

        If CheckedCount() <> 1 Then
            RaiseEvent NewStatusMessage("You can rename rooms only one by one")
            Return
        End If

        ' There is exactly one so its index is 0
        Dim currentFileName = GetSelectedRoomPaths()(0)

        Dim newName As String = InputBox("Choose the new name for " + PathToRoomName(currentFileName))

        ' If the name i not valid, say it and do nothing

        If Not File.IsValidFileName(newName) Then
            RaiseEvent NewStatusMessage("I can't rename the room, the name is not valid !")
            Return
        End If

        ' Try to rename the room and tell of the succes

        Try
            My.Computer.FileSystem.RenameFile(currentFileName, newName + ".dd")
            RaiseEvent NewStatusMessage(String.Format("{0} where renamed to {1}", PathToRoomName(currentFileName), newName))
        Catch ex As Exception
            RaiseEvent NewStatusMessage("The rename has failed for an unknown reason.")
        End Try

        UpdateRoomList()

    End Sub

    ''' <summary>
    ''' Tell the world that the checked rooms has changed, this just raises an event with the current number of checked rooms.
    ''' </summary>
    Private Sub SelectionChange(sender As Object, e As ItemCheckEventArgs) Handles RoomsListBox.ItemCheck

        If e.NewValue = CheckState.Checked Then
            ' There is one more room if now it is checked
            RaiseEvent SelectionChanged(CheckedCount() + 1)
        Else
            ' There is one less if it was unchecked
            RaiseEvent SelectionChanged(CheckedCount() - 1)
        End If

    End Sub

    ' ============== '
    ' Public methods ' 
    ' ============== '

    ''' <summary>
    ''' The RoomManager will now show and manage the rooms of the given folder.
    ''' </summary>
    ''' <param name="path">The folder to get rooms.</param>
    Public Sub SetFolder(path As String)

        If path Is Nothing Or path = "" Then
            Debug.Print("The path in RoomManager.SetFolder was Nothing or """".")
            Return
        End If

        ' We update the folder
        folderPath = path

        UpdateRoomList()

        ' Either if the folder is empty or not, we can always create a room
        CreateRoomButton.Enabled = True

    End Sub

    ''' <summary>
    ''' Get a list of the file paths of the selected rooms. Thie list can be empty.
    ''' </summary>
    Public Function GetSelectedRoomPaths() As String()

        Dim roomFiles = New List(Of String)

        For Each item In RoomsListBox.CheckedItems
            roomFiles.Add(RoomNameToPath(item))
        Next

        Return roomFiles.ToArray

    End Function

    ''' <summary>
    ''' The number of checked (=selected) rooms
    ''' </summary>
    Public Function CheckedCount() As Integer

        Return RoomsListBox.CheckedIndices.Count

    End Function

End Class
