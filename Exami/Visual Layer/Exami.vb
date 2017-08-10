Public Class ExamiForm

    Public WorkingFolder As String

    ' Button functions

    Private Sub ChooseFolderButton_Click() Handles ChooseFolderButton.Click

        ' Prompt the user for a folder
        Dim result As DialogResult = FolderChooseWidget.ShowDialog()

        ' Be sure the user selected a folder
        If Not result = DialogResult.OK Then
            MsgBox("You must select a folder")
            Return
        End If

        ' the selected folder path
        WorkingFolder = FolderChooseWidget.SelectedPath

        ' activate the buttons and display the folder selected
        folderLabel.Text = WorkingFolder

        UpdateAvailaibleFiles()

        ' The room designer and converter are available now that a folder is selected
        CreateRoomButton.Enabled = True
        ConvertButton.Enabled = True

    End Sub

    Private Sub ConvertButton_Click() Handles ConvertButton.Click
        For Each fileName In GetFilesWithExtension(WorkingFolder, ".vass")
            DataAccessLayer.SV.ConvertVassToSv(fileName)
        Next

        MsgBox("All data processed")
        UpdateAvailaibleFiles()
    End Sub

    Private Sub PlacementButton_Click() Handles PlacementButton.Click
        Dim svFile = GetSelectedFilesNamesOrWarn(svListBox, "class", ".sv")
        Dim ddFile = GetSelectedFilesNamesOrWarn(ddListBox, "classroom", ".dd")

        ' We want one man !!!
        If ddFile Is Nothing Or svFile Is Nothing Then
            Return
        End If

        ResultLabel.Text = GetPlacementString(svFile, ddFile)
    End Sub

    Private Sub CreateRoomButton_Click() Handles CreateRoomButton.Click
        Me.Hide()
        RoomDesigner.Show()
    End Sub

    Private Sub SaveButton_Click() Handles SaveButton.Click
        Dim svFile As String
        Dim ddFile As String
        Dim textToSave As String
        Dim fileName As String
        Dim filePath As String

        svFile = GetSelectedFilesNamesOrWarn(svListBox, "class", ".sv")
        ddFile = GetSelectedFilesNamesOrWarn(ddListBox, "classroom", ".dd")
        textToSave = GetPlacementString(svFile, ddFile)

        fileName = String.Format("Examun {0} room {1} the {2}")
        filePath = IO.Path.Combine(WorkingFolder, fileName)

    End Sub

    ' Utilitaries functions

    Public Function GetSelectedFilesNamesOrWarn(listBox As CheckedListBox, name As String, extension As String)

        Dim fileName = GetOneSelected(listBox, name)
        If fileName Is Nothing Then
            Return Nothing
        End If
        fileName = IO.Path.Combine(WorkingFolder, fileName + extension)
        Return fileName
    End Function

    ''' <summary>
    ''' Make the placement and return one string of all the places.
    ''' </summary>
    ''' <remarks>The files must exist or an exception will be raised.</remarks>
    Public Function GetPlacementString(svFile As String, ddFile As String) As String

        ' Then we can get a list of students from the file 
        Dim Students As Student() = SV.GetStudents(svFile)
        ' And a list of the tables
        Dim Places As Place() = DataAccessLayer.DD.LoadRoom(ddFile).GetPlaces1DArray

        Dim placementString As String = ""

        Dim pos As Short = 0
        While pos < Students.Length And pos < Places.Length
            placementString += Places(pos).ToString() & " " & Students(pos).ToString()
            placementString += Environment.NewLine
            pos += 1
        End While

        Return placementString
    End Function


    ''' <summary>
    ''' Updates the files shown in the two CheckBoxList and enables them if needed.
    ''' </summary>
    Public Sub UpdateAvailaibleFiles()
        If WorkingFolder Is Nothing Then
            Debug.WriteLine("UpdateAvailableFiles called when there was no WorkingFolder set.", "WARNING")
            Return
        End If


        Dim successSV As Boolean
        Dim successDD As Boolean

        ' Tutorial shown until somthing is selected
        Dim defaultItems = New String() {
            "First select a folder",
            "Convert vass files",
            "Create and select a classroom",
            "Create the placement"
        }

        ' basicly, those booleans are just is there is some .sv files in the working folder (resp dd)
        successSV = SetFileListBoxItems(svListBox, GetFilesWithExtension(WorkingFolder, ".sv"), defaultItems)
        successDD = SetFileListBoxItems(ddListBox, GetFilesWithExtension(WorkingFolder, ".dd"), defaultItems)

        ' If and only if there is files the user can check them
        svListBox.Enabled = successSV
        ddListBox.Enabled = successDD

        ' He can make a placement only if poth are valables 
        PlacementButton.Enabled = successDD And successSV

    End Sub

    ''' <summary>
    ''' Sets the contents of the FileListBox to the given items.
    ''' The items are an array of file paths, and the items shown in the checkedLstBox will be only the file name (without extension and folders)
    ''' You can provide a default items array in case the first one is empty. I know this compprtement is a bit weird but I will change it later... maybe
    ''' </summary>
    ''' <param name="items">The future contents of the ListBox</param>
    Private Function SetFileListBoxItems(listBox As CheckedListBox, items As String(), Optional defaultsItems As String() = Nothing) As Boolean
        ' TODO : remove it, or not ?
        If items.GetUpperBound(0) < 0 Then
            If defaultsItems IsNot Nothing Then
                If defaultsItems.GetUpperBound(0) >= 0 Then
                    SetFileListBoxItems(listBox, defaultsItems)
                End If
            End If
            Return 0
        End If

        ' Check if the contents are the same, in this case we do nothing so we don't lose the checked boxes
        If items.GetUpperBound(0) + 1 = listBox.Items.Count Then
            Dim allSame As Boolean = True

            For pos = 0 To items.GetUpperBound(0)
                ' We never put the whole file path, juste name of file, so I need to convert it first
                If IO.Path.GetFileNameWithoutExtension(items(pos)) <> listBox.Items.Item(pos) Then
                    allSame = False
                    Exit For
                End If
            Next

            If allSame Then
                Return 1
            End If
        End If

        listBox.BeginUpdate()
        listBox.Items.Clear()

        For Each file In items
            file = IO.Path.GetFileNameWithoutExtension(file)
            listBox.Items.Add(file)
        Next

        listBox.EndUpdate()
        Return 1
    End Function

    ''' <summary>
    ''' Get a 1-dimensional array of all available places. For now it asumes the room is a rectangle of an hardcoded size
    ''' </summary>
    ''' <returns>A 1-dimentional array of places</returns>
    Private Function GetPlacesArray() As Place()

        ' for now it's just a rectangular placement of size MAXROW x MAXCOl
        Dim MAXROW = 5
        Dim MAXCOL = 4

        Dim row As Byte = 0
        Dim col As Byte = 0
        Dim Places(MAXCOL * MAXROW - 1) As Place

        While col < MAXCOL
            row = 0
            While row < MAXROW
                Places(col * MAXROW + row) = New Place(row, col)
                row += 1
            End While
            col += 1
        End While

        Return Places
    End Function

    ''' <summary>
    ''' Get an array of all files with a specific extention in a givem folder
    ''' </summary>
    ''' <param name="path">The path to the folder</param>
    ''' <param name="extention">The extention of files to return (ex: ".vass")</param>
    ''' <returns>An array of path strings to existing files</returns>
    Shared Function GetFilesWithExtension(path As String, extention As String) As String()
        Dim NamesArray(-1) As String
        Dim NumberOfFiles = -1
        Dim fullName As String

        For Each file In IO.Directory.EnumerateFiles(path)
            If IO.Path.GetExtension(file) = extention Then
                NumberOfFiles += 1
                If NumberOfFiles > NamesArray.GetUpperBound(0) Then
                    ReDim Preserve NamesArray(NamesArray.GetUpperBound(0) + 20)
                End If

                fullName = IO.Path.Combine(path, file)
                NamesArray(NumberOfFiles) = fullName
            End If
        Next

        ReDim Preserve NamesArray(NumberOfFiles)

        Return NamesArray

    End Function

    ''' <summary>
    ''' Get the only checked item from a CheckedListBox and if there is no only one, shows warnings to the user
    ''' </summary>
    ''' <param name="checkListBox">The CheckedListBox to procced.</param>
    ''' <param name="name">The name of what the user didn't checked or checked too much, for showing warning.</param>
    ''' <returns>The checked item or Nothing</returns>
    Private Function GetOneSelected(checkListBox As CheckedListBox, name As String) As String

        If checkListBox.CheckedItems.Count = 0 Then
            MsgBox(String.Format("Select a {0} first.", name), MsgBoxStyle.Exclamation)
            Return Nothing
        ElseIf checkListBox.CheckedItems.Count > 1 Then
            MsgBox(String.Format("Currently support only one {0} at a time", name), MsgBoxStyle.Exclamation)
            Return Nothing
        End If

        Dim checkedItem = checkListBox.CheckedItems.Item(0)

        Return checkedItem

    End Function

End Class