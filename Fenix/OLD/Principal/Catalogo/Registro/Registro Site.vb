Public Class Registro_Site

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles B_Registrar.Click
        Dim Sig As Integer

        If (TB_Site.Text.Length > 0) Then
            Dim cmd As SqlClient.SqlCommand
            SQL.Con_BD.Open()
            Try
                cmd = New SqlClient.SqlCommand("INSERT INTO Sites (Site,Direccion,Ciudad,CP) VALUES (@Site,@Direccion,@Ciudad,@CP)", Con_BD)
                With cmd.Parameters
                    .AddWithValue("@Site", TB_Site.Text.ToString)
                    .AddWithValue("@Direccion", TB_Direccion.Text.ToString)
                    .AddWithValue("@Ciudad", TB_Ciudad.Text.ToString)
                    .AddWithValue("@CP", TB_CP.Text.ToString)
                End With
                cmd.ExecuteNonQuery()
                SQL.Con_BD.Close()
                Sig = 1
            Catch ex As System.Data.SqlClient.SqlException
                MsgBox(ex.Message)
            End Try 'Falta Campos
        Else
            MsgBox("Es necesario el siguiente campo: Site")
        End If
        If (Sig = 1) Then
            MsgBox("Registro Completo")
            TB_Site.Clear()
            TB_Ciudad.Clear()
            TB_Direccion.Clear()
            TB_CP.Clear()
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

    Private Sub B_Regresar_Click(sender As Object, e As EventArgs) Handles B_Regresar.Click
        TB_Site.Clear()
        TB_Ciudad.Clear()
        TB_Direccion.Clear()
        TB_CP.Clear()
        Me.Hide()
        Catalogo.Show()
    End Sub
End Class