Imports System.Data
Public Class Principal
    Friend LoginUsuario As String
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Generador_de_Contraseñas.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Servidores.Show()
    End Sub

    Private Sub M_Credenciales_Click(sender As Object, e As EventArgs)
        Me.Hide()

    End Sub

    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'MsgBox(hora())

        'Comentar aqui


        'Dim dt = New DataTable()
        'Dim SentenciaSQL As String
        'Dim Control As New SqlClient.SqlCommand
        'Dim rundata As New SqlClient.SqlDataAdapter

        'SentenciaSQL = "SELECT Nombre,Apellidos FROM fenix.dbo.Usuarios WHERE Usuario = @Usuario"

        'Control = New SqlClient.SqlCommand(SentenciaSQL, Con_BD)
        'Control.Parameters.AddWithValue("@Usuario", LoginUsuario)

        'rundata = New SqlClient.SqlDataAdapter(Control)
        'rundata.Fill(dt)

        'If (dt.Rows.Count > 0) Then
        '    For Each row In dt.Rows
        '        LoginUsuario = row("Nombre") + row("Apellidos")
        '    Next
        'Else
        '    MsgBox("Error: Al parecer hay un error con los datos de usuario")
        'End If

        'NameUser.Text = LoginUsuario

        'Termina comentarios


        'td.Dispose()   //PARA LIBERAR LA MEMORIA UTILIZAR DISPOSE
        'rundata.Dispose()
    End Sub

    Private Sub LogOut_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Inicio.Show()
    End Sub


    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        TestPassword.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs)

        Me.Hide()

    End Sub

    Private Sub B_Generador_Click(sender As Object, e As EventArgs) Handles B_Generador.Click
        Generador_de_Contraseñas.Show()

    End Sub

    Private Sub B_Cartera_Click(sender As Object, e As EventArgs) Handles B_Cartera.Click
        Wallet.Show()
        'Me.Hide()
    End Sub

    Private Sub B_Sesion_Click(sender As Object, e As EventArgs) Handles B_Sesion.Click
        Servidores.Show()


    End Sub

    Private Sub B_Borrado_Click(sender As Object, e As EventArgs) Handles B_Borrado.Click
        SecureRemove.Show()

    End Sub

    
    Private Sub CambiarNIPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CambiarNIPToolStripMenuItem.Click
        changeNip.Show()
    End Sub

    Private Sub CambiarContraseñaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CambiarContraseñaToolStripMenuItem.Click
        ChangePassword.Show()
    End Sub

    Private Sub PreguntaSecretaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PreguntaSecretaToolStripMenuItem.Click
        ChangeQuestion.Show()
    End Sub

    Private Sub Salir_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Inicio.Show()
        Inicio.psw.Clear()
    End Sub

    Private Sub logoff_Click(sender As Object, e As EventArgs) Handles logoff.Click
        Me.Close()
        Inicio.Show()
        Inicio.psw.Clear()
        Inicio.psw.Focus()
    End Sub
    Private Function Liberando()
        Servidores.Close()
        Generador_de_Contraseñas.Close()
        SecureRemove.Close()
        Return 0
    End Function
End Class