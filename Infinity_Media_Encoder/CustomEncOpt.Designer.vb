<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMCUSTOMENC
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
        Me.BOXCUSTOMCODECOPT = New System.Windows.Forms.TextBox()
        Me.BOXCUSTOMVFILTEROPT = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BOXCUSTOMFFMPEGOPT = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BOXCUSTOMFFMPEGOPTF = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'BOXCUSTOMCODECOPT
        '
        Me.BOXCUSTOMCODECOPT.Font = New System.Drawing.Font("맑은 고딕", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.BOXCUSTOMCODECOPT.Location = New System.Drawing.Point(10, 30)
        Me.BOXCUSTOMCODECOPT.Name = "BOXCUSTOMCODECOPT"
        Me.BOXCUSTOMCODECOPT.Size = New System.Drawing.Size(465, 22)
        Me.BOXCUSTOMCODECOPT.TabIndex = 0
        '
        'BOXCUSTOMVFILTEROPT
        '
        Me.BOXCUSTOMVFILTEROPT.Font = New System.Drawing.Font("맑은 고딕", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.BOXCUSTOMVFILTEROPT.Location = New System.Drawing.Point(10, 79)
        Me.BOXCUSTOMVFILTEROPT.Name = "BOXCUSTOMVFILTEROPT"
        Me.BOXCUSTOMVFILTEROPT.Size = New System.Drawing.Size(465, 22)
        Me.BOXCUSTOMVFILTEROPT.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("맑은 고딕", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(405, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Custom Codec Encoding Options (FFmpeg libx264, libx265 codec parameter) "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("맑은 고딕", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(279, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Custom Video Filter (FFmpeg Video Filter parameter)"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("맑은 고딕", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Button1.Location = New System.Drawing.Point(163, 220)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(64, 25)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "OK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("맑은 고딕", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(242, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Custom FFmpeg Options (FFmpeg parameter)"
        '
        'BOXCUSTOMFFMPEGOPT
        '
        Me.BOXCUSTOMFFMPEGOPT.Font = New System.Drawing.Font("맑은 고딕", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.BOXCUSTOMFFMPEGOPT.Location = New System.Drawing.Point(10, 130)
        Me.BOXCUSTOMFFMPEGOPT.Name = "BOXCUSTOMFFMPEGOPT"
        Me.BOXCUSTOMFFMPEGOPT.Size = New System.Drawing.Size(465, 22)
        Me.BOXCUSTOMFFMPEGOPT.TabIndex = 5
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("맑은 고딕", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Button2.Location = New System.Drawing.Point(248, 220)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(64, 25)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("맑은 고딕", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 166)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(323, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Custom FFmpeg Options (FFmpeg parameter - front of input)"
        '
        'BOXCUSTOMFFMPEGOPTF
        '
        Me.BOXCUSTOMFFMPEGOPTF.Font = New System.Drawing.Font("맑은 고딕", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.BOXCUSTOMFFMPEGOPTF.Location = New System.Drawing.Point(11, 182)
        Me.BOXCUSTOMFFMPEGOPTF.Name = "BOXCUSTOMFFMPEGOPTF"
        Me.BOXCUSTOMFFMPEGOPTF.Size = New System.Drawing.Size(465, 22)
        Me.BOXCUSTOMFFMPEGOPTF.TabIndex = 8
        '
        'FRMCUSTOMENC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(489, 257)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BOXCUSTOMFFMPEGOPTF)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BOXCUSTOMFFMPEGOPT)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BOXCUSTOMVFILTEROPT)
        Me.Controls.Add(Me.BOXCUSTOMCODECOPT)
        Me.Font = New System.Drawing.Font("맑은 고딕", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FRMCUSTOMENC"
        Me.Text = "Custom Encoding Parameters"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BOXCUSTOMCODECOPT As System.Windows.Forms.TextBox
    Friend WithEvents BOXCUSTOMVFILTEROPT As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BOXCUSTOMFFMPEGOPT As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents BOXCUSTOMFFMPEGOPTF As System.Windows.Forms.TextBox
End Class
