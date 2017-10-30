''' <summary>
''' This control is intended to show AND modify a placement (or a part of), providing fuctions to save, print, shuffle and sort the students.
''' </summary>
Public Class PlacementBox

    Public subPlacement As SubPlacement
    Public Event NewMessage(msg As String)
    Public Event NeedSave(subplacement As SubPlacement)

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
    ''' <summary>
    ''' Update the name of the subplacement when the title is changed (usually by the user)
    ''' </summary>
    Private Sub TitleLabel_TextChanged() Handles TitleLabel.TextChanged
        ' Avoid nullReferenceException
        If TitleLabel.Text Is Nothing Or Me.subPlacement Is Nothing Then
            Return
        End If
        Me.subPlacement.name = TitleLabel.Text.Replace(vbNewLine, " - ")
    End Sub

    '  Contents set and show

    ''' <summary>
    ''' Set the places and students of the box.
    ''' This actualize the screen.
    ''' </summary>
    ''' <param name="subplacement">The subplacement to show in this box</param>
    Public Sub SetContents(ByRef subplacement As SubPlacement)
        Me.subPlacement = subplacement
        Me.subPlacement.students.Sort()

        ' Enable the options
        AzButton.Enabled = True
        ShuffleButton.Enabled = True
        SaveButton.Enabled = True
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

        For pos = 0 To subPlacement.students.Count - 1
            ' We set the place of the student... in case of
            subPlacement.students.allStudents(pos).place = subPlacement.places(pos)

            ' The place then the name, aligned
            Dim line = subPlacement.places(pos).ToString & vbTab &
                subPlacement.students.allStudents(pos).studentNumber & vbTab &
                subPlacement.students.allStudents(pos).ToString()

            PlacementTextBox.AppendText(line)
            PlacementTextBox.AppendText(vbNewLine)  ' Only one line is a bit... stupid
        Next

    End Sub

    ' Buttons

    ''' <summary>
    ''' Shuffle the places and keep the students in the same order. Thus They are at a random place now.
    ''' Updates the screen.
    ''' </summary>
    Private Sub Shuffle() Handles ShuffleButton.Click
        Helper.Shuffle(Of Place)(subPlacement.places)
        UpdateDisplay()
    End Sub
    ''' <summary>
    ''' Sort the places and leave the students as they are so they are by alphabetical order now.
    ''' Updates the screen.
    ''' </summary>
    Private Sub AzButton_Click() Handles AzButton.Click
        subPlacement.places.Sort()
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
        Me.subPlacement.places.Sort()
        Me.subPlacement.students.allStudents.Sort(New Comparison(Of Student)(Function(s1, s2)
                                                                                 Return s1.studentNumber.CompareTo(s2.studentNumber)
                                                                             End Function))
        UpdateDisplay()
    End Sub

    ''' <summary>
    ''' The Save occurs in PlacementBoxes
    ''' </summary>
    Private Sub SaveButton_Click() Handles SaveButton.Click

        RaiseEvent NeedSave(Me.subPlacement)

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

        ' Print the placement
        For i = currentLine To Math.Min(currentLine + lines, Me.subPlacement.students.Count) - 1
            e.Graphics.DrawString(Me.PlacementTextBox.Lines(i), font, Brushes.Black, New RectangleF(left, top + headerSize + font.Height * (i - currentLine), w, font.Height))
        Next

        currentLine += lines

        If currentLine >= Me.subPlacement.students.Count Then
            e.HasMorePages = False
            currentLine = 0
        Else
            e.HasMorePages = True
        End If

    End Sub


End Class
