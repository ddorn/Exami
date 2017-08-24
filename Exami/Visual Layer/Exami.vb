Public Class ExamiForm

    Dim OuaBonjour
    Public WorkingFolder As String

    ' Button functions

    Private Sub ChooseFolderButton_Click() Handles ChooseFolderButton.Click

        ' Prompt the user for a folder
        Dim result As DialogResult = FolderChooseWidget.ShowDialog()

        ' Be sure the user selected a folder
        If Not result = DialogResult.OK Then
            MsgBox("You must select a folder.")
            Return
        End If

        ' The selected folder path
        WorkingFolder = FolderChooseWidget.SelectedPath

        ' Display the selected folder 
        ChooseFolderButton.Text = "Selected: " & WorkingFolder.Split("\").Last

        ' Updates visibles files
        UpdateAvailaibleFiles()

        ' The onverter and room designer are available now that a folder is selected
        ConvertButton.Enabled = True
        CreateRoomButton.Enabled = True

    End Sub

    Private Sub ConvertButton_Click() Handles ConvertButton.Click
        Dim nbFilesConverted = 0
        Dim nbFilesFailed = 0

        ' We convert each .vass file in the WorkingFolder
        For Each fileName In File.GetFilesWithExtension(WorkingFolder, ".vass")
            ' Keeping track of the number converted / failed
            If DataAccessLayer.SV.TryConvertVassToSv(fileName) Then
                nbFilesConverted += 1
            Else
                nbFilesFailed += 1
            End If
        Next

        ' Be kind, tell her what happend
        If nbFilesConverted = 0 Then
            MsgBox("There is no .vass files to convert in this folder :/")
        ElseIf nbFilesFailed = 0 Then
            MsgBox("All data processed")
        Else
            MsgBox(String.Format("{} files where processed but {} failed", nbFilesConverted, nbFilesFailed))
        End If

        ' Show new files 
        UpdateAvailaibleFiles()
    End Sub

    Private Sub PlacementButton_Click() Handles PlacementButton.Click

        Dim placement As Placement

        If Not TryGetPlacementFromSelectedOrWarn(placement) Then
            ' We already warned about the selected stuff in the TryGetBlabla so we just go back
            Return
        End If

        ' Probably a problem with the files
        If Not placement.TryMakePlacement() Then
            MsgBox("Something went wrong... Check if files exists and are readble.")
            UpdateAvailaibleFiles()
            Return
        End If

        If placement.notPlaced.Count > 0 Then
            Dim response = MsgBox(String.Format("There will be {0} students without a place. Continue ?", placement.notPlaced.Count), MsgBoxStyle.YesNo)
            If response = MsgBoxResult.No Then
                Return
            End If
        End If

        PlacementBox.ResetText()
        ' Show the placement on the screen
        PlacementBox.Text = placement.GetPlacementFormatedString()
        ' Highlighting sections
        HighLightSectionPlacementBox()

        ' Allow the user to save this placement
        SaveButton.Visible = True
    End Sub

    Private Sub CreateRoomButton_Click() Handles CreateRoomButton.Click

        ' Just switch to the room designer form
        Me.Hide()
        RoomDesigner.Show()

    End Sub

    Private Sub SaveButton_Click() Handles SaveButton.Click
        Dim fileName As String
        Dim filePath As String

        Dim placement As Placement
        If TryGetPlacementFromSelectedOrWarn(placement) = False Then
            'We have already worn
            Return
        End If

        Dim prompt As String = "Enter the name of the exam to save."
        ' Until we have a valid file name

        While Not File.IsValidFileName(fileName)
            ' We ask (a bit too violently I think) the name of the file to save
            fileName = InputBox(prompt)

            ' If nothing is entered (like when clicked cancel)
            If fileName = "" Then
                ' Ask if they want to leaaaave
                If MsgBox("You don't want to save it ?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                    Return
                End If
            End If
            ' We change the message a bit to explain why we ask again this boring question
            prompt = "This name is not valid, try an other one (don't use any special chars)"
        End While

        ' We put it in the folder
        filePath = IO.Path.Combine(WorkingFolder, fileName & ".txt")

        ' And save it
        placement.Save(filePath)
    End Sub

    ' Utilitaries functions

    ''' <summary>
    ''' Get the placement given the checked items in the CheckedListBoxes.
    ''' If there is something wrong, it tells the user and a return value indicates it
    ''' </summary>
    ''' <param name="placement">The variable that will hold the placement.</param>
    ''' <returns>Try if it succeded, else False.</returns>
    Private Function TryGetPlacementFromSelectedOrWarn(ByRef placement As Placement) As Boolean
        Dim svFiles As String()
        Dim ddFiles As String()

        ' Try to get the selected files from the to checklist boxes
        svFiles = GetSelectedFilesNamesOrWarn(svListBox, "class", ".sv")
        ddFiles = GetSelectedFilesNamesOrWarn(ddListBox, "classroom", ".dd")

        ' We want one man !!! We already warned so we just go back
        If svFiles Is Nothing Or ddFiles Is Nothing Then
            Return False
        End If

        ' We create the new placement
        placement = New Placement(svFiles, ddFiles)
        Return True

    End Function

    ''' <summary>
    ''' Get an array of the checked files in a given CheckedListBox, assuming the files are all in the WorkingDirectory.
    ''' If there is not checked files, it will warn the user and return Nothing
    ''' </summary>
    ''' <param name="checkListBox">The CheckedListBox the get checked items</param>
    ''' <param name="name">The name of what the user didn't selcect (for warning purposes)</param>
    ''' <param name="extension">The extensions of files in this checkedbox</param>
    ''' <returns>An array of selected files</returns>
    Public Function GetSelectedFilesNamesOrWarn(checkListBox As CheckedListBox, name As String, extension As String) As String()

        ' If there is no checked item
        If checkListBox.CheckedItems.Count = 0 Then
            MsgBox(String.Format("Select a {0} first.", name), MsgBoxStyle.Exclamation)
            Return Nothing
        End If

        ' We just append every checked thing to the list
        Dim fileNames As New List(Of String)
        For i = 0 To (checkListBox.Items.Count - 1)
            If checkListBox.GetItemChecked(i) = True Then
                fileNames.Add(checkListBox.Items(i))
            End If
        Next

        ' And then convert it to the full path
        For pos = 0 To fileNames.Count - 1
            fileNames(pos) = IO.Path.Combine(WorkingFolder, fileNames(pos) & extension)
        Next

        ' Finally, I prefer array than lists so... 
        Return fileNames.ToArray
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
        successSV = TrySetFileListBoxItems(svListBox, File.GetFilesWithExtension(WorkingFolder, ".sv"), defaultItems)
        successDD = TrySetFileListBoxItems(ddListBox, File.GetFilesWithExtension(WorkingFolder, ".dd"), defaultItems)

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
    ''' <param name="listBox">The CheckedListBox to set items</param>
    ''' <param name="items">The future contents of the ListBox</param>
    ''' <param name="defaultsItems">The subtitude for <paramref name="items"/> if this array is empty.</param>
    ''' <returns>True if the items are set False otherwise (even if it is the <paramref name="defaultsItems"/> that is set.</returns>
    Private Function TrySetFileListBoxItems(listBox As CheckedListBox, items As String(), Optional defaultsItems As String() = Nothing) As Boolean
        ' TODO : remove it, or not ?
        ' If items is empty
        If items.GetUpperBound(0) < 0 Then
            ' If there is some default to set
            If defaultsItems IsNot Nothing Then
                'And things in it
                If defaultsItems.GetUpperBound(0) >= 0 Then
                    TrySetFileListBoxItems(listBox, defaultsItems)
                End If
            End If
            Return False
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

            ' We pretend they are set, but it is the same result
            If allSame Then
                Return True
            End If
        End If

        listBox.BeginUpdate()
        listBox.Items.Clear()

        ' We add each file name (without folder/extension)
        For Each file In items
            file = IO.Path.GetFileNameWithoutExtension(file)
            listBox.Items.Add(file)
        Next

        listBox.EndUpdate()
        Return True
    End Function

    Sub HighLightSectionPlacementBox()
        ' Thanks !
        ' https://social.msdn.microsoft.com/Forums/vstudio/en-US/89355ca9-d026-4140-8326-354a95706365/making-specific-lines-bold-in-a-richtextbox-vbnet?forum=vbgeneral

        PlacementBox.SuspendLayout()

        PlacementBox.SelectionStart = 0
        PlacementBox.SelectionLength = PlacementBox.TextLength
        PlacementBox.Font = New Font(PlacementBox.Font, FontStyle.Regular)

        For iLine = 0 To PlacementBox.Lines.Length - 1
            PlacementBox.SelectionStart = PlacementBox.GetFirstCharIndexFromLine(iLine)
            PlacementBox.SelectionLength = PlacementBox.Lines(iLine).Length

            If PlacementBox.Lines(iLine).StartsWith(" ") Then
                PlacementBox.SelectionFont = New Font(PlacementBox.SelectionFont, FontStyle.Bold)

                If PlacementBox.Lines(iLine).StartsWith("  ") Then
                    PlacementBox.SelectionFont = New Font(PlacementBox.SelectionFont, FontStyle.Bold Or FontStyle.Underline)

                    If PlacementBox.Lines(iLine).StartsWith("   ") Then
                        PlacementBox.SelectionAlignment = HorizontalAlignment.Center
                    End If
                End If
            End If
        Next

        PlacementBox.SelectionStart = 0
        PlacementBox.SelectionLength = 0

        PlacementBox.ResumeLayout()
    End Sub

End Class