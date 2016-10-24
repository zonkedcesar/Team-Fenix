Imports System.Xml

Public Class Servidores

    Dim zombie As String
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

        Dim credenciales, servidor As String

        credenciales = "/generic:" + "probandoc" + " /user:" + "Su" + " /pass:" + "Pros@winDoc"
        servidor = "/v " + "probandoc"

        System.Diagnostics.Process.Start("cmdkey.exe", credenciales)

        System.Diagnostics.Process.Start("mstsc.exe", servidor)

        Timer1.Start()
        Timer1.Interval = 1000
        TimeLeft = 5

        'System.Diagnostics.Process.Start("cmdkey.exe", zombie)

    End Sub

    Private Sub Shell_Click(sender As Object, e As EventArgs) Handles Shell.Click
        Dim comando As String
        comando = "-ssh " + "Su" + "@" + "probandoc" + " -pw " + "Pros@winDoc"

        System.Diagnostics.Process.Start("C:\putty.exe", comando)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Mas.Click


    End Sub

    Private Sub Actualiza_Click(sender As Object, e As EventArgs) Handles Actualiza.Click

    End Sub

    Private Sub ClipBoard_Click(sender As Object, e As EventArgs) Handles ClipBoard.Click
        If OutPassword.Text.Length <= 0 Then
            MsgBox("Contraseña Vacia")
        Else
            My.Computer.Clipboard.SetText(OutPassword.Text.ToString) ' Copiando en PortaPapeles
            'Inicia temporizador 1000 = 1 seg & Duracion 10 Seg
            Timer2.Start()
            Timer2.Interval = 1000
            TimeLeft = 10
        End If
    End Sub

    Private Sub CB_ServerSelect_Click(sender As Object, e As EventArgs) Handles CB_ServerSelect.Click

    End Sub
    
    Private Function FastInformation()
        Dim OutHostname, OutSO, OutIP, OutAmbiente, Ruta As String
        Ruta = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\Documents\Fenix\" + Inicio.UsuarioConect + ".Data"

        'Validacion de archivos necesarios
        If My.Computer.FileSystem.FileExists(Ruta) Then
            Try
                'Declaracion de variables de entorno
                Dim Datos As XmlDocument
                Dim Conjunto As XmlNodeList
                Dim Variable As XmlNode
                'Manipulacion de documentos XML con carga
                Datos = New XmlDocument
                Datos.Load(Ruta)
                'Lectura de NODOS para acceder al panel principal
                Conjunto = Datos.SelectNodes("/DataFenix/Servers/Servidor")

                For Each Variable In Conjunto
                    Dim Salida = Variable.LastChild.Value(CB_ServerSelect.Text)
                    MsgBox(Salida)
                Next

                'If SC >= 1 Then

                '    For Lista As Integer = 0 To SC - 1
                '        Variable = Datos.SelectSingleNode("/DataFenix/Servers/Servidor[@id='" & Lista & "']/Hostname")
                '        CB_ServerSelect.Items.Add(Decrypt(Variable.InnerText, Inicio.psw.Text, Inicio.usr.Text))
                '    Next
                'Else
                '    MsgBox("No tiene ningun servidor registrado - Por favor de registrar al menos 1 servidor")
                '    B_Nuevo.Focus()
                'End If
            Catch ex As Exception
                MessageBox.Show("Error Inesperado por favor de contactar al administrador - Out: " & ex.Message)
            End Try
        Else
            MsgBox("Error: No es posible leer la base de datos origen")
        End If
        Return 0
    End Function
    Private Function GetValor(nodoPadre As Xml.XmlNode, clave As String) As Object
        Dim valor As Xml.XmlNode = nodoPadre.SelectSingleNode(clave)
        Return valor.LastChild.Value
    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If TimeLeft > 0 Then
            TimeLeft -= 1
        Else ' Cuando TimeLeft es 0 Limpia el PortaPeles y Detiene el Temporizador
            zombie = "/delete " + "192.168.0.24"
            System.Diagnostics.Process.Start("cmdkey.exe", zombie)
            Timer1.Stop()
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If TimeLeft > 0 Then
            TimeLeft -= 1
        Else ' Cuando TimeLeft es 0 Limpia el PortaPeles y Detiene el Temporizador
            My.Computer.Clipboard.Clear()
            Timer2.Stop()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles B_Nuevo.Click
        Registrar_Servidor.Show()
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
                        MsgBox("No tiene ningun servidor registrado - Por favor de registrar al menos 1 servidor")
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

    Private Sub B_Ok_Click(sender As Object, e As EventArgs) Handles B_Ok.Click
        FastInformation()
    End Sub

    Private Sub CB_ServerSelect_SelectedValueChanged(sender As Object, e As EventArgs) Handles CB_ServerSelect.SelectedValueChanged
        'MsgBox(" other Enter?")
        FastInformation()
    End Sub
End Class