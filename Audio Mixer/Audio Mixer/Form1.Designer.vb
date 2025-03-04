<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        lblName = New Label()
        picVolume = New PictureBox()
        lblVolume = New Label()
        tbVolumeApp = New TrackBar()
        lblOutputDevice = New Label()
        cmbOutputDevice = New ComboBox()
        ComboBox1 = New ComboBox()
        Label1 = New Label()
        pbVolumeLevel = New ProgressBar()
        lblTimer = New Label()
        picTime = New PictureBox()
        lblApp = New Label()
        appTrackBar = New TrackBar()
        pnlAppsContainer = New Panel()
        tmrUpdate = New Timer(components)
        tmrCountDown = New Timer(components)
        CType(picVolume, ComponentModel.ISupportInitialize).BeginInit()
        CType(tbVolumeApp, ComponentModel.ISupportInitialize).BeginInit()
        CType(picTime, ComponentModel.ISupportInitialize).BeginInit()
        CType(appTrackBar, ComponentModel.ISupportInitialize).BeginInit()
        pnlAppsContainer.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.ForeColor = Color.White
        lblName.Location = New Point(55, 56)
        lblName.Name = "lblName"
        lblName.Size = New Size(83, 30)
        lblName.TabIndex = 0
        lblName.Text = "Volume"
        ' 
        ' picVolume
        ' 
        picVolume.Image = My.Resources.Resources.no_volume
        picVolume.Location = New Point(310, 50)
        picVolume.Name = "picVolume"
        picVolume.Size = New Size(33, 36)
        picVolume.TabIndex = 1
        picVolume.TabStop = False
        ' 
        ' lblVolume
        ' 
        lblVolume.AutoSize = True
        lblVolume.ForeColor = Color.White
        lblVolume.Location = New Point(349, 56)
        lblVolume.Name = "lblVolume"
        lblVolume.Size = New Size(41, 30)
        lblVolume.TabIndex = 2
        lblVolume.Text = "0%"
        ' 
        ' tbVolumeApp
        ' 
        tbVolumeApp.Location = New Point(429, 50)
        tbVolumeApp.Maximum = 100
        tbVolumeApp.Name = "tbVolumeApp"
        tbVolumeApp.Size = New Size(257, 80)
        tbVolumeApp.TabIndex = 3
        tbVolumeApp.TickFrequency = 10
        ' 
        ' lblOutputDevice
        ' 
        lblOutputDevice.AutoSize = True
        lblOutputDevice.ForeColor = Color.White
        lblOutputDevice.Location = New Point(55, 137)
        lblOutputDevice.Name = "lblOutputDevice"
        lblOutputDevice.Size = New Size(147, 30)
        lblOutputDevice.TabIndex = 4
        lblOutputDevice.Text = "Output Device"
        ' 
        ' cmbOutputDevice
        ' 
        cmbOutputDevice.FormattingEnabled = True
        cmbOutputDevice.Location = New Point(310, 129)
        cmbOutputDevice.Name = "cmbOutputDevice"
        cmbOutputDevice.Size = New Size(376, 38)
        cmbOutputDevice.TabIndex = 5
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(310, 207)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(376, 38)
        ComboBox1.TabIndex = 7
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = Color.White
        Label1.Location = New Point(55, 215)
        Label1.Name = "Label1"
        Label1.Size = New Size(147, 30)
        Label1.TabIndex = 6
        Label1.Text = "Output Device"
        ' 
        ' pbVolumeLevel
        ' 
        pbVolumeLevel.Location = New Point(55, 332)
        pbVolumeLevel.Name = "pbVolumeLevel"
        pbVolumeLevel.Size = New Size(175, 40)
        pbVolumeLevel.TabIndex = 8
        ' 
        ' lblTimer
        ' 
        lblTimer.AutoSize = True
        lblTimer.ForeColor = Color.White
        lblTimer.Location = New Point(487, 342)
        lblTimer.Name = "lblTimer"
        lblTimer.Size = New Size(158, 30)
        lblTimer.TabIndex = 9
        lblTimer.Text = "Timer : 00:00:00"
        ' 
        ' picTime
        ' 
        picTime.Location = New Point(653, 336)
        picTime.Name = "picTime"
        picTime.Size = New Size(33, 36)
        picTime.TabIndex = 10
        picTime.TabStop = False
        ' 
        ' lblApp
        ' 
        lblApp.AutoSize = True
        lblApp.ForeColor = Color.White
        lblApp.Location = New Point(55, 12)
        lblApp.Name = "lblApp"
        lblApp.Size = New Size(118, 30)
        lblApp.TabIndex = 11
        lblApp.Text = "$AppName"
        ' 
        ' appTrackBar
        ' 
        appTrackBar.Location = New Point(260, 12)
        appTrackBar.Maximum = 100
        appTrackBar.Name = "appTrackBar"
        appTrackBar.Size = New Size(426, 80)
        appTrackBar.TabIndex = 12
        appTrackBar.TickFrequency = 10
        ' 
        ' pnlAppsContainer
        ' 
        pnlAppsContainer.Controls.Add(lblApp)
        pnlAppsContainer.Controls.Add(appTrackBar)
        pnlAppsContainer.Dock = DockStyle.Bottom
        pnlAppsContainer.Location = New Point(0, 428)
        pnlAppsContainer.Name = "pnlAppsContainer"
        pnlAppsContainer.Size = New Size(742, 419)
        pnlAppsContainer.TabIndex = 15
        ' 
        ' tmrUpdate
        ' 
        tmrUpdate.Interval = 2000
        ' 
        ' tmrCountDown
        ' 
        tmrCountDown.Interval = 1000
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(12F, 30F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(55), CByte(63), CByte(81))
        ClientSize = New Size(742, 847)
        Controls.Add(pnlAppsContainer)
        Controls.Add(picTime)
        Controls.Add(lblTimer)
        Controls.Add(pbVolumeLevel)
        Controls.Add(ComboBox1)
        Controls.Add(Label1)
        Controls.Add(cmbOutputDevice)
        Controls.Add(lblOutputDevice)
        Controls.Add(tbVolumeApp)
        Controls.Add(lblVolume)
        Controls.Add(picVolume)
        Controls.Add(lblName)
        Name = "Form1"
        Text = "Audio Mixer"
        CType(picVolume, ComponentModel.ISupportInitialize).EndInit()
        CType(tbVolumeApp, ComponentModel.ISupportInitialize).EndInit()
        CType(picTime, ComponentModel.ISupportInitialize).EndInit()
        CType(appTrackBar, ComponentModel.ISupportInitialize).EndInit()
        pnlAppsContainer.ResumeLayout(False)
        pnlAppsContainer.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents picVolume As PictureBox
    Friend WithEvents lblVolume As Label
    Friend WithEvents tbVolumeApp As TrackBar
    Friend WithEvents lblOutputDevice As Label
    Friend WithEvents cmbOutputDevice As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents pbVolumeLevel As ProgressBar
    Friend WithEvents lblTimer As Label
    Friend WithEvents picTime As PictureBox
    Friend WithEvents lblApp As Label
    Friend WithEvents appTrackBar As TrackBar
    Friend WithEvents pnlAppsContainer As Panel
    Friend WithEvents tmrUpdate As Timer
    Friend WithEvents tmrCountDown As Timer

End Class
