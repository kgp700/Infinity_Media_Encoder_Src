Imports System.Text
Imports System.Text.RegularExpressions

Public Class AvisynthOpt
    Private FPSNUM As String
    Private FPSDEN As String


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim utf8WithoutBom As New System.Text.UTF8Encoding(False)
        Dim FILE_NAME As String = Main.InputCBOX.Text
        If Regex.IsMatch(FILE_NAME, "\p{IsThai}") Or Regex.IsMatch(FILE_NAME, "\p{IsArabic}") Or Regex.IsMatch(FILE_NAME, "\p{IsLatin-1Supplement}") Or Regex.IsMatch(FILE_NAME, "\p{IsGreek}") Or
            Regex.IsMatch(FILE_NAME, "\p{IsLatinExtended-A}") Or Regex.IsMatch(FILE_NAME, "\p{IsLatinExtended-B}") Then
            MsgBox("Avisynth do not support some unicode language file name. please change input file name to english", vbCritical)
            Dim Writer As System.IO.StreamWriter
            Dim Encode As System.Text.Encoding
            Encode = System.Text.Encoding.Default
            Writer = New System.IO.StreamWriter(FILE_NAME + ".avs", False, Encode)
            Writer.Write(BOXAVSSCRIPT.Text)
            Writer.Close()
            MsgBox("AVS Script writen to file")
        Else
            Dim Writer As System.IO.StreamWriter
            Dim Encode As System.Text.Encoding
            Encode = System.Text.Encoding.Default
            Writer = New System.IO.StreamWriter(FILE_NAME + ".avs", False, Encode)
            Writer.Write(BOXAVSSCRIPT.Text)
            Writer.Close()
            MsgBox("AVS Script writen to file")
        End If







        If RDBDGINDEX.Checked = True Then
            Dim p As New Process

            With p.StartInfo
                .WindowStyle = ProcessWindowStyle.Normal
                .Arguments = "/c title Infinity Media Encoder & .\avisynthPlugins\dgindex -i " + """" + Main.INPUTFILENAME2 + """" + " -o " + """" + Main.INPUTFILENAME2 + """" + " -fo 0 -om 2 -exit"
                .FileName = "cmd"

                .UseShellExecute = False
                .CreateNoWindow = False


            End With
            p.Start()
        ElseIf RDBFFMS2.Checked = True Then
            Dim p As New Process

            With p.StartInfo
                .WindowStyle = ProcessWindowStyle.Normal
                .Arguments = "/c title Infinity Media Encoder & .\avisynthPlugins\ffmsindex -t -1 -f " + """" + Main.INPUTFILENAME2 + """"
                .FileName = "cmd"

                .UseShellExecute = False
                .CreateNoWindow = False


            End With
            p.Start()
        End If
        FPSNUM = ""
        FPSDEN = ""


        Me.Hide()

    End Sub

    Private Sub BOXAVSSCRIPT_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles BOXAVSSCRIPT.VisibleChanged
        prepareScript()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click


        Dim FILE_NAME As String = Main.InputCBOX.Text + ".avs"

        Dim Writer As IO.StreamWriter
        Dim Encode As System.Text.Encoding
        Encode = System.Text.Encoding.Default
        Writer = New IO.StreamWriter(FILE_NAME, False, Encode)

        Writer.Write(BOXAVSSCRIPT.Text)
        Writer.Close()
        MsgBox("AVS Script writen to file")

        If My.Computer.FileSystem.FileExists(Main.InputCBOX.Text + ".avs") Then
            ToolStripStatusLabel1.Text = "AVS File loaded"
            Dim fileReader As String
            fileReader = My.Computer.FileSystem.ReadAllText(Main.InputCBOX.Text + ".avs", System.Text.Encoding.Default)
            BOXAVSSCRIPT.Text = fileReader
        Else
            ToolStripStatusLabel1.Text = "Do not have AVS File"
        End If
        FPSNUM = ""
        FPSDEN = ""
    End Sub

    Private Sub CHKAVSMT_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHKAVSMT.CheckedChanged
        If BOXAVSSCRIPT.Text.Contains("#SETMTMODE") And CHKAVSMT.Checked = True Then
            BOXAVSSCRIPT.Text = BOXAVSSCRIPT.Text.Replace("#SETMTMODE", "SetMTmode(5,16)")
        Else

        End If


    End Sub


    Private Sub RDBFFMS2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RDBFFMS2.CheckedChanged
        prepareScript()
    End Sub

    Public Function prepareScript() As String()


        If RDBDGINDEX.Checked = True And Not My.Computer.FileSystem.FileExists(Main.InputCBOX.Text + ".avs") Then
            BOXAVSSCRIPT.Text = "#SETMTMODE" + vbCrLf +
            "LoadPlugin(" + """" + "appdirectory0703\avisynthPlugins\DGDecode.dll" + """" + ")" + vbCrLf +
            "DGDecode_mpeg2source(" + """" + "INPUTFILECODEABS07" + """" + ", cpu = 0, info = 3)" + vbCrLf +
            "LoadPlugin(" + """" + "appdirectory0703\avisynthPlugins\ColorMatrix.dll" + """" + ")" + vbCrLf +
            "ColorMatrix(hints = True, interlaced = True, threads = 0)" + vbCrLf +
            "#NOISEFILTER" + vbCrLf

            If BOXAVSSCRIPT.Text.Contains("INPUTFILECODEABS07") Then
                BOXAVSSCRIPT.Text = BOXAVSSCRIPT.Text.Replace("INPUTFILECODEABS07", Main.INPUTFILENAME2 + ".d2v")

            End If



            If BOXAVSSCRIPT.Text.Contains("appdirectory0703") Then
                Dim directory As String = My.Application.Info.DirectoryPath
                BOXAVSSCRIPT.Text = BOXAVSSCRIPT.Text.Replace("appdirectory0703", directory)

            End If
        ElseIf RDBFFMS2.Checked = True And Not My.Computer.FileSystem.FileExists(Main.InputCBOX.Text + ".avs") Then
            If InStr(2, Main.BOXFPSINFO.Text, ".00") Then
                FPSNUM = Int(Main.BOXFPSINFO.Text).ToString + ", "
                FPSDEN = "fpsden=1"
            ElseIf Main.INFOFRAMEMODE = "VFR" Then
                FPSNUM = "-1"
            Else
                FPSNUM = ((Int(Main.BOXFPSINFO.Text) + 1) * 1000).ToString + ", "
                FPSDEN = "fpsden=1001"
            End If

            BOXAVSSCRIPT.Text = "#SETMTMODE" + vbCrLf +
            "LoadCPlugin(" + """" + "appdirectory0703\avisynthPlugins\ffms2.dll" + """" + ")" + vbCrLf +
            "Import(" + """" + "appdirectory0703\avisynthPlugins\ffms2.avsi" + """" + ")" + vbCrLf +
            "FFmpegSource2(" + """" + "INPUTFILECODEABS07" + """" + ", fpsnum=" + FPSNUM + FPSDEN + ", threads=-1, vtrack=-1" + ")" + vbCrLf +
            "#NOISEFILTER" + vbCrLf

            If BOXAVSSCRIPT.Text.Contains("INPUTFILECODEABS07") Then
                BOXAVSSCRIPT.Text = BOXAVSSCRIPT.Text.Replace("INPUTFILECODEABS07", Main.INPUTFILENAME2)

            End If



            If BOXAVSSCRIPT.Text.Contains("appdirectory0703") Then
                Dim directory As String = My.Application.Info.DirectoryPath
                BOXAVSSCRIPT.Text = BOXAVSSCRIPT.Text.Replace("appdirectory0703", directory)

            End If
        End If
    End Function

    Private Sub RDBDGINDEX_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RDBDGINDEX.CheckedChanged
        prepareScript()
    End Sub
End Class