Public Class FRMMERGEMEDIA
    Private Sub BTNMERGE_Click(sender As Object, e As EventArgs) Handles BTNMERGE.Click

    End Sub

    Private Sub LISTFILES_DragDrop(sender As Object, e As DragEventArgs) Handles LISTFILES.DragDrop
        Dim files() As String = e.Data.GetData(DataFormats.FileDrop)
        For Each path In files
            LISTFILES.Items.Add(path)
        Next
    End Sub

    Private Sub LISTFILES_DragEnter(sender As Object, e As DragEventArgs) Handles LISTFILES.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub


    Private Sub LISTFILES_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LISTFILES.SelectedIndexChanged

    End Sub
End Class