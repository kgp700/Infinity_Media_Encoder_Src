Imports System.IO
Imports System.Threading
Imports System.Runtime.InteropServices
Imports System.Security.Permissions



Public Class TrimPreviewPlayer2
    Delegate Sub ChangeTextsSafe(ByVal percent As String)
    Private MPLAYERPATH As String
    Private p As New Process
    Dim args, time_length, time_pos, buffer, CDP As String
    Dim posh, tdr As Long
    Public mwh As Integer
    Public Const WM_NCLBUTTONDOWN As Integer = &HA1
    Public Const HT_CAPTION As Integer = &H2

    Private Sub TrimPreviewPlayer2_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus
        Me.Focus()
    End Sub

    Private Sub TrimPreviewPlayer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.DoubleBuffered = True

    End Sub
    Public Sub SendCommand(ByVal cmd As String)
        Try
            If p IsNot Nothing AndAlso p.HasExited = False Then
                p.StandardInput.Write(cmd & vbLf)
            End If
        Catch
        End Try
    End Sub

    <DllImport("user32.dll", SetLastError:=True)>
    Private Shared Function MoveWindow(hWnd As IntPtr, X As Integer, Y As Integer, nWidth As Integer, nHeight As Integer, bRepaint As Boolean) As Boolean
    End Function

    <DllImport("user32.dll")>
    Private Shared Function SetParent(hWndChild As IntPtr, hWndNewParent As IntPtr) As IntPtr
    End Function
    <DllImport("user32.dll")> _
    Private Shared Function GetWindowRect(ByVal hWnd As System.IntPtr, ByRef lpRect As RECT) As Boolean
    End Function
    Structure RECT
        Public Left As Integer
        Public Top As Integer
        Public Right As Integer
        Public Bottom As Integer
    End Structure
    <SecurityPermissionAttribute(SecurityAction.Demand, Flags:=SecurityPermissionFlag.UnmanagedCode)>
    Public Shared Sub AppActivate(ProcessId As Integer)
    End Sub
    Declare Function SetWindowPos Lib "user32" (ByVal hwnd As Long, ByVal hWndInsertAfter As Long, ByVal x As Long, ByVal y As Long, ByVal cx As Long, ByVal cy As Long, ByVal wFlags As Long) As Long
    Private Const HWND_TOP = 0
    Private Const HWND_BOTTOM = 1
    Private Const HWND_TOPMOST = -1
    Private Const HWND_NOTOPMOST = -2
    Private Const SWP_NOSIZE = &H1
    Private Const SWP_NOMOVE = &H2
    Const SWP_NOACTIVATE = &H10
    Const SWP_SHOWWINDOW = &H40
    Private Declare Function SetActiveWindow Lib "user32.dll" (ByVal hWnd As Long) As Long
    Private Declare Function SetForegroundWindow Lib "user32.dll" (ByVal hwnd As Long) As IntPtr
    Private Declare Function SendMessage Lib "user32.dll" Alias "SendMessageA" (ByVal winHandle As Int32, _
    ByVal wMsg As Int32, ByVal wParam As Int32, ByVal lParam As Int32) As Int32


    Public Sub StartPlay()
        Initiallize()
        args = " -i"
        MPLAYERPATH = """" + Application.StartupPath + "\Tools\ffmpeg32\ffplay.exe" + """"
        With p.StartInfo


            .FileName = MPLAYERPATH
            .UseShellExecute = False
            .RedirectStandardOutput = True
            .RedirectStandardInput = True
            .CreateNoWindow = True

            .Arguments = args + " " + """" + Main.InputCBOX.Text + """"

        End With
        Thread.Sleep(200)
        p.EnableRaisingEvents = True
        posh = 1
        tdr = 1
        ' BackgroundWorker1.RunWorkerAsync()

        p.Start()
        Dim rectwin As New RECT
        Dim swidth As Integer
        Dim sheight As Integer

        Dim myProcess As System.Diagnostics.Process = System.Diagnostics.Process.GetCurrentProcess()
        GetWindowRect(p.MainWindowHandle, rectwin)
        swidth = rectwin.Right - rectwin.Left
        sheight = rectwin.Bottom - rectwin.Top
        Thread.Sleep(1000)
        SetParent(p.MainWindowHandle, VideoScreen.Handle)
        Thread.Sleep(1000)
        'SetWindowPos(p.MainWindowHandle, HWND_TOP, 0, 0, 0, 0, SWP_NOMOVE Or SWP_NOSIZE)

        MoveWindow(p.MainWindowHandle, 0, 0, VideoScreen.Right - VideoScreen.Left, VideoScreen.Bottom - VideoScreen.Top, 1)
        'SetWindowPos(p.MainWindowHandle, 0, 0, 0, VideoScreen.Width, VideoScreen.Height, 0)
        Thread.Sleep(1000)
        VideoScreen.Refresh()
        'MsgBox(myProcess.ToString)
        Application.DoEvents()
        'SendMessage(p.MainWindowHandle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        'AppActivate(myProcess.Id)
        'SetActiveWindow(myProcess.MainWindowHandle)
        'SetForegroundWindow(myProcess.MainWindowHandle)


        Timer1.Start()
    End Sub


    Public Function StopVideo() As String()
        AppActivate(Process.GetCurrentProcess().Id)
        Try
            p.Kill()
        Catch

        End Try
        Timer1.Stop()

    End Function
    Public Function Initiallize() As String()
        time_length = ""
        time_pos = ""
        BTNPLAYPREV.Text = "Pause"
        Timer1.Stop()
        TrackBar1.Value = 0
        Label1.Text = "00:00:00"
        Label2.Text = "00:00:00"
    End Function
    Private Sub BTNPLAYPREV_Click(sender As Object, e As EventArgs) Handles BTNPLAYPREV.Click
        Form3.Show()
        SetParent(Form3.Handle, VideoScreen.Handle)
        MoveWindow(Form3.Handle, 0, 0, VideoScreen.Right - VideoScreen.Left, VideoScreen.Bottom - VideoScreen.Top, 1)
        'StartPlay()

        If BTNPLAYPREV.Text = "Pause" Then
            posh = 0
            BTNPLAYPREV.Text = "Play"
            Timer1.Stop()
            SendCommand("pause")

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
        Try
            If timeInSeconds >= 0 Then
                Dim iSecond As Double = timeInSeconds
                Dim iSpan As TimeSpan = TimeSpan.FromSeconds(iSecond)
                If strx = 1 Then
                    time_length = iSpan.Hours.ToString.PadLeft(2, "0"c) & ":" & iSpan.Minutes.ToString.PadLeft(2, "0"c) & ":" & iSpan.Seconds.ToString.PadLeft(2, "0"c)
                    TrackBar1.Maximum = timeInSeconds
                    tdr = 0
                Else
                    time_pos = iSpan.Hours.ToString.PadLeft(2, "0"c) & ":" & iSpan.Minutes.ToString.PadLeft(2, "0"c) & ":" & iSpan.Seconds.ToString.PadLeft(2, "0"c)
                    TrackBar1.Value = timeInSeconds
                End If
                Label1.Text = time_pos
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
            End If
        Catch
        End Try
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If tdr = 1 Then
            SendCommand("get_time_length")
        Else
            SendCommand("get_time_pos")
        End If
    End Sub
    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

        Dim safedelegate As New ChangeTextsSafe(AddressOf ChangeTexts)
        Do
            System.Threading.Thread.Sleep(1)
            Try
                If posh = 1 Then
                    Dim sLine As String = p.StandardOutput.ReadLine
                    If sLine.Contains("ANS_LENGTH") Then
                        Dim str = sLine.Substring(sLine.IndexOf("ANS_LENGTH"))
                        Me.Invoke(safedelegate, str)
                    ElseIf sLine.Contains("ANS_TIME_POSITION") Then
                        Dim str = sLine.Substring(sLine.IndexOf("ANS_TIME_POSITION"))
                        Me.Invoke(safedelegate, str)
                    End If
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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BTNOK.Click
        If Not BOXSTARTTIME.Text = "" Then
            Main.BOXTRIMSS.Text = BOXSTARTTIME.Text
        End If
        If Not BOXENDTIME.Text = "" Then
            Main.BOXTRIMTO.Text = BOXENDTIME.Text
        End If

        Me.Close()

    End Sub
    Private Sub TrackBar1_MouseDown(sender As Object, e As MouseEventArgs) Handles TrackBar1.MouseDown
        Try
            If e.Button = Windows.Forms.MouseButtons.Left And BTNPLAYPREV.Text = "Pause" Then
                Dim dValue As Double
                dValue = (Convert.ToDouble(e.X) / Convert.ToDouble(TrackBar1.Width)) * (TrackBar1.Maximum - TrackBar1.Minimum)
                TrackBar1.Value = Convert.ToInt32(dValue)
                'SendCommand("seek " & TrackBar1.Value & " 2")
            End If
        Catch
        End Try
    End Sub
    Private Sub TrackBar1_Move(sender As Object, e As EventArgs) Handles TrackBar1.Move
        Try


            SendCommand("seek " & TrackBar1.Value & " 2")

        Catch
        End Try
    End Sub

End Class