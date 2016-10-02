Imports System.Xml

Public Class ChangePassword

    Private Sub B_Cancelar_Click(sender As Object, e As EventArgs) Handles B_Cancelar.Click
        Me.Hide()
        Principal.Focus()
    End Sub
    Private Sub TB_C_PSW_LostFocus(sender As Object, e As EventArgs) Handles TB_C_PSW.LostFocus
        If TB_N_PSW.Text <> TB_C_PSW.Text Then
            MsgBox("La contraseña no coincide")
            TB_N_PSW.Clear()
            TB_C_PSW.Clear()
            TB_N_PSW.Focus()
        End If
    End Sub
    Private Sub TB_N_PSW_LostFocus(sender As Object, e As EventArgs) Handles TB_N_PSW.LostFocus
        If TB_A_PSW.Text = TB_N_PSW.Text Then
            MsgBox("La contraseña no debe ser igual a la anterior")
            TB_A_PSW.Clear()
            TB_N_PSW.Clear()
            TB_A_PSW.Focus()
        End If
    End Sub

    Private Sub B_Actualizar_Click(sender As Object, e As EventArgs) Handles B_Actualizar.Click
        ConfirmarOperacionNIP.Show()
    End Sub
    Protected Friend Function ActualizacionPassword(ByVal NIPplain As String) As String
        Dim Ruta, Ruta2 As String
        Ruta = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\Documents\Fenix\" + Inicio.UsuarioConect + ".fnx"
        Ruta2 = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\Documents\Fenix\" + Inicio.UsuarioConect + ".Recovery"
        Try
            'Declaracion de variables de entorno
            Dim cuenta, recovery As XmlDocument
            Dim UsuarioAC, PasswordAC, PasswordRCY, email, SecretQuestion As XmlNode
            'Manipulacion de documentos XML con carga
            cuenta = New XmlDocument
            recovery = New XmlDocument
            cuenta.Load(Ruta)
            recovery.Load(Ruta2)
            'Lectura de NODOS para acceder al panel principal
            UsuarioAC = cuenta.SelectSingleNode("Fenix/Perfil/Usuario")
            PasswordAC = cuenta.SelectSingleNode("Fenix/Perfil/Password")
            PasswordRCY = recovery.SelectSingleNode("RecoveryFenix/SecretKey")
            email = cuenta.SelectSingleNode("/Fenix/Perfil/Email")
            SecretQuestion = cuenta.SelectSingleNode("/Fenix/Seguridad/Respuesta")

            If PasswordAC.InnerText <> LCase(SHA512(TB_A_PSW.Text + Inicio.UsuarioConect)) Then
                MsgBox("Tu contraseña es Incorrecta")
                TB_A_PSW.Clear()
                TB_N_PSW.Clear()
                TB_C_PSW.Clear()
                TB_A_PSW.Focus()
            Else
                'ACTUALIZACION A TODOS LOS PARAMETROS AFECTADOS
                ' USUARIO ** USUARIO ** USUARIO **
                UsuarioAC.InnerText = LCase(SHA512(Inicio.UsuarioConect + TB_N_PSW.Text))
                ' PASSWORD ** PASSWORD ** PASSWORD **
                PasswordAC.InnerText = LCase(SHA512(TB_N_PSW.Text + Inicio.UsuarioConect))
                ' PASSWORDRECOVERY ** PASSWORDRECOVERY ** PASSWORDRECOVER **
                PasswordRCY.InnerText = Encrypt(TB_N_PSW.Text, (Decode64(email.InnerText) + Decrypt(SecretQuestion.InnerText, NIPplain, Inicio.UsuarioConect) + NIPplain), Inicio.UsuarioConect)
                MsgBox("Contraseña Actualizada Correctamente")
            End If
            ' TERMINA ALMACENANDO TODOS LOS CAMBIOS
            cuenta.Save(Ruta)
            recovery.Save(Ruta2)
            Me.Hide()
            Principal.Focus()
            'Limpiar datos
            TB_A_PSW.Clear()
            TB_N_PSW.Clear()
            TB_C_PSW.Clear()
        Catch ex As Exception
            MessageBox.Show("Error Inesperado " & ex.Message)
        End Try

        Return 0
    End Function
End Class