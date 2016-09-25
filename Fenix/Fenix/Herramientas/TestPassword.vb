Public Class TestPassword

    Dim EstadoVisible As Integer = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles validar.Click
        If testpsw.Text.Length <= 0 Then
            MsgBox("Ingresa Contraseña")
        Else
            Dim Dificultad As Integer = 0
            Dificultad = LevelPassword.Medir(testpsw.Text)

            If Dificultad > 5 And Dificultad <= 35 Then
                LevelPass.Text = "Dificultad: Facil "
            ElseIf Dificultad > 35 And Dificultad <= 50 Then
                LevelPass.Text = "Dificultad: Regular "
            ElseIf Dificultad > 50 And Dificultad <= 75 Then
                LevelPass.Text = "Dificultad: Media "
            ElseIf Dificultad > 75 And Dificultad <= 90 Then
                LevelPass.Text = "Dificultad: Alta "
            ElseIf Dificultad > 90 And Dificultad <= 100 Then
                LevelPass.Text = "Dificultad: Muy Alta "
            Else
                LevelPass.Text = "Un chino la tiene mas grande xD"
            End If
            ProgressBar1.Minimum = 0%
            ProgressBar1.Maximum = 100%
            ProgressBar1.Value = Dificultad%

        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Principal.Show()
        Me.Hide()

    End Sub

    Private Sub VerPass_Click(sender As Object, e As EventArgs) Handles VerPass.Click
        If testpsw.Text.Length <= 0 Then
            MsgBox("Contraseña Vacia")
        Else
            ' Muestra o Esconde La contraseña al Usuario
            If EstadoVisible = 0 Then
                testpsw.PasswordChar = ""
                EstadoVisible = 1
            Else
                testpsw.PasswordChar = "*"
                EstadoVisible = 0
            End If
        End If
    End Sub

End Class