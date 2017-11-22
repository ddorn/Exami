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

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        Dim webAddress As String = "http://www.koonung.vic.edu.au/"
        Process.Start(webAddress)
    End Sub

    Private Sub ChooseDataDirButton_Click(sender As Object, e As EventArgs) Handles ChooseDataDirButton.Click
        FolderBrowserDialog1.SelectedPath = Nothing
        If FolderBrowserDialog1.ShowDialog = DialogResult.OK Then
            DataDirLabel.Text = FolderBrowserDialog1.SelectedPath
            My.Settings.Datadir = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataDirLabel.Text = My.Settings.Datadir
        SaveDirLabel.Text = My.Settings.SaveDir
    End Sub

    Private Sub ChooseSaveDirButton_Click(sender As Object, e As EventArgs) Handles ChooseSaveDirButton.Click
        FolderBrowserDialog1.SelectedPath = Nothing
        If FolderBrowserDialog1.ShowDialog = DialogResult.OK Then
            SaveDirLabel.Text = FolderBrowserDialog1.SelectedPath
            My.Settings.SaveDir = FolderBrowserDialog1.SelectedPath
        End If
        VersionLabel.Text = My.Settings.Version
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Dim webAddress As String = "http://www.mms.com/Resources/img/characters/yellow/character.jpg"
        Process.Start(webAddress)
    End Sub
End Class