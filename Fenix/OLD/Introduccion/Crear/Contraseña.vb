Public Class Contraseña

    Private Sub Contraseña_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Seguro de tener llenado de campos
        B_PasswordUser.Enabled = False

        MsgBox("Tu contraseña debe contener un minimo de 8 caracteres")

        ' Area de sugerencias
        ToolTip1.SetToolTip(Tb_NewPass, "Nueva Contraseña")
        ToolTip1.SetToolTip(TB_ConfPass, "Confirma tu Contraseña")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles B_PasswordUser.Click
        ' Comprobar las contraseñas sean iguales
        If Tb_NewPass.Text = TB_ConfPass.Text Then
     
        Else
            MsgBox("La contraseñas no coinciden")
            Tb_NewPass.Text = ""
            TB_ConfPass.Text = ""
        End If
    End Sub

    Private Sub Tb_NewPass_TextChanged(sender As Object, e As EventArgs) Handles Tb_NewPass.TextChanged
        B_PasswordUser.Enabled = Tb_NewPass.TextLength > 0 And TB_ConfPass.TextLength > 0
    End Sub

    Private Sub TB_ConfPass_TextChanged(sender As Object, e As EventArgs) Handles TB_ConfPass.TextChanged
        B_PasswordUser.Enabled = Tb_NewPass.TextLength > 0 And TB_ConfPass.TextLength > 0
    End Sub
End Class