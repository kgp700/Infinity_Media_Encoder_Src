
'Imports System.Diagnostics
Imports System.Dynamic
Imports System.Management
Imports System.Runtime.InteropServices
Imports System.IO
Imports System.ComponentModel
Imports System.Threading


'Imports System.Net.NetworkInformation


Public Class FRMProgress

    Private cpuusage As Integer
    Private networkusage As Integer
    Public p As New Process
    Public FFPARAM As String
    Public outputReader As StreamReader
    Public TRIMTO As String
    Public outdata As String
    Public outdata2 As String
    Public logdata As String
    Public logdata2 As String
    Public VALTRIMTO As Double
    Public VALTRIMSS As Double
    Public LISTINDEX As Integer = 0
    Public ForceStopped As Boolean = False
    Public Stopped As Boolean = False
    Public ENDENCODINGFLAG As Boolean = False
    Private ENCODINGCOUNT As Integer = 1
    Public CURRENTENCODINGCMD As String
    Private RUNCMD As String
    Private MEDIADURATION As String
    Private DURATIONTIME As String
    Private DURATION2 As Integer
    Private VIDEODUR As Double
    Private AUDIODUR As Double
    Private TempDuration As Double
    Private startstreamflag As Boolean = False
    Public TRIMCHK As String
    Public osver As System.OperatingSystem
    Dim CALCDURATION As Double
    Private WithEvents worker As BackgroundWorker
    Public Delegate Sub NextPrimeDelegate()
    Private SW As New Stopwatch
    Private WithEvents Tmr As New System.Windows.Forms.Timer




    Private Sub DoWorkHandler(sender As Object, args As DoWorkEventArgs) Handles worker.DoWork

    End Sub



    Private Sub FRMProgress_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ForceStopped = True

        While BackgroundWorker_1.CancellationPending = False
            Try

                KillProcessAndChildren(p.Id)
                KillProcessAndChildren(p.Id)
            Catch

            End Try
            Try
                BackgroundWorker_1.CancelAsync()
            Catch

            End Try

        End While



        'BackgroundWorker_1.CancelAsync()

        'outputReader.Close()





    End Sub
    Private Sub FRMProgress_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        osver = System.Environment.OSVersion

        Select Case osver.Version.Major
            Case 5
                ' Windows 2000 or XP
            Case 6
                ' Windows Vista
        End Select

        Tmr.Interval = 1000
    End Sub
    Public Function StopProcess()
        Stopped = True
        ForceStopped = False

        If osver.ToString.Contains("6.1") Or osver.ToString.Contains("5.1") Or osver.ToString.Contains("5.0") Or osver.ToString.Contains("6.0") Then
            Try
                KillProcessAndChildren(p.Id)
            Catch ex As Exception

            End Try
            BackgroundWorker_1.CancelAsync()
            'outputReader.DiscardBufferedData()
            'outputReader.Close()
        Else
            If BTNPAUSE.Text = "Resume" Then
                Try
                    ResumeProcess(p.Id)
                Catch

                End Try
            End If


            Try
                AttachConsole(CUInt(p.Id))
                GenerateConsoleCtrlEvent(CTRL_C_EVENT, CUInt(p.Id))
                FreeConsole()
                'BackgroundWorker_1.CancelAsync()
                'outputReader.DiscardBufferedData()
                'outputReader.Close()

            Catch ex As Exception
                'If p.HasExited = False Then
                ForceCloseProcessTree(p.Id)
                'BackgroundWorker_1.CancelAsync()
                'outputReader.DiscardBufferedData()
                'outputReader.Close()
                'End If
            End Try
        End If
        p.WaitForExit(5000)
    End Function
    Private Sub BTNSTOP_Click(sender As Object, e As EventArgs) Handles BTNSTOP.Click


        StopProcess()



    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        cpuusage = PerformanceCounter1.NextValue
        Label3.Text = cpuusage.ToString + "%"
        If InStr(Main.OutputCBox.Text, "//") Then
            Label7.Text = "Network Usage : "
            'networkusage = PerformanceCounter2.NextValue
            'LBNETWORK.Text = networkusage.ToString + "Kbps/s"
        End If





    End Sub

    Public Shared Sub KillProcessAndChildren(pid As Integer)
        Try
            Dim proc As Process = Process.GetProcessById(pid)

            proc.Kill()
            'CloseHandle(pid)
        Catch
        End Try

        Dim searcher As New ManagementObjectSearcher("Select * From Win32_Process Where ParentProcessID=" & Convert.ToString(pid))
        Dim moc As ManagementObjectCollection = searcher.[Get]()
        For Each mo As ManagementObject In moc
            KillProcessAndChildren(Convert.ToInt32(mo("ProcessID")))
        Next


    End Sub

    Public Shared Sub StopProcessTree(pid As Integer)

        Try
            Dim proc As Process = Process.GetProcessById(pid)
            'proc.StandardInput.Write(Command)
            proc.StandardInput.Write("q" & vbLf)


        Catch
        End Try

        Dim searcher As New ManagementObjectSearcher("Select * From Win32_Process Where ParentProcessID=" & Convert.ToString(pid))
        Dim moc As ManagementObjectCollection = searcher.[Get]()
        For Each mo As ManagementObject In moc
            StopProcessTree(Convert.ToInt32(mo("ProcessID")))
        Next
        Dim searcher2 As New ManagementObjectSearcher("Select * From Win32_Process Where ParentProcessID=" & Convert.ToString(pid))
        Dim moc2 As ManagementObjectCollection = searcher2.[Get]()
        For Each mo2 As ManagementObject In moc2
            StopProcessTree(Convert.ToInt32(mo2("ProcessID")))
        Next
        Dim searcher3 As New ManagementObjectSearcher("Select * From Win32_Process Where ParentProcessID=" & Convert.ToString(pid))
        Dim moc3 As ManagementObjectCollection = searcher3.[Get]()
        For Each mo3 As ManagementObject In moc3
            StopProcessTree(Convert.ToInt32(mo3("ProcessID")))
        Next

    End Sub

    Public Shared Sub PauseProcess(pid As Integer)

        Dim searcher As New ManagementObjectSearcher("Select * From Win32_Process Where ParentProcessID=" & Convert.ToString(pid))
        Dim moc As ManagementObjectCollection = searcher.[Get]()
        For Each mo As ManagementObject In moc
            PauseProcess(Convert.ToInt32(mo("ProcessID")))
        Next
        Try
            Dim proc As Process = Process.GetProcessById(pid)

            SuspendProcess(proc)

        Catch generatedExceptionName As ArgumentException
        End Try

    End Sub
    Public Shared Sub ResumeProcess(pid As Integer)

        Dim searcher As New ManagementObjectSearcher("Select * From Win32_Process Where ParentProcessID=" & Convert.ToString(pid))
        Dim moc As ManagementObjectCollection = searcher.[Get]()
        For Each mo As ManagementObject In moc
            ResumeProcess(Convert.ToInt32(mo("ProcessID")))
        Next
        Try
            Dim proc As Process = Process.GetProcessById(pid)

            ResumeProcess(proc)


        Catch generatedExceptionName As ArgumentException
        End Try

    End Sub
    Public Shared Sub TerminateProcess1(pid As Integer)

        Dim searcher As New ManagementObjectSearcher("Select * From Win32_Process Where ParentProcessID=" & Convert.ToString(pid))
        Dim moc As ManagementObjectCollection = searcher.[Get]()
        For Each mo As ManagementObject In moc
            TerminateProcess1(Convert.ToInt32(mo("ProcessID")))
        Next
        Try
            Dim proc As Process = Process.GetProcessById(pid)
            TerminateThreada(proc)

        Catch
        End Try

    End Sub
    Public Shared Sub CloseProcessTree(pid As Integer)


        Try
            Dim proc As Process = Process.GetProcessById(pid)

            TerminateThreada(proc)


        Catch
        End Try
        Dim searcher As New ManagementObjectSearcher("Select * From Win32_Process Where ParentProcessID=" & Convert.ToString(pid))
        Dim moc As ManagementObjectCollection = searcher.[Get]()
        For Each mo As ManagementObject In moc
            CloseProcessTree(Convert.ToInt32(mo("ProcessID")))
        Next

    End Sub

    Public Shared Sub ForceCloseProcessTree(pid As Integer)
        Try
            Dim proc As Process = Process.GetProcessById(pid)
            TerminateThread(pid)


        Catch generatedExceptionName As ArgumentException
        End Try

        Dim searcher As New ManagementObjectSearcher("Select * From Win32_Process Where ParentProcessID=" & Convert.ToString(pid))
        Dim moc As ManagementObjectCollection = searcher.[Get]()
        For Each mo As ManagementObject In moc
            Try
                ForceCloseProcessTree(Convert.ToInt32(mo("ProcessID")))
            Catch ex As Exception

            End Try
        Next
        Dim searcher2 As New ManagementObjectSearcher("Select * From Win32_Process Where ParentProcessID=" & Convert.ToString(pid))
        Dim moc2 As ManagementObjectCollection = searcher2.[Get]()
        For Each mo2 As ManagementObject In moc2
            Try
                ForceCloseProcessTree(Convert.ToInt32(mo2("ProcessID")))
            Catch ex As Exception

            End Try

        Next


    End Sub

    Public Function RunProcess() As String()

        BackgroundWorker_1.WorkerSupportsCancellation = True
        BackgroundWorker_1.WorkerReportsProgress = True
        BackgroundWorker_1.RunWorkerAsync()





    End Function
    Public Function GetCMD() As String()

        RUNCMD = ENCODINGLISTVIEW.Items(LISTINDEX).SubItems(2).Text
        ENCODINGLISTVIEW.Items(LISTINDEX).SubItems(1).Text = "Processing"
        Try
            MEDIADURATION = ENCODINGLISTVIEW.Items(LISTINDEX).SubItems(5).Text
            DURATION2 = Convert.ToInt32(TimeSpan.Parse(ENCODINGLISTVIEW.Items(LISTINDEX).SubItems(5).Text).TotalSeconds)
            DURATIONTIME = ENCODINGLISTVIEW.Items(LISTINDEX).SubItems(5).Text
        Catch

        End Try

        Windows.Forms.Application.DoEvents()
    End Function

    Private Sub BackgroundWorker1_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker_1.DoWork
        Stopped = False
        ForceStopped = False
        Invoke(New Action(Function() GetCMD()))


        With p.StartInfo
            .WindowStyle = ProcessWindowStyle.Minimized

            .Arguments = " /c title Infinity Media Encoder & " + RUNCMD
            .FileName = "cmd"

            .UseShellExecute = False


            .RedirectStandardError = True
            .RedirectStandardInput = True
            If Main.CHKCMDWINDOW.Checked = True Then
                .CreateNoWindow = False
            Else
                .CreateNoWindow = True
            End If

        End With
        p.StartInfo.StandardErrorEncoding = System.Text.Encoding.UTF8
        p.Start()
        SW.Start()
        Tmr.Start()

        'outputReader = p.StandardError

        'Dim output As String

        While p.StandardError.EndOfStream = False

            outdata = p.StandardError.ReadLine()

            Try
                BackgroundWorker_1.ReportProgress(0, outdata)


            Catch

            End Try


        End While



    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker_1.ProgressChanged

        Try
            VALTRIMSS = TimeSpan.Parse(ENCODINGLISTVIEW.Items(LISTINDEX).SubItems(3).Text).TotalSeconds
            VALTRIMTO = TimeSpan.Parse(ENCODINGLISTVIEW.Items(LISTINDEX).SubItems(4).Text).TotalSeconds
            LBELAPSEDTIME.Text = "Elapsed Time : " + SW.Elapsed.ToString("hh\:mm\:ss\.f")
        Catch

        End Try

        Try
            logdata = e.UserState.ToString

            If Not ENCODINGLISTVIEW.Items(0).SubItems(0).Text = "Live Streaming" Then

                If TRIMCHK = "Yes" Then
                    Label1.Visible = False
                    Label2.Visible = False
                    If Not VALTRIMSS = "0" And Not VALTRIMTO = "0" Then
                        Label1.Visible = True
                        Label2.Visible = True
                        Try
                            Dim Line = e.UserState.ToString : Static Durationtr As Double
                            If Line.Contains("Duration:") Then
                                Dim str = Line.Substring(Line.IndexOf(":") + 2)
                                Durationtr = TimeSpan.Parse(str.Remove(str.IndexOf(","))).TotalSeconds
                            ElseIf Line.Contains("time=") Then
                                Dim strtr = Line.Substring(Line.IndexOf(":") - 2)

                                CALCDURATION = VALTRIMTO - VALTRIMSS
                                Dim CALCDUR = CALCDURATION.ToString
                                ProgressBar1.Value = Convert.ToInt32(TimeSpan.Parse(strtr.Remove(strtr.IndexOf("b") - 1)).TotalSeconds / CALCDURATION * 100)
                                Percentage.Text = Convert.ToInt32(TimeSpan.Parse(strtr.Remove(strtr.IndexOf("b") - 1)).TotalSeconds / CALCDURATION * 100).ToString + "%"
                            End If
                        Catch
                        End Try
                    ElseIf Not VALTRIMSS = "0" And VALTRIMTO = "0" And VALTRIMTO = DURATION2 Then
                        Try
                            Dim Line = e.UserState.ToString : Static Durationtaa1 As Double
                            If Line.Contains("Duration:") Then
                                Dim str = Line.Substring(Line.IndexOf(":") + 2)
                                Durationtaa1 = TimeSpan.Parse(str.Remove(str.IndexOf(","))).TotalSeconds
                            ElseIf Line.Contains("time=") Then
                                Dim strtr = Line.Substring(Line.IndexOf(":") - 2)
                                Dim DUR As Integer = DURATION2 - VALTRIMSS


                                ProgressBar1.Value = Convert.ToInt32(TimeSpan.Parse(strtr.Remove(strtr.IndexOf("b") - 1)).TotalSeconds / DUR * 100)
                                Percentage.Text = Convert.ToInt32(TimeSpan.Parse(strtr.Remove(strtr.IndexOf("b") - 1)).TotalSeconds / DUR * 100).ToString + "%"
                            End If
                        Catch
                        End Try
                    ElseIf VALTRIMSS = "0" And Not VALTRIMTO = "0" Then
                        Label1.Visible = True
                        Label2.Visible = True
                        Try
                            Dim Line = e.UserState.ToString : Static Durationtaa As Double
                            If Line.Contains("Duration:") Then
                                Dim str = Line.Substring(Line.IndexOf(":") + 2)
                                Durationtaa = TimeSpan.Parse(str.Remove(str.IndexOf(","))).TotalSeconds
                            ElseIf Line.Contains("time=") Then
                                Dim strtr = Line.Substring(Line.IndexOf(":") - 2)


                                ProgressBar1.Value = Convert.ToInt32(TimeSpan.Parse(strtr.Remove(strtr.IndexOf("b") - 1)).TotalSeconds / VALTRIMTO * 100)
                                Percentage.Text = Convert.ToInt32(TimeSpan.Parse(strtr.Remove(strtr.IndexOf("b") - 1)).TotalSeconds / VALTRIMTO * 100).ToString + "%"
                            End If
                        Catch
                        End Try
                    Else

                        Try
                            Dim Line = e.UserState.ToString : Static Durationtra As Double
                            If Line.Contains("Duration:") Then
                                Dim str = Line.Substring(Line.IndexOf(":") + 2)
                                Durationtra = TimeSpan.Parse(str.Remove(str.IndexOf(","))).TotalSeconds
                            ElseIf Line.Contains("time=") Then
                                Dim str = Line.Substring(Line.IndexOf(":") - 2)

                                ProgressBar1.Value = Convert.ToInt32(TimeSpan.Parse(str.Remove(str.IndexOf("b") - 1)).TotalSeconds / DURATION2 * 100)
                                Percentage.Text = Convert.ToInt32(TimeSpan.Parse(str.Remove(str.IndexOf("b") - 1)).TotalSeconds / DURATION2 * 100).ToString + "%"
                            End If
                        Catch
                        End Try
                    End If

                Else

                    Try
                        Dim Line = e.UserState.ToString : Static Duration As Double

                        If Line.Contains("Duration:") Then
                            Dim str = Line.Substring(Line.IndexOf(":") + 2)
                            Duration = TimeSpan.Parse(str.Remove(str.IndexOf(","))).TotalSeconds


                        ElseIf Line.Contains("time=") Then
                            Dim str = Line.Substring(Line.IndexOf(":") - 2)
                            ProgressBar1.Value = Convert.ToInt32(TimeSpan.Parse(str.Remove(str.IndexOf("b") - 1)).TotalSeconds / DURATION2 * 100)
                            Percentage.Text = Convert.ToInt32(TimeSpan.Parse(str.Remove(str.IndexOf("b") - 1)).TotalSeconds / DURATION2 * 100).ToString + "%"
                        End If
                    Catch
                    End Try
                End If
            End If


            If CHKVIEWLOG.Checked = True Then
                Try

                    'BeginInvoke(New Action(Function() ListBox1.Items.Add(logdata)))
                    'ListBox1.BeginUpdate()

                    'ListBox1.EndUpdate()

                    Invoke(DirectCast(Sub()
                                          ListBox1.BeginUpdate()
                                          ListBox1.SuspendLayout()
                                          ListBox1.Items.Add(logdata)
                                          ListBox1.SelectedIndex = ListBox1.Items.Count - 1
                                          ListBox1.EndUpdate()
                                          ListBox1.ResumeLayout()
                                          StreamInfopopup.LBSTREAMINFOP.Text = logdata + " CPU Usage : " + cpuusage.ToString + "%" + " " + LBWARN.Text


                                      End Sub, MethodInvoker))


                Catch
                End Try


            End If


            If ENCODINGLISTVIEW.Items(0).SubItems(0).Text = "Live Streaming" Then
                If logdata.Contains("bitrate=") Then
                    Try
                        Dim split3 As String() = logdata.Split(New [Char]() {"="})
                        Dim String9 As String = split3(6)
                        Dim String10 As String = String9.Replace(":", "")
                        Dim String11 As String = String10.Replace(".", "")
                        Dim String12 As String = String11.Replace(" bitrate", "")
                        Dim String13 As String = String9.Replace(" bitrate", "")
                        LBBITRATE.Text = String13
                    Catch

                    End Try
                End If

                If logdata.Contains("fps=") Then
                    Try
                        Dim split4 As String() = logdata.Split(New [Char]() {"="})
                        Dim String14 As String = split4(2)
                        Dim String15 As String = String14.Replace(":", "")
                        Dim String16 As String = String15.Replace(".", "")
                        Dim String17 As String = String16.Replace(" fps", "")
                        Dim String18 As String = String14.Replace(" q", "")
                        LBFPS.Text = String18 + "fps"
                    Catch

                    End Try

                End If

                If logdata.Contains("frame=") Then
                    startstreamflag = True
                End If
                'If startstreamflag = True Then
                'If logdata.Contains("frame dropped!") Or logdata.Contains("drop=") Then
                'LBWARN.Text = "Frame Dropped!"
                ' End If
                ' End If

            ElseIf Main.BOXCODEC.Text = "No Video" Then
                LBBITRATE.Text = ""
                Label4.Text = ""
                Label6.Text = ""
                LBFPS.Text = ""


            Else
                If logdata.Contains("Duration:") Then
                    Try
                        Dim split1 As String() = logdata.Split(New [Char]() {" ", ","})
                        Dim String1 As String = split1(3)
                        Dim String2 As String = String1.Replace(":", "")
                        Dim String3 As String = String2.Replace(".", "")

                        If TRIMCHK = "Yes" Then
                            If Not VALTRIMSS = "0" And Not VALTRIMTO = "0" Then
                                CALCDURATION = VALTRIMTO - VALTRIMSS
                                Dim ts As TimeSpan = TimeSpan.FromSeconds(CALCDURATION)
                                Dim mydate As DateTime = New DateTime(ts.Ticks)
                                Label2.Text = mydate.ToString(("HH:mm:ss"))

                            ElseIf Not VALTRIMSS = "0" And VALTRIMTO = "0" And VALTRIMTO = DURATION2 Then
                                Label2.Text = DURATION2 & " Completed"

                            ElseIf VALTRIMSS = "0" And Not VALTRIMTO = "0" Then
                                Label2.Text = TRIMTO & " Completed"
                            End If

                            'ProgressBar1.Maximum = String3
                            'Label2.Text = TRIMTO & " Completed"
                            'ProgressBar1.Visible = False

                        Else

                            ProgressBar1.Visible = True
                            'ProgressBar1.Maximum = String3
                            'Label2.Text = String1 & " Completed"
                            Label2.Text = DURATIONTIME & " Completed"
                        End If

                    Catch
                    End Try
                End If

                If logdata.Contains("frame=") Then
                    Try
                        Dim startchar As String = logdata.IndexOf("time=")
                        Dim String9 As String = logdata.Substring(startchar)
                        Dim String10 As String = String9.Replace("time=", "")
                        Dim split2 As String() = String10.Split(New [Char]() {" "})
                        Dim time As String = split2(0)
                        Label1.Text = time & " of "
                    Catch

                    End Try

                End If

                If logdata.Contains("[download]") Then
                    Try
                        Label1.Visible = False
                        Label2.Visible = False
                        Dim startchar As String = logdata.IndexOf("[download]")
                        Dim String9 As String = logdata.Substring(startchar)
                        Dim String10 As String = String9.Replace("[download] ", "")
                        Dim split2 As String() = String10.Split(New [Char]() {" "})

                        If logdata.Contains("[download]   ") Then
                            Dim downloadpercent As String = split2(2)
                            Percentage.Text = downloadpercent
                            Dim percent As Integer = downloadpercent.Replace("%", "")
                            ProgressBar1.Value = Convert.ToInt32(percent)
                        ElseIf logdata.Contains("[download]  ") Then
                            Dim downloadpercent As String = split2(1)
                            Percentage.Text = downloadpercent
                            Dim percent As Integer = downloadpercent.Replace("%", "")
                            ProgressBar1.Value = Convert.ToInt32(percent)
                        ElseIf logdata.Contains("[download] ") Then
                            Dim downloadpercent As String = split2(0)
                            Percentage.Text = downloadpercent
                            Dim percent As Integer = downloadpercent.Replace("%", "")
                            ProgressBar1.Value = Convert.ToInt32(percent)

                        End If

                    Catch

                    End Try

                End If

                If logdata.Contains("bitrate=") Then
                    Try
                        Dim startchar As String = logdata.IndexOf("bitrate=")
                        Dim String9 As String = logdata.Substring(startchar)
                        Dim String10 As String = String9.Replace("bitrate=", "")

                        LBBITRATE.Text = String10
                    Catch
                    End Try

                End If


                If logdata.Contains("fps=") Then
                    Try
                        Dim split4 As String() = logdata.Split(New [Char]() {"="})
                        Dim String14 As String = split4(2)
                        Dim String15 As String = String14.Replace(":", "")
                        Dim String16 As String = String15.Replace(".", "")
                        Dim String17 As String = String16.Replace(" fps", "")
                        Dim String18 As String = String14.Replace(" q", "")
                        LBFPS.Text = String18 + "fps"
                    Catch

                    End Try

                End If

            End If
        Catch

        End Try




    End Sub

    Private Sub BTNPAUSE_Click(sender As Object, e As EventArgs) Handles BTNPAUSE.Click

        If BTNPAUSE.Text = "Pause" Then
            PauseProcess(p.Id)
            'SuspendProcess(p)
            BTNPAUSE.Text = "Resume"
            ENCODINGLISTVIEW.Items(LISTINDEX).SubItems(1).Text = "Pause"
        ElseIf BTNPAUSE.Text = "Resume" Then
            ResumeProcess(p.Id)
            BTNPAUSE.Text = "Pause"
            ENCODINGLISTVIEW.Items(LISTINDEX).SubItems(1).Text = "Resumed"
        End If

        'AttachConsole(CUInt(p.Id))
        'SetConsoleCtrlHandler(Nothing, False)
        'GenerateConsoleCtrlEvent(CtrlTypes.CTRL_C_EVENT, CUInt(p.Id))
        'p.WaitForExit(2000)
        'FreeConsole()

    End Sub

    ' Enumerated type for the control messages sent to the handler routine
    Private Enum CtrlTypes As UInteger
        CTRL_C_EVENT = 0
        CTRL_BREAK_EVENT = 1
        CTRL_CLOSE_EVENT = 2
        CTRL_LOGOFF_EVENT = 5
        CTRL_SHUTDOWN_EVENT
    End Enum

    <DllImport("kernel32.dll", CallingConvention:=CallingConvention.Cdecl)>
    Private Shared Function GenerateConsoleCtrlEvent(dwCtrlEvent As CtrlTypes, dwProcessGroupId As UInteger) As <MarshalAs(UnmanagedType.Bool)> Boolean
    End Function

    Private Delegate Function ConsoleCtrlDelegate(CtrlType As UInteger) As [Boolean]

    '<DllImport("kernel32.dll", SetLastError:=True)>
    'Private Shared Function AttachConsole(dwProcessId As UInteger) As Boolean
    'End Function
    Private Declare Function AttachConsole Lib "kernel32.dll" (dwProcessId As UInt32) As Boolean
    Private Declare Auto Function FreeConsole Lib "kernel32.dll" () As Boolean
    Private Declare Auto Function AllocConsole Lib "kernel32.dll" () As Boolean

    <DllImport("kernel32.dll")>
    Private Shared Function SetConsoleCtrlHandler(HandlerRoutine As ConsoleCtrlDelegate, Add As Boolean) As Boolean
    End Function

    <DllImport("kernel32.dll")>
    Private Shared Function GenerateConsoleCtrlEvent(dwCtrlEvent As UInteger, dwProcessGroupId As UInteger) As <MarshalAs(UnmanagedType.Bool)> Boolean
    End Function

    Private Const CTRL_C_EVENT As UInteger = 0
    Private Const CTRL_BREAK_EVENT As UInteger = 1
    Private Const CTRL_CLOSE_EVENT As UInteger = 2

    Private Sub BTNFORCESTOP_Click(sender As Object, e As EventArgs) Handles BTNFORCESTOP.Click
        ForceStopped = True
        Stopped = False

        While BackgroundWorker_1.CancellationPending = False
            Try

                KillProcessAndChildren(p.Id)
                KillProcessAndChildren(p.Id)

            Catch

            End Try
            Try
                BackgroundWorker_1.CancelAsync()
            Catch

            End Try

        End While
        'BackgroundWorker_1.CancelAsync()
        'BackgroundWorker_1.Dispose()

        'outputReader.DiscardBufferedData()
        'outputReader.Close()



    End Sub

    Public Enum ThreadAccess As Integer
        TERMINATE = (&H1)
        SUSPEND_RESUME = (&H2)
        GET_CONTEXT = (&H8)
        SET_CONTEXT = (&H10)
        SET_INFORMATION = (&H20)
        QUERY_INFORMATION = (&H40)
        SET_THREAD_TOKEN = (&H80)
        IMPERSONATE = (&H100)
        DIRECT_IMPERSONATION = (&H200)
    End Enum

    Public Declare Function OpenThread Lib "kernel32.dll" (ByVal dwDesiredAccess As ThreadAccess, ByVal bInheritHandle As Boolean, ByVal dwThreadId As UInteger) As IntPtr
    Public Declare Function SuspendThread Lib "kernel32.dll" (ByVal hThread As IntPtr) As UInteger
    Public Declare Function ResumeThread Lib "kernel32.dll" (ByVal hThread As IntPtr) As UInteger
    Public Declare Function TerminateThread Lib "kernel32.dll" (ByVal hThread As IntPtr) As UInteger
    Public Declare Function CloseHandle Lib "kernel32.dll" (ByVal hHandle As IntPtr) As Boolean
    <DllImport("kernel32.dll")> Public Shared Function GetExitCodeThread(ByVal hThread As IntPtr, <Out> ByRef lpExitCode As UInt32) As <MarshalAs(UnmanagedType.Bool)> Boolean
    End Function


    Private Shared Sub SuspendProcess(ByVal process As System.Diagnostics.Process)
        For Each t As ProcessThread In process.Threads
            Dim th As IntPtr
            th = OpenThread(ThreadAccess.SUSPEND_RESUME, False, t.Id)
            If th <> IntPtr.Zero Then
                SuspendThread(th)
                'CloseHandle(th)
            End If
        Next
    End Sub

    Private Shared Sub ResumeProcess(ByVal process As System.Diagnostics.Process)
        For Each t As ProcessThread In process.Threads
            Dim th As IntPtr
            th = OpenThread(ThreadAccess.SUSPEND_RESUME, False, t.Id)
            If th <> IntPtr.Zero Then
                ResumeThread(th)
                'CloseHandle(th)
            End If
        Next
    End Sub
    Private Shared Sub TerminateThreada(ByVal process As System.Diagnostics.Process)
        For Each t As ProcessThread In process.Threads
            Dim th As IntPtr
            th = OpenThread(ThreadAccess.TERMINATE, False, t.Id)
            If th <> IntPtr.Zero Then
                TerminateThread(th)
                CloseHandle(th)
            End If
        Next
    End Sub

    Private Declare Function OpenProcess Lib "kernel32" _
      (ByVal dwDesiredAccess As Long, ByVal bInheritHandle As Long,
       ByVal dwProcessId As Long) As Long
    Private Declare Function WaitForSingleObjectEx Lib "kernel32" _
      (ByVal hHandle As Long, ByVal dwMilliseconds As Long,
       ByVal bAlertable As Long) As Long
    Private Declare Function CloseHandle Lib "kernel32" _
      (ByVal hObject As Long) As Long
    Private Declare Sub ExitProcess Lib "kernel32" (ByVal uExitCode As Long)

    Private Const SYNCHRONIZE = &H100000
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ForceStopped = True

        While BackgroundWorker_1.CancellationPending = False
            Try

                StopProcessTree(p.Id)
            Catch

            End Try
            Try
                BackgroundWorker_1.CancelAsync()
            Catch

            End Try

        End While

    End Sub


    Public Event RunWorkerCompleted As RunWorkerCompletedEventHandler

    Private Sub backgroundWorker1_RunWorkerCompleted(
ByVal sender As Object, ByVal e As RunWorkerCompletedEventArgs) _
Handles BackgroundWorker_1.RunWorkerCompleted
        Try
            If ForceStopped = True Then
                ENCODINGLISTVIEW.Items(LISTINDEX).SubItems(1).Text = "Force Stopped"
                Label2.Text = ""
                Label1.Text = "Force Stopped"
                Exit Sub
            ElseIf Stopped = True Then
                ENCODINGLISTVIEW.Items(LISTINDEX).SubItems(1).Text = "Stopped"
                Label2.Text = ""
                Label1.Text = "Stopped"

            Else
                ENCODINGLISTVIEW.Items(LISTINDEX).SubItems(1).Text = "Done"
                Label2.Text = ""
                Label1.Text = "Done"
                Percentage.Text = "100%"
            End If

            CURRENTENCODINGCMD = ENCODINGLISTVIEW.Items(LISTINDEX).SubItems(2).Text
            'Threading.Thread.Sleep(1000)

            Invoke(New Action(Function() ENCODINGLISTVIEW.Items(LISTINDEX).SubItems(1).Text = "Done"))
            If ENCODINGLIST.Items.Count = 1 And Not CURRENTENCODINGCMD = ENCODINGLISTVIEW.Items(LISTINDEX).SubItems(2).Text Then
                'If ENCODINGLIST.Items.Count = 1 Then
                ENCODINGCOUNT = ENCODINGCOUNT - 1
                LISTINDEX = LISTINDEX - 1
            End If
            Dim ENCODINGLISTCOUNT As Integer = ENCODINGLISTVIEW.Items.Count
            Do Until ENCODINGCOUNT = ENCODINGLISTCOUNT
                'MsgBox(ENCODINGCOUNT)
                While BackgroundWorker_1.IsBusy()
                    Threading.Thread.Sleep(500)
                    Windows.Forms.Application.DoEvents()
                End While
                'MsgBox(ENCODINGCOUNT)
                'MsgBox(ENCODINGLIST.Items.Count)
                If ENCODINGCOUNT >= ENCODINGLISTCOUNT Or ForceStopped = True Then

                    GoTo DONTCONTINUE

                Else

                    ListBox1.Items.Clear()
                    Me.Refresh()

                    Try
                        LISTINDEX = LISTINDEX + 1
                        Label1.Text = ""
                        BackgroundWorker_1.WorkerSupportsCancellation = True
                        BackgroundWorker_1.WorkerReportsProgress = True
                        BackgroundWorker_1.RunWorkerAsync()
                        ENCODINGCOUNT = ENCODINGCOUNT + 1
                        'Timer1.Start()
                        'FFPARAM = ENCODINGLIST.Items.Item(LISTINDEX)



                    Catch

                    End Try

                End If

                'MsgBox(ENCODINGCOUNT)
            Loop
            SW.Stop()
            Tmr.Stop()
            SW.Reset()


DONTCONTINUE:
            Try
                FlashWindow(Me.Handle, 3)
                If Label1.Text = "Done" Then
                    ProgressBar1.Value = ProgressBar1.Maximum
                End If
                SW.Stop()
                Tmr.Stop()

            Catch

            End Try


            Exit Sub
        Catch

        End Try



    End Sub
    <DllImport("user32")> Public Shared Function FlashWindow(ByVal hwnd As Integer, ByVal bInvert As Integer) As Integer
    End Function

    Function BWMonitor()
        Dim networkInterfaces As New System.Diagnostics.PerformanceCounterCategory("Network Interface")
        Dim nics As String() = networkInterfaces.GetInstanceNames()
        Dim bytesSent(nics.Length - 1) As System.Diagnostics.PerformanceCounter
        Dim bytesReceived(nics.Length - 1) As System.Diagnostics.PerformanceCounter
        Dim i As Integer
        For i = 0 To nics.Length - 1
            bytesSent(i) = New System.Diagnostics.PerformanceCounter("Network Interface", "Bytes Sent/sec", nics(i), True)
            bytesReceived(i) = New System.Diagnostics.PerformanceCounter("Network Interface", "Bytes received/sec", nics(i), True)
        Next
        'Dim ni As System.Diagnostics.PerformanceCounter 
        For i = 0 To nics.Length - 1
            System.Console.WriteLine(String.Format("     interface {0}: {1} ", i, nics(i)))
        Next
        Do
            For i = 0 To nics.Length - 1
                LBNETWORK.Text = String.Format("interface {0}: {1} bytes sent/sec, {2} bytes received/sec.", i, bytesSent(i).NextValue, bytesReceived(i).NextValue)
            Next

            System.Console.WriteLine("")
            System.Console.WriteLine("")
            System.Threading.Thread.Sleep(3000)
        Loop
    End Function
    Private Sub ENCODINGLIST_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ENCODINGLIST.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Right Then

            Dim index As Integer = ENCODINGLIST.IndexFromPoint(New Point(e.X, e.Y))
            If index >= 0 Then
                ENCODINGLIST.SelectedItem = ENCODINGLIST.Items(index)
            End If
            ContextMenuStrip1.Show(MousePosition)


        End If
    End Sub
    Private Sub ENCODINGLISTVIEW_MouseDoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles ENCODINGLISTVIEW.DoubleClick
        ' If e.Button = Windows.Forms.MouseButtons.Left Then
        Try
            Dim filename As String
            Dim commandinfo As String

            filename = ENCODINGLISTVIEW.SelectedItems(0).SubItems(0).Text
            commandinfo = ENCODINGLISTVIEW.SelectedItems(0).SubItems(2).Text
            MsgBox("Output : " + filename + vbCrLf + vbCrLf + "Command : " + commandinfo)
        Catch

        End Try








        ' End If
    End Sub
    Private Sub MENUSTOPENC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MENUSTOPENC.Click
        'ENCODINGLIST.Items.Insert(ENCODINGLIST.SelectedIndex, "(Skip)" + ENCODINGLIST.SelectedItem.ToString)
        'ENCODINGLIST.Items.RemoveAt(ENCODINGLIST.SelectedIndex)

        If ENCODINGLISTVIEW.Items.Count = 1 Then
            StopProcess()
        Else
            For i = 0 To ENCODINGLISTVIEW.SelectedItems.Count - 1

                ENCODINGLISTVIEW.Items.Remove(ENCODINGLISTVIEW.SelectedItems(0))

            Next
        End If

    End Sub

    Private Sub BTOPENOUTFOLDER_Click(sender As Object, e As EventArgs) Handles BTOPENOUTFOLDER.Click
        If ENCODINGLISTVIEW.SelectedItems.Count > 0 Then
            Dim outputpath1 As String = ENCODINGLISTVIEW.SelectedItems(0).SubItems(6).Text
            If My.Computer.FileSystem.FileExists(outputpath1) Then
                Shell("explorer /select, " & Chr(34) & outputpath1 & Chr(34), vbNormalFocus)
            Else
                MsgBox("Do not exist output file", vbCritical)
            End If
        Else
            ENCODINGLISTVIEW.Items(0).Selected = True

            Dim outputpath1 As String = ENCODINGLISTVIEW.SelectedItems(0).SubItems(6).Text
            If My.Computer.FileSystem.FileExists(outputpath1) Then
                Shell("explorer /select, " & Chr(34) & outputpath1 & Chr(34), vbNormalFocus)
            Else
                MsgBox("Do not exist output file", vbCritical)
            End If
        End If

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick


    End Sub

    Private Sub BTNSTREAMINFOPOP_Click(sender As Object, e As EventArgs) Handles BTNSTREAMINFOPOP.Click
        StreamInfopopup.Show()

    End Sub

    Private Sub CBPRI_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBPRI.SelectedIndexChanged

    End Sub

    Private Sub CBPRI_TextChanged(sender As Object, e As EventArgs) Handles CBPRI.TextChanged
        Try
            If CBPRI.Text = "Normal" Then
                SetPriorityNormal(p.Id)
            ElseIf CBPRI.Text = "AboveNormal" Then
                SetPriorityAboveNormal(p.Id)
            ElseIf CBPRI.Text = "High" Then
                SetPriorityHigh(p.Id)
            ElseIf CBPRI.Text = "BelowNormal" Then
                SetPriorityBelowNormal(p.Id)

            End If
        Catch

        End Try

    End Sub
    Public Shared Sub SetPriorityHigh(pid As Integer)

        Dim searcher As New ManagementObjectSearcher("Select * From Win32_Process Where ParentProcessID=" & Convert.ToString(pid))
        Dim moc As ManagementObjectCollection = searcher.[Get]()
        For Each mo As ManagementObject In moc
            SetPriorityHigh(Convert.ToInt32(mo("ProcessID")))
        Next
        Try
            Dim proc As Process = Process.GetProcessById(pid)

            proc.PriorityClass = System.Diagnostics.ProcessPriorityClass.High


        Catch generatedExceptionName As ArgumentException
        End Try



    End Sub

    Public Shared Sub SetPriorityNormal(pid As Integer)

        Dim searcher As New ManagementObjectSearcher("Select * From Win32_Process Where ParentProcessID=" & Convert.ToString(pid))
        Dim moc As ManagementObjectCollection = searcher.[Get]()
        For Each mo As ManagementObject In moc
            SetPriorityNormal(Convert.ToInt32(mo("ProcessID")))
        Next
        Try
            Dim proc As Process = Process.GetProcessById(pid)

            proc.PriorityClass = System.Diagnostics.ProcessPriorityClass.Normal


        Catch generatedExceptionName As ArgumentException
        End Try



    End Sub

    Public Shared Sub SetPriorityBelowNormal(pid As Integer)

        Dim searcher As New ManagementObjectSearcher("Select * From Win32_Process Where ParentProcessID=" & Convert.ToString(pid))
        Dim moc As ManagementObjectCollection = searcher.[Get]()
        For Each mo As ManagementObject In moc
            SetPriorityBelowNormal(Convert.ToInt32(mo("ProcessID")))
        Next
        Try
            Dim proc As Process = Process.GetProcessById(pid)

            proc.PriorityClass = System.Diagnostics.ProcessPriorityClass.BelowNormal


        Catch generatedExceptionName As ArgumentException
        End Try



    End Sub

    Public Shared Sub SetPriorityAboveNormal(pid As Integer)

        Dim searcher As New ManagementObjectSearcher("Select * From Win32_Process Where ParentProcessID=" & Convert.ToString(pid))
        Dim moc As ManagementObjectCollection = searcher.[Get]()
        For Each mo As ManagementObject In moc
            SetPriorityAboveNormal(Convert.ToInt32(mo("ProcessID")))
        Next
        Try
            Dim proc As Process = Process.GetProcessById(pid)

            proc.PriorityClass = System.Diagnostics.ProcessPriorityClass.AboveNormal


        Catch generatedExceptionName As ArgumentException
        End Try



    End Sub
End Class




