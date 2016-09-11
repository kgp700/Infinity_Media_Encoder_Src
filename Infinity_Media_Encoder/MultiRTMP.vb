Imports System.IO
Imports System.Xml.Serialization

Public Class FRMMULTIRTMP
    Public Function RTMPCOPY1()
        Shell("cmd /c title Infinity Media Encoder - RTMP1 & " + """" + Main.STARTUPPATH + "\Tools\ffmpeg32\ffmpeg.exe" + """" + " -rtbufsize 2100M -i " + """" + Main.OutputCBox.Text + """" +
             " -vcodec copy -acodec copy -metadata description=" + """" + "Encoded by Infinity Media Encoder K.G.P (Louis)" + """" + " -f flv " + """" + BOXRTMPADR1.Text + """" + " &pause", vbNormalFocus)
    End Function
    Public Function RTMPCOPY2()
        Shell("cmd /c title Infinity Media Encoder - RTMP2 & " + """" + Main.STARTUPPATH + "\Tools\ffmpeg32\ffmpeg.exe" + """" + " -rtbufsize 2100M -i " + """" + Main.OutputCBox.Text + """" +
              " -vcodec copy -acodec copy -metadata description=" + """" + "Encoded by Infinity Media Encoder K.G.P (Louis)" + """" + " -f flv " + """" + BOXRTMPADR2.Text + """" + " &pause", vbNormalFocus)
    End Function
    Public Function RTMPCOPY3()
        Shell("cmd /c title Infinity Media Encoder - RTMP3 & " + """" + Main.STARTUPPATH + "\Tools\ffmpeg32\ffmpeg.exe" + """" + " -rtbufsize 2100M -i " + """" + Main.OutputCBox.Text + """" +
             " -vcodec copy -acodec copy -metadata description=" + """" + "Encoded by Infinity Media Encoder K.G.P (Louis)" + """" + " -f flv " + """" + BOXRTMPADR3.Text + """" + " &pause", vbNormalFocus)
    End Function
    Public Function RTMPCOPY4()
        Shell("cmd /c title Infinity Media Encoder - RTMP4 & " + """" + Main.STARTUPPATH + "\Tools\ffmpeg32\ffmpeg.exe" + """" + " -rtbufsize 2100M -i " + """" + Main.OutputCBox.Text + """" +
      " -vcodec copy -acodec copy -metadata description=" + """" + "Encoded by Infinity Media Encoder K.G.P (Louis)" + """" + " -f flv " + """" + BOXRTMPADR4.Text + """" + " &pause", vbNormalFocus)
    End Function
    Public Function RTMPCOPY5()
        Shell("cmd /c title Infinity Media Encoder - RTMP5 & " + """" + Main.STARTUPPATH + "\Tools\ffmpeg32\ffmpeg.exe" + """" + " -rtbufsize 2100M -i " + """" + Main.OutputCBox.Text + """" +
              " -vcodec copy -acodec copy -metadata description=" + """" + "Encoded by Infinity Media Encoder K.G.P (Louis)" + """" + " -f flv " + """" + BOXRTMPADR5.Text + """" + " &pause", vbNormalFocus)
    End Function
    Public Function RTMPCOPY6()
        Shell("cmd /c title Infinity Media Encoder - RTMP6 & " + """" + Main.STARTUPPATH + "\Tools\ffmpeg32\ffmpeg.exe" + """" + " -rtbufsize 2100M -i " + """" + Main.OutputCBox.Text + """" +
              " -vcodec copy -acodec copy -metadata description=" + """" + "Encoded by Infinity Media Encoder K.G.P (Louis)" + """" + " -f flv " + """" + BOXRTMPADR6.Text + """" + " &pause", vbNormalFocus)
    End Function
    Public Function RTMPCOPY7()
        Shell("cmd /c title Infinity Media Encoder - RTMP7 & " + """" + Main.STARTUPPATH + "\Tools\ffmpeg32\ffmpeg.exe" + """" + " -rtbufsize 2100M -i " + """" + Main.OutputCBox.Text + """" +
      " -vcodec copy -acodec copy -metadata description=" + """" + "Encoded by Infinity Media Encoder K.G.P (Louis)" + """" + " -f flv " + """" + BOXRTMPADR7.Text + """" + " &pause", vbNormalFocus)
    End Function
    Private Sub BTCPSTREAM1_Click(sender As Object, e As EventArgs) Handles BTCPSTREAM1.Click
        RTMPCOPY1()
    End Sub

    Private Sub BTCPSTREAM2_Click(sender As Object, e As EventArgs) Handles BTCPSTREAM2.Click
        RTMPCOPY2()
    End Sub

    Private Sub BTCPSTREAM3_Click(sender As Object, e As EventArgs) Handles BTCPSTREAM3.Click
        RTMPCOPY3()
    End Sub

    Private Sub BTCPSTREAM4_Click(sender As Object, e As EventArgs) Handles BTCPSTREAM4.Click
        RTMPCOPY4()
    End Sub

    Private Sub BTCPSTREAM5_Click(sender As Object, e As EventArgs) Handles BTCPSTREAM5.Click
        RTMPCOPY5()
    End Sub

    Private Sub BTCPSTREAM6_Click(sender As Object, e As EventArgs) Handles BTCPSTREAM6.Click
        RTMPCOPY6()
    End Sub

    Private Sub BTCPSTREAM7_Click(sender As Object, e As EventArgs) Handles BTCPSTREAM7.Click
        RTMPCOPY7()
    End Sub

    Public Sub FindControls(ByVal cont As Control, ByVal Data As List(Of ControlData))
        For Each ctl As Control In cont.Controls
            If TypeOf ctl Is ComboBox Then
                Dim CB As ComboBox = DirectCast(ctl, ComboBox)
                If Not CB.Text = "" Then

                    Dim cd As New ControlData
                    cd.ControlName = ctl.Name
                    cd.ControlProperty = "Text"
                    cd.ControlData = CB.Text.ToString
                    Data.Add(cd)

                End If
            ElseIf ctl.HasChildren Then
                FindControls(ctl, Data)

            End If

        Next
    End Sub
    Public Function LoadPresetMRTMP()


        If System.IO.File.Exists(".\Preset\" + Main.PRESETFILENAME + ".xml") Then
            Dim Data As New List(Of ControlData)
            Dim xml As New XmlSerializer(Data.GetType)
            Using reader As New FileStream(".\Preset\" + Main.PRESETFILENAME + ".xml", FileMode.Open)
                Data = CType(xml.Deserialize(reader), List(Of ControlData))

            End Using

            Dim matches() As Control
            For Each cd As ControlData In Data
                matches = Me.Controls.Find(cd.ControlName, True)
                If matches.Length > 0 Then
                    CallByName(matches(0), cd.ControlProperty, CallType.Let, cd.ControlData)
                End If
            Next
        End If

    End Function

    Private Sub BTCPSTREAMALL_Click(sender As Object, e As EventArgs) Handles BTCPSTREAMALL.Click
        If Not BOXRTMPADR1.Text = "" Then
            RTMPCOPY1()
        End If
        If Not BOXRTMPADR2.Text = "" Then
            RTMPCOPY2()
        End If
        If Not BOXRTMPADR3.Text = "" Then
            RTMPCOPY3()
        End If
        If Not BOXRTMPADR4.Text = "" Then
            RTMPCOPY4()
        End If
        If Not BOXRTMPADR5.Text = "" Then
            RTMPCOPY5()
        End If
        If Not BOXRTMPADR6.Text = "" Then
            RTMPCOPY6()
        End If
        If Not BOXRTMPADR7.Text = "" Then
            RTMPCOPY7()
        End If


    End Sub
End Class