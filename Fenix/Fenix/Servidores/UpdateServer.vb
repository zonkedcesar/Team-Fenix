Imports System.Xml

Public Class UpdateServer
    Private Function ActualizaServer()

        Dim IDServer As Integer = Servidores.puntero

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
                'Revisando si es un archivo nuevo
                If SC > 0 Then
                    'Apuntando a una actualizacion por ser un archivo nuevo
                    Conjunto = Datos.SelectNodes("/DataFenix/Servers/Servidor[@id='" & IDServer & "']")
                    For Each Variable In Conjunto
                        Variable.ChildNodes(0).InnerText = Encode64(TB_U_Site.Text)
                        Variable.ChildNodes(1).InnerText = Encode64(TB_U_Rack.Text)
                        'Variable.ChildNodes(2).InnerText = Encode64(TB_Modelo.Text)
                        'Variable.ChildNodes(3).InnerText = Encode64(TB_SerialNumber.Text)
                        'Variable.ChildNodes(4).InnerText = Encode64(TB_ControlDomain.Text)
                        'Variable.ChildNodes(5).InnerText = Encode64(TB_Ambiente.Text)
                        Variable.ChildNodes(6).InnerText = Encrypt(TB_U_Hostname.Text, Inicio.psw.Text, Inicio.usr.Text)
                        'Variable.ChildNodes(7).InnerText = Encode64(TB_Dominio.Text)
                        'Variable.ChildNodes(8).InnerText = Check_Dominio.Checked
                        Variable.ChildNodes(9).InnerText = Encrypt(TB_U_IP.Text, Inicio.psw.Text, Inicio.usr.Text)
                        Variable.ChildNodes(10).InnerText = Encrypt(TB_U_Usr.Text, Inicio.psw.Text, Inicio.usr.Text)
                        Variable.ChildNodes(11).InnerText = Encrypt(TB_U_Psw.Text, Inicio.psw.Text, Inicio.usr.Text)
                        'Variable.ChildNodes(12).InnerText = Encode64(TB_Sistema.Text)
                        'Variable.ChildNodes(13).InnerText = Encode64(TB_Version.Text)
                    Next
                        Datos.Save(Ruta)
                        MsgBox("Actualizacion con exito")
                        Me.Hide()
                        Servidores.Show()
                        Servidores.LimpiaPresentacion()
                        Servidores.ListandoHostnames()
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

    Private Function RevisaExiste()
        Dim UsuarioData As String = "nobody"
        Dim WD As String = "nobody"
        Dim WC As String = "nobody"
        Dim SD As String = "nobody"
        Dim SC As String = "nobody"
        Dim Ruta As String
        Ruta = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\Documents\Fenix\" + Inicio.UsuarioConect + ".Data"

        'Validacion de archivos necesarios
        If My.Computer.FileSystem.FileExists(Ruta) Then
            Try
                'Declaracion de variables de entorno
                Dim Datos As XmlDocument
                Dim Settings As XmlNodeList
                Dim Variable, Variable2, Account As XmlNode
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
                    If SC >= 1 Then
                        For Lista As Integer = 0 To SC - 1
                            Variable = Datos.SelectSingleNode("/DataFenix/Servers/Servidor[@id='" & Lista & "']/Hostname")
                            Variable2 = Datos.SelectSingleNode("/DataFenix/Servers/Servidor[@id='" & Lista & "']/IP")
                            If CB_Hostname.Checked = True Then
                                If LCase(Decrypt(Variable.InnerText, Inicio.psw.Text, Inicio.usr.Text)) = LCase(TB_U_Hostname.Text) Then
                                    MsgBox("Ya hay un registro actualmente con este HOSTNAME")
                                    TB_U_Hostname.Clear()
                                    TB_U_Hostname.Focus()
                                    Lista = SC - 1
                                End If
                            End If
                            If CB_IP.Checked = True Then
                                If Decrypt(Variable2.InnerText, Inicio.psw.Text, Inicio.usr.Text) = TB_U_IP.Text Then
                                    MsgBox("Ya hay un registro actualmente con esta IP")
                                    TB_U_IP.Clear()
                                    TB_U_IP.Focus()
                                    Lista = SC - 1
                                End If
                            End If
                        Next
                    End If
                ElseIf UsuarioData = "nobody" Or WD = "nobody" Or WC = "nobody" Or SD = "nobody" Or SC = "nobody" Then
                    MsgBox("Error: la base de datos " & Inicio.UsuarioConect & ".data - Esta corrupta por favor de contactar al administrador")
                Else
                    MsgBox("Vaya usted esta intentando vulnerar este sistema, sin embargo juega con fuego por favor reconsidera tu accion")
                End If
            Catch ex As Exception
                MessageBox.Show("Error Inesperado por favor de contactar al administrador - Out: " & ex.Message)
            End Try
        Else
            MsgBox("Error: No es posible leer la base de datos origen")
        End If
        Return 0
    End Function
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles B_Cancelar.Click
        Me.Hide()
        Servidores.Show()
    End Sub

    Private Sub B_update_Click(sender As Object, e As EventArgs) Handles B_update.Click
        'Validar todos los datos esten completos
        If TB_U_Site.Text.Length > 0 And TB_U_Rack.TextLength > 0 And TB_U_Hostname.TextLength > 0 _
            And TB_U_IP.TextLength > 0 And TB_U_Usr.TextLength > 0 And TB_U_Psw.TextLength > 0 Then
            'Debe llamar la funcion Actualizar
            ActualizaServer()
            'Volver a cargar los datos
            Servidores.ListandoHostnames()
            'Evitar tener el contenedor More Server
            MoreServer.Hide()
        Else
            MsgBox("Debe Completar todos los campos")
        End If
    End Sub

    Private Sub VerPass_Click(sender As Object, e As EventArgs) Handles VerPass.Click
        If TB_U_Psw.UseSystemPasswordChar = True Then
            TB_U_Psw.UseSystemPasswordChar = False
        Else
            TB_U_Psw.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub UpdateServer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TB_U_Site.SelectedIndex = 1
        TB_U_Psw.Clear()
        TB_U_Psw.Focus()
    End Sub

    Private Sub TB_U_IP_LostFocus(sender As Object, e As EventArgs) Handles TB_U_IP.LostFocus
        If TB_U_IP.TextLength > 0 Then ' Evita bucle infinito por estar vacio
            Dim IP() As String = TB_U_IP.Text.Split(".")
            Dim Test As Integer
            If IP.Length = 4 Then 'If 3 "."
                Dim Proper As Boolean = True
                For I As Integer = 0 To 3
                    Test = Integer.Parse(IP(I)) 'Parse the string for an integer, if its not return -1
                    If Test < 0 Or Test > 255 Then 'If not between 0-255 then the ip is not a proper format
                        MsgBox("IP Invalida no tiene un formato apropiado")
                        TB_U_IP.Focus()
                        TB_U_IP.SelectionStart = TB_U_IP.Text.Length
                        TB_U_IP.Clear()
                        Return
                    End If
                Next
            Else
                MsgBox("IP Address No valida, debe tener un Formato XXX.XXX.XXX.XXX ")
                TB_U_IP.Focus()
                TB_U_IP.SelectionStart = TB_U_IP.Text.Length
                TB_U_IP.Clear()
            End If
            If TB_U_IP.TextLength > 0 Then
                RevisaExiste()
            End If
        End If
    End Sub

    Private Sub TB_U_Hostname_LostFocus(sender As Object, e As EventArgs) Handles TB_U_Hostname.LostFocus
        If TB_U_Hostname.TextLength > 0 Then
            RevisaExiste()
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CB_Hostname.CheckedChanged
        If CB_Hostname.Checked = True Then
            TB_U_Hostname.Enabled = True
            TB_U_Hostname.Clear()
        Else
            TB_U_Hostname.Enabled = False
            TB_U_Hostname.Text = Servidores.OutHostname.Text
        End If
    End Sub

    Private Sub CB_IP_CheckedChanged(sender As Object, e As EventArgs) Handles CB_IP.CheckedChanged
        If CB_IP.Checked = True Then
            TB_U_IP.Enabled = True
            TB_U_IP.Clear()
        Else
            TB_U_IP.Enabled = False
            TB_U_IP.Text = Servidores.OutIP.Text
        End If
    End Sub
End Class