Imports Microsoft.VisualBasic

Public Class Wind
    Private _AktBR As Double

    Public Function GetAktBR() As Double
        Return _AktBR
    End Function

    Public Sub SetAktBR(AutoPropertyValue As Double)
        _AktBR = AutoPropertyValue
    End Sub

    '---------------------------------------------------------------------

    Private _AktWindRichtung As Double

    Public Function GetAktWindRichtung() As Double
        Return _AktWindRichtung
    End Function

    Public Sub SetAktWindRichtung(AutoPropertyValue As Double)
        _AktWindRichtung = AutoPropertyValue
    End Sub

    '---------------------------------------------------------------------

    Private _AktWindStaerke As Double

    Public Function GetAktWindStaerke() As Double
        Return _AktWindStaerke
    End Function

    Public Sub SetAktWindStaerke(AutoPropertyValue As Double)
        _AktWindStaerke = AutoPropertyValue
    End Sub

    '---------------------------------------------------------------------

    Private _WindDifferenz As Double

    Public Function GetWindDifferenz() As Double
        Return _WindDifferenz
    End Function

    '---------------------------------------------------------------------

    Public Sub SetWindDifferenz(AutoPropertyValue As Double)
        _WindDifferenz = AutoPropertyValue
    End Sub

    Private _RueckenWind As Double

    Public Function GetRueckenWind() As Double
        Return _RueckenWind
    End Function

    Public Sub SetRueckenWind(AutoPropertyValue As Double)
        _RueckenWind = AutoPropertyValue
    End Sub

    '---------------------------------------------------------------------
End Class
