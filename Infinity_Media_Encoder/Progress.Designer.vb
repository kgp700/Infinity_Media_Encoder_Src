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
        Me.ListBox1 = New System.Windows.Forms.ListBox()
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
        Me.SuspendLayout()
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.SystemColors.Menu
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Location = New System.Drawing.Point(2, 33)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(737, 360)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = ""
        '
        'BTNSTOP
        '
        Me.BTNSTOP.Location = New System.Drawing.Point(209, 461)
        Me.BTNSTOP.Name = "BTNSTOP"
        Me.BTNSTOP.Size = New System.Drawing.Size(148, 23)
        Me.BTNSTOP.TabIndex = 1
        Me.BTNSTOP.Text = "Stop Processing"
        Me.BTNSTOP.UseVisualStyleBackColor = True
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
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 12
        Me.ListBox1.Location = New System.Drawing.Point(501, 430)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(149, 16)
        Me.ListBox1.TabIndex = 5
        Me.ListBox1.Visible = False
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(363, 461)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(148, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Pause Processing"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(87, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 12)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Label3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(157, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 12)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Bitrate : "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 12)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "CPU Usage :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(308, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 12)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "fps : "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(413, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(103, 12)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Network Usage : "
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'LBBITRATE
        '
        Me.LBBITRATE.AutoSize = True
        Me.LBBITRATE.Location = New System.Drawing.Point(207, 9)
        Me.LBBITRATE.Name = "LBBITRATE"
        Me.LBBITRATE.Size = New System.Drawing.Size(71, 12)
        Me.LBBITRATE.TabIndex = 12
        Me.LBBITRATE.Text = "LBBITRATE"
        '
        'LBFPS
        '
        Me.LBFPS.AutoSize = True
        Me.LBFPS.Location = New System.Drawing.Point(340, 9)
        Me.LBFPS.Name = "LBFPS"
        Me.LBFPS.Size = New System.Drawing.Size(43, 12)
        Me.LBFPS.TabIndex = 13
        Me.LBFPS.Text = "LBFPS"
        '
        'LBNETWORK
        '
        Me.LBNETWORK.AutoSize = True
        Me.LBNETWORK.Location = New System.Drawing.Point(511, 9)
        Me.LBNETWORK.Name = "LBNETWORK"
        Me.LBNETWORK.Size = New System.Drawing.Size(84, 12)
        Me.LBNETWORK.TabIndex = 14
        Me.LBNETWORK.Text = "LBNETWORK "
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
        'FRMProgress
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(741, 491)
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
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.BTNSTOP)
        Me.Controls.Add(Me.RichTextBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "FRMProgress"
        Me.Text = "Infinity Media Encoder - Encoding Progress"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents BTNSTOP As System.Windows.Forms.Button
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
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
End Class
