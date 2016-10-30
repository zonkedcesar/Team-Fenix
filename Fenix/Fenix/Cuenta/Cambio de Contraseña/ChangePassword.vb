Imports System.Xml

Public Class ChangePassword

    Private Sub B_Cancelar_Click(sender As Object, e As EventArgs) Handles B_Cancelar.Click
        Me.Hide()
        Principal.Focus()
    End Sub
    Private Sub TB_C_PSW_LostFocus(sender As Object, e As EventArgs) Handles TB_C_PSW.LostFocus
        If TB_N_PSW.Text <> TB_C_PSW.Text Then
            MsgBox("La contraseña no coincide")
            TB_N_PSW.Clear()
            TB_C_PSW.Clear()
            TB_N_PSW.Focus()
        End If
    End Sub
    Private Sub TB_N_PSW_LostFocus(sender As Object, e As EventArgs) Handles TB_N_PSW.LostFocus
        If TB_A_PSW.Text = TB_N_PSW.Text Then
            MsgBox("La contraseña no debe ser igual a la anterior")
            TB_A_PSW.Clear()
            TB_N_PSW.Clear()
            TB_A_PSW.Focus()
        End If
    End Sub

    Private Sub B_Actualizar_Click(sender As Object, e As EventArgs) Handles B_Actualizar.Click
        ConfirmarOperacionNIP.Show()
    End Sub

    Private Function BarridoDeData()
        Dim UsuarioData As String = "nobody"
        Dim WD As String = "nobody"
        Dim WC As String = "nobody"
        Dim SD As String = "nobody"
        Dim SC As String = "nobody"
        Dim Ruta3 As String
        Ruta3 = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\Documents\Fenix\" + Inicio.UsuarioConect + ".Data"

        'Validacion de archivos necesarios
        If My.Computer.FileSystem.FileExists(Ruta3) Then
            Try
                'Declaracion de variables de entorno
                Dim Datos As XmlDocument
                Dim Settings, Conjunto As XmlNodeList
                Dim Variable, Account As XmlNode
                'Manipulacion de documentos XML con carga
                Datos = New XmlDocument
                Datos.Load(Ruta3)
                'Lectura de NODOS para acceder al panel principal
                Settings = Datos.SelectNodes("/DataFenix/Settings")
                For Each Account In Settings
                    UsuarioData = Account.ChildNodes(0).InnerText
                    WD = Account.ChildNodes(1).InnerText
                    WC = Account.ChildNodes(2).InnerText
                    SD = Account.ChildNodes(3).InnerText
                    SC = Account.ChildNodes(4).InnerText
                Next

                If UsuarioData = LCase(Encode64(SHA512(Inicio.UsuarioConect))) Then
                    If SC >= 1 Then
                        For Lista As Integer = 0 To SC - 1
                            Conjunto = Datos.SelectNodes("/DataFenix/Servers/Servidor[@id='" & Lista & "']")

                            For Each Variable In conjunto
                                Variable.ChildNodes(6).InnerText = Encrypt(Decrypt(Variable.ChildNodes(6).InnerText, Inicio.psw.Text, Inicio.usr.Text), TB_N_PSW.Text, Inicio.usr.Text)
                                Variable.ChildNodes(9).InnerText = Encrypt(Decrypt(Variable.ChildNodes(9).InnerText, Inicio.psw.Text, Inicio.usr.Text), TB_N_PSW.Text, Inicio.usr.Text)
                                Variable.ChildNodes(10).InnerText = Encrypt(Decrypt(Variable.ChildNodes(10).InnerText, Inicio.psw.Text, Inicio.usr.Text), TB_N_PSW.Text, Inicio.usr.Text)
                                Variable.ChildNodes(11).InnerText = Encrypt(Decrypt(Variable.ChildNodes(11).InnerText, Inicio.psw.Text, Inicio.usr.Text), TB_N_PSW.Text, Inicio.usr.Text)
                            Next
                            Datos.Save(Ruta3)
                            Return True
                        Next
                    End If
                    'Se planea que tambien aplique lo mismo para la Cartera de contraseñas XD XD XD XD XD
                ElseIf UsuarioData = "nobody" Or WD = "nobody" Or WC = "nobody" Or SD = "nobody" Or SC = "nobody" Then
                    MsgBox("Error: la base de datos " & Inicio.UsuarioConect & ".data - Esta corrupta por favor de contactar al administrador")
                    Return False
                Else
                    MsgBox("Vaya usted esta intentando vulnerar este sistema, sin embargo juega con fuego por favor reconsidera tu accion")
                    Return False
                End If
            Catch ex As Exception
                MessageBox.Show("Error Inesperado por favor de contactar al administrador - Out: " & ex.Message)
                Return False
            End Try
        Else
            MsgBox("Error: No es posible leer la base de datos origen")
            Return False
        End If
    End Function
    Private Function CloseAll()
        Me.Close()
        ConfirmarOperacionNIP.Close()
        Principal.Close()
        Inicio.Show()
        Inicio.psw.Clear()
        Inicio.psw.Focus()
    End Function
    Protected Friend Function ActualizacionPassword(ByVal NIPplain As String) As String
        Dim Ruta, Ruta2 As String
        Ruta = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\Documents\Fenix\" + Inicio.UsuarioConect + ".fnx"
        Ruta2 = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\Documents\Fenix\" + Inicio.UsuarioConect + ".Recovery"
        Try
            'Declaracion de variables de entorno
            Dim cuenta, recovery As XmlDocument
            Dim UsuarioAC, PasswordAC, PasswordRCY, email, SecretQuestion As XmlNode
            'Manipulacion de documentos XML con carga
            cuenta = New XmlDocument
            recovery = New XmlDocument
            cuenta.Load(Ruta)
            recovery.Load(Ruta2)

            'Lectura de NODOS para acceder al panel principal
            UsuarioAC = cuenta.SelectSingleNode("Fenix/Perfil/Usuario")
            PasswordAC = cuenta.SelectSingleNode("Fenix/Perfil/Password")
            PasswordRCY = recovery.SelectSingleNode("RecoveryFenix/SecretKey")
            email = cuenta.SelectSingleNode("/Fenix/Perfil/Email")
            SecretQuestion = cuenta.SelectSingleNode("/Fenix/Seguridad/Respuesta")

            If PasswordAC.InnerText <> LCase(SHA512(TB_A_PSW.Text + Inicio.UsuarioConect)) Then
                MsgBox("Tu contraseña es Incorrecta")
                TB_A_PSW.Clear()
                TB_N_PSW.Clear()
                TB_C_PSW.Clear()
                TB_A_PSW.Focus()
            Else
                ' USUARIO ** USUARIO ** USUARIO **
                UsuarioAC.InnerText = LCase(SHA512(Inicio.UsuarioConect + TB_N_PSW.Text))
                ' PASSWORD ** PASSWORD ** PASSWORD **
                PasswordAC.InnerText = LCase(SHA512(TB_N_PSW.Text + Inicio.UsuarioConect))
                ' PASSWORDRECOVERY ** PASSWORDRECOVERY ** PASSWORDRECOVER **
                PasswordRCY.InnerText = Encrypt(TB_N_PSW.Text, (Decode64(email.InnerText) + Decrypt(SecretQuestion.InnerText, NIPplain, Inicio.UsuarioConect) + NIPplain), Inicio.UsuarioConect)
                'ACTUALIZACION A TODOS LOS PARAMETROS AFECTADOS FUNCION
                If BarridoDeData() = True Then
                    MsgBox("Contraseña Actualizada Correctamente")
                    cuenta.Save(Ruta)
                    recovery.Save(Ruta2)
                    CloseAll()
                Else
                    MsgBox("Ocurrio Grave Error al Aplicar los Cambios ")
                End If

            End If
            ' TERMINA ALMACENANDO TODOS LOS CAMBIOS
            
            Me.Hide()
            Principal.Focus()
            'Limpiar datos
            TB_A_PSW.Clear()
            TB_N_PSW.Clear()
            TB_C_PSW.Clear()
        Catch ex As Exception
            MessageBox.Show("Error Inesperado " & ex.Message)
        End Try

        Return 0
    End Function
End Class