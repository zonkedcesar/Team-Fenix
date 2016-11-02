Imports System.Text.RegularExpressions
Imports System.Xml

Public Class ModificarWaller
    Friend apuntador As Integer
    Private Sub VerPass_Click(sender As Object, e As EventArgs) Handles VerPass.Click
        If TB_psw.UseSystemPasswordChar = True And TB_psw.TextLength > 0 Then
            TB_psw.UseSystemPasswordChar = False
        Else
            TB_psw.UseSystemPasswordChar = True
        End If
    End Sub


    Private Sub TB_C_psw_LostFocus(sender As Object, e As EventArgs) Handles TB_C_psw.LostFocus
        If TB_psw.Text <> TB_C_psw.Text And TB_C_psw.TextLength > 0 Then
            MsgBox("La contraseña no coincide")
            TB_C_psw.Clear()
            TB_psw.Clear()
            TB_psw.Focus()
        End If
    End Sub

    Private Sub TB_URL_LostFocus(sender As Object, e As EventArgs) Handles TB_URL.LostFocus
        If TB_URL.TextLength > 0 Then
            Dim pattern As String
            pattern = "http(s)?://([\w+?\.\w+])+([a-zA-Z0-9\~\!\@\#\$\%\^\&\*\(\)_\-\=\+\\\/\?\.\:\;\'\,]*)?"
            If Regex.IsMatch(TB_URL.Text, pattern) Then
                'No hacer nada si es valida la URL
            Else
                MsgBox("URL no Valida")
                TB_URL.Clear()
                TB_URL.Focus()

            End If
        End If
    End Sub

    Private Sub CB_yesURL_CheckedChanged(sender As Object, e As EventArgs) Handles CB_yesURL.CheckedChanged
        If CB_yesURL.Checked = True Then
            TB_URL.Enabled = True
        Else
            TB_URL.Enabled = False
        End If
    End Sub

    Private Sub B_Actualizar_Click(sender As Object, e As EventArgs) Handles B_Actualizar.Click
        'Validar que todos los campos estan completos
        If CB_tipe.Text.Length > 0 And TB_Titulo.TextLength > 0 And TB_Usr.TextLength > 0 _
            And TB_psw.TextLength > 0 And TB_C_psw.TextLength > 0 Then

            ActualizaItemActual(apuntador)
            Wallet.amigo()
            Wallet.Show()
            Me.Close()

        Else
            MsgBox("Complete todos los campos")
        End If
    End Sub
    Private Function ActualizaItemActual(ByVal ID As Integer)
        Dim UsuarioData As String = "nobody"
        Dim WD As String = "nobody"
        Dim WC As String = "nobody"
        Dim SD As String = "nobody"
        Dim SC As String = "nobody"

        Dim Ruta As String
        Ruta = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\Documents\Fenix\" + Inicio.UsuarioConect + ".Data"
        Try
            'Declaracion de variables de entorno
            Dim Datos As XmlDocument
            Dim Settings, Conjunto As XmlNodeList
            Dim Variable, Account As XmlNode
            'Manipulacion de documentos XML con carga
            Datos = New XmlDocument
            Datos.Load(Ruta)
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
                Conjunto = Datos.SelectNodes("/DataFenix/Wallet/Cartera ")
                'Revisando si es un archivo nuevo
                If WC > 0 Then
                    'Apuntando a una actualizacion por ser un archivo nuevo
                    If Conjunto.Count() > 0 Then
                        Conjunto = Datos.SelectNodes("/DataFenix/Wallet/Cartera[@id='" & ID & "']")
                        For Each Variable In Conjunto
                            Variable.ChildNodes(0).InnerText = Encode64(CB_tipe.Text)
                            Variable.ChildNodes(1).InnerText = Encrypt(TB_Titulo.Text, Inicio.psw.Text, Inicio.usr.Text)
                            Variable.ChildNodes(2).InnerText = Encrypt(TB_Usr.Text, Inicio.psw.Text, Inicio.usr.Text)
                            Variable.ChildNodes(3).InnerText = Encrypt(TB_psw.Text, Inicio.psw.Text, Inicio.usr.Text)
                            Variable.ChildNodes(4).InnerText = Encode64(TB_URL.Text)
                            Variable.ChildNodes(5).InnerText = Encrypt(TB_coment.Text, Inicio.psw.Text, Inicio.usr.Text)
                        Next
                        Datos.Save(Ruta)
                        MsgBox("Cuenta Actualizada con Exito")
                        
                    Else
                        MsgBox("Error: la base de datos " & Inicio.UsuarioConect & ".data - Esta corrupta por favor de contactar al administrador")
                    End If
                Else
                    MsgBox("Error: la base de datos " & Inicio.UsuarioConect & ".data - Esta corrupta por favor de contactar al administrador")
                End If
            ElseIf UsuarioData = "nobody" Or WD = "nobody" Or WC = "nobody" Or SD = "nobody" Or SC = "nobody" Then
                MsgBox("Error: la base de datos " & Inicio.UsuarioConect & ".data - Esta corrupta por favor de contactar al administrador")
            Else
                MsgBox("Vaya usted esta intentando vulnerar este sistema, sin embargo juega con fuego por favor reconsidera tu accion")
            End If
        Catch ex As Exception
            MessageBox.Show("Error Inesperado por favor de contactar al administrador - Out: " & ex.Message)
        End Try
        Return 0
    End Function

    Private Sub B_cancelar_Click(sender As Object, e As EventArgs) Handles B_cancelar.Click
        Me.Hide()
        Wallet.Show()
    End Sub

End Class