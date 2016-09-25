Public Class List_Pass
    Dim Dificultad As Integer = 0
    Private Sub B_Back_Click(sender As Object, e As EventArgs) Handles B_Back.Click
        Me.Hide()
        ListB_Pass.Items.Clear()
    End Sub

    Private Sub ListB_Pass_Click(sender As Object, e As EventArgs) Handles ListB_Pass.Click
        ' Inicia el Tester de dificultad para la password 
        If ListB_Pass.Text = "******   Lista Generada   ******" Then
            ProgressBar1.Value = 0
            LevelPass.Text = "Dificultad: ?"
        Else
            Dificultad = LevelPassword.Medir(ListB_Pass.Text)

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
                LevelPass.Text = "Contraseña Vacio"
            End If
            ProgressBar1.Minimum = 0%
            ProgressBar1.Maximum = 100%
            ProgressBar1.Value = Dificultad%
        End If
    End Sub
End Class