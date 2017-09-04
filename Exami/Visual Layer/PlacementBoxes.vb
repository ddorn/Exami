Public Class PlacementBoxes

    Private PlacementBoxList As List(Of PlacementBox) = New List(Of PlacementBox)

    Public Sub SetPlacements(students As Dictionary(Of String, StudentGroup), places As Dictionary(Of String, List(Of Place)))

        Controls.Clear()

        Dim boxWidth = Me.Width / students.Count - 3
        Dim curPosX = 0
        Dim box As PlacementBox

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
