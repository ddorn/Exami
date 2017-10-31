''' <summary>
''' This control is intended to show AND modify a placement (or a part of), providing fuctions to save, print, shuffle and sort the students.
''' </summary>
Public Class PlacementBox

    Public group As StudentGroup
    Public Event NewMessage(msg As String)
    Public Event NeedSave(subplacement As StudentGroup)

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

        ' Enable the options
        AzButton.Enabled = True
        ShuffleButton.Enabled = True
        SortNumberButton.Enabled = True

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


    ' Buttons

    ''' <summary>
    ''' Shuffle the places and keep the students in the same order. Thus They are at a random place now.
    ''' Updates the screen.
    ''' </summary>
    Private Sub Shuffle() Handles ShuffleButton.Click
        ' We sort the students by name 
        group.Sort()
        ' Extract the places
        Dim places = GetAllPlaces()
        ' Shuffle them
        Helper.Shuffle(places)
        ' And put them back
        SetAllPlaces(places)
        ' And actualize everything
        UpdateDisplay()
    End Sub
    ''' <summary>
    ''' Sort the places and leave the students as they are so they are by alphabetical order now.
    ''' Updates the screen.
    ''' </summary>
    Private Sub AzButton_Click() Handles AzButton.Click
        ' We sort the students by name 
        group.Sort()
        ' Extract the places
        Dim places = GetAllPlaces()
        ' Sort them too
        places.Sort()
        ' And put them back
        SetAllPlaces(places)
        ' And actualize everything
        UpdateDisplay()
    End Sub
    ''' <summary>
    ''' Sort the places by student number and leave the students as they are so they are by alphabetical order now.
    ''' Updates the screen.
    ''' </summary>
    Private Sub SortNumberButton_Click(sender As Object, e As EventArgs) Handles SortNumberButton.Click
        'Me.subPlacement.places.Sort()
        ' We set the students of each place so we can know wich one it is during the sort
        'For i = 0 To Me.subPlacement.places.Count - 1
        '    Me.subPlacement.places(i).student = Me.subPlacement.students.allStudents(i)
        'Next

        'Me.subPlacement.places.Sort(New Comparison(Of Place)(Function(p1 As Place, p2 As Place)
        '                                                         Dim s1Number = Integer.Parse(p1.student.studentNumber.Substring(0, 8))
        '                                                         Dim s2Number = Integer.Parse(p2.student.studentNumber.Substring(0, 8))
        '                                                         Return s1Number.CompareTo(s2Number)
        '                                                     End Function))
        ' We sort the students by number 
        group.SortByNum()
        ' Extract the places
        Dim places = GetAllPlaces()
        ' sort them too 
        places.Sort()
        ' And put them back
        SetAllPlaces(places)
        ' And actualize everything
        UpdateDisplay()
    End Sub

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


End Class
