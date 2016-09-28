Public Class Recuperar_Contraseña

    Private Sub TB_NIP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TB_NIP.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub TB_NIP_LostFocus(sender As Object, e As EventArgs) Handles TB_NIP.LostFocus
        If TB_NIP.TextLength < 4 Then
            MsgBox("Debe cumplir con minimo 4 digitos")
            TB_NIP.Clear()
            TB_NIP.Focus()
        End If
    End Sub

    Private Sub B_File_Account_Click(sender As Object, e As EventArgs) Handles B_File_Account.Click
        ' Habilitando parte Inferior
        TB_Respuesta.Enabled = True
        TB_NIP.Enabled = True

    End Sub
End Class