Public Class AvisynthOpt

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        Dim FILE_NAME As String = Main.InputCBOX.Text
        Dim Writer As IO.StreamWriter
        Dim Encode As System.Text.Encoding
        Encode = System.Text.Encoding.Default
        Writer = New IO.StreamWriter(FILE_NAME + ".avs", False, Encode)

        Writer.Write(BOXAVSSCRIPT.Text)
        Writer.Close()
        MsgBox("AVS Script writen to file")


        If RDBDGINDEX.Checked = True Then

            Dim fso, oFile
            fso = CreateObject("Scripting.FileSystemObject")
            oFile = fso.CreateTextFile("avs.cmd", True)
            oFile.WriteLine("title Simple FFMpeg Encoder")
            oFile.WriteLine(".\avisynthPlugins\dgindex -i " + """" + Main.INPUTFILENAME2 + """" + " -o " + """" + Main.INPUTFILENAME2 + """" + " -fo 0 -om 2 -exit")
            oFile.WriteLine("exit")
            oFile.Close()
            Shell("cmd /c avs.cmd & cmd /c call comp.bat", vbNormalFocus)
        ElseIf RDBFFMS2.Checked = True Then
            Dim fso, oFile
            fso = CreateObject("Scripting.FileSystemObject")
            oFile = fso.CreateTextFile("avs.cmd", True)
            oFile.WriteLine("title Simple FFMpeg Encoder")
            oFile.WriteLine(".\avisynthPlugins\ffmsindex  -f -t -1 " + """" + Main.INPUTFILENAME2 + """")
            oFile.WriteLine("exit")
            oFile.Close()




            Shell("cmd /c avs.cmd & cmd /c call comp.bat", vbNormalFocus)
        End If
        Me.Hide()

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHKDGDEBLOCK.CheckedChanged

    End Sub

    Private Sub BOXAVSSCRIPT_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BOXAVSSCRIPT.Click


    End Sub

    Private Sub BOXAVSSCRIPT_ControlAdded(ByVal sender As Object, ByVal e As System.Windows.Forms.ControlEventArgs) Handles BOXAVSSCRIPT.ControlAdded

    End Sub

    Private Sub BOXAVSSCRIPT_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BOXAVSSCRIPT.TextChanged

    End Sub

    Private Sub BOXAVSSCRIPT_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles BOXAVSSCRIPT.VisibleChanged
        If BOXAVSSCRIPT.Text.Contains("INPUTFILECODEABS07") Then
            BOXAVSSCRIPT.Text = BOXAVSSCRIPT.Text.Replace("INPUTFILECODEABS07", Main.INPUTFILENAME2 + ".d2v")

        End If



        If BOXAVSSCRIPT.Text.Contains("appdirectory0703") Then
            Dim directory As String = My.Application.Info.DirectoryPath
            BOXAVSSCRIPT.Text = BOXAVSSCRIPT.Text.Replace("appdirectory0703", directory)

        End If




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
            MsgBox("AVS File found.")
            Dim fileReader As String
            fileReader = My.Computer.FileSystem.ReadAllText(Main.InputCBOX.Text + ".avs", System.Text.Encoding.Default)
            BOXAVSSCRIPT.Text = fileReader
        Else
            MsgBox("AVS File not found.")
        End If

    End Sub

    Private Sub CHKAVSMT_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHKAVSMT.CheckedChanged
        If BOXAVSSCRIPT.Text.Contains("#SETMTMODE") And CHKAVSMT.Checked = True Then
            BOXAVSSCRIPT.Text = BOXAVSSCRIPT.Text.Replace("#SETMTMODE", "SetMTmode(2,0)")
        Else

        End If


    End Sub
End Class