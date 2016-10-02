Public Class ConfirmarOperacionNIP
    Protected Friend Interacion As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles B_ConfirmarNIP.Click
        ChangePassword.ActualizacionPassword(TB_NIP.Text)
        Me.Hide()
        TB_NIP.Clear()
    End Sub
    Private Sub TB_NIP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TB_NIP.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub ConfirmarOperacionNIP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TB_NIP.Focus()
    End Sub
End Class