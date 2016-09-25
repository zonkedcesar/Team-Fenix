Public Class RegistroRack

    Private Sub Registrar_Click(sender As Object, e As EventArgs) Handles Registrar.Click
        Dim Sig As Integer
        If (TB_Numero_Rack.Text.Length > 0) Then
            Dim cmd As SqlClient.SqlCommand
            SQL.Con_BD.Open()
            Try
                cmd = New SqlClient.SqlCommand("INSERT INTO Racks (Numero_rack,Nombre_rack,Numero_Hilera,id_site) VALUES (@N_Rack,@Nom_Rack,@N_Hile,@Site)", Con_BD)
                With cmd.Parameters
                    .AddWithValue("@N_Rack", TB_Numero_Rack.Text.ToString)
                    .AddWithValue("@Nom_Rack", TB_Nombre.Text.ToString)
                    .AddWithValue("@N_Hile", CB_Numero_Hilera.Text.ToString)
                    .AddWithValue("@Site", CB_Site.Text.ToString)
                End With
                cmd.ExecuteNonQuery()
                SQL.Con_BD.Close()
                Sig = 1
            Catch ex As System.Data.SqlClient.SqlException
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("Es necesario el siguiente campo: Numero Rack")
        End If
        If (Sig = 1) Then
            MsgBox("Registro Completo")
            TB_Numero_Rack.Clear()
            TB_Nombre.Clear()
            CB_Numero_Hilera.ResetText()
            CB_Site.ResetText()
            Me.Hide()
            Catalogo.Show()
        Else
            MsgBox("Error: No se pudo completar el registro")
            Sig = Sig + 1
            If (Sig > 10) Then
                MsgBox("Error: Por favor contacte al administrador del programa")
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles B_Regresar.Click
        TB_Numero_Rack.Clear()
        TB_Nombre.Clear()
        CB_Numero_Hilera.ResetText()
        CB_Site.ResetText()
        Me.Hide()
        Catalogo.Show()
    End Sub
End Class