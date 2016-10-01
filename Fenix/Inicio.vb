
Imports System.IO

Public Class Inicio

    Dim PATHPROFILE As String = Nothing

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AyudaToolStripMenuItem.Click
        Acerca.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs)

        'Dim myStream As Stream = Nothing
        'Dim openFileDialog1 As New OpenFileDialog()

        'openFileDialog1.Title = "Archivo base"
        'openFileDialog1.Filter = "Archivo | *.znk"
        'openFileDialog1.FileName = "FenixKey"
        'openFileDialog1.InitialDirectory = "C:\Program Files (x86)\Fenix Wallet Key\Fenix\Key"

        'If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
        '    Try
        '        myStream = openFileDialog1.OpenFile()

        '        If (myStream IsNot Nothing) Then
        '            ' Abierto
        '            MsgBox("Archivo Cargado")
        '            Dim Source As String
        '            Source = openFileDialog1.FileName
        '            Dim Destination As String = "C:\Program Files (x86)\Fenix Wallet Key\Fenix\Key\Fenix.znk"
        '            System.IO.File.Copy(Source, Destination, True)

        '        End If

        '    Catch Ex As Exception
        '        MessageBox.Show("No se puede leer el archivo. Original error: " & Ex.Message)

        '    Finally
        '        ' Final
        '        If (myStream IsNot Nothing) Then
        '            myStream.Close()
        '        End If
        '    End Try
        'End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Login.Click

        Principal.Show()

        ''Dim FileReader As String

        'If My.Computer.FileSystem.FileExists("%USERPROFILE%\Documents\Fenix\Fenix.znk") Then

        '    Principal.Show()

        '    'FileReader = My.Computer.FileSystem.ReadAllText("C:\Program Files (x86)\Fenix Wallet Key\Fenix\Key\Fenix.znk")
        '    'If FileReader = "Inicial" Then
        '    '    User = "Admin"
        '    '    Pass = "Admin"
        '    'End If
        'Else
        '    MsgBox("Antes de utilizar Fénix es necesario configurar tu cuenta de usuario.")
        '    PATHPROFILE = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\Documents\Fenix"
        '    Directory.CreateDirectory(PATHPROFILE)
        '    Me.SendToBack()
        '    Me.Hide()
        '    Primeros_Pasos.Show()
        'End If




        'DESCOMENTARIZAR

        'Dim cmd As SqlClient.SqlCommand
        'Dim data As SqlClient.SqlDataReader

        'If (usr.Text.Length > 0 And psw.Text.Length > 0) Then
        '    Try
        '        SQL.Con_BD.Open()
        '        cmd = New SqlClient.SqlCommand("dbo.sp_fenixlogin", Con_BD)
        '        cmd.CommandType = CommandType.StoredProcedure
        '        With cmd.Parameters
        '            .AddWithValue("@Usuario", usr.Text.ToString)
        '            .AddWithValue("@Login_User", LCase(SHA512(usr.Text + psw.Text)).ToString)
        '            .AddWithValue("@Login_Pass", LCase(SHA512(psw.Text + usr.Text)).ToString)
        '        End With
        '        data = cmd.ExecuteReader
        '        If data.HasRows = True Then
        '            Con_BD.Close()
        '            Principal.LoginUsuario = usr.Text
        '            usr.Text = ""
        '            psw.Text = ""

        '            Me.Hide()
        '            Principal.Show()
        '        Else
        '            Con_BD.Close()
        '            MsgBox("Credenciales No validas")
        '        End If
        '    Catch ex As Exception : MsgBox(ex.Message)
        '    End Try
        'Else
        '    MsgBox("Error: Alguno de los parametros no se completo")
        'End If


        'FINAL AQUI


        'SQL.Login(usr.Text, SHA512(usr.Text), SHA512(psw.Text))

        'MsgBox(usr.Text, SHA512(usr.Text), SHA512(psw.Text))

        'Dim AES256Encry, AES256Descry As String
        'Dim AES128Encry, AES128Descry As String



        'AES256Encry = Encrypt("P455w0rd", "3e0f9dd9209151e021d5dc44e648cb30", "hola")
        'AES256Descry = Decrypt(AES256Encry, "3e0f9dd9209151e021d5dc44e648cb30", "hola")

        'AES256Encry = Encrypt("P455w0rd", "HaHaHackingTeam", "hola")
        'AES256Descry = Decrypt(AES256Encry, "HaHaHackingTeam", "hola")

        'AES128Encry = AES_Encrypt("P455w0rd", "5761636177616361726f626572746f31")

        'AES128Descry = AES_Decrypt(AES128Encry, "5761636177616361726f626572746f31")

        'My.Computer.FileSystem.WriteAllText("C:\Prueba\AES256.txt", AES256Encry + "-" + AES256Descry, True)

        'My.Computer.FileSystem.WriteAllText("C:\Prueba\AES128.txt", AES128Encry + "-" + AES128Descry, True)



    End Sub



    Private Sub psw_KeyPress(sender As Object, e As KeyPressEventArgs) Handles psw.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Dim cmd As SqlClient.SqlCommand
            Dim data As SqlClient.SqlDataReader

            If (usr.Text.Length > 0 And psw.Text.Length > 0) Then
                Try
                    SQL.Con_BD.Open()
                    cmd = New SqlClient.SqlCommand("dbo.sp_fenixlogin", Con_BD)
                    cmd.CommandType = CommandType.StoredProcedure
                    With cmd.Parameters
                        .AddWithValue("@Usuario", usr.Text.ToString)
                        .AddWithValue("@Login_User", LCase(SHA512(usr.Text + psw.Text)).ToString)
                        .AddWithValue("@Login_Pass", LCase(SHA512(psw.Text + usr.Text)).ToString)
                    End With
                    data = cmd.ExecuteReader
                    If data.HasRows = True Then
                        Con_BD.Close()
                        Principal.LoginUsuario = usr.Text
                        usr.Text = ""
                        psw.Text = ""

                        Me.Hide()
                        Principal.Show()
                    Else
                        Con_BD.Close()
                        MsgBox("Credenciales No validas")
                    End If
                Catch ex As Exception : MsgBox(ex.Message)
                End Try
            Else
                MsgBox("Error: Alguno de los parametros no se completo")
            End If
        End If
    End Sub

    Private Sub usr_KeyPress(sender As Object, e As KeyPressEventArgs) Handles usr.KeyPress
        If Asc(e.KeyChar) = 13 Then
            psw.Focus()
        End If
    End Sub

    

    'Private Sub Inicio_MouseClick(sender As Object, e As MouseEventArgs) Handles Me.MouseClick
    '    'Dim FileReader As String
    '    If My.Computer.FileSystem.FileExists("%USERPROFILE%\Documents\Fenix\Fenix.znk") Then
    '        'FileReader = My.Computer.FileSystem.ReadAllText("C:\Program Files (x86)\Fenix Wallet Key\Fenix\Key\Fenix.znk")
    '        'If FileReader = "Inicial" Then
    '        '    User = "Admin"
    '        '    Pass = "Admin"
    '        'End If
    '    Else
    '        MsgBox("Antes de utilizar Fénix es necesario configurar tu cuenta de usuario.")
    '        PATHPROFILE = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\Documents\Fenix"
    '        Directory.CreateDirectory(PATHPROFILE)
    '        Me.SendToBack()
    '        Me.Hide()
    '        Primeros_Pasos.Show()
    '    End If
    'End Sub

    'Private Sub MenuStrip1_Click(sender As Object, e As EventArgs) Handles MenuStrip1.Click
    '    'Dim FileReader As String
    '    If My.Computer.FileSystem.FileExists("%USERPROFILE%\Documents\Fenix\Fenix.znk") Then
    '        'FileReader = My.Computer.FileSystem.ReadAllText("C:\Program Files (x86)\Fenix Wallet Key\Fenix\Key\Fenix.znk")
    '        'If FileReader = "Inicial" Then
    '        '    User = "Admin"
    '        '    Pass = "Admin"
    '        'End If
    '    Else

    '        MsgBox("Antes de utilizar Fénix es necesario configurar tu cuenta de usuario.")
    '        PATHPROFILE = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\Documents\Fenix"
    '        Directory.CreateDirectory(PATHPROFILE)
    '        Me.SendToBack()
    '        Me.Hide()
    '        Primeros_Pasos.Show()
    '    End If
    'End Sub

    


    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles B_Invitado.Click
        Invitado.Show()
        Me.Hide()
    End Sub

    Private Sub B_Crear_Click(sender As Object, e As EventArgs) Handles B_Crear.Click
        Crear_cuenta.Show()
        Me.Hide()
    End Sub

    
   
    Private Sub ConfigurarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConfigurarToolStripMenuItem.Click
        Configuracion.Show()
    End Sub

    Private Sub RecuperarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RecuperarToolStripMenuItem.Click
        Recuperar_Contraseña.Show()
    End Sub
End Class
