Module Helper
    Sub Shuffle(Of T)(ByRef A() As T)
        Dim last As Integer = A.Length - 1
        Dim B(last) As T
        Dim done(last) As Boolean
        Dim r As New Random(My.Computer.Clock.TickCount)
        Dim n As Integer
        For i As Integer = 0 To last
            Do
                n = r.Next(last + 1)
            Loop Until Not done(n)
            done(n) = True
            B(i) = A(n)
        Next
        A = B
    End Sub

    Sub Shuffle(Of T)(ByRef A As List(Of T))
        Dim array = A.ToArray
        Shuffle(Of T)(array)
        A = array.ToList
    End Sub
End Module
