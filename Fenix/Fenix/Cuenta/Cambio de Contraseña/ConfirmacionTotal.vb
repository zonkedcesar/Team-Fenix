Public Class ConfirmacionTotal

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles B_Confirmar.Click
        ChangeQuestion.ActualizarPregunta(TB_Pass.Text, TB_NIP.Text)
        Me.Hide()
        TB_NIP.Clear()
        TB_Pass.Clear()
        Principal.Focus()
    End Sub
End Class