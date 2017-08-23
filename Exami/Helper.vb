Module Helper
    Sub Shuffle(Of T)(ByRef A() As T)
        Dim last As Integer = A.Length - 1
        Dim B(last) As T
        Dim done(last) As Byte
        Dim r As New Random(My.Computer.Clock.TickCount)
        Dim n As Integer
        For i As Integer = 0 To last
            Do
                n = r.Next(last + 1)
            Loop Until Not done(n)
            done(n) = 1
            B(i) = A(n)
        Next
        A = B
    End Sub
End Module
