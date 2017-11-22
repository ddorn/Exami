Public Class NeighboursForm
    Protected placement As Placement
    Protected student As Student

    Public students(9) As Student  ' student(3 * row + col)

    Public Sub SetContent(student As Student, placement As Placement)
        Me.placement = placement
        Me.student = student

        For i = 0 To 9
            students(i) = Nothing  ' cleearing
        Next

        Dim firstCol As Integer = student.place.col - 1
        Dim firstRow As Integer = student.place.row - 1

        ' We set the tag of each button to their place (it it exists, ese Nothing)
        For col = 0 To 2
            For row = 0 To 2
                If row + firstRow < 0 Or row + firstRow > 255 Or col + firstCol < 0 Or col + firstCol > 255 Then
                    buttons(3 * row + col).Tag = Nothing
                Else
                    buttons(3 * row + col).Tag = New Place(row + firstRow, col + firstCol, student.place.room)
                End If
            Next
        Next

        ' Then for each place we put the student seating there int the student array
        Dim sameRoomStudents = placement.students.GetStudentsByRoom()(student.place.room).allStudents
        For Each stud In sameRoomStudents
            For row = 0 To 2
                For col = 0 To 2
                    Dim pos = 3 * row + col
                    If buttons(pos).Tag Is Nothing Then
                        ' nothing to do
                    ElseIf stud.place.CompareTo(buttons(pos).Tag) = 0 Then
                        students(pos) = stud
                    End If
                Next
            Next
        Next

        ' And we set the text of each button to its students name
        For row = 0 To 2
            For col = 0 To 2
                Dim pos = 3 * row + col
                If students(pos) Is Nothing Then
                    buttons(pos).Visible = False
                    buttons(pos).Tag = Nothing
                Else
                    buttons(pos).Visible = True
                    buttons(pos).Text = students(pos).place.ToString + vbNewLine + students(pos).ToString
                    buttons(pos).Tag = students(pos)
                End If
            Next
        Next

        ' set labels
        For col = 0 To 2
            If col + firstCol < 0 Or col + firstCol > 255 Then
                ColumnLabels(col).Text = "-"
            Else
                ColumnLabels(col).Text = (col + firstCol + 1).ToString
            End If
        Next

        For row = 0 To 2
            If row + firstRow < 0 Or row + firstRow > 26 Then
                RowLabels(row).Text = "-"
            Else
                RowLabels(row).Text = Chr(65 + row + firstRow)
            End If
        Next

    End Sub

    Private Sub Button_Click(sender As Button, e As EventArgs) Handles Button1A.Click, Button1B.Click, Button1C.Click, Button2A.Click, Button2B.Click, Button2C.Click, Button3A.Click, Button3B.Click, Button3C.Click
        Me.SetContent(sender.Tag, Me.placement)
    End Sub

    Public ReadOnly Property Buttons() As Button()
        Get
            Return {
            Button1A, Button2A, Button3A,
            Button1B, Button2B, Button3B,
            Button1C, Button2C, Button3C
        }
        End Get
    End Property

    Public ReadOnly Property ColumnLabels As Label()
        Get
            Return {Col1Label, Col2Label, Col3Label}
        End Get
    End Property

    Public ReadOnly Property RowLabels As Label()
        Get
            Return {Row1Label, Row2Label, Row3Label}
        End Get
    End Property
End Class