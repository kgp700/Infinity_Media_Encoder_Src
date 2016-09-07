<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TrimPreviewPlayer2
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
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

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기를 사용하여 수정하지 마십시오.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.VideoScreen = New System.Windows.Forms.Panel()
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
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'VideoScreen
        '
        Me.VideoScreen.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VideoScreen.BackColor = System.Drawing.Color.Black
        Me.VideoScreen.Location = New System.Drawing.Point(1, 12)
        Me.VideoScreen.Name = "VideoScreen"
        Me.VideoScreen.Size = New System.Drawing.Size(863, 397)
        Me.VideoScreen.TabIndex = 4
        '
        'BTNPREVSTOP
        '
        Me.BTNPREVSTOP.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BTNPREVSTOP.Location = New System.Drawing.Point(93, 496)
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
        Me.Label1.Location = New System.Drawing.Point(10, 429)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 12)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(822, 429)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 12)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Label2"
        '
        'BTNPLAYPREV
        '
        Me.BTNPLAYPREV.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BTNPLAYPREV.Location = New System.Drawing.Point(7, 496)
        Me.BTNPLAYPREV.Name = "BTNPLAYPREV"
        Me.BTNPLAYPREV.Size = New System.Drawing.Size(75, 23)
        Me.BTNPLAYPREV.TabIndex = 33
        Me.BTNPLAYPREV.Text = "Play"
        Me.BTNPLAYPREV.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 50
        '
        'TrackBar1
        '
        Me.TrackBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TrackBar1.Location = New System.Drawing.Point(58, 417)
        Me.TrackBar1.Maximum = 100
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(752, 45)
        Me.TrackBar1.TabIndex = 34
        '
        'BOXSTARTTIME
        '
        Me.BOXSTARTTIME.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BOXSTARTTIME.Location = New System.Drawing.Point(79, 458)
        Me.BOXSTARTTIME.Name = "BOXSTARTTIME"
        Me.BOXSTARTTIME.Size = New System.Drawing.Size(100, 21)
        Me.BOXSTARTTIME.TabIndex = 35
        '
        'BOXENDTIME
        '
        Me.BOXENDTIME.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BOXENDTIME.Location = New System.Drawing.Point(271, 458)
        Me.BOXENDTIME.Name = "BOXENDTIME"
        Me.BOXENDTIME.Size = New System.Drawing.Size(100, 21)
        Me.BOXENDTIME.TabIndex = 36
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 461)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 12)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Start Time"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(205, 461)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 12)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "End Time"
        '
        'BTNINPUTSTIME
        '
        Me.BTNINPUTSTIME.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BTNINPUTSTIME.Location = New System.Drawing.Point(174, 496)
        Me.BTNINPUTSTIME.Name = "BTNINPUTSTIME"
        Me.BTNINPUTSTIME.Size = New System.Drawing.Size(123, 23)
        Me.BTNINPUTSTIME.TabIndex = 39
        Me.BTNINPUTSTIME.Text = "Input Start Time"
        Me.BTNINPUTSTIME.UseVisualStyleBackColor = True
        '
        'BTNINPUTETIME
        '
        Me.BTNINPUTETIME.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BTNINPUTETIME.Location = New System.Drawing.Point(303, 496)
        Me.BTNINPUTETIME.Name = "BTNINPUTETIME"
        Me.BTNINPUTETIME.Size = New System.Drawing.Size(123, 23)
        Me.BTNINPUTETIME.TabIndex = 40
        Me.BTNINPUTETIME.Text = "Input End Time"
        Me.BTNINPUTETIME.UseVisualStyleBackColor = True
        '
        'BTNOK
        '
        Me.BTNOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BTNOK.Location = New System.Drawing.Point(7, 525)
        Me.BTNOK.Name = "BTNOK"
        Me.BTNOK.Size = New System.Drawing.Size(75, 23)
        Me.BTNOK.TabIndex = 41
        Me.BTNOK.Text = "OK"
        Me.BTNOK.UseVisualStyleBackColor = True
        '
        'TrimPreviewPlayer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(876, 557)
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
        Me.Controls.Add(Me.VideoScreen)
        Me.Name = "TrimPreviewPlayer"
        Me.Text = "TrimPreviewPlayer"
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents VideoScreen As System.Windows.Forms.Panel
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
End Class
