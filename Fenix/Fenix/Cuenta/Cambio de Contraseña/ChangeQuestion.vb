Public Class ChangeQuestion

    Private Sub B_Cancelar_Click(sender As Object, e As EventArgs) Handles B_Cancelar.Click
        Me.Hide()
        Principal.Focus()
    End Sub

    Private Sub TB_NIP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TB_NIP.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TB_NIP_LostFocus(sender As Object, e As EventArgs) Handles TB_NIP.LostFocus
        If TB_NIP.TextLength < 4 Then
            MsgBox("Longitud Minima Invalida")
            TB_NIP.Clear()
            TB_NIP.Focus()
        End If
    End Sub

End Class