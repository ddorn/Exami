''' <summary>
''' This control is intended to show AND modify a placement (or a part of), providing fuctions to save, print, shuffle and sort the students.
''' </summary>
Public Class PlacementBox

    Public group As StudentGroup
    Public Event NewMessage(msg As String)
    Public Event NeedSave(subplacement As StudentGroup)

    Enum SeeBy
        Table
        Alpha
        Number
    End Enum

    Private _currentSeeBy As SeeBy = SeeBy.Alpha
    Public Property CurrentSeeBy() As SeeBy
        Get
            Return _currentSeeBy
        End Get
        Set(ByVal value As SeeBy)
            _currentSeeBy = value

            If value = SeeBy.Alpha Then
                Me.AzSort()
                SeeByButton.BackgroundImage = My.Resources.sortAZ
            ElseIf value = SeeBy.Number Then
                Me.NumbSort()
                SeeByButton.BackgroundImage = My.Resources.sortNum
            Else
                Me.TableSort()
                SeeByButton.BackgroundImage = My.Resources.sorttable
            End If
        End Set
    End Property

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
    Public Sub SetContents(ByRef group As StudentGroup)
        Me.group = group

        ' And updat everything
        UpdateDisplay()
    End Sub

    ''' <summary>
    ''' This DOES a placement and show it to the screen.
    ''' </summary>
    Private Sub UpdateDisplay()
        ' Yep, the placement is done here...
        ' I kmow it is supposed to be only displaying but well
        ' It just associate places and students in the order, for option in the order, just suffle/order the two lists as you want

        PlacementTextBox.ResetText()

        For Each stud In group.allStudents

            ' The place then the name, aligned
            Dim line = stud.place.ToString & vbTab &
                stud.studentNumber & vbTab &
                stud.ToString()

            PlacementTextBox.AppendText(line)
            PlacementTextBox.AppendText(vbNewLine)  ' Only one line is a bit... stupid
        Next

    End Sub

    ' Help functions

    Private Function GetAllPlaces() As List(Of Place)
        Dim places = New List(Of Place)
        For Each stud In group.allStudents
            places.Add(stud.place)
        Next
        Return places
    End Function

    Private Sub SetAllPlaces(places As List(Of Place))
        For i = 0 To places.Count - 1
            group.allStudents(i).place = places(i)
            places(i).student = group.allStudents(i)
        Next
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

        Dim students = group.Copy()
        students.Sort()

        ' Print the placement
        For i = currentLine To Math.Min(currentLine + lines, Me.group.Count) - 1
            Dim ouatou = students.allStudents(i).place.ToString & vbTab & students.allStudents(i).ToString
            e.Graphics.DrawString(ouatou, font, Brushes.Black, New RectangleF(left, top + headerSize + font.Height * (i - currentLine), w, font.Height))
        Next

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
        If CurrentSeeBy = SeeBy.Alpha Then
            CurrentSeeBy = SeeBy.Number
        ElseIf CurrentSeeBy = SeeBy.Number Then
            CurrentSeeBy = SeeBy.Table
        Else
            CurrentSeeBy = SeeBy.Alpha
        End If
    End Sub
End Class
