<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Contconv
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.OutputCBox = New System.Windows.Forms.ComboBox()
        Me.InputCBOX = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 12)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Output File Path"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 12)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Input File Path"
        '
        'OutputCBox
        '
        Me.OutputCBox.AllowDrop = True
        Me.OutputCBox.FormattingEnabled = True
        Me.OutputCBox.Location = New System.Drawing.Point(12, 94)
        Me.OutputCBox.Name = "OutputCBox"
        Me.OutputCBox.Size = New System.Drawing.Size(371, 20)
        Me.OutputCBox.TabIndex = 26
        '
        'InputCBOX
        '
        Me.InputCBOX.AllowDrop = True
        Me.InputCBOX.Font = New System.Drawing.Font("굴림", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.InputCBOX.FormattingEnabled = True
        Me.InputCBOX.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.InputCBOX.Location = New System.Drawing.Point(12, 44)
        Me.InputCBOX.Name = "InputCBOX"
        Me.InputCBOX.Size = New System.Drawing.Size(371, 20)
        Me.InputCBOX.TabIndex = 25
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(389, 90)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(85, 26)
        Me.Button2.TabIndex = 24
        Me.Button2.Text = "Output"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(389, 40)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(85, 26)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "Input"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(150, 136)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(183, 26)
        Me.Button3.TabIndex = 29
        Me.Button3.Text = "Convert to Video file"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(150, 178)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(183, 26)
        Me.Button4.TabIndex = 30
        Me.Button4.Text = "Convert to Audio file"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Contconv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(483, 216)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.OutputCBox)
        Me.Controls.Add(Me.InputCBOX)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Contconv"
        Me.Text = "Media Container Converter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents OutputCBox As System.Windows.Forms.ComboBox
    Friend WithEvents InputCBOX As System.Windows.Forms.ComboBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
End Class
