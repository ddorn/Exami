﻿Public Class SubjectTreeManager

    Public Event NewStatusMessage(msg As String)
    Public Event SelectionChanged(selectedCount As Integer)

    ''' <summary> 
    ''' The root folder from where the subjects are shown
    ''' </summary>
    Private folderPath As String

    ' Update visible subjects

    ''' <summary>
    ''' Reload the folder to update the list of availaible subjects
    ''' </summary>
    Private Sub UpdateSubjectList()

        ' Getting the subjects

        If folderPath Is Nothing Or folderPath = "" Or Not IO.Directory.Exists(folderPath) Then
            ' Not good
            TreeView1.Nodes.Clear()
            Me.EmptyFolderLabel.Visible = True
        End If

        ' Put subjects in the CheckedListBox

        ' Begin and EndUpdate makes the box not flicker and update in one step instead of updating N+1 times.
        TreeView1.BeginUpdate()
        TreeView1.Nodes.Clear()
        ' We add each file name (without folder/extension)
        Dim root = TreeView1.Nodes.Add(IO.Path.GetFileName(folderPath))
        Dim qte = PopulateTreeView(Me.folderPath, root)
        root.Tag = folderPath

        ' Enable buttons depending on the existence of subjects

        If qte Then
            TreeView1.Enabled = True
            EmptyFolderLabel.Visible = False
            WarnImage.Visible = False
        Else
            TreeView1.Nodes.Clear()
            TreeView1.Enabled = False
            EmptyFolderLabel.Visible = True
            WarnImage.Visible = True
        End If

        TreeView1.EndUpdate()
        TreeView1.ExpandAll()
    End Sub

    ''' <summary>
    ''' Recursively add the .sv files in dir to the parentNode
    ''' </summary>
    ''' <param name="dir">Root directory to take the file </param>
    ''' <param name="parentNode">Node to  put the childs of dir</param>
    ''' <returns>The number of added .sv files.</returns>
    Private Function PopulateTreeView(dir As String, parentNode As TreeNode) As Integer
        Dim folder As String = String.Empty
        Dim recFilesCount = 0

        'Add folders to treeview
        Dim folders() As String = IO.Directory.GetDirectories(dir)
        If folders.Length <> 0 Then
            Dim folderNode As TreeNode = Nothing
            Dim folderName As String = String.Empty

            For Each folder In folders
                folderName = IO.Path.GetFileName(folder)
                folderNode = parentNode.Nodes.Add(folderName)
                folderNode.Tag = folder
                Dim subFilesCount = PopulateTreeView(folder, folderNode)
                recFilesCount += subFilesCount
                If subFilesCount = 0 Then
                    ' Remove the node just added (last one)
                    parentNode.Nodes.RemoveAt(parentNode.Nodes.Count - 1)
                End If
            Next
        End If

        'Add the files to treeview
        Dim files() As String = File.GetFilesWithExtension(dir, ".sv")
        If files.Length <> 0 Then
            Dim fileNode As TreeNode = Nothing
            For Each file As String In files
                fileNode = parentNode.Nodes.Add(IO.Path.GetFileNameWithoutExtension(file))
                fileNode.Tag = file
            Next
        End If

        Return recFilesCount + files.Length
    End Function

    ''' <summary>
    ''' Set and reload the folder from which the subjects are shown.
    ''' </summary>
    ''' <param name="path"></param>
    Friend Sub SetFolder(path As String)
        Me.folderPath = path
        Me.UpdateSubjectList()
    End Sub

    ''' <summary>
    ''' Get an array of the file paths to the checked subjects
    ''' </summary>
    Public Function GetSelectedSubjectPaths() As String()

        Return _GetCheckedNodes(TreeView1.Nodes(0)).ToArray
    End Function

    ''' <summary>
    ''' Recursively get the checked subjects path from a node.
    ''' </summary>
    ''' <param name="node">Origin node to get paths from.</param>
    ''' <returns>A list of paths to the checked subjects.</returns>
    Private Function _GetCheckedNodes(node As TreeNode) As List(Of String)
        If node.GetNodeCount(False) = 0 And node.Checked Then
            Return New List(Of String)({CType(node.Tag, String)})
        End If

        Dim checked = New List(Of String)

        For Each n In node.Nodes
            checked.AddRange(_GetCheckedNodes(n))
        Next

        Return checked
    End Function

    ''' <summary>
    ''' Number of checked subjects.
    ''' </summary>
    ''' <returns></returns>
    Public Function CheckedCount() As Integer
        Return GetSelectedSubjectPaths.Count
    End Function

    Private Sub TreeView1_AfterCheck() Handles TreeView1.AfterCheck
        RaiseEvent SelectionChanged(GetSelectedSubjectPaths.Count)
    End Sub

    Private Sub TreeView1_AfterCheck(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterCheck

    End Sub
End Class
