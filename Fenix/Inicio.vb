
Imports System.IO
Imports System.Xml

Public Class Inicio

    Protected Friend UsuarioConect As String

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
        If usr.TextLength > 0 And psw.TextLength > 0 Then
            Dim Ruta, Ruta2 As String
            Ruta = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\Documents\Fenix\" + usr.Text + ".fnx"
            Ruta2 = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\Documents\Fenix\" + usr.Text + ".Recovery"

            'Validacion de archivos necesarios
            If My.Computer.FileSystem.FileExists("%USERPROFILE%\Documents\Fenix\Fenix.fnx") Then
                MsgBox("Falta el archivo principal de su cuenta por favor de importarla")
            ElseIf My.Computer.FileSystem.FileExists("%USERPROFILE%\Documents\Fenix\Fenix.Recovery") Then
                MsgBox("Falta el archivo recovery para inciar sesion")
            Else
                'Validacion de Usuario y Contraseña
                Try
                    'Declaracion de variables de entorno
                    Dim cuenta, recovery As XmlDocument
                    Dim Username, Password As XmlNode
                    'Manipulacion de documentos XML con carga
                    cuenta = New XmlDocument
                    recovery = New XmlDocument
                    cuenta.Load(Ruta)
                    recovery.Load(Ruta2)
                    'Lectura de NODOS para acceder al panel principal
                    Username = cuenta.SelectSingleNode("Fenix/Perfil/Usuario")
                    Password = cuenta.SelectSingleNode("Fenix/Perfil/Password")

                    If Username.InnerText <> LCase(SHA512(usr.Text + psw.Text)) And Password.InnerText <> LCase(SHA512(psw.Text + usr.Text)) Then
                        MsgBox("Usuario y/o Contraseña Incorrecta")
                    Else
                        'Establecer Variable de entorno para ejecucion interna
                        UsuarioConect = usr.Text
                        Principal.Show()
                        Me.Hide()
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error Inesperado " & ex.Message)
                End Try
            End If
        Else
            MsgBox("La contraseña y/o Usuario no deben estar vacios")
        End If
    End Sub

    Private Sub psw_KeyPress(sender As Object, e As KeyPressEventArgs) Handles psw.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If usr.TextLength > 0 And psw.TextLength > 0 Then
                Dim Ruta, Ruta2 As String
                Ruta = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\Documents\Fenix\" + usr.Text + ".fnx"
                Ruta2 = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\Documents\Fenix\" + usr.Text + ".Recovery"

                'Validacion de archivos necesarios
                If My.Computer.FileSystem.FileExists("%USERPROFILE%\Documents\Fenix\Fenix.fnx") Then
                    MsgBox("Falta el archivo principal de su cuenta por favor de importarla")
                ElseIf My.Computer.FileSystem.FileExists("%USERPROFILE%\Documents\Fenix\Fenix.Recovery") Then
                    MsgBox("Falta el archivo recovery para inciar sesion")
                Else
                    'Validacion de Usuario y Contraseña
                    Try
                        'Declaracion de variables de entorno
                        Dim cuenta, recovery As XmlDocument
                        Dim Username, Password As XmlNode
                        'Manipulacion de documentos XML con carga
                        cuenta = New XmlDocument
                        recovery = New XmlDocument
                        cuenta.Load(Ruta)
                        recovery.Load(Ruta2)
                        'Lectura de NODOS para acceder al panel principal
                        Username = cuenta.SelectSingleNode("Fenix/Perfil/Usuario")
                        Password = cuenta.SelectSingleNode("Fenix/Perfil/Password")

                        If Username.InnerText <> LCase(SHA512(usr.Text + psw.Text)) And Password.InnerText <> LCase(SHA512(psw.Text + usr.Text)) Then
                            MsgBox("Usuario y/o Contraseña Incorrecta")
                        Else
                            'Establecer Variable de entorno para ejecucion interna
                            UsuarioConect = usr.Text
                            Principal.Show()
                            Me.Hide()
                        End If
                    Catch ex As Exception
                        MessageBox.Show("Error Inesperado " & ex.Message)
                    End Try
                End If
            Else
                MsgBox("La contraseña y/o Usuario no deben estar vacios")
            End If
        End If
    End Sub

    Private Sub usr_KeyPress(sender As Object, e As KeyPressEventArgs) Handles usr.KeyPress
        If Char.IsLetterOrDigit(e.KeyChar) Or _
            Char.IsLower(e.KeyChar) Or _
            Asc(e.KeyChar) = Keys.Delete Or _
           Asc(e.KeyChar) = Keys.Right Or _
           Asc(e.KeyChar) = Keys.Left Or _
           Asc(e.KeyChar) = Keys.Delete Or _
           Asc(e.KeyChar) = Keys.Back Then
            Return
        End If
        e.Handled = True
        If Asc(e.KeyChar) = 13 Then
            psw.Focus()
        End If
    End Sub

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
