''' <summary>
''' This control is just a container for a list of PlacementBox
''' </summary>
Public Class PlacementBoxes

    Public Event NewStatusMessage(msg As String)
    Public Event StudentClick(student As Student)

    Public boxes As New List(Of PlacementBox)
    Private _doPaint = True

    ''' <summary>
    ''' Removes every PlacementBox and create new ones with the students of placement separated by view
    ''' </summary>
    ''' <param name="placement">The students, seated. If Nothing, will just remove everything.</param>
    Public Sub SetPlacements(placement As Placement, options As PlacementViewOptions)

        BeginUpdate()

        Controls.Clear()
        boxes.Clear()

        If placement Is Nothing Then
            ' We just clear everything
            Return
        End If

        Dim groups = placement.students.Separate(options.groupedBy)

        For Each group In groups

            Dim box = New PlacementBox()
            With box
                .Title = group.GetNameAs(options.groupedBy)
                .Anchor = AnchorStyles.Top Or AnchorStyles.Left
                .SetContents(group, options)
            End With

            Me.Controls.Add(box)
            Me.boxes.Add(box)

            AddHandler box.ColumnReorder, AddressOf ReorderAllColumns
            AddHandler box.ItemClick, AddressOf BoxItemClick_Handler

        Next

        ' Set all the positions and sizes
        Me.PlacementBoxes_Resize()

        EndUpdate()

    End Sub

    Public Sub Print(sender As Object, e As Printing.PrintPageEventArgs)
        Static iSubPlacement = 0

        boxes(iSubPlacement).PrintPage(sender, e)
        If Not e.HasMorePages Then
            iSubPlacement += 1
            e.HasMorePages = True
        End If

        If iSubPlacement >= boxes.Count Then
            ' We reset everything at the end.
            e.HasMorePages = False
            iSubPlacement = 0
        End If
    End Sub

    Private Sub PlacementBoxes_Resize() Handles Me.Resize

        If boxes Is Nothing Or boxes.Count = 0 Then
            Return
        End If

        ' Adapt the size if there is a scrollbar 
        Dim Par = CType(Parent, Panel)
        If Par.HorizontalScroll.Visible Then
            Me.Height = Me.Parent.Height - SystemInformation.HorizontalScrollBarHeight
        Else
            Me.Height = Me.Parent.Height
        End If

        Me.Width = Math.Max(350 * boxes.Count, Parent.Width)

        ' We dont want the boxes to small be if we can they should be all the same size and fill the container.
        Dim boxWidth = Me.Width \ boxes.Count - 3

        ' We progress from left to right increasing the x pos each times
        Dim curPosX = 0

        For Each box In boxes
            box.Location = New Point(curPosX, 0)
            box.Size = New Size(boxWidth, Me.Height)
            curPosX += boxWidth + 3
        Next
    End Sub

    Private Sub ReorderAllColumns(sender As PlacementBox, oldIndex As Integer, newIndex As Integer)
        For Each con As PlacementBox In Controls
            If con Is sender Then
                Continue For
            End If

            con.ReorderColumns(oldIndex, newIndex)
        Next

    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        If _doPaint Then
            MyBase.OnPaint(e)
        End If
    End Sub

    Public Sub BeginUpdate()
        _doPaint = False
        SuspendLayout()
    End Sub

    Public Sub EndUpdate()
        _doPaint = True
        ResumeLayout()
    End Sub

    Protected Sub BoxItemClick_Handler(student As Student)
        RaiseEvent StudentClick(student)
    End Sub

End Class
