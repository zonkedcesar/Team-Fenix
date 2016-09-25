Public Class Crear_cuenta


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Back.Click
        Me.Hide()
        Inicio.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles B_Registrar.Click
        MsgBox("Debe tener acceso a su cuenta de correo")
        ValidateAccount.Show()
    End Sub


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TB_Nombres.TextChanged
        B_Registrar.Enabled = TB_Nombres.Text.Length > 0 And TB_Apellidos.Text.Length > 0 And _
        TB_Usuario.Text.Length > 0 And TB_Email.Text.Length > 0 And TB_pass.Text.Length > 0 And _
        TB_password.Text.Length > 0 And TB_Pregunta.Text.Length > 0 And TB_Respuesta.Text.Length > 0 And _
        TB_NIP.Text.Length > 0 And TB_C_NIP.Text.Length > 0
    End Sub


    Private Sub TB_Apellidos_TextChanged(sender As Object, e As EventArgs) Handles TB_Apellidos.TextChanged
        B_Registrar.Enabled = TB_Nombres.Text.Length > 0 And TB_Apellidos.Text.Length > 0 And _
        TB_Usuario.Text.Length > 0 And TB_Email.Text.Length > 0 And TB_pass.Text.Length > 0 And _
        TB_password.Text.Length > 0 And TB_Pregunta.Text.Length > 0 And TB_Respuesta.Text.Length > 0 And _
        TB_NIP.Text.Length > 0 And TB_C_NIP.Text.Length > 0
    End Sub

    Private Sub TB_Usuario_TextChanged(sender As Object, e As EventArgs) Handles TB_Usuario.TextChanged
        B_Registrar.Enabled = TB_Nombres.Text.Length > 0 And TB_Apellidos.Text.Length > 0 And _
        TB_Usuario.Text.Length > 0 And TB_Email.Text.Length > 0 And TB_pass.Text.Length > 0 And _
        TB_password.Text.Length > 0 And TB_Pregunta.Text.Length > 0 And TB_Respuesta.Text.Length > 0 And _
        TB_NIP.Text.Length > 0 And TB_C_NIP.Text.Length > 0
    End Sub

    Private Sub TB_Email_TextChanged(sender As Object, e As EventArgs) Handles TB_Email.TextChanged
        B_Registrar.Enabled = TB_Nombres.Text.Length > 0 And TB_Apellidos.Text.Length > 0 And _
        TB_Usuario.Text.Length > 0 And TB_Email.Text.Length > 0 And TB_pass.Text.Length > 0 And _
        TB_password.Text.Length > 0 And TB_Pregunta.Text.Length > 0 And TB_Respuesta.Text.Length > 0 And _
        TB_NIP.Text.Length > 0 And TB_C_NIP.Text.Length > 0
    End Sub

    Private Sub TB_pass_TextChanged(sender As Object, e As EventArgs) Handles TB_pass.TextChanged
        B_Registrar.Enabled = TB_Nombres.Text.Length > 0 And TB_Apellidos.Text.Length > 0 And _
        TB_Usuario.Text.Length > 0 And TB_Email.Text.Length > 0 And TB_pass.Text.Length > 0 And _
        TB_password.Text.Length > 0 And TB_Pregunta.Text.Length > 0 And TB_Respuesta.Text.Length > 0 And _
        TB_NIP.Text.Length > 0 And TB_C_NIP.Text.Length > 0
    End Sub

    Private Sub TB_password_LostFocus(sender As Object, e As EventArgs) Handles TB_password.LostFocus
        If TB_pass.Text <> TB_password.Text Then
            MsgBox("La contraseña no coincide")
            TB_pass.Clear()
            TB_password.Clear()
            TB_pass.Focus()
        End If
    End Sub


    Private Sub TB_C_NIP_LostFocus(sender As Object, e As EventArgs) Handles TB_C_NIP.LostFocus
        If TB_NIP.Text <> TB_C_NIP.Text Then
            MsgBox("El NIP no coincide")
            TB_NIP.Clear()
            TB_C_NIP.Clear()
            TB_NIP.Focus()
        End If
    End Sub

    Private Sub TB_password_TextChanged(sender As Object, e As EventArgs) Handles TB_password.TextChanged
        B_Registrar.Enabled = TB_Nombres.Text.Length > 0 And TB_Apellidos.Text.Length > 0 And _
        TB_Usuario.Text.Length > 0 And TB_Email.Text.Length > 0 And TB_pass.Text.Length > 0 And _
        TB_password.Text.Length > 0 And TB_Pregunta.Text.Length > 0 And TB_Respuesta.Text.Length > 0 And _
        TB_NIP.Text.Length > 0 And TB_C_NIP.Text.Length > 0
    End Sub

    Private Sub TB_Pregunta_Enter(sender As Object, e As EventArgs) Handles TB_Pregunta.Enter
        TB_Pregunta.Clear()
    End Sub


    Private Sub TB_Pregunta_TextChanged(sender As Object, e As EventArgs) Handles TB_Pregunta.TextChanged
        B_Registrar.Enabled = TB_Nombres.Text.Length > 0 And TB_Apellidos.Text.Length > 0 And _
        TB_Usuario.Text.Length > 0 And TB_Email.Text.Length > 0 And TB_pass.Text.Length > 0 And _
        TB_password.Text.Length > 0 And TB_Pregunta.Text.Length > 0 And TB_Respuesta.Text.Length > 0 And _
        TB_NIP.Text.Length > 0 And TB_C_NIP.Text.Length > 0
    End Sub

    Private Sub TB_Respuesta_Enter(sender As Object, e As EventArgs) Handles TB_Respuesta.Enter
        TB_Respuesta.Clear()
    End Sub

    Private Sub TB_Respuesta_TextChanged(sender As Object, e As EventArgs) Handles TB_Respuesta.TextChanged
        B_Registrar.Enabled = TB_Nombres.Text.Length > 0 And TB_Apellidos.Text.Length > 0 And _
        TB_Usuario.Text.Length > 0 And TB_Email.Text.Length > 0 And TB_pass.Text.Length > 0 And _
        TB_password.Text.Length > 0 And TB_Pregunta.Text.Length > 0 And TB_Respuesta.Text.Length > 0 And _
        TB_NIP.Text.Length > 0 And TB_C_NIP.Text.Length > 0
    End Sub

    Private Sub TB_NIP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TB_NIP.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub TB_C_NIP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TB_C_NIP.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TB_NIP_TextChanged(sender As Object, e As EventArgs) Handles TB_NIP.TextChanged
        B_Registrar.Enabled = TB_Nombres.Text.Length > 0 And TB_Apellidos.Text.Length > 0 And _
        TB_Usuario.Text.Length > 0 And TB_Email.Text.Length > 0 And TB_pass.Text.Length > 0 And _
        TB_password.Text.Length > 0 And TB_Pregunta.Text.Length > 0 And TB_Respuesta.Text.Length > 0 And _
        TB_NIP.Text.Length > 0 And TB_C_NIP.Text.Length > 0
    End Sub



    Private Sub TB_C_NIP_TextChanged(sender As Object, e As EventArgs) Handles TB_C_NIP.TextChanged
        B_Registrar.Enabled = TB_Nombres.Text.Length > 0 And TB_Apellidos.Text.Length > 0 And _
        TB_Usuario.Text.Length > 0 And TB_Email.Text.Length > 0 And TB_pass.Text.Length > 0 And _
        TB_password.Text.Length > 0 And TB_Pregunta.Text.Length > 0 And TB_Respuesta.Text.Length > 0 And _
        TB_NIP.Text.Length > 0 And TB_C_NIP.Text.Length > 0
    End Sub
End Class