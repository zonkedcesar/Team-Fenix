Public Class useradd

    
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Comprobamos que ciertos 
        If TB_Nempleado.Text.Length < 0 Then
            TB_Nempleado.BackColor = Color.LightCoral
        End If
        If TB_Nombre.Text.Length < 0 Then
            TB_Nombre.BackColor = Color.LightCoral
        End If
        If TB_Apellidos.Text.Length < 0 Then
            TB_Apellidos.BackColor = Color.LightCoral
        End If
        If TB_Correo.Text.Length < 0 Then
            TB_Correo.BackColor = Color.LightCoral
        End If
        If TB_Usuario.Text.Length < 0 Then
            TB_Usuario.BackColor = Color.LightCoral
        End If
        If TB_NewPassword.Text.Length < 0 Then
            TB_NewPassword.BackColor = Color.LightCoral
        End If
        If TB_ConfirmPassword.Text.Length < 0 Then
            TB_ConfirmPassword.BackColor = Color.LightCoral
        End If

    End Sub
End Class