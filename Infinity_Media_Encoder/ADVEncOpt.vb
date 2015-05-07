Public Class AdvancedFRM
    Public LBMERANGE As String
    Public LBMEALGORITHM As String
    Public LBSR As String
    Public LBTR As String
    Public LBNOPSKIP As String
    Public LBNODCT As String
    Public LBAQMODE As String
    Public LBBFRAMES As String
    Public LBAQSTR As String
    Public LBDEBLOCK As String
    Public LBFADE As String
    Public LBSCENE As String




    Private Sub Button1s_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1s.Click

        If CHKMERANGE.Checked Then
            LBMERANGE = ":merange=" + NMMERANGE.Text
        Else
            LBMERANGE = ""
        End If

        If CHKMEALGO.Checked Then
            LBMEALGORITHM = ":me=" + BOXMEALGO.Text
        Else
            LBMEALGORITHM = ""
        End If

        If CHKSR.Checked Then
            LBSR = ":subme=" + BOXSR.Text
        Else
            LBSR = ""
        End If

        If CHKTR.Checked Then
            LBTR = ":trellis=" + BOXTR.Text
        Else
            LBTR = ""
        End If

        If CHKNOPSKIP.Checked Then
            LBNOPSKIP = ":no-fast-pskip=1"
        Else
            LBNOPSKIP = ""
        End If

        If CHKNODCT.Checked Then
            LBNODCT = ":no-dct-decimate=1"
        Else
            LBNODCT = ""
        End If

        If CHKBFRAMES.Checked Then
            LBBFRAMES = ":bframes=" + BOXBFRAMES.Text
        Else
            LBBFRAMES = ""
        End If

        If CHKAQMODE.Checked Then
            LBAQMODE = ":aq-mode=" + BOXAQMODE.Text
        Else
            LBAQMODE = ""
        End If

        If CHKAQSTR.Checked Then
            LBAQSTR = ":aq-strength=" + BOXAQSTR.Text
        Else
            LBAQSTR = ""
        End If

        If CHKDEBLOCK.Checked Then
            LBDEBLOCK = " -deblock " + NMDBSTR.Text + ":" + NMDBTR.Text + " "
        Else
            LBDEBLOCK = ""
        End If

        If CHKFADE.Checked Then
            LBFADE = ":fade_compensate=" + BOXFADE.Text
        Else
            LBFADE = ""
        End If

        If CHKSCENE.Checked Then
            LBSCENE = ":scenecut=" + BOXSCENE.Text
        Else
            LBSCENE = ""
        End If


        Me.Hide()

    End Sub

    Private Sub BOXAQMODE_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BOXAQMODE.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub
End Class