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

        ' We automatically convert the folder every time
        ' On click less for this user that will do that automatically
        ' And more room in the screen for other buttons
        ConvertFolder()
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
    Private Sub ConvertFolder() Handles ReloadFolderButton.Click
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
            RaiseEvent NewStatusMessage("There is no files to convert in this folder :/")
        ElseIf nbFilesFailed = 0 Then

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
        If checkedCount > 0 And SubjectManager1.CheckedCount > 0 Then
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

        Dim placement = New Placement(RoomManager1.GetSelectedRoomPaths, SubjectManager1.GetSelectedSubjectPaths)
        placement.MakePlacement(PlacementViewBySelector1.CurrentViewBy)

        PlacementBoxes1.SetPlacements(placement)

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
