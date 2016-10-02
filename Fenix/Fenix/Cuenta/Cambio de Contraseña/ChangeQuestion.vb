Imports System.Xml

Public Class ChangeQuestion

    Private Sub B_Cancelar_Click(sender As Object, e As EventArgs) Handles B_Cancelar.Click
        Me.Hide()
        Principal.Focus()
    End Sub

    Private Sub TB_NIP_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub B_Actualizar_Click(sender As Object, e As EventArgs) Handles B_Actualizar.Click
        ConfirmacionTotal.Show()
    End Sub
    Protected Friend Function ActualizarPregunta(ByVal PassPlain As String, ByVal NIPPlain As String) As String
        Dim Ruta, Ruta2 As String
        Ruta = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\Documents\Fenix\" + Inicio.UsuarioConect + ".fnx"
        Ruta2 = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\Documents\Fenix\" + Inicio.UsuarioConect + ".Recovery"
        Try
            'Declaracion de variables de entorno
            Dim cuenta, recovery As XmlDocument
            Dim Pregunta, Respuesta, PasswordRCY, email As XmlNode
            'Manipulacion de documentos XML con carga
            cuenta = New XmlDocument
            recovery = New XmlDocument
            cuenta.Load(Ruta)
            recovery.Load(Ruta2)
            'Lectura de NODOS para acceder al panel principal
            Pregunta = cuenta.SelectSingleNode("Fenix/Seguridad/Pregunta")
            email = cuenta.SelectSingleNode("Fenix/Perfil/Email")
            Respuesta = cuenta.SelectSingleNode("Fenix/Seguridad/Respuesta")
            PasswordRCY = recovery.SelectSingleNode("RecoveryFenix/SecretKey")

            ' Password Recovery
            'pass + (EMAIL + Respuesta + NIP) + user
            PasswordRCY.InnerText = Encrypt(PassPlain, (Decode64(email.InnerText) + TB_Respuesta.Text + NIPPlain), Inicio.UsuarioConect)
            ' Nuevos valores para los parametros
            Pregunta.InnerText = Encode64(TB_P_Secure.Text)
            'respuesta + NIP + user
            Respuesta.InnerText = Encrypt(TB_Respuesta.Text, NIPPlain, Inicio.UsuarioConect)

            MsgBox("Pregunta de seguridad Actualizada correctamente")
            ' TERMINA ALMACENANDO TODOS LOS CAMBIOS
            cuenta.Save(Ruta)
            recovery.Save(Ruta2)
            Me.Hide()
            Principal.Focus()
            'Limpiar datos
            TB_P_Secure.Clear()
            TB_Respuesta.Clear()
        Catch ex As Exception
            MessageBox.Show("Error Inesperado " & ex.Message)
        End Try
        Return 0
    End Function
End Class