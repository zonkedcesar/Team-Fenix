Imports System.Text.RegularExpressions
Module LevelPassword
    Public Function Medir(ByVal password As String) As Integer
        Dim intScore As Integer = 0
        Dim Longitud As Integer = 0
        ' Mayusculas, Minusculas y Numeros.
        Dim upper As New Regex("[A-Z]")
        Dim lower As New Regex("[a-z]")
        Dim number As New Regex("[0-9]")
        ' Caracteres Especiales.
        Dim special As New Regex("[^a-zA-Z0-9]")
        ' Puntuacion por longitun
        ' 40% Puntuacion Maxima + 18 Caracteres como Maximo
        If password.Length < 0 Then
            Longitud = 1
        Else
            Longitud = password.Length
        End If
        intScore = (Longitud * 20) / 18                              ' Tamaño
        intScore = intScore + ((upper.Matches(password).Count * 45) / Longitud)    ' Mayusculas
        intScore = intScore + ((lower.Matches(password).Count * 30) / Longitud)    ' Minusculas
        intScore = intScore + ((number.Matches(password).Count * 15) / Longitud)    ' Numeros
        intScore = intScore + ((special.Matches(password).Count * 80) / Longitud)  ' Especial
        ' No sobre pasar el 100% .
        If intScore > 100 Then
            intScore = 100
        End If
        Return intScore
    End Function
End Module