Public Class Confirmar_Operacion

    Protected Friend Interacion As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles B_Confirmar_PSW.Click

        changeNip.ActualizacionNIP(TB_Conf_Pass.Text)

        TB_Conf_Pass.Clear()
        Me.Hide()
    End Sub

    Private Sub Confirmar_Operacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TB_Conf_Pass.Focus()
    End Sub
End Class