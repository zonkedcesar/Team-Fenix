Imports System.Xml
Imports System.Text
Imports System.IO

Public Class changeNip

    Private Sub B_Cancelar_Click(sender As Object, e As EventArgs) Handles B_Cancelar.Click
        Me.Hide()
        Principal.Focus()
    End Sub

    Protected Friend Function ActualizacionNIP(ByVal PassPlaint As String) As String
        ' Obteniendo Ruta
        Dim Ruta, Ruta2 As String
        Ruta = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\Documents\Fenix\" + Inicio.UsuarioConect + ".fnx"
        Ruta2 = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\Documents\Fenix\" + Inicio.UsuarioConect + ".Recovery"

        'Dim nodelist As XmlNodeList
        'Dim nodo1 = nodo.ChildNodes(0).InnerText

        Try
            Dim documentoxml, documentoxml2 As XmlDocument
            Dim nip, email, SecretQuestion, SecretKey As XmlNode

            documentoxml = New XmlDocument
            documentoxml.Load(Ruta)
            nip = documentoxml.SelectSingleNode("/Fenix/Seguridad/NIP")

            'MsgBox(nodo.InnerText)
            If nip.InnerText <> LCase(SHA512(TB_A_NIP.Text + Inicio.UsuarioConect)) Then
                MsgBox("Tu NIP es incorrecto")
                TB_A_NIP.Clear()
                TB_A_NIP.Focus()
            Else
                ' PROCESO DE ACTUALIZACION DE NIP EN LA BASE DE DATOS
                nip.InnerText = LCase(SHA512(TB_C_NIP.Text + Inicio.UsuarioConect))

                ' PROCESO DE ACTUALIZACION DE CREDENCIALES DENTRO DE LAS CUALES SE VE AFECTADO

                ' PASSRECOVERY ** PASSRECOVERY ** PASSRECOVERY ** PASSRECOVERY **
                documentoxml2 = New XmlDocument
                documentoxml2.Load(Ruta2)

                email = documentoxml.SelectSingleNode("/Fenix/Perfil/Email")
                SecretKey = documentoxml2.SelectSingleNode("/RecoveryFenix/SecretKey")
                SecretQuestion = documentoxml.SelectSingleNode("/Fenix/Seguridad/Respuesta")
                SecretKey.InnerText = Encrypt(PassPlaint, (Decode64(email.InnerText) + Decrypt(SecretQuestion.InnerText, TB_A_NIP.Text, Inicio.UsuarioConect) + TB_C_NIP.Text), Inicio.UsuarioConect)

                ' PREGUNTA ** PREGUNTA ** PREGUNTA ** PREGUNTA ** PREGUNTA **
                SecretQuestion.InnerText = Encrypt(Decrypt(SecretQuestion.InnerText, TB_A_NIP.Text, Inicio.UsuarioConect), TB_C_NIP.Text, Inicio.UsuarioConect)

                ' BARRIDO DE CONTRASEÑAS ** BARRIDO DE CONTRASEÑAS ** BARRIDO DE CONTRASEÑAS **

                ' TERMINA ALMACENANDO TODOS LOS CAMBIOS
                documentoxml.Save(Ruta)
                documentoxml2.Save(Ruta2)
                Me.Hide()
                Principal.Focus()
                MsgBox("NIP Actualizado Correctamente")
                'Limpiar valores
                TB_A_NIP.Clear()
                TB_N_NIP.Clear()
                TB_C_NIP.Clear()
            End If
        Catch ex As Exception
            MessageBox.Show("Error Inesperado " & ex.Message)
        End Try
        Return 0
    End Function


    Private Sub B_Actualizar_Click(sender As Object, e As EventArgs) Handles B_Actualizar.Click
        Confirmar_Operacion.Interacion = 1
        Confirmar_Operacion.Show()
    End Sub

    ' APARTADO PARA VALIDAR QUE SOLO SE INGRESEN NUMEROS EN NIP
    Private Sub TB_A_NIP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TB_A_NIP.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TB_N_NIP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TB_N_NIP.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TB_C_NIP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TB_C_NIP.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    ' APARTADO PARA VALIDAR QUE EL NIP TIENE MINIMO 4 DIGITOS
    Private Sub TB_A_NIP_LostFocus(sender As Object, e As EventArgs) Handles TB_A_NIP.LostFocus
        If TB_A_NIP.TextLength < 4 Then
            MsgBox("El NIP se compone de 4 digitos")
            TB_A_NIP.Clear()
            TB_A_NIP.Focus()
        End If
    End Sub

    Private Sub TB_N_NIP_LostFocus(sender As Object, e As EventArgs) Handles TB_N_NIP.LostFocus
        If TB_N_NIP.TextLength < 4 Then
            MsgBox("El NIP se compone de 4 digitos")
            TB_N_NIP.Clear()
            TB_N_NIP.Focus()
        End If
    End Sub

    Private Sub TB_C_NIP_LostFocus(sender As Object, e As EventArgs) Handles TB_C_NIP.LostFocus
        If TB_C_NIP.TextLength < 4 Then
            MsgBox("El NIP se compone de 4 digitos")
            TB_C_NIP.Clear()
            TB_C_NIP.Focus()
        End If
    End Sub

End Class