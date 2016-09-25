Public Class Añadir_IP

    Private Sub Añadir_IP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If CB_TipoIp.Items.Count > 0 Then
            CB_TipoIp.SelectedIndex = 0    ' The first item has index 0 '
        End If
    End Sub
End Class