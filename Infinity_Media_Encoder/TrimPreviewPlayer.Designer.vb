<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TrimPreviewPlayer
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기를 사용하여 수정하지 마십시오.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.BTNPREVSTOP = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BTNPLAYPREV = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.BOXSTARTTIME = New System.Windows.Forms.TextBox()
        Me.BOXENDTIME = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BTNINPUTSTIME = New System.Windows.Forms.Button()
        Me.BTNINPUTETIME = New System.Windows.Forms.Button()
        Me.BTNOK = New System.Windows.Forms.Button()
        Me.VideoScreen = New System.Windows.Forms.Panel()
        Me.LISTLOG = New System.Windows.Forms.ListBox()
        Me.BTREWIND = New System.Windows.Forms.Button()
        Me.BTFF = New System.Windows.Forms.Button()
        Me.BTNSEEKFRAME = New System.Windows.Forms.Button()
        Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTNPREVSTOP
        '
        Me.BTNPREVSTOP.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BTNPREVSTOP.Location = New System.Drawing.Point(93, 711)
        Me.BTNPREVSTOP.Name = "BTNPREVSTOP"
        Me.BTNPREVSTOP.Size = New System.Drawing.Size(75, 23)
        Me.BTNPREVSTOP.TabIndex = 5
        Me.BTNPREVSTOP.Text = "Stop"
        Me.BTNPREVSTOP.UseVisualStyleBackColor = True
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 639)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 12)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "00:00:00"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(815, 639)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 12)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "00:00:00"
        '
        'BTNPLAYPREV
        '
        Me.BTNPLAYPREV.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BTNPLAYPREV.Location = New System.Drawing.Point(7, 711)
        Me.BTNPLAYPREV.Name = "BTNPLAYPREV"
        Me.BTNPLAYPREV.Size = New System.Drawing.Size(75, 23)
        Me.BTNPLAYPREV.TabIndex = 33
        Me.BTNPLAYPREV.Text = "Play"
        Me.BTNPLAYPREV.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'TrackBar1
        '
        Me.TrackBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TrackBar1.LargeChange = 0
        Me.TrackBar1.Location = New System.Drawing.Point(58, 628)
        Me.TrackBar1.Maximum = 100
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(752, 45)
        Me.TrackBar1.SmallChange = 0
        Me.TrackBar1.TabIndex = 34
        '
        'BOXSTARTTIME
        '
        Me.BOXSTARTTIME.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BOXSTARTTIME.Location = New System.Drawing.Point(111, 673)
        Me.BOXSTARTTIME.Name = "BOXSTARTTIME"
        Me.BOXSTARTTIME.Size = New System.Drawing.Size(100, 21)
        Me.BOXSTARTTIME.TabIndex = 35
        '
        'BOXENDTIME
        '
        Me.BOXENDTIME.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BOXENDTIME.Location = New System.Drawing.Point(324, 673)
        Me.BOXENDTIME.Name = "BOXENDTIME"
        Me.BOXENDTIME.Size = New System.Drawing.Size(100, 21)
        Me.BOXENDTIME.TabIndex = 36
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 676)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 12)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Trim Start Time"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(226, 676)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 12)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Trim End Time"
        '
        'BTNINPUTSTIME
        '
        Me.BTNINPUTSTIME.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BTNINPUTSTIME.Location = New System.Drawing.Point(174, 711)
        Me.BTNINPUTSTIME.Name = "BTNINPUTSTIME"
        Me.BTNINPUTSTIME.Size = New System.Drawing.Size(123, 23)
        Me.BTNINPUTSTIME.TabIndex = 39
        Me.BTNINPUTSTIME.Text = "Input Start Time"
        Me.BTNINPUTSTIME.UseVisualStyleBackColor = True
        '
        'BTNINPUTETIME
        '
        Me.BTNINPUTETIME.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BTNINPUTETIME.Location = New System.Drawing.Point(303, 711)
        Me.BTNINPUTETIME.Name = "BTNINPUTETIME"
        Me.BTNINPUTETIME.Size = New System.Drawing.Size(123, 23)
        Me.BTNINPUTETIME.TabIndex = 40
        Me.BTNINPUTETIME.Text = "Input End Time"
        Me.BTNINPUTETIME.UseVisualStyleBackColor = True
        '
        'BTNOK
        '
        Me.BTNOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BTNOK.Location = New System.Drawing.Point(7, 740)
        Me.BTNOK.Name = "BTNOK"
        Me.BTNOK.Size = New System.Drawing.Size(161, 23)
        Me.BTNOK.TabIndex = 41
        Me.BTNOK.Text = "Confirm Trim Time"
        Me.BTNOK.UseVisualStyleBackColor = True
        '
        'VideoScreen
        '
        Me.VideoScreen.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VideoScreen.BackColor = System.Drawing.Color.Black
        Me.VideoScreen.Location = New System.Drawing.Point(7, 9)
        Me.VideoScreen.Name = "VideoScreen"
        Me.VideoScreen.Size = New System.Drawing.Size(857, 464)
        Me.VideoScreen.TabIndex = 42
        '
        'LISTLOG
        '
        Me.LISTLOG.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LISTLOG.FormattingEnabled = True
        Me.LISTLOG.ItemHeight = 12
        Me.LISTLOG.Location = New System.Drawing.Point(7, 483)
        Me.LISTLOG.Name = "LISTLOG"
        Me.LISTLOG.Size = New System.Drawing.Size(857, 136)
        Me.LISTLOG.TabIndex = 43
        '
        'BTREWIND
        '
        Me.BTREWIND.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BTREWIND.Location = New System.Drawing.Point(432, 711)
        Me.BTREWIND.Name = "BTREWIND"
        Me.BTREWIND.Size = New System.Drawing.Size(75, 23)
        Me.BTREWIND.TabIndex = 44
        Me.BTREWIND.Text = "<"
        Me.BTREWIND.UseVisualStyleBackColor = True
        '
        'BTFF
        '
        Me.BTFF.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BTFF.Location = New System.Drawing.Point(513, 711)
        Me.BTFF.Name = "BTFF"
        Me.BTFF.Size = New System.Drawing.Size(75, 23)
        Me.BTFF.TabIndex = 45
        Me.BTFF.Text = ">"
        Me.BTFF.UseVisualStyleBackColor = True
        '
        'BTNSEEKFRAME
        '
        Me.BTNSEEKFRAME.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BTNSEEKFRAME.Location = New System.Drawing.Point(594, 711)
        Me.BTNSEEKFRAME.Name = "BTNSEEKFRAME"
        Me.BTNSEEKFRAME.Size = New System.Drawing.Size(75, 23)
        Me.BTNSEEKFRAME.TabIndex = 46
        Me.BTNSEEKFRAME.Text = "+0.1"
        Me.BTNSEEKFRAME.UseVisualStyleBackColor = True
        '
        'BackgroundWorker2
        '
        '
        'TrimPreviewPlayer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(876, 772)
        Me.Controls.Add(Me.BTNSEEKFRAME)
        Me.Controls.Add(Me.BTFF)
        Me.Controls.Add(Me.BTREWIND)
        Me.Controls.Add(Me.LISTLOG)
        Me.Controls.Add(Me.VideoScreen)
        Me.Controls.Add(Me.BTNOK)
        Me.Controls.Add(Me.BTNINPUTETIME)
        Me.Controls.Add(Me.BTNINPUTSTIME)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BOXENDTIME)
        Me.Controls.Add(Me.BOXSTARTTIME)
        Me.Controls.Add(Me.TrackBar1)
        Me.Controls.Add(Me.BTNPLAYPREV)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BTNPREVSTOP)
        Me.DoubleBuffered = True
        Me.Name = "TrimPreviewPlayer"
        Me.Text = "TrimPreviewPlayer"
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BTNPREVSTOP As System.Windows.Forms.Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BTNPLAYPREV As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents TrackBar1 As System.Windows.Forms.TrackBar
    Friend WithEvents BOXSTARTTIME As System.Windows.Forms.TextBox
    Friend WithEvents BOXENDTIME As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents BTNINPUTSTIME As System.Windows.Forms.Button
    Friend WithEvents BTNINPUTETIME As System.Windows.Forms.Button
    Friend WithEvents BTNOK As System.Windows.Forms.Button
    Friend WithEvents VideoScreen As System.Windows.Forms.Panel
    Friend WithEvents LISTLOG As System.Windows.Forms.ListBox
    Friend WithEvents BTREWIND As System.Windows.Forms.Button
    Friend WithEvents BTFF As System.Windows.Forms.Button
    Friend WithEvents BTNSEEKFRAME As System.Windows.Forms.Button
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
End Class
