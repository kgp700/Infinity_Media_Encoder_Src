Public Class FRMCUSTOMENC

    Dim BOXCUSTOMCODECOPTTEXT As String
    Dim CUSTOMVIDEOFILTERTEXT As String
    Dim CUSTOMFFMPEGOPTTEXT As String
    Dim CUSTOMFFMPEGOPTTEXTF As String

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        If Not BOXCUSTOMCODECOPT.Text = "" Then
            Main.CUSTOMCODECOPT = ":" + BOXCUSTOMCODECOPT.Text
            BOXCUSTOMCODECOPTTEXT = BOXCUSTOMCODECOPT.Text
        Else
            Main.CUSTOMCODECOPT = BOXCUSTOMCODECOPT.Text
            BOXCUSTOMCODECOPTTEXT = BOXCUSTOMCODECOPT.Text
        End If

        If Not BOXCUSTOMVFILTEROPT.Text = "" Then
            Main.CUSTOMVIDEOFILTER = "," + BOXCUSTOMVFILTEROPT.Text
            CUSTOMVIDEOFILTERTEXT = BOXCUSTOMVFILTEROPT.Text
        Else
            Main.CUSTOMVIDEOFILTER = BOXCUSTOMVFILTEROPT.Text
            CUSTOMVIDEOFILTERTEXT = BOXCUSTOMVFILTEROPT.Text
        End If

        If Not BOXCUSTOMFFMPEGOPT.Text = "" Then
            Main.CUSTOMFFMPEGOPT = " " + BOXCUSTOMFFMPEGOPT.Text + " "
            CUSTOMFFMPEGOPTTEXT = BOXCUSTOMFFMPEGOPT.Text
        Else
            Main.CUSTOMFFMPEGOPT = BOXCUSTOMFFMPEGOPT.Text
            CUSTOMFFMPEGOPTTEXT = BOXCUSTOMFFMPEGOPT.Text
        End If

        If Not BOXCUSTOMFFMPEGOPTF.Text = "" Then
            Main.CUSTOMFFMPEGOPTF = " " + BOXCUSTOMFFMPEGOPTF.Text + " "
            CUSTOMFFMPEGOPTTEXTF = BOXCUSTOMFFMPEGOPTF.Text
        Else
            Main.CUSTOMFFMPEGOPTF = BOXCUSTOMFFMPEGOPTF.Text
            CUSTOMFFMPEGOPTTEXTF = BOXCUSTOMFFMPEGOPTF.Text
        End If

        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click

        BOXCUSTOMCODECOPT.Text = BOXCUSTOMCODECOPTTEXT
        BOXCUSTOMVFILTEROPT.Text = CUSTOMVIDEOFILTERTEXT
        BOXCUSTOMFFMPEGOPT.Text = CUSTOMFFMPEGOPTTEXT
        Me.Hide()
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub
End Class