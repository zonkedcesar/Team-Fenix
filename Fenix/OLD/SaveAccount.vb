Public Class SaveAccount

    Private Sub B_Validar_Click(sender As Object, e As EventArgs) Handles B_Validar.Click
        If ValidateAccount.CODIGO <> TB_C_Codigo.Text Then
            MsgBox("El codigo Proporcionado es Incorrecto")
            TB_C_Codigo.Clear()
            TB_C_Codigo.Focus()
        End If
    End Sub
End Class