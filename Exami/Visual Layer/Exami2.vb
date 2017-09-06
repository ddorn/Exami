Public Class Exami2

    Public Event NewStatusMessage(msg As String)

    Public WorkingFolder As String

    ' Create room

    Private Sub CreateRoom() Handles RoomManager1.CreateRoom

        ' Just switch to the room designer form
        Me.Hide()
        RoomDesigner.Show()

    End Sub

    ' ############## '
    ' Folder  Manage '
    ' ############## '

    ''' <summary>
    ''' Shows the FolderDialog, sets the WorkingFolder and loads it.
    ''' </summary>
    Private Sub SelectFolder() Handles SelectFolderButton.Click

        ' Prompt the user for a folder
        Dim result As DialogResult = FolderBrowserDialog1.ShowDialog()

        ' Be sure the user selected a folder
        If Not result = DialogResult.OK Then
            MsgBox("You must select a folder.")
            Return
        End If

        Dim path = FolderBrowserDialog1.SelectedPath

        ' The selected folder path
        WorkingFolder = path

        ' Show the folder in the status bar for feedback
        RaiseEvent NewStatusMessage(path)

        ' We actualize everything because the folder has changed
        ReloadWorkingFolder()

        ' Allow to convert the selected folder
        ConvertFolderButton.Enabled = True

    End Sub

    ''' <summary>
    ''' (Re)load the WorkingFolder, and then the room and subjects managers.
    ''' </summary>
    Public Sub ReloadWorkingFolder()

        ' Update the class and rooms managers
        RoomManager1.SetFolder(WorkingFolder)
        SubjectManager1.SetFolder(WorkingFolder)

    End Sub

    ''' <summary>
    ''' Converts the all the vass files in the workingFolder to sv ones. Informs the user of the succes of the operation
    ''' </summary>
    Private Sub ConvertFolder() Handles ConvertFolderButton.Click
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
        If nbFilesConverted = 0 And nbFilesFailed = 0 Then
            RaiseEvent NewStatusMessage("There is no .vass files to convert in this folder :/")
        ElseIf nbFilesFailed = 0 Then
            RaiseEvent NewStatusMessage("All data processed")
        Else
            RaiseEvent NewStatusMessage(String.Format("{} files where processed and {} failed", nbFilesConverted, nbFilesFailed))
        End If

        ' Show new files 
        ReloadWorkingFolder()

    End Sub


    ' ############## '
    '   Placement    '
    ' ############## '

    ' Enable MakePlacementButton when the selected stuff changes
    Private Sub EnablePlacementFromRoom(checkedCount As Integer) Handles RoomManager1.SelectionChanged
        ' When the user selects an item in the RoomManager that makes more than 0 items selected and there is some subject selected too
        ' Aka both have selected subject/room now
        If checkedCount > 0 And SubjectManager1.CheckedNumber > 0 Then
            MakePlacementButton.Enabled = True
        Else
            MakePlacementButton.Enabled = False
        End If
    End Sub
    Private Sub EnablePlacementFromSubject(checkedCount As Integer) Handles SubjectManager1.SelectionChanged
        If checkedCount > 0 And RoomManager1.CheckedCount > 0 Then
            MakePlacementButton.Enabled = True
        Else
            MakePlacementButton.Enabled = False
        End If
    End Sub

    ''' <summary>
    ''' Actualise thePLacementBoxes given the current ViewBy and the current selected files.
    ''' </summary>
    Private Sub MakePlacement() Handles MakePlacementButton.Click

        Dim places = DataAccessLayer.DD.LoadAllPlaces1D(RoomManager1.GetSelectedRoomPaths)
        Dim students = New StudentGroup(SubjectManager1.GetSelectedSubjectPaths)

        ' We really want to have enough places
        If students.Count > places.Count Then
            RaiseEvent NewStatusMessage("There is more students than places.")
            MsgBox("There is more students than places !", MsgBoxStyle.Exclamation)
            Return
        End If

        ' This is just removing the Room flag
        Dim groupBy = PlacementViewBySelector1.CurrentViewBy Or GroupType.Room Xor GroupType.Room

        ' The idea is to do a virtual placement 
        ' So sudents will have a room
        ' And then we can separate them by room

        Dim groups = students.Separate(groupBy)

        Dim pos = 0
        For Each group In groups
            For studPos = 0 To group.Count - 1
                group.allStudents(studPos).place = places(pos)
                pos += 1
            Next
        Next

        ' So we separate the sudents and alocating the places by chunck like u=in the previous for
        ' it is likely that sudents wont have this place at the end, but the goal are 
        '   1. to be able to already separate the clas
        '   2. to have the same group in the same 'chunk' of places
        '   3. I'm soory for not beiing clear

        ' Thos dicts have the category name as key and a chunk of students or corresponding places as values
        Dim studDict = New Dictionary(Of String, StudentGroup)
        Dim placeDict = New Dictionary(Of String, List(Of Place))

        ' The real groups with the rooms
        groups = New StudentGroup(students.allStudents).Separate(PlacementViewBySelector1.CurrentViewBy)
        For Each group In groups
            Dim name = group.GetNameAs(PlacementViewBySelector1.CurrentViewBy)
            studDict(name) = group
            ' We take the same number of places than of students
            ' We take them in the list order
            placeDict(name) = places.Take(group.Count).ToList
            ' And then remove them, they are used.
            places.RemoveRange(0, group.Count)
        Next

        ' Finally we can send those two dicts to the placementBoxes wo will add one PlacementBox for each category
        PlacementBoxes1.SetPlacements(studDict, placeDict)

    End Sub

    ' ############## '
    ' Hover Tool Tip '
    ' ############## '

    Private Sub Exami2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetUpHoverHandler(Me)
    End Sub

    ''' <summary>
    ''' Set the Status label to the tag of the current control the mouse is in.
    ''' 
    ''' Controls are added recursively via SetUpHoverControl in Exami_Load.
    ''' </summary>
    ''' <seealso cref="SetUpHoverHandler(Control)"/>
    Private Sub SetToolTipHelp(sender As Control, e As EventArgs)

        ' Only if this control has a tag, we show it in the help status
        If sender.Tag <> "" Then
            HoverStatusLabel.Text = sender.Tag
        End If

    End Sub

    ''' <summary>
    ''' Recursively add handler for when the mouse passes over a control to SetToolTipHelp.
    ''' </summary>
    ''' <param name="control">The control to add to the ToolTipHelp</param>
    ''' <seealso cref="SetToolTipHelp(Control, EventArgs)"/>
    Sub SetUpHoverHandler(control As Control)

        ' We add the handler
        AddHandler control.MouseEnter, AddressOf SetToolTipHelp
        AddHandler control.Enter, AddressOf SetToolTipHelp

        ' And the same for every sub control
        For Each con In control.Controls
            SetUpHoverHandler(con)
        Next

    End Sub

    ''' <summary>
    ''' Set the message in the botton right cornr of the app.
    ''' this corner is inteded tobe used for general purpose messages, warnings and jokes ^^
    ''' </summary>
    ''' <param name="msg">The new text of the generak message status</param>
    Sub SetStatusMessage(msg As String) Handles Me.NewStatusMessage, RoomManager1.NewStatusMessage
        GeneralStatusLabel.Text = msg
    End Sub

End Class


''' <summary>
''' This enumeration represents the possibilities for grouping students.
''' </summary>
<Flags()>
Public Enum GroupType
    None = 0
    Classe = 1
    Room = 2
    Subject = 4
    All = GroupType.Classe Or GroupType.Room Or GroupType.Subject
End Enum
