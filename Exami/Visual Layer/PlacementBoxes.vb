''' <summary>
''' This control is just a list of 
''' </summary>
Public Class PlacementBoxes

    Public Event NewStatusMessage(msg As String)
    Public boxes As New List(Of PlacementBox)

    Public Sub SetPlacements(placement As Placement)

        Controls.Clear()
        boxes.Clear()

        ' We dont want the boxes to small be if we can they should be all the same size and fill the container.
        Dim boxWidth = Math.Max(Me.Width / placement.subPlacements.Count - 3, 300)
        ' We progress from left to right increasing the x pos each times
        Dim curPosX = 0
        Dim box As PlacementBox = Nothing

        For Each subpla In placement.subPlacements
            box = New PlacementBox()

            With box
                .Location = New Point(curPosX, 0)
                .Size = New Size(boxWidth, Me.Height)
                .Title = subpla.name
                .Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Bottom
            End With
            Me.Controls.Add(box)
            Me.boxes.Add(box)
            box.SetContents(subpla)
            curPosX += boxWidth + 3  ' This is the offset between the boxes.

            AddHandler box.NeedSave, AddressOf Save
        Next

        ' The last one fills up space to the right in case the user makes a bigger window
        ' TODO: implement a resize function so they all always have the same size.
        box.Anchor = box.Anchor Or AnchorStyles.Right

    End Sub

    Private Sub Save(subplacement As SubPlacement)

        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            MP.SavePlacement(subplacement, SaveFileDialog1.FileName)
            RaiseEvent NewStatusMessage(String.Format("This part of the placement was saved at {0}", SaveFileDialog1.FileName))
        Else
            RaiseEvent NewStatusMessage("You canceled the saving.")
        End If

    End Sub

    Public Sub Print(sender As Object, e As Printing.PrintPageEventArgs)
        Static iSubPlacement = 0

        boxes(iSubPlacement).PrintPage(sender, e)
        If Not e.HasMorePages Then
            iSubPlacement += 1
            e.HasMorePages = True
        End If

        If iSubPlacement >= boxes.Count Then
            e.HasMorePages = False
            iSubPlacement = 0
        End If
    End Sub
End Class
