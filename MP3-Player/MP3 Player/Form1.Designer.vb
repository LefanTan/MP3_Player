<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.wpm = New AxWMPLib.AxWindowsMediaPlayer()
        Me.ButFolder = New System.Windows.Forms.Button()
        Me.ButClose = New System.Windows.Forms.Button()
        Me.txtfolder = New System.Windows.Forms.TextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TrackSongToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.PlayPauseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NextToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PreviousToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ModeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RepeatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RepeatAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShuffleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LOLToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RepeatToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RepeatAllToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.shuffle = New System.Windows.Forms.ToolStripMenuItem()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.HScrollBar1 = New System.Windows.Forms.HScrollBar()
        CType(Me.wpm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'wpm
        '
        Me.wpm.Enabled = True
        Me.wpm.Location = New System.Drawing.Point(12, 248)
        Me.wpm.Name = "wpm"
        Me.wpm.OcxState = CType(resources.GetObject("wpm.OcxState"), System.Windows.Forms.AxHost.State)
        Me.wpm.Size = New System.Drawing.Size(325, 45)
        Me.wpm.TabIndex = 0
        '
        'ButFolder
        '
        Me.ButFolder.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ButFolder.Font = New System.Drawing.Font("Adobe Heiti Std R", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.ButFolder.Location = New System.Drawing.Point(254, 299)
        Me.ButFolder.Name = "ButFolder"
        Me.ButFolder.Size = New System.Drawing.Size(83, 31)
        Me.ButFolder.TabIndex = 1
        Me.ButFolder.Text = "Select Folder"
        Me.ButFolder.UseVisualStyleBackColor = False
        '
        'ButClose
        '
        Me.ButClose.Font = New System.Drawing.Font("Adobe Heiti Std R", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.ButClose.Location = New System.Drawing.Point(12, 338)
        Me.ButClose.Name = "ButClose"
        Me.ButClose.Size = New System.Drawing.Size(325, 33)
        Me.ButClose.TabIndex = 2
        Me.ButClose.Text = "Minimize To Tray"
        Me.ButClose.UseVisualStyleBackColor = True
        '
        'txtfolder
        '
        Me.txtfolder.Cursor = System.Windows.Forms.Cursors.No
        Me.txtfolder.Enabled = False
        Me.txtfolder.Font = New System.Drawing.Font("Adobe Heiti Std R", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtfolder.Location = New System.Drawing.Point(12, 299)
        Me.txtfolder.Name = "txtfolder"
        Me.txtfolder.Size = New System.Drawing.Size(236, 33)
        Me.txtfolder.TabIndex = 3
        '
        'ListBox1
        '
        Me.ListBox1.AllowDrop = True
        Me.ListBox1.BackColor = System.Drawing.Color.White
        Me.ListBox1.Font = New System.Drawing.Font("Adobe Heiti Std R", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 14
        Me.ListBox1.Location = New System.Drawing.Point(12, 27)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(325, 144)
        Me.ListBox1.TabIndex = 4
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TrackSongToolStripMenuItem, Me.ToolStripSeparator1, Me.PlayPauseToolStripMenuItem, Me.NextToolStripMenuItem, Me.PreviousToolStripMenuItem, Me.ToolStripSeparator2, Me.ModeToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(171, 148)
        '
        'TrackSongToolStripMenuItem
        '
        Me.TrackSongToolStripMenuItem.Name = "TrackSongToolStripMenuItem"
        Me.TrackSongToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.TrackSongToolStripMenuItem.Text = "Track Song/Name"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(167, 6)
        '
        'PlayPauseToolStripMenuItem
        '
        Me.PlayPauseToolStripMenuItem.Name = "PlayPauseToolStripMenuItem"
        Me.PlayPauseToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.PlayPauseToolStripMenuItem.Text = "Play/Pause"
        '
        'NextToolStripMenuItem
        '
        Me.NextToolStripMenuItem.Name = "NextToolStripMenuItem"
        Me.NextToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.NextToolStripMenuItem.Text = "Next"
        '
        'PreviousToolStripMenuItem
        '
        Me.PreviousToolStripMenuItem.Name = "PreviousToolStripMenuItem"
        Me.PreviousToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.PreviousToolStripMenuItem.Text = "Previous "
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(167, 6)
        '
        'ModeToolStripMenuItem
        '
        Me.ModeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RepeatToolStripMenuItem, Me.RepeatAllToolStripMenuItem, Me.ShuffleToolStripMenuItem})
        Me.ModeToolStripMenuItem.Name = "ModeToolStripMenuItem"
        Me.ModeToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.ModeToolStripMenuItem.Text = "Mode"
        '
        'RepeatToolStripMenuItem
        '
        Me.RepeatToolStripMenuItem.CheckOnClick = True
        Me.RepeatToolStripMenuItem.Name = "RepeatToolStripMenuItem"
        Me.RepeatToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.RepeatToolStripMenuItem.Text = "Repeat"
        '
        'RepeatAllToolStripMenuItem
        '
        Me.RepeatAllToolStripMenuItem.CheckOnClick = True
        Me.RepeatAllToolStripMenuItem.Name = "RepeatAllToolStripMenuItem"
        Me.RepeatAllToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.RepeatAllToolStripMenuItem.Text = "Repeat All"
        '
        'ShuffleToolStripMenuItem
        '
        Me.ShuffleToolStripMenuItem.CheckOnClick = True
        Me.ShuffleToolStripMenuItem.Name = "ShuffleToolStripMenuItem"
        Me.ShuffleToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.ShuffleToolStripMenuItem.Text = "Shuffle"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.ExitToolStripMenuItem.Text = "Exit "
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.LOLToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(352, 24)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'LOLToolStripMenuItem
        '
        Me.LOLToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RepeatToolStripMenuItem1, Me.RepeatAllToolStripMenuItem1, Me.shuffle})
        Me.LOLToolStripMenuItem.Name = "LOLToolStripMenuItem"
        Me.LOLToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.LOLToolStripMenuItem.Text = "Mode"
        '
        'RepeatToolStripMenuItem1
        '
        Me.RepeatToolStripMenuItem1.CheckOnClick = True
        Me.RepeatToolStripMenuItem1.Name = "RepeatToolStripMenuItem1"
        Me.RepeatToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.RepeatToolStripMenuItem1.Text = "Repeat"
        '
        'RepeatAllToolStripMenuItem1
        '
        Me.RepeatAllToolStripMenuItem1.CheckOnClick = True
        Me.RepeatAllToolStripMenuItem1.Name = "RepeatAllToolStripMenuItem1"
        Me.RepeatAllToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.RepeatAllToolStripMenuItem1.Text = "Repeat All"
        '
        'shuffle
        '
        Me.shuffle.CheckOnClick = True
        Me.shuffle.Name = "shuffle"
        Me.shuffle.Size = New System.Drawing.Size(152, 22)
        Me.shuffle.Text = "Shuffle"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Font = New System.Drawing.Font("Adobe Heiti Std R", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.RichTextBox1.ForeColor = System.Drawing.Color.Maroon
        Me.RichTextBox1.Location = New System.Drawing.Point(12, 197)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(325, 45)
        Me.RichTextBox1.TabIndex = 12
        Me.RichTextBox1.Text = ""
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'HScrollBar1
        '
        Me.HScrollBar1.Location = New System.Drawing.Point(12, 174)
        Me.HScrollBar1.Name = "HScrollBar1"
        Me.HScrollBar1.Size = New System.Drawing.Size(325, 17)
        Me.HScrollBar1.TabIndex = 13
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(352, 383)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.HScrollBar1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.txtfolder)
        Me.Controls.Add(Me.ButClose)
        Me.Controls.Add(Me.ButFolder)
        Me.Controls.Add(Me.wpm)
        Me.Font = New System.Drawing.Font("Adobe Heiti Std R", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Lefan's MP3 Player"
        CType(Me.wpm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents wpm As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents ButFolder As System.Windows.Forms.Button
    Friend WithEvents ButClose As System.Windows.Forms.Button
    Friend WithEvents txtfolder As System.Windows.Forms.TextBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents TrackSongToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PlayPauseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NextToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PreviousToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ModeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RepeatToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RepeatAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShuffleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LOLToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RepeatToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RepeatAllToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents shuffle As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents HScrollBar1 As System.Windows.Forms.HScrollBar

End Class
