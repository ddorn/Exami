Imports System.ComponentModel

Public Class PlacementBox

    Public Property Title() As String
        Get
            Return NameLabel.Text
        End Get
        Set(ByVal value As String)
            NameLabel.Text = value
            Invalidate()
        End Set
    End Property

End Class
