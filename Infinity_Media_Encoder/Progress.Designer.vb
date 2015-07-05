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
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.BTNSTOP = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.CHKVIEWLOG = New System.Windows.Forms.CheckBox()
        Me.PerformanceCounter1 = New System.Diagnostics.PerformanceCounter()
        Me.PerformanceCounter2 = New System.Diagnostics.PerformanceCounter()
        CType(Me.PerformanceCounter1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PerformanceCounter2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.SystemColors.Window
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Location = New System.Drawing.Point(2, 33)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(737, 361)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = ""
        '
        'BTNSTOP
        '
        Me.BTNSTOP.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BTNSTOP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNSTOP.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BTNSTOP.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BTNSTOP.Location = New System.Drawing.Point(143, 456)
        Me.BTNSTOP.Name = "BTNSTOP"
        Me.BTNSTOP.Size = New System.Drawing.Size(148, 23)
        Me.BTNSTOP.TabIndex = 1
        Me.BTNSTOP.Text = "Stop Processing"
        Me.BTNSTOP.UseVisualStyleBackColor = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(2, 400)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(737, 23)
        Me.ProgressBar1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 434)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 12)
        Me.Label1.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(88, 434)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 12)
        Me.Label2.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button1.Enabled = False
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button1.Location = New System.Drawing.Point(297, 456)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(148, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Pause Processing"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(87, 9)
        Me.Label3.Margin = New System.Windows.Forms.Padding(0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 12)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Label3"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(157, 9)
        Me.Label4.Margin = New System.Windows.Forms.Padding(0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 12)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Bitrate : "
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(7, 9)
        Me.Label5.Margin = New System.Windows.Forms.Padding(0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 12)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "CPU Usage :"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(312, 9)
        Me.Label6.Margin = New System.Windows.Forms.Padding(0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 12)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "fps : "
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(417, 9)
        Me.Label7.Margin = New System.Windows.Forms.Padding(0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(103, 12)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = " "
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'LBBITRATE
        '
        Me.LBBITRATE.Location = New System.Drawing.Point(207, 9)
        Me.LBBITRATE.Margin = New System.Windows.Forms.Padding(0)
        Me.LBBITRATE.Name = "LBBITRATE"
        Me.LBBITRATE.Size = New System.Drawing.Size(84, 12)
        Me.LBBITRATE.TabIndex = 12
        Me.LBBITRATE.Text = "LBBITRATE"
        '
        'LBFPS
        '
        Me.LBFPS.Location = New System.Drawing.Point(344, 9)
        Me.LBFPS.Margin = New System.Windows.Forms.Padding(0)
        Me.LBFPS.Name = "LBFPS"
        Me.LBFPS.Size = New System.Drawing.Size(43, 12)
        Me.LBFPS.TabIndex = 13
        Me.LBFPS.Text = "LBFPS"
        '
        'LBNETWORK
        '
        Me.LBNETWORK.Location = New System.Drawing.Point(515, 9)
        Me.LBNETWORK.Margin = New System.Windows.Forms.Padding(0)
        Me.LBNETWORK.Name = "LBNETWORK"
        Me.LBNETWORK.Size = New System.Drawing.Size(117, 12)
        Me.LBNETWORK.TabIndex = 14
        Me.LBNETWORK.Text = " "
        '
        'LBWARN
        '
        Me.LBWARN.AutoSize = True
        Me.LBWARN.ForeColor = System.Drawing.Color.Red
        Me.LBWARN.Location = New System.Drawing.Point(610, 9)
        Me.LBWARN.Name = "LBWARN"
        Me.LBWARN.Size = New System.Drawing.Size(0, 12)
        Me.LBWARN.TabIndex = 15
        '
        'BackgroundWorker_1
        '
        Me.BackgroundWorker_1.WorkerReportsProgress = True
        Me.BackgroundWorker_1.WorkerSupportsCancellation = True
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button2.Location = New System.Drawing.Point(451, 456)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(148, 23)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "Force Stop"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'CHKVIEWLOG
        '
        Me.CHKVIEWLOG.AutoSize = True
        Me.CHKVIEWLOG.Checked = True
        Me.CHKVIEWLOG.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CHKVIEWLOG.Location = New System.Drawing.Point(643, 433)
        Me.CHKVIEWLOG.Name = "CHKVIEWLOG"
        Me.CHKVIEWLOG.Size = New System.Drawing.Size(77, 16)
        Me.CHKVIEWLOG.TabIndex = 17
        Me.CHKVIEWLOG.Text = "View Log"
        Me.CHKVIEWLOG.UseVisualStyleBackColor = True
        '
        'PerformanceCounter1
        '
        Me.PerformanceCounter1.CategoryName = "Processor"
        Me.PerformanceCounter1.CounterName = "% Processor Time"
        Me.PerformanceCounter1.InstanceName = "_Total"
        '
        'PerformanceCounter2
        '
        Me.PerformanceCounter2.CategoryName = "Network Adapter"
        Me.PerformanceCounter2.CounterName = "Current Bandwidth"
        Me.PerformanceCounter2.InstanceName = "Realtek PCIe GBE Family Controller"
        '
        'FRMProgress
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(741, 491)
        Me.Controls.Add(Me.CHKVIEWLOG)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.LBWARN)
        Me.Controls.Add(Me.LBNETWORK)
        Me.Controls.Add(Me.LBFPS)
        Me.Controls.Add(Me.LBBITRATE)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.BTNSTOP)
        Me.Controls.Add(Me.RichTextBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "FRMProgress"
        Me.Text = "Infinity Media Encoder - Encoding Progress"
        CType(Me.PerformanceCounter1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PerformanceCounter2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents BTNSTOP As System.Windows.Forms.Button
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
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
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents CHKVIEWLOG As System.Windows.Forms.CheckBox
    Friend WithEvents PerformanceCounter1 As System.Diagnostics.PerformanceCounter
    Friend WithEvents PerformanceCounter2 As System.Diagnostics.PerformanceCounter
End Class
