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
    ' Folder  Select '
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
        ReloadWorkingFolderFolder()

    End Sub

    Public Sub ReloadWorkingFolderFolder()
        ' Update the class and rooms managers
        RoomManager1.SetFolder(WorkingFolder)
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
