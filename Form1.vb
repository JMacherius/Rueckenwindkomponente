Public Class Form1

    Dim windObj As New Wind
    Dim flag As Boolean

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Berechnung()
    End Sub

    Private Sub TrackBar2_Scroll(sender As Object, e As EventArgs) Handles TrackBar2.Scroll
        Try
            TextBox3.Text = TrackBar2.Value
        Catch ex As InvalidCastException

        End Try
        Berechnung()
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        Try
            TextBox2.Text = TrackBar1.Value * 10
        Catch ex As InvalidCastException

        End Try

        Berechnung()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Try
            TrackBar1.Value = TextBox2.Text / 10
        Catch ex As InvalidCastException

        End Try

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        Try
            TrackBar2.Value = TextBox3.Text
        Catch ex As Exception

        End Try

    End Sub
    Private Sub Berechnung()

        '------------------------------------------------
        Try
                windObj.SetAktBR(TextBox1.Text * 10)
            Catch ex As InvalidCastException
                MsgBox("Nur Zahlen erlaubt!")
            TextBox1.Text = 0
        End Try
        '------------------------------------------------
        Try
            windObj.SetAktWindRichtung(TextBox2.Text)
        Catch ex As InvalidCastException
            MsgBox("Nur Zahlen erlaubt!")
            TextBox2.Text = 0
        End Try
        '------------------------------------------------
        Try
            windObj.SetAktWindStaerke(TextBox3.Text)
        Catch ex As InvalidCastException
            MsgBox("Nur Zahlen erlaubt!")
            TextBox3.Text = 0
        End Try
        '------------------------------------------------

        If windObj.GetAktWindRichtung() >= windObj.GetAktBR() - 260 And windObj.GetAktWindRichtung() <= windObj.GetAktBR() - 180 Then
            windObj.SetWindDifferenz(windObj.GetAktBR() - windObj.GetAktWindRichtung() - 180)
        ElseIf windObj.GetAktWindRichtung() <= windObj.GetAktBR() - 100 And windObj.GetAktWindRichtung() >= windObj.GetAktBR() - 180 Then
            windObj.SetWindDifferenz(windObj.GetAktWindRichtung() + 180 - windObj.GetAktBR())
        End If

        If windObj.GetWindDifferenz() <= 80 Then
            windObj.SetRueckenWind(Math.Round(windObj.GetAktWindStaerke() * Math.Cos(Math.PI / 180 * windObj.GetWindDifferenz()), 2))
        End If

        If windObj.GetRueckenWind() <= 5 Then
            TextBox4.BackColor = Color.Green
        Else
            TextBox4.BackColor = Color.Red
        End If

        TextBox4.Text = windObj.GetRueckenWind()
    End Sub

End Class
