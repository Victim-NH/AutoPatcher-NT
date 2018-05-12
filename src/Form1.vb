


Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Check Version.txt Local and Download
        If My.Computer.FileSystem.FileExists("Version.txt") Then

        Else

            My.Computer.Network.DownloadFile("http://YOUR LINK/patch/Version.txt", "Version.txt")
            
        End If
        'Check Launcher.exe Local and Download
        If My.Computer.FileSystem.FileExists("YOUR LAUNCHER.exe") Then

        Else
            My.Computer.Network.DownloadFile("http://YOUR LINK/patch/YOUR LAUNCHER.exe", "YOUR LAUNCHER.exe")

        End If
    End Sub

    Private Sub START_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Disable double pression button.
        Button1.Enabled = False
        'Check Version.txt Online and Local.
        Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("http://YOUR LINK/Version.txt")
        Dim response As System.Net.HttpWebResponse = request.GetResponse()

        Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())

        Dim newestversion As String = sr.ReadToEnd()
        Dim currentversion As String = My.Computer.FileSystem.ReadAllText("Version.txt")



        If newestversion.Contains(currentversion) Then
            MessageBox.Show("You have the current version")
            Process.Start("YOURLAUNCHER.EXE")
            End

        Else
            MessageBox.Show("Newer version is avaible")
            If My.Computer.FileSystem.FileExists("Version.txt") Then My.Computer.FileSystem.DeleteFile("Version.txt")
        My.Computer.Network.DownloadFile("https://YOUR LINK/patch/Version.txt", "Version.txt")

        End If
    End Sub

    Private Sub DISCORD_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Process.Start("https://LINK DISCORD")
    End Sub

    Private Sub WEBSITE_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Process.Start("https://LINK WEBSITE")
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

    End Sub

    Private Sub EXIT_Click(sender As Object, e As EventArgs) Handles Button4.Click
    Application.Exit()
    End Sub
End Class
