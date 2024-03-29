﻿Imports System.IO
Imports System.Xml.Serialization
Public Class AdvancedFRM
    Public LBMERANGE As String
    Public LBMEALGORITHM As String
    Public LBSR As String
    Public LBTR As String
    Public LBNOPSKIP As String
    Public LBNODCT As String
    Public LBAQMODE As String
    Public LBBFRAMES As String
    Public LBAQSTR As String
    Public LBDEBLOCK As String
    Public LBSCENE As String
    Public X264ADVOPT As String



    Private FileName As String = System.IO.Path.Combine(Application.StartupPath, "ADVENCSettings.xml")
    Private RevertXML As String = System.IO.Path.Combine(Application.StartupPath, "RevertADVENCSettings.xml")



    Private Sub Button1s_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1s.Click

        Dim Data As New List(Of ControlData)
        FindControls(Me, Data)

        Dim xml As New XmlSerializer(Data.GetType)
        Using writer As New FileStream(FileName, FileMode.Create)
            xml.Serialize(writer, Data)
        End Using

        LBMERANGE = ":merange=" + NMMERANGE.Text
        LBMEALGORITHM = ":me=" + BOXMEALGO.Text
        LBSR = ":subme=" + BOXSR.Text
        LBTR = ":trellis=" + BOXTR.Text
        LBNOPSKIP = ":no-fast-pskip=1"
        LBNODCT = ":no-dct-decimate=1"
        LBBFRAMES = ":bframes=" + BOXBFRAMES.Text
        LBAQMODE = ":aq-mode=" + BOXAQMODE.Text
        LBAQSTR = ":aq-strength=" + BOXAQSTR.Text
        LBDEBLOCK = " -deblock " + NMDBSTR.Text + ":" + NMDBTR.Text + " "
        LBSCENE = ":scenecut=" + BOXSCENE.Text

        Me.Hide()
        'CHECKADV.Checked = True

    End Sub
    Private Sub BTNCANCEL_Click(sender As System.Object, e As System.EventArgs) Handles BTNCANCEL.Click
        LoadPresetRevert()

        Me.Hide()
    End Sub

    Private Sub AdvancedFRM_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

    End Sub

    Private Sub AdvancedFRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Data As New List(Of ControlData)
        FindControls(Me, Data)

        Dim xml As New XmlSerializer(Data.GetType)
        Using writer As New FileStream(RevertXML, FileMode.Create)
            xml.Serialize(writer, Data)
        End Using

        LBMERANGE = ":merange=" + NMMERANGE.Text
        LBMEALGORITHM = ":me=" + BOXMEALGO.Text
        LBSR = ":subme=" + BOXSR.Text
        LBTR = ":trellis=" + BOXTR.Text
        LBNOPSKIP = ":no-fast-pskip=1"
        LBNODCT = ":no-dct-decimate=1"
        LBBFRAMES = ":bframes=" + BOXBFRAMES.Text
        LBAQMODE = ":aq-mode=" + BOXAQMODE.Text
        LBAQSTR = ":aq-strength=" + BOXAQSTR.Text
        LBDEBLOCK = " -deblock " + NMDBSTR.Text + ":" + NMDBTR.Text + " "
        LBSCENE = ":scenecut=" + BOXSCENE.Text


        'CHECKADV.Checked = True

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

            If TypeOf ctl Is CheckBox Then
                Dim CB As CheckBox = DirectCast(ctl, CheckBox)

                Dim cd As New ControlData
                cd.ControlName = ctl.Name
                cd.ControlProperty = "Checked"
                cd.ControlData = CB.Checked.ToString
                Data.Add(cd)


            End If


            If TypeOf ctl Is NumericUpDown Then
                Dim CB As NumericUpDown = DirectCast(ctl, NumericUpDown)

                Dim cd As New ControlData
                cd.ControlName = ctl.Name
                cd.ControlProperty = "Text"
                cd.ControlData = CB.Text.ToString
                Data.Add(cd)


            End If
        Next
    End Sub
    Public Function LoadPresetADV()
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

    Public Function LoadPresetRevert()
        If System.IO.File.Exists(RevertXML) Then
            Dim Data As New List(Of ControlData)
            Dim xml As New XmlSerializer(Data.GetType)
            Using reader As New FileStream(RevertXML, FileMode.Open)
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
    Public items As New List(Of ListViewItems)
    Public Structure ListViewItems

        Public column1 As String

        Public column2 As String

    End Structure
End Class
<Serializable()> Public Class ControlData
    Public ControlName As String
    Public ControlProperty As String
    Public ControlData As String



End Class