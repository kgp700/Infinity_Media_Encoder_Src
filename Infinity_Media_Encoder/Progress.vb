Imports System.Diagnostics
Imports System.IO
Imports System.Dynamic

Public Class FRMProgress
    Private totalHits As Integer = 0
    Private cpuusage As Integer


    Private Sub FRMProgress_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Main.p.HasExited = False Then
            Main.p.Kill()
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
            Main.p.Kill()
        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        cpuusage = Main.PerformanceCounter1.NextValue

        Label3.Text = cpuusage.ToString + "%"




    End Sub
End Class