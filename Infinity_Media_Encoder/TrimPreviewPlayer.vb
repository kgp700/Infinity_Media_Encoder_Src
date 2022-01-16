Imports System.IO
Imports System.Threading
Imports System.Runtime.CompilerServices


Public Class TrimPreviewPlayer
    Delegate Sub ChangeTextsSafe(ByVal percent As String)
    Private MPLAYERPATH As String
    Private FFMPEGPATH As String
    Private p As New Process
    Dim args, time_length, time_pos, buffer, CDP As String
    Dim posh, tdr, pauseseek As Long
    Public outputReader As StreamReader
    Private isWMV3 As String
    Private dragingtrackbar As Boolean = False
    Private iSecond As Double
    Private Interlaced As String
    Private deInterlace As String
    Private demoThread As Thread = Nothing


    Private STARTTIME As Double

    Private Sub TrimPreviewPlayer_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Try
            If p.HasExited = False Then
                p.Kill()
            End If
            Timer1.Stop()
        Catch

        End Try
        StopVideo()

    End Sub


    Private Sub TrimPreviewPlayer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Invalidate()
        SetStyle(ControlStyles.DoubleBuffer Or ControlStyles.AllPaintingInWmPaint Or ControlStyles.ResizeRedraw, True)
        MPLAYERPATH = """" + Application.StartupPath + "\Tools\mplayer\mplayer.exe" + """"


        With p.StartInfo

            .FileName = MPLAYERPATH
            .ErrorDialog = False
            .UseShellExecute = False
            .RedirectStandardOutput = True
            .RedirectStandardInput = True
            .CreateNoWindow = True


        End With

        'BackgroundWorker1.RunWorkerAsync()
        p.Start()
    End Sub
    Public Sub SendCommand(ByVal cmd As String)
        Try
            If p IsNot Nothing AndAlso p.HasExited = False Then
                p.StandardInput.Write(cmd & vbLf)
            End If
        Catch
        End Try
    End Sub
    Public Sub StartPlay()
        LISTLOG.Items.Clear()
        If BackgroundWorker1.IsBusy = False Then
            BackgroundWorker1.RunWorkerAsync()
        Else

        End If
        Initiallize()
        Interlaced = Main.BOXINTERLACE.Text
        If Interlaced = "MBAFF" Or Interlaced = "Interlaced" Then
            deInterlace = " -vf kerndeint=1 "
        End If
        If Main.BOXCODECINFO.Text = "WMV3" Then
            args = "-lavdopts threads=16 -slave -noquiet -identify -cache 65535 -volume 100 -demuxer asf -nosub -noass -noautosub -vo gl -speed 1 -ao dsound -delay 0 -osdlevel 0 -wid " & CInt(VideoScreen.Handle)
        ElseIf Main.BOXFORMATINFO.Text = "MPEG-TS" Then
            args = "-lavdopts threads=16 -slave -noquiet -identify -cache 65535  -volume 100 -demuxer lavf -autosync 30 -framedrop -nosub -noass -noautosub -vo gl_tiled " + deInterlace + "-speed 1 -ao dsound -osdlevel 0 -wid " & CInt(VideoScreen.Handle)
        Else

            args = "-lavdopts threads=16 -slave -noquiet -identify -cache 65535 -volume 100 -demuxer lavf -autosync 30 -framedrop -nosub -noass -noautosub -vo gl_tiled -speed 1 -ao dsound -osdlevel 0 -wid " & CInt(VideoScreen.Handle)
        End If

        With p.StartInfo

            .Arguments = " " + args + " " + """" + Main.InputCBOX.Text + """"

        End With
        posh = 1
        tdr = 1

        p.Start()

        Timer1.Start()
        'SendCommand("frame_drop 0")
    End Sub
    Public Function StopVideo() As String()
        Try
            p.Kill()
        Catch

        End Try

        Timer1.Stop()

        posh = 0
        Initiallize()
        BackgroundWorker1.CancelAsync()
    End Function
    Public Function Initiallize() As String()
        'LISTLOG.Items.Clear()

        pauseseek = "0"
        time_length = ""
        time_pos = ""
        BTNPLAYPREV.Text = "Play"
        Timer1.Stop()
        TrackBar1.Value = 0
        Label1.Text = "00:00:00"
        Label2.Text = "00:00:00"
    End Function
    Private Sub BTNPLAYPREV_Click(sender As Object, e As EventArgs) Handles BTNPLAYPREV.Click


        Me.Refresh()
        Try
            If p.HasExited = True Then
                StartPlay()
            Else

            End If
        Catch

        End Try

        If BTNPLAYPREV.Text = "Pause" Then
            posh = 0
            BTNPLAYPREV.Text = "Play"
            Timer1.Stop()
            SendCommand("pause")
        Else
            posh = 1
            BTNPLAYPREV.Text = "Pause"
            SendCommand("pause")
            Timer1.Start()
        End If



    End Sub
    Private Sub BTNPREVSTOP_Click(sender As Object, e As EventArgs) Handles BTNPREVSTOP.Click
        StopVideo()

        BTNPLAYPREV.Text = "Play"

    End Sub
    Public Sub ConvertTimeHHMMSS(ByVal timeInSeconds As Double, ByVal strx As Long)
        Dim timeInSeconds2 As Double

        Try
            If timeInSeconds >= 0.0 Then
                iSecond = timeInSeconds
                Dim iSpan As TimeSpan = TimeSpan.FromSeconds(iSecond)
                If strx = 1 Then
                    'time_length = iSpan.Hours.ToString.PadLeft(2, "0"c) & ":" & iSpan.Minutes.ToString.PadLeft(2, "0"c) & ":" & iSpan.Seconds.ToString.PadLeft(2, "0"c)

                    Dim ts As TimeSpan = TimeSpan.FromSeconds(iSecond)
                    Dim mydate As DateTime = New DateTime(ts.Ticks)
                    time_length = mydate.ToString(("HH:mm:ss"))
                    TrackBar1.Maximum = timeInSeconds
                    tdr = 0




                Else

                    Dim ts As TimeSpan = TimeSpan.FromSeconds(iSecond)
                    'Dim mydate As DateTime = New DateTime(ts.Ticks)
                    If Not STARTTIME = 0.0 Then

                        'time_pos = STARTTIME - time_pos
                        time_pos = iSpan.Hours.ToString.PadLeft(2, "0"c) & ":" & iSpan.Minutes.ToString.PadLeft(2, "0"c) & ":" & iSpan.Seconds.ToString.PadLeft(2, "0"c)
                        'time_pos = mydate.ToString(("HH:mm:ss"))
                        timeInSeconds2 = timeInSeconds - STARTTIME
                        If dragingtrackbar = True Then
                            ' TrackBar1.Value = TrackBar1.Value - 1
                        Else
                            TrackBar1.Value = timeInSeconds2
                        End If

                    Else
                        time_pos = iSpan.Hours.ToString.PadLeft(2, "0"c) & ":" & iSpan.Minutes.ToString.PadLeft(2, "0"c) & ":" & iSpan.Seconds.ToString.PadLeft(2, "0"c)
                        'time_pos = mydate.ToString(("HH:mm:ss"))
                        If dragingtrackbar = True Then
                            'TrackBar1.Value = TrackBar1.Value - 1
                        Else
                            TrackBar1.Value = timeInSeconds
                        End If

                    End If


                End If

                If Not STARTTIME = 0.0 Then
                    Dim iSpan2 As TimeSpan = TimeSpan.FromSeconds(timeInSeconds2)
                    time_pos = iSpan2.Hours.ToString.PadLeft(2, "0"c) & ":" & iSpan2.Minutes.ToString.PadLeft(2, "0"c) & ":" & iSpan2.Seconds.ToString.PadLeft(2, "0"c)

                    Label1.Text = time_pos
                Else
                    Label1.Text = time_pos
                End If



                Label2.Text = time_length
            End If
        Catch
        End Try
    End Sub
    Public Sub ChangeTexts(ByVal per As String)
        Try
            If posh = 1 Then
                If per.Contains("ANS_LENGTH") Then
                    ConvertTimeHHMMSS(per.Replace("ANS_LENGTH=", ""), 1)
                Else
                    ConvertTimeHHMMSS(per.Replace("ANS_TIME_POSITION=", ""), 0)

                End If
                If per.Contains("ID_START_TIME=") Then
                    ConvertTimeHHMMSS(per.Replace("ID_START_TIME=", ""), 0)
                End If
            End If
        Catch
        End Try
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If tdr = 1 Then
            SendCommand("get_time_length")
        Else
            SendCommand("get_time_pos")
            'SendCommand("get_property time_pos")
        End If
    End Sub


    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

        Dim safedelegate As New ChangeTextsSafe(AddressOf ChangeTexts)
        Do
            System.Threading.Thread.Sleep(1)


            Try
                If pauseseek = 1 Then
                    Dim sLine As String = p.StandardOutput.ReadLine
                    If sLine.Contains("ANS_LENGTH") Then
                        Dim str = sLine.Substring(sLine.IndexOf("ANS_LENGTH"))
                        Me.Invoke(safedelegate, str)

                    End If
                    If sLine.Contains("ANS_TIME_POSITION") Then
                        Dim str = sLine.Substring(sLine.IndexOf("ANS_TIME_POSITION"))
                        Me.Invoke(safedelegate, str)

                    End If



                    If sLine.Contains("ID_START_TIME=") Then
                        Dim str = sLine.Substring(sLine.IndexOf("ID_START_TIME="))
                        STARTTIME = str.Replace("ID_START_TIME=", "")



                    End If

                    If sLine.Contains("A:") Then
                        Dim str = sLine.Substring(sLine.IndexOf("A:"))
                        Dim StringSplit As String = str.Substring(0, str.IndexOf(" "))
                        Dim StringSplit2 As String = StringSplit.Replace("A:", "")
                        Me.Invoke(safedelegate, StringSplit2)
                    End If


                    Invoke(New Action(Function() LISTLOG.Items.Add(sLine)))

                    'Me.LISTLOG.SelectedIndex = Me.LISTLOG.SelectedIndex + 1

                ElseIf posh = 1 Then
                    Dim sLine As String = p.StandardOutput.ReadLine
                    If sLine.Contains("ANS_LENGTH") Then
                        Dim str = sLine.Substring(sLine.IndexOf("ANS_LENGTH"))
                        Me.Invoke(safedelegate, str)

                    End If
                    If sLine.Contains("ANS_TIME_POSITION") Then
                        Dim str = sLine.Substring(sLine.IndexOf("ANS_TIME_POSITION"))
                        Me.Invoke(safedelegate, str)

                    End If



                    If sLine.Contains("ID_START_TIME=") Then
                        Dim str = sLine.Substring(sLine.IndexOf("ID_START_TIME="))
                        STARTTIME = str.Replace("ID_START_TIME=", "")



                    End If




                    'Me.LISTLOG.SelectedIndex = Me.LISTLOG.SelectedIndex + 1
                    Try
                        Invoke(New Action(Function() LISTLOG.Items.Add(sLine)))

                    Catch

                    End Try
                    If sLine.Contains("Exiting... (End of file)") Then
                        Exit Do
                    End If

                Else




                End If





            Catch
            End Try






        Loop






    End Sub


    Private Sub BTNINPUTSTIME_Click(sender As Object, e As EventArgs) Handles BTNINPUTSTIME.Click
        BOXSTARTTIME.Text = Label1.Text

    End Sub

    Private Sub BTNINPUTETIME_Click(sender As Object, e As EventArgs) Handles BTNINPUTETIME.Click
        BOXENDTIME.Text = Label1.Text
    End Sub

    Private Sub BTNOK_Click(sender As Object, e As EventArgs) Handles BTNOK.Click
        If Not BOXSTARTTIME.Text = "" Then
            Main.BOXTRIMSS.Text = BOXSTARTTIME.Text
        End If
        If Not BOXENDTIME.Text = "" Then
            Main.BOXTRIMTO.Text = BOXENDTIME.Text
        End If
        Try
            Timer1.Stop()
            StopVideo()
            'BackgroundWorker1.CancelAsync()
        Catch

        End Try

        Me.Close()


    End Sub

    Private Sub TrackBar1_MouseDown(sender As Object, e As MouseEventArgs) Handles TrackBar1.MouseDown


        If e.Button = Windows.Forms.MouseButtons.Left Then
            Dim dblValue As Double

            dblValue = (Convert.ToDouble(e.X) / Convert.ToDouble(TrackBar1.Width)) * (TrackBar1.Maximum - TrackBar1.Minimum)
            TrackBar1.Value = Convert.ToInt32(dblValue)
            'SendCommand("pausing_keep seek " & TrackBar1.Value & " 2")
            Invoke(New Action(Function() Seekfunction()))


            SendCommand("pausing_keep get_time_pos")

        End If
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        StopVideo()
    End Sub

    Private Sub TrackBar1_MouseUp(sender As Object, e As MouseEventArgs) Handles TrackBar1.MouseUp
        If BackgroundWorker1.IsBusy = True Then
            If e.Button = Windows.Forms.MouseButtons.Left Then
                Dim dblValue As Double

                dblValue = (Convert.ToDouble(e.X) / Convert.ToDouble(TrackBar1.Width)) * (TrackBar1.Maximum - TrackBar1.Minimum)
                TrackBar1.Value = Convert.ToInt32(dblValue)
                Label1.Text = dblValue
            End If

        End If


    End Sub


    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        Try
            'dragingtrackbar = True


            'Label1.Text = TrackBar1.Value


            Invoke(New Action(Function() Seekfunction()))
            'dragingtrackbar = False
            If posh = 0 Then
                Label1.Text = TrackBar1.Value
            Else

            End If

        Catch

        End Try
    End Sub



    Private Sub BTREWIND_MouseDown(sender As Object, e As EventArgs) Handles BTREWIND.MouseDown
        Try
            'dragingtrackbar = True
            Invoke(New Action(Function() Seekminor()))
            'dragingtrackbar = False

        Catch

        End Try
    End Sub

    Private Sub BTFF_MouseDown(sender As Object, e As EventArgs) Handles BTFF.MouseDown
        posh = 1
        pauseseek = 0
        Try
            'dragingtrackbar = True
            Invoke(New Action(Function() Seekplus()))

            ' dragingtrackbar = False

        Catch

        End Try


    End Sub
    Public Function Seekfunction()
        'TrackBar1.Value = TrackBar1.Value
        'SendCommand("seek " & TrackBar1.Value & " 2")
        SendCommand("pausing_keep seek " & TrackBar1.Value & " 2")



    End Function

    Private Sub BackgroundWorker2_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker2.DoWork

    End Sub



    Public Function Seekplus()

        Try
            If posh = 0 Then
                TrackBar1.Value = TrackBar1.Value + 1
                SendCommand("pausing_keep seek " & TrackBar1.Value & " 2")
                Label1.Text = TrackBar1.Value
            Else
                TrackBar1.Value = TrackBar1.Value + 2
                SendCommand("pausing_keep seek " & TrackBar1.Value & " 2")
                Label1.Text = TrackBar1.Value

            End If

        Catch

        End Try

        'SendCommand("seek " & TrackBar1.Value + 1 & " 2")
        'TrackBar1.Value = TrackBar1.Value + 1

    End Function
    Public Function Seekminor()
        'SendCommand("pause")
        Try
            If posh = 0 Then
                TrackBar1.Value = TrackBar1.Value - 1
                SendCommand("pausing_keep seek " & TrackBar1.Value & " 2")
                'Label1.Text = TrackBar1.Value

            Else
                TrackBar1.Value = TrackBar1.Value - 2
                SendCommand("pausing_keep seek " & TrackBar1.Value & " 2")
                Label1.Text = TrackBar1.Value

            End If
        Catch

        End Try



        'TrackBar1.Value = TrackBar1.Value - 1
    End Function
    Public Function framestep()

        SendCommand("pausing_keep frame_step ")

    End Function
    Private Sub BTNSEEKFRAME_Click(sender As Object, e As MouseEventArgs) Handles BTNSEEKFRAME.Click
        VideoScreen.Focus()

        framestep()

        Label1.Text = TrackBar1.Value
    End Sub

    Private Sub TrimPreviewPlayer_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
    End Sub

    Private Sub LISTLOG_MouseWheel(sender As Object, e As MouseEventArgs) Handles LISTLOG.MouseWheel
        LISTLOG.Visible = False
        LISTLOG.Visible = True
    End Sub
End Class