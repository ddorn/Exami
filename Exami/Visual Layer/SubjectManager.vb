Public Class SubjectManager

    Public Event NewStatusMessage(msg As String)

    ' Tutorial shown until somthing is selected
    Dim helperSubjectList = New String() {
            "Once you've selected a folder",
            "Convert the vass files",
            "By clicking 'Convert Files'",
            "Then select a subject",
            "And create a placement"
        }
    ''' <summary> 
    ''' The folder from where the subjects are shown
    ''' </summary>
    Dim folderPath As String

    ' Conversion between path and names

    Private Function SubjectToPath(subject As String) As String
        Return IO.Path.Combine(folderPath, subject + ".sv")
    End Function
    Private Function PathToSubject(path As String) As String
        Return IO.Path.GetFileNameWithoutExtension(path)
    End Function

    ' Update visible subjects

    ''' <summary>
    ''' Reload the folder to update the list of availaible subjects
    ''' </summary>
    Private Sub UpdateSubjectList()
        Dim thereIsSubjectsInTheFolder As Boolean = False
        Dim subjects As String() = helperSubjectList

        ' Getting the subjects or the tuto if there is not subjects or if the folder is empty

        If folderPath Is Nothing Or folderPath = "" Or Not IO.Directory.Exists(folderPath) Then
            ' The inital values are already whay we want
        Else
            subjects = File.GetFilesWithExtension(folderPath, ".sv")

            If subjects.GetUpperBound(0) > 0 Then
                ' We have a non empty subject list ! Cool
                thereIsSubjectsInTheFolder = True
            Else
                ' If it's empty we want our tuto back
                subjects = helperSubjectList
            End If
        End If

        ' Put subjects in the CheckedListBox

        SubjectListBox.BeginUpdate()
        SubjectListBox.Items.Clear()
        ' We add each file name (without folder/extension)
        For Each subject In subjects
            subject = PathToSubject(subject)
            SubjectListBox.Items.Add(subject)
        Next
        SubjectListBox.EndUpdate()

        ' Enable buttons depending on the existence of subjects

        SubjectListBox.Enabled = thereIsSubjectsInTheFolder

    End Sub

    ' ============== '
    ' Public methods ' 
    ' ============== '

    ''' <summary>
    ''' The SubjectManager will show the subjects of the given folder.
    ''' </summary>
    ''' <param name="path">The folder to get subjects from.</param>
    Public Sub SetFolder(path As String)

        If path Is Nothing Or path = "" Then
            Return
        End If

        ' We update the folder
        folderPath = path
        ' And then what we know about it
        UpdateSubjectList()
    End Sub

    ''' <summary>
    ''' Get a list of the file paths of the selected subjects. Thie list can be empty.
    ''' </summary>
    Public Function GetSelectedSubjectPaths() As List(Of String)
        Dim subjectPaths = New List(Of String)

        For Each item In SubjectListBox.CheckedItems
            subjectPaths.Add(SubjectToPath(item))
        Next

        Return subjectPaths
    End Function

    ''' <summary>
    ''' The number of checked subjects
    ''' </summary>
    Public Function CheckedNumber() As Integer
        Return SubjectListBox.CheckedIndices.Count
    End Function


End Class
