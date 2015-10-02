Public Class About

    Private Sub About_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.SelectionStart = TextBox1.Text.Length
        TextBox1.DeselectAll()
    End Sub
End Class