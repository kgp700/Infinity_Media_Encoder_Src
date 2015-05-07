<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AvisynthOpt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AvisynthOpt))
        Me.CHKDGDEBLOCK = New System.Windows.Forms.CheckBox()
        Me.CHKDGNOISEFILTER = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BOXDGNOISEFILTER = New System.Windows.Forms.ComboBox()
        Me.BOXAVSSCRIPT = New System.Windows.Forms.TextBox()
        Me.RDBDGINDEX = New System.Windows.Forms.RadioButton()
        Me.RDBFFMS2 = New System.Windows.Forms.RadioButton()
        Me.CHKAVSMT = New System.Windows.Forms.CheckBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CHKDGDEBLOCK
        '
        Me.CHKDGDEBLOCK.AutoSize = True
        Me.CHKDGDEBLOCK.Checked = True
        Me.CHKDGDEBLOCK.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CHKDGDEBLOCK.Enabled = False
        Me.CHKDGDEBLOCK.Location = New System.Drawing.Point(12, 27)
        Me.CHKDGDEBLOCK.Name = "CHKDGDEBLOCK"
        Me.CHKDGDEBLOCK.Size = New System.Drawing.Size(184, 16)
        Me.CHKDGDEBLOCK.TabIndex = 0
        Me.CHKDGDEBLOCK.Text = "DGIndex MPEG2 Deblocking"
        Me.CHKDGDEBLOCK.UseVisualStyleBackColor = True
        '
        'CHKDGNOISEFILTER
        '
        Me.CHKDGNOISEFILTER.AutoSize = True
        Me.CHKDGNOISEFILTER.Location = New System.Drawing.Point(12, 50)
        Me.CHKDGNOISEFILTER.Name = "CHKDGNOISEFILTER"
        Me.CHKDGNOISEFILTER.Size = New System.Drawing.Size(88, 16)
        Me.CHKDGNOISEFILTER.TabIndex = 1
        Me.CHKDGNOISEFILTER.Text = "Noise Filter"
        Me.CHKDGNOISEFILTER.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Checked = True
        Me.CheckBox3.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox3.Enabled = False
        Me.CheckBox3.Location = New System.Drawing.Point(12, 72)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(116, 16)
        Me.CheckBox3.TabIndex = 2
        Me.CheckBox3.Text = "Color Correction"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(139, 364)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Save / Indexing"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BOXDGNOISEFILTER
        '
        Me.BOXDGNOISEFILTER.FormattingEnabled = True
        Me.BOXDGNOISEFILTER.Location = New System.Drawing.Point(106, 46)
        Me.BOXDGNOISEFILTER.Name = "BOXDGNOISEFILTER"
        Me.BOXDGNOISEFILTER.Size = New System.Drawing.Size(89, 20)
        Me.BOXDGNOISEFILTER.TabIndex = 5
        '
        'BOXAVSSCRIPT
        '
        Me.BOXAVSSCRIPT.Location = New System.Drawing.Point(9, 96)
        Me.BOXAVSSCRIPT.Multiline = True
        Me.BOXAVSSCRIPT.Name = "BOXAVSSCRIPT"
        Me.BOXAVSSCRIPT.Size = New System.Drawing.Size(499, 261)
        Me.BOXAVSSCRIPT.TabIndex = 6
        Me.BOXAVSSCRIPT.Text = resources.GetString("BOXAVSSCRIPT.Text")
        '
        'RDBDGINDEX
        '
        Me.RDBDGINDEX.AutoSize = True
        Me.RDBDGINDEX.Checked = True
        Me.RDBDGINDEX.Location = New System.Drawing.Point(13, 5)
        Me.RDBDGINDEX.Name = "RDBDGINDEX"
        Me.RDBDGINDEX.Size = New System.Drawing.Size(71, 16)
        Me.RDBDGINDEX.TabIndex = 7
        Me.RDBDGINDEX.TabStop = True
        Me.RDBDGINDEX.Text = "DGIndex"
        Me.RDBDGINDEX.UseVisualStyleBackColor = True
        '
        'RDBFFMS2
        '
        Me.RDBFFMS2.AutoSize = True
        Me.RDBFFMS2.Enabled = False
        Me.RDBFFMS2.Location = New System.Drawing.Point(90, 5)
        Me.RDBFFMS2.Name = "RDBFFMS2"
        Me.RDBFFMS2.Size = New System.Drawing.Size(93, 16)
        Me.RDBFFMS2.TabIndex = 8
        Me.RDBFFMS2.Text = "FFMS2Index"
        Me.RDBFFMS2.UseVisualStyleBackColor = True
        '
        'CHKAVSMT
        '
        Me.CHKAVSMT.AutoSize = True
        Me.CHKAVSMT.Location = New System.Drawing.Point(218, 5)
        Me.CHKAVSMT.Name = "CHKAVSMT"
        Me.CHKAVSMT.Size = New System.Drawing.Size(119, 16)
        Me.CHKAVSMT.TabIndex = 9
        Me.CHKAVSMT.Text = "AVS MultiThread"
        Me.CHKAVSMT.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(256, 364)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(111, 23)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Save Script Only"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(519, 399)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.CHKAVSMT)
        Me.Controls.Add(Me.RDBFFMS2)
        Me.Controls.Add(Me.RDBDGINDEX)
        Me.Controls.Add(Me.BOXAVSSCRIPT)
        Me.Controls.Add(Me.BOXDGNOISEFILTER)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CheckBox3)
        Me.Controls.Add(Me.CHKDGNOISEFILTER)
        Me.Controls.Add(Me.CHKDGDEBLOCK)
        Me.MaximizeBox = False
        Me.Name = "Form7"
        Me.Text = "Avisynth Options"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CHKDGDEBLOCK As System.Windows.Forms.CheckBox
    Friend WithEvents CHKDGNOISEFILTER As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents BOXDGNOISEFILTER As System.Windows.Forms.ComboBox
    Friend WithEvents BOXAVSSCRIPT As System.Windows.Forms.TextBox
    Friend WithEvents RDBDGINDEX As System.Windows.Forms.RadioButton
    Friend WithEvents RDBFFMS2 As System.Windows.Forms.RadioButton
    Friend WithEvents CHKAVSMT As System.Windows.Forms.CheckBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
