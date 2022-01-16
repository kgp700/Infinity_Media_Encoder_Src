<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMProgress
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
        Me.BTNSTOP = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BTNPAUSE = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LBBITRATE = New System.Windows.Forms.Label()
        Me.LBFPS = New System.Windows.Forms.Label()
        Me.LBNETWORK = New System.Windows.Forms.Label()
        Me.LBWARN = New System.Windows.Forms.Label()
        Me.BackgroundWorker_1 = New System.ComponentModel.BackgroundWorker()
        Me.BTNFORCESTOP = New System.Windows.Forms.Button()
        Me.CHKVIEWLOG = New System.Windows.Forms.CheckBox()
        Me.PerformanceCounter1 = New System.Diagnostics.PerformanceCounter()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Percentage = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MENUSTOPENC = New System.Windows.Forms.ToolStripMenuItem()
        Me.ENCODINGLIST = New System.Windows.Forms.ListBox()
        Me.ENCODINGLISTVIEW = New System.Windows.Forms.ListView()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.COLSTARTTIME = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.COLENDTIME = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.COLDURATION = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.COLPATH = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BTOPENOUTFOLDER = New System.Windows.Forms.Button()
        Me.BTNSTREAMINFOPOP = New System.Windows.Forms.Button()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.LBELAPSEDTIME = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CBPRI = New System.Windows.Forms.ComboBox()
        CType(Me.PerformanceCounter1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BTNSTOP
        '
        Me.BTNSTOP.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BTNSTOP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNSTOP.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BTNSTOP.Font = New System.Drawing.Font("맑은 고딕", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.BTNSTOP.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BTNSTOP.Location = New System.Drawing.Point(12, 481)
        Me.BTNSTOP.Name = "BTNSTOP"
        Me.BTNSTOP.Size = New System.Drawing.Size(135, 23)
        Me.BTNSTOP.TabIndex = 1
        Me.BTNSTOP.Text = "Stop"
        Me.BTNSTOP.UseVisualStyleBackColor = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(2, 432)
        Me.ProgressBar1.MarqueeAnimationSpeed = 0
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(737, 23)
        Me.ProgressBar1.Step = 1
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("맑은 고딕", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 460)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("맑은 고딕", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label2.Location = New System.Drawing.Point(81, 460)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 4
        '
        'BTNPAUSE
        '
        Me.BTNPAUSE.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BTNPAUSE.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BTNPAUSE.Font = New System.Drawing.Font("맑은 고딕", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.BTNPAUSE.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BTNPAUSE.Location = New System.Drawing.Point(155, 481)
        Me.BTNPAUSE.Name = "BTNPAUSE"
        Me.BTNPAUSE.Size = New System.Drawing.Size(135, 23)
        Me.BTNPAUSE.TabIndex = 6
        Me.BTNPAUSE.Text = "Pause"
        Me.BTNPAUSE.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label3.Location = New System.Drawing.Point(87, 6)
        Me.Label3.Margin = New System.Windows.Forms.Padding(0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 18)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "-"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label4.Location = New System.Drawing.Point(157, 6)
        Me.Label4.Margin = New System.Windows.Forms.Padding(0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 18)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Bitrate : "
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label5.Location = New System.Drawing.Point(7, 6)
        Me.Label5.Margin = New System.Windows.Forms.Padding(0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 18)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "CPU Usage :"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label6.Location = New System.Drawing.Point(312, 6)
        Me.Label6.Margin = New System.Windows.Forms.Padding(0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 18)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "fps : "
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label7.Location = New System.Drawing.Point(417, 6)
        Me.Label7.Margin = New System.Windows.Forms.Padding(0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(103, 18)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = " "
        Me.Label7.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 2000
        '
        'LBBITRATE
        '
        Me.LBBITRATE.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.LBBITRATE.Location = New System.Drawing.Point(207, 6)
        Me.LBBITRATE.Margin = New System.Windows.Forms.Padding(0)
        Me.LBBITRATE.Name = "LBBITRATE"
        Me.LBBITRATE.Size = New System.Drawing.Size(95, 18)
        Me.LBBITRATE.TabIndex = 12
        Me.LBBITRATE.Text = "-"
        '
        'LBFPS
        '
        Me.LBFPS.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.LBFPS.Location = New System.Drawing.Point(344, 6)
        Me.LBFPS.Margin = New System.Windows.Forms.Padding(0)
        Me.LBFPS.Name = "LBFPS"
        Me.LBFPS.Size = New System.Drawing.Size(73, 18)
        Me.LBFPS.TabIndex = 13
        Me.LBFPS.Text = "-"
        '
        'LBNETWORK
        '
        Me.LBNETWORK.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.LBNETWORK.Location = New System.Drawing.Point(515, 6)
        Me.LBNETWORK.Margin = New System.Windows.Forms.Padding(0)
        Me.LBNETWORK.Name = "LBNETWORK"
        Me.LBNETWORK.Size = New System.Drawing.Size(117, 18)
        Me.LBNETWORK.TabIndex = 14
        Me.LBNETWORK.Text = " "
        Me.LBNETWORK.Visible = False
        '
        'LBWARN
        '
        Me.LBWARN.AutoSize = True
        Me.LBWARN.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.LBWARN.ForeColor = System.Drawing.Color.Red
        Me.LBWARN.Location = New System.Drawing.Point(639, 5)
        Me.LBWARN.Name = "LBWARN"
        Me.LBWARN.Size = New System.Drawing.Size(0, 15)
        Me.LBWARN.TabIndex = 15
        '
        'BackgroundWorker_1
        '
        Me.BackgroundWorker_1.WorkerReportsProgress = True
        Me.BackgroundWorker_1.WorkerSupportsCancellation = True
        '
        'BTNFORCESTOP
        '
        Me.BTNFORCESTOP.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BTNFORCESTOP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNFORCESTOP.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BTNFORCESTOP.Font = New System.Drawing.Font("맑은 고딕", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.BTNFORCESTOP.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BTNFORCESTOP.Location = New System.Drawing.Point(296, 481)
        Me.BTNFORCESTOP.Name = "BTNFORCESTOP"
        Me.BTNFORCESTOP.Size = New System.Drawing.Size(135, 23)
        Me.BTNFORCESTOP.TabIndex = 16
        Me.BTNFORCESTOP.Text = "Force Stop for All Jobs"
        Me.BTNFORCESTOP.UseVisualStyleBackColor = False
        '
        'CHKVIEWLOG
        '
        Me.CHKVIEWLOG.AutoSize = True
        Me.CHKVIEWLOG.Checked = True
        Me.CHKVIEWLOG.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CHKVIEWLOG.Font = New System.Drawing.Font("맑은 고딕", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.CHKVIEWLOG.Location = New System.Drawing.Point(643, 460)
        Me.CHKVIEWLOG.Name = "CHKVIEWLOG"
        Me.CHKVIEWLOG.Size = New System.Drawing.Size(76, 17)
        Me.CHKVIEWLOG.TabIndex = 17
        Me.CHKVIEWLOG.Text = "Show Log"
        Me.CHKVIEWLOG.UseVisualStyleBackColor = True
        '
        'PerformanceCounter1
        '
        Me.PerformanceCounter1.CategoryName = "Processor"
        Me.PerformanceCounter1.CounterName = "% Processor Time"
        Me.PerformanceCounter1.InstanceName = "_Total"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button3.Font = New System.Drawing.Font("맑은 고딕", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button3.Location = New System.Drawing.Point(596, 456)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(41, 23)
        Me.Button3.TabIndex = 18
        Me.Button3.Text = "TEST"
        Me.Button3.UseVisualStyleBackColor = False
        Me.Button3.Visible = False
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("맑은 고딕", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.HorizontalScrollbar = True
        Me.ListBox1.Location = New System.Drawing.Point(2, 207)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(737, 186)
        Me.ListBox1.TabIndex = 19
        '
        'Percentage
        '
        Me.Percentage.BackColor = System.Drawing.Color.Transparent
        Me.Percentage.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Percentage.Location = New System.Drawing.Point(339, 407)
        Me.Percentage.Margin = New System.Windows.Forms.Padding(0)
        Me.Percentage.Name = "Percentage"
        Me.Percentage.Size = New System.Drawing.Size(82, 21)
        Me.Percentage.TabIndex = 20
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label8.Location = New System.Drawing.Point(606, 407)
        Me.Label8.Margin = New System.Windows.Forms.Padding(0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(126, 18)
        Me.Label8.TabIndex = 22
        '
        'BackgroundWorker2
        '
        Me.BackgroundWorker2.WorkerReportsProgress = True
        Me.BackgroundWorker2.WorkerSupportsCancellation = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(17, 17)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MENUSTOPENC})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(212, 26)
        '
        'MENUSTOPENC
        '
        Me.MENUSTOPENC.Name = "MENUSTOPENC"
        Me.MENUSTOPENC.Size = New System.Drawing.Size(211, 22)
        Me.MENUSTOPENC.Text = "Delete from encoding list"
        '
        'ENCODINGLIST
        '
        Me.ENCODINGLIST.ContextMenuStrip = Me.ContextMenuStrip1
        Me.ENCODINGLIST.Font = New System.Drawing.Font("맑은 고딕", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.ENCODINGLIST.FormattingEnabled = True
        Me.ENCODINGLIST.HorizontalScrollbar = True
        Me.ENCODINGLIST.Location = New System.Drawing.Point(2, 29)
        Me.ENCODINGLIST.Name = "ENCODINGLIST"
        Me.ENCODINGLIST.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.ENCODINGLIST.Size = New System.Drawing.Size(737, 43)
        Me.ENCODINGLIST.TabIndex = 25
        Me.ENCODINGLIST.Visible = False
        '
        'ENCODINGLISTVIEW
        '
        Me.ENCODINGLISTVIEW.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.COLSTARTTIME, Me.COLENDTIME, Me.COLDURATION, Me.COLPATH})
        Me.ENCODINGLISTVIEW.ContextMenuStrip = Me.ContextMenuStrip1
        Me.ENCODINGLISTVIEW.Font = New System.Drawing.Font("맑은 고딕", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.ENCODINGLISTVIEW.FullRowSelect = True
        Me.ENCODINGLISTVIEW.HideSelection = False
        Me.ENCODINGLISTVIEW.Location = New System.Drawing.Point(2, 29)
        Me.ENCODINGLISTVIEW.Name = "ENCODINGLISTVIEW"
        Me.ENCODINGLISTVIEW.ShowItemToolTips = True
        Me.ENCODINGLISTVIEW.Size = New System.Drawing.Size(737, 177)
        Me.ENCODINGLISTVIEW.TabIndex = 79
        Me.ENCODINGLISTVIEW.UseCompatibleStateImageBehavior = False
        Me.ENCODINGLISTVIEW.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Output File Name"
        Me.ColumnHeader3.Width = 441
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Status"
        Me.ColumnHeader4.Width = 100
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Command"
        Me.ColumnHeader5.Width = 191
        '
        'COLSTARTTIME
        '
        Me.COLSTARTTIME.Text = "Start Time"
        '
        'COLENDTIME
        '
        Me.COLENDTIME.Text = "End Time"
        '
        'COLDURATION
        '
        Me.COLDURATION.Text = "Original Duration"
        Me.COLDURATION.Width = 119
        '
        'COLPATH
        '
        Me.COLPATH.Text = "Output Path"
        '
        'BTOPENOUTFOLDER
        '
        Me.BTOPENOUTFOLDER.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BTOPENOUTFOLDER.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTOPENOUTFOLDER.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BTOPENOUTFOLDER.Font = New System.Drawing.Font("맑은 고딕", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.BTOPENOUTFOLDER.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BTOPENOUTFOLDER.Location = New System.Drawing.Point(437, 481)
        Me.BTOPENOUTFOLDER.Name = "BTOPENOUTFOLDER"
        Me.BTOPENOUTFOLDER.Size = New System.Drawing.Size(135, 23)
        Me.BTOPENOUTFOLDER.TabIndex = 80
        Me.BTOPENOUTFOLDER.Text = "Open Output Folder"
        Me.BTOPENOUTFOLDER.UseVisualStyleBackColor = False
        '
        'BTNSTREAMINFOPOP
        '
        Me.BTNSTREAMINFOPOP.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BTNSTREAMINFOPOP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNSTREAMINFOPOP.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BTNSTREAMINFOPOP.Font = New System.Drawing.Font("맑은 고딕", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.BTNSTREAMINFOPOP.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BTNSTREAMINFOPOP.Location = New System.Drawing.Point(578, 481)
        Me.BTNSTREAMINFOPOP.Name = "BTNSTREAMINFOPOP"
        Me.BTNSTREAMINFOPOP.Size = New System.Drawing.Size(135, 23)
        Me.BTNSTREAMINFOPOP.TabIndex = 81
        Me.BTNSTREAMINFOPOP.Text = "Popout Encoding Info"
        Me.BTNSTREAMINFOPOP.UseVisualStyleBackColor = False
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'LBELAPSEDTIME
        '
        Me.LBELAPSEDTIME.AutoSize = True
        Me.LBELAPSEDTIME.Font = New System.Drawing.Font("맑은 고딕", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.LBELAPSEDTIME.Location = New System.Drawing.Point(8, 411)
        Me.LBELAPSEDTIME.Name = "LBELAPSEDTIME"
        Me.LBELAPSEDTIME.Size = New System.Drawing.Size(0, 13)
        Me.LBELAPSEDTIME.TabIndex = 82
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label9.Location = New System.Drawing.Point(587, 6)
        Me.Label9.Margin = New System.Windows.Forms.Padding(0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 18)
        Me.Label9.TabIndex = 88
        Me.Label9.Text = "Priority"
        '
        'CBPRI
        '
        Me.CBPRI.Font = New System.Drawing.Font("맑은 고딕", 9.176471!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.CBPRI.FormattingEnabled = True
        Me.CBPRI.Items.AddRange(New Object() {"High", "AboveNormal", "Normal", "BelowNormal"})
        Me.CBPRI.Location = New System.Drawing.Point(645, 3)
        Me.CBPRI.Name = "CBPRI"
        Me.CBPRI.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CBPRI.Size = New System.Drawing.Size(94, 23)
        Me.CBPRI.TabIndex = 87
        Me.CBPRI.Text = "Normal"
        '
        'FRMProgress
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(741, 510)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.CBPRI)
        Me.Controls.Add(Me.LBELAPSEDTIME)
        Me.Controls.Add(Me.BTNSTREAMINFOPOP)
        Me.Controls.Add(Me.BTOPENOUTFOLDER)
        Me.Controls.Add(Me.ENCODINGLISTVIEW)
        Me.Controls.Add(Me.ENCODINGLIST)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Percentage)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.CHKVIEWLOG)
        Me.Controls.Add(Me.BTNFORCESTOP)
        Me.Controls.Add(Me.LBWARN)
        Me.Controls.Add(Me.LBNETWORK)
        Me.Controls.Add(Me.LBFPS)
        Me.Controls.Add(Me.LBBITRATE)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BTNPAUSE)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.BTNSTOP)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FRMProgress"
        Me.Text = "Infinity Media Encoder - Encoding Progress"
        CType(Me.PerformanceCounter1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BTNSTOP As System.Windows.Forms.Button
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BTNPAUSE As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents LBBITRATE As System.Windows.Forms.Label
    Friend WithEvents LBFPS As System.Windows.Forms.Label
    Friend WithEvents LBNETWORK As System.Windows.Forms.Label
    Friend WithEvents LBWARN As System.Windows.Forms.Label
    Friend WithEvents BackgroundWorker_1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BTNFORCESTOP As System.Windows.Forms.Button
    Friend WithEvents CHKVIEWLOG As System.Windows.Forms.CheckBox
    Friend WithEvents PerformanceCounter1 As System.Diagnostics.PerformanceCounter
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Percentage As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ENCODINGLIST As System.Windows.Forms.ListBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents MENUSTOPENC As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ENCODINGLISTVIEW As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents COLSTARTTIME As System.Windows.Forms.ColumnHeader
    Friend WithEvents COLENDTIME As System.Windows.Forms.ColumnHeader
    Friend WithEvents COLDURATION As System.Windows.Forms.ColumnHeader
    Friend WithEvents BTOPENOUTFOLDER As Button
    Friend WithEvents BTNSTREAMINFOPOP As Button
    Friend WithEvents COLPATH As ColumnHeader
    Friend WithEvents Timer2 As Timer
    Friend WithEvents LBELAPSEDTIME As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents CBPRI As ComboBox
End Class
