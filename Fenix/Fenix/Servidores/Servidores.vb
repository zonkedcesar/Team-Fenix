Imports System.Xml

Public Class Servidores
    Dim Usedominio As Boolean
    Dim zombie, domainServer, SystemServer As String
    Dim TimeLeft As Integer
    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs)

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        Me.Hide()
        Principal.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        Me.Close()
        Catalogo.Show()
    End Sub

    Private Sub Remote_Click(sender As Object, e As EventArgs) Handles Remote.Click

        If CB_ServerSelect.Text.Length > 0 And OutPassword.Text.Length > 0 Then
            If SystemServer = "Windows" Then
                Dim credenciales, servidor As String

                'credenciales = "/generic:" + "probandoc" + " /user:" + "Su" + " /pass:" + "Pros@winDoc"
                'servidor = "/v " + "probandoc"
                If Usedominio = True Then
                    credenciales = "/generic:" + domainServer + " /user:" + OutUsr.Text + " /pass:" + OutPassword.Text
                Else
                    credenciales = "/generic:" + OutHostname.Text + " /user:" + OutUsr.Text + " /pass:" + OutPassword.Text
                End If
                'Lanzador
                servidor = "/v " + OutIP.Text
                System.Diagnostics.Process.Start("cmdkey.exe", credenciales)
                System.Diagnostics.Process.Start("mstsc.exe", servidor)
                'Contador
                T_Token.Start()
                T_Token.Interval = 1000
                TimeLeft = 5
            Else
                MsgBox("El Remote Desktop solo esta disponible para Windows")
            End If
        Else
            MsgBox("Por favor seleccione un servidor primero")
        End If
    End Sub

    Private Sub Shell_Click(sender As Object, e As EventArgs) Handles Shell.Click
        Dim comando As String
        If CB_ServerSelect.Text.Length > 0 And OutPassword.Text.Length > 0 Then
            comando = "-ssh " + OutUsr.Text + "@" + OutIP.Text + " -pw " + OutPassword.Text
            System.Diagnostics.Process.Start("C:\Fenix\putty.exe", comando)
        Else
            MsgBox("Por favor seleccione un servidor primero")
        End If


        'comando = "-ssh " + "Su" + "@" + "probandoc" + " -pw " + "Pros@winDoc"
        'System.Diagnostics.Process.Start("C:/putty.exe", comando)

    End Sub

    
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Mas.Click
        MoreServer.Show()
        MoreServer.B_Close.Focus()
    End Sub

    Private Sub Actualiza_Click(sender As Object, e As EventArgs) Handles Actualiza.Click

    End Sub

    Private Sub ClipBoard_Click(sender As Object, e As EventArgs) Handles ClipBoard.Click
        If OutPassword.Text.Length <= 0 Then
            MsgBox("Contraseña Vacia")
        Else
            My.Computer.Clipboard.SetText(OutPassword.Text.ToString) ' Copiando en PortaPapeles
            'Inicia temporizador 1000 = 1 seg & Duracion 10 Seg
            T_Copy.Start()
            T_Copy.Interval = 1000
            TimeLeft = 10
        End If
    End Sub

    Private Sub CB_ServerSelect_Click(sender As Object, e As EventArgs) Handles CB_ServerSelect.Click

    End Sub

    Private Function FastInformation()
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
                    'Obtener datos del servidor por ID ITEM
                    Dim puntero As Integer

                    'MsgBox("Total de items " & CB_ServerSelect.Items.Count & "  Total de Registros " & SC)

                    If CB_ServerSelect.SelectedIndex >= SC Then
                        puntero = CB_ServerSelect.SelectedIndex - (CB_ServerSelect.Items.Count - SC)
                        Conjunto = Datos.SelectNodes("/DataFenix/Servers/Servidor[@id='" & puntero & "']")

                        For Each Variable In Conjunto
                            OutHostname.Text = Decrypt(Variable.ChildNodes(6).InnerText, Inicio.psw.Text, Inicio.usr.Text)
                            OutSO.Text = Decode64(Variable.ChildNodes(12).InnerText)
                            OutIP.Text = Decrypt(Variable.ChildNodes(9).InnerText, Inicio.psw.Text, Inicio.usr.Text)
                            OutAmbiente.Text = Decode64(Variable.ChildNodes(5).InnerText)
                            OutPassword.Text = Decrypt(Variable.ChildNodes(11).InnerText, Inicio.psw.Text, Inicio.usr.Text)
                            OutUsr.Text = Decrypt(Variable.ChildNodes(10).InnerText, Inicio.psw.Text, Inicio.usr.Text)
                            Usedominio = Variable.ChildNodes(8).InnerText
                            domainServer = Decode64(Variable.ChildNodes(7).InnerText)
                            SystemServer = Decode64(Variable.ChildNodes(12).InnerText)

                            'More Information
                            MoreServer.MoreHostname.Text = OutHostname.Text & " - " & OutIP.Text
                            MoreServer.MoreAmbiente.Text = OutAmbiente.Text
                            MoreServer.OutSite.Text = Decode64(Variable.ChildNodes(0).InnerText)
                            MoreServer.OutRack.Text = Decode64(Variable.ChildNodes(1).InnerText)
                            MoreServer.OutModelo.Text = Decode64(Variable.ChildNodes(2).InnerText)
                            MoreServer.OutSerial.Text = Decode64(Variable.ChildNodes(3).InnerText)
                            MoreServer.OutControlDomain.Text = Decode64(Variable.ChildNodes(4).InnerText)
                            MoreServer.OutSistem.Text = OutSO.Text
                            MoreServer.OutVersion.Text = Decode64(Variable.ChildNodes(13).InnerText)
                        Next
                    Else
                        puntero = CB_ServerSelect.SelectedIndex
                        Conjunto = Datos.SelectNodes("/DataFenix/Servers/Servidor[@id='" & puntero & "']")

                        For Each Variable In Conjunto
                            OutHostname.Text = Decrypt(Variable.ChildNodes(6).InnerText, Inicio.psw.Text, Inicio.usr.Text)
                            OutSO.Text = Decode64(Variable.ChildNodes(12).InnerText)
                            OutIP.Text = Decrypt(Variable.ChildNodes(9).InnerText, Inicio.psw.Text, Inicio.usr.Text)
                            OutAmbiente.Text = Decode64(Variable.ChildNodes(5).InnerText)
                            OutPassword.Text = Decrypt(Variable.ChildNodes(11).InnerText, Inicio.psw.Text, Inicio.usr.Text)
                            OutUsr.Text = Decrypt(Variable.ChildNodes(10).InnerText, Inicio.psw.Text, Inicio.usr.Text)
                            Usedominio = Variable.ChildNodes(8).InnerText
                            domainServer = Decode64(Variable.ChildNodes(7).InnerText)
                            SystemServer = Decode64(Variable.ChildNodes(12).InnerText)

                            'More Information
                            MoreServer.MoreHostname.Text = OutHostname.Text & " - " & OutIP.Text
                            MoreServer.MoreAmbiente.Text = OutAmbiente.Text
                            MoreServer.OutSite.Text = Decode64(Variable.ChildNodes(0).InnerText)
                            MoreServer.OutRack.Text = Decode64(Variable.ChildNodes(1).InnerText)
                            MoreServer.OutModelo.Text = Decode64(Variable.ChildNodes(2).InnerText)
                            MoreServer.OutSerial.Text = Decode64(Variable.ChildNodes(3).InnerText)
                            MoreServer.OutControlDomain.Text = Decode64(Variable.ChildNodes(4).InnerText)
                            MoreServer.OutSistem.Text = OutSO.Text
                            MoreServer.OutVersion.Text = Decode64(Variable.ChildNodes(13).InnerText)
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

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles T_Token.Tick
        If TimeLeft > 0 Then
            TimeLeft -= 1
        Else ' Cuando TimeLeft es 0 Limpia el PortaPeles y Detiene el Temporizador
            zombie = "/delete " + "192.168.0.24"
            System.Diagnostics.Process.Start("cmdkey.exe", zombie)
            T_Token.Stop()
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles T_Copy.Tick
        If TimeLeft > 0 Then
            TimeLeft -= 1
        Else ' Cuando TimeLeft es 0 Limpia el PortaPeles y Detiene el Temporizador
            My.Computer.Clipboard.Clear()
            T_Copy.Stop()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles B_Nuevo.Click
        Registrar_Servidor.Show()
        CB_ServerSelect.SelectedIndex = -1
    End Sub

    Public Function ListandoHostnames()
        CB_ServerSelect.Items.Clear()
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
                    'Listando Hostname
                    If SC >= 1 Then

                        For Lista As Integer = 0 To SC - 1
                            Variable = Datos.SelectSingleNode("/DataFenix/Servers/Servidor[@id='" & Lista & "']/Hostname")
                            CB_ServerSelect.Items.Add(Decrypt(Variable.InnerText, Inicio.psw.Text, Inicio.usr.Text))
                        Next

                        For Lista As Integer = 0 To SC - 1
                            Variable = Datos.SelectSingleNode("/DataFenix/Servers/Servidor[@id='" & Lista & "']/IP")
                            CB_ServerSelect.Items.Add(Decrypt(Variable.InnerText, Inicio.psw.Text, Inicio.usr.Text))
                        Next
                        'CB_MaxLong.Items.Add("-")
                    Else
                        MsgBox("No tiene ningun servidor registrado - Por favor de registrar al menos un servidor")
                        B_Nuevo.Focus()
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


    Private Sub Servidores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListandoHostnames()
    End Sub

    Private Sub CB_ServerSelect_SelectedValueChanged(sender As Object, e As EventArgs) Handles CB_ServerSelect.SelectedValueChanged
        'MsgBox(" other Enter?")
        OutPassword.UseSystemPasswordChar = True

        FastInformation()
        Mas.Enabled = True
        Actualiza.Enabled = True

        'MsgBox(CB_ServerSelect.Text)
    End Sub

    Private Sub VerPass_Click(sender As Object, e As EventArgs) Handles VerPass.Click
        If OutPassword.UseSystemPasswordChar = True Then
            OutPassword.UseSystemPasswordChar = False
            'Inicia temporizador 1000 = 1 seg & Duracion 10 Seg
            T_lockPass.Start()
            T_lockPass.Interval = 1000
            TimeLeft = 3
        Else
            OutPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles T_lockPass.Tick
        If TimeLeft > 0 Then
            TimeLeft -= 1
        Else ' Cuando TimeLeft es 0 Limpia vuelve a tapar la contraseña
            OutPassword.UseSystemPasswordChar = True
            T_lockPass.Stop()
        End If
    End Sub
End Class