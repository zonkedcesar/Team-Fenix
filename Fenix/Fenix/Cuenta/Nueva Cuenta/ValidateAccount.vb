Imports System.Net.Mail

Public Class ValidateAccount

    Private Sub TB_Correo_LostFocus(sender As Object, e As EventArgs) Handles TB_Correo.LostFocus
        If Crear_cuenta.TB_Email.Text <> TB_Correo.Text Then
            MsgBox("El correo no coincide con el registro")
            TB_Correo.Clear()
            TB_Correo.Focus()
        End If
    End Sub

    Private Sub B_Validar_Click(sender As Object, e As EventArgs) Handles B_Inicio.Click
        MsgBox("Enviando Codigo de Validacion a su bandeja de entrada")
        Try

            Dim smtpserver As New SmtpClient()
            Dim mail As New MailMessage()
            smtpserver.Credentials = New Net.NetworkCredential(TB_Correo.Text.ToString, TB_PasswordSecure.Text.ToString)
            smtpserver.Port = 465
            smtpserver.Host = "mail.prosa.com.mx"
            mail = New MailMessage()
            mail.From = New MailAddress("Fenix@prosa.com.mx")
            mail.To.Add("Support Fenix")
            mail.Subject = "Codigo de Activacion"
            mail.Body = "Su codigo de activacion es: 12345"
            smtpserver.Send(mail)
            SaveAccount.Show()
            Me.Hide()
        Catch ex As Exception
            MsgBox(ex.ToString)
            Close()
        End Try
    End Sub
End Class