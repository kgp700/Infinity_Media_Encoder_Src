'Imports System.Diagnostics
'Imports System.IO
'Imports System.Dynamic
Imports System.Management
Imports System.Runtime.InteropServices
Imports System.IO
Imports System.Net.NetworkInformation


Public Class FRMProgress
    Private cpuusage As Integer
    Private networkusage As Integer
    Public p As New Process
    Public FFPARAM As String
    Public outputReader As StreamReader
    Public TRIMCHK As Boolean = Main.TRIMCHKVAL
    Public TRIMTO As String = Main.TRIMTO
    Private Sub FRMProgress_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        If p.HasExited = False Then
            Try
                KillProcessAndChildren(p.Id)
            Catch ex As Exception

            End Try
            If BackgroundWorker_1.IsBusy = True Then
                BackgroundWorker_1.CancelAsync()
            End If

        End If
        outputReader.DiscardBufferedData()
        outputReader.Close()

    End Sub

    Private Sub FRMProgress_Leave(sender As Object, e As EventArgs) Handles Me.Leave

    End Sub

    Private Sub FRMProgress_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FFPARAM = Main.SHELLCMD
        RunProcess()

        Timer1.Start()

    End Sub

    Private Sub BTNSTOP_Click(sender As Object, e As EventArgs) Handles BTNSTOP.Click
        If p.HasExited = False Then
            Try
                AttachConsole(CUInt(p.Id))
                GenerateConsoleCtrlEvent(CTRL_C_EVENT, CUInt(p.Id))
                FreeConsole()
            Catch ex As Exception

            End Try
        End If
        p.WaitForExit(2000)
        outputReader.Close()

    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        cpuusage = PerformanceCounter1.NextValue
        Label3.Text = cpuusage.ToString + "%"
        If InStr(Main.OutputCBox.Text, "//") Then
            Label7.Text = "Network Usage : "
            networkusage = PerformanceCounter2.NextValue
            LBNETWORK.Text = networkusage.ToString + "Kbps/s"
        End If
        




    End Sub

    Public Shared Sub KillProcessAndChildren(pid As Integer)

        Dim searcher As New ManagementObjectSearcher("Select * From Win32_Process Where ParentProcessID=" & Convert.ToString(pid))
        Dim moc As ManagementObjectCollection = searcher.[Get]()
        For Each mo As ManagementObject In moc
            KillProcessAndChildren(Convert.ToInt32(mo("ProcessID")))
        Next
        Try
            Dim proc As Process = Process.GetProcessById(pid)
            proc.Kill()

        Catch generatedExceptionName As ArgumentException
        End Try

    End Sub

    Public Function RunProcess() As String()
        BackgroundWorker_1.WorkerSupportsCancellation = True
        BackgroundWorker_1.WorkerReportsProgress = True
        BackgroundWorker_1.RunWorkerAsync()



    End Function

    Private Sub BackgroundWorker1_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker_1.DoWork
        With p.StartInfo
            .WindowStyle = ProcessWindowStyle.Minimized
            .Arguments = " /c title Infinity Media Encoder & " + FFPARAM
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
        p.Start()
        outputReader = p.StandardError
        Dim output As String

        While p.StandardError.EndOfStream = False

            output = outputReader.ReadLine()
            BackgroundWorker_1.ReportProgress(0, output)

        End While

        If p.StandardError.EndOfStream = True Then
            outputReader.Close()
            MsgBox("Processing Done!", MsgBoxStyle.Information)

        End If

    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker_1.ProgressChanged

        Dim output As String = e.UserState.ToString
        If CHKVIEWLOG.Checked = True Then
            Try
                RichTextBox1.AppendText(output & vbNewLine)
            Catch
            End Try

            RichTextBox1.ScrollToCaret()
        End If


        If InStr(Main.OutputCBox.Text, "//") Then
            If output.Contains("bitrate=") Then
                Dim split3 As String() = output.Split(New [Char]() {"="})
                Dim String9 As String = split3(6)
                Dim String10 As String = String9.Replace(":", "")
                Dim String11 As String = String10.Replace(".", "")
                Dim String12 As String = String11.Replace(" bitrate", "")
                Dim String13 As String = String9.Replace(" bitrate", "")
                LBBITRATE.Text = String13

            End If

            If output.Contains("fps=") Then
                Dim split4 As String() = output.Split(New [Char]() {"="})
                Dim String14 As String = split4(2)
                Dim String15 As String = String14.Replace(":", "")
                Dim String16 As String = String15.Replace(".", "")
                Dim String17 As String = String16.Replace(" fps", "")
                Dim String18 As String = String14.Replace(" q", "")
                LBFPS.Text = String18 + "fps"
            End If

            If output.Contains("frame dropped!") And output.Contains("time=") Then
                LBWARN.Text = "Frame Dropped!"
            End If
        Else
            If output.Contains("Duration:") Then
                Try
                    Dim split1 As String() = output.Split(New [Char]() {" ", ","})
                    Dim String1 As String = split1(3)
                    Dim String2 As String = String1.Replace(":", "")
                    Dim String3 As String = String2.Replace(".", "")

                    If Main.TRIMCHKVAL = True Then
                        ProgressBar1.Maximum = String3
                        Label2.Text = Main.TRIMTO & " Completed"
                        ProgressBar1.Visible = False
                    Else
                        ProgressBar1.Maximum = String3
                        Label2.Text = String1 & " Completed"
                    End If

                Catch
                End Try
            End If
            If output.Contains("frame=") Then
                Try
                    Dim split2 As String() = output.Split(New [Char]() {"="})
                    Dim String4 As String = split2(5)
                    Dim String5 As String = String4.Replace(":", "")
                    Dim String6 As String = String5.Replace(".", "")
                    Dim String7 As String = String6.Replace(" bitrate", "")
                    Dim String8 As String = String4.Replace(" bitrate", "")
                    ProgressBar1.Value = String7
                    Label1.Text = String8 & " of "
                Catch
                End Try
            End If

            If output.Contains("bitrate=") Then
                Dim split3 As String() = output.Split(New [Char]() {"="})
                Dim String9 As String = split3(6)
                Dim String10 As String = String9.Replace(":", "")
                'Dim String11 As String = String10.Replace(".", "")
                Dim String12 As String = String10.Replace("bitrate ", "")

                LBBITRATE.Text = String12
            End If

            If output.Contains("fps=") Then
                Dim split4 As String() = output.Split(New [Char]() {"="})
                Dim String14 As String = split4(2)
                Dim String15 As String = String14.Replace(":", "")
                Dim String16 As String = String15.Replace(".", "")
                Dim String17 As String = String16.Replace(" fps", "")
                Dim String18 As String = String14.Replace(" q", "")
                LBFPS.Text = String18 + "fps"
            End If
        End If



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        AttachConsole(CUInt(p.Id))
        GenerateConsoleCtrlEvent(CTRL_C_EVENT, CUInt(p.Id))
        FreeConsole()

    End Sub


    ' Enumerated type for the control messages sent to the handler routine
    Private Enum CtrlTypes As UInteger
        CTRL_C_EVENT = 0
        CTRL_BREAK_EVENT
        CTRL_CLOSE_EVENT
        CTRL_LOGOFF_EVENT = 5
        CTRL_SHUTDOWN_EVENT
    End Enum

    <DllImport("kernel32.dll")> _
    Private Shared Function GenerateConsoleCtrlEvent(dwCtrlEvent As CtrlTypes, dwProcessGroupId As UInteger) As <MarshalAs(UnmanagedType.Bool)> Boolean
    End Function

    Private Delegate Function ConsoleCtrlDelegate(CtrlType As UInteger) As [Boolean]

    <DllImport("kernel32.dll", SetLastError:=True)>
    Private Shared Function AttachConsole(dwProcessId As UInteger) As Boolean
    End Function

    Private Declare Auto Function FreeConsole Lib "kernel32.dll" () As Boolean

    <DllImport("kernel32.dll")>
    Private Shared Function SetConsoleCtrlHandler(HandlerRoutine As ConsoleCtrlDelegate, Add As Boolean) As Boolean
    End Function

    <DllImport("kernel32.dll")>
    Private Shared Function GenerateConsoleCtrlEvent(dwCtrlEvent As UInteger, dwProcessGroupId As UInteger) As <MarshalAs(UnmanagedType.Bool)> Boolean
    End Function

    Private Const CTRL_C_EVENT As UInteger = 0

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            KillProcessAndChildren(p.Id)
        Catch ex As Exception

        End Try
        BackgroundWorker_1.CancelAsync()
        outputReader.DiscardBufferedData()
        outputReader.Close()


    End Sub

End Class