Public Class Confirmar_Operacion

    Protected Friend Interacion As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Interacion = 1 Then
            changeNip.ActualizacionNIP(TB_Conf_Pass.Text)
        ElseIf Interacion = 2 Then

        ElseIf Interacion = 3 Then

        Else
            MsgBox("Ocurrio un problema en la interaccion de confirmacion")
        End If
    End Sub
End Class