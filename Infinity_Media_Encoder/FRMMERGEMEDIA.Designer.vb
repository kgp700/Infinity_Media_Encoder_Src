<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMMERGEMEDIA
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
        Me.LISTFILES = New System.Windows.Forms.ListBox()
        Me.BTNMERGE = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LISTFILES
        '
        Me.LISTFILES.AllowDrop = True
        Me.LISTFILES.FormattingEnabled = True
        Me.LISTFILES.HorizontalScrollbar = True
        Me.LISTFILES.ItemHeight = 12
        Me.LISTFILES.Location = New System.Drawing.Point(3, 3)
        Me.LISTFILES.Name = "LISTFILES"
        Me.LISTFILES.Size = New System.Drawing.Size(592, 292)
        Me.LISTFILES.TabIndex = 0
        '
        'BTNMERGE
        '
        Me.BTNMERGE.Location = New System.Drawing.Point(5, 310)
        Me.BTNMERGE.Name = "BTNMERGE"
        Me.BTNMERGE.Size = New System.Drawing.Size(124, 23)
        Me.BTNMERGE.TabIndex = 1
        Me.BTNMERGE.Text = "Merge"
        Me.BTNMERGE.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(135, 310)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(124, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Delete Selected"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(265, 310)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(124, 23)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Clear List"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'FRMMERGEMEDIA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(597, 340)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.BTNMERGE)
        Me.Controls.Add(Me.LISTFILES)
        Me.Name = "FRMMERGEMEDIA"
        Me.Text = "FRMMERGEMEDIA"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LISTFILES As ListBox
    Friend WithEvents BTNMERGE As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
