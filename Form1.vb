Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim aktBR As Double
        Dim aktWindRichtung As Double
        Dim aktWindStaerke As Double
        Dim WindDifferenz As Double
        Dim RueckenWind As Double

        aktBR = TextBox1.Text * 10
        aktWindRichtung = TextBox2.Text
        aktWindStaerke = TextBox3.Text

        If aktWindRichtung >= aktBR - 260 And aktWindRichtung <= aktBR - 180 Then
            WindDifferenz = aktBR - aktWindRichtung - 180
        ElseIf aktWindRichtung <= aktBR - 100 And aktWindRichtung >= aktBR - 180 Then
            WindDifferenz = aktWindRichtung + 180 - aktBR
        End If

        If WindDifferenz <= 80 Then
            RueckenWind = Math.Round(aktWindStaerke * Math.Cos(Math.PI / 180 * WindDifferenz), 2)
        End If

        If RueckenWind <= 5 Then
            TextBox4.BackColor = Color.Green
        Else
            TextBox4.BackColor = Color.Red
        End If

        TextBox4.Text = RueckenWind
    End Sub

    Private Sub TrackBar2_Scroll(sender As Object, e As EventArgs) Handles TrackBar2.Scroll
        TextBox3.Text = TrackBar2.Value
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        TextBox2.Text = TrackBar1.Value * 10
    End Sub
End Class
