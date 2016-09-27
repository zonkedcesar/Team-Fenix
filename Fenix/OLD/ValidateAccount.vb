Imports System.Net.Mail

Public Class ValidateAccount

    
    Protected Friend CODIGO As Integer
    Private Sub B_Validar_Click(sender As Object, e As EventArgs) Handles B_Inicio.Click
        MsgBox("Enviando Codigo de Validacion a su bandeja de entrada")
        MsgBox(TB_Correo.Text + ":" + TB_PasswordSecure.Text)
        Try

            Dim smtpserver As New SmtpClient()
            Dim mail As New MailMessage()

            smtpserver.Credentials = New Net.NetworkCredential(TB_Correo.Text, TB_PasswordSecure.Text)
            smtpserver.Port = "25"
            smtpserver.Host = "mail.prosa.com.mx"
            mail = New MailMessage()
            mail.From = New MailAddress("fenix@prosa.com.mx")
            mail.To.Add(TB_Correo.Text)
            mail.Subject = "Codigo de Activacion"
            CODIGO = 1234
            mail.Body = "Su codigo de activacion es: " + CODIGO.ToString
            smtpserver.Send(mail)
            SaveAccount.Show()
            Me.Hide()
        Catch ex As Exception
            MsgBox(ex.ToString)
            Close()
        End Try
    End Sub

    Private Sub ValidateAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TB_Correo.Text = Crear_cuenta.TB_Email.Text + "@prosa.com.mx"
        TB_Correo.Enabled = False
    End Sub
End Class