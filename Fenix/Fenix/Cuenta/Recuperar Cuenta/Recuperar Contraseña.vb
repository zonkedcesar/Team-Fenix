Imports System.Xml


Public Class Recuperar_Contraseña
    Private Function RecuperandoPassword(ByVal User As String, ByVal Email As String, ByVal Respuesta As String, ByVal NIP As String) As Integer
        Dim Ruta, Ruta2 As String
        Dim PassPlain As String
        Dim Resultado As Integer = 0
        Ruta = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\Documents\Fenix\" + User + ".fnx"
        Ruta2 = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\Documents\Fenix\" + User + ".Recovery"
        Try
            'Declaracion de variables de entorno
            Dim cuenta, recovery As XmlDocument
            Dim PasswordRecovery As XmlNode
            'Manipulacion de documentos XML con carga
            cuenta = New XmlDocument
            recovery = New XmlDocument
            cuenta.Load(Ruta)
            recovery.Load(Ruta2)
            'Lectura de NODOS para acceder al panel principal
            PasswordRecovery = recovery.SelectSingleNode("RecoveryFenix/SecretKey")
            Try
                PassPlain = Decrypt(PasswordRecovery.InnerText, Email + Respuesta + NIP, User)
            Catch ex As Exception
                Resultado = 1
            End Try
            If Resultado = 1 Then
                MsgBox("Los datos proporcionados son incorrectos, Por favor de validar la información.")
                TB_User.Focus()
            Else
                PassPlain = Decrypt(PasswordRecovery.InnerText, Email + Respuesta + NIP, User)
                MsgBox("La contraseña recuperada es: " + PassPlain)
                MsgBox("Tenga en cuenta que debe guardar su contraseña en un lugar seguro y actualizar su información")
                Me.Hide()
                Inicio.Show()
            End If

            ' TERMINACION DE PROCEDIMIENTO
            TB_User.Clear()
            TB_Email.Clear()
            Label_Pregunta.BackColor = Nothing
            Label_Pregunta.Text = "¿Quien es el creador de Fenix?"
            TB_Respuesta.Text = "Emmanuel Galeana"
            TB_NIP.Clear()
            TB_Respuesta.Enabled = False
            TB_NIP.Enabled = False
        Catch ex As Exception
            MessageBox.Show("Error Inesperado " & ex.Message)
        End Try
        Return 0
    End Function
    Private Function VerificandoDatosRecovery(ByVal User As String, ByVal Email As String)
        Dim Ruta, Ruta2 As String
        Ruta = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\Documents\Fenix\" + User + ".fnx"
        Ruta2 = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\Documents\Fenix\" + User + ".Recovery"
        Try
            'Declaracion de variables de entorno
            Dim cuenta, recovery As XmlDocument
            Dim Username, Correo, Pregunta As XmlNode
            'Manipulacion de documentos XML con carga
            cuenta = New XmlDocument
            recovery = New XmlDocument
            cuenta.Load(Ruta)
            recovery.Load(Ruta2)
            'Lectura de NODOS para acceder al panel principal
            Username = recovery.SelectSingleNode("RecoveryFenix/Usuario")
            Correo = cuenta.SelectSingleNode("Fenix/Perfil/Email")
            Pregunta = cuenta.SelectSingleNode("Fenix/Seguridad/Pregunta")
            If Username.InnerText <> LCase(SHA512(User)) Then
                MsgBox("Existe un problema con el archivo de su cuenta, por favor de verificar")
            ElseIf Correo.InnerText <> Encode64(Email) Then
                MsgBox("Existe un problema con el archivo Recovery de su cuenta, por favor de verificar")
            Else
                Label_Pregunta.Text = "¿" + Decode64(Pregunta.InnerText) + "?"
                Label_Pregunta.BackColor = Color.Yellow
                TB_Respuesta.Enabled = True
                TB_Respuesta.Clear()
                TB_NIP.Enabled = True
                TB_Respuesta.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show("Error Inesperado " & ex.Message)
        End Try
        Return 0
    End Function
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


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles B_Recuperacion.Click
        RecuperandoPassword(TB_User.Text, TB_Email.Text, TB_Respuesta.Text, TB_NIP.Text)
    End Sub

    Private Sub B_Cancelar_Click(sender As Object, e As EventArgs) Handles B_Cancelar.Click
        Me.Hide()
        Inicio.Show()
        TB_User.Clear()
        TB_Email.Clear()
        TB_Respuesta.Clear()
        TB_NIP.Clear()
    End Sub

    Private Sub TB_User_TextChanged(sender As Object, e As EventArgs) Handles TB_User.TextChanged
        B_Recuperacion.Enabled = TB_User.TextLength > 0 And TB_Email.TextLength > 0 And _
            TB_Respuesta.TextLength > 0 And TB_NIP.TextLength > 0
    End Sub
    Private Sub TB_Email_TextChanged(sender As Object, e As EventArgs) Handles TB_Email.TextChanged
        B_Recuperacion.Enabled = TB_User.TextLength > 0 And TB_Email.TextLength > 0 And _
            TB_Respuesta.TextLength > 0 And TB_NIP.TextLength > 0
    End Sub
    Private Sub TB_Respuesta_TextChanged(sender As Object, e As EventArgs) Handles TB_Respuesta.TextChanged
        B_Recuperacion.Enabled = TB_User.TextLength > 0 And TB_Email.TextLength > 0 And _
            TB_Respuesta.TextLength > 0 And TB_NIP.TextLength > 0
    End Sub
    Private Sub TB_NIP_TextChanged(sender As Object, e As EventArgs) Handles TB_NIP.TextChanged
        B_Recuperacion.Enabled = TB_User.TextLength > 0 And TB_Email.TextLength > 0 And _
            TB_Respuesta.TextLength > 0 And TB_NIP.TextLength > 0
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles B_Leer.Click
        If TB_User.TextLength > 0 And TB_Email.TextLength > 0 Then
            VerificandoDatosRecovery(TB_User.Text, TB_Email.Text)
        Else
            MsgBox("Por favor de complementar Username y/o Email")
        End If
    End Sub
End Class