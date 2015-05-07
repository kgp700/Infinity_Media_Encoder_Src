Public Class Contconv
    Private Property strFileName As String
    Private Property strFileNameOpen As String
    Private Property strFileNameSave As String
    Public INPUTFILENAME As String
    Public OUTPUTFILENAME As String
    Public STARTTIME As String
    Public DURATION As String
    Public FLAG As String

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        OpenFileDialog1.Filter = "All Files (*.*)|*.*|Video Files |*.mkv;*.mp4;*.ts;*.avi;*.mov;*.3gp;*.wmv;*.m2ts;*.flv;*.mpeg;*.webm;*.mpg|Audio Files |*.mp3;*.aac;*.m4a;*.dts;*.ac3;*.wav;*.mp2;*.wma;*.ogg;*.rm"
        OpenFileDialog1.FilterIndex = 1
        OpenFileDialog1.ShowDialog()
        strFileNameOpen = OpenFileDialog1.FileName
        InputCBOX.Text = strFileNameOpen
        INPUTFILENAME = InputCBOX.Text
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        SaveFileDialog1.ShowDialog()
        strFileNameSave = SaveFileDialog1.FileName
        OutputCBox.Text = strFileNameSave
        OUTPUTFILENAME = OutputCBox.Text
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        INPUTFILENAME = InputCBOX.Text
        OUTPUTFILENAME = OutputCBox.Text
        Dim fso, oFile
        fso = CreateObject("Scripting.FileSystemObject")
        oFile = fso.CreateTextFile("run.cmd", True)
        oFile.WriteLine("@echo off")
        oFile.WriteLine("title Simple FFMpeg Encoder")
        oFile.WriteLine("ffmpeghyb -i " + """" + INPUTFILENAME + """" + " -vcodec copy -metadata comment=Encoded_by_Simple_FFMpeg_Encoder_Nexstreaming_Louis -acodec copy " + """" + OUTPUTFILENAME + """")
        oFile.Close()
        Shell("cmd /c run.cmd & cmd /c call comp.bat", vbNormalFocus)

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        INPUTFILENAME = InputCBOX.Text
        OUTPUTFILENAME = OutputCBox.Text
        Dim fso, oFile
        fso = CreateObject("Scripting.FileSystemObject")
        oFile = fso.CreateTextFile("run.cmd", True)
        oFile.WriteLine("@echo off")
        oFile.WriteLine("title Simple FFMpeg Encoder")
        oFile.WriteLine("ffmpeghyb -i " + """" + INPUTFILENAME + """" + " -metadata comment=Encoded_by_Simple_FFMpeg_Encoder_Nexstreaming_Louis -vn -sn -acodec copy " + """" + OUTPUTFILENAME + """")
        oFile.Close()
        Shell("cmd /c run.cmd & cmd /c call comp.bat", vbNormalFocus)

    End Sub

    Private Sub Contconv_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.AllowDrop = True
    End Sub

    Private Sub Contconv_DragEnter(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles Me.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub


End Class