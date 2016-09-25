Public Class Crear_cuenta


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Back.Click
        Me.Hide()
        Inicio.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles B_Registrar.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TB_Nombres.TextChanged
        B_Registrar.Enabled = TB_Nombres.Text.Length > 0 And TB_Apellidos.Text.Length > 0 And TB_Usuario.Text.Length > 0 And TB_pass.Text.Length > 0 And TB_password.Text.Length > 0
    End Sub
End Class