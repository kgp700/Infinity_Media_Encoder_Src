Public Class FRMDSHOW


    Private Sub BTNDSHOWOK_Click(sender As Object, e As EventArgs) Handles BTNDSHOWOK.Click
        Main.INPUTVIDNAME = "-rtbufsize 2000M -f dshow -i video=" + """" + BOXDSHOWVID.Text + """"
        Main.INPUTAUDFILENAME = " -f dshow -i audio=" + """" + BOXDSHOWAUD.Text + """" + " -pix_fmt " + BOXPIXELFORMAT.Text
        Main.InputCBOX.Text = " " + Main.INPUTVIDNAME + Main.INPUTAUDFILENAME
        Main.INPUTVIDNAME = ""
        Main.INPUTAUDFILENAME = ""
        Me.Hide()
    End Sub
End Class