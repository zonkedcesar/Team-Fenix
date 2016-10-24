Imports System.Xml

Public Class Registrar_Servidor
    Dim IPoN As Boolean = False
    Private Sub B_Cancelar_Click(sender As Object, e As EventArgs) Handles B_Cancelar.Click
        Me.Hide()
        Servidores.Show()
        ClearAll()
    End Sub

    Private Function ClearAll()
        'Limpiar contenedores
        TB_Rack.Clear()
        TB_Modelo.Clear()
        TB_SerialNumber.Clear()
        'Limpiar Contenedores
        TB_ControlDomain.Clear()
        TB_Hostname.Clear()
        TB_Ambiente.Items.Clear()
        TB_IP.Clear()
        TB_Version.Items.Clear()
        TB_Version.Items.Clear()
        TB_Usuario.Clear()
        TB_Password.Clear()
        Return 0
    End Function

    Private Function CargarXML()
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
                Conjunto = Datos.SelectNodes("/DataFenix/Servers/Servidor")
                'Revisando si es un archivo nuevo
                If SD = True Then
                    'Apuntando a una actualizacion por ser un archivo nuevo
                    If Conjunto.Count() > 0 Then
                        Conjunto = Datos.SelectNodes("/DataFenix/Servers/Servidor[@id='0']")
                        For Each Variable In Conjunto
                            Variable.ChildNodes(0).InnerText = Encode64(TB_Site.Text)
                            Variable.ChildNodes(1).InnerText = Encode64(TB_Rack.Text)
                            Variable.ChildNodes(2).InnerText = Encode64(TB_Modelo.Text)
                            Variable.ChildNodes(3).InnerText = Encode64(TB_SerialNumber.Text)
                            Variable.ChildNodes(4).InnerText = Encode64(TB_ControlDomain.Text)
                            Variable.ChildNodes(5).InnerText = Encode64(TB_Ambiente.Text)
                            Variable.ChildNodes(6).InnerText = Encrypt(TB_Hostname.Text, Inicio.psw.Text, Inicio.usr.Text)
                            Variable.ChildNodes(7).InnerText = Encode64(TB_Dominio.Text)
                            Variable.ChildNodes(8).InnerText = Check_Dominio.Checked
                            Variable.ChildNodes(9).InnerText = Encrypt(TB_IP.Text, Inicio.psw.Text, Inicio.usr.Text)
                            Variable.ChildNodes(10).InnerText = Encrypt(TB_Usuario.Text, Inicio.psw.Text, Inicio.usr.Text)
                            Variable.ChildNodes(11).InnerText = Encrypt(TB_Password.Text, Inicio.psw.Text, Inicio.usr.Text)
                            Variable.ChildNodes(12).InnerText = Encode64(TB_Sistema.Text)
                            Variable.ChildNodes(13).InnerText = Encode64(TB_Version.Text)
                        Next
                        For Each Account In Settings
                            Account.ChildNodes(3).InnerText = False
                            Account.ChildNodes(4).InnerText = SC + 1
                        Next
                        Datos.Save(Ruta)
                        ClearAll()
                        MsgBox("Servidor Registrado con exito")
                        Me.Hide()
                        Servidores.Show()
                        Servidores.ListandoHostnames()
                    Else
                        MsgBox("Error: la base de datos " & Inicio.UsuarioConect & ".data - Esta corrupta por favor de contactar al administrador")
                    End If
                ElseIf SD = False Then
                    'Creando un nodo para los nuevos servidores de entrada
                    If Conjunto.Count() > 0 Then

                        'Variable = Datos.SelectSingleNode("/DataFenix/Servers/Servidor[@id='0']")

                        Dim elem2 As XmlElement = Datos.SelectSingleNode("/DataFenix/Servers/Servidor[@id='0']")

                        'Dim elem As XmlElement = Datos.CreateElement("Servidor")
                        'elem.SetAttribute("id", SC)
                        ''Datos.DocumentElement.LastChild.AppendChild(elem)
                        'OtroMetodo
                        'Dim newNode = Variable.CloneNode(True)
                        'Datos.DocumentElement.LastChild.AppendChild(newNode)
                        'newNode.Attributes.RemoveAll()
                        'OtherMetodh 2

                        Dim newElement = elem2.CloneNode(True)

                        newElement.Attributes.GetNamedItem("id").Value = SC
                        newElement.ChildNodes(0).InnerText = Encode64(TB_Site.Text)
                        newElement.ChildNodes(1).InnerText = Encode64(TB_Rack.Text)
                        newElement.ChildNodes(2).InnerText = Encode64(TB_Modelo.Text)
                        newElement.ChildNodes(3).InnerText = Encode64(TB_SerialNumber.Text)
                        newElement.ChildNodes(4).InnerText = Encode64(TB_ControlDomain.Text)
                        newElement.ChildNodes(5).InnerText = Encode64(TB_Ambiente.Text)
                        newElement.ChildNodes(6).InnerText = Encrypt(TB_Hostname.Text, Inicio.psw.Text, Inicio.usr.Text)
                        newElement.ChildNodes(7).InnerText = Encode64(TB_Dominio.Text)
                        newElement.ChildNodes(8).InnerText = Check_Dominio.Checked
                        newElement.ChildNodes(9).InnerText = Encrypt(TB_IP.Text, Inicio.psw.Text, Inicio.usr.Text)
                        newElement.ChildNodes(10).InnerText = Encrypt(TB_Usuario.Text, Inicio.psw.Text, Inicio.usr.Text)
                        newElement.ChildNodes(11).InnerText = Encrypt(TB_Password.Text, Inicio.psw.Text, Inicio.usr.Text)
                        newElement.ChildNodes(12).InnerText = Encode64(TB_Sistema.Text)
                        newElement.ChildNodes(13).InnerText = Encode64(TB_Version.Text)
                        Datos.DocumentElement.LastChild.AppendChild(newElement)

                        For Each Account In Settings
                            Account.ChildNodes(3).InnerText = False
                            Account.ChildNodes(4).InnerText = SC + 1
                        Next

                        Datos.Save(Ruta)
                        MsgBox("Servidor Registrado con exito")
                        ClearAll()
                        Me.Hide()
                        Servidores.Show()
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

    Private Sub B_Registrar_Click(sender As Object, e As EventArgs) Handles B_Registrar.Click
        If TB_Ambiente.Text.Length > 0 And TB_ControlDomain.Text.Length > 0 And TB_Dominio.Text.Length > 0 And _
            TB_Hostname.TextLength > 0 And TB_IP.TextLength > 0 And TB_Modelo.Text.Length > 0 And _
            TB_Password.TextLength > 0 And TB_Rack.TextLength > 0 And TB_SerialNumber.TextLength > 0 And _
            TB_Sistema.Text.Length > 0 And TB_Site.Text.Length > 0 And TB_Usuario.TextLength > 0 And _
            TB_Version.Text.Length > 0 Then
            'Solo si todos los campos estan llenos
            CargarXML()
            Servidores.ListandoHostnames()
        Else
            MsgBox("Por favor completa todos los campos para registrar")
        End If
    End Sub

    Private Sub VerPass_Click(sender As Object, e As EventArgs) Handles VerPass.Click
        If TB_Password.UseSystemPasswordChar = True Then
            TB_Password.UseSystemPasswordChar = False
        Else
            TB_Password.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Check_Dominio_CheckStateChanged(sender As Object, e As EventArgs) Handles Check_Dominio.CheckStateChanged
        If Check_Dominio.Checked = True Then
            TB_Dominio.Enabled = True
            TB_Dominio.Clear()
        Else
            TB_Dominio.Enabled = False
            TB_Dominio.Text = "PROSAMX"
        End If
    End Sub

   
    Private Sub Registrar_Servidor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TB_Site.SelectedIndex = 1
        TB_Ambiente.SelectedIndex = 1
        TB_Sistema.SelectedIndex = 0
    End Sub

    Private Sub TB_IP_Enter(sender As Object, e As EventArgs) Handles TB_IP.Enter

        If IPoN = False Then
            TB_IP.Clear()
            IPoN = True
        End If
    End Sub

    Private Sub TB_IP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TB_IP.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Or Asc(e.KeyChar) = Keys.Delete Or _
           Asc(e.KeyChar) = Keys.Right Or Asc(e.KeyChar) = Keys.Left Or Asc(e.KeyChar) = Keys.Delete Or Asc(e.KeyChar) = Keys.Back Then
            Return
        End If
        e.Handled = True
    End Sub


    Private Sub TB_IP_LostFocus(sender As Object, e As EventArgs) Handles TB_IP.LostFocus
        Dim IP() As String = TB_IP.Text.Split(".")
        Dim Test As Integer
        If IP.Length = 4 Then 'If 3 "."
            Dim Proper As Boolean = True
            For I As Integer = 0 To 3
                Test = Integer.Parse(IP(I)) 'Parse the string for an integer, if its not return -1
                If Test < 0 Or Test > 255 Then 'If not between 0-255 then the ip is not a proper format
                    MsgBox("IP Invalida no tiene un formato apropiado")
                    TB_IP.Focus()
                    TB_IP.SelectionStart = TB_IP.Text.Length
                    TB_IP.Clear()
                    Return
                End If
            Next
        Else
            MsgBox("IP Address No valida, debe tener un Formato XXX.XXX.XXX.XXX ")
            TB_IP.Focus()
            TB_IP.SelectionStart = TB_IP.Text.Length
            TB_IP.Clear()
        End If
    End Sub

    Private Sub TB_Usuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TB_Usuario.KeyPress
        If Char.IsLetterOrDigit(e.KeyChar) Or _
            Asc(e.KeyChar) = Keys.Delete Or _
           Asc(e.KeyChar) = Keys.Right Or _
           Asc(e.KeyChar) = Keys.Left Or _
           Asc(e.KeyChar) = Keys.Delete Or _
           Asc(e.KeyChar) = Keys.Back Then
            Return
        End If
        e.Handled = True
    End Sub
End Class