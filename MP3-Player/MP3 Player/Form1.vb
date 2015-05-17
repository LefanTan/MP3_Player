Public Class Form1

    'Declare External Variables'
    Dim r As New Random
    Dim tempInt As Integer
    Dim currentTrack As Integer = 0
    Dim currentSong As String = Nothing
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButFolder.Click
        'Show Browser Url in Textbox- txtfolder'
        If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
            txtfolder.Text = FolderBrowserDialog1.SelectedPath.ToString 'convert to string'
        End If

    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles ButClose.Click
        'minimize program to taskbar'
        Me.Visible = False
    End Sub

    Private Sub ListBox1_DoubleClick(sender As Object, e As EventArgs) Handles ListBox1.DoubleClick
        'Play song when double clicked'
        RichTextBox1.Clear()
        currentSong = ListBox1.Text
        wpm.URL = currentSong

        Dim curSongPlayin As String = System.IO.Path.GetFileName(currentSong)
        Dim textPlay As String = "Song playing:" & System.Environment.NewLine & curSongPlayin
        RichTextBox1.AppendText(textPlay)
    End Sub
    Private Sub txtfolder_TextChanged(sender As Object, e As EventArgs) Handles txtfolder.TextChanged

        ListBox1.Items.Clear()


        Dim pathName As String = FolderBrowserDialog1.SelectedPath.ToString
        If Not txtfolder.Text = "" Then
            For Each item As String In My.Computer.FileSystem.GetFiles(txtfolder.Text, Microsoft.VisualBasic.FileIO.SearchOption.SearchTopLevelOnly, "*.mp3")
                ListBox1.Items.Add(item) 'add items to listbox'
            Next


        End If

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click

        RichTextBox1.Clear()
        'Enable program to open a single song'


        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            currentSong = OpenFileDialog1.FileName.ToString
            ListBox1.Items.Add(currentSong)
        End If

        If Not currentSong = "" Then
            wpm.URL = currentSong
        End If

        Dim curSongOpen As String = System.IO.Path.GetFileName(currentSong)
        Dim textPlay As String = "Song playing:" & System.Environment.NewLine & (curSongOpen)
        RichTextBox1.AppendText(textPlay)
    End Sub

    Private Sub PlayPauseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlayPauseToolStripMenuItem.Click

        'Play/Pause function when minimize'
        If wpm.playState = WMPLib.WMPPlayState.wmppsPaused Then
            wpm.Ctlcontrols.play()
        ElseIf wpm.playState = WMPLib.WMPPlayState.wmppsPlaying Then
            wpm.Ctlcontrols.pause()
        End If
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Me.Visible = True
    End Sub

    Private Sub NextToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NextToolStripMenuItem.Click
        'next function'
        If currentTrack = (ListBox1.Items.Count - 1) Then
            wpm.URL = ListBox1.Items(0)
            currentTrack = Nothing
        Else
            wpm.URL = ListBox1.Items(currentTrack + 1)
            currentTrack += 1
        End If
    End Sub


    Private Sub PreviousToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PreviousToolStripMenuItem.Click
        'Previous Function'
        If currentTrack = 0 Then
            wpm.URL = ListBox1.Items(ListBox1.Items.Count - 1)
            currentTrack = ListBox1.Items.Count - 1
        Else
            wpm.URL = ListBox1.Items(currentTrack - 1)
            currentTrack -= 1
        End If
    End Sub

    Private Sub wpm_MediaChange(sender As Object, e As AxWMPLib._WMPOCXEvents_MediaChangeEvent) Handles wpm.MediaChange
        TrackSongToolStripMenuItem.Text = ListBox1.Items(currentTrack)
    End Sub

    Private Sub wpm_PlayStateChange(sender As Object, e As AxWMPLib._WMPOCXEvents_PlayStateChangeEvent) Handles wpm.PlayStateChange
        While shuffle.CheckOnClick = True
            tempInt = r.Next(0, ListBox1.Items.Count + 1)
            wpm.URL = ListBox1.Items(tempInt)
        End While
        While RepeatToolStripMenuItem1.CheckOnClick = True
            wpm.URL = currentSong
            End
    End Sub
End Class

