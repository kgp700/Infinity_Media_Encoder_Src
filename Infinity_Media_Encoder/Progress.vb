Imports System.Diagnostics
Imports System.IO
Imports System.Dynamic
Imports System.Management

Public Class FRMProgress
    Private totalHits As Integer = 0
    Private cpuusage As Integer
    Public myId As Integer
    Private myId2 As Integer
    Public myId3 As Integer


    Private Sub FRMProgress_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Main.p.HasExited = False Then
            KillProcessAndChildren(Main.p.Id)
        End If
    End Sub

    Private Sub FRMProgress_Leave(sender As Object, e As EventArgs) Handles Me.Leave

    End Sub

    Private Sub FRMProgress_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Main.RunProcess()
        Timer1.Start()


    End Sub

    Private Sub BTNSTOP_Click(sender As Object, e As EventArgs) Handles BTNSTOP.Click
        If Main.p.HasExited = False Then

            KillProcessAndChildren(Main.p.Id)

        End If


    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        cpuusage = Main.PerformanceCounter1.NextValue

        Label3.Text = cpuusage.ToString + "%"




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

            ' Process already exited.
        Catch generatedExceptionName As ArgumentException
        End Try
    End Sub
End Class