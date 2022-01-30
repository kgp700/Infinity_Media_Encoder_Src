Imports System.Xml
Imports System.IO
Imports System.IO.Path
Imports System.Xml.Serialization
Imports System.Threading
Imports System.Data.OleDb
Imports System.Security
Imports System.Security.Cryptography
Imports System.Text
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Text.RegularExpressions
Imports System.Xml.Linq.XDocument

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
    Public OUTPUTFILENAMEONLY As String
    Public FPSVAL As String
    Public LVVAL As String
    Public PFVAL As String
    Public RSVAL As String
    Public BITVAL As String
    Public BITMODE As String
    Public REFVAL As String
    Public DEINTVAL As String
    Public KEYINTVAL As String
    Public CODEC As String
    Public ADVOPT As String
    Public X264OPT As String
    Public TRIMSSVAL As String
    Public TRIMTOVAL As String
    Public AUDIOTRIMSSVAL As String
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
    Public AUDIOBITVAL As String
    Public X264OPTVAL As String
    Public VCODECOPT As String
    Public VIDFILTERFLAG As String
    Public STARTTIME As String
    Public isInterlaced As String
    Public qualityinfo As String
    Public LOADEDMEDIA As String

    Public ASPECTRATIOVAL As String
    Public RATIOVALUE As String
    Public RS As String
    Public VIDEOFILTER As String
    Public AUDIOFILTER As String
    Public CFRVAL As String
    Public CBRVAL As String
    Public ENABLELOG As String
    Public YOUTUBEQ As String
    Public YOUTUBEAUDQ As String
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
    Public CUSTOMAUDIOFILTER As String
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
    Public RMMETADATAVAL As String
    Public TRIMCHKVAL As Boolean
    Public TRIMSS As String
    Public TRIMTO As String
    Public GPTSIDTS As String
    Private TEMPFILENAME As String
    Private tempinputfileName As String


    Public STREAMPARAM As String
    Public STREAMINPUT As String
    Public STREAMOUTPUT As String
    Public HLSADDRESS As String
    Public STARTUPPATH As String
    Public FFPLAYEXE As String
    Public LIVESTREAMEREXE As String
    Public YOUTUBEDLPATH As String
    Public MULTIENCODINGFLAG As Boolean
    Private PRESETLOADING As Boolean
    Public osver As System.OperatingSystem

    Dim DURHOURS As Integer
    Dim DURMIN As Integer
    Dim DURSEC As Integer
    Dim DURT As Integer
    Dim DURSS As Integer
    Dim DURSS2 As Integer
    Dim FILENUM As Integer
    Dim FFLAGS As String
    Private realtimeenc As String
    Public Run1 As String
    Public PRESETFILENAME As String
    Dim DISCORRUPT As String

    Dim sDate As String
    Dim hours As String
    Dim minutes As String
    Dim seconds As String
    Dim dblStringToDblSS As Double
    Dim dblStringToDblTO As Double
    Dim dblStringToDblRESULT As Double
    Dim YTVP9ONLY As Boolean
    Public FLVOPT As String
    Private A251OPUS As String
    Private A140M4A As String
    Private V243VP9360P As String
    Private V134AVC360P As String
    Private V244VP9480P As String
    Private V135AVC480P As String
    Private V247VP9720P As String
    Private V136AVC720P As String
    Private V302VP9720P60F As String
    Private V298AVC720P60F As String
    Private V303VP91080P60F As String
    Private V299AVC1080P60F As String
    Private V335VP91080P60FH As String
    Private V699AV11080P60FH As String
    Private V401AV12160P60FH As String
    Private V315VP92160P60F As String
    Private V337VP92160P60FH As String
    Private V701AV12160P60FH As String
    Private V702AV14320P60FH As String

    Dim iRow, iCol As Integer

    Dim MI As New MediaInfo
    Dim WScript
    Private FileName As String = System.IO.Path.Combine(Application.StartupPath, "Settings.xml")





    Private Sub BTNINPUT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNINPUT.Click
        If BTNINPUT.Text = "Settings" Then
            FRMDSHOW.Show()
        Else
            If InputCBOX.Text = "" Then
                OpenFileDialog1.FileName = ""
            Else
                Try
                    Dim filenameinfo As System.IO.FileInfo
                    filenameinfo = My.Computer.FileSystem.GetFileInfo(InputCBOX.Text)
                    OpenFileDialog1.FileName = filenameinfo.Name
                Catch

                End Try

            End If


            OpenFileDialog1.Filter = "All Files (*.*)|*.*|Video Files |*.mkv;*.mp4;*.ts;*.avi;*.mov;*.3gp;*.wmv;*.m2ts;*.flv;*.mpeg;*.webm;*.mpg|MP4 |*.mp4"
            OpenFileDialog1.FilterIndex = 1


            If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                strFileNameOpen = OpenFileDialog1.FileName


                InputCBOX.Text = strFileNameOpen
            End If
            getMediainfo()
            prepareOpen()

        End If
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

    Private Sub BTNOUTPUT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNOUTPUT.Click
        If OutputCBox.Text = "" Then
        Else
            Dim filenameinfo3 As System.IO.FileInfo
            filenameinfo3 = My.Computer.FileSystem.GetFileInfo(OutputCBox.Text)
            SaveFileDialog1.FileName = filenameinfo3.Name
        End If


        SaveFileDialog1.Filter = BOXCONTAINER.Text + " file|" + "*." + BOXCONTAINER.Text
        SaveFileDialog1.FilterIndex = 1

        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            strFileNameSave = SaveFileDialog1.FileName
            OutputCBox.Text = strFileNameSave
            OUTPUTFILENAME = OutputCBox.Text
        End If


    End Sub


    Private Sub BOXCODEC_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles BOXCODEC.TextChanged
        ChangeCodecOPT()
        If BOXCONTAINER.Text = "=== HLS Encoding Mode ===" Then
        Else
            'ChangeItems()
        End If

        If Not BOXCODEC.Text = "libx264" And Not BOXCODEC.Text = "libx265" And Not BOXCODEC.Text = "libsvtav1" Then
            BOXBITRATEMODE.Text = "CBR"
        ElseIf BOXCODEC.Text = "libsvtav1" Then
            BOXBITRATEMODE.Text = "CRF(CQP)"
        End If

        If InputCBOX.Text.Contains("http://ustream.tv") Or InputCBOX.Text.Contains("http://www.ustream.tv") Or InputCBOX.Text.Contains("https://ustream.tv/") Or
            InputCBOX.Text.Contains("https://www.ustream.tv/") Or InputCBOX.Text.Contains("http://www.connectcast.tv/") Or InputCBOX.Text.Contains("http://connectcast.tv/") Or InputCBOX.Text.Contains("http://www.dailymotion.com") Or
            InputCBOX.Text.Contains("https://twitch.tv/") Or InputCBOX.Text.Contains("https://www.twitch.tv/") Then
            CHKMULTITR.Enabled = False

        End If


    End Sub
    Public Function AddFormat() As String()

        BOXCONTAINER.Items.Clear()
        BOXCONTAINER.Items.Add("=== Video ===")

        BOXCONTAINER.Items.Add("mp4")
        BOXCONTAINER.Items.Add("mkv")
        BOXCONTAINER.Items.Add("avi")
        BOXCONTAINER.Items.Add("ts")
        BOXCONTAINER.Items.Add("flv")
        BOXCONTAINER.Items.Add("mov")
        BOXCONTAINER.Items.Add("3gp")
        BOXCONTAINER.Items.Add("3g2")
        BOXCONTAINER.Items.Add("webm")
        BOXCONTAINER.Items.Add("wmv")

        BOXCONTAINER.Items.Add("=== Audio ===")
        BOXCONTAINER.Items.Add("m4a")
        BOXCONTAINER.Items.Add("aac")
        BOXCONTAINER.Items.Add("mp3")
        BOXCONTAINER.Items.Add("ogg")
        BOXCONTAINER.Items.Add("flac")
        BOXCONTAINER.Items.Add("ac3")
        BOXCONTAINER.Items.Add("wav")
        BOXCONTAINER.Items.Add("wma")
        BOXCONTAINER.Items.Add("opus")
        BOXCONTAINER.Items.Add("dts")
        BOXCONTAINER.Items.Add("mp2")

        BOXCONTAINER.Items.Add("=== RTMP Streaming Mode ===")
        BOXCONTAINER.Items.Add("=== HLS Encoding Mode ===")
        BOXCONTAINER.Items.Add("=== Smooth Encoding Mode ===")
        BOXCONTAINER.Items.Add("=== DASH Encoding Mode ===")


    End Function

    Public Function ChangeItems() As String()
        If BOXCONTAINER.Text = "mp4" Then
            BOXCODEC.Items.Clear()


            BOXCODEC.Items.Add("libx264")
            BOXCODEC.Items.Add("libx265")
            BOXCODEC.Items.Add("h264_nvenc")
            BOXCODEC.Items.Add("hevc_nvenc")
            BOXCODEC.Items.Add("libsvtav1")
            BOXCODEC.Items.Add("mpeg4")
            BOXCODEC.Items.Add("libxvid")
            BOXCODEC.Items.Add("copy")
            BOXCODEC.Items.Add("No Video")
            If Not BOXCODEC.Items.Contains(BOXCODEC.Text) Then

                BOXCODEC.Text = "libx264"
            End If



            BOXACODEC.Items.Clear()
            BOXACODEC.Items.Add("libfdk_aac")
            BOXACODEC.Items.Add("libmp3lame")
            BOXACODEC.Items.Add("ac3")
            BOXACODEC.Items.Add("eac3")
            BOXACODEC.Items.Add("libvorbis")
            BOXACODEC.Items.Add("dca")
            BOXACODEC.Items.Add("libtwolame")
            BOXACODEC.Items.Add("libvo-amrwbenc")
            BOXACODEC.Items.Add("libopencore_amrnb")
            BOXACODEC.Items.Add("copy")
            BOXACODEC.Items.Add("No Audio")

            BOXACODEC.Text = "libfdk_aac"

        ElseIf BOXCONTAINER.Text = "avi" Then
            BOXCODEC.Items.Clear()
            BOXCODEC.Items.Add("libx264")
            BOXCODEC.Items.Add("libx265")
            BOXCODEC.Items.Add("h264_nvenc")
            BOXCODEC.Items.Add("hevc_nvenc")
            BOXCODEC.Items.Add("libxvid")
            BOXCODEC.Items.Add("divx3")
            BOXCODEC.Items.Add("divx4")
            BOXCODEC.Items.Add("divx5")
            BOXCODEC.Items.Add("h263p")
            BOXCODEC.Items.Add("mpeg4")
            BOXCODEC.Items.Add("msmpeg4")
            BOXCODEC.Items.Add("copy")
            BOXCODEC.Items.Add("No Video")
            If Not BOXCODEC.Items.Contains(BOXCODEC.Text) Then
                BOXCODEC.Text = "libx264"
            End If



            BOXACODEC.Items.Clear()
            BOXACODEC.Items.Add("copy")
            BOXACODEC.Items.Add("libfdk_aac")
            BOXACODEC.Items.Add("libmp3lame")
            BOXACODEC.Items.Add("ac3")
            BOXACODEC.Items.Add("eac3")
            BOXACODEC.Items.Add("flac")
            BOXACODEC.Items.Add("PCM")
            BOXACODEC.Items.Add("libvorbis")
            BOXACODEC.Items.Add("dca")
            BOXACODEC.Items.Add("wmav2")
            BOXACODEC.Items.Add("libtwolame")
            BOXACODEC.Items.Add("No Audio")
            BOXACODEC.Text = "libfdk_aac"

        ElseIf BOXCONTAINER.Text = "mkv" Then
            BOXCODEC.Items.Clear()
            BOXCODEC.Items.Add("libx264")
            BOXCODEC.Items.Add("libx265")
            BOXCODEC.Items.Add("h264_nvenc")
            BOXCODEC.Items.Add("hevc_nvenc")
            BOXCODEC.Items.Add("libaom-av1")
            BOXCODEC.Items.Add("libsvtav1")
            BOXCODEC.Items.Add("libvpx-vp9")
            BOXCODEC.Items.Add("libvpx")
            BOXCODEC.Items.Add("prores_ks")
            BOXCODEC.Items.Add("mpeg4")
            BOXCODEC.Items.Add("libxvid")
            BOXCODEC.Items.Add("divx3")
            BOXCODEC.Items.Add("divx4")
            BOXCODEC.Items.Add("divx5")
            BOXCODEC.Items.Add("h263p")
            BOXCODEC.Items.Add("copy")
            BOXCODEC.Items.Add("No Video")
            If Not BOXCODEC.Items.Contains(BOXCODEC.Text) Then
                BOXCODEC.Text = "libx264"
            End If




            BOXACODEC.Items.Clear()
            BOXACODEC.Items.Add("copy")
            BOXACODEC.Items.Add("libfdk_aac")
            BOXACODEC.Items.Add("libmp3lame")
            BOXACODEC.Items.Add("ac3")
            BOXACODEC.Items.Add("eac3")
            BOXACODEC.Items.Add("dca")
            BOXACODEC.Items.Add("libtwolame")
            BOXACODEC.Items.Add("No Audio")
            BOXACODEC.Text = "libfdk_aac"

        ElseIf BOXCONTAINER.Text = "ts" Then
            BOXCODEC.Items.Clear()
            BOXCODEC.Items.Add("libx264")
            BOXCODEC.Items.Add("libx265")
            BOXCODEC.Items.Add("h264_nvenc")
            BOXCODEC.Items.Add("hevc_nvenc")
            BOXCODEC.Items.Add("libvpx-vp9")
            BOXCODEC.Items.Add("libvpx")
            BOXCODEC.Items.Add("libxvid")
            BOXCODEC.Items.Add("mpeg4")
            BOXCODEC.Items.Add("mpeg2video")
            BOXCODEC.Items.Add("mpeg1video")
            BOXCODEC.Items.Add("h263p")
            BOXCODEC.Items.Add("msmpeg4")
            BOXCODEC.Items.Add("copy")
            BOXCODEC.Items.Add("No Video")

            If Not BOXCODEC.Items.Contains(BOXCODEC.Text) Then
                BOXCODEC.Text = "libx264"
            End If


            BOXACODEC.Items.Clear()
            BOXACODEC.Items.Add("libfdk_aac")
            BOXACODEC.Items.Add("libmp3lame")
            BOXACODEC.Items.Add("ac3")
            BOXACODEC.Items.Add("eac3")
            BOXACODEC.Items.Add("dca")
            BOXACODEC.Items.Add("flac")
            BOXACODEC.Items.Add("PCM")
            BOXACODEC.Items.Add("libvorbis")
            BOXACODEC.Items.Add("libopus")
            BOXACODEC.Items.Add("wmav2")
            BOXACODEC.Items.Add("libtwolame")
            BOXACODEC.Items.Add("copy")
            BOXACODEC.Items.Add("No Audio")
            BOXACODEC.Text = "ac3"

        ElseIf BOXCONTAINER.Text = "flv" Then
            BOXCODEC.Items.Clear()
            BOXCODEC.Items.Add("libx264")
            BOXCODEC.Items.Add("libx265")
            BOXCODEC.Items.Add("h264_nvenc")
            BOXCODEC.Items.Add("hevc_nvenc")
            BOXCODEC.Items.Add("copy")
            BOXCODEC.Items.Add("No Video")
            If Not BOXCODEC.Items.Contains(BOXCODEC.Text) Then
                BOXCODEC.Text = "libx264"
            End If


            BOXACODEC.Items.Clear()
            BOXACODEC.Items.Add("libfdk_aac")
            BOXACODEC.Items.Add("libmp3lame")
            BOXACODEC.Items.Add("ac3")
            BOXACODEC.Items.Add("eac3")
            BOXACODEC.Items.Add("libvorbis")
            BOXACODEC.Items.Add("copy")
            BOXACODEC.Items.Add("No Audio")
            BOXACODEC.Text = "libfdk_aac"

        ElseIf BOXCONTAINER.Text = "mov" Then
            BOXCODEC.Items.Clear()
            BOXCODEC.Items.Add("libx264")
            BOXCODEC.Items.Add("libx265")
            BOXCODEC.Items.Add("h264_nvenc")
            BOXCODEC.Items.Add("hevc_nvenc")
            BOXCODEC.Items.Add("mpeg4")
            BOXCODEC.Items.Add("msmpeg4")
            BOXCODEC.Items.Add("libxvid")
            BOXCODEC.Items.Add("libvpx")
            BOXCODEC.Items.Add("libvpx-vp9")
            BOXCODEC.Items.Add("copy")
            BOXCODEC.Items.Add("No Video")
            If Not BOXCODEC.Items.Contains(BOXCODEC.Text) Then
                BOXCODEC.Text = "libx264"
            End If


            BOXACODEC.Items.Clear()
            BOXACODEC.Items.Add("libfdk_aac")
            BOXACODEC.Items.Add("libmp3lame")
            BOXACODEC.Items.Add("ac3")
            BOXACODEC.Items.Add("eac3")
            BOXACODEC.Items.Add("PCM")
            BOXACODEC.Items.Add("libvorbis")
            BOXACODEC.Items.Add("libtwolame")
            BOXACODEC.Items.Add("libvo-amrwbenc")
            BOXACODEC.Items.Add("libopencore_amrnb")
            BOXACODEC.Items.Add("copy")
            BOXACODEC.Items.Add("No Audio")
            BOXACODEC.Text = "libfdk_aac"

        ElseIf BOXCONTAINER.Text = "3gp" Then
            BOXCODEC.Items.Clear()
            BOXCODEC.Items.Add("libx264")
            BOXCODEC.Items.Add("libx265")
            BOXCODEC.Items.Add("h264_nvenc")
            BOXCODEC.Items.Add("hevc_nvenc")
            BOXCODEC.Items.Add("libxvid")
            BOXCODEC.Items.Add("mpeg4")
            BOXCODEC.Items.Add("copy")
            BOXCODEC.Items.Add("No Video")
            If Not BOXCODEC.Items.Contains(BOXCODEC.Text) Then
                BOXCODEC.Text = "libx264"
            End If


            BOXACODEC.Items.Clear()
            BOXACODEC.Items.Add("libfdk_aac")
            BOXACODEC.Items.Add("copy")
            BOXACODEC.Items.Add("No Audio")
            BOXACODEC.Text = "libfdk_aac"

        ElseIf BOXCONTAINER.Text = "3g2" Then
            BOXCODEC.Items.Clear()
            BOXCODEC.Items.Add("libx264")
            BOXCODEC.Items.Add("libx265")
            BOXCODEC.Items.Add("h264_nvenc")
            BOXCODEC.Items.Add("hevc_nvenc")
            BOXCODEC.Items.Add("libxvid")
            BOXCODEC.Items.Add("mpeg4")
            BOXCODEC.Items.Add("copy")
            BOXCODEC.Items.Add("No Video")
            If Not BOXCODEC.Items.Contains(BOXCODEC.Text) Then
                BOXCODEC.Text = "libx264"
            End If


            BOXACODEC.Items.Clear()
            BOXACODEC.Items.Add("libfdk_aac")
            BOXACODEC.Items.Add("copy")
            BOXACODEC.Items.Add("No Audio")
            BOXACODEC.Text = "libfdk_aac"

        ElseIf BOXCONTAINER.Text = "webm" Then
            BOXCODEC.Items.Clear()
            BOXCODEC.Items.Add("libvpx")
            BOXCODEC.Items.Add("libvpx-vp9")
            BOXCODEC.Items.Add("copy")
            BOXCODEC.Items.Add("No Video")
            If Not BOXCODEC.Items.Contains(BOXCODEC.Text) Then
                BOXCODEC.Text = "libvpx-vp9"
            End If


            BOXACODEC.Items.Clear()
            BOXACODEC.Items.Add("libvorbis")
            BOXACODEC.Items.Add("libopus")
            BOXACODEC.Items.Add("copy")
            BOXACODEC.Items.Add("No Audio")
            BOXACODEC.Text = "libvorbis"

        ElseIf BOXCONTAINER.Text = "wmv" Then
            BOXCODEC.Items.Clear()
            BOXCODEC.Items.Add("wmv2")
            BOXCODEC.Items.Add("copy")
            BOXCODEC.Items.Add("No Video")
            If Not BOXCODEC.Items.Contains(BOXCODEC.Text) Then
                BOXCODEC.Text = "wmv2"
            End If


            BOXACODEC.Items.Clear()
            BOXACODEC.Items.Add("wmav2")
            BOXACODEC.Items.Add("copy")
            BOXACODEC.Items.Add("No Audio")
            BOXACODEC.Text = "wmav2"

        ElseIf BOXCONTAINER.Text = "m4a" Then
            BOXCODEC.Items.Clear()
            BOXCODEC.Items.Add("No Video")
            BOXCODEC.Text = "No Video"

            BOXACODEC.Items.Clear()
            BOXACODEC.Items.Add("libfdk_aac")
            BOXACODEC.Items.Add("copy")
            BOXACODEC.Text = "libfdk_aac"

        ElseIf BOXCONTAINER.Text = "mp3" Then
            BOXCODEC.Items.Clear()
            BOXCODEC.Items.Add("No Video")
            BOXCODEC.Text = "No Video"

            BOXACODEC.Items.Clear()
            BOXACODEC.Items.Add("libmp3lame")
            BOXACODEC.Items.Add("copy")
            BOXACODEC.Text = "libmp3lame"

        ElseIf BOXCONTAINER.Text = "ogg" Then
            BOXCODEC.Items.Clear()
            BOXCODEC.Items.Add("No Video")
            BOXCODEC.Text = "No Video"

            BOXACODEC.Items.Clear()
            BOXACODEC.Items.Add("libvorbis")
            BOXACODEC.Items.Add("libopus")
            BOXACODEC.Items.Add("copy")
            BOXACODEC.Text = "libvorbis"

        ElseIf BOXCONTAINER.Text = "flac" Then
            BOXCODEC.Items.Clear()
            BOXCODEC.Items.Add("No Video")
            BOXCODEC.Text = "No Video"

            BOXACODEC.Items.Clear()
            BOXACODEC.Items.Add("flac")
            BOXACODEC.Items.Add("sox-flac")
            BOXACODEC.Items.Add("copy")
            BOXACODEC.Text = "flac"

        ElseIf BOXCONTAINER.Text = "aac" Then
            BOXCODEC.Items.Clear()
            BOXCODEC.Items.Add("No Video")
            BOXCODEC.Text = "No Video"

            BOXACODEC.Items.Clear()
            BOXACODEC.Items.Add("libfdk_aac")
            BOXACODEC.Items.Add("copy")
            BOXACODEC.Text = "libfdk_aac"

        ElseIf BOXCONTAINER.Text = "ac3" Then
            BOXCODEC.Items.Clear()
            BOXCODEC.Items.Add("No Video")
            BOXCODEC.Text = "No Video"

            BOXACODEC.Items.Clear()
            BOXACODEC.Items.Add("ac3")
            BOXACODEC.Items.Add("eac3")
            BOXACODEC.Items.Add("copy")
            BOXACODEC.Text = "ac3"

        ElseIf BOXCONTAINER.Text = "wav" Then
            BOXCODEC.Items.Clear()
            BOXCODEC.Items.Add("No Video")
            BOXCODEC.Text = "No Video"

            BOXACODEC.Items.Clear()
            BOXACODEC.Items.Add("PCM")
            BOXACODEC.Items.Add("copy")
            BOXACODEC.Text = "PCM"

        ElseIf BOXCONTAINER.Text = "wma" Then
            BOXCODEC.Items.Clear()
            BOXCODEC.Items.Add("No Video")
            BOXCODEC.Text = "No Video"

            BOXACODEC.Items.Clear()
            BOXACODEC.Items.Add("wmav2")
            BOXACODEC.Items.Add("copy")
            BOXACODEC.Text = "wmav2"

        ElseIf BOXCONTAINER.Text = "opus" Then
            BOXCODEC.Items.Clear()
            BOXCODEC.Items.Add("No Video")
            BOXCODEC.Text = "No Video"

            BOXACODEC.Items.Clear()
            BOXACODEC.Items.Add("libopus")
            BOXACODEC.Items.Add("copy")
            BOXACODEC.Text = "libopus"

        ElseIf BOXCONTAINER.Text = "dts" Then
            BOXCODEC.Items.Clear()
            BOXCODEC.Items.Add("No Video")
            BOXCODEC.Text = "No Video"

            BOXACODEC.Items.Clear()
            BOXACODEC.Items.Add("dca")
            BOXACODEC.Items.Add("copy")
            BOXACODEC.Text = "dca"

        ElseIf BOXCONTAINER.Text = "mp2" Then
            BOXCODEC.Items.Clear()
            BOXCODEC.Items.Add("No Video")
            BOXCODEC.Text = "No Video"

            BOXACODEC.Items.Clear()
            BOXACODEC.Items.Add("libtwolame")
            BOXACODEC.Items.Add("copy")
            BOXACODEC.Text = "libtwolame"

        ElseIf BOXCONTAINER.Text = "m3u8" Then
            BOXCODEC.Items.Clear()
            BOXCODEC.Items.Add("libx264")
            BOXCODEC.Items.Add("libx265")
            BOXCODEC.Items.Add("No Video")

            BOXCODEC.Text = "libx264"

            BOXACODEC.Items.Clear()
            BOXACODEC.Items.Add("libfdk_aac")
            BOXACODEC.Items.Add("libmp3lame")
            BOXACODEC.Items.Add("ac3")
            BOXACODEC.Items.Add("eac3")
            BOXACODEC.Items.Add("libvorbis")
            BOXACODEC.Items.Add("copy")
            BOXACODEC.Items.Add("No Audio")
            BOXACODEC.Text = "libfdk_aac"


        End If




    End Function
    Public Function ChangePresetList() As String()
        If BOXCODEC.Text = "hevc_nvenc" Or BOXCODEC.Text = "nvenc" Then
            BOXCODECPRESET.Items.Clear()
            BOXCODECPRESET.Items.Add("hq")
            BOXCODECPRESET.Items.Add("bd")
            BOXCODECPRESET.Items.Add("slow")
            BOXCODECPRESET.Items.Add("medium")
            BOXCODECPRESET.Items.Add("fast")
            BOXCODECPRESET.Items.Add("lq")
            If PRESETLOADING = False Then
                BOXCODECPRESET.Text = "slow"
            End If

        ElseIf BOXCODEC.Text = "libsvtav1" Then
            BOXCODECPRESET.Items.Clear()
            BOXCODECPRESET.Items.Add("0")
            BOXCODECPRESET.Items.Add("1")
            BOXCODECPRESET.Items.Add("2")
            BOXCODECPRESET.Items.Add("3")
            BOXCODECPRESET.Items.Add("4")
            BOXCODECPRESET.Items.Add("5")
            BOXCODECPRESET.Items.Add("6")
            BOXCODECPRESET.Items.Add("7")
            BOXCODECPRESET.Items.Add("8")
            BOXCODECPRESET.Items.Add("9")
            BOXCODECPRESET.Items.Add("10")
            BOXCODECPRESET.Items.Add("11")
            BOXCODECPRESET.Items.Add("12")
            BOXCODECPRESET.Items.Add("13")
            If PRESETLOADING = False Then
                BOXCODECPRESET.Text = "7"
            End If

        Else
            BOXCODECPRESET.Items.Clear()
            BOXCODECPRESET.Items.Add("ultrafast")
            BOXCODECPRESET.Items.Add("superfast")
            BOXCODECPRESET.Items.Add("veryfast")
            BOXCODECPRESET.Items.Add("fast")
            BOXCODECPRESET.Items.Add("faster")
            BOXCODECPRESET.Items.Add("medium")
            BOXCODECPRESET.Items.Add("slow")
            BOXCODECPRESET.Items.Add("slower")
            BOXCODECPRESET.Items.Add("veryslow")
            BOXCODECPRESET.Items.Add("placebo")

            If PRESETLOADING = False Then
                BOXCODECPRESET.Text = "fast"
            End If
        End If

    End Function
    Public Function ChangeCodecOPT() As String()
        If BOXCODEC.Text = "libx265" Then
            If Not LVBOX.Items.Contains(LVBOX.Text) Then
                LVBOX.Text = ""
            End If
            If Not PFBOX.Items.Contains(PFBOX.Text) Then
                PFBOX.Text = ""
            End If

            PFBOX.Enabled = True
            LVBOX.Enabled = False
            REFBOX.Enabled = True
            LBDEINTMODE.Enabled = True
            RSBOX.Enabled = True
            BITBOX.Enabled = True
            BOXBITRATEMODE.Enabled = True
            BOXFPS.Enabled = True
            BOXKEYINTMAX.Enabled = True
            BOXCODECPRESET.Enabled = True
            CHKMULTITR.Enabled = True
            CHKFAST1ST.Enabled = True

        ElseIf BOXCODEC.Text = "hevc_nvenc" Then
            If Not LVBOX.Items.Contains(LVBOX.Text) Then
                LVBOX.Text = ""
            End If
            If Not PFBOX.Items.Contains(PFBOX.Text) Then
                PFBOX.Text = ""
            End If



            PFBOX.Enabled = False
            LVBOX.Enabled = False
            REFBOX.Enabled = True
            LBDEINTMODE.Enabled = True
            RSBOX.Enabled = True
            BITBOX.Enabled = True
            BOXBITRATEMODE.Enabled = True
            BOXFPS.Enabled = True
            BOXKEYINTMAX.Enabled = True
            BOXCODECPRESET.Enabled = True
            CHKMULTITR.Enabled = True
            CHKFAST1ST.Enabled = True

        ElseIf BOXCODEC.Text = "libx264" Then
            If Not LVBOX.Items.Contains(LVBOX.Text) Then
                LVBOX.Text = ""
            End If
            If Not PFBOX.Items.Contains(PFBOX.Text) Then
                PFBOX.Text = ""
            End If

            PFBOX.Enabled = True
            LVBOX.Enabled = True
            REFBOX.Enabled = True
            LBDEINTMODE.Enabled = True
            RSBOX.Enabled = True
            BITBOX.Enabled = True
            BOXBITRATEMODE.Enabled = True
            BOXFPS.Enabled = True
            BOXKEYINTMAX.Enabled = True
            BOXCODECPRESET.Enabled = True
            CHKMULTITR.Enabled = True
            CHKFAST1ST.Enabled = True

        ElseIf BOXCODEC.Text = "h264_nvenc" Then
            If Not LVBOX.Items.Contains(LVBOX.Text) Then
                LVBOX.Text = ""
            End If
            If Not PFBOX.Items.Contains(PFBOX.Text) Then
                PFBOX.Text = ""
            End If

            PFBOX.Enabled = True
            LVBOX.Enabled = True
            REFBOX.Enabled = True
            LBDEINTMODE.Enabled = True
            RSBOX.Enabled = True
            BITBOX.Enabled = True
            BOXBITRATEMODE.Enabled = True
            BOXFPS.Enabled = True
            BOXKEYINTMAX.Enabled = True
            BOXCODECPRESET.Enabled = True
            CHKMULTITR.Enabled = True
            CHKFAST1ST.Enabled = True

        ElseIf BOXCODEC.Text = "libsvtav1" Then
            If Not LVBOX.Items.Contains(LVBOX.Text) Then
                LVBOX.Text = ""
            End If
            If Not PFBOX.Items.Contains(PFBOX.Text) Then
                PFBOX.Items.Clear()
                PFBOX.Text = ""

            End If

            PFBOX.Enabled = True
            LVBOX.Enabled = True
            REFBOX.Enabled = False
            LBDEINTMODE.Enabled = True
            RSBOX.Enabled = True
            BITBOX.Enabled = True
            BOXBITRATEMODE.Enabled = True
            BOXFPS.Enabled = True
            BOXKEYINTMAX.Enabled = True
            BOXCODECPRESET.Enabled = True
            CHKMULTITR.Enabled = True
            CHKFAST1ST.Enabled = True

        ElseIf BOXCODEC.Text = "copy" Then
            LVBOX.Text = ""
            PFBOX.Text = ""
            PFBOX.Enabled = False
            LVBOX.Enabled = False
            REFBOX.Enabled = False
            LBDEINTMODE.Enabled = False
            RSBOX.Enabled = False
            BITBOX.Enabled = False
            BOXBITRATEMODE.Enabled = False
            BOXFPS.Enabled = False
            BOXKEYINTMAX.Enabled = False
            BOXCODECPRESET.Enabled = False
            CHKMULTITR.Enabled = True
            'CHKQA.Enabled = True
            CHKFAST1ST.Enabled = False

        ElseIf BOXCODEC.Text = "No Video" Then
            LVBOX.Text = ""
            PFBOX.Text = ""
            PFBOX.Enabled = False
            LVBOX.Enabled = False
            REFBOX.Enabled = False
            LBDEINTMODE.Enabled = False
            RSBOX.Enabled = False
            BITBOX.Enabled = False
            BOXBITRATEMODE.Enabled = False
            BOXFPS.Enabled = False
            BOXKEYINTMAX.Enabled = False
            BOXCODECPRESET.Enabled = False
            CHKMULTITR.Enabled = False
            'CHKQA.Enabled = False
            CHKFAST1ST.Enabled = False
        Else
            LVBOX.Text = ""
            PFBOX.Text = ""
            PFBOX.Enabled = False
            LVBOX.Enabled = False
            REFBOX.Enabled = False
            LBDEINTMODE.Enabled = True
            RSBOX.Enabled = True
            BITBOX.Enabled = True
            BOXBITRATEMODE.Enabled = True
            BOXFPS.Enabled = True
            BOXKEYINTMAX.Enabled = True
            BOXCODECPRESET.Enabled = True
            CHKMULTITR.Enabled = True
            'CHKQA.Enabled = True
            CHKFAST1ST.Enabled = True
        End If

        If BOXCODEC.Text = "libx265" Or BOXCODEC.Text = "libx264" Then

            BOXBITRATEMODE.Items.Clear()
            BOXBITRATEMODE.Items.Add("CRF")
            BOXBITRATEMODE.Items.Add("CRF-MaxBitrate")
            BOXBITRATEMODE.Items.Add("CBR")
            BOXBITRATEMODE.Items.Add("ABR")
            BOXBITRATEMODE.Items.Add("File Size")
            BOXBITRATEMODE.Items.Add("2pass-ABR")

            If Not BOXBITRATEMODE.Items.Contains(BOXBITRATEMODE.Text) Then
                BOXBITRATEMODE.Text = "CRF"
            End If

        ElseIf BOXCODEC.Text = "libsvtav1" Then
            BOXBITRATEMODE.Items.Clear()
            BOXBITRATEMODE.Items.Add("CVBR")
            BOXBITRATEMODE.Items.Add("VBR")
            BOXBITRATEMODE.Items.Add("CRF(CQP)")

        Else
            BOXBITRATEMODE.Items.Clear()

            BOXBITRATEMODE.Items.Add("CBR")
            BOXBITRATEMODE.Items.Add("ABR")

            If Not BOXBITRATEMODE.Items.Contains(BOXBITRATEMODE.Text) Then
                BOXBITRATEMODE.Text = "ABR"
            End If
        End If


        If BOXACODEC.Text = "copy" Then
            BOXAUDBITRATE.Enabled = False
            BOXSAMPLE.Enabled = False
            BOXCHANNEL.Enabled = False
            BOXAACPF.Enabled = False
            BOXAUDBITDEPTH.Enabled = False

        ElseIf BOXACODEC.Text = "libfdk_aac" Then
            BOXAUDBITRATE.Enabled = True
            BOXSAMPLE.Enabled = True
            BOXCHANNEL.Enabled = True
            BOXAACPF.Enabled = True
            BOXAUDBITDEPTH.Enabled = False
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
            BOXAUDBITDEPTH.Enabled = True
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
            BOXAUDBITDEPTH.Items.Clear()
            BOXAUDBITDEPTH.Items.Add("Auto")
            BOXAUDBITDEPTH.Items.Add("8")
            BOXAUDBITDEPTH.Items.Add("16")
            BOXAUDBITDEPTH.Items.Add("24")
            BOXAUDBITDEPTH.Items.Add("32")
            BOXAUDBITDEPTH.Items.Add("32(Float)")

        ElseIf BOXACODEC.Text = "dca" Then
            BOXAUDBITRATE.Enabled = False
            BOXSAMPLE.Enabled = True
            BOXCHANNEL.Enabled = False
            BOXAACPF.Enabled = False
            BOXAUDBITDEPTH.Enabled = False

        ElseIf BOXACODEC.Text = "flac" Then
            BOXAUDBITRATE.Enabled = False
            BOXSAMPLE.Enabled = True
            BOXCHANNEL.Enabled = True
            BOXAACPF.Enabled = False
            BOXAUDBITDEPTH.Enabled = True
            BOXAUDBITDEPTH.Items.Clear()
            BOXAUDBITDEPTH.Items.Add("Auto")
            BOXAUDBITDEPTH.Items.Add("16")
            BOXAUDBITDEPTH.Items.Add("24")
            BOXAUDBITDEPTH.Text = "Auto"

        ElseIf BOXACODEC.Text = "sox-flac" Then
            BOXAUDBITRATE.Enabled = False
            BOXSAMPLE.Enabled = True
            BOXCHANNEL.Enabled = True
            BOXAACPF.Enabled = False
            BOXAUDBITDEPTH.Enabled = True
            BOXAUDBITDEPTH.Items.Clear()
            BOXAUDBITDEPTH.Items.Add("Auto")
            BOXAUDBITDEPTH.Items.Add("8")
            BOXAUDBITDEPTH.Items.Add("12")
            BOXAUDBITDEPTH.Items.Add("16")
            BOXAUDBITDEPTH.Items.Add("20")
            BOXAUDBITDEPTH.Items.Add("24")
            BOXAUDBITDEPTH.Text = "Auto"

        ElseIf BOXACODEC.Text = "No Audio" Then
            BOXAUDBITRATE.Enabled = False
            BOXSAMPLE.Enabled = False
            BOXCHANNEL.Enabled = False
            BOXAACPF.Enabled = False
            BOXAUDBITDEPTH.Enabled = False
        Else
            BOXAUDBITRATE.Enabled = True
            BOXSAMPLE.Enabled = True
            BOXCHANNEL.Enabled = True
            BOXAACPF.Enabled = False
            BOXAUDBITDEPTH.Enabled = False
        End If
        ChangePresetList()
    End Function

    Private Sub BOXACODEC_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BOXACODEC.SelectedIndexChanged
        ChangeCodecOPT()

    End Sub
    Public Function SwitchContainer() As String()
        If BOXCONTAINER.Text = "=== HLS Encoding Mode ===" Then
            'Dim originalFile As String = OutputCBox.Text
            'Dim newName As String = Path.ChangeExtension(originalFile, "m3u8")
            'OutputCBox.Text = newName
            INPUTVIDNAME = InputCBOX.Text
            OutputCBox.Text = STARTUPPATH + "\HLS_Output\index.m3u8"
        ElseIf BOXCONTAINER.Text = "=== Smooth Encoding Mode ===" Or BOXCONTAINER.Text = "=== DASH Encoding Mode ===" Or BOXCONTAINER.Text = "=== RTMP Streaming Mode ===" Then

        ElseIf OutputCBox.Text = "" Or InputCBOX.Text.Contains("-f dshow") Or InputCBOX.Text.Contains("//") Then
            Dim originalFile As String = OutputCBox.Text
            Dim newName As String = Path.ChangeExtension(originalFile, BOXCONTAINER.Text)
            OutputCBox.Text = newName
        Else
            Dim originalFile As String = OutputCBox.Text
            Dim newName As String = Path.ChangeExtension(originalFile, BOXCONTAINER.Text)
            OutputCBox.Text = newName

        End If


    End Function

    Private Sub BTNAVSEDITOR_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNAVSEDITOR.Click
        If BOXFPSINFO.Text = "" Then
            getMediainfo()
            prepareOpen()
        ElseIf InputCBOX.Text.Contains("-f dshow") Then


        End If

        If My.Computer.FileSystem.FileExists(InputCBOX.Text + ".avs") Then
            AvisynthOpt.ToolStripStatusLabel1.Text = "AVS File loaded"
            Dim fileReader As String
            fileReader = My.Computer.FileSystem.ReadAllText(InputCBOX.Text + ".avs", System.Text.Encoding.Default)
            AvisynthOpt.BOXAVSSCRIPT.Text = fileReader
        Else
            AvisynthOpt.ToolStripStatusLabel1.Text = "Do not have AVS File"
        End If
        If BOXCODECINFO.Text = "MPEG-2V" Then
            AvisynthOpt.RDBDGINDEX.Checked = True
        Else
            AvisynthOpt.RDBFFMS2.Checked = True
        End If


        AvisynthOpt.Show()
        Dim FILE_NAME As String = InputCBOX.Text
        If Regex.IsMatch(FILE_NAME, "\p{IsThai}") Or Regex.IsMatch(FILE_NAME, "\p{IsArabic}") Or Regex.IsMatch(FILE_NAME, "\p{IsLatin-1Supplement}") Or Regex.IsMatch(FILE_NAME, "\p{IsGreek}") Or
            Regex.IsMatch(FILE_NAME, "\p{IsLatinExtended-A}") Or Regex.IsMatch(FILE_NAME, "\p{IsLatinExtended-B}") Then
            MsgBox("Avisynth do not support some unicode language file name. please change input file name to english", vbCritical)
        End If
    End Sub

    Private Sub Button9_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FRMCUSTOMENC.Show()
    End Sub

    Private Sub BTNAVSPREVIEW_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNAVSPREVIEW.Click
        Shell("cmd /c title Infinity Media Encoder & " + FFPLAYEXE + " -x 800 -y 450 -i " + """" + InputCBOX.Text + ".avs" + """")


    End Sub


    Private Sub CHKTRIM_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHKTRIM.CheckedChanged
        If InputCBOX.Text.Contains("http://") Then
            CHKTRIM.Checked = False
            MsgBox("Http Contents Trim not supported ", MsgBoxStyle.Information)

        ElseIf BOXCODEC.Text = "copy" And Not BOXACODEC.Text = "copy" Then
            If CHKTRIM.Checked = True Then
                MsgBox("Do not recommend use Video codec copy and Re-encoding Audio with trim option. It might be cause video duration error", MsgBoxStyle.Exclamation)
            End If


        End If
    End Sub
    Public Function RandomString()
        Dim s As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"
        Dim r As New Random
        Dim sb As New StringBuilder
        For i As Integer = 1 To 5
            Dim idx As Integer = r.Next(0, 35)
            sb.Append(s.Substring(idx, 1))
        Next
        Return sb.ToString()
    End Function

    Private Sub ENCLISTVIEWMAIN_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles ENCLISTVIEWMAIN.DragDrop
        LBENCLISTHELP.Text = ""
        WaitScreen.Show()
        Dim files() As String = e.Data.GetData(DataFormats.FileDrop)
        For Each path In files


            BOXASPECT.Text = ""
            BOXDURATION.Text = ""
            BOXCODECINFO.Text = ""
            BOXDELAYINFO.Text = ""
            BOXFPSINFO.Text = ""
            MI.Open(path)

            'BOXCODECINFO.Text = Invoke(New Action(Function() MI.Get_(StreamKind.Video, 0, "Codec")))
            BOXCODECINFO.Text = MI.Get_(StreamKind.Video, 0, "Codec")

            'BOXDELAYINFO.Text = Invoke(New Action(Function() MI.Get_(StreamKind.Audio, 0, "Video_Delay")))
            BOXDELAYINFO.Text = MI.Get_(StreamKind.Audio, 0, "Video_Delay")

            If BOXDELAYINFO.Text = "" Then
                BOXDELAYINFO.Text = "0"
            End If

            If Not BOXDELAYINFO.Text = "" Then
                Dim VDELAYINFO1 As String = (BOXDELAYINFO.Text * (1 / 1000)).ToString
                VDELAYINFO = VDELAYINFO1

                BOXDELAYINFO.Text = VDELAYINFO
            End If
            BOXDURATION2.Text = MI.Get_(StreamKind.Video, 0, "Duration")
            BOXFORMATINFO.Text = MI.Get_(StreamKind.General, 0, "Format")
            BOXACODECINFO.Text = MI.Get_(StreamKind.Audio, 0, "Codec")

            'BOXASPECT.Text = MI.Get_(StreamKind.Video, 0, "DisplayAspectRatio/String")
            'BOXDURATION.Text = MI.Get_(StreamKind.Video, 0, "Duration/String3")
            'BOXPFINFO.Text = MI.Get_(StreamKind.Video, 0, "Format_Profile")
            'BOXRSINFO.Text = MI.Get_(StreamKind.Video, 0, "Width") + "x" + MI.Get_(StreamKind.Video, 0, "Height")
            'BOXREFINFO.Text = MI.Get_(StreamKind.Video, 0, "Format_Settings_RefFrames")

            MI.Close()



            Dim p As New Process
            Dim outputReader2 As StreamReader
            With p.StartInfo
                .WindowStyle = ProcessWindowStyle.Minimized
                .Arguments = "" + " -i " + """" + path + """"
                .FileName = """" + STARTUPPATH + "\Tools\ffmpeg32\ffmpeg.exe" + """"

                .UseShellExecute = False
                .RedirectStandardOutput = True
                .RedirectStandardError = True
                .CreateNoWindow = True


            End With

            Invoke(New Action(Function() p.Start()))
            outputReader2 = p.StandardError
            Dim output2 As String



            While outputReader2.EndOfStream = False
                output2 = outputReader2.ReadLine()


                If output2.Contains("Stream #") And output2.Contains("Video:") Then
                    Try
                        Dim split4 As String() = output2.Split(New [Char]() {"#"})
                        Dim String14 As String = split4(1)

                        If String14.Contains("fps") Then


                            Dim startchar As Integer = String14.IndexOf("fps")
                            Dim split6 As String = String14.Substring(startchar - 8)
                            'Dim String15 As String = split5(22)
                            Dim split15 As String() = split6.Split(New [Char]() {" ", ","})
                            Dim String16 As String = split15(5)
                            'MsgBox(String15)
                            If BOXFPSINFO.Text = "" Then
                                BOXFPSINFO.Text = String16
                                If Not BOXFPSINFO.Text.Contains(".") Then
                                    BOXFPSINFO.Text = BOXFPSINFO.Text + ".00"

                                End If

                            End If
                        Else
                            If BOXFPSINFO.Text = "" Then
                                Dim split41 As String() = output2.Split(New [Char]() {"#"})
                                Dim String141 As String = split41(1)
                                Dim startchar1 As Integer = String141.IndexOf("tbr")
                                Dim split61 As String = String141.Substring(startchar1 - 4)
                                'Dim String15 As String = split5(22)
                                Dim split151 As String() = split61.Split(New [Char]() {" ", ","})
                                Dim String161 As String = split151(1)
                                BOXFPSINFO.Text = String161
                                If Not BOXFPSINFO.Text.Contains(".") Then
                                    BOXFPSINFO.Text = BOXFPSINFO.Text + ".00"

                                End If
                            End If
                        End If


                    Catch

                    End Try
                End If




                If output2.Contains("Duration:") Then
                    Try
                        Dim splitDUR As String() = output2.Split(New [Char]() {" ", ","})
                        Dim String14 As String = splitDUR(3)

                        If BOXDURATION.Text = "" Then
                            BOXDURATION.Text = String14
                            BOXDURATION2.Text = TimeSpan.Parse(String14).TotalSeconds
                            p.Kill()

                        End If

                    Catch

                    End Try
                End If



            End While


            prepareOpen()
            INPUTVIDNAME = path
            'inputMediainfo()
            prepareEncoding()

            INPUTVIDNAME = path
            If INPUTVIDNAME.Contains("-f dshow") Then
            ElseIf OutputCBox.Text.Contains("//") Then

            Else

                Dim testFile As System.IO.FileInfo
                testFile = My.Computer.FileSystem.GetFileInfo(INPUTVIDNAME)
                Dim folderPath As String = testFile.DirectoryName
                Dim infileName As String = testFile.Name
                IO.Path.GetFileNameWithoutExtension(infileName)
                OUTPUTFILENAMEONLY = "[InfinityEncoder]" + IO.Path.GetFileNameWithoutExtension(infileName) + "-" + RandomString() + "." + BOXCONTAINER.Text
                OUTPUTFILENAME = folderPath + "\" + OUTPUTFILENAMEONLY

            End If

            prepareEncoding2()
            Dim ACMD As String = SHELLCMD

            Dim ENCLISTCOUNT As Integer = ENCLISTVIEWMAIN.Items.Count
            'LISTCHKENC2.Items.Add(ACMD)
            If OutputCBox.Text.Contains("//") Then
                OUTPUTFILENAME = "OutputCBox.Text"
                OUTPUTFILENAMEONLY = "Live Streaming"
            End If

            If CHKDEBUG.Checked Then
                BOXDEBUG.Text = ACMD
            End If

            Dim add As New ListViewItem(OUTPUTFILENAMEONLY)

            add.SubItems.Add("")
            add.SubItems.Add(ACMD)
            If CHKTRIM.Checked = True Then

                add.SubItems.Add(BOXTRIMSS.Text)
                add.SubItems.Add(BOXTRIMTO.Text)
                add.SubItems.Add(BOXDURATION.Text)
                add.SubItems.Add(OUTPUTFILENAME)
            Else
                add.SubItems.Add("0")
                add.SubItems.Add("0")
                add.SubItems.Add(BOXDURATION.Text)
                add.SubItems.Add(OUTPUTFILENAME)
            End If

            ENCLISTVIEWMAIN.Items.Add(add)


            'MsgBox("Added to Encoding Job List - List Item count is " + LISTCHKENC2.Items.Count.ToString, MsgBoxStyle.Information)

            initialValue()
            BOXFPSINFO.Text = ""
            BOXDURATION.Text = ""
        Next

        WaitScreen.Close()
    End Sub

    Private Sub ENCLISTVIEWMAIN_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles ENCLISTVIEWMAIN.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If

    End Sub


    Private Sub BTADDENCLIST_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTADDENCLIST.Click
        LBENCLISTHELP.Text = ""
        INPUTVIDNAME = InputCBOX.Text
        OUTPUTFILENAME = OutputCBox.Text

        If Not InputCBOX.Text = "" And Not OutputCBox.Text = "" Then
            prepareEncoding()
            prepareEncoding2()
            Dim ACMD As String = SHELLCMD


            Dim filenameinfo As String
            Dim outfileName As String
            If OutputCBox.Text.Contains("//") Then
                filenameinfo = "Live Streaming"
            Else
                filenameinfo = System.IO.Path.GetFileName(OutputCBox.Text)
                Dim testFile As System.IO.FileInfo
                testFile = My.Computer.FileSystem.GetFileInfo(OutputCBox.Text)
                outfileName = testFile.Name
                Dim folderPath As String = testFile.DirectoryName
                IO.Path.GetFileNameWithoutExtension(outfileName)
                OUTPUTFILENAMEONLY = IO.Path.GetFileNameWithoutExtension(outfileName) + "." + BOXCONTAINER.Text
                OUTPUTFILENAME = folderPath + "\" + OUTPUTFILENAMEONLY

            End If



            Dim ENCLISTCOUNT As Integer = ENCLISTVIEWMAIN.Items.Count
            If OutputCBox.Text.Contains("//") Then
                OUTPUTFILENAME = "OutputCBox.Text"
                OUTPUTFILENAMEONLY = "Live Streaming"
            End If

            Dim add As New ListViewItem(OUTPUTFILENAMEONLY)

            add.SubItems.Add("")
            add.SubItems.Add(ACMD)
            If CHKTRIM.Checked = True Then

                add.SubItems.Add(BOXTRIMSS.Text)
                add.SubItems.Add(BOXTRIMTO.Text)
                add.SubItems.Add(BOXDURATION.Text)
                add.SubItems.Add(OUTPUTFILENAME)
            Else
                add.SubItems.Add("0")
                add.SubItems.Add("0")
                add.SubItems.Add(BOXDURATION.Text)
                add.SubItems.Add(OUTPUTFILENAME)
            End If

            ENCLISTVIEWMAIN.Items.Add(add)
            'MsgBox(ENCLISTVIEWMAIN.Items(0).SubItems(2).Text)

            'ENCLISTVIEWMAIN.Items(ENCLISTCOUNT).SubItems.Add(ACMD)
            'ENCLISTCOUNT = ENCLISTCOUNT + 1
            'Dim lvi As New ListViewItem(filenameinfo)
            'lvi.SubItems.Add(ACMD)
            'ENCLISTVIEWMAIN.Items.Add(lvi)
            CreateObject("WScript.Shell").Popup("Added to Encoding Job List - List Item count is " + ENCLISTVIEWMAIN.Items.Count.ToString, 1, "Infinity Media Encoder")
            'End If



            'MsgBox("Added to Encoding Job List - List Item count is " + LISTCHKENC2.Items.Count.ToString, MsgBoxStyle.Information)
            initialValue()
        Else
            MsgBox("Please specific Input Path / Output Path", MsgBoxStyle.Critical, "Infinity Media Encoder")
            GoTo INITIAL
        End If
        If ENCLISTVIEWMAIN.SelectedItems.Count = 0 Then
            'ENCLISTVIEWMAIN.SetSelected(0, True)
        End If
INITIAL:
        initialValue()
        BOXFPSINFO.Text = ""
        BOXDURATION.Text = ""
    End Sub

    Private Sub InputCBOX_Leave(sender As Object, e As EventArgs) Handles InputCBOX.Leave
        If InputCBOX.Text.Contains("//") Then
        Else
            'InputCBOX.Text = INPUTFILENAME

        End If
    End Sub



    Private Sub InputCBOX_TextUpdate(ByVal sender As Object, ByVal e As System.EventArgs) Handles InputCBOX.TextChanged
        INPUTVIDNAME = InputCBOX.Text
        If InputCBOX.Text.Contains("http://ustream.tv") Or InputCBOX.Text.Contains("http://www.ustream.tv") Or InputCBOX.Text.Contains("https://ustream.tv/") Or
        InputCBOX.Text.Contains("https://www.ustream.tv/") Or InputCBOX.Text.Contains("http://www.connectcast.tv/") Or InputCBOX.Text.Contains("http://connectcast.tv/") Or
        InputCBOX.Text.Contains("https://twitch.tv/") Or InputCBOX.Text.Contains("https://www.twitch.tv/") Then
            BOXTRIMSS.Enabled = False
            BOXTRIMTO.Enabled = False
            CHKTRIM.Enabled = False
            CHKMULTITR.Enabled = False
            'CHKQA.Enabled = False
            BOXCODEC.Enabled = True
            BOXACODEC.Enabled = True
            AddFormat()

        Else
            BOXTRIMSS.Enabled = True
            BOXTRIMTO.Enabled = True
            CHKTRIM.Enabled = True
            CHKMULTITR.Enabled = True
            'CHKQA.Enabled = True
            BOXCODEC.Enabled = True
            BOXACODEC.Enabled = True
            AddFormat()


        End If
    End Sub
    Public Structure ListViewItemsVID

        Public column1 As String

        Public column2 As String

    End Structure
    Public Structure ListViewItemsAUD

        Public column1 As String

        Public column2 As String

    End Structure

    Private items As New List(Of ListViewItemsVID)
    Private itemsA As New List(Of ListViewItemsAUD)


    Public Sub FindControls(ByVal cont As Control, ByVal Data As List(Of ControlData))
        For Each ctl As Control In cont.Controls
            If CHKALLSET.Checked = False Then





                If TypeOf ctl Is ComboBox Then
                    Dim CB As ComboBox = DirectCast(ctl, ComboBox)
                    If Not CB.Text = "" And Not CB.Name = "BOXYTFILENAME" And Not CB.Name = "YTPARSINGINFO" And
                        Not CB.Name = "BOXVFILTERNAME" And Not CB.Name = "BOXAFILTERNAME" And Not CB.Name = "InputCBOX" And Not CB.Name = "BOXAUDIOPATH" And Not CB.Name = "OutputCBox" And
                        Not CB.Name = "BOXSUBPATH" And Not CB.Name = "BOXTRIMSS" And Not CB.Name = "BOXTRIMTO" And Not CB.Name = "BOXVFILTERPARAM" And Not CB.Name = "BOXFFMPEGEXE" Then

                        Dim cd As New ControlData
                        cd.ControlName = ctl.Name
                        cd.ControlProperty = "Text"
                        cd.ControlData = CB.Text.ToString
                        Data.Add(cd)

                    End If
                ElseIf ctl.HasChildren Then
                    FindControls(ctl, Data)

                End If


                If TypeOf ctl Is TextBox Then
                    Dim CB As TextBox = DirectCast(ctl, TextBox)
                    If CB.Name = "BOXVFILTER" Or CB.Name = "BOXAFILTER" Or CB.Name = "BOXVFILTERCST" Or CB.Name = "BOXAFILTERCST" Or CB.Name = "BOXCHLSADDRESS" Or CB.Name = "BOXFLVFLAG" Then
                        Dim cd As New ControlData
                        cd.ControlName = ctl.Name
                        cd.ControlProperty = "Text"
                        cd.ControlData = CB.Text.ToString
                        Data.Add(cd)
                    End If
                End If

                If TypeOf ctl Is ListView Then
                    Dim LV As ListView = DirectCast(ctl, ListView)
                    Dim cd As New ControlData
                    cd.ControlName = ctl.Name
                    cd.ControlProperty = "Text"
                    cd.ControlData = LV.Text.ToString
                    Data.Add(cd)
                End If

                If TypeOf ctl Is CheckBox Then
                    Dim CB As CheckBox = DirectCast(ctl, CheckBox)
                    If Not CB.Name = "CHKTRIM" Then


                        Dim cd As New ControlData
                        cd.ControlName = ctl.Name
                        cd.ControlProperty = "Checked"
                        cd.ControlData = CB.Checked.ToString
                        Data.Add(cd)


                    End If

                End If


            Else


                If TypeOf ctl Is ComboBox Then
                    Dim CB As ComboBox = DirectCast(ctl, ComboBox)
                    If Not CB.Name = "YTPARSINGINFO" And Not CB.Name = "BOXFFMPEGEXE" Then
                        Dim cd As New ControlData
                        cd.ControlName = ctl.Name
                        cd.ControlProperty = "Text"
                        cd.ControlData = CB.Text.ToString
                        Data.Add(cd)
                    End If
                ElseIf ctl.HasChildren Then
                    FindControls(ctl, Data)
                End If

                If TypeOf ctl Is CheckBox Then
                    Dim CB As CheckBox = DirectCast(ctl, CheckBox)
                    If Not CB.Name = "CHKINTELLIDEINT" And Not CB.Name = "CHKRMMETADATA" And Not CB.Name = "CHKATRACKAVISYNTH" And Not CB.Name = "CHKCMDWINDOW" And
                         Not CB.Name = "CHKMULTIENC" And Not CB.Name = "CHKPTSDTS" And Not CB.Name = "CHKVSYNC0" And Not CB.Name = "CHKASYNC" Then
                        Dim cd As New ControlData
                        cd.ControlName = ctl.Name
                        cd.ControlProperty = "Checked"
                        cd.ControlData = CB.Checked.ToString
                        Data.Add(cd)
                    End If



                End If


                If TypeOf ctl Is TextBox Then
                    Dim CB As TextBox = DirectCast(ctl, TextBox)
                    If CB.Name = "BOXVFILTER" Or CB.Name = "BOXAFILTER" Or CB.Name = "BOXVFILTERCST" Or CB.Name = "BOXAFILTERCST" Or CB.Name = "BOXCHLSADDRESS" Or CB.Name = "BOXFLVFLAG" Then
                        Dim cd As New ControlData
                        cd.ControlName = ctl.Name
                        cd.ControlProperty = "Text"
                        cd.ControlData = CB.Text.ToString
                        Data.Add(cd)
                    End If
                End If

            End If




        Next



    End Sub
    <Serializable()>
    Public Class ListViewItemCollection
        Inherits System.Collections.ObjectModel.Collection(Of String())
    End Class

    Private Sub DeserializeToListView(ByVal LV As ListView, ByVal filename As String)

        '  Create a FileStream to access the storage file

        Dim FS As FileStream = File.Open(".\Preset\Filter\" + PRESETFILENAME + ".xml", FileMode.Open)

        '  Create a Binary Formatter for Serialization process

        Dim BinFmtr As New BinaryFormatter

        '  Create an arraylist as temp storage for listview items data

        Dim alSavedLV As New ArrayList



        '  Deserialize the data from the file and put it in the arraylist

        alSavedLV = CType(BinFmtr.Deserialize(FS), ArrayList)



        '  Read the arraylist contents into the listview

        Dim lvi As ListViewItem

        For item As Integer = 0 To alSavedLV.Count - 1

            lvi = New ListViewItem

            lvi = CType(alSavedLV(item), ListViewItem)

            LV.Items.Add(lvi)

        Next



        '  Done with the FileStream

        FS.Close()

    End Sub
    Private Sub SerializeListViewData(LV As ListView, ByVal filename As String)

        '  Create a FileStream and get the file to write to. 

        Dim FS As FileStream = File.Create(".\Preset\Filter\" + PRESETFILENAME + ".xml")

        '  Create a Binary Formatter for Serialization process

        Dim BinFmtr As New BinaryFormatter

        '  Create an arraylist as temp storage for listview items data

        Dim alSavedLV As New ArrayList



        '  Iterate through the ListView's listitem collection and add

        '  each to the temporary ArrayList

        For item As Integer = 0 To LV.Items.Count - 1

            '  Add next item/subitem to the arraylist

            alSavedLV.Add(LV.Items(item))

        Next



        '  Serialize the complete arraylist to the file

        '  The arraylist contains all the listview data

        BinFmtr.Serialize(FS, alSavedLV)



        '  Close the FileStream

        FS.Close()



    End Sub
    Public Sub MergeXml(ByVal XmlPath1 As String, ByVal XmlPath2 As String)
        'Documents we need to merge
        Dim xmlreader1 As New XmlTextReader(XmlPath1)
        Dim xmlreader2 As New XmlTextReader(XmlPath2)
        'Create a new dataset to hold Xml1
        Dim ds1 As New DataSet()
        Try
            'Load Xml into dataset
            ds1.ReadXml(xmlreader1)
            'Same for Xml2
            Dim ds2 As New DataSet()
            ds2.ReadXml(xmlreader2)
            'Merge the two Xmls
            ds1.Merge(ds2)
            ds1.WriteXml("C:\XmlTest.xml", XmlWriteMode.IgnoreSchema)
        Catch ex As Exception
            MessageBox.Show("Error merging Xml Documents")
        End Try
    End Sub
    Public Function FindXmlNode(parentE As XmlNode, elementName As String) As XmlNode
        For Each node As XmlNode In parentE.ChildNodes
            If node.Name = elementName Then
                Return node
            Else
                If node.HasChildNodes Then
                    FindXmlNode(node, elementName)
                End If
            End If
        Next
        Return Nothing
    End Function

    Private Sub BTPRSAVE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTPRSAVE.Click
        If BOXPRESETFILENAME.Text = "" Then
            MsgBox("Please input preset name", MsgBoxStyle.Information, "Infinity Media Encoder")
        Else
            Dim fileDateTime As String = DateTime.Now.ToString("yyyyMMdd") & "_" & DateTime.Now.ToString("HHmmss")
            PRESETFILENAME = BOXPRESETFILENAME.Text
            If BOXPRESETFILENAME.Text = "" Then
                PRESETFILENAME = fileDateTime
            End If

            Dim nsBlank As New XmlSerializerNamespaces
            nsBlank.Add("", "")

            '==Save textbox, combobox, checkbox value to xml 
            Dim Data As New List(Of ControlData)


            FindControls(Me, Data)
            AdvancedFRM.FindControls(AdvancedFRM, Data)
            FRMMULTIRTMP.FindControls(FRMMULTIRTMP, Data)

            If CHKALLSET.Checked = True Then
                FRMCUSTOMENC.FindControls(FRMCUSTOMENC, Data)

            End If
            '==

            '===Save ListView items to xml 
            items = New List(Of ListViewItemsVID)

            For Each lvi As ListViewItem In LISTVFILTER.Items

                Dim lv As New ListViewItemsVID

                lv.column1 = lvi.SubItems(0).Text

                lv.column2 = lvi.SubItems(1).Text

                items.Add(lv)

            Next

            '===Save ListView items to xml 
            itemsA = New List(Of ListViewItemsAUD)

            For Each lvi As ListViewItem In LISTAFILTER.Items

                Dim lv As New ListViewItemsAUD

                lv.column1 = lvi.SubItems(0).Text

                lv.column2 = lvi.SubItems(1).Text

                itemsA.Add(lv)

            Next



            Dim serializer As New Xml.Serialization.XmlSerializer(GetType(List(Of ListViewItemsVID)), New XmlRootAttribute("ListViewItemsV"))
            Dim serializerA As New Xml.Serialization.XmlSerializer(GetType(List(Of ListViewItemsAUD)), New XmlRootAttribute("ListViewItemsA"))

            Dim xml As New XmlSerializer(Data.GetType)

            Using writer As New FileStream(".\Preset\" + PRESETFILENAME + ".xml", FileMode.Create)
                xml.Serialize(writer, Data, nsBlank)
                'serializer.Serialize(writer, items, nsBlank)
            End Using

            Using writer As New FileStream(".\Preset\" + PRESETFILENAME + "-LV.vset", FileMode.Create)

                serializer.Serialize(writer, items, nsBlank)

            End Using


            Using writer As New FileStream(".\Preset\" + PRESETFILENAME + "-LA.aset", FileMode.Create)

                serializerA.Serialize(writer, itemsA, nsBlank)

            End Using


            Dim xml1 = XDocument.Load(".\Preset\" + PRESETFILENAME + ".xml")
            Dim xml2 = XDocument.Load(".\Preset\" + PRESETFILENAME + "-LV.vset")


            xml1.Descendants("ArrayOfControlData").FirstOrDefault().Add(xml2.Descendants("ListViewItemsV").FirstOrDefault())

            xml1.Save(".\Preset\" + PRESETFILENAME + ".xml")
            DeleteFile(".\Preset\" + PRESETFILENAME + "-LV.vset", 10)



            Dim xml3 = XDocument.Load(".\Preset\" + PRESETFILENAME + ".xml")
            Dim xml4 = XDocument.Load(".\Preset\" + PRESETFILENAME + "-LA.aset")

            xml3.Descendants("ArrayOfControlData").FirstOrDefault().Add(xml4.Descendants("ListViewItemsA").FirstOrDefault())


            xml3.Save(".\Preset\" + PRESETFILENAME + ".xml")
            DeleteFile(".\Preset\" + PRESETFILENAME + "-LA.aset", 10)
            '===

            BOXPRESETFILENAME.Text = PRESETFILENAME
            MsgBox("Preset Saved", MsgBoxStyle.Information, "Infinity Media Encoder")

            Dim PRESETFOLDER As String = ".\Preset\"

            BOXPRESETFILENAME.Items.Clear()
            For Each PRESETFILE As String In My.Computer.FileSystem.GetFiles _
                                                        (PRESETFOLDER, FileIO.SearchOption.SearchTopLevelOnly, "*.xml")

                BOXPRESETFILENAME.Items.Add(IO.Path.GetFileNameWithoutExtension(PRESETFILE))
            Next
        End If

    End Sub
    Private Function DeleteFile(path As String, Optional maxAttempts As Integer = 0) As Boolean

        Dim fileDeleted = False

        Dim attempts = 0



        Do

            Try

                File.Delete(path)

                fileDeleted = True

            Catch ex As IOException

                attempts += 1



                If attempts = maxAttempts Then

                    Exit Do
                End If



                'The file is open so pause before trying again.

                Thread.Sleep(1000)

            End Try

        Loop Until fileDeleted



        Return fileDeleted

    End Function

    Private Sub BTPRLOAD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTPRLOAD.Click
        PRESETLOADING = True
        If BOXPRESETFILENAME.Text = "" Then
            MsgBox("Please select preset", MsgBoxStyle.Information, "Infinity Media Encoder")
        Else

            PRESETFILENAME = BOXPRESETFILENAME.Text
            LISTVFILTER.Items.Clear()
            LISTAFILTER.Items.Clear()
            BOXVFILTER.Text = ""
            BOXVFILTERCST.Text = ""
            BOXAFILTER.Text = ""
            BOXAFILTERCST.Text = ""

            Parsingsettings()

            If CHKALLSET.Checked = True Then
                FRMCUSTOMENC.ParsingsettingsCustomEncOpt()
            End If
            AdvancedFRM.LoadPresetADV()
            FRMMULTIRTMP.LoadPresetMRTMP()

            ParsingFiltersettings()
            Try

            Catch
                'DeserializeToListView(LISTVFILTER, PRESETFILENAME)
                'DeserializeToListView(LISTAFILTER, PRESETFILENAME)
            End Try
            ChangeCodecOPT()
            getMediainfo()
            MsgBox("Preset Loaded", MsgBoxStyle.Information, "Infinity Media Encoder")

        End If
        PRESETLOADING = False
    End Sub

    Public Function Parsingsettings() As String()

        Try
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
                MsgBox("Does not exist Preset file " + PRESETFILENAME + ".xml", MsgBoxStyle.Critical, "Infinity Media Encoder")
            End If
        Catch

        End Try




    End Function
    Public Function ParsingFiltersettings() As String()

        Dim MyDataSet As DataSet = New DataSet
        MyDataSet.ReadXml(".\Preset\" + PRESETFILENAME + ".xml", XmlReadMode.Auto)

        Try

            For Each dr As DataRow In MyDataSet.Tables("ListViewItemsVID").Rows

                Dim lvi As New ListViewItem
                lvi.Text = dr.Item(0).ToString()
                lvi.SubItems.Add(dr.Item(1).ToString())
                LISTVFILTER.Items.Add(lvi)
                LISTVFILTER.Update()
            Next
        Catch

        End Try
        Try
            For Each dr As DataRow In MyDataSet.Tables("ListViewItemsAUD").Rows
                Dim lvi As New ListViewItem
                lvi.Text = dr.Item(0).ToString()
                lvi.SubItems.Add(dr.Item(1).ToString())
                LISTAFILTER.Items.Add(lvi)
                LISTAFILTER.Update()
            Next
        Catch

        End Try



    End Function


    Private Sub Main_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try


            FRMProgress.KillProcessAndChildren(FRMProgress.p.Id)
            FRMProgress.KillProcessAndChildren(FRMProgress.p.Id)
            FRMProgress.BackgroundWorker_1.CancelAsync()
        Catch ex As Exception

        End Try

        'BackgroundWorker_1.CancelAsync()

        'outputReader.Close()
    End Sub
    Private Sub BOXAUDIOPATH_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles BOXAUDIOPATH.KeyPress
        e.Handled = True
    End Sub
    Private Sub InputCBOX_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles InputCBOX.KeyPress

    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        osver = System.Environment.OSVersion
        STARTUPPATH = Application.StartupPath()
        If Environment.Is64BitOperatingSystem = True Then
            BOXFFMPEGEXE.Text = STARTUPPATH + "\Tools\ffmpeg64\ffmpeg.exe"
        ElseIf Environment.Is64BitOperatingSystem = False Then
            BOXFFMPEGEXE.Text = STARTUPPATH + "\Tools\ffmpeg32\ffmpeg.exe"
        End If

        FFPLAYEXE = """" + STARTUPPATH + "\Tools\ffmpeg64\ffplay.exe" + """"
        YOUTUBEDLPATH = """" + STARTUPPATH + "\Tools\yt-dlp\yt-dlp.exe" + """"
        LIVESTREAMEREXE = """" + STARTUPPATH + "\Tools\livestreamer\livestreamer.exe" + """"

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

            ElseIf InputCBOX.Text.Contains("-f dshow") Or OutputCBox.Text.Contains("//") And BOXCONTAINER.Text = "" Or BOXCONTAINER.Text = "=== RTMP Streaming Mode ===" Or BOXCONTAINER.Text = "=== HLS Encoding Mode ===" Or BOXCONTAINER.Text = "=== Smooth Encoding Mode ===" Or BOXCONTAINER.Text = "=== DASH Encoding Mode ===" Then

            ElseIf InputCBOX.Text.Contains("//") Then
                If OutputCBox.Text = "" Then
                    OutputCBox.Text = "[InfinityEncoder]Video.mp4"
                    OUTPUTFILENAME = OutputCBox.Text
                Else

                End If


            ElseIf BOXCONTAINER.Text = "=== HLS Encoding Mode ===" Then
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

    Public Function getFFmpegPath()
        If CHKAVISYNTH.Checked = True Then
            FFMPEGEXE = """" + STARTUPPATH + "\Tools\ffmpeg32\ffmpeg.exe" + """"
            'ElseIf INPUTVIDNAME.Contains("-f dshow") Then
            'FFMPEGEXE = """" + STARTUPPATH + "\Tools\ffmpeg32\ffmpeg.exe " + """"
        ElseIf BOXFFMPEGEXE.Text = "64bit FFmpeg" Then
            FFMPEGEXE = """" + STARTUPPATH + "\Tools\ffmpeg64\ffmpeg.exe" + """"
        ElseIf BOXFFMPEGEXE.Text = "32bit FFmpeg" Then
            FFMPEGEXE = """" + STARTUPPATH + "\Tools\ffmpeg32\ffmpeg.exe " + """"
        Else
            FFMPEGEXE = """" + BOXFFMPEGEXE.Text + """"
        End If
    End Function
    Public Function prepareEncoding() As String()
        FRMProgress.FFPARAM = ""
        'If BOXCODECINFO.Text = "" Then
        'getMediainfo()
        ' Else



        If CHKAVISYNTH.Checked = True Then
            FFMPEGEXE = """" + STARTUPPATH + "\Tools\ffmpeg32\ffmpeg.exe" + """"
            'ElseIf INPUTVIDNAME.Contains("-f dshow") Then
            'FFMPEGEXE = """" + STARTUPPATH + "\Tools\ffmpeg32\ffmpeg.exe " + """"
        ElseIf BOXFFMPEGEXE.Text = "64bit FFmpeg" Then
            FFMPEGEXE = """" + STARTUPPATH + "\Tools\ffmpeg64\ffmpeg.exe" + """"
        ElseIf BOXFFMPEGEXE.Text = "32bit FFmpeg" Then
            FFMPEGEXE = """" + STARTUPPATH + "\Tools\ffmpeg32\ffmpeg.exe " + """"
        Else
            FFMPEGEXE = """" + BOXFFMPEGEXE.Text + """"
        End If

        Dim targetfps As String
        If BOXFPS.Text = "23.976" Then
            targetfps = "24000/1001"
        ElseIf BOXFPS.Text = "29.97" Then
            targetfps = "30000/1001"
        ElseIf BOXFPS.Text = "59.94" Then
            targetfps = "60000/1001"
        Else
            targetfps = BOXFPS.Text
        End If


        If Not BOXFPS.Text = "" And Not BOXCODEC.Text = "copy" And Not BOXFPS.Text = "Original" Then
            FPSVAL = " -framerate " + targetfps + " "
        End If

        If BOXCODEC.Text = "libx264" Then
            PFVAL = " -profile:v " + PFBOX.Text
        ElseIf BOXCODEC.Text = "libx265" Then
            PFVAL = ""
        ElseIf BOXCODEC.Text = "libsvtav1" Then
            'PFVAL = " -profile " + PFBOX.Text
        End If
        If PFBOX.Text = "" Then
            PFVAL = ""
        End If


        If BOXCODEC.Text = "libx264" And Not LVBOX.Text = "" Then
            LVVAL = " -level:v " + LVBOX.Text
        End If




        If BOXCODEC.Text = "libx264" Then
            If REFBOX.Text = "Original" Then
                If BOXCODECINFO.Text = "AVC" Then
                    REFVAL = ":ref=" + BOXREFINFO.Text
                End If

            Else
                REFVAL = ":ref=" + REFBOX.Text
            End If
        End If



        If BOXCODEC.Text = "copy" Or RSBOX.Text = "Original" Then
            RSVAL = ""
        Else
            RSVAL = ",scale=" + RSBOX.Text + ":flags=lanczos"

        End If

        If BOXCODEC.Text = "copy" Or LBDEINTMODE.Text = "Disabled" Then
            DEINTVAL = ""
        Else
            DEINTVAL = "," + LBDEINTMODE.Text + "=" + BOXDEINT.Text + ":-1:0"
        End If








        If BOXKEYINTMAX.Text = "Auto" Then

        Else
            KEYINTVAL = " -g " + BOXKEYINTMAX.Text + " -keyint_min " + BOXKEYINTMIN.Text
        End If


        If CHKDISCORRUPT.Checked = True Then
            DISCORRUPT = "+discardcorrupt"
            FFLAGS = " -fflags " + GPTSIDTS + DISCORRUPT + " "
        End If
        If CHKPTSDTS.Checked = True Then
            GPTSIDTS = "+genpts+igndts"
            FFLAGS = " -fflags " + GPTSIDTS + DISCORRUPT + " "
        End If

        If CHKTRIM.Checked Then
            If BOXTRIMSS.Text = "00:00:00" Then

            Else
                dblStringToDblSS = TimeSpan.Parse(BOXTRIMSS.Text).TotalSeconds
                TRIMSSVAL = " -ss " + BOXTRIMSS.Text
                'sDate = BOXTRIMSS.Text
                'hours = Trim(Split(sDate, ":")(0))
                'minutes = Trim(Split(sDate, ":")(1))
                'seconds = Trim(Split(sDate, ":")(2))
                'dblStringToDblSS = CLng(hours) * 3600 + CLng(minutes) * 60 + CLng(seconds)
            End If

            If BOXTRIMTO.Text = "00:00:00" Then

            Else
                dblStringToDblTO = TimeSpan.Parse(BOXTRIMTO.Text).TotalSeconds
                sDate = BOXTRIMTO.Text
                'hours = Trim(Split(sDate, ":")(0))
                'minutes = Trim(Split(sDate, ":")(1))
                'seconds = Trim(Split(sDate, ":")(2))
                'dblStringToDblTO = CLng(hours) * 3600 + CLng(minutes) * 60 + CLng(seconds)

                dblStringToDblRESULT = dblStringToDblTO - dblStringToDblSS
                TRIMTOVAL = " -to " + dblStringToDblRESULT.ToString
            End If
        End If

        If BOXCODEC.Text = "libx264" Then

            If CHKFAST1ST.Checked = True Then
                X264FAST1STFLAG = " -fastfirstpass 1 "
            End If
        End If

        If BOXCODEC.Text = "libx264" And AdvancedFRM.CHECKADV.Checked Then


        ElseIf BOXCODEC.Text = "libx265" Then

            If CHKFAST1ST.Checked = False Then
                FAST1STFLAG = ":slow-firstpass=1"
            End If

        End If

        If BOXCODEC.Text = "libx264" And AdvancedFRM.CHKCQM.Checked And Not PFBOX.Text = "main" And Not PFBOX.Text = "baseline" And Not PFBOX.Text = "copy" Then
            CQMVAL = ":cqmfile=KGP-X264-Custom-Quantization-Matrix.cfg"
        End If

        If BOXCODEC.Text = "libx264" And AdvancedFRM.CHECKADV.Checked Then
            ADVOPT = AdvancedFRM.LBMERANGE + AdvancedFRM.LBMEALGORITHM + AdvancedFRM.LBSR + AdvancedFRM.LBTR + AdvancedFRM.LBNOPSKIP + AdvancedFRM.LBNODCT +
                AdvancedFRM.LBBFRAMES + AdvancedFRM.LBAQMODE + AdvancedFRM.LBAQSTR + AdvancedFRM.LBSCENE

        End If
        If BOXCODEC.Text = "libx264" Or BOXCODEC.Text = "libx265" Then
            VCODECOPT = REFVAL + ADVOPT + CUSTOMCODECOPT + CQMVAL
        End If


        If BOXCODEC.Text = "libx264" Then
            If Not VCODECOPT = "" Then
                X264OPT = " -x264-params "
                'X264OPTVAL = ":"
            End If
        ElseIf BOXCODEC.Text = "libx265" Then
            If Not VCODECOPT = "" Then
                X264OPT = " -x265-params "
                'X264OPTVAL = ":"
            End If

        End If
        If Not VCODECOPT = "" Then
            VCODECOPT = VCODECOPT.Remove(0, 1)
        End If

        If BOXCODEC.Text = "libx264" Or BOXCODEC.Text = "libx265" Then
            VCODECOPT = X264OPT + X264OPTVAL + VCODECOPT
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

        If BOXACODEC.Text = "aac" Then
            AUDIOCODECVAL = BOXACODEC.Text + " -strict -2 -aac_tns 0 -aac_is 0 -aac_ms 1 -aac_pns 0 "
        End If


        Bitrateparam()


        If Not BOXDELAY.Text = "Auto" And Not BOXACODEC.Text = "No Audio" And Not BOXCONTAINER.Text.Contains("Mode ===") Then
            AUDIODELAYVAL = " -itsoffset " + VDELAYINFO + " "
        End If
        If BOXDELAY.Text = "Auto" And Not BOXDELAYINFO.Text = "" And Not BOXCONTAINER.Text.Contains("Mode ===") Then
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
        If BOXCFR.Text = "CFR" And BOXCODEC.Text = "libx264" Or BOXCFR.Text = "CFR" And BOXCODEC.Text = "libx265" Then
            CFRVAL = ":force-cfr=1"
        End If

        If CHKTRIM.Checked Then
            AUDIOTRIMSSVAL = " -ss " + BOXTRIMSS.Text
        End If

        If BOXAUDIOPATH.Text = "" And CHKAVISYNTH.Checked = True And CHKATRACKAVISYNTH.Checked = True Then
            INPUTAUDFILENAME = AUDIOTRIMSSVAL + " -i " + """" + InputCBOX.Text + """" + " "
        End If

        If Not BOXAUDIOPATH.Text = "" Then
            INPUTAUDFILENAME = AUDIOTRIMSSVAL + " -i " + """" + BOXAUDIOPATH.Text + """" + " "
        End If



        If CHKLOG.Checked Then
            ENABLELOG = " -report "
        End If




        If CHKRMMETADATA.Checked Then
            RMMETADATAVAL = " -map_metadata -1 -map_chapters -1"
        End If

        If Not BOXCODEC.Text = "libvpx" And Not BOXCODEC.Text = "libvpx-vp9" Then
            METADATA = RMMETADATAVAL + " -metadata description=" + """" + "Infinity Media Encoder by K.G.P-Louis" + """"
        Else

        End If
        INPUTVIDNAME = InputCBOX.Text
        OUTPUTFILENAME = OutputCBox.Text

        If CHKAVISYNTH.Checked = True Then
            INPUTVIDNAME = InputCBOX.Text + ".avs"
        Else
            INPUTVIDNAME = InputCBOX.Text
        End If

        If InputCBOX.Text.Contains("-f dshow") Then
        ElseIf OutputCBox.Text.Contains("//") Then
            If BOXCONTAINER.Text = "=== RTMP Streaming Mode ===" Then

                If Not BOXFLVFLAG.Text = "" Then
                    FLVOPT = "-flvflags " + BOXFLVFLAG.Text + " "
                End If

            End If
            FORCEEXTENSION = " -f flv " + FLVOPT

        Else
            Try
                Dim testFile As System.IO.FileInfo
                testFile = My.Computer.FileSystem.GetFileInfo(OUTPUTFILENAME)
                Dim folderPath As String = testFile.DirectoryName
                Dim outfileName As String = testFile.Name
                TEMPYTFILENAME = outfileName
            Catch

            End Try

        End If





        If Not BOXSUBPATH.Text = "" Then
            SUBTITLEPATH = " -fix_sub_duration " + " -i " + """" + BOXSUBPATH.Text + """" + " "
            If BOXFORMATINFO.Text = "MPEG-4" Then
                SUBTITLECHKVAL = " -scodec mov_text "
            ElseIf BOXFORMATINFO.Text = "Matroska" Then
                SUBTITLECHKVAL = " -scodec mov_text "
            ElseIf BOXFORMATINFO.Text = "MPEG-TS" Then
                SUBTITLECHKVAL = " -scodec copy "
            End If

        End If

        If Not BOXVFILTER.Text = "" Or Not BOXVFILTERCST.Text = "" Then
            If BOXVFILTER.Text = "" Then
                CUSTOMVIDEOFILTER = "," + BOXVFILTERCST.Text
            ElseIf BOXVFILTERCST.Text = "" Then
                CUSTOMVIDEOFILTER = "," + BOXVFILTER.Text
            Else
                CUSTOMVIDEOFILTER = "," + BOXVFILTER.Text + "," + BOXVFILTERCST.Text
            End If

        End If
        If Not BOXAFILTER.Text = "" Or Not BOXAFILTERCST.Text = "" Then
            If BOXAFILTER.Text = "" Then
                CUSTOMAUDIOFILTER = "," + BOXAFILTERCST.Text
            ElseIf BOXAFILTERCST.Text = "" Then
                CUSTOMAUDIOFILTER = "," + BOXAFILTER.Text
            Else
                CUSTOMAUDIOFILTER = "," + BOXAFILTER.Text + "," + BOXAFILTERCST.Text
            End If

        End If



        If BOXACODEC.Text = "copy" Then
            AUDIOFILTER = ""
        ElseIf CUSTOMAUDIOFILTER = "" Then
            AUDIOFILTER = ""
        Else
            CUSTOMAUDIOFILTER = Replace(CUSTOMAUDIOFILTER, ",", "",, 1)
            AUDIOFILTER = " -af " + """" + CUSTOMAUDIOFILTER + """"
        End If


        If BOXCODEC.Text = "copy" Then
            VIDEOFILTER = ""
        ElseIf CUSTOMVIDEOFILTER = "" And RSVAL = "" And DEINTVAL = "" And SPPVAL = "" Then
            VIDEOFILTER = ""
            VIDFILTERFLAG = ""

        Else
            VIDFILTERFLAG = DEINTVAL + RSVAL + SPPVAL + USHARPFILTER + CUSTOMVIDEOFILTER
            VIDFILTERFLAG = Replace(VIDFILTERFLAG, ",", "",, 1)
            VIDEOFILTER = " -filter_complex " + """" + VIDFILTERFLAG + """"

        End If

        If BOXCODEC.Text = "No Video" Or BOXCODEC.Text = "h264_qsv" Or BOXCODEC.Text = "libwebp" Or BOXCODEC.Text = "libaom-av1" Then
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

        If BOXACODEC.Text = "flac" And BOXAUDBITDEPTH.Text = "16" Then
            AUDIOBITVAL = " -sample_fmt s16 "
        ElseIf BOXACODEC.Text = "flac" And BOXAUDBITDEPTH.Text = "24" Then
            AUDIOBITVAL = " -sample_fmt s32 "
        ElseIf BOXACODEC.Text = "flac" And BOXAUDBITDEPTH.Text = "Auto" Then
            AUDIOBITVAL = " -sample_fmt s16 "
        End If


        If BOXACODEC.Text = "PCM" And BOXAUDBITDEPTH.Text = "Auto" Then
            AUDIOBITVAL = ""
        ElseIf BOXACODEC.Text = "PCM" And BOXAUDBITDEPTH.Text = "8" Then
            BOXAACPF.Text = "pcm_u8"
            AUDIOCODECVAL = "pcm_u8"
        ElseIf BOXACODEC.Text = "PCM" And BOXAUDBITDEPTH.Text = "16" Then
            BOXAACPF.Text = "pcm_s16le"
            AUDIOCODECVAL = "pcm_s16le"
        ElseIf BOXACODEC.Text = "PCM" And BOXAUDBITDEPTH.Text = "24" Then
            BOXAACPF.Text = "pcm_s24le"
            AUDIOCODECVAL = "pcm_s24le"
        ElseIf BOXACODEC.Text = "PCM" And BOXAUDBITDEPTH.Text = "32" Then
            BOXAACPF.Text = "pcm_s32le"
            AUDIOCODECVAL = "pcm_s32le"
        ElseIf BOXACODEC.Text = "PCM" And BOXAUDBITDEPTH.Text = "32(Float)" Then
            BOXAACPF.Text = "pcm_f32le"
            AUDIOCODECVAL = "pcm_f32le"
        End If



        If BOXACODEC.Text = "No Audio" Then
            AUDIOVAL = " -an " + AUDIOBITVAL
            AUDIOCHKVAL = ""
        Else
            AUDIOVAL = "" + AUDIOBITVAL
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
            FRMProgress.TRIMCHK = "Yes"
            TRIMSS = BOXTRIMSS.Text
            TRIMTO = BOXTRIMTO.Text
            FRMProgress.TRIMTO = BOXTRIMTO.Text
        End If

        'If BOXCODEC.Text = "copy" Then
        'CODECPRESET = " -copyinkf "
        'End If



    End Function
    Public Function StopProcess() As String
        initialValue()

    End Function

    Public Function prepareEncoding2() As String()
        If OutputCBox.Text.Contains("/") Then
        Else
            Try
                Dim testFile As System.IO.FileInfo
                testFile = My.Computer.FileSystem.GetFileInfo(OutputCBox.Text)
                Dim folderPath As String = testFile.DirectoryName

                If Not Directory.Exists(folderPath) Then
                    Directory.CreateDirectory(folderPath)
                End If
            Catch

            End Try

        End If




        If BOXACODEC.Text = "copy" And BOXFORMATINFO.Text = "MPEG-TS" And BOXACODECINFO.Text = "AAC LC" And Not BOXCONTAINER.Text = "ts" Then
            BITSTREAMFILTER = " -bsf:a aac_adtstoasc "
        ElseIf BOXCODEC.Text = "copy" And BOXFORMATINFO.Text = "MPEG-4" And BOXCONTAINER.Text = "ts" Or BOXCONTAINER.Text = "m3u8" Then
            BITSTREAMFILTER = " -bsf:v h264_mp4toannexb "
        End If

        If BOXCONTAINER.Text = "=== HLS Encoding Mode ===" Then

            Dim calckeyint As Double
            Dim calcforcekeyint As Double
            'calckeyint = 1 / (BOXFPSINFO.Text * 2)
            calckeyint = BOXFPSINFO.Text * 2
            'calckeyint = BOXCUSTOMT.Text / 2
            calcforcekeyint = 2
            'calckeyint = BOXFPSINFO.Text
            'HLSOPTIONFLAG = " -force_key_frames expr:gte(t,n_forced*" + calckeyint.ToString + ") -keyint_min " + BOXCUSTOMT.Text + " -g " + BOXCUSTOMT.Text + " -hls_list_size 0 -sc_threshold 0 -hls_time " + BOXCUSTOMT.Text + " "
            HLSOPTIONFLAG = " -force_key_frames expr:gte(t,n_forced*" + calcforcekeyint.ToString + ") -force_key_frames 0 -keyint_min " + calckeyint.ToString + " -g " + calckeyint.ToString + " -hls_list_size 0 -sc_threshold 0 -hls_time " + BOXCUSTOMT.Text + " "
            'HLSOPTIONFLAG = " -force_key_frames expr:gte(t,n_forced*" + calckeyint.ToString + ") -keyint_min " + calckeyint.ToString + " -g " + calckeyint.ToString + " -hls_list_size 0 -sc_threshold 0 -hls_time " + BOXCUSTOMT.Text + " "
            'HLSOPTIONFLAG = " -force_key_frames expr:gte(t,n_forced*" + BOXCUSTOMT.Text + ") -keyint_min " + BOXCUSTOMT.Text + " -g " + BOXCUSTOMT.Text + " -hls_list_size 0 -sc_threshold 0 -hls_time " + BOXCUSTOMT.Text + " "
            'HLSOPTIONFLAG = " -force_key_frames expr:gte(t,n_forced*" + BOXCUSTOMT.Text + ") -keyint_min " + BOXCUSTOMT.Text + " -g " + BOXCUSTOMT.Text + " -f segment -segment_list_type m3u8 -segment_list_size 0 -segment_list .\HLS_Output\index.m3u8 -sc_threshold 0 -segment_time " + BOXCUSTOMT.Text + " " + ".\HLS_Output\index%03d.ts"
            If BOXCODEC.Text = "libx265" Then
                VCODECOPT = VCODECOPT + ":keyint=" + calckeyint.ToString + ":min-keyint=" + calckeyint.ToString + ":pass=1" + ":scenecut=0"
            End If
            SHELLCMD = FFMPEGEXE + " " + FFLAGS + FFLAGS + CUSTOMFFMPEGOPTF + TRIMSSVAL + " -i " + """" + INPUTVIDNAME + """" + AUDIODELAYVAL + INPUTAUDFILENAME + SUBTITLEPATH + TRIMTOVAL + VIDEOFILTER + AUDIOFILTER + CODEC + CODECPRESET + PFVAL + LVVAL + BITVAL + FPSVAL + HLSOPTIONFLAG + HLSADDRESS + CUSTOMFFMPEGOPT + VCODECOPT + CFRVAL + DEBLOCKVAL + VIDEOVAL + ASPECTRATIOVAL + CBRVAL + ENABLELOG +
            MULTITRACK + AUDIOMAPVAL + AUDIOCHKVAL + AUDIOCODECVAL + AUDIOPFVAL + AUDIOBITRATEVAL + AUDIOSAMPLEVAL + AUDIOCHANNELVAL + AUDIOVAL + SUBTITLECHKVAL + METADATA + " " + """" + OUTPUTFILENAME + """"
            'SHELLCMD = FFMPEGEXE + " " + FFLAGS + CUSTOMFFMPEGOPTF + TRIMSSVAL + " -i " + """" + INPUTVIDNAME + """" + AUDIODELAYVAL + INPUTAUDFILENAME + SUBTITLEPATH + TRIMTOVAL + VIDEOFILTER + AUDIOFILTER + CODEC + CODECPRESET + PFVAL + LVVAL + BITVAL+ FPSVAL + HLSADDRESS + CUSTOMFFMPEGOPT +VCODECOPT + CFRVAL + DEBLOCKVAL + VIDEOVAL + ASPECTRATIOVAL + CBRVAL + ENABLELOG +
            'MULTITRACK + AUDIOMAPVAL + AUDIOCHKVAL + AUDIOCODECVAL + AUDIOPFVAL + AUDIOBITRATEVAL + AUDIOSAMPLEVAL + AUDIOCHANNELVAL + AUDIOVAL + SUBTITLECHKVAL + METADATA + HLSOPTIONFLAG
        ElseIf INPUTVIDNAME.Contains("http://ustream.tv") Or INPUTVIDNAME.Contains("http://www.ustream.tv") Or INPUTVIDNAME.Contains("https://ustream.tv/") Or
            INPUTVIDNAME.Contains("https://www.ustream.tv/") Or INPUTVIDNAME.Contains("http://www.connectcast.tv/") Or INPUTVIDNAME.Contains("http://connectcast.tv/") Or INPUTVIDNAME.Contains("http://www.dailymotion.com") Or INPUTVIDNAME.Contains("http://vaughnlive.tv") Or
            INPUTVIDNAME.Contains("https://twitch.tv/") Or INPUTVIDNAME.Contains("https://www.twitch.tv/") Then
            If BOXCODEC.Text = "copy" Then
                VIDEOFILTER = ""
            End If
            If BOXACODEC.Text = "copy" Then
                AUDIOFILTER = ""
            End If

            SHELLCMD = LIVESTREAMEREXE + " " + """" + INPUTVIDNAME + """" + " best -o - | " +
                  FFMPEGEXE + " -y " + FFLAGS + FFLAGS + " -i - " + AUDIODELAYVAL + INPUTAUDFILENAME + VIDEOFILTER + AUDIOFILTER + CODEC + " -vsync 0 -bsf:a aac_adtstoasc " + CODECPRESET + PFVAL + LVVAL + KEYINTVAL + BITVAL + FPSVAL + VCODECOPT + CFRVAL + DEBLOCKVAL + VIDEOVAL + ASPECTRATIOVAL + CBRVAL + ENABLELOG + MULTITRACK + AUDIOMAPVAL + AUDIOCHKVAL + AUDIOCODECVAL + AUDIOPFVAL + AUDIOBITRATEVAL + AUDIOSAMPLEVAL + AUDIOCHANNELVAL + AUDIOVAL + METADATA + " " + """" + OUTPUTFILENAME + """"

        ElseIf BOXBITRATEMODE.Text = "2pass-ABR" Then

            SHELLCMD = FFMPEGEXE + " -y " + CUSTOMFFMPEGOPTF + FFLAGS + TRIMSSVAL + " -i " + """" + INPUTVIDNAME + """" + AUDIODELAYVAL + INPUTAUDFILENAME + SUBTITLEPATH + TRIMTOVAL + VIDEOFILTER + AUDIOFILTER + CODEC + CODECPRESET + PFVAL + LVVAL + KEYINTVAL + BITVAL + FPSVAL + CUSTOMFFMPEGOPT + EXTRAFFPRAM + VCODECOPT + ":pass=1" + FAST1STFLAG + CFRVAL + DEBLOCKVAL + VIDEOVAL + ASPECTRATIOVAL + CBRVAL + ENABLELOG + X264FAST1STFLAG +
                 MULTITRACK + AUDIOMAPVAL + AUDIOCHKVAL + AUDIOCODECVAL + AUDIOPFVAL + AUDIOBITRATEVAL + AUDIOSAMPLEVAL + AUDIOCHANNELVAL + AUDIOVAL + SUBTITLECHKVAL + METADATA + " " + "-f mp4 NUL " + " & " +
            FFMPEGEXE + CUSTOMFFMPEGOPTF + FFLAGS + TRIMSSVAL + " -i " + """" + INPUTVIDNAME + """" + AUDIODELAYVAL + INPUTAUDFILENAME + SUBTITLEPATH + TRIMTOVAL + VIDEOFILTER + AUDIOFILTER + CODEC + CODECPRESET + PFVAL + LVVAL + KEYINTVAL + BITVAL + CUSTOMFFMPEGOPT + EXTRAFFPRAM + VCODECOPT + ":pass=2" + CFRVAL + DEBLOCKVAL + VIDEOVAL + ASPECTRATIOVAL + CBRVAL + ENABLELOG +
            MULTITRACK + AUDIOMAPVAL + AUDIOCHKVAL + AUDIOCODECVAL + AUDIOPFVAL + AUDIOBITRATEVAL + AUDIOSAMPLEVAL + AUDIOCHANNELVAL + AUDIOVAL + SUBTITLECHKVAL + METADATA + " " + """" + OUTPUTFILENAME + """"
        Else
            If OUTPUTFILENAME.Contains("//") Or CHKINPUTDSHOW.Checked = True Then
                If Not INPUTVIDNAME.Contains("-f dshow") Then
                    realtimeenc = " -re "
                    FORCEEXTENSION = " -f flv "
                    INPUTVIDNAME = " -i " + """" + INPUTVIDNAME + """"
                Else
                    If BOXCONTAINER.Text = "=== RTMP Streaming Mode ===" Then

                        If Not BOXFLVFLAG.Text = "" Then
                            FLVOPT = "-flvflags " + BOXFLVFLAG.Text + " "
                        End If


                    End If
                    FORCEEXTENSION = " -f flv " + FLVOPT
                End If
                If Not OUTPUTFILENAME.Contains("//") Then
                    FORCEEXTENSION = ""
                End If
            Else
                INPUTVIDNAME = " -i " + """" + INPUTVIDNAME + """"
            End If
            SHELLCMD = FFMPEGEXE + " -y " + realtimeenc + CUSTOMFFMPEGOPTF + FFLAGS + TRIMSSVAL + AUDIODELAYVAL + INPUTVIDNAME + INPUTAUDFILENAME + SUBTITLEPATH + TRIMTOVAL + VIDEOFILTER + AUDIOFILTER + CODEC + CODECPRESET + PFVAL + LVVAL + KEYINTVAL + BITMODE + BITVAL + FPSVAL + CUSTOMFFMPEGOPT + EXTRAFFPRAM + VCODECOPT + CFRVAL + DEBLOCKVAL + VIDEOVAL + ASPECTRATIOVAL + CBRVAL + ENABLELOG +
                     MULTITRACK + AUDIOMAPVAL + AUDIOCHKVAL + AUDIOCODECVAL + AUDIOPFVAL + AUDIOBITRATEVAL + AUDIOSAMPLEVAL + AUDIOCHANNELVAL + AUDIOVAL + SUBTITLECHKVAL + BITSTREAMFILTER + METADATA + FORCEEXTENSION + " " + """" + OUTPUTFILENAME + """"

        End If
        realtimeenc = ""
        FORCEEXTENSION = ""
        'FRMProgress.FFPARAM = SHELLCMD
        'FRMProgress.ENCODINGLIST.Items.Add(FRMProgress.FFPARAM)

    End Function
    Public Function inputMediainfo() As String()
        LBINPUTINFO.Text = "Video Codec : " + BOXCODECINFO.Text + " | Format : " + BOXFORMATINFO.Text + " | Resolution : " + BOXRSINFO.Text + " | Framerate : " + BOXFPSINFO.Text + " | Aspect Ratio : " + BOXASPECT.Text + " | " + BOXINTERLACE.Text & vbCrLf &
         "Delay : " + BOXDELAYINFO.Text + "Sec " + "| Duration : " + BOXDURATION.Text + " | Profile : " + BOXPFINFO.Text + " | Reference Frames : " + BOXREFINFO.Text + " | Audio Codec : " + BOXACODECINFO.Text
    End Function
    Public Function getMediainfo() As String()

        BOXINTERLACE.Text = ""
        BOXASPECT.Text = ""
        BOXDURATION.Text = ""
        BOXCODECINFO.Text = ""
        BOXDELAYINFO.Text = ""
        BOXFPSINFO.Text = ""
        MI.Open(InputCBOX.Text)
        BOXCODECINFO.Text = MI.Get_(StreamKind.Video, 0, "Codec")
        'BOXFPSINFO.Text = MI.Get_(StreamKind.Video, 0, "FrameRate")
        BOXDELAYINFO.Text = MI.Get_(StreamKind.Audio, 0, "Video_Delay")
        If BOXDELAYINFO.Text = "" Then
            BOXDELAYINFO.Text = "0"
        End If
        INFOFRAMEMODE = MI.Get_(StreamKind.Video, 0, "FrameRate_Mode")
        If Not BOXDELAYINFO.Text = "" Then
            Dim VDELAYINFO1 As String = (BOXDELAYINFO.Text * (1 / 1000)).ToString
            VDELAYINFO = VDELAYINFO1

            BOXDELAYINFO.Text = VDELAYINFO
        End If
        Try
            BOXASPECT.Text = MI.Get_(StreamKind.Video, 0, "DisplayAspectRatio/String")
            BOXDURATION.Text = MI.Get_(StreamKind.Video, 0, "Duration/String3")
            BOXDURATION2.Text = MI.Get_(StreamKind.Video, 0, "Duration")
            BOXPFINFO.Text = MI.Get_(StreamKind.Video, 0, "Format_Profile")
            BOXFORMATINFO.Text = MI.Get_(StreamKind.General, 0, "Format")

            BOXRSINFO.Text = MI.Get_(StreamKind.Video, 0, "Width") + "x" + MI.Get_(StreamKind.Video, 0, "Height")
            BOXACODECINFO.Text = MI.Get_(StreamKind.Audio, 0, "Codec")
            BOXREFINFO.Text = MI.Get_(StreamKind.Video, 0, "Format_Settings_RefFrames")
            BOXSAMPLERINFO.Text = MI.Get_(StreamKind.Audio, 0, "SamplingRate/String")
            BOXAUDCHINFO.Text = MI.Get_(StreamKind.Audio, 0, "Channel(s)")
            BOXAUDBITINFO.Text = MI.Get_(StreamKind.Audio, 0, "BitDepth/String")
            BOXAUDBITRATEINFO.Text = Fix(MI.Get_(StreamKind.Audio, 0, "BitRate") / 1000)
            BOXINTERLACE.Text = MI.Get_(StreamKind.Video, 0, "ScanType")
        Catch

        End Try




        MI.Close()

        getMediainfoFFMPEG()
    End Function

    Public Function getMediainfoFFMPEG() As String()



        Dim mediaffinfo As String

        Dim p As New Process
        Dim outputReader2 As StreamReader
        With p.StartInfo
            .WindowStyle = ProcessWindowStyle.Minimized
            .Arguments = " /c title Infinity Media Encoder & " + """" + STARTUPPATH + "\Tools\ffmpeg32\ffmpeg.exe" + """" + " -i " + """" + InputCBOX.Text + """"
            .FileName = "cmd"

            .UseShellExecute = False
            .RedirectStandardOutput = True
            .RedirectStandardError = True
            .CreateNoWindow = True


        End With

        p.Start()
        outputReader2 = p.StandardError
        Dim output2 As String

        FRMMULTISTREAM.LISTVIDEOSTREAM.Items.Clear()
        FRMMULTISTREAM.MAPVID.Items.Clear()
        FRMMULTISTREAM.LISTAUDIOSTREAM.Items.Clear()
        FRMMULTISTREAM.MAPAUD.Items.Clear()


        While outputReader2.EndOfStream = False


            output2 = outputReader2.ReadLine()
            mediaffinfo = output2

            If output2.Contains("Stream #") And output2.Contains("Video:") Then
                Dim mapcount As Integer
                Try
                    Dim split4 As String() = output2.Split(New [Char]() {"#"})
                    Dim String14 As String = split4(1)

                    FRMMULTISTREAM.LISTVIDEOSTREAM.Items.Add(String14)
                    FRMMULTISTREAM.MAPVID.Items.Add("0:" & mapcount)
                    mapcount = mapcount + 1

                    'Dim split5 As String() = String14.Split(New [Char]() {" ", ","})
                    If String14.Contains("fps") Then


                        Dim startchar As Integer = String14.IndexOf("fps")
                        Dim split6 As String = String14.Substring(startchar - 8)
                        'Dim String15 As String = split5(22)
                        Dim split15 As String() = split6.Split(New [Char]() {" ", ","})
                        Dim String16 As String = split15(2)
                        'MsgBox(String15)
                        If BOXFPSINFO.Text = "" Then
                            BOXFPSINFO.Text = String16
                            If Not BOXFPSINFO.Text.Contains(".") Then
                                BOXFPSINFO.Text = BOXFPSINFO.Text + ".00"

                            End If

                        End If
                    Else
                        If BOXFPSINFO.Text = "" Then
                            Dim split41 As String() = output2.Split(New [Char]() {"#"})
                            Dim String141 As String = split41(1)
                            Dim startchar1 As Integer = String141.IndexOf("tbr")
                            Dim split61 As String = String141.Substring(startchar1 - 4)
                            'Dim String15 As String = split5(22)
                            Dim split151 As String() = split61.Split(New [Char]() {" ", ","})
                            Dim String161 As String = split151(1)
                            BOXFPSINFO.Text = String161
                            If Not BOXFPSINFO.Text.Contains(".") Then
                                BOXFPSINFO.Text = BOXFPSINFO.Text + ".00"

                            End If
                        End If
                    End If


                Catch

                End Try
            End If


            If output2.Contains("Stream #") And output2.Contains("Audio:") Then
                Dim mapcount2 As Integer
                Try
                    Dim split4 As String() = output2.Split(New [Char]() {"#"})
                    Dim String14 As String = split4(1)

                    FRMMULTISTREAM.LISTAUDIOSTREAM.Items.Add(String14)
                    FRMMULTISTREAM.MAPAUD.Items.Add("0:" & mapcount2)
                    mapcount2 = mapcount2 + 1


                Catch

                End Try
            End If

            If output2.Contains("Duration:") Then
                Try
                    Dim splitDUR As String() = output2.Split(New [Char]() {" ", ","})
                    Dim String14 As String = splitDUR(3)

                    If BOXDURATION.Text = "" Then
                        BOXDURATION.Text = String14
                        BOXDURATION2.Text = TimeSpan.Parse(String14).TotalSeconds
                        p.Kill()

                    End If

                Catch

                End Try
            End If
            If PRESETLOADING = False Then
                BOXTRIMTO.Text = BOXDURATION.Text
            End If





        End While
        inputMediainfo()
        If Not LOADEDMEDIA = InputCBOX.Text Then
            If PRESETLOADING = False Then
                CHKTRIM.Checked = False
                BOXTRIMSS.Text = "00:00:00"
            End If

        End If
        LOADEDMEDIA = InputCBOX.Text
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TrimPreviewPlayer2.Show()

    End Sub
    Public Function prepareOpen() As String()
        CHKINPUTDSHOW.Checked = False
        INPUTFILENAME = InputCBOX.Text
        CHKAVISYNTH.Checked = False
        If BOXFORMATINFO.Text = "MPEG-4" Or BOXFORMATINFO.Text = "Matroska" Or BOXFORMATINFO.Text = "AVI" Or BOXFORMATINFO.Text = "MOV" Or BOXFORMATINFO.Text = "MPEG-TS" Or
            BOXFORMATINFO.Text = "MPEG-TS" Then
            CHKAVISYNTH.Enabled = True
            CHKAVISYNTH.Checked = False

        End If
        INPUTFILENAME2 = InputCBOX.Text


        If CHKAUTONAME.Checked Then
            If InputCBOX.Text = "" Then

            ElseIf InputCBOX.Text.Contains("//") Then
                If OutputCBox.Text = "" Then
                    OutputCBox.Text = "[InfinityEncoder]Video.mp4"
                    OUTPUTFILENAME = OutputCBox.Text
                Else

                End If
            ElseIf InputCBOX.Text.Contains("-f dshow") Then
            ElseIf BOXCONTAINER.Text.Contains("=== RTMP Streaming Mode ===") Then

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



        SwitchContainer()



    End Function
    Public Function initialValue() As String()
initvalue:
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
        AUDIOTRIMSSVAL = ""
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
        VCODECOPT = ""
        INPUTAUDFILENAME = ""
        VIDEOFILTER = ""
        AUDIOFILTER = ""
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
        OUTPUTFILENAME = ""
        OUTPUTFILENAMEONLY = ""

        HLSOPTIONFLAG = ""
        YTMAP = ""
        FAST1STFLAG = ""
        CODECPRESET1ST = ""
        X264FAST1STFLAG = ""
        BITSTREAMFILTER = ""
        FORCEEXTENSION = ""
        VDELAYINFO = ""
        GPTSIDTS = ""
        FFLAGS = ""
        DISCORRUPT = ""
        EXTRAFFPRAM = ""
        RMMETADATAVAL = ""
        YOUTUBEAUDQ = ""
        AUDIOBITVAL = ""
        VIDFILTERFLAG = ""
        CUSTOMVIDEOFILTER = ""
        CUSTOMAUDIOFILTER = ""
        YTVP9ONLY = False
        FLVOPT = ""


    End Function


    Private Sub Button9_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click

        ENCLISTVIEWMAIN.Items.Clear()
        BOXCMDINFO.Text = ""
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

        For i = 0 To ENCLISTVIEWMAIN.SelectedItems.Count - 1

            ENCLISTVIEWMAIN.Items.Remove(ENCLISTVIEWMAIN.SelectedItems(0))

        Next
        BOXCMDINFO.Text = ""
    End Sub



    Private Sub BTNSTARTPRC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNSTARTPRC.Click
        If BOXACODEC.Text = "libfdk_aac" Then
            Dim testFile As System.IO.FileInfo
            testFile = My.Computer.FileSystem.GetFileInfo(BOXFFMPEGEXE.Text)
            Dim folderPath As String = testFile.DirectoryName
            If Not System.IO.File.Exists(folderPath + "\libfdk-aac-0.dll") Then
                initialValue()
                MsgBox("Does not exist libfdk-aac-0.dll. change to another audio codec or" + vbCrLf + "Please put libfdk-aac-0.dll to " + folderPath, MsgBoxStyle.Critical, "Infinity Media Encoder")
                GoTo noencoding

            End If

        End If

        If CHKINTELLIDEINT.Checked = True Then
            If BOXINTERLACE.Text = "" Or BOXINTERLACE.Text = "Progressive" Then
                If LBDEINTMODE.Text = "Disabled" Or LBDEINTMODE.Text = "" Then
                Else

                    Dim answer As Integer = MsgBox("Input video is not interlaced video but enabled deinterlace." + vbCrLf + "Do you wish continue?", MsgBoxStyle.YesNo, "Infinity Media Encoder")
                    If answer = DialogResult.Yes Then
                        GoTo continueencoding1
                    ElseIf answer = DialogResult.No Then
                        initialValue()
                        GoTo noencoding
                    End If
                End If
            ElseIf BOXINTERLACE.Text = "Interlaced" Then
                If Not LBDEINTMODE.Text = "Disabled" Or LBDEINTMODE.Text = "" Then
                Else

                    Dim answer As Integer = MsgBox("Input video is interlaced video but disabled deinterlace." + vbCrLf + "Do you wish continue?", MsgBoxStyle.YesNo, "Infinity Media Encoder")
                    If answer = DialogResult.Yes Then
                        GoTo continueencoding1
                    ElseIf answer = DialogResult.No Then
                        initialValue()
                        GoTo noencoding
                    End If
                End If
            End If
        End If




continueencoding1:
        If My.Computer.FileSystem.FileExists(OutputCBox.Text) Then
            Dim answer As Integer = MsgBox("File already exists. Do you want to overwrite?", MsgBoxStyle.YesNo, "Infinity Media Encoder")
            If answer = DialogResult.Yes Then
                GoTo continueencoding
            ElseIf answer = DialogResult.No Then
                initialValue()
                GoTo noencoding
            End If
        End If

continueencoding:
        MULTIENCODINGFLAG = False
        INPUTVIDNAME = InputCBOX.Text
        OUTPUTFILENAME = OutputCBox.Text
        If Not InputCBOX.Text = "" And Not OutputCBox.Text = "" Then



            If CHKMULTIENC.Checked Then
                prepareEncoding()
                prepareEncoding2()
                Shell("cmd /c title Infinity Media Encoder & " + SHELLCMD + " & comp.bat", vbNormalFocus)
            Else
                If FRMProgress.BackgroundWorker_1.IsBusy = True Then
                    prepareEncoding()
                    prepareEncoding2()
                    Invoke(New Action(Function() COPYONEITEM()))
                    MsgBox("Added to Encoding List", MsgBoxStyle.Information, "Infinity Media Encoder")
                    GoTo noencoding
                Else
                    FRMProgress.Close()
                    prepareEncoding()
                    prepareEncoding2()
                    Invoke(New Action(Function() COPYONEITEM()))

                End If

                FRMProgress.Show()
                FRMProgress.RunProcess()
                FRMProgress.Timer1.Start()
            End If


            If CHKDEBUG.Checked Then
                BOXDEBUG.Text = "cmd /c title Infinity Media Encoder & " + SHELLCMD + " & comp.bat"
            End If

            initialValue()
        Else
            MsgBox("Please specific Input Path / Output Path", MsgBoxStyle.Critical, "Infinity Media Encoder")
        End If

noencoding:
        initialValue()
    End Sub
    Public Function COPYONEITEM() As String()


        If FRMProgress.BackgroundWorker_1.IsBusy = True Then
        Else
            FRMProgress.ENCODINGLISTVIEW.Items.Clear()
        End If


        Dim filenameinfo As String
        Dim outfilename As String
        If OUTPUTFILENAME.Contains("//") Then
            outfilename = "Live Streaming"
        Else
            filenameinfo = System.IO.Path.GetFileName(OutputCBox.Text)
            Dim testFile As System.IO.FileInfo
            testFile = My.Computer.FileSystem.GetFileInfo(filenameinfo)
            outfilename = testFile.Name
        End If


        Dim add As New ListViewItem(outfilename)

        add.SubItems.Add("")
        add.SubItems.Add(SHELLCMD)
        If CHKTRIM.Checked = True Then

            add.SubItems.Add(BOXTRIMSS.Text)
            add.SubItems.Add(BOXTRIMTO.Text)
            add.SubItems.Add(BOXDURATION.Text)
            add.SubItems.Add(OutputCBox.Text)
        Else
            add.SubItems.Add("0")
            add.SubItems.Add("0")
            add.SubItems.Add(BOXDURATION.Text)
            add.SubItems.Add(OutputCBox.Text)
        End If

        FRMProgress.ENCODINGLISTVIEW.Items.Add(add)
        FRMProgress.ENCODINGLISTVIEW.EndUpdate()
        Windows.Forms.Application.DoEvents()
    End Function
    Private Sub BTBATCHENC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTBATCHENC.Click
        FRMProgress.Close()
        If ENCLISTVIEWMAIN.Items.Count = 0 Then
            GoTo noencoding
        End If
        Dim answer As Integer = MsgBox("If file exists, will be overwrite." + vbCrLf + "Do you wish continue?", MsgBoxStyle.YesNo, "Infinity Media Encoder")
        If answer = DialogResult.Yes Then
            GoTo continueencoding
        ElseIf answer = DialogResult.No Then
            initialValue()
            GoTo noencoding
        End If
continueencoding:
        prepareEncoding()
        prepareEncoding2()
        MULTIENCODINGFLAG = True

        'If BOXCODECINFO.Text = "" Then
        'getMediainfo()
        'ElseIf InputCBOX.Text.Contains("-f dshow") Then
        'End If

        Dim CMD As String
        Dim CMD1 As String

        FRMProgress.ENCODINGLISTVIEW.Items.Clear()
        Invoke(New Action(Function() COPYITEMS()))
        Windows.Forms.Application.DoEvents()

        FRMProgress.Show()
        FRMProgress.RunProcess()
        FRMProgress.Timer1.Start()
        'Shell("cmd /c title Infinity Media Encoder & " + CMD1 + CMD + " &comp.bat", vbNormalFocus)


        initialValue()
        CMD1 = ""
        CMD = ""
        SHELLCMD = ""
noencoding:

        initialValue()

        CMD1 = ""
        CMD = ""
        SHELLCMD = ""
    End Sub
    Private Sub BackgroundWorker2_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker2.DoWork



    End Sub
    Private Sub BackgroundWorker2_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker2.RunWorkerCompleted


    End Sub
    Public Function COPYITEMS() As String()
        FRMProgress.ENCODINGLISTVIEW.Items.Clear()
        For i As Integer = 0 To ENCLISTVIEWMAIN.Items.Count - 1
            FRMProgress.ENCODINGLISTVIEW.Items.Add(ENCLISTVIEWMAIN.Items(i).Clone)
        Next
        FRMProgress.ENCODINGLISTVIEW.EndUpdate()
        Windows.Forms.Application.DoEvents()
    End Function

    Private Sub BTENCSELECTED_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTENCSELECTED.Click
        If ENCLISTVIEWMAIN.Items.Count = 0 Or ENCLISTVIEWMAIN.SelectedItems.Count = 0 Then
            GoTo noencoding
        End If
        FRMProgress.Close()
        Dim answer1 As Integer = MsgBox("If file exists, will be overwrite." + vbCrLf + "Do you wish continue?", MsgBoxStyle.YesNo, "Infinity Media Encoder")
        If answer1 = DialogResult.Yes Then
            GoTo continueencoding
        ElseIf answer1 = DialogResult.No Then
            initialValue()
            GoTo noencoding
        End If


continueencoding:

        'If BOXCODECINFO.Text = "" Then
        'getMediainfo()
        'ElseIf InputCBOX.Text.Contains("-f dshow") Then
        'End If

        Dim CMD As String
        Dim CMD1 As String

        prepareEncoding()
        prepareEncoding2()
        MULTIENCODINGFLAG = True

        'If BOXCODECINFO.Text = "" Then
        'getMediainfo()
        'ElseIf InputCBOX.Text.Contains("-f dshow") Then
        'End If


        Invoke(New Action(Function() COPYSELECTEDITEMS()))
        Windows.Forms.Application.DoEvents()

        FRMProgress.Show()
        FRMProgress.RunProcess()
        FRMProgress.Timer1.Start()
        'Shell("cmd /c title Infinity Media Encoder & " + CMD1 + CMD + " &comp.bat", vbNormalFocus)


        initialValue()
        CMD1 = ""
        CMD = ""
        SHELLCMD = ""

        initialValue()
        CMD1 = ""
        CMD = ""
        SHELLCMD = ""
noencoding:
        initialValue()

        CMD1 = ""
        CMD = ""
        SHELLCMD = ""

    End Sub
    Public Function COPYSELECTEDITEMS() As String()
        FRMProgress.ENCODINGLISTVIEW.Items.Clear()
        For i As Integer = 0 To ENCLISTVIEWMAIN.SelectedItems.Count - 1
            FRMProgress.ENCODINGLISTVIEW.Items.Add(ENCLISTVIEWMAIN.SelectedItems(i).Clone)
        Next
        FRMProgress.ENCODINGLISTVIEW.EndUpdate()
        Windows.Forms.Application.DoEvents()
    End Function

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNINPUTSUB.Click

        OpenFileDialog2.Filter = "All Files (*.*)|*.*|Subtitle Files |*.srt;*.smi"
        OpenFileDialog2.FilterIndex = 1
        If Not OpenFileDialog2.ShowDialog = Windows.Forms.DialogResult.Cancel Then
            strFileNameOpen = OpenFileDialog2.FileName

            BOXSUBPATH.Text = strFileNameOpen
        End If
    End Sub

    Private Sub BTNOPENOUTFOLDER_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNOPENOUTFOLDER.Click
        If Not InputCBOX.Text = "" And Not OutputCBox.Text = "" Then

            Dim testFile As System.IO.FileInfo
            testFile = My.Computer.FileSystem.GetFileInfo(OutputCBox.Text)
            Dim folderPath As String = testFile.DirectoryName

            If My.Computer.FileSystem.FileExists(OutputCBox.Text) Then
                Shell("explorer /select, " & Chr(34) & OutputCBox.Text & Chr(34), vbNormalFocus)
            Else
                Process.Start(folderPath)
            End If

        Else
            MsgBox("Please specific Input Path / Output Path", MsgBoxStyle.Critical, "Infinity Media Encoder")
        End If

    End Sub

    Private Sub InputCBOX_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles InputCBOX.DragDrop

        WaitScreen.Show()
        Dim files() As String = e.Data.GetData(DataFormats.FileDrop)
        For Each path In files
            InputCBOX.Text = path
            getMediainfo()


            prepareOpen()
            SwitchContainer()
        Next

        WaitScreen.Close()
    End Sub
    Private Sub InputCBOX_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles InputCBOX.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If

    End Sub




    Private Sub BTNCUSTOMPARAM_Click_3(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCUSTOMPARAM.Click
        FRMCUSTOMENC.ShowDialog()
    End Sub

    Private Sub CHKDEBUG_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHKDEBUG.CheckedChanged
        If CHKDEBUG.Checked = True Then
            BOXDEBUG.Enabled = True
        Else
            BOXDEBUG.Enabled = False
        End If
    End Sub
    Private Sub BOXCONTAINER_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles BOXCONTAINER.SelectedValueChanged
        ChangeItems()
        SwitchContainer()
    End Sub

    Private Sub BOXCONTAINER_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles BOXCONTAINER.TextChanged
        ChangeItems()
        SwitchContainer()

    End Sub

    Private Sub OutputCBox_TextUpdate(ByVal sender As Object, ByVal e As System.EventArgs) Handles OutputCBox.TextUpdate
        If Not OutputCBox.Text = "" And Not BOXCONTAINER.Text.Contains("===") Then
            'Dim ext As String = System.IO.Path.GetExtension(OutputCBox.Text)
            'Dim ext3 As String = System.IO.Path.ChangeExtension(OutputCBox.Text, BOXCONTAINER.Text)

            ' Dim ext2 As String = ext.Replace(".", "")
            'BOXCONTAINER.Text = ext3

            'OutputCBox.Text = ext3

        Else

        End If

    End Sub


    Private Sub BTNENCVIDPREVIEWER_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNENCVIDPREVIEWER.Click
        If Not InputCBOX.Text = "" And Not OutputCBox.Text = "" Then
            prepareEncoding()
            prepareEncoding2()



            OUTPUTFILENAME = "-"
            FORCEEXTENSION = " -f mpegts "
            INPUTVIDNAME = " -i " + """" + InputCBOX.Text + """"

            If BOXACODEC.Text = "copy" And BOXFORMATINFO.Text = "MPEG-TS" And BOXACODECINFO.Text = "AAC LC" And Not BOXCONTAINER.Text = "ts" Then
                BITSTREAMFILTER = " -bsf:a aac_adtstoasc "
            ElseIf BOXCODEC.Text = "copy" And BOXFORMATINFO.Text = "MPEG-4" Then
                BITSTREAMFILTER = " -bsf:v h264_mp4toannexb "
            End If

            SHELLCMD = FFMPEGEXE + CUSTOMFFMPEGOPTF + FFLAGS + TRIMSSVAL + AUDIODELAYVAL + INPUTVIDNAME.ToString + INPUTAUDFILENAME + SUBTITLEPATH + TRIMTOVAL + VIDEOFILTER + AUDIOFILTER + CODEC + CODECPRESET + PFVAL + LVVAL + KEYINTVAL + BITVAL + FPSVAL + CUSTOMFFMPEGOPT + EXTRAFFPRAM + VCODECOPT + CFRVAL + DEBLOCKVAL + VIDEOVAL + ASPECTRATIOVAL + CBRVAL + ENABLELOG +
     MULTITRACK + AUDIOMAPVAL + AUDIOCHKVAL + AUDIOCODECVAL + AUDIOPFVAL + AUDIOBITRATEVAL + AUDIOSAMPLEVAL + AUDIOCHANNELVAL + AUDIOVAL + SUBTITLECHKVAL + BITSTREAMFILTER + METADATA + FORCEEXTENSION + " " + """" + OUTPUTFILENAME + """" + " | " + FFPLAYEXE + " -x 800 -y 450 -i - " + " &  comp.bat"

            'Shell("cmd cmd /c title Infinity Media Encoder & " + SHELLCMD, vbNormalFocus)

            Dim p As New Process

            With p.StartInfo
                .WindowStyle = ProcessWindowStyle.Normal
                .Arguments = " /c title Infinity Media Encoder & " + SHELLCMD
                .FileName = "cmd"

                .UseShellExecute = False
                .RedirectStandardOutput = False
                .CreateNoWindow = False


            End With

            p.Start()

            If CHKDEBUG.Checked Then
                BOXDEBUG.Text = SHELLCMD
            End If
            realtimeenc = ""
            FORCEEXTENSION = ""
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

    Private Sub BTNYUVEXTRACT_Click(sender As System.Object, e As System.EventArgs) Handles BTNYUVEXTRACT.Click
        INPUTVIDNAME = InputCBOX.Text
        If CHKAVISYNTH.Checked = True Then
            FFMPEGEXE = """" + STARTUPPATH + "\Tools\ffmpeg32\ffmpeg.exe" + """"
            'ElseIf INPUTVIDNAME.Contains("-f dshow") Then
            'FFMPEGEXE = """" + STARTUPPATH + "\Tools\ffmpeg32\ffmpeg.exe " + """"
        ElseIf BOXFFMPEGEXE.Text = "64bit FFmpeg" Then
            FFMPEGEXE = """" + STARTUPPATH + "\Tools\ffmpeg64\ffmpeg.exe" + """"
        ElseIf BOXFFMPEGEXE.Text = "32bit FFmpeg" Then
            FFMPEGEXE = """" + STARTUPPATH + "\Tools\ffmpeg32\ffmpeg.exe" + """"
        Else
            FFMPEGEXE = """" + BOXFFMPEGEXE.Text + """"
        End If



        If InputCBOX.Text.Contains("-f dshow") Or InputCBOX.Text.Contains("//") Then

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
            MsgBox("Not yet avaliable. preparing advanced options.", MsgBoxStyle.Information, "Infinity Media Encoder")
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
            If PRESETLOADING = False Then
                BITBOX.Text = "Auto"
            End If


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
            If PRESETLOADING = False Then
                BITBOX.Text = "200"
            End If

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
            If PRESETLOADING = False Then
                BITBOX.Text = "Auto"
            End If


        ElseIf BOXBITRATEMODE.Text = "VBR" Then
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
            If PRESETLOADING = False Then
                BITBOX.Text = "Auto"
            End If


        ElseIf BOXBITRATEMODE.Text = "CVBR" Then
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
            If PRESETLOADING = False Then
                BITBOX.Text = "Auto"
            End If


        ElseIf BOXBITRATEMODE.Text = "CRF(CQP)" Then
            LBBPS.Text = ""
            LBBITRATE.Text = "CRF"
            LBBPS2.Text = ""
            BITBOX2.Enabled = True
            BITBOX2.Visible = True
            LBBPS.Text = "Bitrate"
            LBBPS2.Text = "Kbps"
            BITBOX.Items.Clear()
            BITBOX.Items.Add("Auto")
            BITBOX.Items.Add("63")
            BITBOX.Items.Add("60")
            BITBOX.Items.Add("59")
            BITBOX.Items.Add("58")
            BITBOX.Items.Add("57")
            BITBOX.Items.Add("56")
            BITBOX.Items.Add("55")
            BITBOX.Items.Add("54")
            BITBOX.Items.Add("53")
            BITBOX.Items.Add("52")
            BITBOX.Items.Add("51")
            BITBOX.Items.Add("50")
            BITBOX.Items.Add("49")
            BITBOX.Items.Add("48")
            BITBOX.Items.Add("47")
            BITBOX.Items.Add("46")
            BITBOX.Items.Add("45")
            BITBOX.Items.Add("43")
            BITBOX.Items.Add("40")
            BITBOX.Items.Add("38")
            BITBOX.Items.Add("35")
            BITBOX.Items.Add("32")
            BITBOX.Items.Add("30")
            BITBOX.Items.Add("25")
            BITBOX.Items.Add("20")
            BITBOX.Items.Add("10")
            BITBOX.Items.Add("5")
            BITBOX.Items.Add("0")
            If PRESETLOADING = False Then
                BITBOX.Text = "Auto"
            End If


            BITBOX2.Items.Clear()
            BITBOX2.Items.Add("Auto")
            BITBOX2.Items.Add("500")
            BITBOX2.Items.Add("1000")
            BITBOX2.Items.Add("1500")
            BITBOX2.Items.Add("2000")
            BITBOX2.Items.Add("2500")
            BITBOX2.Items.Add("3000")
            BITBOX2.Items.Add("6000")
            BITBOX2.Items.Add("8000")
            BITBOX2.Items.Add("11000")
            BITBOX2.Items.Add("12000")
            If PRESETLOADING = False Then
                BITBOX2.Text = "Auto"
            End If


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
            If PRESETLOADING = False Then
                BITBOX.Text = "Auto"
                'BITBOX2.Text = "Auto"
            End If

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
            If PRESETLOADING = False Then
                BITBOX.Text = "Auto"
            End If

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
            INPUTVIDNAME = "-rtbufsize 2000M -f dshow -i video=" + """" + FRMDSHOW.BOXDSHOWVID.Text + """"
            INPUTAUDFILENAME = " -f dshow -i audio=" + """" + FRMDSHOW.BOXDSHOWAUD.Text + """" + " -pix_fmt " + FRMDSHOW.BOXPIXELFORMAT.Text
            InputCBOX.Text = " " + INPUTVIDNAME + INPUTAUDFILENAME
            INPUTVIDNAME = ""
            INPUTAUDFILENAME = ""
            BTNINPUT.Text = "Settings"
        Else
            InputCBOX.Text = ""
            INPUTVIDNAME = ""
            BTNINPUT.Text = "Input"

        End If
    End Sub

    Public Function Bitrateparam()
        BITMODE = ""
        BITVAL = ""
        CBRVAL = ""
        If BITBOX.Text = "Auto" AndAlso Not BOXBITRATEMODE.Text = "CRF" AndAlso Not BOXBITRATEMODE.Text = "CRF(CQP)" Then
            BITVAL = ""
            CBRVAL = ""
        Else
            If BOXBITRATEMODE.Text = "CBR" Or BOXBITRATEMODE.Text = "ABR" Or BOXBITRATEMODE.Text = "2pass-ABR" Then
                BITVAL = " -b:v " + BITBOX.Text + "k"
            ElseIf BOXBITRATEMODE.Text = "CRF" Then
                BITVAL = " -crf " + BITBOX.Text
            ElseIf BOXBITRATEMODE.Text = "VBR" AndAlso BOXCODEC.Text = "libsvtav1" Then
                BITMODE = " -rc vbr "
                BITVAL = " -b " + BITBOX.Text + "K "
            ElseIf BOXBITRATEMODE.Text = "CVBR" AndAlso BOXCODEC.Text = "libsvtav1" Then
                BITMODE = " -rc cvbr "
                BITVAL = " -b " + BITBOX.Text + "K "
            ElseIf BOXBITRATEMODE.Text = "CRF(CQP)" AndAlso BOXCODEC.Text = "libsvtav1" Then
                CBRVAL = ""
                BITMODE = " -rc cqp "
                If BITBOX.Text = "Auto" Then
                    BITVAL = ""
                Else
                    BITVAL = " -qp " + BITBOX.Text
                End If

                If BITBOX2.Text = "" Or BITBOX2.Text = "Auto" Then
                    CBRVAL = ""
                Else
                    CBRVAL = " -b " + BITBOX2.Text + "K "

                End If
            End If

            If BOXBITRATEMODE.Text = "CBR" And Not BITBOX.Text = "" AndAlso Not BOXCODEC.Text = "libsvtav1" Then
                CBRVAL = " -bufsize:v " + BITBOX.Text + "k " + " -maxrate:v " + BITBOX.Text + "k " + "-minrate:v " + BITBOX.Text + "k "
            ElseIf BOXBITRATEMODE.Text = "CRF" Then
                CBRVAL = ""
            ElseIf BOXBITRATEMODE.Text = "CRF-MaxBitrate" Then
                BITVAL = " -crf " + BITBOX.Text
                If Not BITBOX2.Text = "" And Not BITBOX2.Text = "Auto" Then
                    CBRVAL = " -bufsize:v " + BITBOX2.Text + "k " + "-maxrate:v " + BITBOX2.Text + "k "
                End If

            ElseIf BOXBITRATEMODE.Text = "File Size" Then
                If CHKTRIM.Checked Then
                    sDate = BOXTRIMSS.Text
                    'hours = Trim(Split(sDate, ":")(0))
                    'minutes = Trim(Split(sDate, ":")(1))
                    'seconds = Trim(Split(sDate, ":")(2))
                    'dblStringToDblSS = CLng(hours) * 3600 + CLng(minutes) * 60 + CLng(seconds)
                    dblStringToDblSS = TimeSpan.Parse(BOXTRIMSS.Text).TotalSeconds
                    sDate = BOXTRIMTO.Text
                    'hours = Trim(Split(sDate, ":")(0))
                    'minutes = Trim(Split(sDate, ":")(1))
                    'seconds = Trim(Split(sDate, ":")(2))
                    'dblStringToDblTO = CLng(hours) * 3600 + CLng(minutes) * 60 + CLng(seconds)
                    dblStringToDblTO = TimeSpan.Parse(BOXTRIMTO.Text).TotalSeconds


                    dblStringToDblRESULT = dblStringToDblTO - dblStringToDblSS
                    Dim TRIMDURATION As Integer = CInt(Int(dblStringToDblRESULT))
                    Dim VIDEOBITRATESIZE As Integer
                    Dim DURSECRESULT3 As Integer
                    'DURSECRESULT3 = Microsoft.VisualBasic.Left(BOXDURATION2.Text, BOXDURATION2.Text.Length - 3)
                    DURSECRESULT3 = BOXDURATION2.Text
                    VIDEOBITRATESIZE = (BITBOX.Text * 8192 / (TRIMDURATION * 1000)) * 1024
                    BITVAL = " -b:v " + VIDEOBITRATESIZE.ToString + "k" + " -bufsize:v " + VIDEOBITRATESIZE.ToString + "k"

                Else
                    Dim VIDEOBITRATESIZE As Integer
                    Dim DURSECRESULT3 As Integer
                    'DURSECRESULT3 = Microsoft.VisualBasic.Left(BOXDURATION2.Text, BOXDURATION2.Text.Length - 3)
                    DURSECRESULT3 = BOXDURATION2.Text
                    VIDEOBITRATESIZE = BITBOX.Text / DURSECRESULT3 * 8192 * 1024

                    BITVAL = " -b:v " + VIDEOBITRATESIZE.ToString + "k" + " -bufsize:v " + VIDEOBITRATESIZE.ToString + "k"
                End If
            Else
                'CBRVAL = " -bufsize:v " + BITBOX.Text + "k " + "-maxrate:v " + BITBOX.Text + "k " + "-minrate:v " + BITBOX.Text + "k "
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

        If BOXCODEC.Text = "copy" Then

            BITVAL = ""
            CBRVAL = ""
        End If

        If BOXACODEC.Text = "copy" Then

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



    Private Sub BTNABOUT_Click_1(sender As Object, e As EventArgs) Handles BTNABOUT.Click
        About.ShowDialog()
    End Sub
    Public Function GETYTQUALITY() As String()
        Invoke(DirectCast(Sub()

                              'Dim qualityinfo As String
                              BOXDEBUG.Text = " /c title Infinity Media Encoder & " + "" + YOUTUBEDLPATH + "" + " --list-formats " + LBYTADDRESS.Text
                              Dim p As New Process
                              Dim outputReader2 As StreamReader
                              With p.StartInfo
                                  .WindowStyle = ProcessWindowStyle.Minimized
                                  .Arguments = " /c title Infinity Media Encoder & " + "" + YOUTUBEDLPATH + "" + " --list-formats " + LBYTADDRESS.Text
                                  .FileName = "cmd"

                                  .UseShellExecute = False
                                  .RedirectStandardOutput = True
                                  .RedirectStandardError = True
                                  .CreateNoWindow = True


                              End With

                              p.Start()
                              outputReader2 = p.StandardOutput
                              Dim output2 As String


                              While outputReader2.EndOfStream = False
                                  output2 = outputReader2.ReadToEnd()
                                  qualityinfo = output2
                                  YTPARSINGINFO.Text = output2
                                  Application.DoEvents()
                              End While

                              outputReader2.Close()


                          End Sub, MethodInvoker))
    End Function
    Public Function SwitchYTQuality()



        If Not qualityinfo = "" Then
            Invoke(DirectCast(Sub()
                                  YTDNFORMAT.Enabled = True
                                  RB8K.Checked = False
                                  RB8KHDR.Checked = False
                                  RB8K60F.Checked = False
                                  RB8K60FHDR.Checked = False
                                  RB5K.Checked = False
                                  RB5KHDR.Checked = False
                                  RB5K60F.Checked = False
                                  RB5K60FHDR.Checked = False
                                  RB4K60FHDR.Checked = False
                                  RB4K60F.Checked = False
                                  RB4KHDR.Checked = False
                                  RB4K.Checked = False
                                  RB2K.Enabled = False
                                  RB2K60F.Checked = False
                                  RB1080P60F.Checked = False
                                  RB1080P.Checked = False
                                  RB720P.Checked = False
                                  RB720P60F.Checked = False
                                  RB480P.Checked = False
                                  RB360P.Checked = False
                                  RBAUDONLY.Checked = False

                                  RB8K.Enabled = False
                                  RB8KHDR.Enabled = False
                                  RB8K60F.Enabled = False
                                  RB8K60FHDR.Enabled = False
                                  RB5K.Enabled = False
                                  RB5KHDR.Enabled = False
                                  RB5K60F.Enabled = False
                                  RB5K60FHDR.Enabled = False
                                  RB4K60FHDR.Enabled = False
                                  RB4K60F.Enabled = False
                                  RB4KHDR.Enabled = False
                                  RB4K.Enabled = False
                                  RB2K.Enabled = False
                                  RB2K60F.Enabled = False
                                  RB1080P60F.Enabled = False
                                  RB1080P.Enabled = False
                                  RB720P.Enabled = False
                                  RB720P60F.Enabled = False
                                  RB480P.Enabled = False
                                  RB360P.Enabled = False
                                  RBAUDONLY.Enabled = False


                                  If YTPARSINGINFO.Text.Contains("m3u8 information") Then
                                      YTDNFORMAT.Enabled = False
                                      Dim newName As String = Path.ChangeExtension(BOXYTFILENAME.Text, "ts")
                                      BOXYTFILENAME.Text = newName

                                  End If

                                  If LBYTADDRESS.Text.Contains("youtube") Or LBYTADDRESS.Text.Contains("youtu.be") Then
                                      If qualityinfo.Contains("4320p") Then
                                          If qualityinfo.Contains("4320p60, mp4_dash") AndAlso qualityinfo.Contains("571 mp4") Then

                                              If YTDNFORMAT.Text = "mp4" Then
                                                  RB8K60F.Enabled = True
                                                  RB8K60F.Text = "8K (2160p) 60fps | AV01"
                                              End If
                                          End If
                                          If qualityinfo.Contains("4320p60 HDR, mp4_dash") AndAlso qualityinfo.Contains("702 mp4") Then

                                              If YTDNFORMAT.Text = "mp4" Then
                                                  RB8K60FHDR.Enabled = True
                                                  RB8K60FHDR.Text = "8K (2160p) 60fps HDR | AV01"
                                              End If
                                          End If


                                          If qualityinfo.Contains("4320p, mp4_dash") AndAlso qualityinfo.Contains("571 mp4") Then

                                              If YTDNFORMAT.Text = "mp4" Then
                                                  RB8K.Enabled = True
                                                  RB8K.Text = "8K (2160p) | AV01"
                                              End If
                                          End If
                                          If qualityinfo.Contains("4320p HDR, mp4_dash") AndAlso qualityinfo.Contains("702 mp4") Then

                                              If YTDNFORMAT.Text = "mp4" Then
                                                  RB8KHDR.Enabled = True
                                                  RB8KHDR.Text = "8K (2160p) HDR | AV01"
                                              End If
                                          End If



                                          If qualityinfo.Contains("4320p60, webm_dash") AndAlso qualityinfo.Contains("272 webm") Then

                                              If YTDNFORMAT.Text = "mkv" Then
                                                  RB8K60F.Enabled = True
                                                  RB8K60F.Text = "8K (2160p) 60fps | VP9"
                                              End If
                                          End If


                                          If qualityinfo.Contains("4320p, webm_dash") AndAlso qualityinfo.Contains("272 webm") Then

                                              If YTDNFORMAT.Text = "mkv" Then
                                                  RB8K.Enabled = True
                                                  RB8K.Text = "8K (2160p) | VP9"
                                              End If
                                          End If

                                      Else

                                          RB8K.Enabled = False
                                          RB8K60F.Enabled = False
                                          RB8K60FHDR.Enabled = False
                                      End If

                                      If qualityinfo.Contains("2160p") Then
                                          If qualityinfo.Contains("2160p60, mp4_dash") AndAlso qualityinfo.Contains("401 mp4") Then

                                              If YTDNFORMAT.Text = "mp4" Then
                                                  RB4K60F.Enabled = True
                                                  RB4K60F.Text = "4K (2160p) 60fps | AV01"
                                              End If
                                          End If

                                          If qualityinfo.Contains("2160p60 HDR, mp4_dash") AndAlso qualityinfo.Contains("701 mp4") Then

                                              If YTDNFORMAT.Text = "mp4" Then
                                                  RB4K60FHDR.Enabled = True
                                                  RB4K60FHDR.Text = "4K (2160p) 60fps HDR | AV01"
                                              End If
                                          End If


                                          If qualityinfo.Contains("2160p, mp4_dash") AndAlso qualityinfo.Contains("401 mp4") Then

                                              If YTDNFORMAT.Text = "mp4" Then
                                                  RB4K.Enabled = True
                                                  RB4K.Text = "4K (2160p) | AV01"
                                              End If
                                          End If

                                          If qualityinfo.Contains("2160p HDR, mp4_dash") AndAlso qualityinfo.Contains("701 mp4") Then

                                              If YTDNFORMAT.Text = "mp4" Then
                                                  RB4KHDR.Enabled = True
                                                  RB4KHDR.Text = "4K (2160p) HDR | AV01"
                                              End If

                                          End If



                                          If qualityinfo.Contains("2160p60, webm_dash") AndAlso qualityinfo.Contains("315 webm") Then

                                              If YTDNFORMAT.Text = "mkv" Then
                                                  RB4K60F.Enabled = True
                                                  RB4K60F.Text = "4K (2160p) 60fps | VP9"
                                              End If
                                          End If

                                          If qualityinfo.Contains("2160p60 HDR, webm_dash") AndAlso qualityinfo.Contains("337 webm") Then

                                              If YTDNFORMAT.Text = "mkv" Then
                                                  RB4K60FHDR.Enabled = True
                                                  RB4K60FHDR.Text = "4K (2160p) 60fps HDR | VP9"
                                              End If
                                          End If

                                          If qualityinfo.Contains("2160p, webm_dash") AndAlso qualityinfo.Contains("313 webm") Then

                                              If YTDNFORMAT.Text = "mkv" Then
                                                  RB4K.Enabled = True
                                                  RB4K.Text = "4K (2160p) | VP9"
                                              End If
                                          End If

                                          If qualityinfo.Contains("2160p HDR, webm_dash") AndAlso qualityinfo.Contains("337 webm") Then

                                              If YTDNFORMAT.Text = "mkv" Then
                                                  RB4KHDR.Enabled = True
                                                  RB4KHDR.Text = "4K (2160p) HDR | VP9"
                                              End If
                                          End If

                                      Else

                                          RB4K.Enabled = False
                                          RB4K60F.Enabled = False
                                          RB4K60FHDR.Enabled = False

                                      End If

                                      If qualityinfo.Contains("1080p") Or qualityinfo.Contains("1920x1080") Then
                                          If qualityinfo.Contains("1080p60, mp4_dash") AndAlso qualityinfo.Contains("299 mp4") Then

                                              If YTDNFORMAT.Text = "mp4" Then
                                                  RB1080P60F.Enabled = True
                                                  RB1080P60F.Text = "1080p 60fps | H.264"
                                              End If
                                          End If


                                          If qualityinfo.Contains("1080p, mp4_dash") AndAlso qualityinfo.Contains("137 mp4") Then

                                              If YTDNFORMAT.Text = "mp4" Then
                                                  RB1080P.Enabled = True
                                                  RB1080P.Text = "1080p | H.264"
                                              End If
                                          End If

                                          If qualityinfo.Contains("137      mp4   1") Then

                                              If YTDNFORMAT.Text = "mp4" Then
                                                  RB1080P.Enabled = True
                                                  RB1080P.Text = "1080p | H.264"
                                              End If
                                          End If



                                          If qualityinfo.Contains("1080p60, webm_dash") AndAlso qualityinfo.Contains("303 webm") Then

                                              If YTDNFORMAT.Text = "mkv" Then
                                                  RB1080P60F.Enabled = True
                                                  RB1080P60F.Text = "1080p 60fps | VP9"
                                              End If
                                          End If

                                          If qualityinfo.Contains("1080p, webm_dash") AndAlso qualityinfo.Contains("248 webm") Then

                                              If YTDNFORMAT.Text = "mkv" Then
                                                  RB1080P.Enabled = True
                                                  RB1080P.Text = "1080p | VP9"
                                              End If
                                          End If

                                          If qualityinfo.Contains("1080p, webm_dash") AndAlso qualityinfo.Contains("313 webm  1") Then

                                              If YTDNFORMAT.Text = "mkv" Then
                                                  RB1080P.Enabled = True
                                                  RB1080P.Text = "1080p | VP9"
                                              End If
                                          End If

                                          If qualityinfo.Contains("248      webm") Then

                                              If YTDNFORMAT.Text = "mkv" Then
                                                  RB1080P.Enabled = True
                                                  RB1080P.Text = "1080p | VP9"
                                              End If
                                          End If


                                      Else

                                          RB1080P.Enabled = False
                                          RB1080P60F.Enabled = False


                                      End If

                                      If qualityinfo.Contains("720p") Or qualityinfo.Contains("1280x720") Then
                                          If qualityinfo.Contains("720p60, mp4_dash") AndAlso qualityinfo.Contains("298 mp4") Then

                                              If YTDNFORMAT.Text = "mp4" Then
                                                  RB720P60F.Enabled = True
                                                  RB720P60F.Text = "720p 60fps | H.264"
                                              End If
                                          End If


                                          If qualityinfo.Contains("720p, mp4_dash") AndAlso qualityinfo.Contains("22  mp4") Then

                                              If YTDNFORMAT.Text = "mp4" Then
                                                  RB720P.Enabled = True
                                                  RB720P.Text = "720p | H.264"
                                              End If
                                          End If
                                          If qualityinfo.Contains("22       mp4") Then

                                              If YTDNFORMAT.Text = "mp4" Then
                                                  RB720P.Enabled = True
                                                  RB720P.Text = "720p | H.264"
                                              End If
                                          End If



                                          If qualityinfo.Contains("720p60, webm_dash") AndAlso qualityinfo.Contains("302 webm") Then

                                              If YTDNFORMAT.Text = "mkv" Then
                                                  RB720P60F.Enabled = True
                                                  RB720P60F.Text = "720p 60fps | VP9"
                                              End If
                                          End If

                                          If qualityinfo.Contains("720p, webm_dash") AndAlso qualityinfo.Contains("247 webm") Then

                                              If YTDNFORMAT.Text = "mkv" Then
                                                  RB720P.Enabled = True
                                                  RB720P.Text = "720p | VP9"
                                              End If
                                          End If

                                          If qualityinfo.Contains("720p, webm_dash") AndAlso qualityinfo.Contains("271 webm  8") Or qualityinfo.Contains("271 webm  7") Then

                                              If YTDNFORMAT.Text = "mkv" Then
                                                  RB720P.Enabled = True
                                                  RB720P.Text = "720p | VP9"
                                              End If
                                          End If

                                          If qualityinfo.Contains("247      webm  1") Then

                                              If YTDNFORMAT.Text = "mkv" Then
                                                  RB720P.Enabled = True
                                                  RB720P.Text = "720p | VP9"
                                              End If
                                          End If


                                      Else

                                          RB720P.Enabled = False
                                          RB720P60F.Enabled = False


                                      End If

                                      If qualityinfo.Contains("480p") Or qualityinfo.Contains("854x480") Then


                                          If qualityinfo.Contains("480p, mp4_dash") AndAlso qualityinfo.Contains("135 mp4   8") Then

                                              If YTDNFORMAT.Text = "mp4" Then
                                                  RB480P.Enabled = True
                                                  RB480P.Text = "480p | H.264"
                                              End If
                                          End If
                                          If qualityinfo.Contains("135      mp4") Then

                                              If YTDNFORMAT.Text = "mp4" Then
                                                  RB480P.Enabled = True
                                                  RB480P.Text = "480p | H.264"
                                              End If
                                          End If
                                          If qualityinfo.Contains("137 mp4   6") Or qualityinfo.Contains("137 mp4   5") Then

                                              If YTDNFORMAT.Text = "mp4" Then
                                                  RB480P.Enabled = True
                                                  RB480P.Text = "480p | H.264"
                                              End If
                                          End If


                                          If qualityinfo.Contains("480p, webm_dash") AndAlso qualityinfo.Contains("244 webm") Then

                                              If YTDNFORMAT.Text = "mkv" Then
                                                  RB480P.Enabled = True
                                                  RB480P.Text = "480p | VP9"
                                              End If
                                          End If

                                          If qualityinfo.Contains("480p, webm_dash") AndAlso qualityinfo.Contains("248 webm  5") Or qualityinfo.Contains("248 webm  6") Then

                                              If YTDNFORMAT.Text = "mkv" Then
                                                  RB480P.Enabled = True
                                                  RB480P.Text = "480p | VP9"
                                              End If
                                          End If

                                          If qualityinfo.Contains("244      webm  8") Then

                                              If YTDNFORMAT.Text = "mkv" Then
                                                  RB480P.Enabled = True
                                                  RB480P.Text = "480p | VP9"
                                              End If
                                          End If


                                      Else

                                          RB480P.Enabled = False


                                      End If

                                      If YTDNFORMAT.Text = "m4a" Or YTDNFORMAT.Text = "aac" Or YTDNFORMAT.Text = "opus" Then
                                          RBAUDONLY.Enabled = True
                                          RBAUDONLY.Checked = True
                                      Else
                                          RBAUDONLY.Enabled = False
                                      End If

                                      If YTPARSINGINFO.Text.Contains("m3u8 information") Then
                                          If qualityinfo.Contains("94  mp4") Or qualityinfo.Contains("94 mp4") Then
                                              RB480P.Enabled = True
                                              RB480P.Text = "480p | H.264"
                                          End If

                                          If qualityinfo.Contains("95  mp4") Or qualityinfo.Contains("95 mp4") Then
                                              RB720P.Enabled = True
                                              RB720P.Text = "720p | H.264"
                                          End If

                                          If qualityinfo.Contains("96  mp4") Or qualityinfo.Contains("96 mp4") Then
                                              RB1080P.Enabled = True
                                              RB1080P.Text = "1080p | H.264"
                                          End If

                                      End If
                                  End If
                              End Sub, MethodInvoker))
        End If


    End Function
    Public Function DownloadYT() As String()
        STARTUPPATH = Application.StartupPath()
        FFMPEGEXE = """" + BOXFFMPEGEXE.Text + """"


        YOUTUBEDLPATH = """" + STARTUPPATH + "\Tools\yt-dlp\yt-dlp.exe" + """"

        If RB4K.Checked Then
            If YTDNFORMAT.Text = "mp4" Then

                YOUTUBEQ = "401"
                YOUTUBEAUDQ = "258/140"

            ElseIf YTDNFORMAT.Text = "mkv" Then
                YOUTUBEQ = "315/313"
                YOUTUBEAUDQ = "251"
            End If
        ElseIf RB4KHDR.Checked Then
            If YTDNFORMAT.Text = "mp4" Then

                YOUTUBEQ = "701"
                YOUTUBEAUDQ = "258/140"

            ElseIf YTDNFORMAT.Text = "mkv" Then
                YOUTUBEQ = "337"
                YOUTUBEAUDQ = "251"
            End If

        ElseIf RB4K60F.Checked Then
            If YTDNFORMAT.Text = "mp4" Then

                YOUTUBEQ = "401"
                YOUTUBEAUDQ = "258/140"

            ElseIf YTDNFORMAT.Text = "mkv" Then
                YOUTUBEQ = "315"
                YOUTUBEAUDQ = "251"
            End If

        ElseIf RB4K60FHDR.Checked Then
            If YTDNFORMAT.Text = "mp4" Then

                YOUTUBEQ = "701"
                YOUTUBEAUDQ = "258/140"

            ElseIf YTDNFORMAT.Text = "mkv" Then
                YOUTUBEQ = "337"
                YOUTUBEAUDQ = "251"
            End If


        ElseIf RB8K.Checked Then
            If YTDNFORMAT.Text = "mp4" Then

                YOUTUBEQ = "571"
                YOUTUBEAUDQ = "258/140"

            ElseIf YTDNFORMAT.Text = "mkv" Then
                YOUTUBEQ = "571"
                YOUTUBEAUDQ = "251"
            End If

        ElseIf RB8KHDR.Checked Then
            If YTDNFORMAT.Text = "mp4" Then

                YOUTUBEQ = "702"
                YOUTUBEAUDQ = "258/140"
            End If

        ElseIf RB8K60F.Checked Then
            If YTDNFORMAT.Text = "mp4" Then

                YOUTUBEQ = "571"
                YOUTUBEAUDQ = "258/140"

            ElseIf YTDNFORMAT.Text = "mkv" Then
                YOUTUBEQ = "272"
                YOUTUBEAUDQ = "251"
            End If

        ElseIf RB8K60FHDR.Checked Then
            If YTDNFORMAT.Text = "mp4" Then
                YOUTUBEQ = "702"
                YOUTUBEAUDQ = "258/140"
            End If

        ElseIf RB2K.Checked Then
            If YTDNFORMAT.Text = "mp4" Then

                YOUTUBEQ = "264 "


            ElseIf YTDNFORMAT.Text = "mkv" Then
                YOUTUBEQ = "271 "
            End If
        ElseIf RB2K60F.Checked Then
            If YTDNFORMAT.Text = "mp4" Then

                YOUTUBEQ = "308 "


            ElseIf YTDNFORMAT.Text = "mkv" Then
                YOUTUBEQ = "308 "
            End If

        ElseIf RB1080P.Checked Then
            If YTDNFORMAT.Text = "mp4" Then
                YOUTUBEQ = "137/96"
                YOUTUBEAUDQ = "258/140"
            ElseIf YTDNFORMAT.Text = "mkv" Then
                YOUTUBEQ = "248/313"
                YOUTUBEAUDQ = "251"
            End If

        ElseIf RB1080P60F.Checked Then
            If YTDNFORMAT.Text = "mp4" Then
                YOUTUBEQ = "299"
                YOUTUBEAUDQ = "258/140"
            ElseIf YTDNFORMAT.Text = "mkv" Then
                YOUTUBEQ = "303"
                YOUTUBEAUDQ = "251"
            End If

        ElseIf RB720P.Checked Then
            If YTDNFORMAT.Text = "mp4" Then
                YOUTUBEQ = "22/95/136 "
                YOUTUBEAUDQ = "258/140"
            ElseIf YTDNFORMAT.Text = "mkv" Then
                YOUTUBEQ = "247/271 "
                YOUTUBEAUDQ = "251"
            End If
        ElseIf RB720P60F.Checked Then
            If YTDNFORMAT.Text = "mp4" Then
                YOUTUBEQ = "298 "
                YOUTUBEAUDQ = "258/140"
            ElseIf YTDNFORMAT.Text = "mkv" Then
                YOUTUBEQ = "302 "
                YOUTUBEAUDQ = "251"
            End If


        ElseIf RB480P.Checked Then
            If YTDNFORMAT.Text = "mp4" Then
                If qualityinfo.Contains("137 mp4   6") Or qualityinfo.Contains("137 mp4   5") Then
                    YOUTUBEQ = "137/135/94"
                    YOUTUBEAUDQ = "258/140"
                Else
                    YOUTUBEQ = "135/94"
                    YOUTUBEAUDQ = "258/140"
                End If

            ElseIf YTDNFORMAT.Text = "mkv" Then
                If qualityinfo.Contains("244      webm  8") Or qualityinfo.Contains("244 webm  8") Then
                    YOUTUBEQ = "244"
                    YOUTUBEAUDQ = "251"
                Else
                    YOUTUBEQ = "248"
                    YOUTUBEAUDQ = "251"
                End If


            End If
        ElseIf RB360P.Checked Then
            If YTDNFORMAT.Text = "mp4" Then
                YOUTUBEQ = "93/134 "

            ElseIf YTDNFORMAT.Text = "mkv" Then
                YOUTUBEQ = "243 "
            End If
        End If

        If YTPARSINGINFO.Text.Contains("m3u8 information") Then
            If RB1080P.Checked = True Then
                YOUTUBEQ = "96"
            ElseIf RB4K.Checked = True Then
                YOUTUBEQ = "313"
            ElseIf RB720P.Checked = True Then
                YOUTUBEQ = "95"
            ElseIf RB480P.Checked = True Then
                YOUTUBEQ = "94"
            ElseIf RB360P.Checked = True Then
                YOUTUBEQ = "93"
            End If
        End If

        If YTDNFORMAT.Text = "m4a" Or YTDNFORMAT.Text = "aac" Then
            YOUTUBEAUDQ = "258/140"
        ElseIf YTDNFORMAT.Text = "opus" Then
            YOUTUBEAUDQ = "251"
        End If

        If BOXCSTVIDQ.Text = "" Then

        Else
            YOUTUBEQ = BOXCSTVIDQ.Text
        End If

        If BOXCSTAUDQ.Text = "" Then

        Else
            YOUTUBEAUDQ = BOXCSTAUDQ.Text
        End If

        YTMAP = " -map 0:v:0 -map 1:a:0 "

        Try
            Dim testFile As System.IO.FileInfo
            testFile = My.Computer.FileSystem.GetFileInfo(BOXYTFILENAME.Text)
            Dim folderPath As String = testFile.DirectoryName
            Dim outfileName As String = testFile.Name
            TEMPYTFILENAME = outfileName
        Catch

        End Try
        Dim YTADDRESS As String = LBYTADDRESS.Text

        If YTDNFORMAT.Text = "m4a" Or YTDNFORMAT.Text = "aac" Or YTDNFORMAT.Text = "opus" Then
            SHELLCMD = YOUTUBEDLPATH + " -f " + YOUTUBEAUDQ + " " + """" + YTADDRESS + """" + " -o - --verbose --prefer-insecure --no-playlist | " + FFMPEGEXE + " -y " + FFLAGS + " -i - -acodec copy -vn " + "-metadata description=" + """" + "Infinity Media Encoder by KGP-Louis" + """" + " " + """" + BOXYTFILENAME.Text + """"
        ElseIf YTPARSINGINFO.Text.Contains("m3u8 information") Then


            If My.Computer.FileSystem.FileExists(BOXYTFILENAME.Text) Then
                Dim OUTPUTFILENAMEONLYHLS As String
                Dim OUTPUTFILENAMEHLS As String

                Dim testFile As System.IO.FileInfo
                testFile = My.Computer.FileSystem.GetFileInfo(BOXYTFILENAME.Text)
                Dim folderPath As String = testFile.DirectoryName
                Dim infileName As String = testFile.Name
                IO.Path.GetFileNameWithoutExtension(infileName)
                OUTPUTFILENAMEONLYHLS = IO.Path.GetFileNameWithoutExtension(BOXYTFILENAME.Text) + "-" + RandomString() + ".ts"
                OUTPUTFILENAMEHLS = folderPath + "\" + OUTPUTFILENAMEONLYHLS
                BOXYTFILENAME.Text = OUTPUTFILENAMEHLS
                'SHELLCMD = YOUTUBEDLPATH + " -v -f " + YOUTUBEQ + " " + """" + YTADDRESS + """" + " --ffmpeg-location " + FFMPEGEXE + " --force-overwrites --output " + """" + OUTPUTFILENAMEHLS + """"
                SHELLCMD = YOUTUBEDLPATH + " -f " + YOUTUBEQ + " " + """" + YTADDRESS + """" + " --ffmpeg-location " + FFMPEGEXE + " -o - --verbose --prefer-insecure --no-playlist --force-overwrites | " + FFMPEGEXE + " -y " + FFLAGS + " -i - -vcodec copy -acodec copy " + """" + OUTPUTFILENAMEHLS + """"
            Else
                Dim OUTPUTFILENAMEHLS As String = Path.ChangeExtension(BOXYTFILENAME.Text, "ts")
                BOXYTFILENAME.Text = OUTPUTFILENAMEHLS
                'SHELLCMD = YOUTUBEDLPATH + " -v -f " + YOUTUBEQ + " " + """" + YTADDRESS + """" + " --ffmpeg-location " + FFMPEGEXE + " --force-overwrites --output " + """" + OUTPUTFILENAMEHLS + """"
                SHELLCMD = YOUTUBEDLPATH + " -f " + YOUTUBEQ + " " + """" + YTADDRESS + """" + " --ffmpeg-location " + FFMPEGEXE + " -o - --verbose --prefer-insecure --no-playlist --force-overwrites | " + FFMPEGEXE + " -y " + FFLAGS + " -i - -vcodec copy -acodec copy " + """" + OUTPUTFILENAMEHLS + """"
            End If

        ElseIf LBYTADDRESS.Text.Contains("youtube") Or LBYTADDRESS.Text.Contains("youtu.be") Then
            SHELLCMD = YOUTUBEDLPATH + " -f " + YOUTUBEQ + " " + """" + YTADDRESS + """" + " -o - --verbose --prefer-insecure --no-playlist | " + FFMPEGEXE + " -y " + FFLAGS + "-i - -vcodec copy" + " -metadata description=" + """" + "Infinity Media Encoder by KGP-Louis" + """" + " " + """" + "temp_" + TEMPYTFILENAME + """" +
        "& " + YOUTUBEDLPATH + " -f " + YOUTUBEAUDQ + " " + """" + YTADDRESS + """" + " -o - --verbose --prefer-insecure --no-playlist | " + FFMPEGEXE + " -y " + FFLAGS + " -i " + """" + "temp_" + TEMPYTFILENAME + """" + " -i - -vcodec copy -acodec copy " + YTMAP + "-metadata description=" + """" + "Infinity Media Encoder by KGP-Louis" + """" + " " + """" + BOXYTFILENAME.Text + """" +
        "& del " + """" + "temp_" + TEMPYTFILENAME + """"
        Else
            SHELLCMD = YOUTUBEDLPATH + " -f " + YOUTUBEQ + " " + """" + YTADDRESS + """" + " -o - --verbose --prefer-insecure --no-playlist | " + FFMPEGEXE + " -y " + FFLAGS + " -i - -vcodec copy -acodec copy " + """" + BOXYTFILENAME.Text + """"
        End If




    End Function
    Public Function COPYONEYTITEM() As String()
        If FRMProgress.BackgroundWorker_1.IsBusy = True Then
        Else
            FRMProgress.ENCODINGLISTVIEW.Items.Clear()
        End If

        Dim filenameinfo As String
        filenameinfo = BOXYTFILENAME.Text
        Dim testFile As System.IO.FileInfo
        testFile = My.Computer.FileSystem.GetFileInfo(filenameinfo)
        Dim ytoutfileName As String = testFile.Name

        Dim add As New ListViewItem(ytoutfileName)

        add.SubItems.Add("")
        add.SubItems.Add(SHELLCMD)
        If CHKTRIM.Checked = True Then
            add.SubItems.Add(BOXTRIMSS.Text)
            add.SubItems.Add(BOXTRIMTO.Text)
            add.SubItems.Add("")
            add.SubItems.Add(BOXYTFILENAME.Text)
        Else
            add.SubItems.Add("0")
            add.SubItems.Add("0")
            add.SubItems.Add("")
            add.SubItems.Add(BOXYTFILENAME.Text)
        End If

        FRMProgress.ENCODINGLISTVIEW.Items.Add(add)
        FRMProgress.ENCODINGLISTVIEW.EndUpdate()
        Windows.Forms.Application.DoEvents()
    End Function

    Private Sub BTPASTEYTADDRESS_Click(sender As Object, e As EventArgs) Handles BTPASTEYTADDRESS.Click
        qualityinfo = ""

        'Dim _thread1 As Thread
        'Invoke(DirectCast(Sub()
        ' End Sub, MethodInvoker))
        BackgroundWorker3.WorkerSupportsCancellation = True
        BackgroundWorker3.WorkerReportsProgress = True
        BackgroundWorker3.RunWorkerAsync()
        'YTGETINFO()
        '_thread1 = New Thread(AddressOf YTGETINFO)
        '_thread1.IsBackground = True
        '_thread1.Start()





    End Sub

    Private Sub BTDNYOUTUBE_Click(sender As Object, e As EventArgs) Handles BTDNYOUTUBE.Click
        Try
            Dim testFile As System.IO.FileInfo
            testFile = My.Computer.FileSystem.GetFileInfo(BOXYTFILENAME.Text)
            Dim folderPath As String = testFile.DirectoryName

            If Not Directory.Exists(folderPath) Then
                Directory.CreateDirectory(folderPath)
            End If
        Catch

        End Try
        If Not BOXYTFILENAME.Text = "" Then

            DownloadYT()

            If CHKDEBUG.Checked Then
                BOXDEBUG.Text = SHELLCMD
            End If

            If CHKMULTIENC.Checked Then
                Shell("cmd /c title Infinity Media Encoder & " + SHELLCMD + " & comp.bat", vbNormalFocus)
            Else
                If FRMProgress.BackgroundWorker_1.IsBusy = True Then
                    Invoke(New Action(Function() COPYONEYTITEM()))
                    MsgBox("Added to Encoding List", MsgBoxStyle.Information, "Infinity Media Encoder")
                    GoTo noencoding
                Else
                    FRMProgress.Close()
                    Invoke(New Action(Function() COPYONEYTITEM()))

                End If

                If RB8K.Checked = False And RB8KHDR.Checked = False And RB8K60F.Checked = False And RB8K60FHDR.Checked = False And RB5K.Checked = False And RB5KHDR.Checked = False And RB5K60F.Checked = False And RB5K60FHDR.Checked = False And RB4K60FHDR.Checked = False And RB4K60F.Checked = False And RB4KHDR.Checked = False And RB4K.Checked = False And RB2K.Enabled = False And RB2K60F.Checked = False And RB1080P60F.Checked = False And RB1080P.Checked = False And RB720P.Checked = False And RB720P60F.Checked = False And RB480P.Checked = False And RB360P.Checked = False And RBAUDONLY.Checked = False Then
                    If BOXCSTVIDQ.Text = "" Or BOXCSTAUDQ.Text = "" Then
                        If LBYTADDRESS.Text.Contains("youtube") Or LBYTADDRESS.Text.Contains("youtu.be") Then
                            MsgBox("Please Select Youtube Quality.", MsgBoxStyle.Critical, "Infinity Media Encoder")
                            GoTo noencoding
                        End If


                    End If
                    Invoke(New Action(Function() COPYONEYTITEM()))

                End If

                FRMProgress.Show()
                FRMProgress.RunProcess()
                FRMProgress.Timer1.Start()
            End If
            initialValue()


        Else

        End If
noencoding:

        initialValue()

    End Sub

    Private Sub YTDNFORMAT_SelectedIndexChanged(sender As Object, e As EventArgs) Handles YTDNFORMAT.SelectedIndexChanged

        Dim originalFile As String = BOXYTFILENAME.Text
        Dim newName As String = Path.ChangeExtension(originalFile, YTDNFORMAT.Text)
        BOXYTFILENAME.Text = newName
        SwitchYTQuality()
    End Sub


    Private Sub BYOPENYTFOLDER_Click(sender As Object, e As EventArgs) Handles BYOPENYTFOLDER.Click
        Try
            If Not BOXYTFILENAME.Text = "" Then
                Dim testFile As System.IO.FileInfo
                testFile = My.Computer.FileSystem.GetFileInfo(BOXYTFILENAME.Text)
                Dim folderPath As String = testFile.DirectoryName

                If My.Computer.FileSystem.FileExists(BOXYTFILENAME.Text) Then
                    Shell("explorer /select, " & Chr(34) & BOXYTFILENAME.Text & Chr(34), vbNormalFocus)
                Else
                    Process.Start(folderPath)
                End If
            Else
                Shell("explorer " + STARTUPPATH + "\My_Youtube_Files", vbNormalFocus)

            End If

        Catch

        End Try




    End Sub

    Private Sub BOXAACPF_SelectedIndexChanged(sender As Object, e As EventArgs) Handles BOXAACPF.SelectedIndexChanged
        If BOXACODEC.Text = "PCM" And BOXAACPF.Text = "pcm_s16le" And BOXAUDBITDEPTH.Text = "Auto" Then
            BOXAUDBITDEPTH.Text = "Auto"
        ElseIf BOXACODEC.Text = "PCM" And BOXAACPF.Text = "pcm_s16le" Then
            BOXAUDBITDEPTH.Text = "16"
        ElseIf BOXACODEC.Text = "PCM" And BOXAACPF.Text = "pcm_u8" Then
            BOXAUDBITDEPTH.Text = "8"
        ElseIf BOXACODEC.Text = "PCM" And BOXAACPF.Text = "pcm_s16le" Then
            BOXAUDBITDEPTH.Text = "16"
        ElseIf BOXACODEC.Text = "PCM" And BOXAACPF.Text = "pcm_s24le" Then
            BOXAUDBITDEPTH.Text = "24"
        ElseIf BOXACODEC.Text = "PCM" And BOXAACPF.Text = "pcm_s32le" Then
            BOXAUDBITDEPTH.Text = "32"
        ElseIf BOXACODEC.Text = "PCM" And BOXAACPF.Text = "pcm_f32le" Then
            BOXAUDBITDEPTH.Text = "32(Float)"

        End If
    End Sub

    Private Sub BOXAUDBITDEPTH_SelectedIndexChanged(sender As Object, e As EventArgs) Handles BOXAUDBITDEPTH.SelectedIndexChanged
        If BOXACODEC.Text = "PCM" And BOXAUDBITDEPTH.Text = "Auto" Then
            BOXAACPF.Text = "pcm_s16le"
        ElseIf BOXACODEC.Text = "PCM" And BOXAUDBITDEPTH.Text = "8" Then
            BOXAACPF.Text = "pcm_u8"
        ElseIf BOXACODEC.Text = "PCM" And BOXAUDBITDEPTH.Text = "16" Then
            BOXAACPF.Text = "pcm_s16le"
        ElseIf BOXACODEC.Text = "PCM" And BOXAUDBITDEPTH.Text = "24" Then
            BOXAACPF.Text = "pcm_s24le"
        ElseIf BOXACODEC.Text = "PCM" And BOXAUDBITDEPTH.Text = "32" Then
            BOXAACPF.Text = "pcm_s32le"
        ElseIf BOXACODEC.Text = "PCM" And BOXAUDBITDEPTH.Text = "32(Float)" Then
            BOXAACPF.Text = "pcm_f32le"

        End If

    End Sub
    Private Sub BTNINPUTPATHYTVID_Click(sender As Object, e As EventArgs) Handles BTNINPUTPATHYTVID.Click
        InputCBOX.Text = BOXYTFILENAME.Text
        Try
            getMediainfo()
            prepareOpen()
        Catch

        End Try
    End Sub


    Private Sub BTNSELECTSTREAM_Click(sender As Object, e As EventArgs) Handles BTNSELECTSTREAM.Click
        FRMMULTISTREAM.ShowDialog()

    End Sub

    Private Sub ENCLISTVIEWMAIN_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ENCLISTVIEWMAIN.SelectedIndexChanged
        If ENCLISTVIEWMAIN.SelectedItems.Count > 1 Then
            BOXCMDINFO.Text = ""

        ElseIf ENCLISTVIEWMAIN.SelectedItems.Count > 0 Then
            Try
                BOXCMDINFO.Text = ENCLISTVIEWMAIN.FocusedItem.SubItems(2).Text
            Catch

            End Try
        Else
            BOXCMDINFO.Text = ""
        End If

    End Sub


    Private Sub BTNTRIMPREV_Click(sender As Object, e As EventArgs) Handles BTNTRIMPREV.Click
        TrimPreviewPlayer.Show()
    End Sub
    Function md5_hash(ByVal file_name As String)

        Return hash_generator("md5", file_name)

    End Function

    Function sha_1(ByVal file_name As String)

        Return hash_generator("sha1", file_name)

    End Function

    Function sha_256(ByVal file_name As String)

        Return hash_generator("sha256", file_name)

    End Function
    Function hash_generator(ByVal hash_type As String, ByVal file_name As String)


        Dim hash
        If hash_type = "md5" Then

            hash = MD5.Create
        ElseIf hash_type = "sha1" Then

            hash = SHA1.Create()
        ElseIf hash_type = "sha256" Then

            hash = SHA256.Create()
        Else
            MsgBox("Unknown hash type : " & hash_type, MsgBoxStyle.Critical)
            Return False
        End If


        Dim hashValue() As Byte


        Dim fileStream As FileStream = File.OpenRead(file_name)

        fileStream.Position = 0

        hashValue = hash.ComputeHash(fileStream)

        Dim hash_hex = PrintByteArray(hashValue)

        fileStream.Close()

        Return hash_hex

    End Function
    Public Function PrintByteArray(ByVal array() As Byte)

        Dim hex_value As String = ""


        Dim i As Integer
        For i = 0 To array.Length - 1

            hex_value += array(i).ToString("X2")

        Next i

        Return hex_value

    End Function


    Private Sub BTNGETHASHFROMFILE_Click(sender As Object, e As EventArgs) Handles BTNGETHASHFROMFILE.Click
        BOXHASH.Text = sha_256(InputCBOX.Text)
    End Sub


    Private Sub BOXHASH_DragDrop(sender As Object, e As DragEventArgs) Handles BOXHASH.DragDrop
        Dim files() As String = e.Data.GetData(DataFormats.FileDrop)
        For Each path In files

            BOXHASH.Text = sha_256(path)
        Next


    End Sub

    Private Sub BOXHASH_DragEnter(sender As Object, e As DragEventArgs) Handles BOXHASH.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    Private Sub BTNCOPYHASH_Click(sender As Object, e As EventArgs) Handles BTNCOPYHASH.Click
        My.Computer.Clipboard.SetText(BOXHASH.Text)
    End Sub

    Private Sub BOXHASH_KeyPress(sender As Object, e As KeyPressEventArgs) Handles BOXHASH.KeyPress
        e.Handled = True
    End Sub

    Private Sub BOXCONTAINER_SelectedIndexChanged(sender As Object, e As EventArgs) Handles BOXCONTAINER.SelectedIndexChanged
        If BOXCONTAINER.Text = "=== Video ===" Then
            BOXCONTAINER.Text = "mp4"
            BTNSTREAMING.Visible = False
        ElseIf BOXCONTAINER.Text = "=== Audio ===" Then
            BOXCONTAINER.Text = "mp3"
            BTNSTREAMING.Visible = False
        ElseIf BOXCONTAINER.Text = "=== HLS Encoding Mode ===" Then
            BTNSTREAMING.Visible = True
        ElseIf BOXCONTAINER.Text = "=== Smooth Encoding Mode ===" Then
            BTNSTREAMING.Visible = True
        ElseIf BOXCONTAINER.Text = "=== RTMP Streaming Mode ===" Then
            BTNSTREAMING.Visible = True

        ElseIf BOXCONTAINER.Text = "=== DASH Encoding Mode ===" Then
            MsgBox("Not yet avaliable", MsgBoxStyle.Information, "Infinity Media Encoder")
            BTNSTREAMING.Visible = True
        Else
            BTNSTREAMING.Visible = False

        End If
    End Sub

    Private Sub BTNSTREAMING_Click(sender As Object, e As EventArgs) Handles BTNSTREAMING.Click
        TAB.SelectTab(5)
        If BOXCONTAINER.Text = "=== HLS Encoding Mode ===" Then
            TAB.SelectTab(5)
            TABSTREAMSET.SelectTab(0)
        ElseIf BOXCONTAINER.Text = "=== Smooth Encoding Mode ===" Then
            TAB.SelectTab(5)
            TABSTREAMSET.SelectTab(2)
        ElseIf BOXCONTAINER.Text = "=== RTMP Streaming Mode ===" Then
            TAB.SelectTab(5)
            TABSTREAMSET.SelectTab(1)
        ElseIf BOXCONTAINER.Text = "=== DASH Encoding Mode ===" Then
            MsgBox("Not yet avaliable", MsgBoxStyle.Information, "Infinity Media Encoder")
            TAB.SelectTab(5)
            TABSTREAMSET.SelectTab(3)
        End If

    End Sub

    Private Sub BTNADDVFILTER_Click(sender As Object, e As EventArgs) Handles BTNADDVFILTER.Click
        Dim FTINDEX As Integer
        FTINDEX = 0
        Dim ItemsCount As Integer
        Dim VFILTERPARAM As String
        Dim VFILTER As String
        Dim VFILTERCOMP As String

        Dim add As New ListViewItem(BOXVFILTERNAME.Text)
        add.SubItems.Add(BOXVFILTERPARAM.Text)
        LISTVFILTER.Items.Add(add)
        ItemsCount = LISTVFILTER.Items.Count

        VFILTERCOMP = VFILTER & VFILTERPARAM

        Do Until FTINDEX = ItemsCount
            If FTINDEX = 0 Then
                VFILTER = LISTVFILTER.Items(FTINDEX).Text + "="
                VFILTERPARAM = LISTVFILTER.Items(FTINDEX).SubItems(1).Text
                VFILTERCOMP = VFILTERCOMP & VFILTER & VFILTERPARAM
            Else
                VFILTER = "," + LISTVFILTER.Items(FTINDEX).Text + "="
                VFILTERPARAM = LISTVFILTER.Items(FTINDEX).SubItems(1).Text
                VFILTERCOMP = VFILTERCOMP & VFILTER & VFILTERPARAM
            End If


            FTINDEX = FTINDEX + 1
        Loop





        BOXVFILTER.Text = VFILTERCOMP

        If Not LISTVFILTER.Items.Count = 0 Then
            LISTVFILTER.Items(LISTVFILTER.Items.Count - 1).Selected = True

        End If

    End Sub

    Private Sub LISTVFILTER_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LISTVFILTER.SelectedIndexChanged
        Try
            BOXVFILTERNAME.Text = LISTVFILTER.FocusedItem.SubItems(0).Text
            BOXVFILTERPARAM.Text = LISTVFILTER.FocusedItem.SubItems(1).Text
        Catch

        End Try

    End Sub


    Private Sub BTNEDITVFILTER_Click(sender As Object, e As EventArgs) Handles BTNEDITVFILTER.Click
        Dim FTINDEX As Integer
        FTINDEX = 0

        Dim ItemsCount As Integer
        Dim FIRSTVFILTERPARAM As String
        Dim VFILTERPARAM As String
        Dim VFILTER As String
        Dim VFILTERCOMP As String
        Try
            If Not BOXVFILTERNAME.Text = "" And Not BOXVFILTERPARAM.Text = "" Then
                Me.LISTVFILTER.SelectedItems(0).SubItems().Item(0).Text = BOXVFILTERNAME.Text
                Me.LISTVFILTER.SelectedItems(0).SubItems().Item(1).Text = BOXVFILTERPARAM.Text
            End If
            ItemsCount = LISTVFILTER.Items.Count
            VFILTERCOMP = VFILTER & VFILTERPARAM
            Do Until FTINDEX = ItemsCount
                If FTINDEX = 0 Then
                    VFILTER = LISTVFILTER.Items(FTINDEX).Text + "="
                    VFILTERPARAM = LISTVFILTER.Items(FTINDEX).SubItems(1).Text
                    VFILTERCOMP = VFILTERCOMP & VFILTER & VFILTERPARAM
                Else
                    VFILTER = "," + LISTVFILTER.Items(FTINDEX).Text + "="
                    VFILTERPARAM = LISTVFILTER.Items(FTINDEX).SubItems(1).Text
                    VFILTERCOMP = VFILTERCOMP & VFILTER & VFILTERPARAM
                End If


                FTINDEX = FTINDEX + 1
            Loop

            BOXVFILTER.Text = VFILTERCOMP
        Catch

        End Try


    End Sub

    Private Sub BTNRMVFILTER_Click(sender As Object, e As EventArgs) Handles BTNRMVFILTER.Click
        Dim FTINDEX As Integer
        FTINDEX = 0
        Dim ItemsCount As Integer
        Dim VFILTERPARAM As String
        Dim VFILTER As String
        Dim VFILTERCOMP As String
        Try
            LISTVFILTER.SelectedItems(0).Remove()
        Catch

        End Try


        ItemsCount = LISTVFILTER.Items.Count

        VFILTERCOMP = VFILTER & VFILTERPARAM

        Do Until FTINDEX = ItemsCount
            If FTINDEX = 0 Then
                VFILTER = LISTVFILTER.Items(FTINDEX).Text + "="
                VFILTERPARAM = LISTVFILTER.Items(FTINDEX).SubItems(1).Text
                VFILTERCOMP = VFILTERCOMP & VFILTER & VFILTERPARAM
            Else
                VFILTER = "," + LISTVFILTER.Items(FTINDEX).Text + "="
                VFILTERPARAM = LISTVFILTER.Items(FTINDEX).SubItems(1).Text
                VFILTERCOMP = VFILTERCOMP & VFILTER & VFILTERPARAM
            End If


            FTINDEX = FTINDEX + 1
        Loop


        BOXVFILTER.Text = VFILTERCOMP
        If Not LISTVFILTER.Items.Count = 0 Then
            LISTVFILTER.Items(0).Selected = True

        End If

    End Sub

    Private Sub BTNADDAFILTER_Click(sender As Object, e As EventArgs) Handles BTNADDAFILTER.Click
        Dim FTINDEX As Integer
        FTINDEX = 0
        Dim ItemsCount As Integer
        Dim AFILTERPARAM As String
        Dim AFILTER As String
        Dim AFILTERCOMP As String

        Dim add As New ListViewItem(BOXAFILTERNAME.Text)
        add.SubItems.Add(BOXAFILTERPARAM.Text)
        LISTAFILTER.Items.Add(add)
        ItemsCount = LISTAFILTER.Items.Count

        AFILTERCOMP = AFILTER & AFILTERPARAM

        Do Until FTINDEX = ItemsCount
            If FTINDEX = 0 Then
                AFILTER = LISTAFILTER.Items(FTINDEX).Text + "="
                AFILTERPARAM = LISTAFILTER.Items(FTINDEX).SubItems(1).Text
                AFILTERCOMP = AFILTERCOMP & AFILTER & AFILTERPARAM
            Else
                AFILTER = "," + LISTAFILTER.Items(FTINDEX).Text + "="
                AFILTERPARAM = LISTAFILTER.Items(FTINDEX).SubItems(1).Text
                AFILTERCOMP = AFILTERCOMP & AFILTER & AFILTERPARAM
            End If


            FTINDEX = FTINDEX + 1
        Loop


        BOXAFILTER.Text = AFILTERCOMP
        If Not LISTAFILTER.Items.Count = 0 Then
            LISTAFILTER.Items(LISTAFILTER.Items.Count - 1).Selected = True

        End If

    End Sub

    Private Sub BTNRMAFILTER_Click(sender As Object, e As EventArgs) Handles BTNRMAFILTER.Click
        Dim FTINDEX As Integer
        FTINDEX = 0
        Dim ItemsCount As Integer
        Dim AFILTERPARAM As String
        Dim AFILTER As String
        Dim AFILTERCOMP As String
        Try
            LISTAFILTER.SelectedItems(0).Remove()
        Catch

        End Try


        ItemsCount = LISTAFILTER.Items.Count

        AFILTERCOMP = AFILTER & AFILTERPARAM

        Do Until FTINDEX = ItemsCount
            If FTINDEX = 0 Then
                AFILTER = LISTAFILTER.Items(FTINDEX).Text + "="
                AFILTERPARAM = LISTAFILTER.Items(FTINDEX).SubItems(1).Text
                AFILTERCOMP = AFILTERCOMP & AFILTER & AFILTERPARAM
            Else
                AFILTER = "," + LISTAFILTER.Items(FTINDEX).Text + "="
                AFILTERPARAM = LISTAFILTER.Items(FTINDEX).SubItems(1).Text
                AFILTERCOMP = AFILTERCOMP & AFILTER & AFILTERPARAM
            End If


            FTINDEX = FTINDEX + 1
        Loop

        BOXAFILTER.Text = AFILTERCOMP
        If Not LISTAFILTER.Items.Count = 0 Then
            LISTAFILTER.Items(0).Selected = True

        End If
    End Sub

    Private Sub BTNEDITAFILTER_Click(sender As Object, e As EventArgs) Handles BTNEDITAFILTER.Click
        Dim FTINDEX As Integer
        FTINDEX = 0

        Dim ItemsCount As Integer
        Dim FIRSTAFILTERPARAM As String
        Dim AFILTERPARAM As String
        Dim AFILTER As String
        Dim AFILTERCOMP As String
        Try
            If Not BOXAFILTERNAME.Text = "" And Not BOXAFILTERPARAM.Text = "" Then
                Me.LISTAFILTER.SelectedItems(0).SubItems().Item(0).Text = BOXAFILTERNAME.Text
                Me.LISTAFILTER.SelectedItems(0).SubItems().Item(1).Text = BOXAFILTERPARAM.Text
            End If
            ItemsCount = LISTAFILTER.Items.Count
            AFILTERCOMP = AFILTER & AFILTERPARAM

            Do Until FTINDEX = ItemsCount
                If FTINDEX = 0 Then
                    AFILTER = LISTAFILTER.Items(FTINDEX).Text + "="
                    AFILTERPARAM = LISTAFILTER.Items(FTINDEX).SubItems(1).Text
                    AFILTERCOMP = AFILTERCOMP & AFILTER & AFILTERPARAM
                Else
                    AFILTER = "," + LISTAFILTER.Items(FTINDEX).Text + "="
                    AFILTERPARAM = LISTAFILTER.Items(FTINDEX).SubItems(1).Text
                    AFILTERCOMP = AFILTERCOMP & AFILTER & AFILTERPARAM
                End If


                FTINDEX = FTINDEX + 1
            Loop

            BOXAFILTER.Text = AFILTERCOMP
        Catch

        End Try
    End Sub


    Private Sub BTNFNGR_Click(sender As Object, e As EventArgs) Handles BTNFNGR.Click
        FileNameGen()
        FileNameGen_Rename()
    End Sub
    Public Function FileNameGen()

        Dim testFile As System.IO.FileInfo
        testFile = My.Computer.FileSystem.GetFileInfo(InputCBOX.Text)
        Dim folderPath As String = testFile.DirectoryName
        tempinputfileName = IO.Path.GetFileNameWithoutExtension(InputCBOX.Text)
        Dim ext As String = System.IO.Path.GetExtension(InputCBOX.Text)
        Dim vcodecinfo As String
        Dim acodecinfo As String
        Dim refinfo As String
        Dim pfinfo As String
        Dim fpsinfo As String
        Dim audchinfo As String
        Dim rsinfo As String
        Dim audbitdepthinfo As String
        Dim audsamplinginfo As String
        Dim audbitrateinfo As String


        If BOXCODECINFO.Text = "AVC" Then
            vcodecinfo = "H.264(AVC)"
        ElseIf BOXCODECINFO.Text = "V_MPEG4/ISO/AVC" Then
            vcodecinfo = "H.264(AVC)"
        ElseIf BOXCODECINFO.Text = "V_MPEGH/ISO/HEVC" Then
            vcodecinfo = "H.265(HEVC)"
        ElseIf BOXCODECINFO.Text = "V_MPEG4/ISO/ASP" Then
            vcodecinfo = "DivX"
        ElseIf BOXCODECINFO.Text = "HEVC" Then
            vcodecinfo = "H.265(HEVC)"
        ElseIf BOXCODECINFO.Text = "" Then
            vcodecinfo = ""
        Else
            vcodecinfo = BOXCODECINFO.Text

        End If

        If BOXACODECINFO.Text = "AAC LC" Then
            acodecinfo = "-AAC-LC"
        ElseIf BOXACODECINFO.Text = "AAC LC-SBR" Then
            acodecinfo = "-HE-AACv1"
        ElseIf BOXACODECINFO.Text = "AAC LC-SBR-PS" Then
            acodecinfo = "-HE-AACv2"
        ElseIf BOXACODECINFO.Text = "AAC Main" Then
            acodecinfo = "-AAC-Main"
        ElseIf BOXACODECINFO.Text = "MPA1L3" Then
            acodecinfo = "-MP3"
        ElseIf BOXACODECINFO.Text = "samr" Then
            acodecinfo = "-AMRNB"
        ElseIf BOXACODECINFO.Text = "sawb" Then
            acodecinfo = "-AMRWB"
        ElseIf BOXACODECINFO.Text = "161" Then
            acodecinfo = "-WMVv2"
        ElseIf BOXACODECINFO.Text = "" Then
            acodecinfo = ""
        Else
            acodecinfo = "-" + BOXACODECINFO.Text

        End If
        If BOXRSINFO.Text = "x" Then
            rsinfo = ""
        Else
            rsinfo = "_" + BOXRSINFO.Text
        End If
        If BOXREFINFO.Text = "" Then
            refinfo = ""
        Else
            refinfo = "_Ref" + BOXREFINFO.Text
        End If

        If BOXPFINFO.Text = "" Then
            pfinfo = ""
        Else
            pfinfo = "_" + BOXPFINFO.Text
        End If


        If BOXFPSINFO.Text = "" Then
            fpsinfo = ""
        Else
            fpsinfo = "_" + BOXFPSINFO.Text + "fps"

        End If

        If BOXAUDCHINFO.Text = "" Then
            audchinfo = ""
        Else
            If Not BOXACODECINFO.Text = "AAC LC-SBR" And Not BOXACODECINFO.Text = "AAC LC-SBR-PS" Then
                audchinfo = "_" + BOXAUDCHINFO.Text + "ch"
            End If

        End If

        If BOXAUDBITDEPTH.Text = "Auto" Then
            audbitdepthinfo = ""
        Else
            audbitdepthinfo = "_" + BOXAUDBITDEPTH.Text
        End If

        If BOXSAMPLERINFO.Text = "" Then

            audsamplinginfo = ""
        Else
            If Not BOXACODECINFO.Text = "AAC LC-SBR" And Not BOXACODECINFO.Text = "AAC LC-SBR-PS" Then
                audsamplinginfo = "_" + Replace(BOXSAMPLERINFO.Text, " ", "")
            End If

        End If

        If BOXAUDBITRATEINFO.Text = "" Then
            audbitrateinfo = ""
        Else
            If BOXCODECINFO.Text = "" Then
                audbitrateinfo = "_" + BOXAUDBITRATEINFO.Text + "Kbps"
            Else
                audbitrateinfo = ""
            End If

        End If
        TEMPFILENAME = vcodecinfo + pfinfo + refinfo + rsinfo + fpsinfo + acodecinfo + audsamplinginfo + audbitrateinfo + audchinfo + audbitdepthinfo + ext

    End Function
    Public Function FileNameGen_Rename()
        If CHKINFOFILENAME.Checked = True Then
            My.Computer.FileSystem.RenameFile(InputCBOX.Text, TEMPFILENAME)
        Else
            My.Computer.FileSystem.RenameFile(InputCBOX.Text, tempinputfileName + "-" + TEMPFILENAME)
        End If

        tempinputfileName = ""
        TEMPFILENAME = ""
    End Function

    Private Sub BTNUPDATEYTDL_Click(sender As Object, e As EventArgs) Handles BTNUPDATEYTDL.Click
        Shell("cmd /c title Infinity Media Encoder & " + """" + STARTUPPATH + "\Tools\yt-dlp\yt-dlp.exe" + """" + " -U & pause", vbNormalFocus)
    End Sub

    Private Sub BTMERGEMEDIA_Click(sender As Object, e As EventArgs) Handles BTMERGEMEDIA.Click
        FRMMERGEMEDIA.Show()

    End Sub

    Private Sub BackgroundWorker3_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker3.DoWork
        YTWaitScreen.Show()
        Application.DoEvents()
        YTGETINFO()
        SwitchYTQuality()
        YTWaitScreen.Close()



    End Sub
    Private Sub backgroundWorker3_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker3.RunWorkerCompleted

    End Sub



    Private Sub BTRTMPMULTI_Click(sender As Object, e As EventArgs) Handles BTRTMPMULTI.Click
        FRMMULTIRTMP.Show()

    End Sub

    Private Sub BackgroundWorker4_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker4.DoWork


    End Sub

    Public Function YTGETINFO()
        Invoke(DirectCast(Sub()
                              Dim ytaddress As String
                              LBYTSTREAM.Text = ""
                              ytaddress = ""
                              BOXCSTVIDQ.Text = ""
                              BOXCSTAUDQ.Text = ""
                              STARTUPPATH = Application.StartupPath()
                              YOUTUBEDLPATH = """" + STARTUPPATH + "\Tools\yt-dlp\yt-dlp.exe" + """"
                              ytaddress = Clipboard.GetText()
                              If ytaddress.Contains("youtube.com") Or ytaddress.Contains("youtu.be") Then
                                  LBYTADDRESS.Text = ytaddress
                              Else
                                  If ytaddress.Contains("http://") Or ytaddress.Contains("https://") Then
                                      LBYTADDRESS.Text = ytaddress
                                  Else
                                      ytaddress = ""
                                      LBYTADDRESS.Text = ""
                                  End If

                              End If
                              Application.DoEvents()

                              'OutputCBox.Text = ""
                              'OUTPUTFILENAME = ""
                              Dim p As New Process
                              Dim outputReader As StreamReader
                              With p.StartInfo
                                  .WindowStyle = ProcessWindowStyle.Minimized
                                  .Arguments = " /c title Infinity Media Encoder & " + "" + YOUTUBEDLPATH + "" + " --get-filename " + LBYTADDRESS.Text
                                  .FileName = "cmd"

                                  .UseShellExecute = False
                                  .RedirectStandardOutput = True
                                  .CreateNoWindow = True


                              End With

                              p.Start()
                              outputReader = p.StandardOutput
                              Dim output As String
                              output = outputReader.ReadLine()

                              Dim originalFile As String = output
                              Dim newName As String = Path.ChangeExtension(originalFile, YTDNFORMAT.Text)
                              BOXYTFILENAME.Text = STARTUPPATH + "\My_Youtube_Files\" + newName
                              Application.DoEvents()
                              outputReader.Close()

                              'Threading.Thread.Sleep(300)

                              If BOXYTFILENAME.Text = "" Then
                                  MsgBox("Failed to get Youtube video title", MsgBoxStyle.Critical, "Infinity Media Encoder")
                                  If osver.ToString.Contains("5.1") Or osver.ToString.Contains("5.0") Then
                                      MsgBox("Do not support Youtube Download on Windows XP/2000/NT", MsgBoxStyle.Critical)
                                  End If
                              End If
                              Try
                                  GETYTQUALITY()

                              Catch

                              End Try

                          End Sub, MethodInvoker))
    End Function

    Public Function getFFPath(e)
        Dim files() As String = e.Data.GetData(DataFormats.FileDrop)
        For Each path In files
            BOXFFMPEGEXE.Text = path
        Next

    End Function

    Private Sub BOXFFMPEGEXE_DragDrop(sender As Object, e As DragEventArgs) Handles BOXFFMPEGEXE.DragDrop
        getFFPath(e)
    End Sub

    Private Sub BOXPRESETFILENAME_SelectedIndexChanged(sender As Object, e As EventArgs) Handles BOXPRESETFILENAME.SelectedIndexChanged

    End Sub

    Private Sub BTDEFAULTFFMP_Click(sender As Object, e As EventArgs) Handles BTDEFAULTFFMP.Click
        STARTUPPATH = Application.StartupPath()
        If Environment.Is64BitOperatingSystem = True Then
            'BOXFFMPEGEXE.Text = "64bit FFmpeg"
            BOXFFMPEGEXE.Text = STARTUPPATH + "\Tools\ffmpeg64\ffmpeg.exe"

        ElseIf Environment.Is64BitOperatingSystem = False Then
            'BOXFFMPEGEXE.Text = "32bit FFmpeg"
            BOXFFMPEGEXE.Text = STARTUPPATH + "\Tools\ffmpeg32\ffmpeg.exe "

        End If
    End Sub


    Private Sub BOXFFMPEGEXE_DragEnter(sender As Object, e As DragEventArgs) Handles BOXFFMPEGEXE.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub


    Private Sub BITBOX_MouseHover(sender As Object, e As EventArgs) Handles BITBOX.MouseHover
        If BOXCODEC.Text = "libsvtav1" Then
            Dim buttonToolTip As New ToolTip()

            buttonToolTip.ToolTipTitle = "CRF (CQP)"

            buttonToolTip.UseFading = True

            buttonToolTip.UseAnimation = True

            buttonToolTip.IsBalloon = True

            buttonToolTip.ShowAlways = True

            buttonToolTip.AutoPopDelay = 5000

            buttonToolTip.InitialDelay = 800

            buttonToolTip.ReshowDelay = 500

            buttonToolTip.IsBalloon = True
            buttonToolTip.SetToolTip(BITBOX, "Affect to bitrate and quality." + vbCrLf + "Recommand :53 ")
        End If

    End Sub

    Private Sub BOXCODECPRESET_MouseHover(sender As Object, e As EventArgs) Handles BOXCODECPRESET.MouseHover
        If BOXCODEC.Text = "libsvtav1" Then
            Dim buttonToolTip As New ToolTip()

            buttonToolTip.ToolTipTitle = "Preset"

            buttonToolTip.UseFading = True

            buttonToolTip.UseAnimation = True

            buttonToolTip.IsBalloon = True

            buttonToolTip.ShowAlways = True

            buttonToolTip.AutoPopDelay = 5000

            buttonToolTip.InitialDelay = 800

            buttonToolTip.ReshowDelay = 500

            buttonToolTip.IsBalloon = True
            buttonToolTip.SetToolTip(BOXCODECPRESET, "Affect to encoding speed and quality." + vbCrLf + "Recommand(speed/quality balanced) :7 ")
        End If
    End Sub

    Private Sub Label36_Click(sender As Object, e As EventArgs) Handles Label36.Click

    End Sub
    Private Sub YTDNFORMAT_TextChanged(sender As Object, e As EventArgs) Handles YTDNFORMAT.TextChanged

    End Sub

    Private Sub YTPARSINGINFO_MouseDown(sender As Object, e As MouseEventArgs) Handles YTPARSINGINFO.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Right Then

            Clipboard.SetText(YTPARSINGINFO.SelectedText)

        End If
    End Sub
End Class
<Serializable()>
Public Class ListViewTextCollection
    Inherits System.Collections.ObjectModel.Collection(Of String())
End Class
