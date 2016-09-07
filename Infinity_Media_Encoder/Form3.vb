Imports System.Runtime.InteropServices
Imports System.Threading
Imports System.Security.Permissions
Imports System.IO


Public Class Form3
    Public outputReader As StreamReader
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StartPlay()
    End Sub


    Delegate Sub ChangeTextsSafe(ByVal percent As String)
    Private MPLAYERPATH As String
    Private p As New Process
    Dim args, time_length, time_pos, buffer, CDP As String
    Dim posh, tdr As Long
    Public mwh As Integer
    Public Const WM_NCLBUTTONDOWN As Integer = &HA1
    Public Const HT_CAPTION As Integer = &H2




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

        'SendMessage(p.MainWindowHandle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        'AppActivate(myProcess.Id)
        'SetActiveWindow(myProcess.MainWindowHandle)
        'SetForegroundWindow(myProcess.MainWindowHandle)

    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        outputReader = p.StandardOutput
        Dim outdata As String = outputReader.ReadLine()
        Label1.Text = outdata
    End Sub
End Class
