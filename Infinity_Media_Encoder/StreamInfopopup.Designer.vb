<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StreamInfopopup
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
        Me.LBSTREAMINFOP = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LBSTREAMINFOP
        '
        Me.LBSTREAMINFOP.AutoSize = True
        Me.LBSTREAMINFOP.Font = New System.Drawing.Font("맑은 고딕", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.LBSTREAMINFOP.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LBSTREAMINFOP.Location = New System.Drawing.Point(3, 5)
        Me.LBSTREAMINFOP.Margin = New System.Windows.Forms.Padding(0)
        Me.LBSTREAMINFOP.Name = "LBSTREAMINFOP"
        Me.LBSTREAMINFOP.Size = New System.Drawing.Size(125, 20)
        Me.LBSTREAMINFOP.TabIndex = 0
        Me.LBSTREAMINFOP.Text = "LBSTREAMINFOP"
        '
        'StreamInfopopup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(899, 35)
        Me.Controls.Add(Me.LBSTREAMINFOP)
        Me.Font = New System.Drawing.Font("맑은 고딕", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "StreamInfopopup"
        Me.Text = "StreamInfopopup - Infinity Media Encoder by KGP"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LBSTREAMINFOP As Label
End Class
