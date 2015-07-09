Imports System.IO
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
    Public LBFADE As String
    Public LBSCENE As String


    Private FileName As String = System.IO.Path.Combine(Application.StartupPath, "ADVENCSettings.xml")


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
        LBFADE = ":fade_compensate=" + BOXFADE.Text
        LBSCENE = ":scenecut=" + BOXSCENE.Text

        Me.Hide()

    End Sub
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub

    Private Sub AdvancedFRM_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

    End Sub

    Private Sub AdvancedFRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
                    CallByName(matches(0), cd.ControlProperty, CallType.Let, cd.ControlData) ' <-- this could also be done using proper REFLECTION!
                End If
            Next
        End If

    End Sub
    Private Sub FindControls(ByVal cont As Control, ByVal Data As List(Of ControlData))
        For Each ctl As Control In cont.Controls
            If TypeOf ctl Is ComboBox Then
                Dim CB As ComboBox = DirectCast(ctl, ComboBox)
                If Not IsNothing(CB.SelectedItem) Then
                    Dim cd As New ControlData
                    cd.ControlName = ctl.Name
                    cd.ControlProperty = "SelectedItem"
                    cd.ControlData = CB.SelectedItem.ToString
                    Data.Add(cd)
                End If
            ElseIf ctl.HasChildren Then
                FindControls(ctl, Data)
            End If
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

End Class
<Serializable()> Public Class ControlData
    Public ControlName As String
    Public ControlProperty As String
    Public ControlData As String
End Class