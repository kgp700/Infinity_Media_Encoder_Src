Imports System.Xml.Serialization
Imports System.IO

Public Class FRMCUSTOMENC
    Private FileName As String = System.IO.Path.Combine(Application.StartupPath, "CustomEncOpt.xml")
    Dim BOXCUSTOMCODECOPTTEXT As String
    Dim CUSTOMVIDEOFILTERTEXT As String
    Dim CUSTOMAUDIOFILTERTEXT As String
    Dim CUSTOMFFMPEGOPTTEXT As String
    Dim CUSTOMFFMPEGOPTTEXTF As String

    Public Function SaveCustomEncOpt() As String()
        Dim Data As New List(Of ControlData)
        FindControls(Me, Data)

        Dim xml As New XmlSerializer(Data.GetType)
        Using writer As New FileStream(".\Preset\" + Main.PRESETFILENAME + ".xml", FileMode.Open)
            xml.Serialize(writer, Data)
        End Using
    End Function
    Public Sub FindControls(ByVal cont As Control, ByVal Data As List(Of ControlData))
        For Each ctl As Control In cont.Controls
            If TypeOf ctl Is TextBox Then
                Dim CB As TextBox = DirectCast(ctl, TextBox)
                If Not CB.Text = "" Then
                    Dim cd As New ControlData
                    cd.ControlName = ctl.Name
                    cd.ControlProperty = "Text"
                    cd.ControlData = CB.Text.ToString
                    Data.Add(cd)
                End If
            End If
        Next
    End Sub


    Public Function ParsingsettingsCustomEncOpt()
        BOXCUSTOMCODECOPT.Text = ""
        Main.CUSTOMCODECOPT = ""
        BOXCUSTOMCODECOPTTEXT = ""

        BOXCUSTOMVFILTEROPT.Text = ""
        Main.CUSTOMVIDEOFILTER = ""
        CUSTOMVIDEOFILTERTEXT = ""

        BOXCUSTOMAUDFILTEROPT.Text = ""
        Main.CUSTOMAUDIOFILTER = ""
        CUSTOMAUDIOFILTERTEXT = ""

        BOXCUSTOMFFMPEGOPT.Text = ""
        Main.CUSTOMFFMPEGOPT = ""
        CUSTOMFFMPEGOPTTEXT = ""

        BOXCUSTOMFFMPEGOPTF.Text = ""
        Main.CUSTOMFFMPEGOPTF = ""
        CUSTOMFFMPEGOPTTEXTF = ""

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
        Else
            MsgBox("Do not exist Preset file " + Main.PRESETFILENAME + ".xml")
        End If
        If Not BOXCUSTOMCODECOPT.Text = "" Then
            Main.CUSTOMCODECOPT = ":" + BOXCUSTOMCODECOPT.Text
            BOXCUSTOMCODECOPTTEXT = BOXCUSTOMCODECOPT.Text
        Else
            Main.CUSTOMCODECOPT = BOXCUSTOMCODECOPT.Text
            BOXCUSTOMCODECOPTTEXT = BOXCUSTOMCODECOPT.Text
        End If

        If Not BOXCUSTOMVFILTEROPT.Text = "" Then
            Main.CUSTOMVIDEOFILTER = "," + BOXCUSTOMVFILTEROPT.Text
            CUSTOMVIDEOFILTERTEXT = BOXCUSTOMVFILTEROPT.Text
        Else
            Main.CUSTOMVIDEOFILTER = BOXCUSTOMVFILTEROPT.Text
            CUSTOMVIDEOFILTERTEXT = BOXCUSTOMVFILTEROPT.Text
        End If

        If Not BOXCUSTOMAUDFILTEROPT.Text = "" Then
            Main.CUSTOMAUDIOFILTER = "," + BOXCUSTOMAUDFILTEROPT.Text
            CUSTOMAUDIOFILTERTEXT = BOXCUSTOMAUDFILTEROPT.Text
        Else
            Main.CUSTOMAUDIOFILTER = BOXCUSTOMAUDFILTEROPT.Text
            CUSTOMAUDIOFILTERTEXT = BOXCUSTOMAUDFILTEROPT.Text
        End If

        If Not BOXCUSTOMFFMPEGOPT.Text = "" Then
            Main.CUSTOMFFMPEGOPT = " " + BOXCUSTOMFFMPEGOPT.Text + " "
            CUSTOMFFMPEGOPTTEXT = BOXCUSTOMFFMPEGOPT.Text
        Else
            Main.CUSTOMFFMPEGOPT = BOXCUSTOMFFMPEGOPT.Text
            CUSTOMFFMPEGOPTTEXT = BOXCUSTOMFFMPEGOPT.Text
        End If

        If Not BOXCUSTOMFFMPEGOPTF.Text = "" Then
            Main.CUSTOMFFMPEGOPTF = " " + BOXCUSTOMFFMPEGOPTF.Text + " "
            CUSTOMFFMPEGOPTTEXTF = BOXCUSTOMFFMPEGOPTF.Text
        Else
            Main.CUSTOMFFMPEGOPTF = BOXCUSTOMFFMPEGOPTF.Text
            CUSTOMFFMPEGOPTTEXTF = BOXCUSTOMFFMPEGOPTF.Text
        End If

    End Function

    Public Function SaveFormCustomEncOpt() As String()
        Dim Data As New List(Of ControlData)
        Main.FindControls(Me, Data)

        Dim xml As New XmlSerializer(Data.GetType)
        Using writer As New FileStream(FileName, FileMode.Create)
            xml.Serialize(writer, Data)
        End Using
        Me.Hide()
    End Function

    Public Function ParsingsettingsFormCustomEncOpt() As String()

        If System.IO.File.Exists(FileName) Then
            Dim Data As New List(Of ControlData)
            Dim xml As New XmlSerializer(Data.GetType)
            Using reader As New FileStream(FileName, FileMode.Open)
                Data = CType(xml.Deserialize(reader), List(Of ControlData))

            End Using

            Dim matches() As Control
            For Each cd As ControlData In Data
                matches = Me.Controls.Find(cd.ControlName, True)
                If matches.Length > 0 Then
                    CallByName(matches(0), cd.ControlProperty, CallType.Let, cd.ControlData)
                End If
            Next
        Else
            MsgBox("Do not exist Setting file " + FileName)
        End If

        Me.Hide()


    End Function

    Private Sub BTCUSTOMOK_Click(sender As Object, e As EventArgs) Handles BTCUSTOMOK.Click
        'SaveFormCustomEncOpt()
        If Not BOXCUSTOMCODECOPT.Text = "" Then
            Main.CUSTOMCODECOPT = ":" + BOXCUSTOMCODECOPT.Text
            BOXCUSTOMCODECOPTTEXT = BOXCUSTOMCODECOPT.Text
        Else
            Main.CUSTOMCODECOPT = BOXCUSTOMCODECOPT.Text
            BOXCUSTOMCODECOPTTEXT = BOXCUSTOMCODECOPT.Text
        End If

        If Not BOXCUSTOMVFILTEROPT.Text = "" Then
            Main.CUSTOMVIDEOFILTER = "," + BOXCUSTOMVFILTEROPT.Text
            CUSTOMVIDEOFILTERTEXT = BOXCUSTOMVFILTEROPT.Text
        Else
            Main.CUSTOMVIDEOFILTER = BOXCUSTOMVFILTEROPT.Text
            CUSTOMVIDEOFILTERTEXT = BOXCUSTOMVFILTEROPT.Text
        End If

        If Not BOXCUSTOMAUDFILTEROPT.Text = "" Then
            Main.CUSTOMAUDIOFILTER = "," + BOXCUSTOMAUDFILTEROPT.Text
            CUSTOMAUDIOFILTERTEXT = BOXCUSTOMAUDFILTEROPT.Text
        Else
            Main.CUSTOMAUDIOFILTER = BOXCUSTOMAUDFILTEROPT.Text
            CUSTOMAUDIOFILTERTEXT = BOXCUSTOMAUDFILTEROPT.Text
        End If

        If Not BOXCUSTOMFFMPEGOPT.Text = "" Then
            Main.CUSTOMFFMPEGOPT = " " + BOXCUSTOMFFMPEGOPT.Text + " "
            CUSTOMFFMPEGOPTTEXT = BOXCUSTOMFFMPEGOPT.Text
        Else
            Main.CUSTOMFFMPEGOPT = BOXCUSTOMFFMPEGOPT.Text
            CUSTOMFFMPEGOPTTEXT = BOXCUSTOMFFMPEGOPT.Text
        End If

        If Not BOXCUSTOMFFMPEGOPTF.Text = "" Then
            Main.CUSTOMFFMPEGOPTF = " " + BOXCUSTOMFFMPEGOPTF.Text + " "
            CUSTOMFFMPEGOPTTEXTF = BOXCUSTOMFFMPEGOPTF.Text
        Else
            Main.CUSTOMFFMPEGOPTF = BOXCUSTOMFFMPEGOPTF.Text
            CUSTOMFFMPEGOPTTEXTF = BOXCUSTOMFFMPEGOPTF.Text
        End If

        Me.Hide()
    End Sub


    Private Sub BTCUSTOMCANCEL_Click(sender As Object, e As EventArgs) Handles BTCUSTOMCANCEL.Click
        'ParsingsettingsFormCustomEncOpt()
        BOXCUSTOMCODECOPT.Text = BOXCUSTOMCODECOPTTEXT
        BOXCUSTOMVFILTEROPT.Text = CUSTOMVIDEOFILTERTEXT
        BOXCUSTOMAUDFILTEROPT.Text = CUSTOMAUDIOFILTERTEXT
        BOXCUSTOMFFMPEGOPT.Text = CUSTOMFFMPEGOPTTEXT
        BOXCUSTOMFFMPEGOPTF.Text = CUSTOMFFMPEGOPTTEXTF
        Me.Hide()
        'Me.Close()
    End Sub

    Private Sub FRMCUSTOMENC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ParsingsettingsFormCustomEncOpt()

    End Sub
End Class