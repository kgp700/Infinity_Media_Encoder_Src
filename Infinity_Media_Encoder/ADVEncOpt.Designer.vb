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
        Me.CHKBFRAMES = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CheckBox7 = New System.Windows.Forms.CheckBox()
        Me.BOXSR = New System.Windows.Forms.ComboBox()
        Me.BOXMEALGO = New System.Windows.Forms.ComboBox()
        Me.NMMERANGE = New System.Windows.Forms.NumericUpDown()
        Me.CHKSR = New System.Windows.Forms.CheckBox()
        Me.CHKMEALGO = New System.Windows.Forms.CheckBox()
        Me.CHKMERANGE = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox8 = New System.Windows.Forms.CheckBox()
        Me.BOXFADE = New System.Windows.Forms.ComboBox()
        Me.CHKFADE = New System.Windows.Forms.CheckBox()
        Me.CheckBox6 = New System.Windows.Forms.CheckBox()
        Me.ComboBox6 = New System.Windows.Forms.ComboBox()
        Me.CheckBox5 = New System.Windows.Forms.CheckBox()
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.CHKSCENE = New System.Windows.Forms.CheckBox()
        Me.BOXSCENE = New System.Windows.Forms.ComboBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.BOXTR = New System.Windows.Forms.ComboBox()
        Me.CHKTR = New System.Windows.Forms.CheckBox()
        Me.CHKNODCT = New System.Windows.Forms.CheckBox()
        Me.CHKNOPSKIP = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.BOXAQSTR = New System.Windows.Forms.ComboBox()
        Me.CHKAQSTR = New System.Windows.Forms.CheckBox()
        Me.BOXAQMODE = New System.Windows.Forms.ComboBox()
        Me.CHKAQMODE = New System.Windows.Forms.CheckBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.NMDBTR = New System.Windows.Forms.NumericUpDown()
        Me.NMDBSTR = New System.Windows.Forms.NumericUpDown()
        Me.CHKDEBLOCK = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
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
        Me.BOXBFRAMES.Location = New System.Drawing.Point(106, 215)
        Me.BOXBFRAMES.Name = "BOXBFRAMES"
        Me.BOXBFRAMES.Size = New System.Drawing.Size(125, 21)
        Me.BOXBFRAMES.TabIndex = 1
        Me.BOXBFRAMES.Text = "3"
        '
        'CHKBFRAMES
        '
        Me.CHKBFRAMES.AutoSize = True
        Me.CHKBFRAMES.Checked = True
        Me.CHKBFRAMES.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CHKBFRAMES.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.CHKBFRAMES.Location = New System.Drawing.Point(14, 219)
        Me.CHKBFRAMES.Name = "CHKBFRAMES"
        Me.CHKBFRAMES.Size = New System.Drawing.Size(74, 19)
        Me.CHKBFRAMES.TabIndex = 2
        Me.CHKBFRAMES.Text = "B-frames"
        Me.CHKBFRAMES.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckBox7)
        Me.GroupBox1.Controls.Add(Me.BOXSR)
        Me.GroupBox1.Controls.Add(Me.BOXMEALGO)
        Me.GroupBox1.Controls.Add(Me.NMMERANGE)
        Me.GroupBox1.Controls.Add(Me.CHKSR)
        Me.GroupBox1.Controls.Add(Me.CHKMEALGO)
        Me.GroupBox1.Controls.Add(Me.CHKMERANGE)
        Me.GroupBox1.Font = New System.Drawing.Font("맑은 고딕", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(352, 149)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(317, 122)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Motion Estimation"
        '
        'CheckBox7
        '
        Me.CheckBox7.AutoSize = True
        Me.CheckBox7.Checked = True
        Me.CheckBox7.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox7.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.CheckBox7.Location = New System.Drawing.Point(14, 96)
        Me.CheckBox7.Name = "CheckBox7"
        Me.CheckBox7.Size = New System.Drawing.Size(96, 19)
        Me.CheckBox7.TabIndex = 6
        Me.CheckBox7.Text = "Chroma M.E."
        Me.CheckBox7.UseVisualStyleBackColor = True
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
        Me.NMMERANGE.Name = "NMMERANGE"
        Me.NMMERANGE.Size = New System.Drawing.Size(54, 22)
        Me.NMMERANGE.TabIndex = 3
        Me.NMMERANGE.Value = New Decimal(New Integer() {16, 0, 0, 0})
        '
        'CHKSR
        '
        Me.CHKSR.AutoSize = True
        Me.CHKSR.Checked = True
        Me.CHKSR.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CHKSR.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.CHKSR.Location = New System.Drawing.Point(14, 71)
        Me.CHKSR.Name = "CHKSR"
        Me.CHKSR.Size = New System.Drawing.Size(137, 19)
        Me.CHKSR.TabIndex = 2
        Me.CHKSR.Text = "Subpixel Refinement"
        Me.CHKSR.UseVisualStyleBackColor = True
        '
        'CHKMEALGO
        '
        Me.CHKMEALGO.AutoSize = True
        Me.CHKMEALGO.Checked = True
        Me.CHKMEALGO.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CHKMEALGO.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.CHKMEALGO.Location = New System.Drawing.Point(14, 46)
        Me.CHKMEALGO.Name = "CHKMEALGO"
        Me.CHKMEALGO.Size = New System.Drawing.Size(107, 19)
        Me.CHKMEALGO.TabIndex = 1
        Me.CHKMEALGO.Text = "M.E. Algorithm"
        Me.CHKMEALGO.UseVisualStyleBackColor = True
        '
        'CHKMERANGE
        '
        Me.CHKMERANGE.AutoSize = True
        Me.CHKMERANGE.Checked = True
        Me.CHKMERANGE.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CHKMERANGE.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.CHKMERANGE.Location = New System.Drawing.Point(14, 20)
        Me.CHKMERANGE.Name = "CHKMERANGE"
        Me.CHKMERANGE.Size = New System.Drawing.Size(86, 19)
        Me.CHKMERANGE.TabIndex = 0
        Me.CHKMERANGE.Text = "M.E. Range"
        Me.CHKMERANGE.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ComboBox3)
        Me.GroupBox2.Controls.Add(Me.CheckBox3)
        Me.GroupBox2.Controls.Add(Me.CheckBox8)
        Me.GroupBox2.Controls.Add(Me.BOXFADE)
        Me.GroupBox2.Controls.Add(Me.CHKFADE)
        Me.GroupBox2.Controls.Add(Me.CheckBox6)
        Me.GroupBox2.Controls.Add(Me.ComboBox6)
        Me.GroupBox2.Controls.Add(Me.CheckBox5)
        Me.GroupBox2.Controls.Add(Me.ComboBox5)
        Me.GroupBox2.Controls.Add(Me.CheckBox4)
        Me.GroupBox2.Controls.Add(Me.ComboBox4)
        Me.GroupBox2.Controls.Add(Me.CHKSCENE)
        Me.GroupBox2.Controls.Add(Me.BOXSCENE)
        Me.GroupBox2.Controls.Add(Me.CheckBox2)
        Me.GroupBox2.Controls.Add(Me.ComboBox2)
        Me.GroupBox2.Controls.Add(Me.CheckBox1)
        Me.GroupBox2.Controls.Add(Me.ComboBox1)
        Me.GroupBox2.Controls.Add(Me.BOXTR)
        Me.GroupBox2.Controls.Add(Me.CHKTR)
        Me.GroupBox2.Controls.Add(Me.CHKBFRAMES)
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
        'ComboBox3
        '
        Me.ComboBox3.Enabled = False
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"0.0", "0.5", "1.0"})
        Me.ComboBox3.Location = New System.Drawing.Point(150, 47)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(125, 21)
        Me.ComboBox3.TabIndex = 23
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Checked = True
        Me.CheckBox3.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox3.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.CheckBox3.Location = New System.Drawing.Point(14, 324)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(94, 19)
        Me.CheckBox3.TabIndex = 21
        Me.CheckBox3.Text = "Use MB-Tree"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox8
        '
        Me.CheckBox8.AutoSize = True
        Me.CheckBox8.Checked = True
        Me.CheckBox8.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox8.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.CheckBox8.Location = New System.Drawing.Point(14, 48)
        Me.CheckBox8.Name = "CheckBox8"
        Me.CheckBox8.Size = New System.Drawing.Size(115, 19)
        Me.CheckBox8.TabIndex = 22
        Me.CheckBox8.Text = "Psy-RD Strength"
        Me.CheckBox8.UseVisualStyleBackColor = True
        '
        'BOXFADE
        '
        Me.BOXFADE.FormattingEnabled = True
        Me.BOXFADE.Items.AddRange(New Object() {"0.0", "0.5", "1.0"})
        Me.BOXFADE.Location = New System.Drawing.Point(150, 298)
        Me.BOXFADE.Name = "BOXFADE"
        Me.BOXFADE.Size = New System.Drawing.Size(125, 21)
        Me.BOXFADE.TabIndex = 20
        Me.BOXFADE.Text = "1.0"
        '
        'CHKFADE
        '
        Me.CHKFADE.AutoSize = True
        Me.CHKFADE.Checked = True
        Me.CHKFADE.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CHKFADE.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.CHKFADE.Location = New System.Drawing.Point(14, 299)
        Me.CHKFADE.Name = "CHKFADE"
        Me.CHKFADE.Size = New System.Drawing.Size(122, 19)
        Me.CHKFADE.TabIndex = 19
        Me.CHKFADE.Text = "Fade Compensate"
        Me.CHKFADE.UseVisualStyleBackColor = True
        '
        'CheckBox6
        '
        Me.CheckBox6.AutoSize = True
        Me.CheckBox6.Checked = True
        Me.CheckBox6.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox6.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.CheckBox6.Location = New System.Drawing.Point(14, 273)
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.Size = New System.Drawing.Size(82, 19)
        Me.CheckBox6.TabIndex = 18
        Me.CheckBox6.Text = "B-Pyramid"
        Me.CheckBox6.UseVisualStyleBackColor = True
        '
        'ComboBox6
        '
        Me.ComboBox6.Enabled = False
        Me.ComboBox6.FormattingEnabled = True
        Me.ComboBox6.Location = New System.Drawing.Point(150, 272)
        Me.ComboBox6.Name = "ComboBox6"
        Me.ComboBox6.Size = New System.Drawing.Size(125, 21)
        Me.ComboBox6.TabIndex = 17
        Me.ComboBox6.Text = "Normal"
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.Checked = True
        Me.CheckBox5.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox5.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.CheckBox5.Location = New System.Drawing.Point(14, 246)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(125, 19)
        Me.CheckBox5.TabIndex = 16
        Me.CheckBox5.Text = "Adapted B-Frames"
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'ComboBox5
        '
        Me.ComboBox5.Enabled = False
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.Location = New System.Drawing.Point(150, 246)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(125, 21)
        Me.ComboBox5.TabIndex = 15
        Me.ComboBox5.Text = "Smart"
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Checked = True
        Me.CheckBox4.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox4.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.CheckBox4.Location = New System.Drawing.Point(14, 192)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(182, 19)
        Me.CheckBox4.TabIndex = 14
        Me.CheckBox4.Text = "P-frame Weighted Prediction"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'ComboBox4
        '
        Me.ComboBox4.Enabled = False
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(205, 190)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(125, 21)
        Me.ComboBox4.TabIndex = 13
        Me.ComboBox4.Text = "2-Optimal"
        '
        'CHKSCENE
        '
        Me.CHKSCENE.AutoSize = True
        Me.CHKSCENE.Checked = True
        Me.CHKSCENE.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CHKSCENE.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.CHKSCENE.Location = New System.Drawing.Point(14, 167)
        Me.CHKSCENE.Name = "CHKSCENE"
        Me.CHKSCENE.Size = New System.Drawing.Size(75, 19)
        Me.CHKSCENE.TabIndex = 12
        Me.CHKSCENE.Text = "Scenecut"
        Me.CHKSCENE.UseVisualStyleBackColor = True
        '
        'BOXSCENE
        '
        Me.BOXSCENE.FormattingEnabled = True
        Me.BOXSCENE.Items.AddRange(New Object() {"40", "50", "60", "70", "100"})
        Me.BOXSCENE.Location = New System.Drawing.Point(106, 163)
        Me.BOXSCENE.Name = "BOXSCENE"
        Me.BOXSCENE.Size = New System.Drawing.Size(125, 21)
        Me.BOXSCENE.TabIndex = 11
        Me.BOXSCENE.Text = "40"
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Checked = True
        Me.CheckBox2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox2.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.CheckBox2.Location = New System.Drawing.Point(14, 142)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(84, 19)
        Me.CheckBox2.TabIndex = 10
        Me.CheckBox2.Text = "Lookahead"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'ComboBox2
        '
        Me.ComboBox2.Enabled = False
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(106, 140)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(125, 21)
        Me.ComboBox2.TabIndex = 9
        Me.ComboBox2.Text = "40"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(14, 116)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(132, 19)
        Me.CheckBox1.TabIndex = 8
        Me.CheckBox1.Text = "MV Prediction mod"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"1", "2", "3"})
        Me.ComboBox1.Location = New System.Drawing.Point(150, 114)
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
        'CHKTR
        '
        Me.CHKTR.AutoSize = True
        Me.CHKTR.Checked = True
        Me.CHKTR.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CHKTR.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.CHKTR.Location = New System.Drawing.Point(14, 24)
        Me.CHKTR.Name = "CHKTR"
        Me.CHKTR.Size = New System.Drawing.Size(56, 19)
        Me.CHKTR.TabIndex = 3
        Me.CHKTR.Text = "Trellis"
        Me.CHKTR.UseVisualStyleBackColor = True
        '
        'CHKNODCT
        '
        Me.CHKNODCT.AutoSize = True
        Me.CHKNODCT.Checked = True
        Me.CHKNODCT.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CHKNODCT.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.CHKNODCT.Location = New System.Drawing.Point(14, 92)
        Me.CHKNODCT.Name = "CHKNODCT"
        Me.CHKNODCT.Size = New System.Drawing.Size(131, 19)
        Me.CHKNODCT.TabIndex = 2
        Me.CHKNODCT.Text = "No Dct Decimation"
        Me.CHKNODCT.UseVisualStyleBackColor = True
        '
        'CHKNOPSKIP
        '
        Me.CHKNOPSKIP.AutoSize = True
        Me.CHKNOPSKIP.Checked = True
        Me.CHKNOPSKIP.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CHKNOPSKIP.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.CHKNOPSKIP.Location = New System.Drawing.Point(14, 70)
        Me.CHKNOPSKIP.Name = "CHKNOPSKIP"
        Me.CHKNOPSKIP.Size = New System.Drawing.Size(106, 19)
        Me.CHKNOPSKIP.TabIndex = 1
        Me.CHKNOPSKIP.Text = "No Fast P-Skip"
        Me.CHKNOPSKIP.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.BOXAQSTR)
        Me.GroupBox3.Controls.Add(Me.CHKAQSTR)
        Me.GroupBox3.Controls.Add(Me.BOXAQMODE)
        Me.GroupBox3.Controls.Add(Me.CHKAQMODE)
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
        'CHKAQSTR
        '
        Me.CHKAQSTR.AutoSize = True
        Me.CHKAQSTR.Checked = True
        Me.CHKAQSTR.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CHKAQSTR.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.CHKAQSTR.Location = New System.Drawing.Point(14, 52)
        Me.CHKAQSTR.Name = "CHKAQSTR"
        Me.CHKAQSTR.Size = New System.Drawing.Size(72, 19)
        Me.CHKAQSTR.TabIndex = 9
        Me.CHKAQSTR.Text = "Strength"
        Me.CHKAQSTR.UseVisualStyleBackColor = True
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
        'CHKAQMODE
        '
        Me.CHKAQMODE.AutoSize = True
        Me.CHKAQMODE.Checked = True
        Me.CHKAQMODE.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CHKAQMODE.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.CHKAQMODE.Location = New System.Drawing.Point(14, 26)
        Me.CHKAQMODE.Name = "CHKAQMODE"
        Me.CHKAQMODE.Size = New System.Drawing.Size(57, 19)
        Me.CHKAQMODE.TabIndex = 7
        Me.CHKAQMODE.Text = "Mode"
        Me.CHKAQMODE.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.NMDBTR)
        Me.GroupBox4.Controls.Add(Me.NMDBSTR)
        Me.GroupBox4.Controls.Add(Me.CHKDEBLOCK)
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
        Me.NMDBTR.Maximum = New Decimal(New Integer() {4, 0, 0, 0})
        Me.NMDBTR.Minimum = New Decimal(New Integer() {4, 0, 0, -2147483648})
        Me.NMDBTR.Name = "NMDBTR"
        Me.NMDBTR.Size = New System.Drawing.Size(54, 22)
        Me.NMDBTR.TabIndex = 12
        '
        'NMDBSTR
        '
        Me.NMDBSTR.Location = New System.Drawing.Point(105, 19)
        Me.NMDBSTR.Maximum = New Decimal(New Integer() {4, 0, 0, 0})
        Me.NMDBSTR.Minimum = New Decimal(New Integer() {4, 0, 0, -2147483648})
        Me.NMDBSTR.Name = "NMDBSTR"
        Me.NMDBSTR.Size = New System.Drawing.Size(54, 22)
        Me.NMDBSTR.TabIndex = 11
        '
        'CHKDEBLOCK
        '
        Me.CHKDEBLOCK.AutoSize = True
        Me.CHKDEBLOCK.Checked = True
        Me.CHKDEBLOCK.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CHKDEBLOCK.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.CHKDEBLOCK.Location = New System.Drawing.Point(14, 20)
        Me.CHKDEBLOCK.Name = "CHKDEBLOCK"
        Me.CHKDEBLOCK.Size = New System.Drawing.Size(87, 19)
        Me.CHKDEBLOCK.TabIndex = 10
        Me.CHKDEBLOCK.Text = "Deblocking"
        Me.CHKDEBLOCK.UseVisualStyleBackColor = True
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
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("맑은 고딕", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Button2.Location = New System.Drawing.Point(429, 380)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Load"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'AdvancedFRM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(674, 415)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1s)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
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
    Friend WithEvents CHKBFRAMES As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BOXSR As System.Windows.Forms.ComboBox
    Friend WithEvents BOXMEALGO As System.Windows.Forms.ComboBox
    Friend WithEvents NMMERANGE As System.Windows.Forms.NumericUpDown
    Friend WithEvents CHKSR As System.Windows.Forms.CheckBox
    Friend WithEvents CHKMEALGO As System.Windows.Forms.CheckBox
    Friend WithEvents CHKMERANGE As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents BOXTR As System.Windows.Forms.ComboBox
    Friend WithEvents CHKTR As System.Windows.Forms.CheckBox
    Friend WithEvents CHKNODCT As System.Windows.Forms.CheckBox
    Friend WithEvents CHKNOPSKIP As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents BOXAQSTR As System.Windows.Forms.ComboBox
    Friend WithEvents CHKAQSTR As System.Windows.Forms.CheckBox
    Friend WithEvents BOXAQMODE As System.Windows.Forms.ComboBox
    Friend WithEvents CHKAQMODE As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents NMDBTR As System.Windows.Forms.NumericUpDown
    Friend WithEvents NMDBSTR As System.Windows.Forms.NumericUpDown
    Friend WithEvents CHKDEBLOCK As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox6 As System.Windows.Forms.CheckBox
    Friend WithEvents ComboBox6 As System.Windows.Forms.ComboBox
    Friend WithEvents CheckBox5 As System.Windows.Forms.CheckBox
    Friend WithEvents ComboBox5 As System.Windows.Forms.ComboBox
    Friend WithEvents CheckBox4 As System.Windows.Forms.CheckBox
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents CHKSCENE As System.Windows.Forms.CheckBox
    Friend WithEvents BOXSCENE As System.Windows.Forms.ComboBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents BOXFADE As System.Windows.Forms.ComboBox
    Friend WithEvents CHKFADE As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox7 As System.Windows.Forms.CheckBox
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox8 As System.Windows.Forms.CheckBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
