Public Class Exami2

    Public Event CreateRoomEvent()
    Public Event DeleteRoomEvent()
    Public Event PrintAllEvent()
    Public Event SaveAllEvent()
    Public Event MakePlacementEvent()
    Public Event FolderSelected(path As String)
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

    Public Sub ReloadWorkingFolder()

        ' Update the class and rooms managers
        RoomManager1.SetFolder(WorkingFolder)
        SubjectManager1.SetFolder(WorkingFolder)

    End Sub

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
        If nbFilesConverted = 0 Then
            RaiseEvent NewStatusMessage("There is no .vass files to convert in this folder :/")
        ElseIf nbFilesFailed = 0 Then
            RaiseEvent NewStatusMessage("All data processed")
        Else
            MsgBox(String.Format("{} files where processed but {} failed", nbFilesConverted, nbFilesFailed))
        End If

        ' Show new files 
        ReloadWorkingFolder()

    End Sub


    ' ############## '
    '   Placement    '
    ' ############## '

    ' Enable MakePlacementButton when the selected stuff changes
    Private Sub EnablePlacementFromRoom(checkedCount As Integer) Handles RoomManager1.SelectionChanged
        If checkedCount > 0 And SubjectManager1.CheckedNumber > 0 Then
            MakePlacementButton.Enabled = True
        Else
            MakePlacementButton.Enabled = False
        End If
    End Sub
    Private Sub EnablePlacementFromSubject(checkedCount As Integer) Handles SubjectManager1.SelectionChanged
        If checkedCount > 0 And RoomManager1.CheckedNumber > 0 Then
            MakePlacementButton.Enabled = True
        Else
            MakePlacementButton.Enabled = False
        End If
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
    Private Sub SetToolTipHelp(sender As Object, e As EventArgs)
        Dim control = CType(sender, Control)
        If control.Tag <> "" Then
            HoverStatusLabel.Text = control.Tag
        End If
    End Sub

    ''' <summary>
    ''' Recursively add handler for when the mouse passes over a control to SetToolTipHelp.
    ''' </summary>
    ''' <param name="control">The control to add to the ToolTipHelp</param>
    ''' <seealso cref="SetToolTipHelp(Object, EventArgs)"/>
    Sub SetUpHoverHandler(control As Control)
        AddHandler control.MouseEnter, AddressOf SetToolTipHelp
        AddHandler control.Enter, AddressOf SetToolTipHelp

        For Each con In control.Controls
            SetUpHoverHandler(con)
        Next
    End Sub

    ''' <summary>
    ''' Set the message in the botton right cornr of the app.
    ''' this corner is inteded tobe used for general purpose messages, warnings and jokes ^^
    ''' </summary>
    ''' <param name="msg"></param>
    Sub SetStatusMessage(msg As String) Handles Me.NewStatusMessage, RoomManager1.NewStatusMessage
        GeneralStatusLabel.Text = msg
    End Sub

End Class
