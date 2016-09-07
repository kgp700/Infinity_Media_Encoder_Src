<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdvancedFRM
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
        Me.Button1s = New System.Windows.Forms.Button()
        Me.BOXBFRAMES = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.CheckBox7 = New System.Windows.Forms.CheckBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.BOXSR = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.BOXMEALGO = New System.Windows.Forms.ComboBox()
        Me.NMMERANGE = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BOXFADE = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBox6 = New System.Windows.Forms.ComboBox()
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.BOXSCENE = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.BOXTR = New System.Windows.Forms.ComboBox()
        Me.CHKNODCT = New System.Windows.Forms.CheckBox()
        Me.CHKNOPSKIP = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.BOXAQSTR = New System.Windows.Forms.ComboBox()
        Me.BOXAQMODE = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.NMDBTR = New System.Windows.Forms.NumericUpDown()
        Me.NMDBSTR = New System.Windows.Forms.NumericUpDown()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NMMERANGE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.NMDBTR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NMDBSTR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1s
        '
        Me.Button1s.Font = New System.Drawing.Font("맑은 고딕", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Button1s.Location = New System.Drawing.Point(267, 380)
        Me.Button1s.Name = "Button1s"
        Me.Button1s.Size = New System.Drawing.Size(75, 23)
        Me.Button1s.TabIndex = 0
        Me.Button1s.Text = "OK"
        Me.Button1s.UseVisualStyleBackColor = True
        '
        'BOXBFRAMES
        '
        Me.BOXBFRAMES.FormattingEnabled = True
        Me.BOXBFRAMES.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.BOXBFRAMES.Location = New System.Drawing.Point(121, 217)
        Me.BOXBFRAMES.Name = "BOXBFRAMES"
        Me.BOXBFRAMES.Size = New System.Drawing.Size(125, 21)
        Me.BOXBFRAMES.TabIndex = 1
        Me.BOXBFRAMES.Text = "3"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.CheckBox7)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.BOXSR)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.BOXMEALGO)
        Me.GroupBox1.Controls.Add(Me.NMMERANGE)
        Me.GroupBox1.Font = New System.Drawing.Font("맑은 고딕", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(352, 149)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(317, 122)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Motion Estimation"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(12, 72)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(111, 13)
        Me.Label16.TabIndex = 25
        Me.Label16.Text = "Subpixel Refinement"
        '
        'CheckBox7
        '
        Me.CheckBox7.AutoSize = True
        Me.CheckBox7.Checked = True
        Me.CheckBox7.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox7.Font = New System.Drawing.Font("맑은 고딕", 8.25!)
        Me.CheckBox7.Location = New System.Drawing.Point(14, 96)
        Me.CheckBox7.Name = "CheckBox7"
        Me.CheckBox7.Size = New System.Drawing.Size(90, 17)
        Me.CheckBox7.TabIndex = 6
        Me.CheckBox7.Text = "Chroma M.E."
        Me.CheckBox7.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(12, 45)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(82, 13)
        Me.Label15.TabIndex = 24
        Me.Label15.Text = "M.E. Algorithm"
        '
        'BOXSR
        '
        Me.BOXSR.FormattingEnabled = True
        Me.BOXSR.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11"})
        Me.BOXSR.Location = New System.Drawing.Point(155, 69)
        Me.BOXSR.Name = "BOXSR"
        Me.BOXSR.Size = New System.Drawing.Size(121, 21)
        Me.BOXSR.TabIndex = 5
        Me.BOXSR.Text = "6"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(12, 23)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(63, 13)
        Me.Label14.TabIndex = 23
        Me.Label14.Text = "M.E. Range"
        '
        'BOXMEALGO
        '
        Me.BOXMEALGO.FormattingEnabled = True
        Me.BOXMEALGO.Items.AddRange(New Object() {"dia", "hex", "umh", "esa", "tesa"})
        Me.BOXMEALGO.Location = New System.Drawing.Point(155, 42)
        Me.BOXMEALGO.Name = "BOXMEALGO"
        Me.BOXMEALGO.Size = New System.Drawing.Size(121, 21)
        Me.BOXMEALGO.TabIndex = 4
        Me.BOXMEALGO.Text = "umh"
        '
        'NMMERANGE
        '
        Me.NMMERANGE.Location = New System.Drawing.Point(155, 15)
        Me.NMMERANGE.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.NMMERANGE.Minimum = New Decimal(New Integer() {16, 0, 0, 0})
        Me.NMMERANGE.Name = "NMMERANGE"
        Me.NMMERANGE.Size = New System.Drawing.Size(54, 22)
        Me.NMMERANGE.TabIndex = 3
        Me.NMMERANGE.Value = New Decimal(New Integer() {16, 0, 0, 0})
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.ComboBox3)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.CheckBox3)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.BOXFADE)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.ComboBox6)
        Me.GroupBox2.Controls.Add(Me.ComboBox5)
        Me.GroupBox2.Controls.Add(Me.ComboBox4)
        Me.GroupBox2.Controls.Add(Me.BOXSCENE)
        Me.GroupBox2.Controls.Add(Me.ComboBox2)
        Me.GroupBox2.Controls.Add(Me.ComboBox1)
        Me.GroupBox2.Controls.Add(Me.BOXTR)
        Me.GroupBox2.Controls.Add(Me.CHKNODCT)
        Me.GroupBox2.Controls.Add(Me.BOXBFRAMES)
        Me.GroupBox2.Controls.Add(Me.CHKNOPSKIP)
        Me.GroupBox2.Font = New System.Drawing.Font("맑은 고딕", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(3, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(343, 354)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Extra / B-Frames"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "MV Prediction mod"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(13, 277)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "B-Pyramid"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Psy-RD Strength"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 251)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(102, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Adapted B-Frames"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Trellis"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 303)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Reserved"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 220)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "B-frames"
        '
        'ComboBox3
        '
        Me.ComboBox3.Enabled = False
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"0.0", "0.5", "1.0"})
        Me.ComboBox3.Location = New System.Drawing.Point(106, 48)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(125, 21)
        Me.ComboBox3.TabIndex = 23
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 195)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(155, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "P-frame Weighted Prediction"
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Checked = True
        Me.CheckBox3.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox3.Font = New System.Drawing.Font("맑은 고딕", 8.25!)
        Me.CheckBox3.Location = New System.Drawing.Point(14, 326)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(92, 17)
        Me.CheckBox3.TabIndex = 21
        Me.CheckBox3.Text = "Use MB-Tree"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 168)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Scenecut"
        '
        'BOXFADE
        '
        Me.BOXFADE.Enabled = False
        Me.BOXFADE.FormattingEnabled = True
        Me.BOXFADE.Items.AddRange(New Object() {"0.0", "0.5", "1.0"})
        Me.BOXFADE.Location = New System.Drawing.Point(121, 300)
        Me.BOXFADE.Name = "BOXFADE"
        Me.BOXFADE.Size = New System.Drawing.Size(125, 21)
        Me.BOXFADE.TabIndex = 20
        Me.BOXFADE.Text = "1.0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 145)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Lookahead"
        '
        'ComboBox6
        '
        Me.ComboBox6.Enabled = False
        Me.ComboBox6.FormattingEnabled = True
        Me.ComboBox6.Location = New System.Drawing.Point(121, 274)
        Me.ComboBox6.Name = "ComboBox6"
        Me.ComboBox6.Size = New System.Drawing.Size(125, 21)
        Me.ComboBox6.TabIndex = 17
        Me.ComboBox6.Text = "Normal"
        '
        'ComboBox5
        '
        Me.ComboBox5.Enabled = False
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.Location = New System.Drawing.Point(121, 248)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(125, 21)
        Me.ComboBox5.TabIndex = 15
        Me.ComboBox5.Text = "Smart"
        '
        'ComboBox4
        '
        Me.ComboBox4.Enabled = False
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(185, 192)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(125, 21)
        Me.ComboBox4.TabIndex = 13
        Me.ComboBox4.Text = "2-Optimal"
        '
        'BOXSCENE
        '
        Me.BOXSCENE.FormattingEnabled = True
        Me.BOXSCENE.Items.AddRange(New Object() {"40", "50", "60", "70", "100"})
        Me.BOXSCENE.Location = New System.Drawing.Point(106, 165)
        Me.BOXSCENE.Name = "BOXSCENE"
        Me.BOXSCENE.Size = New System.Drawing.Size(125, 21)
        Me.BOXSCENE.TabIndex = 11
        Me.BOXSCENE.Text = "40"
        '
        'ComboBox2
        '
        Me.ComboBox2.Enabled = False
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(106, 142)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(125, 21)
        Me.ComboBox2.TabIndex = 9
        Me.ComboBox2.Text = "40"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"1", "2", "3"})
        Me.ComboBox1.Location = New System.Drawing.Point(150, 116)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(81, 21)
        Me.ComboBox1.TabIndex = 7
        Me.ComboBox1.Text = "3"
        '
        'BOXTR
        '
        Me.BOXTR.FormattingEnabled = True
        Me.BOXTR.Items.AddRange(New Object() {"1", "2"})
        Me.BOXTR.Location = New System.Drawing.Point(106, 22)
        Me.BOXTR.Name = "BOXTR"
        Me.BOXTR.Size = New System.Drawing.Size(125, 21)
        Me.BOXTR.TabIndex = 6
        Me.BOXTR.Text = "1"
        '
        'CHKNODCT
        '
        Me.CHKNODCT.AutoSize = True
        Me.CHKNODCT.Checked = True
        Me.CHKNODCT.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CHKNODCT.Font = New System.Drawing.Font("맑은 고딕", 8.25!)
        Me.CHKNODCT.Location = New System.Drawing.Point(15, 96)
        Me.CHKNODCT.Name = "CHKNODCT"
        Me.CHKNODCT.Size = New System.Drawing.Size(124, 17)
        Me.CHKNODCT.TabIndex = 2
        Me.CHKNODCT.Text = "No Dct Decimation"
        Me.CHKNODCT.UseVisualStyleBackColor = True
        '
        'CHKNOPSKIP
        '
        Me.CHKNOPSKIP.AutoSize = True
        Me.CHKNOPSKIP.Checked = True
        Me.CHKNOPSKIP.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CHKNOPSKIP.Font = New System.Drawing.Font("맑은 고딕", 8.25!)
        Me.CHKNOPSKIP.Location = New System.Drawing.Point(15, 73)
        Me.CHKNOPSKIP.Name = "CHKNOPSKIP"
        Me.CHKNOPSKIP.Size = New System.Drawing.Size(102, 17)
        Me.CHKNOPSKIP.TabIndex = 1
        Me.CHKNOPSKIP.Text = "No Fast P-Skip"
        Me.CHKNOPSKIP.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.BOXAQSTR)
        Me.GroupBox3.Controls.Add(Me.BOXAQMODE)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Font = New System.Drawing.Font("맑은 고딕", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(352, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(317, 76)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Adaptive Quantizers"
        '
        'BOXAQSTR
        '
        Me.BOXAQSTR.FormattingEnabled = True
        Me.BOXAQSTR.Items.AddRange(New Object() {"0.1", "0.2", "0.5", "0.6", "0.7", "0.8", "1.0", "1.2", "1.5"})
        Me.BOXAQSTR.Location = New System.Drawing.Point(88, 48)
        Me.BOXAQSTR.Name = "BOXAQSTR"
        Me.BOXAQSTR.Size = New System.Drawing.Size(121, 21)
        Me.BOXAQSTR.TabIndex = 10
        Me.BOXAQSTR.Text = "1.0"
        '
        'BOXAQMODE
        '
        Me.BOXAQMODE.FormattingEnabled = True
        Me.BOXAQMODE.Items.AddRange(New Object() {"1", "2", "3"})
        Me.BOXAQMODE.Location = New System.Drawing.Point(88, 24)
        Me.BOXAQMODE.Name = "BOXAQMODE"
        Me.BOXAQMODE.Size = New System.Drawing.Size(121, 21)
        Me.BOXAQMODE.TabIndex = 8
        Me.BOXAQMODE.Text = "1"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(11, 27)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(37, 13)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "Mode"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(12, 51)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(50, 13)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "Strength"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.NMDBTR)
        Me.GroupBox4.Controls.Add(Me.NMDBSTR)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Font = New System.Drawing.Font("맑은 고딕", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(352, 93)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(317, 49)
        Me.GroupBox4.TabIndex = 6
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "H.264 Deblocking"
        '
        'NMDBTR
        '
        Me.NMDBTR.Location = New System.Drawing.Point(165, 19)
        Me.NMDBTR.Maximum = New Decimal(New Integer() {6, 0, 0, 0})
        Me.NMDBTR.Minimum = New Decimal(New Integer() {6, 0, 0, -2147483648})
        Me.NMDBTR.Name = "NMDBTR"
        Me.NMDBTR.Size = New System.Drawing.Size(54, 22)
        Me.NMDBTR.TabIndex = 12
        '
        'NMDBSTR
        '
        Me.NMDBSTR.Location = New System.Drawing.Point(105, 19)
        Me.NMDBSTR.Maximum = New Decimal(New Integer() {6, 0, 0, 0})
        Me.NMDBSTR.Minimum = New Decimal(New Integer() {6, 0, 0, -2147483648})
        Me.NMDBSTR.Name = "NMDBSTR"
        Me.NMDBSTR.Size = New System.Drawing.Size(54, 22)
        Me.NMDBSTR.TabIndex = 11
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(13, 24)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(65, 13)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Deblocking"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("맑은 고딕", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Button1.Location = New System.Drawing.Point(348, 380)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Cancel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'AdvancedFRM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(674, 415)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1s)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "AdvancedFRM"
        Me.Text = "Advanced Encoding Options"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NMMERANGE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.NMDBTR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NMDBSTR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1s As System.Windows.Forms.Button
    Friend WithEvents BOXBFRAMES As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BOXSR As System.Windows.Forms.ComboBox
    Friend WithEvents BOXMEALGO As System.Windows.Forms.ComboBox
    Friend WithEvents NMMERANGE As System.Windows.Forms.NumericUpDown
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents BOXTR As System.Windows.Forms.ComboBox
    Friend WithEvents CHKNODCT As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents BOXAQSTR As System.Windows.Forms.ComboBox
    Friend WithEvents BOXAQMODE As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents NMDBTR As System.Windows.Forms.NumericUpDown
    Friend WithEvents NMDBSTR As System.Windows.Forms.NumericUpDown
    Friend WithEvents ComboBox6 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox5 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents BOXSCENE As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents BOXFADE As System.Windows.Forms.ComboBox
    Friend WithEvents CheckBox7 As System.Windows.Forms.CheckBox
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CHKNOPSKIP As System.Windows.Forms.CheckBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
End Class
