﻿Imports Exami

Public Class Exami2

    Public Event NewStatusMessage(msg As String)

    Public WorkingFolder As String
    Private _CurrentPlacement As Placement

    ''' <summary>
    ''' Update the current placement.
    ''' </summary>
    ''' <returns>The current displayed placement</returns>
    Public Property CurrentPLacement() As Placement
        Get
            Return _CurrentPlacement
        End Get
        Set(ByVal value As Placement)
            _CurrentPlacement = value
            PlacementBoxes1.SetPlacements(value, SexyViewOptionsSelector1.Options)
            SetUpHoverHandler(PlacementBoxes1)

            Dim ouatou = value IsNot Nothing

            AddStudentButton.Enabled = ouatou
            SexyViewOptionsSelector1.Enabled = ouatou
            SortOptions1.Enabled = ouatou
            PrintAllButton.Enabled = ouatou
            SaveAllButton.Enabled = ouatou
        End Set
    End Property

    ' Create room

    Private Sub CreateRoom() Handles RoomManager1.CreateRoom

        ' Just switch to the room designer form
        Me.Hide()
        RoomDesigner.Show()

    End Sub

    Private Sub ModifyRoom(roomPath As String) Handles RoomManager1.ModifyRoom
        Me.Hide()
        Dim room As Room
        If DD.TryLoadRoom(roomPath, room) Then
            RoomDesigner.SetRoom(room)
        End If
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
        SubjectTreeManager1.SetFolder(WorkingFolder)
    End Sub

    ''' <summary>
    ''' Converts the all the vass files in the workingFolder to sv ones. Informs the user of the succes of the operation
    ''' </summary>
    Private Sub ConvertFolder() Handles ReloadFolderButton.Click

        Dim info = ConvertFolder(WorkingFolder)  ' (converted, failed)

        ' Be kind, tell her what happend
        If info.Item1 = 0 And info.Item2 = 0 Then
            RaiseEvent NewStatusMessage("There is no files to convert in this folder :/")
        ElseIf info.Item2 = 0 Then

        Else
            RaiseEvent NewStatusMessage(String.Format("{} files where processed and {} failed", info.Item1, info.Item2))
        End If

        ' Show new files 
        ReloadWorkingFolder()

    End Sub

    Private Function ConvertFolder(folder As String) As Tuple(Of Integer, Integer)
        ' Keeping track of the number converted / failed
        Dim nbFilesConverted = 0
        Dim nbFilesFailed = 0

        ' We convert each .vass file in the folder
        For Each fileName In File.GetFilesWithExtension(folder, ".vass")
            If DataAccessLayer.SV.TryConvertVassToSv(fileName) Then
                nbFilesConverted += 1
            Else
                nbFilesFailed += 1
            End If
        Next

        ' The all .csv (for year 10/11)
        For Each filename In File.GetFilesWithExtension(folder, ".csv")
            If DataAccessLayer.SV.TryConvertCsvToSv(filename) Then
                nbFilesConverted += 1
            Else
                nbFilesFailed += 1
            End If
        Next

        ' And also each subfolder
        For Each fold In IO.Directory.GetDirectories(folder)
            Dim info = ConvertFolder(fold)
            nbFilesConverted += info.Item1
            nbFilesConverted += info.Item2
        Next

        Return New Tuple(Of Integer, Integer)(nbFilesConverted, nbFilesFailed)
    End Function

    ' ############## '
    '   Placement    '
    ' ############## '

    ' Enable MakePlacementButton when the selected stuff changes
    Private Sub EnablePlacementFromRoom(checkedCount As Integer) Handles RoomManager1.SelectionChanged
        ' When the user selects an item in the RoomManager that makes more than 0 items selected and there is some subject selected too
        ' Aka both have selected subject/room now
        If checkedCount > 0 And SubjectTreeManager1.CheckedCount > 0 Then
            MakePlacementButton.Enabled = True
        Else
            MakePlacementButton.Enabled = False
        End If

        CurrentPLacement = Nothing
    End Sub
    Private Sub EnablePlacementFromSubject(checkedCount As Integer) Handles SubjectTreeManager1.SelectionChanged
        If checkedCount > 0 And RoomManager1.CheckedCount > 0 Then
            MakePlacementButton.Enabled = True
        Else
            MakePlacementButton.Enabled = False
        End If
        CurrentPLacement = Nothing
    End Sub

    ''' <summary>
    ''' Actualise thePLacementBoxes given the current ViewBy and the current selected files.
    ''' </summary>
    Private Sub MakePlacement() Handles MakePlacementButton.Click, SortOptions1.SortChanged, SexyViewOptionsSelector1.OptionsChanged

        Dim Placement
        If CurrentPLacement Is Nothing Then
            Placement = New Placement(SubjectTreeManager1.GetSelectedSubjectPaths, RoomManager1.GetSelectedRoomPaths)
        Else
            Placement = CurrentPLacement.Reseted()
        End If


        If Not Placement.TryMakePlacement(SortOptions1.Sort, SortOptions1.GroupClasses, SortOptions1.Snake) Then
            MsgBox("There is more students than places !", MsgBoxStyle.Exclamation)
            RaiseEvent NewStatusMessage("There was more students than places, the placement aborted.")
            Return
        End If

        CurrentPLacement = Placement
    End Sub

    ' Save / Load

    Private Sub SaveAll() Handles SaveAllButton.Click

        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            MP.SavePlacement(Me.CurrentPLacement, SaveFileDialog1.FileName)
            RaiseEvent NewStatusMessage(String.Format("The placement was saved at {0}", SaveFileDialog1.FileName))
        Else
            RaiseEvent NewStatusMessage("You canceled the saving.")
        End If

    End Sub
    Private Sub OpenButton_Click() Handles OpenButton.Click
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            CurrentPLacement = MP.LoadPlacement(OpenFileDialog1.FileName)
            RaiseEvent NewStatusMessage("Placement loaded !")
        Else
            RaiseEvent NewStatusMessage("You canceled the operation. The placement isn't loaded.")
        End If
    End Sub

    ' ############## '
    ' Hover Tool Tip '
    ' ############## '

    Private Sub Exami2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'SexyViewOptionsSelector1.Tag = "Choose how you see the seating plan" + vbNewLine + "This doesn't change how the students are seated, only how you see them."
        For Each con In Controls
            ToolTip1.SetToolTip(con, con.tag)
        Next
        SetUpHoverHandler(Me)

        ' Default settings
        Me.FolderBrowserDialog1.SelectedPath = My.Settings.Datadir
        Me.OpenFileDialog1.FileName = My.Settings.SaveDir
        Me.SaveFileDialog1.FileName = My.Settings.SaveDir
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
        AddHandler control.Click, AddressOf SetToolTipHelp

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
    Sub SetStatusMessage(msg As String) Handles Me.NewStatusMessage, RoomManager1.NewStatusMessage, PlacementBoxes1.NewStatusMessage, SexyViewOptionsSelector1.NewStatusMsg
        GeneralStatusLabel.Text = msg
    End Sub

    ' ############## '
    '    Printing    '
    ' ############## '

    Private Sub PrintAll() Handles PrintAllButton.Click
        If PrintDialog1.ShowDialog() = DialogResult.OK Then
            PrintDocument1.Print()
        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Me.PlacementBoxes1.Print(sender, e)
    End Sub

    ' ############## '
    '  Other button  '
    ' ############## '

    Private Sub SettingsButton_Click(sender As Object, e As EventArgs) Handles SettingsButton.Click
        Settings.Show()
    End Sub

    Private Sub AddStudentButton_Click(sender As Object, e As EventArgs) Handles AddStudentButton.Click
        If CurrentPLacement Is Nothing Then
            MsgBox("You need to make a placement before adding students to it.")
            RaiseEvent NewStatusMessage("You need to make a placement before adding students to it.")
            Return
        End If

        AddStudentForm.SetPlacement(CurrentPLacement)
        If AddStudentForm.ShowDialog() = DialogResult.OK Then
            CurrentPLacement.students.allStudents.Add(AddStudentForm.GetStudent)
            MakePlacement()
        Else
            MsgBox("Canceled.")
            RaiseEvent NewStatusMessage("You canceled the new student.")
        End If
    End Sub

    ' ############## '
    '   Neighbours   '
    ' ############## '

    Private Sub PlacementBoxes1_StudentClick(student As Student) Handles PlacementBoxes1.StudentClick
        Dim neigh = New NeighboursForm()
        neigh.SetContent(student, CurrentPLacement)
        neigh.Show()
    End Sub

End Class


''' <summary>
''' This enumeration represents the possibilities for grouping students.
''' </summary>
<Flags()>
Public Enum GroupBy
    None = 0
    Classe = 1
    Room = 2
    Subject = 4
    All = GroupBy.Classe Or GroupBy.Room Or GroupBy.Subject
End Enum

''' <summary>
''' This enumeration represents the possibilities for sorting students.
''' </summary>
Public Enum SortBy
    Name
    Number
    Shuffle
End Enum


Public Enum SeeSortedBy
    Table
    Alpha
    Number
End Enum

Public Class PlacementViewOptions
    Public sortedBy = SeeSortedBy.Alpha
    Public showNumbers = True
    Public groupedBy = GroupBy.None

    Public Sub New(groupedBy As GroupBy, sortedBy As SeeSortedBy, showNumbers As Boolean)
        With Me
            .groupedBy = groupedBy
            .showNumbers = showNumbers
            .sortedBy = sortedBy
        End With
    End Sub
End Class