''' <summary>
''' This control is just a list of 
''' </summary>
Public Class PlacementBoxes

    Public Event NewMessage(nsg As String)

    ''' <summary>
    ''' Creates a PlacementBox for each keys of the two dictionnaries.
    ''' </summary>
    ''' <param name="students">A dictionnary of the names of the Boxes as key and a student group as key. The Keys must be the same as the <paramref name="places"/>...
    ''' and the number of students by student group se same as the corresponding list of places.</param>
    ''' <param name="places">A dictionnary with the exact same structure as <paramref name="students"/>.</param>
    Public Sub SetPlacements(students As Dictionary(Of String, StudentGroup), places As Dictionary(Of String, List(Of Place)))

        Controls.Clear()

        If students.Count <> places.Count Or students.Count = 0 Then
            RaiseEvent NewMessage("Wow, there a problem... Check PlacementBoxes.SetPlacements...")
            Return
        End If

        Dim boxWidth = Math.Max(Me.Width / students.Count - 3, 300)
        Dim curPosX = 0
        Dim box As PlacementBox = Nothing

        For Each boxName In students.Keys
            box = New PlacementBox()

            With box
                .Location = New Point(curPosX, 0)
                .Size = New Size(boxWidth, Me.Height)
                .Title = boxName
                .Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Bottom
            End With

            Me.Controls.Add(box)
            box.SetContents(students(boxName), places(boxName))

            curPosX += boxWidth + 3
        Next

        box.Anchor = box.Anchor Or AnchorStyles.Right

    End Sub

End Class
