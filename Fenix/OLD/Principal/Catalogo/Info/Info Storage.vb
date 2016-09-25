Public Class Info_Storage

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Cancelar.Click
        CB_Capacidad_Unidad.ResetText()
        CB_Marca.ResetText()
        CB_Modelo.ResetText()
        CB_Tipo.ResetText()
        TB_Capacidad_Cifra.Clear()
        TB_DiscoDuro.Clear()
        TB_NumeroSerie.Clear()
        Me.Hide()
    End Sub

    
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Anotar.Click
        'Dim Servicio As Integer

    End Sub
End Class