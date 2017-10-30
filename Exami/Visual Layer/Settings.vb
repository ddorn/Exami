Public Class Settings
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim webAddress As String = "https://www.icons8.com/"
        Process.Start(webAddress)
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Dim webAddress As String = "https://www.stackoverflow.com/"
        Process.Start(webAddress)
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        Dim webAddress As String = "https://www.github.com/ddorn/"
        Process.Start(webAddress)
    End Sub
End Class