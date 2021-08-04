Public Class FRMDSHOW


    Private Sub BTNDSHOWOK_Click(sender As Object, e As EventArgs) Handles BTNDSHOWOK.Click
        Main.INPUTVIDNAME = "-rtbufsize 2000M -f dshow -i video=" + """" + BOXDSHOWVID.Text + """"
        Main.INPUTAUDFILENAME = ":audio=" + """" + BOXDSHOWAUD.Text + """"
        Main.InputCBOX.Text = " " + Main.INPUTVIDNAME + Main.INPUTAUDFILENAME + " -pix_fmt " + BOXPIXELFORMAT.Text
        Main.INPUTVIDNAME = ""
        Main.INPUTAUDFILENAME = ""
        Me.Hide()
    End Sub

    Private Sub BTSHOWFILTER_Click(sender As Object, e As EventArgs) Handles BTSHOWFILTER.Click
        Shell("cmd /c title Infinity Media Encoder & " + """" + Main.STARTUPPATH + "\Tools\ffmpeg32\ffmpeg.exe" + """" + " -list_devices true -f dshow -i dummy & pause", vbNormalFocus)
    End Sub
End Class