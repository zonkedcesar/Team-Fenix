Imports System.Xml

Public Class changeNip

    Private Sub B_Cancelar_Click(sender As Object, e As EventArgs) Handles B_Cancelar.Click
        Me.Hide()
        Principal.Focus()
    End Sub

    Private Sub B_Actualizar_Click(sender As Object, e As EventArgs) Handles B_Actualizar.Click
        ' Obteniendo Ruta
        Dim Ruta As String
        Ruta = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\Documents\Fenix\" + Inicio.UsuarioConect + ".fnx"

        'Dim nodelist As XmlNodeList
        'Dim nodo1 = nodo.ChildNodes(0).InnerText

        Try
            Dim documentoxml As XmlDocument
            Dim nodo As XmlNode

            documentoxml = New XmlDocument
            documentoxml.Load(Ruta)
            nodo = documentoxml.SelectSingleNode("/Fenix/Seguridad/NIP")
            'MsgBox(nodo.InnerText)
            If nodo.InnerText <> LCase(SHA512(TB_A_NIP.Text + Inicio.UsuarioConect)) Then
                MsgBox(LCase(SHA512(TB_A_NIP.Text + Inicio.UsuarioConect)))
                MsgBox("Tu NIP es incorrecto")
                TB_A_NIP.Clear()
                TB_A_NIP.Focus()
            Else
                ' PROCESO DE ACTUALIZACION DE NIP EN LA BASE DE DATOS
                nodo.InnerText = LCase(SHA512(TB_C_NIP.Text + Inicio.UsuarioConect))

                ' PROCESO DE ACTUALIZACION DE CREDENCIALES DENTRO DE LAS CUALES SE VE AFECTADO 

                ' PASSRECOVERY

                ' PREGUNTA

                ' BARRIDO DE CONTRASEÑAS

                ' TERMINA ALMACENANDO TODOS LOS CAMBIOS
                documentoxml.Save(Ruta)
                MsgBox("NIP Actualizado Correctamente")
                Me.Hide()
                Principal.Focus()
            End If

        Catch ex As Exception
            MessageBox.Show("Error Inesperado " & ex.Message)
        End Try
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