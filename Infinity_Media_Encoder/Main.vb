﻿Imports System.Xml
Imports System.IO
Imports System.IO.Path
Imports System.Xml.Serialization
'Imports System.Drawing
'Imports DirectShowLib
'Imports System.Runtime.InteropServices
'Imports System.Threading.Tasks
'Imports System.Text
'Imports System.Threading
'Imports System.Diagnostics


Public Class Main
    Public fileReader As String
    Private Property strFileName As String
    Private Property strFileNameOpen As String
    Private Property strFileNameSave As String
    Public INPUTFILENAME As String
    Public INPUTFILENAME2 As String
    Public INPUTVIDNAME As String
    Public INPUTAUDFILENAME As String
    Public OUTPUTFILENAME As String
    Public FPSVAL As String
    Public LVVAL As String
    Public PFVAL As String
    Public RSVAL As String
    Public BITVAL As String
    Public REFVAL As String
    Public DEINTVAL As String
    Public KEYINTVAL As String
    Public CODEC As String
    Public ADVOPT As String
    Public X264OPT As String
    Public TRIMSSVAL As String
    Public TRIMTOVAL As String
    Public DEBLOCKVAL As String
    Public CQMVAL As String
    Public VIDEOVAL As String
    Public AUDIOVAL As String
    Public AUDIOPARAMVAL As String
    Public AUDIOCODECVAL As String
    Public AUDIOBITRATEVAL As String
    Public AUDIOSAMPLEVAL As String
    Public AUDIOCHANNELVAL As String
    Public AUDIOPFVAL As String
    Public AUDIODELAYVAL As String
    Public AUDIOCHKVAL As String
    Public AUDIOMAPVAL As String
    Public X264OPTVAL As String
    Public ASPECTRATIOVAL As String
    Public RATIOVALUE As String
    Public RS As String
    Public VIDEOFILTER As String
    Public CFRVAL As String
    Public CBRVAL As String
    Public ENABLELOG As String
    Public YOUTUBEQ As String
    Public SPPVAL As String
    Public USHARPFILTER As String
    Public MULTITRACK As String
    Public METADATA As String
    Public TEMPYTFILENAME As String
    Public RUNCMD As String
    Public SHELLCMD As String
    Public SUBTITLEPATH As String
    Public SUBTITLECHKVAL As String
    Public SUBTITLEMAP As String
    Public CUSTOMCODECOPT As String
    Public CUSTOMVIDEOFILTER As String
    Public CUSTOMFFMPEGOPT As String
    Public CUSTOMFFMPEGOPTF As String
    Public CODECPRESET As String
    Public HLSOPTIONFLAG As String
    Public FFMPEGEXE As String
    Public YTMAP As String
    Public FAST1STFLAG As String
    Public X264FAST1STFLAG As String
    Public CODECPRESET1ST As String
    Public BITSTREAMFILTER As String
    Public FORCEEXTENSION As String
    Public VDELAYINFO As String
    Public INFOFRAMEMODE As String
    Public EXTRAFFPRAM As String
    Public TRIMCHKVAL As Boolean
    Public TRIMSS As String
    Public TRIMTO As String

    Public STREAMPARAM As String
    Public STREAMINPUT As String
    Public STREAMOUTPUT As String
    Public HLSADDRESS As String
    Public STARTUPPATH As String
    Public FFPLAYEXE As String
    Public YOUTUBEDLPATH As String


    Dim DURHOURS As Integer
    Dim DURMIN As Integer
    Dim DURSEC As Integer
    Dim DURT As Integer
    Dim DURSS As Integer
    Dim DURSS2 As Integer
    Dim FILENUM As Integer
    Dim GPTSIDTS As String


    Public Run1 As String
    Dim PRESETFILENAME As String

    Dim sDate As String
    Dim hours As String
    Dim minutes As String
    Dim seconds As String
    Dim dblStringToDblSS As Double
    Dim dblStringToDblTO As Double
    Dim dblStringToDblRESULT As Double

    Dim MI As New MediaInfo
    Dim WScript
    Private FileName As String = System.IO.Path.Combine(Application.StartupPath, "Settings.xml")


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If InputCBOX.Text = "" Then
            OpenFileDialog1.FileName = ""
        Else
            Dim filenameinfo As System.IO.FileInfo
            filenameinfo = My.Computer.FileSystem.GetFileInfo(InputCBOX.Text)
            OpenFileDialog1.FileName = filenameinfo.Name
        End If


        OpenFileDialog1.Filter = "All Files (*.*)|*.*|Video Files |*.mkv;*.mp4;*.ts;*.avi;*.mov;*.3gp;*.wmv;*.m2ts;*.flv;*.mpeg;*.webm;*.mpg|MP4 |*.mp4"
        OpenFileDialog1.FilterIndex = 1


        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            strFileNameOpen = OpenFileDialog1.FileName


            InputCBOX.Text = strFileNameOpen
        End If

        prepareOpen()

    End Sub
    Private Sub BTAUDINPUNT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTAUDINPUNT.Click
        If BOXAUDIOPATH.Text = "" Then
            OpenFileDialog2.FileName = ""
        Else
            Dim filenameinfo2 As System.IO.FileInfo
            filenameinfo2 = My.Computer.FileSystem.GetFileInfo(BOXAUDIOPATH.Text)
            OpenFileDialog2.FileName = filenameinfo2.Name
        End If


        OpenFileDialog2.Filter = "All Files (*.*)|*.*|Audio Files |*.mp3;*.aac;*.m4a;*.wma;*.mp2"
        OpenFileDialog2.FilterIndex = 1

        Dim strAudFileNameOpen As String

        If OpenFileDialog2.ShowDialog = Windows.Forms.DialogResult.OK Then
            strAudFileNameOpen = OpenFileDialog2.FileName


            BOXAUDIOPATH.Text = strAudFileNameOpen
        End If


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If OutputCBox.Text = "" Then
        Else
            Dim filenameinfo3 As System.IO.FileInfo
            filenameinfo3 = My.Computer.FileSystem.GetFileInfo(OutputCBox.Text)
            SaveFileDialog1.FileName = filenameinfo3.Name
        End If


        SaveFileDialog1.Filter = "All Files (*.*)|*.*|MP4 Files |*.mp4 |Video Files |*.mkv;*.mp4;*.ts;*.avi;*.mov;*.3gp;*.wmv;*.m2ts;*.flv;*.mpeg;*.webm;*.mpg"
        SaveFileDialog1.FilterIndex = 1

        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            strFileNameSave = SaveFileDialog1.FileName
            OutputCBox.Text = strFileNameSave
            OUTPUTFILENAME = OutputCBox.Text
        End If


    End Sub



    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If FRMProgress.Visible = True Then
            If CHKMULTIENC.Checked = False And FRMProgress.p.HasExited = True Then
                FRMProgress.Close()
            End If
        End If

        If My.Computer.FileSystem.FileExists(OutputCBox.Text) Then
            Dim answer As Integer = MsgBox("File already exists. Do you want to overwrite?", MsgBoxStyle.YesNo)
            If answer = DialogResult.Yes Then
                GoTo continueencoding
            ElseIf answer = DialogResult.No Then
                initialValue()
                GoTo noencoding
            End If
        End If
continueencoding:


        If Not InputCBOX.Text = "" And Not OutputCBox.Text = "" Then
            prepareEncoding()
            prepareEncoding2()

            ' If CHKMULTIENC.Checked Or InStr(1, InputCBOX.Text, "http://youtube.com") Or InStr(1, InputCBOX.Text, "https://youtu.be") Or InStr(1, InputCBOX.Text, "http://www.youtube.com") Or InStr(1, InputCBOX.Text, "https://youtube.com/") Or InStr(1, InputCBOX.Text, "https://www.youtube.com/") Or
            ' InStr(1, InputCBOX.Text, "http://ustream.tv") Or InStr(1, InputCBOX.Text, "http://www.ustream.tv") Or InStr(1, InputCBOX.Text, "https://ustream.tv/") Or
            ' InStr(1, InputCBOX.Text, "https://www.ustream.tv/") Or InStr(1, InputCBOX.Text, "http://www.connectcast.tv/") Or InStr(1, InputCBOX.Text, "http://connectcast.tv/") Then
            If CHKMULTIENC.Checked Then
                Shell("cmd /c title Infinity Media Encoder & " + SHELLCMD + " & comp.bat", vbNormalFocus)
            Else

                FRMProgress.Show()
            End If


            If CHKDEBUG.Checked Then
                BOXDEBUG.Text = "cmd /c title Infinity Media Encoder & " + SHELLCMD + " & comp.bat"
            End If

            initialValue()
        Else
            MsgBox("Please specific Input Path / Output Path", MsgBoxStyle.Critical)
        End If

noencoding:
            initialValue()
    End Sub

    Private Sub BOXCODEC_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles BOXCODEC.TextChanged
        If CHKQA.Checked = True Then
        Else
            ChangeItems()
        End If

        If Not BOXCODEC.Text = "libx264" And Not BOXCODEC.Text = "libx265" Then
            BOXBITRATEMODE.Text = "ABR"

        End If

        If InStr(1, InputCBOX.Text, "http://youtube.com") Or InStr(1, InputCBOX.Text, "https://youtu.be") Or InStr(1, InputCBOX.Text, "http://www.youtube.com") Or InStr(1, InputCBOX.Text, "https://youtube.com/") Or InStr(1, InputCBOX.Text, "https://www.youtube.com/") Or
            InStr(1, InputCBOX.Text, "http://ustream.tv") Or InStr(1, InputCBOX.Text, "http://www.ustream.tv") Or InStr(1, InputCBOX.Text, "https://ustream.tv/") Or
            InStr(1, InputCBOX.Text, "https://www.ustream.tv/") Or InStr(1, InputCBOX.Text, "http://www.connectcast.tv/") Or InStr(1, InputCBOX.Text, "http://connectcast.tv/") Then
            CHKMULTITR.Enabled = False
            CHKQA.Enabled = False
        End If


    End Sub
    Public Function ChangeItems() As String()
        If BOXCODEC.Text = "libx265" Then
            LVBOX.Text = ""
            PFBOX.Text = ""
            PFBOX.Enabled = False
            LVBOX.Enabled = False
            REFBOX.Enabled = True
            BOXDEINT.Enabled = True
            RSBOX.Enabled = True
            BITBOX.Enabled = True
            BOXBITRATEMODE.Enabled = True
            BOXFPS.Enabled = True
            BOXKEYINT.Enabled = True
            BOXSPP.Enabled = True
            BOXUNSHARP.Enabled = True
            BOXCODECPRESET.Enabled = True
            CHKMULTITR.Enabled = True
            CHKQA.Enabled = True
            CHKFAST1ST.Enabled = True

            BOXCONTAINER.Items.Clear()
            BOXCONTAINER.Text = "mp4"
            BOXCONTAINER.Items.Add("mp4")
            BOXCONTAINER.Items.Add("mkv")
            BOXCONTAINER.Items.Add("ts")

            BOXBITRATEMODE.Items.Clear()
            BOXBITRATEMODE.Text = "CRF"
            BOXBITRATEMODE.Items.Add("CRF")
            BOXBITRATEMODE.Items.Add("CRF-MaxBitrate")
            BOXBITRATEMODE.Items.Add("ABR")
            BOXBITRATEMODE.Items.Add("File Size")

        ElseIf BOXCODEC.Text = "libx264" Then
            LVBOX.Text = ""
            PFBOX.Text = ""
            PFBOX.Enabled = True
            LVBOX.Enabled = True
            REFBOX.Enabled = True
            BOXDEINT.Enabled = True
            RSBOX.Enabled = True
            BITBOX.Enabled = True
            BOXBITRATEMODE.Enabled = True
            BOXFPS.Enabled = True
            BOXKEYINT.Enabled = True
            BOXSPP.Enabled = True
            BOXUNSHARP.Enabled = True
            BOXCODECPRESET.Enabled = True
            CHKMULTITR.Enabled = True
            CHKQA.Enabled = True
            CHKFAST1ST.Enabled = True

            BOXCONTAINER.Items.Clear()
            BOXCONTAINER.Text = "mp4"
            BOXCONTAINER.Items.Add("mp4")
            BOXCONTAINER.Items.Add("mkv")
            BOXCONTAINER.Items.Add("ts")
            BOXCONTAINER.Items.Add("avi")
            BOXCONTAINER.Items.Add("flv")
            BOXCONTAINER.Items.Add("mov")
            BOXCONTAINER.Items.Add("3gp")
            BOXCONTAINER.Items.Add("3g2")

            BOXBITRATEMODE.Items.Clear()
            BOXBITRATEMODE.Text = "CRF"
            BOXBITRATEMODE.Items.Add("CRF")
            BOXBITRATEMODE.Items.Add("CRF-MaxBitrate")
            BOXBITRATEMODE.Items.Add("CBR")
            BOXBITRATEMODE.Items.Add("ABR")
            BOXBITRATEMODE.Items.Add("File Size")
            BOXBITRATEMODE.Items.Add("2pass-ABR")

        ElseIf BOXCODEC.Text = "mpeg4" Then
            BOXBITRATEMODE.Items.Clear()
            BOXBITRATEMODE.Items.Add("CBR")
            BOXBITRATEMODE.Items.Add("ABR")

        ElseIf BOXCODEC.Text = "copy" Then
            LVBOX.Text = ""
            PFBOX.Text = ""
            PFBOX.Enabled = False
            LVBOX.Enabled = False
            REFBOX.Enabled = False
            BOXDEINT.Enabled = False
            RSBOX.Enabled = False
            BITBOX.Enabled = False
            BOXBITRATEMODE.Enabled = False
            BOXFPS.Enabled = False
            BOXKEYINT.Enabled = False
            BOXSPP.Enabled = False
            BOXUNSHARP.Enabled = False
            BOXCODECPRESET.Enabled = False
            CHKMULTITR.Enabled = True
            CHKQA.Enabled = True
            CHKFAST1ST.Enabled = False

            BOXCONTAINER.Items.Clear()
            BOXCONTAINER.Items.Add("mp4")
            BOXCONTAINER.Items.Add("mkv")
            BOXCONTAINER.Items.Add("ts")
            BOXCONTAINER.Items.Add("avi")
            BOXCONTAINER.Items.Add("flv")
            BOXCONTAINER.Items.Add("webm")
            BOXCONTAINER.Items.Add("mov")
            BOXCONTAINER.Items.Add("3gp")
            BOXCONTAINER.Items.Add("3g2")
            BOXCONTAINER.Items.Add("mp3")
            BOXCONTAINER.Items.Add("aac")
            BOXCONTAINER.Items.Add("m4a")
            BOXCONTAINER.Items.Add("ac3")
            BOXCONTAINER.Items.Add("flac")
            BOXCONTAINER.Items.Add("ogg")
            BOXCONTAINER.Items.Add("opus")
            BOXCONTAINER.Items.Add("dts")
            BOXCONTAINER.Items.Add("wav")
            BOXCONTAINER.Items.Add("wma")
            SwitchContainer()



        ElseIf BOXCODEC.Text = "No Video" Then
            LVBOX.Text = ""
            PFBOX.Text = ""
            PFBOX.Enabled = False
            LVBOX.Enabled = False
            REFBOX.Enabled = False
            BOXDEINT.Enabled = False
            RSBOX.Enabled = False
            BITBOX.Enabled = False
            BOXBITRATEMODE.Enabled = False
            BOXFPS.Enabled = False
            BOXKEYINT.Enabled = False
            BOXSPP.Enabled = False
            BOXUNSHARP.Enabled = False
            BOXCODECPRESET.Enabled = False
            CHKMULTITR.Enabled = False
            CHKQA.Enabled = False
            CHKFAST1ST.Enabled = False

            If BOXACODEC.Text = "libfdk_aac" Then
                BOXCONTAINER.Items.Clear()
                BOXCONTAINER.Text = "m4a"
                BOXCONTAINER.Items.Add("m4a")
                BOXCONTAINER.Items.Add("aac")

            ElseIf BOXACODEC.Text = "libmp3lame" Then
                BOXCONTAINER.Items.Clear()
                BOXCONTAINER.Text = "mp3"
                BOXCONTAINER.Items.Add("mp3")

            ElseIf BOXACODEC.Text = "ac3" Then
                BOXCONTAINER.Items.Clear()
                BOXCONTAINER.Text = "ac3"
                BOXCONTAINER.Items.Add("ac3")

            ElseIf BOXACODEC.Text = "PCM" Then
                BOXCONTAINER.Items.Clear()
                BOXCONTAINER.Text = "wav"
                BOXCONTAINER.Items.Add("wav")

            ElseIf BOXACODEC.Text = "libvorbis" Then
                BOXCONTAINER.Items.Clear()
                BOXCONTAINER.Text = "ogg"
                BOXCONTAINER.Items.Add("ogg")

            ElseIf BOXACODEC.Text = "libopus" Then
                BOXCONTAINER.Items.Clear()
                BOXCONTAINER.Text = "opus"
                BOXCONTAINER.Items.Add("opus")

            ElseIf BOXACODEC.Text = "dca" Then
                BOXCONTAINER.Items.Clear()
                BOXCONTAINER.Text = "dts"
                BOXCONTAINER.Items.Add("dts")

            ElseIf BOXACODEC.Text = "wmav2" Then
                BOXCONTAINER.Items.Clear()
                BOXCONTAINER.Text = "wma"
                BOXCONTAINER.Items.Add("wma")
            Else
                BOXCONTAINER.Items.Clear()
                BOXCONTAINER.Items.Add("mp3")
                BOXCONTAINER.Items.Add("aac")
                BOXCONTAINER.Items.Add("m4a")
                BOXCONTAINER.Items.Add("ac3")
                BOXCONTAINER.Items.Add("flac")
                BOXCONTAINER.Items.Add("ogg")
                BOXCONTAINER.Items.Add("opus")
                BOXCONTAINER.Items.Add("dts")
                BOXCONTAINER.Items.Add("wav")
                BOXCONTAINER.Items.Add("wma")
            End If



        Else
            PFBOX.Enabled = False
            LVBOX.Enabled = False
            REFBOX.Enabled = False
            BOXDEINT.Enabled = True
            RSBOX.Enabled = True
            BITBOX.Enabled = True
            BOXBITRATEMODE.Enabled = True
            BOXFPS.Enabled = True
            BOXKEYINT.Enabled = True
            BOXSPP.Enabled = True
            BOXUNSHARP.Enabled = True
            BOXCODECPRESET.Enabled = True
            CHKMULTITR.Enabled = True
            CHKQA.Enabled = True
            CHKFAST1ST.Enabled = True
            BOXCONTAINER.Items.Clear()
            BOXCONTAINER.Items.Add("mp4")
            BOXCONTAINER.Items.Add("mkv")
            BOXCONTAINER.Items.Add("ts")
            BOXCONTAINER.Items.Add("avi")
            BOXCONTAINER.Items.Add("flv")
            BOXCONTAINER.Items.Add("webm")
            BOXCONTAINER.Items.Add("mov")
            BOXCONTAINER.Items.Add("3gp")
            BOXCONTAINER.Items.Add("3g2")
            BOXCONTAINER.Items.Add("wmv")
            BOXCONTAINER.Items.Add("mp3")
            BOXCONTAINER.Items.Add("aac")
            BOXCONTAINER.Items.Add("m4a")
            BOXCONTAINER.Items.Add("ac3")
            BOXCONTAINER.Items.Add("flac")
            BOXCONTAINER.Items.Add("ogg")
            BOXCONTAINER.Items.Add("opus")
            BOXCONTAINER.Items.Add("dts")
            BOXCONTAINER.Items.Add("wav")
            BOXCONTAINER.Items.Add("wma")

            BOXBITRATEMODE.Items.Clear()
            BOXBITRATEMODE.Text = "CBR"
            BOXBITRATEMODE.Items.Add("CRF")
            BOXBITRATEMODE.Items.Add("CBR")
            BOXBITRATEMODE.Items.Add("ABR")
            BOXBITRATEMODE.Items.Add("File Size")
            BOXBITRATEMODE.Items.Add("2pass-ABR")


        End If
    End Function

    Private Sub Button7_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If BOXFPSINFO.Text = "" Then
            prepareOpen()
        ElseIf InStr(InputCBOX.Text, "-f dshow") Then


        End If

        If My.Computer.FileSystem.FileExists(InputCBOX.Text + ".avs") Then
            MsgBox("AVS File found.")
            Dim fileReader As String
            fileReader = My.Computer.FileSystem.ReadAllText(InputCBOX.Text + ".avs", System.Text.Encoding.Default)
            AvisynthOpt.BOXAVSSCRIPT.Text = fileReader
        Else
            MsgBox("AVS File not found.")
        End If
        If BOXCODECINFO.Text = "MPEG-2V" Then
            AvisynthOpt.RDBDGINDEX.Checked = True
        Else
            AvisynthOpt.RDBFFMS2.Checked = True
        End If


        AvisynthOpt.Show()
    End Sub

    Private Sub Button9_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FRMCUSTOMENC.Show()
    End Sub

    Private Sub Button6_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Shell("cmd /c " + FFPLAYEXE + " -i " + """" + InputCBOX.Text + ".avs" + """")

    End Sub


    Private Sub CHKTRIM_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHKTRIM.CheckedChanged
        If InStr(1, InputCBOX.Text, "http://") Then
            CHKTRIM.Checked = False
            MsgBox("Http Contents Trim not supported ", MsgBoxStyle.Information)

        ElseIf BOXCODEC.Text = "copy" And Not BOXACODEC.Text = "copy" Then
            If CHKTRIM.Checked = True Then
                MsgBox("Do not recommend use Video codec copy and Re-encoding Audio with trim option. It might be cause video duration error", MsgBoxStyle.Exclamation)
            End If


        End If
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTADDENCLIST.Click
        If Not InputCBOX.Text = "" And Not OutputCBox.Text = "" Then
            prepareEncoding()
            prepareEncoding2()
            Dim ACMD As String = SHELLCMD
            LISTCHKENC2.Items.Add(ACMD)
            CreateObject("WScript.Shell").Popup("Added to list - List Item count is " + LISTCHKENC2.Items.Count.ToString, 1, "Infinity Media Encoder")


            'MsgBox("Added to list - List Item count is " + LISTCHKENC2.Items.Count.ToString, MsgBoxStyle.Information)
            initialValue()
        Else
            MsgBox("Please specific Input Path / Output Path", MsgBoxStyle.Critical)
        End If
        If LISTCHKENC2.SelectedItems.Count = 0 Then
            LISTCHKENC2.SetSelected(0, True)
        End If

    End Sub

    Private Sub InputCBOX_TextUpdate(ByVal sender As Object, ByVal e As System.EventArgs) Handles InputCBOX.TextChanged
        INPUTVIDNAME = InputCBOX.Text
        If InStr(1, InputCBOX.Text, "http://youtube.com") Or InStr(1, InputCBOX.Text, "https://youtu.be") Or InStr(1, InputCBOX.Text, "http://www.youtube.com") Or InStr(1, InputCBOX.Text, "https://youtube.com/") Or InStr(1, InputCBOX.Text, "https://www.youtube.com/") Then
            BOXTRIMSS.Enabled = False
            CHKMULTITR.Enabled = False
            CHKQA.Enabled = False
            BOXCODEC.Text = "copy"
            BOXACODEC.Text = "copy"
            BOXCODEC.Enabled = False
            BOXACODEC.Enabled = False



        ElseIf InStr(1, InputCBOX.Text, "http://ustream.tv") Or InStr(1, InputCBOX.Text, "http://www.ustream.tv") Or InStr(1, InputCBOX.Text, "https://ustream.tv/") Or
            InStr(1, InputCBOX.Text, "https://www.ustream.tv/") Or InStr(1, InputCBOX.Text, "http://www.connectcast.tv/") Or InStr(1, InputCBOX.Text, "http://connectcast.tv/") Then
            BOXTRIMSS.Enabled = False
            BOXTRIMTO.Enabled = False
            CHKTRIM.Enabled = False
            CHKMULTITR.Enabled = False
            CHKQA.Enabled = False
            BOXCODEC.Enabled = True
            BOXACODEC.Enabled = True

        Else
            BOXTRIMSS.Enabled = True
            BOXTRIMTO.Enabled = True
            CHKTRIM.Enabled = True
            CHKMULTITR.Enabled = True
            CHKQA.Enabled = True
            BOXCODEC.Enabled = True
            BOXACODEC.Enabled = True

        End If
    End Sub

    Private Sub BTPRSAVE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTPRSAVE.Click
        Dim fileDateTime As String = DateTime.Now.ToString("yyyyMMdd") & "_" & DateTime.Now.ToString("HHmmss")
        PRESETFILENAME = BOXPRESETFILENAME.Text
        If BOXPRESETFILENAME.Text = "" Then
            PRESETFILENAME = fileDateTime
        End If
        Dim Data As New List(Of ControlData)
        FindControls(Me, Data)

        Dim xml As New XmlSerializer(Data.GetType)
        Using writer As New FileStream(".\Preset\" + PRESETFILENAME + ".xml", FileMode.Create)
            xml.Serialize(writer, Data)
        End Using

        If Not BOXPRESETFILENAME.Items.Contains(PRESETFILENAME) Then
            BOXPRESETFILENAME.Items.Add(PRESETFILENAME)
        End If
        BOXPRESETFILENAME.Text = PRESETFILENAME
        MsgBox("Preset Added", MsgBoxStyle.Information)
    End Sub

    Private Sub BTPRLOAD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTPRLOAD.Click

        PRESETFILENAME = BOXPRESETFILENAME.Text
        Parsingsettings()

        MsgBox("Preset Loaded", MsgBoxStyle.Information)
    End Sub

    Public Function Parsingsettings() As String()
        If System.IO.File.Exists(".\Preset\" + PRESETFILENAME + ".xml") Then
            Dim Data As New List(Of ControlData)
            Dim xml As New XmlSerializer(Data.GetType)
            Using reader As New FileStream(".\Preset\" + PRESETFILENAME + ".xml", FileMode.Open)
                Data = CType(xml.Deserialize(reader), List(Of ControlData))

            End Using

            Dim matches() As Control
            For Each cd As ControlData In Data
                matches = Me.Controls.Find(cd.ControlName, True)
                If matches.Length > 0 Then
                    CallByName(matches(0), cd.ControlProperty, CallType.Let, cd.ControlData)
                End If
            Next
        Else
            MsgBox("Do not exist Preset file " + PRESETFILENAME + ".xml")
        End If


    End Function
    Private Sub FindControls(ByVal cont As Control, ByVal Data As List(Of ControlData))
        For Each ctl As Control In cont.Controls
            If CHKALLSET.Checked = False Then
                If TypeOf ctl Is ComboBox Then
                    Dim CB As ComboBox = DirectCast(ctl, ComboBox)
                    If Not IsNothing(CB.SelectedItem) Then
                        Dim cd As New ControlData
                        cd.ControlName = ctl.Name
                        cd.ControlProperty = "SelectedItem"
                        cd.ControlData = CB.SelectedItem.ToString
                        Data.Add(cd)
                    End If
                ElseIf ctl.HasChildren Then
                    FindControls(ctl, Data)
                End If
            Else
                If TypeOf ctl Is ComboBox Then
                    Dim CB As ComboBox = DirectCast(ctl, ComboBox)
                    If Not IsNothing(CB.Text) Then
                        Dim cd As New ControlData
                        cd.ControlName = ctl.Name
                        cd.ControlProperty = "Text"
                        cd.ControlData = CB.Text.ToString
                        Data.Add(cd)
                    End If
                ElseIf ctl.HasChildren Then
                    FindControls(ctl, Data)
                End If
            End If

            If TypeOf ctl Is CheckBox Then
                Dim CB As CheckBox = DirectCast(ctl, CheckBox)
                If Not CB.Checked = False Then
                    Dim cd As New ControlData
                    cd.ControlName = ctl.Name
                    cd.ControlProperty = "Checked"
                    cd.ControlData = CB.Checked.ToString
                    Data.Add(cd)
                ElseIf Not CB.Checked = True Then
                    Dim cd As New ControlData
                    cd.ControlName = ctl.Name
                    cd.ControlProperty = "Checked"
                    cd.ControlData = CB.Checked.ToString
                    Data.Add(cd)

                End If
            End If
            If TypeOf ctl Is TextBox Then
                Dim CB As TextBox = DirectCast(ctl, TextBox)
                If Not CB.Text = "" Then
                    Dim cd As New ControlData
                    cd.ControlName = ctl.Name
                    cd.ControlProperty = "Text"
                    cd.ControlData = CB.Text.ToString
                    Data.Add(cd)
                End If
            End If


        Next
    End Sub

    Private Sub Main_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try
            FRMProgress.KillProcessAndChildren(FRMProgress.p.Id)
        Catch
        End Try
        Try
            FRMProgress.BackgroundWorker_1.CancelAsync()
            FRMProgress.outputReader.DiscardBufferedData()
            FRMProgress.outputReader.Close()
        Catch
        End Try
    End Sub



    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        STARTUPPATH = Application.StartupPath()
        If Environment.Is64BitOperatingSystem = True Then
            BOXFFMPEGEXE.Text = "64bit FFmpeg"
        ElseIf Environment.Is64BitOperatingSystem = False Then
            BOXFFMPEGEXE.Text = "32bit FFmpeg"
        End If
        FFPLAYEXE = """" + STARTUPPATH + "\Tools\ffmpeg32\ffplay.exe" + """"
        YOUTUBEDLPATH = """" + STARTUPPATH + "\Tools\youtube-dl\youtube-dl.exe" + """"


        Dim PRESETFOLDER As String = ".\Preset\"

        For Each PRESETFILE As String In My.Computer.FileSystem.GetFiles _
                                                    (PRESETFOLDER, FileIO.SearchOption.SearchTopLevelOnly, "*.xml")
            BOXPRESETFILENAME.Items.Add(IO.Path.GetFileNameWithoutExtension(PRESETFILE))
        Next
        ChangeItems()



    End Sub

    Private Sub CHKAUTONAME_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHKAUTONAME.CheckedChanged
        If CHKAUTONAME.Checked Then

            If InputCBOX.Text = "" Then

            ElseIf InStr(InputCBOX.Text, "-f dshow") Then

            ElseIf InStr(1, InputCBOX.Text, "http://youtube.com") Or InStr(1, InputCBOX.Text, "https://youtu.be") Or InStr(1, InputCBOX.Text, "http://www.youtube.com") Or InStr(1, InputCBOX.Text, "https://youtube.com/") Or InStr(1, InputCBOX.Text, "https://www.youtube.com/") Then
                OutputCBox.Text = ""
                OUTPUTFILENAME = ""

                If Environment.Is64BitOperatingSystem = True Then
                    Dim oProcess As New Process()
                    Dim oStartInfo As New ProcessStartInfo("cmd", "/c " + YOUTUBEDLPATH + " --get-filename " + InputCBOX.Text)
                    oStartInfo.UseShellExecute = False
                    oStartInfo.RedirectStandardOutput = True

                    oStartInfo.StandardOutputEncoding = System.Text.Encoding.Default
                    oProcess.StartInfo = oStartInfo
                    oProcess.Start()
                    Try
                        Dim sOutput As String
                        Using oStreamReader As System.IO.StreamReader = oProcess.StandardOutput
                            sOutput = oStreamReader.ReadLine()
                            oStreamReader.Close()
                        End Using

                        Console.WriteLine(sOutput)
                        OutputCBox.Text = sOutput
                    Catch
                        Dim sOutput As String
                        Using oStreamReader As System.IO.StreamReader = oProcess.StandardOutput
                            sOutput = oStreamReader.ReadLine()
                            oStreamReader.Close()
                        End Using

                        Console.WriteLine(sOutput)
                        OutputCBox.Text = sOutput
                    End Try

                Else
                    Shell("cmd /c " + YOUTUBEDLPATH + " --get-filename " + InputCBOX.Text + " > temp.txt", vbNormalFocus)
                    Threading.Thread.Sleep(500)

                    Dim exists As String = System.IO.File.Exists("temp.txt")
                    If exists = True Then

                        Try
                            fileReader = My.Computer.FileSystem.ReadAllText("temp.txt", System.Text.Encoding.Default)

                        Catch
                            Threading.Thread.Sleep(3000)
                            fileReader = My.Computer.FileSystem.ReadAllText("temp.txt", System.Text.Encoding.Default)
                        End Try
                        Try
                            Threading.Thread.Sleep(2000)
                            fileReader = My.Computer.FileSystem.ReadAllText("temp.txt", System.Text.Encoding.Default)
                        Catch
                            fileReader = My.Computer.FileSystem.ReadAllText("temp.txt", System.Text.Encoding.Default)
                        End Try

                        OutputCBox.Text = fileReader

                    End If
                End If
                OUTPUTFILENAME = OutputCBox.Text


                If OutputCBox.Text = "" Then
                    MsgBox("Failed to get Youtube video title", MsgBoxStyle.Critical)
                End If
                ''If exists = True Then
                ''My.Computer.FileSystem.DeleteFile("temp.txt")
                '' End If


            ElseIf InStr(5, InputCBOX.Text, "//") Then
                If OutputCBox.Text = "" Then
                    OutputCBox.Text = "[InfinityEncoder]Video.mp4"
                    OUTPUTFILENAME = OutputCBox.Text
                Else

                End If


            ElseIf CHKQA.Checked = True Then
                OutputCBox.Text = STARTUPPATH + "\HLS_Output\index.m3u8"
            Else
                INPUTVIDNAME = InputCBOX.Text
                Dim testFile As System.IO.FileInfo
                testFile = My.Computer.FileSystem.GetFileInfo(INPUTVIDNAME)
                Dim folderPath As String = testFile.DirectoryName
                Dim infileName As String = testFile.Name
                OutputCBox.Text = folderPath + "\[InfinityEncoder]" + infileName
                OUTPUTFILENAME = OutputCBox.Text
            End If
            SwitchContainer()


        Else

        End If

    End Sub

    Public Function prepareEncoding() As String()
        FRMProgress.FFPARAM = ""
        If BOXCODECINFO.Text = "" Then
            getMediainfo()
        ElseIf InStr(InputCBOX.Text, "-f dshow") Then
        End If

        If CHKAVISYNTH.Checked = True Then
            FFMPEGEXE = """" + STARTUPPATH + "\Tools\ffmpeg32\ffmpeghyb32.exe" + """"
        ElseIf InStr(InputCBOX.Text, "-f dshow") Then
            FFMPEGEXE = """" + STARTUPPATH + "\Tools\ffmpeg32\ffmpeghyb32.exe " + """"
        ElseIf BOXFFMPEGEXE.Text = "64bit FFmpeg" Then
            FFMPEGEXE = """" + STARTUPPATH + "\Tools\ffmpeg64\ffmpeghyb64.exe" + """"
        ElseIf BOXFFMPEGEXE.Text = "32bit FFmpeg" Then
            FFMPEGEXE = """" + STARTUPPATH + "\Tools\ffmpeg32\ffmpeghyb32.exe " + """"
        Else
            FFMPEGEXE = """" + BOXFFMPEGEXE.Text + """"
        End If





        If Not BOXFPS.Text = "" And Not BOXCODEC.Text = "copy" And Not BOXFPS.Text = "Original" Then
            FPSVAL = ",fps=fps=" + BOXFPS.Text
        End If

        If BOXCODEC.Text = "libx264" Then
            PFVAL = " -profile:v " + PFBOX.Text
        ElseIf BOXCODEC.Text = "libx265" Then
            PFVAL = ""
        End If
        If PFBOX.Text = "" Then
            PFVAL = ""
        End If


        If BOXCODEC.Text = "libx264" And Not LVBOX.Text = "" Then
            LVVAL = " -level:v " + LVBOX.Text
        End If




        If BOXCODEC.Text = "libx264" Then
            If REFBOX.Text = "Original" Then
                REFVAL = ":ref=" + BOXREFINFO.Text
            Else
                REFVAL = ":ref=" + REFBOX.Text
            End If
        End If


        If BOXCODEC.Text = "copy" Or RSBOX.Text = "Original" Then
            RSVAL = ""
        Else
            RSVAL = ",scale=" + RSBOX.Text + ":flags=lanczos"

        End If

        If BOXCODEC.Text = "copy" Or BOXDEINT.Text = "Disabled" Then
            DEINTVAL = ""
        Else
            DEINTVAL = ",yadif=" + BOXDEINT.Text
        End If


        If BOXCODEC.Text = "copy" Or BOXSPP.Text = "Disabled" Then
            SPPVAL = ""
        Else
            SPPVAL = ",spp=" + BOXSPP.Text
        End If






        If Not BOXKEYINT.Text = "Auto" Then
            KEYINTVAL = " -g " + BOXKEYINT.Text
        End If

        If CHKPTSDTS.Checked = True Then
            GPTSIDTS = " -fflags +genpts+igndts "
        End If

        If CHKTRIM.Checked Then
            If BOXTRIMSS.Text = "00:00:00" Then

            Else
                TRIMSSVAL = " -ss " + BOXTRIMSS.Text
                sDate = BOXTRIMSS.Text
                hours = Trim(Split(sDate, ":")(0))
                minutes = Trim(Split(sDate, ":")(1))
                seconds = Trim(Split(sDate, ":")(2))
                dblStringToDblSS = CLng(hours) * 3600 + CLng(minutes) * 60 + CLng(seconds)
            End If

            If BOXTRIMTO.Text = "00:00:00" Then

            Else
                sDate = BOXTRIMTO.Text
                hours = Trim(Split(sDate, ":")(0))
                minutes = Trim(Split(sDate, ":")(1))
                seconds = Trim(Split(sDate, ":")(2))
                dblStringToDblTO = CLng(hours) * 3600 + CLng(minutes) * 60 + CLng(seconds)

                dblStringToDblRESULT = dblStringToDblTO - dblStringToDblSS
                TRIMTOVAL = " -to " + dblStringToDblRESULT.ToString
            End If
        End If

        If BOXCODEC.Text = "libx264" Then
            X264OPTVAL = " -x264opts fullrange=off:colorprim=bt709" + CUSTOMCODECOPT
            If CHKFAST1ST.Checked = True Then
                X264FAST1STFLAG = " -fastfirstpass 1 "
            End If
        End If

        If BOXCODEC.Text = "libx264" And CHECKADV.Checked Then
            X264OPT = ":fullrange=off:colorprim=bt709:weightp=2:weightb=1:b-adapt=2:rc-lookahead=40:b-pyramid=2:b-bias=3" + CUSTOMCODECOPT

        ElseIf BOXCODEC.Text = "libx265" Then
            X264OPT = " -x265-params colorprim=bt709:open-gop=0" + CUSTOMCODECOPT
            If CHKFAST1ST.Checked = False Then
                FAST1STFLAG = ":slow-firstpass=1"
            End If
        End If

        If BOXCODEC.Text = "libx264" And CHKCQM.Checked And Not PFBOX.Text = "main" And Not PFBOX.Text = "baseline" And Not PFBOX.Text = "copy" Then
            CQMVAL = ":cqmfile=KGP-X264-Custom-Quantization-Matrix.cfg"
        End If

        If BOXCODEC.Text = "libx264" And CHECKADV.Checked Then
            ADVOPT = AdvancedFRM.LBMERANGE + AdvancedFRM.LBMEALGORITHM + AdvancedFRM.LBSR + AdvancedFRM.LBTR + AdvancedFRM.LBNOPSKIP + AdvancedFRM.LBNODCT + AdvancedFRM.LBBFRAMES + AdvancedFRM.LBAQMODE + AdvancedFRM.LBAQSTR + AdvancedFRM.LBFADE + AdvancedFRM.LBSCENE
        End If



        If BOXDELAYINFO.Text = "" And Not BOXDELAY.Text = "Auto" Then

        ElseIf Not BOXDELAYINFO.Text = "" And BOXDELAY.Text = "Auto" Then
            VDELAYINFO = BOXDELAYINFO.Text
        Else
            VDELAYINFO = BOXDELAY.Text
        End If

        If BOXACODEC.Text = "No Audio" Then

        ElseIf BOXACODEC.Text = "PCM" Then
            AUDIOCODECVAL = BOXAACPF.Text
        Else
            AUDIOCODECVAL = BOXACODEC.Text
        End If

        Bitrateparam()


        If Not BOXDELAY.Text = "Auto" And Not BOXACODEC.Text = "No Audio" Then
            AUDIODELAYVAL = " -itsoffset " + VDELAYINFO + " "
        End If
        If BOXDELAY.Text = "Auto" And Not BOXDELAYINFO.Text = "" Then
            AUDIODELAYVAL = " -itsoffset " + VDELAYINFO + " "
        End If
        If BOXDELAY.Text = "Disabled" Or BOXDELAY.Text = "" Then
            AUDIODELAYVAL = ""
        End If

        If Not BOXAACPF.Text = "Auto" And Not BOXACODEC.Text = "No Audio" And BOXACODEC.Text = "libfdk_aac" Or BOXACODEC.Text = "libfaac" Then
            AUDIOPFVAL = " -profile:a " + BOXAACPF.Text
        End If

        If Not BOXACODEC.Text = "No Audio" Then
            AUDIOCHKVAL = " -acodec "
        End If

        If CHKREPLACEAUD.Checked And Not BOXACODEC.Text = "No Audio" And Not BOXAUDIOPATH.Text = "" Then
            AUDIOMAPVAL = " -map 0:v:0 -map 1:a:0 "
        End If

        If Not BOXACODEC.Text = "No Audio" And CHKMULTITR.Checked Then
            MULTITRACK = " -map 0 "
        End If

        If Not RSBOX.Text = "" Then
            Dim RESINPUT As String = RSBOX.Text
            Dim RATIOVALUE As String = Replace(RESINPUT, "x", "/")
            ASPECTRATIOVAL = " -aspect " + RATIOVALUE + " "
        End If

        If RSBOX.Text = "Original" Then
            ASPECTRATIOVAL = ""
        End If

        DEBLOCKVAL = AdvancedFRM.LBDEBLOCK
        If BOXCFR.Text = "CFR" And BOXCODEC.Text = "libx264" Or BOXCODEC.Text = "libx265" Then
            CFRVAL = ":force-cfr=1"
        End If


        If Not BOXAUDIOPATH.Text = "" Then
            INPUTAUDFILENAME = " -i " + """" + BOXAUDIOPATH.Text + """" + " "
        End If

        If CHKLOG.Checked Then
            ENABLELOG = " -report "
        End If

        If CHK4K.Checked Then
            YOUTUBEQ = "138/266/264/299/137/best "
        Else
            YOUTUBEQ = "299/137/best "
        End If







        If Not BOXCODEC.Text = "libvpx" And Not BOXCODEC.Text = "libvpx-vp9" Then
            METADATA = " -metadata description=" + """" + "Infinity Media Encoder by K.G.P-Louis" + """"
        Else

        End If
        INPUTVIDNAME = InputCBOX.Text
        OUTPUTFILENAME = OutputCBox.Text

        If CHKAVISYNTH.Checked = True Then
            INPUTVIDNAME = InputCBOX.Text + ".avs"
        Else
            INPUTVIDNAME = InputCBOX.Text
        End If

        If InStr(InputCBOX.Text, "-f dshow") Then
        ElseIf OutputCBox.Text.Contains("//") Then
            FORCEEXTENSION = " -f flv "
        Else
            Dim testFile As System.IO.FileInfo
            testFile = My.Computer.FileSystem.GetFileInfo(OUTPUTFILENAME)
            Dim folderPath As String = testFile.DirectoryName
            Dim outfileName As String = testFile.Name
            TEMPYTFILENAME = outfileName
        End If





        If Not BOXSUBPATH.Text = "" Then
            SUBTITLEPATH = " -i " + """" + BOXSUBPATH.Text + """" + " "
            If BOXFORMATINFO.Text = "MPEG-4" Then
                SUBTITLECHKVAL = " -scodec mov_text "
            ElseIf BOXFORMATINFO.Text = "Matroska" Then
                SUBTITLECHKVAL = " -scodec srt "
            ElseIf BOXFORMATINFO.Text = "MPEG-TS" Then
                SUBTITLECHKVAL = " -scodec copy "
            End If

        End If

        If BOXUNSHARP.Text = "Disabled" Or BOXUNSHARP.Enabled = False Then
            USHARPFILTER = ""
        Else
            USHARPFILTER = ",unsharp=" + BOXUNSHARP.Text + " "
        End If

        If BOXCODEC.Text = "copy" Then
            VIDEOFILTER = ""
        ElseIf CUSTOMVIDEOFILTER = "" And RSVAL = "" And FPSVAL = "" And DEINTVAL = "" And SPPVAL = "" Then
            VIDEOFILTER = ""
        Else
            VIDEOFILTER = " -filter_complex null" + DEINTVAL + RSVAL + FPSVAL + SPPVAL + USHARPFILTER + CUSTOMVIDEOFILTER

        End If

        If BOXCODEC.Text = "No Video" Or BOXCODEC.Text = "h264_qsv" Or BOXCODEC.Text = "libwebp" Then
            CODECPRESET = ""
        Else
            CODECPRESET = " -preset " + BOXCODECPRESET.Text + " "
        End If

        YTMAP = " -map 0:v:0 -map 1:a:0 "

        Dim VSYNCVAL As String
        Dim CHKASYNCVAL As String
        If CHKVSYNC0.Checked = True Then
            VSYNCVAL = " -vsync 0 "
        End If
        If CHKASYNC.Checked = True Then
            CHKASYNCVAL = " -async 1 "
        End If
        EXTRAFFPRAM = VSYNCVAL + CHKASYNCVAL

        VSYNCVAL = ""
        CHKASYNCVAL = ""

        If BOXACODEC.Text = "No Audio" Then
            AUDIOVAL = " -an "
            AUDIOCHKVAL = ""
        Else
            AUDIOVAL = ""
        End If


        If BOXCODEC.Text = "No Video" Then
            VIDEOVAL = " -vn "
        Else
            VIDEOVAL = ""
        End If

        If Not BOXCODEC.Text = "No Video" And Not BOXACODEC.Text = "No Audio" Then
            VIDEOVAL = ""
            AUDIOVAL = ""
        End If

        If BOXCONTAINER.Text = "mp3" Or BOXCONTAINER.Text = "m4a" Or BOXCONTAINER.Text = "aac" Or BOXCONTAINER.Text = "ac3" Or BOXCONTAINER.Text = "flac" Or
            BOXCONTAINER.Text = "ogg" Or BOXCONTAINER.Text = "opus" Or BOXCONTAINER.Text = "dts" Or BOXCONTAINER.Text = "wav" Or BOXCONTAINER.Text = "wma" Then
            VIDEOFILTER = ""
            RSVAL = ""
            CODEC = ""
            BITVAL = ""
            EXTRAFFPRAM = ""
        ElseIf BOXCODEC.Text = "No Video" Then
            VIDEOFILTER = ""
            RSVAL = ""
            CODEC = ""
            BITVAL = ""
            EXTRAFFPRAM = ""
        Else
            CODEC = " -vcodec " + BOXCODEC.Text
        End If

        If CHKCHLSADDRESS.Checked = True Then
            HLSADDRESS = " -hls_base_url " + BOXCHLSADDRESS.Text
        End If

        If CHKTRIM.Checked = True Then
            TRIMCHKVAL = True
            FRMProgress.TRIMCHK = True
            TRIMSS = BOXTRIMSS.Text
            TRIMTO = BOXTRIMTO.Text
            FRMProgress.TRIMTO = BOXTRIMTO.Text
        End If

    End Function

    Public Function prepareEncoding2() As String()
        If OutputCBox.Text.Contains("/") Then
        Else
            Dim testFile As System.IO.FileInfo
            testFile = My.Computer.FileSystem.GetFileInfo(OutputCBox.Text)
            Dim folderPath As String = testFile.DirectoryName

            If Not Directory.Exists(folderPath) Then
                Directory.CreateDirectory(folderPath)
            End If
        End If




        If BOXACODEC.Text = "copy" And BOXFORMATINFO.Text = "MPEG-TS" And BOXACODECINFO.Text = "AAC LC" And Not BOXCONTAINER.Text = "ts" Then
            BITSTREAMFILTER = " -bsf:a aac_adtstoasc "
        ElseIf BOXCODEC.Text = "copy" And BOXFORMATINFO.Text = "MPEG-4" And BOXCONTAINER.Text = "ts" Or BOXCONTAINER.Text = "m3u8" Then
            BITSTREAMFILTER = " -bsf:v h264_mp4toannexb "
        End If

        If CHKQA.Checked Then
            HLSOPTIONFLAG = " -force_key_frames expr:gte(t,n_forced*" + BOXCUSTOMT.Text + ") -keyint_min " + BOXCUSTOMT.Text + " -hls_list_size 0 -hls_time " + BOXCUSTOMT.Text + " "
            SHELLCMD = FFMPEGEXE + " " + CUSTOMFFMPEGOPTF + TRIMSSVAL + " -i " + """" + INPUTVIDNAME + """" + AUDIODELAYVAL + INPUTAUDFILENAME + SUBTITLEPATH + TRIMTOVAL + VIDEOFILTER + CODEC + CODECPRESET + PFVAL + LVVAL + BITVAL + HLSOPTIONFLAG + HLSADDRESS + CUSTOMFFMPEGOPT + X264OPTVAL + X264OPT + REFVAL + CQMVAL + ADVOPT + CFRVAL + DEBLOCKVAL + VIDEOVAL + ASPECTRATIOVAL + CBRVAL + ENABLELOG +
                 MULTITRACK + AUDIOMAPVAL + AUDIOCHKVAL + AUDIOCODECVAL + AUDIOPFVAL + AUDIOBITRATEVAL + AUDIOSAMPLEVAL + AUDIOCHANNELVAL + AUDIOVAL + SUBTITLECHKVAL + METADATA + " " + """" + OUTPUTFILENAME + """"

        ElseIf InStr(InputCBOX.Text, "-f dshow") Then
            SHELLCMD = FFMPEGEXE + CUSTOMFFMPEGOPTF + GPTSIDTS + TRIMSSVAL + AUDIODELAYVAL + InputCBOX.Text + SUBTITLEPATH + TRIMTOVAL + VIDEOFILTER + CODEC + CODECPRESET + PFVAL + LVVAL + KEYINTVAL + BITVAL + CUSTOMFFMPEGOPT + EXTRAFFPRAM + X264OPTVAL + X264OPT + REFVAL + CQMVAL + ADVOPT + CFRVAL + DEBLOCKVAL + VIDEOVAL + ASPECTRATIOVAL + CBRVAL + ENABLELOG +
                     MULTITRACK + AUDIOMAPVAL + AUDIOCHKVAL + AUDIOCODECVAL + AUDIOPFVAL + AUDIOBITRATEVAL + AUDIOSAMPLEVAL + AUDIOCHANNELVAL + AUDIOVAL + SUBTITLECHKVAL + BITSTREAMFILTER + METADATA + " -f flv " + """" + OUTPUTFILENAME + """"

        ElseIf InStr(1, InputCBOX.Text, "http://youtube.com") Or InStr(1, InputCBOX.Text, "https://youtu.be") Or InStr(1, InputCBOX.Text, "http://www.youtube.com") Or InStr(1, InputCBOX.Text, "https://youtube.com/") Or InStr(1, InputCBOX.Text, "https://www.youtube.com/") Then
            If InStr(1, InputCBOX.Text, "https://youtube.com") Or InStr(1, InputCBOX.Text, "https://www.youtube.com") Then
                InputCBOX.Text.Replace("https://", "http://")
            End If
            CHKQA.Enabled = False
            CHKMULTITR.Enabled = False

            If BOXCODEC.Text = "copy" Then
                VIDEOFILTER = ""
            End If

            If Not BOXCODEC.Text = "No Video" And Not BOXACODEC.Text = "No Audio" Then
                SHELLCMD = YOUTUBEDLPATH + " -f " + YOUTUBEQ + """" + INPUTVIDNAME + """" + " -o - | " + FFMPEGEXE + " -y " + GPTSIDTS + "-i - " + AUDIODELAYVAL + INPUTAUDFILENAME + VIDEOFILTER + CODEC + CODECPRESET + PFVAL + LVVAL + KEYINTVAL + BITVAL + X264OPTVAL + X264OPT + REFVAL + CQMVAL + ADVOPT + CFRVAL + DEBLOCKVAL + VIDEOVAL + ASPECTRATIOVAL + CBRVAL + ENABLELOG + AUDIOMAPVAL + AUDIOCHKVAL + AUDIOCODECVAL + AUDIOPFVAL + AUDIOBITRATEVAL + AUDIOSAMPLEVAL + AUDIOCHANNELVAL + AUDIOVAL + " -metadata description=" + """" + "Infinity Media Encoder by KGP-Louis" + """" + " " + """" + "temp_" + TEMPYTFILENAME + """" +
                "& " + YOUTUBEDLPATH + " -f 141/140 " + """" + INPUTVIDNAME + """" + " -o - | " + FFMPEGEXE + " -y " + GPTSIDTS + " -i " + """" + "temp_" + TEMPYTFILENAME + """" + INPUTAUDFILENAME + " -i - " + TRIMTOVAL + " -vcodec copy " + AUDIOMAPVAL + AUDIOCHKVAL + AUDIOCODECVAL + AUDIOPFVAL + AUDIOBITRATEVAL + AUDIOSAMPLEVAL + AUDIOCHANNELVAL + AUDIOVAL + SUBTITLECHKVAL + YTMAP + "-metadata description=" + """" + "Youtube Processing - Infinity Media Encoder by KGP-Louis" + """" + " " + """" + OUTPUTFILENAME + """" +
                "& del " + """" + "temp_" + TEMPYTFILENAME + """"
            ElseIf Not BOXCODEC.Text = "No Video" And BOXACODEC.Text = "No Audio" Then
                SHELLCMD = YOUTUBEDLPATH + " -f " + YOUTUBEQ + """" + INPUTVIDNAME + """" + " -o - | " + FFMPEGEXE + " -y " + GPTSIDTS + "-i - " + AUDIODELAYVAL + INPUTAUDFILENAME + TRIMTOVAL + VIDEOFILTER + CODEC + CODECPRESET + PFVAL + LVVAL + KEYINTVAL + BITVAL + X264OPTVAL + X264OPT + REFVAL + CQMVAL + ADVOPT + CFRVAL + DEBLOCKVAL + VIDEOVAL + ASPECTRATIOVAL + CBRVAL + ENABLELOG + AUDIOMAPVAL + AUDIOCHKVAL + AUDIOCODECVAL + AUDIOPFVAL + AUDIOBITRATEVAL + AUDIOSAMPLEVAL + AUDIOCHANNELVAL + AUDIOVAL + " -metadata description=" + """" + "Infinity Media Encoder by KGP-Louis" + """" + " " + """" + OUTPUTFILENAME + """"
            Else
                SHELLCMD = YOUTUBEDLPATH + " -f 141/140 " + """" + INPUTVIDNAME + """" + " -o - | " + FFMPEGEXE + " -y " + GPTSIDTS + "-i - " + TRIMTOVAL + AUDIOMAPVAL + AUDIOCHKVAL + AUDIOCODECVAL + AUDIOPFVAL + AUDIOBITRATEVAL + AUDIOSAMPLEVAL + AUDIOCHANNELVAL + AUDIOVAL + "-metadata description=" + """" + "Youtube Processing - Infinity Media Encoder by KGP-Louis" + """" + " " + """" + OUTPUTFILENAME + """"
            End If


        ElseIf InStr(1, InputCBOX.Text, "http://ustream.tv") Or InStr(1, InputCBOX.Text, "http://www.ustream.tv") Or InStr(1, InputCBOX.Text, "https://ustream.tv/") Or
            InStr(1, InputCBOX.Text, "https://www.ustream.tv/") Or InStr(1, InputCBOX.Text, "http://www.connectcast.tv/") Or InStr(1, InputCBOX.Text, "http://connectcast.tv/") Then
            If BOXCODEC.Text = "copy" Then
                VIDEOFILTER = ""
            End If

            SHELLCMD = """" + STARTUPPATH + "\Tools\livestreamer\livestreamer" + """" + """" + INPUTVIDNAME + """" + " best -o - | " +
                  FFMPEGEXE + " -y" + GPTSIDTS + "-i - " + "- " + AUDIODELAYVAL + INPUTAUDFILENAME + VIDEOFILTER + CODEC + " -vsync 0 " + CODECPRESET + PFVAL + LVVAL + KEYINTVAL + BITVAL + X264OPTVAL + X264OPT + REFVAL + CQMVAL + ADVOPT + CFRVAL + DEBLOCKVAL + VIDEOVAL + ASPECTRATIOVAL + CBRVAL + ENABLELOG + MULTITRACK + AUDIOMAPVAL + AUDIOCHKVAL + AUDIOCODECVAL + AUDIOPFVAL + AUDIOBITRATEVAL + AUDIOSAMPLEVAL + AUDIOCHANNELVAL + AUDIOVAL + METADATA + " " + """" + OUTPUTFILENAME + """"

        ElseIf BOXBITRATEMODE.Text = "2pass-ABR" Then

            SHELLCMD = FFMPEGEXE + " -y " + CUSTOMFFMPEGOPTF + GPTSIDTS + TRIMSSVAL + " -i " + """" + INPUTVIDNAME + """" + AUDIODELAYVAL + INPUTAUDFILENAME + SUBTITLEPATH + TRIMTOVAL + VIDEOFILTER + CODEC + CODECPRESET + PFVAL + LVVAL + KEYINTVAL + BITVAL + CUSTOMFFMPEGOPT + EXTRAFFPRAM + X264OPTVAL + X264OPT + ":pass=1" + FAST1STFLAG + REFVAL + CQMVAL + ADVOPT + CFRVAL + DEBLOCKVAL + VIDEOVAL + ASPECTRATIOVAL + CBRVAL + ENABLELOG + X264FAST1STFLAG +
                 MULTITRACK + AUDIOMAPVAL + AUDIOCHKVAL + AUDIOCODECVAL + AUDIOPFVAL + AUDIOBITRATEVAL + AUDIOSAMPLEVAL + AUDIOCHANNELVAL + AUDIOVAL + SUBTITLECHKVAL + METADATA + " " + "-f mp4 NUL " + " & " +
            FFMPEGEXE + CUSTOMFFMPEGOPTF + GPTSIDTS + TRIMSSVAL + " -i " + """" + INPUTVIDNAME + """" + AUDIODELAYVAL + INPUTAUDFILENAME + SUBTITLEPATH + TRIMTOVAL + VIDEOFILTER + CODEC + CODECPRESET + PFVAL + LVVAL + KEYINTVAL + BITVAL + CUSTOMFFMPEGOPT + EXTRAFFPRAM + X264OPTVAL + X264OPT + ":pass=2" + REFVAL + CQMVAL + ADVOPT + CFRVAL + DEBLOCKVAL + VIDEOVAL + ASPECTRATIOVAL + CBRVAL + ENABLELOG +
            MULTITRACK + AUDIOMAPVAL + AUDIOCHKVAL + AUDIOCODECVAL + AUDIOPFVAL + AUDIOBITRATEVAL + AUDIOSAMPLEVAL + AUDIOCHANNELVAL + AUDIOVAL + SUBTITLECHKVAL + METADATA + " " + """" + OUTPUTFILENAME + """"
        Else
            SHELLCMD = FFMPEGEXE + " -y " + CUSTOMFFMPEGOPTF + GPTSIDTS + TRIMSSVAL + AUDIODELAYVAL + " -i " + """" + INPUTVIDNAME + """" + INPUTAUDFILENAME + SUBTITLEPATH + TRIMTOVAL + VIDEOFILTER + CODEC + CODECPRESET + PFVAL + LVVAL + KEYINTVAL + BITVAL + CUSTOMFFMPEGOPT + EXTRAFFPRAM + X264OPTVAL + X264OPT + REFVAL + CQMVAL + ADVOPT + CFRVAL + DEBLOCKVAL + VIDEOVAL + ASPECTRATIOVAL + CBRVAL + ENABLELOG +
                     MULTITRACK + AUDIOMAPVAL + AUDIOCHKVAL + AUDIOCODECVAL + AUDIOPFVAL + AUDIOBITRATEVAL + AUDIOSAMPLEVAL + AUDIOCHANNELVAL + AUDIOVAL + SUBTITLECHKVAL + BITSTREAMFILTER + METADATA + FORCEEXTENSION + " " + """" + OUTPUTFILENAME + """"

        End If
        FRMProgress.FFPARAM = SHELLCMD
    End Function
    Public Function getMediainfo() As String()
        MI.Open(InputCBOX.Text)
        BOXCODECINFO.Text = MI.Get_(StreamKind.Visual, 0, "Codec")
        BOXFPSINFO.Text = MI.Get_(StreamKind.Visual, 0, "FrameRate")
        BOXDELAYINFO.Text = MI.Get_(StreamKind.Audio, 0, "Video_Delay")
        INFOFRAMEMODE = MI.Get_(StreamKind.Visual, 0, "FrameRate_Mode")
        If Not BOXDELAYINFO.Text = "" Then
            Dim VDELAYINFO1 As String = (BOXDELAYINFO.Text * (1 / 1000)).ToString
            VDELAYINFO = VDELAYINFO1

            BOXDELAYINFO.Text = VDELAYINFO
        End If





        BOXASPECT.Text = MI.Get_(StreamKind.Visual, 0, "DisplayAspectRatio/String")
        BOXDURATION.Text = MI.Get_(StreamKind.Visual, 0, "Duration/String3")
        BOXDURATION2.Text = MI.Get_(StreamKind.Visual, 0, "Duration")
        BOXPFINFO.Text = MI.Get_(StreamKind.Visual, 0, "Format_Profile")
        BOXFORMATINFO.Text = MI.Get_(StreamKind.General, 0, "Format")
        BOXACODECINFO.Text = MI.Get_(StreamKind.Audio, 0, "Codec")
        BOXREFINFO.Text = MI.Get_(StreamKind.Visual, 0, "Format_Settings_RefFrames")

        MI.Close()
    End Function
    Public Function prepareOpen() As String()
        getMediainfo()
        INPUTFILENAME = InputCBOX.Text
        CHKAVISYNTH.Checked = False
        INPUTFILENAME2 = InputCBOX.Text


        If CHKAUTONAME.Checked Then
            If InputCBOX.Text = "" Then

            ElseIf InStr(5, InputCBOX.Text, "//") Then
                If OutputCBox.Text = "" Then
                    OutputCBox.Text = "[InfinityEncoder]Video.mp4"
                    OUTPUTFILENAME = OutputCBox.Text
                Else

                End If
            ElseIf InStr(InputCBOX.Text, "-f dshow") Then

            Else
                INPUTVIDNAME = InputCBOX.Text
                Dim testFile As System.IO.FileInfo
                testFile = My.Computer.FileSystem.GetFileInfo(INPUTVIDNAME)
                Dim folderPath As String = testFile.DirectoryName
                Dim infileName As String = testFile.Name
                OutputCBox.Text = folderPath + "\[InfinityEncoder]" + infileName
                OUTPUTFILENAME = OutputCBox.Text
            End If
        End If

        LBINPUTINFO.Text = "Video Codec : " + BOXCODECINFO.Text + "   Format : " + BOXFORMATINFO.Text + "   Framerate : " + BOXFPSINFO.Text + "   Aspect Ratio : " + BOXASPECT.Text + "   Delay : " +
        BOXDELAYINFO.Text + " Sec" & vbCrLf & "Duration : " + BOXDURATION.Text + "   Profile : " + BOXPFINFO.Text + "   Ref Frames : " + BOXREFINFO.Text + "   Audio Codec : " + BOXACODECINFO.Text

        If CHKQA.Checked = True And Not InputCBOX.Text = "" Then
            BOXCONTAINER.Items.Clear()
            BOXCONTAINER.Items.Add("m3u8")
            BOXCONTAINER.Text = "m3u8"
            INPUTVIDNAME = InputCBOX.Text
            OutputCBox.Text = STARTUPPATH + "\HLS_Output\index.m3u8"
        ElseIf CHKQA.Checked = False Then
            'ChangeItems()
        End If

        SwitchContainer()



    End Function
    Public Function initialValue() As String()
        FPSVAL = ""
        PFVAL = ""
        RSVAL = ""
        LVVAL = ""
        BITVAL = ""
        DEINTVAL = ""
        REFVAL = ""
        KEYINTVAL = ""
        CODEC = ""
        ADVOPT = ""
        TRIMSSVAL = ""
        TRIMTOVAL = ""
        DEBLOCKVAL = ""
        CQMVAL = ""
        VIDEOVAL = ""
        AUDIOVAL = ""
        AUDIOPARAMVAL = ""
        AUDIOPARAMVAL = ""
        AUDIOCODECVAL = ""
        AUDIOBITRATEVAL = ""
        AUDIOSAMPLEVAL = ""
        AUDIOCHANNELVAL = ""
        AUDIOPFVAL = ""
        AUDIODELAYVAL = ""
        AUDIOCHKVAL = ""
        AUDIOMAPVAL = ""
        ASPECTRATIOVAL = ""
        RATIOVALUE = ""
        RS = ""
        CFRVAL = ""
        CBRVAL = ""
        X264OPT = ""
        X264OPTVAL = ""
        INPUTAUDFILENAME = ""
        VIDEOFILTER = ""
        ENABLELOG = ""
        INPUTVIDNAME = ""
        YOUTUBEQ = ""
        SPPVAL = ""
        USHARPFILTER = ""
        MULTITRACK = ""
        TEMPYTFILENAME = ""
        RUNCMD = ""
        SUBTITLEPATH = ""
        dblStringToDblRESULT = Nothing
        dblStringToDblTO = Nothing
        dblStringToDblSS = Nothing

        SHELLCMD = ""


        HLSOPTIONFLAG = ""
        YTMAP = ""
        FAST1STFLAG = ""
        CODECPRESET1ST = ""
        X264FAST1STFLAG = ""
        BITSTREAMFILTER = ""
        FORCEEXTENSION = ""
        VDELAYINFO = ""
        GPTSIDTS = ""
        EXTRAFFPRAM = ""
    End Function


    Private Sub Button9_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        LISTCHKENC2.Items.Clear()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        For i = 0 To LISTCHKENC2.SelectedItems.Count - 1

            LISTCHKENC2.Items.Remove(LISTCHKENC2.SelectedItems(0))

        Next

    End Sub

    Private Sub BTBATCHENC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTBATCHENC.Click
        If My.Computer.FileSystem.FileExists(OutputCBox.Text) Then
            Dim answer As Integer = MsgBox("File already exists. Do you want to overwrite?", MsgBoxStyle.YesNo)
            If answer = DialogResult.Yes Then
                GoTo continueencoding
            ElseIf answer = DialogResult.No Then
                initialValue()
                GoTo noencoding
            End If

        End If
continueencoding:
        If BOXCODECINFO.Text = "" Then
            getMediainfo()
        ElseIf InStr(InputCBOX.Text, "-f dshow") Then
        End If

        Dim CMD As String
        Dim CMD1 As String
        If CHKMULTIENC.Checked = False Then
            'FRMProgress.Close()
        End If
        If CHKMULTIENC.Checked = False Then
            CMD1 = " " + CStr(LISTCHKENC2.Items(0))
        Else
            CMD1 = "cmd /c title Infinity Media Encoder & " + CStr(LISTCHKENC2.Items(0))
        End If

        Dim listIndex As Integer = 1
        For listCount As Integer = 1 To LISTCHKENC2.Items.Count - 1

            CMD = CMD & " & " & CStr(LISTCHKENC2.Items(listIndex))


            listIndex = listIndex + 1

        Next
        If CHKDEBUG.Checked = True Then
            MsgBox(CMD1 + CMD + " & comp.bat", vbNormalFocus)
        End If
        If CHKMULTIENC.Checked = False Then
            SHELLCMD = CMD1 + CMD
            FRMProgress.Show()
        Else
            Shell(CMD1 + CMD + " & comp.bat", vbNormalFocus)
        End If

noencoding:
        initialValue()

        CMD1 = ""
        CMD = ""
        SHELLCMD = ""
    End Sub

    Private Sub BTENCSELECTED_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTENCSELECTED.Click
        If My.Computer.FileSystem.FileExists(OutputCBox.Text) Then
            Dim answer As Integer = MsgBox("File already exists. Do you want to overwrite?", MsgBoxStyle.YesNo)
            If answer = DialogResult.Yes Then
                GoTo continueencoding
            ElseIf answer = DialogResult.No Then
                initialValue()
                GoTo noencoding
            End If

        End If
continueencoding:

        If BOXCODECINFO.Text = "" Then
            getMediainfo()
        ElseIf InStr(InputCBOX.Text, "-f dshow") Then
        End If

        Dim CMD As String
        Dim CMD1 As String
        If CHKMULTIENC.Checked = False Then
            'FRMProgress.Close()
        End If
        If CHKMULTIENC.Checked = False Then
            CMD1 = " " + CStr(LISTCHKENC2.SelectedItems(0))
        Else
            CMD1 = "cmd /c title Infinity Media Encoder & " + CStr(LISTCHKENC2.SelectedItems(0))
        End If

        Dim listIndex As Integer = 1
        For listCount As Integer = 1 To LISTCHKENC2.SelectedItems.Count - 1

            CMD = CMD & " & " & CStr(LISTCHKENC2.SelectedItems(listIndex))


            listIndex = listIndex + 1

        Next
        If CHKDEBUG.Checked = True Then
            MsgBox(CMD1 + CMD + " & comp.bat", vbNormalFocus)
        End If
        If CHKMULTIENC.Checked = False Then
            SHELLCMD = CMD1 + CMD
            FRMProgress.Show()
        Else
            Shell(CMD1 + CMD + " & comp.bat", vbNormalFocus)
        End If
noencoding:
        initialValue()

        CMD1 = ""
        CMD = ""
        SHELLCMD = ""

    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click

        OpenFileDialog2.Filter = "All Files (*.*)|*.*|Subtitle Files |*.srt;*.smi"
        OpenFileDialog2.FilterIndex = 1
        If Not OpenFileDialog2.ShowDialog = Windows.Forms.DialogResult.Cancel Then
            strFileNameOpen = OpenFileDialog2.FileName

            BOXSUBPATH.Text = strFileNameOpen
        End If
    End Sub

    Private Sub Button8_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        If Not InputCBOX.Text = "" And Not OutputCBox.Text = "" Then

            Dim testFile As System.IO.FileInfo
            testFile = My.Computer.FileSystem.GetFileInfo(OutputCBox.Text)
            Dim folderPath As String = testFile.DirectoryName
            Process.Start(folderPath)
        Else
            MsgBox("Please specific Input Path / Output Path", MsgBoxStyle.Critical)
        End If

    End Sub


    Private Sub InputCBOX_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles InputCBOX.DragDrop
        Dim files() As String = e.Data.GetData(DataFormats.FileDrop)
        For Each path In files
            InputCBOX.Text = path
            prepareOpen()
            SwitchContainer()
        Next
    End Sub

    Private Sub InputCBOX_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles InputCBOX.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If

    End Sub


    Private Sub BOXACODEC_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BOXACODEC.SelectedIndexChanged
        If BOXACODEC.Text = "copy" Then
            BOXAUDBITRATE.Enabled = False
            BOXSAMPLE.Enabled = False
            BOXCHANNEL.Enabled = False
            BOXAACPF.Enabled = False

        ElseIf BOXACODEC.Text = "libfdk_aac" Then
            BOXAUDBITRATE.Enabled = True
            BOXSAMPLE.Enabled = True
            BOXCHANNEL.Enabled = True
            BOXAACPF.Enabled = True
            BOXAACPF.Items.Clear()
            BOXAACPF.Text = "Auto"
            BOXAACPF.Items.Add("Auto")
            BOXAACPF.Items.Add("aac_low")
            BOXAACPF.Items.Add("aac_he")
            BOXAACPF.Items.Add("aac_he_v2")
            BOXAACPF.Items.Add("aac_ld")
            BOXAACPF.Items.Add("aac_eld")


        ElseIf BOXACODEC.Text = "PCM" Then
            BOXAUDBITRATE.Enabled = False
            BOXSAMPLE.Enabled = True
            BOXCHANNEL.Enabled = True
            BOXAACPF.Enabled = True
            BOXAACPF.Items.Clear()
            BOXAACPF.Text = "pcm_s16le"
            BOXAACPF.Items.Add("pcm_s16le")
            BOXAACPF.Items.Add("pcm_s16be")
            BOXAACPF.Items.Add("pcm_s24le")
            BOXAACPF.Items.Add("pcm_s24be")
            BOXAACPF.Items.Add("pcm_s32le")
            BOXAACPF.Items.Add("pcm_s32be")
            BOXAACPF.Items.Add("pcm_f32le")
            BOXAACPF.Items.Add("pcm_f32be")
            BOXAACPF.Items.Add("pcm_f64be")
            BOXAACPF.Items.Add("pcm_u8")
            BOXAACPF.Items.Add("pcm_s8")
            BOXAACPF.Items.Add("adpcm_yamaha")
            BOXAACPF.Items.Add("adpcm_ms")
            BOXAACPF.Items.Add("adpcm_ima_wav")

        ElseIf BOXACODEC.Text = "dca" Then
            BOXAUDBITRATE.Enabled = False
            BOXSAMPLE.Enabled = True
            BOXCHANNEL.Enabled = False
            BOXAACPF.Enabled = False

        ElseIf BOXACODEC.Text = "No Audio" Then
            BOXAUDBITRATE.Enabled = False
            BOXSAMPLE.Enabled = False
            BOXCHANNEL.Enabled = False
            BOXAACPF.Enabled = False

        Else
            BOXAUDBITRATE.Enabled = True
            BOXSAMPLE.Enabled = True
            BOXCHANNEL.Enabled = True
            BOXAACPF.Enabled = False

        End If

        If BOXCODEC.Text = "No Video" Then
            If BOXACODEC.Text = "libfdk_aac" Then
                BOXCONTAINER.Items.Clear()
                BOXCONTAINER.Text = "m4a"
                BOXCONTAINER.Items.Add("m4a")
                BOXCONTAINER.Items.Add("aac")

            ElseIf BOXACODEC.Text = "libmp3lame" Then
                BOXCONTAINER.Items.Clear()
                BOXCONTAINER.Text = "mp3"
                BOXCONTAINER.Items.Add("mp3")

            ElseIf BOXACODEC.Text = "ac3" Then
                BOXCONTAINER.Items.Clear()
                BOXCONTAINER.Text = "ac3"
                BOXCONTAINER.Items.Add("ac3")

            ElseIf BOXACODEC.Text = "PCM" Then
                BOXCONTAINER.Items.Clear()
                BOXCONTAINER.Text = "wav"
                BOXCONTAINER.Items.Add("wav")

            ElseIf BOXACODEC.Text = "libvorbis" Then
                BOXCONTAINER.Items.Clear()
                BOXCONTAINER.Text = "ogg"
                BOXCONTAINER.Items.Add("ogg")

            ElseIf BOXACODEC.Text = "libopus" Then
                BOXCONTAINER.Items.Clear()
                BOXCONTAINER.Text = "opus"
                BOXCONTAINER.Items.Add("opus")

            ElseIf BOXACODEC.Text = "dca" Then
                BOXCONTAINER.Items.Clear()
                BOXCONTAINER.Text = "dts"
                BOXCONTAINER.Items.Add("dts")

            ElseIf BOXACODEC.Text = "wmav2" Then
                BOXCONTAINER.Items.Clear()
                BOXCONTAINER.Text = "wma"
                BOXCONTAINER.Items.Add("wma")
            Else
                BOXCONTAINER.Items.Clear()
                BOXCONTAINER.Items.Add("mp3")
                BOXCONTAINER.Items.Add("aac")
                BOXCONTAINER.Items.Add("m4a")
                BOXCONTAINER.Items.Add("ac3")
                BOXCONTAINER.Items.Add("flac")
                BOXCONTAINER.Items.Add("ogg")
                BOXCONTAINER.Items.Add("opus")
                BOXCONTAINER.Items.Add("dts")
                BOXCONTAINER.Items.Add("wav")
                BOXCONTAINER.Items.Add("wma")
            End If
        End If

    End Sub
    Public Function SwitchContainer() As String()

        If OutputCBox.Text = "" Or InStr(InputCBOX.Text, "-f dshow") Then

        Else
            Dim originalFile As String = OutputCBox.Text
            Dim newName As String = Path.ChangeExtension(originalFile, BOXCONTAINER.Text)
            OutputCBox.Text = newName

        End If


    End Function

    Private Sub Button4_Click_3(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        FRMCUSTOMENC.ShowDialog()
    End Sub

    Private Sub CHKDEBUG_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHKDEBUG.CheckedChanged
        If CHKDEBUG.Checked = True Then
            BOXDEBUG.Enabled = True
        Else
            BOXDEBUG.Enabled = False
        End If
    End Sub


    Private Sub BTNSTARTNGINX_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNSTARTNGINX.Click
        Shell("cmd /c cd nginx & nginx.exe", vbNormalFocus)
    End Sub

    Private Sub BTNSTOPNGINX_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNSTOPNGINX.Click
        Shell("cmd /c cd nginx & nginx -s stop", vbNormalFocus)
    End Sub

    Private Sub BOXCONTAINER_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles BOXCONTAINER.SelectedValueChanged
        SwitchContainer()
    End Sub

    Private Sub BOXCONTAINER_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles BOXCONTAINER.TextChanged
        SwitchContainer()
    End Sub

    Private Sub OutputCBox_TextUpdate(ByVal sender As Object, ByVal e As System.EventArgs) Handles OutputCBox.TextUpdate
        If Not OutputCBox.Text = "" Then
            Dim ext As String = System.IO.Path.GetExtension(OutputCBox.Text)
            Dim ext2 As String = ext.Replace(".", "")
            BOXCONTAINER.Text = ext2
        Else

        End If

    End Sub


    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        If Not InputCBOX.Text = "" And Not OutputCBox.Text = "" Then
            prepareEncoding()
            prepareEncoding2()

            OUTPUTFILENAME = "-"
            FORCEEXTENSION = " -f mpegts "
            SHELLCMD = FFMPEGEXE + CUSTOMFFMPEGOPTF + GPTSIDTS + TRIMSSVAL + AUDIODELAYVAL + " -i " + """" + INPUTVIDNAME + """" + INPUTAUDFILENAME + SUBTITLEPATH + TRIMTOVAL + VIDEOFILTER + CODEC + CODECPRESET + PFVAL + LVVAL + KEYINTVAL + BITVAL + CUSTOMFFMPEGOPT + EXTRAFFPRAM + X264OPTVAL + X264OPT + REFVAL + CQMVAL + ADVOPT + CFRVAL + DEBLOCKVAL + VIDEOVAL + ASPECTRATIOVAL + CBRVAL + ENABLELOG +
                     MULTITRACK + AUDIOMAPVAL + AUDIOCHKVAL + AUDIOCODECVAL + AUDIOPFVAL + AUDIOBITRATEVAL + AUDIOSAMPLEVAL + AUDIOCHANNELVAL + AUDIOVAL + SUBTITLECHKVAL + BITSTREAMFILTER + METADATA + FORCEEXTENSION + " " + """" + OUTPUTFILENAME + """"
            Shell("cmd /c title Infinity Media Encoder & " + SHELLCMD + " | " + FFPLAYEXE + " -i - " + BITSTREAMFILTER + " &  comp.bat", vbNormalFocus)
            If CHKDEBUG.Checked Then
                BOXDEBUG.Text = "cmd /c title Infinity Media Encoder & " + SHELLCMD + " | " + FFPLAYEXE + " -i - " + BITSTREAMFILTER + " &  comp.bat"
            End If

            initialValue()
        End If
    End Sub

    Private Sub BOXAUDIOPATH_DragDrop(sender As Object, e As System.Windows.Forms.DragEventArgs) Handles BOXAUDIOPATH.DragDrop
        Dim files() As String = e.Data.GetData(DataFormats.FileDrop)
        For Each path In files
            BOXAUDIOPATH.Text = path
        Next
    End Sub

    Private Sub BOXAUDIOPATH_DragEnter(sender As Object, e As System.Windows.Forms.DragEventArgs) Handles BOXAUDIOPATH.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    Private Sub Button14_Click(sender As System.Object, e As System.EventArgs) Handles Button14.Click
        If CHKAVISYNTH.Checked = True Then
            FFMPEGEXE = """" + STARTUPPATH + "\Tools\ffmpeg32\ffmpeghyb32.exe" + """"
        ElseIf InStr(InputCBOX.Text, "-f dshow") Then
            FFMPEGEXE = """" + STARTUPPATH + "\Tools\ffmpeg32\ffmpeghyb32.exe " + """"
        ElseIf BOXFFMPEGEXE.Text = "64bit FFmpeg" Then
            FFMPEGEXE = """" + STARTUPPATH + "\Tools\ffmpeg64\ffmpeghyb64.exe" + """"
        ElseIf BOXFFMPEGEXE.Text = "32bit FFmpeg" Then
            FFMPEGEXE = """" + STARTUPPATH + "\Tools\ffmpeg32\ffmpeghyb32.exe" + """"
        Else
            FFMPEGEXE = """" + BOXFFMPEGEXE.Text + """"
        End If

        INPUTVIDNAME = InputCBOX.Text

        If InStr(InputCBOX.Text, "-f dshow") Or InStr(InputCBOX.Text, "//") Then

        Else
            Dim testFile As System.IO.FileInfo
            testFile = My.Computer.FileSystem.GetFileInfo(INPUTVIDNAME)
            Dim folderPath As String = testFile.DirectoryName + "\"
            Dim SHELLCMD2 As String


            Dim infileName As String = IO.Path.GetFileNameWithoutExtension(INPUTVIDNAME)

            SHELLCMD = FFMPEGEXE + " -y -i " + """" + INPUTVIDNAME + """" + " -c copy -an " + """" + folderPath + infileName + ".mkv" + """"
            SHELLCMD2 = FFMPEGEXE + " -y -i " + """" + folderPath + infileName + ".mkv" + """" + " -f rawvideo " + """" + folderPath + infileName + ".yuv" + """" + " & del " + """" + folderPath + infileName + ".mkv" + """"
            Shell("cmd /c title Infinity Media Encoder & " + SHELLCMD + " & " + SHELLCMD2 + " & comp.bat", vbNormalFocus)
            If CHKDEBUG.Checked Then
                BOXDEBUG.Text = "cmd /c title Infinity Media Encoder & " + SHELLCMD + " & " + SHELLCMD2 + " & comp.bat"
            End If
        End If

        initialValue()

    End Sub

    Private Sub BTNADV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNADV.Click
        If BOXCODEC.Text = "libx264" Then
            AdvancedFRM.ShowDialog()
        Else
            MsgBox("Advanced Options only support on libx264 Codec", MsgBoxStyle.Information)
        End If

    End Sub

    Private Sub CHKQA_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles CHKQA.CheckedChanged
        If CHKQA.Checked = True And Not InputCBOX.Text = "" Then
            BOXCONTAINER.Items.Clear()
            BOXCONTAINER.Items.Add("m3u8")
            BOXCONTAINER.Text = "m3u8"
            INPUTVIDNAME = InputCBOX.Text
            OutputCBox.Text = STARTUPPATH + "\HLS_Output\index.m3u8"
        ElseIf CHKQA.Checked = False Then
            ChangeItems()
        End If
        SwitchContainer()
        If CHKQA.Checked = True Then
            CHKSMOOTH.Enabled = False
            'CHKDASH.Enabled = False
        Else
            CHKSMOOTH.Enabled = True
            'CHKDASH.Enabled = True
        End If


    End Sub
    Public Function SWBitratemode() As String()
        If BOXBITRATEMODE.Text = "CRF" Then
            LBBPS.Text = ""
            LBBITRATE.Text = "CRF"
            LBBPS2.Text = ""
            BITBOX2.Enabled = False
            BITBOX2.Visible = False

            BITBOX.Items.Clear()
            BITBOX.Items.Add("Auto")
            BITBOX.Items.Add("24")
            BITBOX.Items.Add("25")
            BITBOX.Items.Add("26")
            BITBOX.Items.Add("26.5")
            BITBOX.Items.Add("27")
            BITBOX.Items.Add("28")
            BITBOX.Text = "Auto"

        ElseIf BOXBITRATEMODE.Text = "File Size" Then
            LBBPS.Text = "MB"
            LBBITRATE.Text = "Size"
            LBBPS2.Text = ""
            BITBOX2.Enabled = False
            BITBOX2.Visible = False

            BITBOX.Items.Clear()
            BITBOX.Items.Add("100")
            BITBOX.Items.Add("200")
            BITBOX.Items.Add("300")
            BITBOX.Items.Add("400")
            BITBOX.Items.Add("500")
            BITBOX.Text = "200"
        ElseIf BOXBITRATEMODE.Text = "ABR" Then
            LBBPS.Text = "Kbps"
            LBBITRATE.Text = "Bitrate"
            LBBPS2.Text = ""
            BITBOX2.Enabled = False
            BITBOX2.Visible = False

            BITBOX.Items.Clear()
            BITBOX.Items.Add("Auto")
            BITBOX.Items.Add("500")
            BITBOX.Items.Add("1000")
            BITBOX.Items.Add("1500")
            BITBOX.Items.Add("2000")
            BITBOX.Items.Add("2500")
            BITBOX.Items.Add("3000")
            BITBOX.Items.Add("6000")
            BITBOX.Items.Add("8000")
            BITBOX.Items.Add("11000")
            BITBOX.Items.Add("12000")
            BITBOX.Text = "8000"

        ElseIf BOXBITRATEMODE.Text = "CRF-MaxBitrate" Then
            LBBPS.Text = "Max"
            LBBITRATE.Text = "CRF"
            LBBPS2.Text = "Kbps"
            BITBOX2.Enabled = True
            BITBOX2.Visible = True

            BITBOX.Items.Clear()
            BITBOX.Items.Add("Auto")
            BITBOX.Items.Add("24")
            BITBOX.Items.Add("25")
            BITBOX.Items.Add("26")
            BITBOX.Items.Add("26.5")
            BITBOX.Items.Add("27")
            BITBOX.Items.Add("28")
            BITBOX.Text = "Auto"
        Else
            LBBPS.Text = "Kbps"
            LBBITRATE.Text = "Bitrate"
            LBBPS2.Text = ""
            BITBOX2.Enabled = False
            BITBOX2.Visible = False
            BITBOX.Items.Clear()
            BITBOX.Items.Add("Auto")
            BITBOX.Items.Add("500")
            BITBOX.Items.Add("1000")
            BITBOX.Items.Add("1500")
            BITBOX.Items.Add("2000")
            BITBOX.Items.Add("2500")
            BITBOX.Items.Add("3000")
            BITBOX.Items.Add("6000")
            BITBOX.Items.Add("8000")
            BITBOX.Items.Add("11000")
            BITBOX.Items.Add("12000")
            BITBOX.Text = "8000"
        End If
    End Function

    Private Sub BOXBITRATEMODE_TextChanged(sender As Object, e As System.EventArgs) Handles BOXBITRATEMODE.TextChanged
        SWBitratemode()


    End Sub

    Private Sub BOXBITRATEMODE_TextUpdate(sender As Object, e As System.EventArgs) Handles BOXBITRATEMODE.TextUpdate
        SWBitratemode()
    End Sub

    Private Sub CHKINPUTDSHOW_CheckedChanged(sender As Object, e As EventArgs) Handles CHKINPUTDSHOW.CheckedChanged
        If CHKINPUTDSHOW.Checked = True Then
            INPUTVIDNAME = "-rtbufsize 2M -f dshow -i video=" + """" + BOXDSHOWVID.Text + """"
            INPUTAUDFILENAME = " -f dshow -i audio=" + """" + BOXDSHOWAUD.Text + """" + " -pix_fmt yuv420p "
            InputCBOX.Text = " " + INPUTVIDNAME + INPUTAUDFILENAME
        End If
    End Sub

    Public Function Bitrateparam() As String()
        If BITBOX.Text = "Auto" Then
            BITVAL = ""
            CBRVAL = ""
        Else
            If BOXBITRATEMODE.Text = "CBR" Or BOXBITRATEMODE.Text = "ABR" Or BOXBITRATEMODE.Text = "2pass-ABR" Then
                BITVAL = " -b:v " + BITBOX.Text + "k"
            ElseIf BOXBITRATEMODE.Text = "CRF" Then
                BITVAL = " -crf " + BITBOX.Text
            End If

            If BOXBITRATEMODE.Text = "CBR" And Not BITBOX.Text = "" Then
                CBRVAL = " -bufsize:v " + BITBOX.Text + "k " + " -maxrate:v " + BITBOX.Text + "k " + "-minrate:v " + BITBOX.Text + "k "
            ElseIf BOXBITRATEMODE.Text = "CRF" Then
                CBRVAL = ""
            ElseIf BOXBITRATEMODE.Text = "CRF-MaxBitrate" Then
                BITVAL = " -crf " + BITBOX.Text
                CBRVAL = " -bufsize:v " + BITBOX2.Text + "k " + "-maxrate:v " + BITBOX2.Text + "k "
            ElseIf BOXBITRATEMODE.Text = "File Size" Then
                If CHKTRIM.Checked Then
                    sDate = BOXTRIMSS.Text
                    hours = Trim(Split(sDate, ":")(0))
                    minutes = Trim(Split(sDate, ":")(1))
                    seconds = Trim(Split(sDate, ":")(2))
                    dblStringToDblSS = CLng(hours) * 3600 + CLng(minutes) * 60 + CLng(seconds)

                    sDate = BOXTRIMTO.Text
                    hours = Trim(Split(sDate, ":")(0))
                    minutes = Trim(Split(sDate, ":")(1))
                    seconds = Trim(Split(sDate, ":")(2))
                    dblStringToDblTO = CLng(hours) * 3600 + CLng(minutes) * 60 + CLng(seconds)

                    dblStringToDblRESULT = dblStringToDblTO - dblStringToDblSS
                    Dim TRIMDURATION As Integer = CInt(Int(dblStringToDblRESULT))
                    Dim VIDEOBITRATESIZE As Integer
                    Dim DURSECRESULT3 As Integer
                    DURSECRESULT3 = Microsoft.VisualBasic.Left(BOXDURATION2.Text, BOXDURATION2.Text.Length - 3)
                    VIDEOBITRATESIZE = BITBOX.Text * 8192 / TRIMDURATION
                    BITVAL = " -b:v " + VIDEOBITRATESIZE.ToString + "k" + " -bufsize:v " + VIDEOBITRATESIZE.ToString + "k"

                Else
                    Dim VIDEOBITRATESIZE As Integer
                    Dim DURSECRESULT3 As Integer
                    DURSECRESULT3 = Microsoft.VisualBasic.Left(BOXDURATION2.Text, BOXDURATION2.Text.Length - 3)
                    VIDEOBITRATESIZE = BITBOX.Text * 8192 / DURSECRESULT3

                    BITVAL = " -b:v " + VIDEOBITRATESIZE.ToString + "k" + " -bufsize:v " + VIDEOBITRATESIZE.ToString + "k"
                End If
            Else
                CBRVAL = " -bufsize:v " + BITBOX.Text + "k " + "-maxrate:v " + BITBOX.Text + "k " + "-minrate:v " + BITBOX.Text + "k "
            End If
        End If

        If BOXBITRATEMODE.Text = "ABR" Then
            CBRVAL = ""
        End If

        If Not BOXAUDBITRATE.Text = "Auto" And Not BOXACODEC.Text = "No Audio" Then
            AUDIOBITRATEVAL = " -b:a " + BOXAUDBITRATE.Text + "k"
        End If
        If BOXAUDBITRATE.Text = "Auto" And Not BOXACODEC.Text = "No Audio" And Not BOXACODEC.Text = "copy" And Not BOXACODEC.Text = "PCM" And Not BOXACODEC.Text = "dca" Then
            AUDIOBITRATEVAL = " -b:a 256k"
        End If
        If Not BOXSAMPLE.Text = "Auto" And Not BOXACODEC.Text = "No Audio" Then
            AUDIOSAMPLEVAL = " -ar " + BOXSAMPLE.Text
        End If

        If Not BOXCHANNEL.Text = "Auto" And Not BOXACODEC.Text = "No Audio" Then
            AUDIOCHANNELVAL = " -ac " + BOXCHANNEL.Text
        End If
    End Function

    Private Sub CHKCHLSADDRESS_CheckedChanged(sender As Object, e As EventArgs) Handles CHKCHLSADDRESS.CheckedChanged
        If CHKCHLSADDRESS.Checked = True Then
            BOXCHLSADDRESS.Enabled = True
        ElseIf CHKCHLSADDRESS.Checked = False Then
            BOXCHLSADDRESS.Enabled = False
            BOXCHLSADDRESS.Text = ""
        End If
    End Sub

    Private Sub CHKSMOOTH_CheckedChanged(sender As Object, e As EventArgs) Handles CHKSMOOTH.CheckedChanged
        If CHKSMOOTH.Checked = True And Not InputCBOX.Text = "" Then
            BOXCONTAINER.Items.Clear()
            BOXCONTAINER.Items.Add("ismv")
            BOXCONTAINER.Items.Add("isma")
            BOXCONTAINER.Text = "ismv"
            INPUTVIDNAME = InputCBOX.Text
        ElseIf CHKQA.Checked = False Then
            ChangeItems()
        End If
        SwitchContainer()

        If CHKSMOOTH.Checked = True Then
            CHKQA.Enabled = False
            'CHKDASH.Enabled = False
        Else
            CHKQA.Enabled = True
            'CHKDASH.Enabled = True
        End If
    End Sub

    Private Sub Button10_Click_1(sender As Object, e As EventArgs) Handles Button10.Click
        About.ShowDialog()
    End Sub
End Class