<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMDSHOW
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
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.BOXDSHOWAUD = New System.Windows.Forms.ComboBox()
        Me.BOXDSHOWVID = New System.Windows.Forms.ComboBox()
        Me.BTNDSHOWOK = New System.Windows.Forms.Button()
        Me.BOXPIXELFORMAT = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.Button2)
        Me.GroupBox4.Controls.Add(Me.BOXDSHOWAUD)
        Me.GroupBox4.Controls.Add(Me.BOXDSHOWVID)
        Me.GroupBox4.Font = New System.Drawing.Font("Malgun Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(3, 4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(455, 74)
        Me.GroupBox4.TabIndex = 80
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "DirectShow Filter Input"
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.Location = New System.Drawing.Point(326, 32)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(118, 23)
        Me.Button2.TabIndex = 82
        Me.Button2.Text = "Auto Detect Filters"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'BOXDSHOWAUD
        '
        Me.BOXDSHOWAUD.AllowDrop = True
        Me.BOXDSHOWAUD.FormattingEnabled = True
        Me.BOXDSHOWAUD.Items.AddRange(New Object() {"FFsplit Playback Mixer"})
        Me.BOXDSHOWAUD.Location = New System.Drawing.Point(54, 46)
        Me.BOXDSHOWAUD.Name = "BOXDSHOWAUD"
        Me.BOXDSHOWAUD.Size = New System.Drawing.Size(266, 21)
        Me.BOXDSHOWAUD.TabIndex = 36
        Me.BOXDSHOWAUD.Text = "FFsplit Playback Mixer"
        '
        'BOXDSHOWVID
        '
        Me.BOXDSHOWVID.AllowDrop = True
        Me.BOXDSHOWVID.FormattingEnabled = True
        Me.BOXDSHOWVID.Items.AddRange(New Object() {"FFsource"})
        Me.BOXDSHOWVID.Location = New System.Drawing.Point(54, 20)
        Me.BOXDSHOWVID.Name = "BOXDSHOWVID"
        Me.BOXDSHOWVID.Size = New System.Drawing.Size(266, 21)
        Me.BOXDSHOWVID.TabIndex = 34
        Me.BOXDSHOWVID.Text = "FFsource"
        '
        'BTNDSHOWOK
        '
        Me.BTNDSHOWOK.Font = New System.Drawing.Font("Malgun Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.BTNDSHOWOK.Location = New System.Drawing.Point(193, 111)
        Me.BTNDSHOWOK.Name = "BTNDSHOWOK"
        Me.BTNDSHOWOK.Size = New System.Drawing.Size(75, 23)
        Me.BTNDSHOWOK.TabIndex = 81
        Me.BTNDSHOWOK.Text = "OK"
        Me.BTNDSHOWOK.UseVisualStyleBackColor = True
        '
        'BOXPIXELFORMAT
        '
        Me.BOXPIXELFORMAT.AllowDrop = True
        Me.BOXPIXELFORMAT.Font = New System.Drawing.Font("Malgun Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.BOXPIXELFORMAT.FormattingEnabled = True
        Me.BOXPIXELFORMAT.Items.AddRange(New Object() {"yuv420p"})
        Me.BOXPIXELFORMAT.Location = New System.Drawing.Point(88, 84)
        Me.BOXPIXELFORMAT.Name = "BOXPIXELFORMAT"
        Me.BOXPIXELFORMAT.Size = New System.Drawing.Size(359, 21)
        Me.BOXPIXELFORMAT.TabIndex = 82
        Me.BOXPIXELFORMAT.Text = "yuv420p"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Malgun Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label14.Location = New System.Drawing.Point(8, 87)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(70, 13)
        Me.Label14.TabIndex = 83
        Me.Label14.Text = "Pixel Format"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 83
        Me.Label1.Text = "Video"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 84
        Me.Label2.Text = "Audio"
        '
        'FRMDSHOW
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(463, 139)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.BOXPIXELFORMAT)
        Me.Controls.Add(Me.BTNDSHOWOK)
        Me.Controls.Add(Me.GroupBox4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRMDSHOW"
        Me.Text = "DShowSettings"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents BOXDSHOWAUD As System.Windows.Forms.ComboBox
    Friend WithEvents BOXDSHOWVID As System.Windows.Forms.ComboBox
    Friend WithEvents BTNDSHOWOK As System.Windows.Forms.Button
    Friend WithEvents BOXPIXELFORMAT As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
