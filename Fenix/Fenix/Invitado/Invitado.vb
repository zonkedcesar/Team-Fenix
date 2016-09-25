Public Class Invitado

    Private Sub B_Analizar_Click(sender As Object, e As EventArgs) Handles B_Analizar.Click
        Me.Hide()
        Analizar_Contraseña_Invitado.Show()
    End Sub

    Private Sub B_Generar_Click(sender As Object, e As EventArgs) Handles B_Generar.Click
        Me.Hide()
        Generador_Invitado.Show()
    End Sub
End Class