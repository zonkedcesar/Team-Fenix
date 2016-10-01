Imports System.Text

Public Class Crear_cuenta


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Back.Click
        Me.Hide()
        Inicio.Show()
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

    Private Sub TB_pass_LostFocus(sender As Object, e As EventArgs) Handles TB_pass.LostFocus
        If TB_pass.TextLength < 6 Then
            MsgBox("La contraseña debe contener un minimo de 6 caracteres")
            TB_pass.Clear()
            TB_pass.Focus()
        End If
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

    Private Sub TB_NIP_LostFocus(sender As Object, e As EventArgs) Handles TB_NIP.LostFocus
        If TB_NIP.TextLength < 4 Then
            MsgBox("El NIP debe ser obligatoriamente de 4 digitos")
            TB_NIP.Clear()
            TB_NIP.Focus()
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

    Private Sub B_Registrar_Click(sender As Object, e As EventArgs) Handles B_Registrar.Click
        Dim obj As Object
        Dim archivo As Object
        Dim x As Integer = 0
        Dim Ruta As String
        Try
            obj = CreateObject("Scripting.FileSystemObject")
            Ruta = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\Documents\Fenix\" + TB_Usuario.Text + ".fnx"
            archivo = obj.CreateTextFile(Ruta, True)
            archivo.WriteLine("<?xml version='1.0' encoding='utf-8'?>")
            archivo.WriteLine("<Fenix>")
            archivo.WriteLine("<Personal>")
            archivo.WriteLine("<Nombre>" + TB_Nombres.Text + "</Nombre>")
            archivo.WriteLine("<Apellido>" + TB_Apellidos.Text + "</Apellido>")
            archivo.WriteLine("</Personal>")
            archivo.WriteLine("<Perfil>")
            'USUARIO + CONTRASEÑA
            archivo.WriteLine("<Usuario>" + LCase(SHA512(TB_Usuario.Text + TB_pass.Text)) + "</Usuario>")

            archivo.WriteLine("<Email>" + Encode64(TB_Email.Text) + "</Email>")
            'CONTRASEÑA + USUARIO
            archivo.WriteLine("<Password>" + LCase(SHA512(TB_pass.Text + TB_Usuario.Text)) + "</Password>")
            archivo.WriteLine("</Perfil>")
            archivo.WriteLine("<Seguridad>")

            archivo.WriteLine("<Pregunta>" + Encode64(TB_Pregunta.Text) + "</Pregunta>")
            'Respuesta + NIP + Usuario
            archivo.WriteLine("<Respuesta>" + Encrypt(TB_Respuesta.Text, TB_NIP.Text, TB_Usuario.Text) + "</Respuesta>")
            archivo.WriteLine("<NIP>" + LCase(SHA512(TB_NIP.Text + TB_Usuario.Text)) + "</NIP>")
            archivo.WriteLine("</Seguridad>")
            archivo.WriteLine("</Fenix>")
        Catch ex As Exception
            MessageBox.Show("No se pudo crear la cuenta " & ex.Message)
        End Try
        Try
            obj = CreateObject("Scripting.FileSystemObject")
            Ruta = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\Documents\Fenix\" + TB_Usuario.Text + ".Recovery"
            archivo = obj.CreateTextFile(Ruta, True)
            archivo.WriteLine("<?xml version='1.0' encoding='utf-8'?>")
            archivo.WriteLine("<RecoveryFenix>")
            archivo.WriteLine("<Usuario>" + LCase(SHA512(TB_Usuario.Text)) + "</Usuario>")
            archivo.WriteLine("<SecretKey>" + Encrypt(TB_pass.Text, (TB_Email.Text + TB_Respuesta.Text + TB_NIP.Text), TB_Usuario.Text) + "</SecretKey>")
            archivo.WriteLine("</RecoveryFenix>")
        Catch ex As Exception
            MessageBox.Show("No se pudo generar llave de recuperacion la cuenta " & ex.Message)
        End Try
        MsgBox("Usuario Creado Correctamente")
        Me.Hide()
        'Limpia todas las variables y obtiene el foco en el primer elemento
        TB_Nombres.Clear()
        TB_Apellidos.Clear()
        TB_Usuario.Clear()
        TB_Email.Clear()
        TB_pass.Clear()
        TB_password.Clear()
        TB_Pregunta.Clear()
        TB_Respuesta.Clear()
        TB_NIP.Clear()
        TB_C_NIP.Clear()
        TB_Nombres.Focus()
        ' Establece foco en otro punto
        Inicio.Show()
        Inicio.usr.Text = TB_Usuario.Text
    End Sub

    
End Class