<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMMULTISTREAM
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
        Me.LISTVIDEOSTREAM = New System.Windows.Forms.ListBox()
        Me.MAPVID = New System.Windows.Forms.ListBox()
        Me.MAPAUD = New System.Windows.Forms.ListBox()
        Me.LISTAUDIOSTREAM = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LISTVIDEOSTREAM
        '
        Me.LISTVIDEOSTREAM.AllowDrop = True
        Me.LISTVIDEOSTREAM.FormattingEnabled = True
        Me.LISTVIDEOSTREAM.HorizontalScrollbar = True
        Me.LISTVIDEOSTREAM.ItemHeight = 12
        Me.LISTVIDEOSTREAM.Location = New System.Drawing.Point(2, 30)
        Me.LISTVIDEOSTREAM.Name = "LISTVIDEOSTREAM"
        Me.LISTVIDEOSTREAM.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.LISTVIDEOSTREAM.Size = New System.Drawing.Size(513, 76)
        Me.LISTVIDEOSTREAM.TabIndex = 1
        '
        'MAPVID
        '
        Me.MAPVID.AllowDrop = True
        Me.MAPVID.FormattingEnabled = True
        Me.MAPVID.ItemHeight = 12
        Me.MAPVID.Location = New System.Drawing.Point(575, 30)
        Me.MAPVID.Name = "MAPVID"
        Me.MAPVID.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.MAPVID.Size = New System.Drawing.Size(65, 76)
        Me.MAPVID.TabIndex = 2
        '
        'MAPAUD
        '
        Me.MAPAUD.AllowDrop = True
        Me.MAPAUD.FormattingEnabled = True
        Me.MAPAUD.ItemHeight = 12
        Me.MAPAUD.Location = New System.Drawing.Point(575, 164)
        Me.MAPAUD.Name = "MAPAUD"
        Me.MAPAUD.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.MAPAUD.Size = New System.Drawing.Size(65, 76)
        Me.MAPAUD.TabIndex = 4
        '
        'LISTAUDIOSTREAM
        '
        Me.LISTAUDIOSTREAM.AllowDrop = True
        Me.LISTAUDIOSTREAM.FormattingEnabled = True
        Me.LISTAUDIOSTREAM.HorizontalScrollbar = True
        Me.LISTAUDIOSTREAM.ItemHeight = 12
        Me.LISTAUDIOSTREAM.Location = New System.Drawing.Point(2, 164)
        Me.LISTAUDIOSTREAM.Name = "LISTAUDIOSTREAM"
        Me.LISTAUDIOSTREAM.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.LISTAUDIOSTREAM.Size = New System.Drawing.Size(513, 76)
        Me.LISTAUDIOSTREAM.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(273, 246)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "OK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FRMMULTISTREAM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(652, 280)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MAPAUD)
        Me.Controls.Add(Me.LISTAUDIOSTREAM)
        Me.Controls.Add(Me.MAPVID)
        Me.Controls.Add(Me.LISTVIDEOSTREAM)
        Me.Name = "FRMMULTISTREAM"
        Me.Text = "MultiStream"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LISTVIDEOSTREAM As System.Windows.Forms.ListBox
    Friend WithEvents MAPVID As System.Windows.Forms.ListBox
    Friend WithEvents MAPAUD As System.Windows.Forms.ListBox
    Friend WithEvents LISTAUDIOSTREAM As System.Windows.Forms.ListBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
