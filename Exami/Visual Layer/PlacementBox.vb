''' <summary>
''' This control is intended to show AND modify a placement (or a part of), providing fuctions to save, print, shuffle and sort the students.
''' </summary>
Public Class PlacementBox

    Public group As StudentGroup
    Public Event NewMessage(msg As String)
    Public Event NeedSave(subplacement As StudentGroup)

    Public Property CurrentSeeBy() As SeeSortedBy
        Get
            Return options.sortedBy
        End Get
        Set(ByVal value As SeeSortedBy)
            options.sortedBy = value

            If value = SeeSortedBy.Alpha Then
                Me.AzSort()
                SeeByButton.BackgroundImage = My.Resources.sortAZ
            ElseIf value = SeeSortedBy.Number Then
                Me.NumbSort()
                SeeByButton.BackgroundImage = My.Resources.sortNum
            Else
                Me.TableSort()
                SeeByButton.BackgroundImage = My.Resources.sorttable
            End If
        End Set
    End Property

    Private options As PlacementViewOptions

    ' Title

    ''' <summary>
    ''' The title that is shown in bold underline of the box.
    ''' 
    ''' If there is some " - " in it, they will be converted in new lines. This is how Placement.GetNameAs is done.
    ''' </summary>
    Public Property Title() As String
        Get
            Return TitleLabel.Text
        End Get
        Set(ByVal value As String)
            value = value.Replace(" - ", vbNewLine)
            TitleLabel.Text = value
            Invalidate()
        End Set
    End Property

    '  Contents set and show

    ''' <summary>
    ''' Set the places and students of the box.
    ''' This actualize the screen.
    ''' </summary>
    ''' <param name="group">The group of students to show in this box</param>
    Public Sub SetContents(ByRef group As StudentGroup, options As PlacementViewOptions)
        Me.group = group
        Me.options = options
        Me.CurrentSeeBy = options.sortedBy
        ' And updat everything
        UpdateDisplay()
    End Sub

    Private Sub UpdateDisplay()

        ListView1.BeginUpdate()
        ListView1.SuspendLayout()

        ListView1.Clear()

        For Each stud In group.allStudents
            Dim item = ListView1.Items.Add(stud.place.ToString)
            If options.showNumbers Then
                item.SubItems.Add(stud.studentNumber)
            End If
            item.SubItems.Add(stud.ToString)
        Next
        ' Creating the columns
        ' TODO: addhandler for click to sort them
        ListView1.Columns.Add("Place", -2).Tag = SeeSortedBy.Table
        If options.showNumbers Then
            ListView1.Columns.Add("Student number", -2).Tag = SeeSortedBy.Number
        End If
        ListView1.Columns.Add("Name", -2).Tag = SeeSortedBy.Alpha

        ListView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)
        ListView1.ResumeLayout()
        ListView1.EndUpdate()
    End Sub

    ' Print

    Private Sub PrintButton_Click(sender As Object, e As EventArgs) Handles PrintButton.Click

        If PrintDialog1.ShowDialog() = DialogResult.OK Then
            PrintDocument1.Print()
        End If

    End Sub

    Public Sub PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Static currentLine = 0

        Dim bigfont = New Font("segoe ui black", 14)
        Dim font = New Font("segoe ui", 11)

        Dim h, w As Integer
        Dim left, top As Integer
        With PrintDocument1.DefaultPageSettings
            h = .PaperSize.Height - .Margins.Top - .Margins.Bottom
            w = .PaperSize.Width - .Margins.Left - .Margins.Right
            left = 0
            top = 0
        End With

        If PrintDocument1.DefaultPageSettings.Landscape Then
            Dim a As Integer
            a = h
            h = w
            w = a
        End If


        ' Print the header
        Dim headerlines = TitleLabel.Lines.Count
        Dim headerSize = headerlines * bigfont.Height + 20
        For i = 0 To headerlines - 1
            Dim size = e.Graphics.MeasureString(TitleLabel.Lines(i), bigfont)
            e.Graphics.DrawString(TitleLabel.Lines(i), bigfont, Brushes.Black, left + (w - size.Width) / 2, top + bigfont.Height * i)
        Next

        Dim lines As Integer = CInt(Math.Round((h - headerSize) / font.Height))

        Dim columnOrder(ListView1.Columns.Count - 1) As Byte
        For Each col As ColumnHeader In ListView1.Columns
            columnOrder(col.DisplayIndex) = col.Index
        Next

        Dim colSizes(columnOrder.Count - 1) As Integer  ' In display order
        ' Finding the sizes of columns (max of each item)
        For Each item As ListViewItem In ListView1.Items
            For col = 0 To columnOrder.Count - 1
                Dim size = e.Graphics.MeasureString(item.SubItems(col).Text + "  ", font).Width
                If colSizes(col) < size Then
                    colSizes(col) = size
                End If
            Next
        Next

        ' Find the position of each colum
        Dim colPositions(columnOrder.Count - 1) As Integer
        Dim pos = 0
        For Each col In columnOrder
            colPositions(col) = pos
            pos += colSizes(col)
        Next

        For i = currentLine To Math.Min(currentLine + lines, Me.group.Count) - 1
            Dim ouatou As ListViewItem = Me.ListView1.Items(i)

            For Each col In columnOrder
                e.Graphics.DrawString(ouatou.SubItems(col).Text, font, Brushes.Black, New RectangleF(left + colPositions(col), top + headerSize + font.Height * (i - currentLine), w, font.Height))
            Next col
        Next i

        currentLine += lines

        If currentLine >= Me.group.Count Then
            e.HasMorePages = False
            currentLine = 0
        Else
            e.HasMorePages = True
        End If

    End Sub

    ' Buttons

    ''' <summary>
    ''' Shuffle the places and keep the students in the same order. Thus They are at a random place now.
    ''' Updates the screen.
    ''' </summary>
    Private Sub TableSort()
        group.allStudents.Sort(New Comparison(Of Student)(Function(s1, s2)
                                                              Return s1.place.CompareTo(s2.place)
                                                          End Function))
        UpdateDisplay()
    End Sub
    ''' <summary>
    ''' Sort the places and leave the students as they are so they are by alphabetical order now.
    ''' Updates the screen.
    ''' </summary>
    Private Sub AzSort()
        group.Sort()
        UpdateDisplay()
    End Sub
    ''' <summary>
    ''' Sort the places by student number and leave the students as they are so they are by alphabetical order now.
    ''' Updates the screen.
    ''' </summary>
    Private Sub NumbSort()
        ' We sort the students by number 
        group.SortByNum()
        UpdateDisplay()
    End Sub

    Private Sub SeeByButton_Click() Handles SeeByButton.Click
        If CurrentSeeBy = SeeSortedBy.Alpha Then
            CurrentSeeBy = SeeSortedBy.Number
        ElseIf CurrentSeeBy = SeeSortedBy.Number Then
            CurrentSeeBy = SeeSortedBy.Table
        Else
            CurrentSeeBy = SeeSortedBy.Alpha
        End If
    End Sub

    Private Sub ListView1_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles ListView1.ColumnClick
        CurrentSeeBy = ListView1.Columns(e.Column).Tag  ' Tag is the way to sort it, see UpdateDisplay.
    End Sub
End Class
