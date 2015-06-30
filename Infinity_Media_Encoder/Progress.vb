'Imports System.Diagnostics
'Imports System.IO
'Imports System.Dynamic
Imports System.Management

Public Class FRMProgress
    Private cpuusage As Integer


    Private Sub FRMProgress_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        If Main.p.HasExited = False Then
            Try
                KillProcessAndChildren(Main.p.Id)
            Catch ex As Exception

            End Try
            If Main.BackgroundWorker1.IsBusy = True Then
                Main.BackgroundWorker1.CancelAsync()
            End If

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
            Try
                KillProcessAndChildren(Main.p.Id)
            Catch ex As Exception

            End Try
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