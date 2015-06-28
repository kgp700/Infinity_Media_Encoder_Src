Public Class FRMProgress



    Private Sub FRMProgress_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        For Each pr As Process In Process.GetProcesses
            ListBox1.Items.Add(pr.ProcessName.ToString)

            If String.Compare(pr.ProcessName, "ffmpeghyb", True) = 0 Then
                pr.Kill()
            End If

        Next



    End Sub

    Private Sub FRMProgress_Leave(sender As Object, e As EventArgs) Handles Me.Leave

    End Sub

    Private Sub FRMProgress_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Main.RunProcess()
        Me.Activate()
    End Sub

    Private Sub BTNSTOP_Click(sender As Object, e As EventArgs) Handles BTNSTOP.Click
        For Each pr As Process In Process.GetProcesses
            ListBox1.Items.Add(pr.ProcessName.ToString)

            If String.Compare(pr.ProcessName, "ffmpeghyb", True) = 0 Then
                pr.Kill()
            End If

        Next


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For Each pr As Process In Process.GetProcesses
            ListBox1.Items.Add(pr.ProcessName.ToString)

            If String.Compare(pr.ProcessName, "ffmpeghyb", True) = 0 Then

            End If

        Next
    End Sub
End Class