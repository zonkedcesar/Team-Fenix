Imports System.Xml

Public Class Wallet
    Dim TimeLeft, TimeLeft1 As Integer
    Dim NumeroFila As ListViewItem
    Protected Friend Function amigo()
        PanelDePassword.Items.Clear()
        ImprimirLista(CB_type.Text)
        habilitacontrol()
        TB_Out_PSW.Clear()
        Return 0
    End Function
    Private Function ImprimirLista(ByVal Tipo As String)
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
                Dim Recolector, Variable, Account As XmlNode
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
                    ' Verificar que hay datos en la cartera de forma general

                    If WC > 0 Then
                        'Cicla todo para comenzar a extrar datos
                        For puntero As Integer = 0 To WC - 1
                            Variable = Datos.SelectSingleNode("DataFenix/Wallet/Cartera[@id='" & puntero & "']/Tipo")
                            'Si este valor es igual debera obtenerlo

                            If Decode64(Variable.InnerText) = Tipo Then
                                Conjunto = Datos.SelectNodes("DataFenix/Wallet/Cartera[@id='" & puntero & "']")
                                'Una ves que siga apuntando recoltar informacion
                                For Each Recolector In Conjunto

                                    Dim item As New ListViewItem(puntero.ToString, puntero)
                                    item.Checked = True
                                    item.SubItems.Add(Decrypt(Recolector.ChildNodes(1).InnerText, Inicio.psw.Text, Inicio.usr.Text))
                                    item.SubItems.Add(Decrypt(Recolector.ChildNodes(2).InnerText, Inicio.psw.Text, Inicio.usr.Text))
                                    item.SubItems.Add("********")
                                    item.SubItems.Add(Decode64(Recolector.ChildNodes(4).InnerText))
                                    item.SubItems.Add(Decrypt(Recolector.ChildNodes(5).InnerText, Inicio.psw.Text, Inicio.usr.Text))
                                    PanelDePassword.Items.Add(item)
                                Next
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
    Private Function PresentarContrasenia(ByVal puntero As Integer)
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
                    ' Verificar que hay datos en la cartera de forma general

                    If WC > 0 Then
                        'Cicla todo para comenzar a extrar datos
                        Variable = Datos.SelectSingleNode("DataFenix/Wallet/Cartera[@id='" & puntero & "']/Contrasenia")
                        TB_Out_PSW.Text = Decrypt(Variable.InnerText, Inicio.psw.Text, Inicio.usr.Text)
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
    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        NuevoCuenta.Show()
    End Sub

    Private Sub ModificarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarToolStripMenuItem.Click
        If PanelDePassword.SelectedItems.Count > 0 Then
            Dim apunta As String = NumeroFila.SubItems(0).Text

            If CInt(apunta) >= 0 Then
                ModificarWaller.CB_tipe.Text = Me.CB_type.Text
                ModificarWaller.TB_Titulo.Text = NumeroFila.SubItems(1).Text
                ModificarWaller.TB_Usr.Text = NumeroFila.SubItems(2).Text
                ModificarWaller.TB_URL.Text = NumeroFila.SubItems(4).Text
                ModificarWaller.TB_coment.Text = NumeroFila.SubItems(5).Text
                ModificarWaller.apuntador = CInt(apunta)
                ModificarWaller.Show()
            End If
        End If
    End Sub

    Private Sub Wallet_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'PanelDePassword.Items.AddRange(New ListViewItem() {item1, item2})
        'PanelDePassword.Items.Add(item3)

    End Sub

    Private Sub PanelDePassword_ItemSelectionChanged(sender As Object, e As ListViewItemSelectionChangedEventArgs) Handles PanelDePassword.ItemSelectionChanged
        If PanelDePassword.SelectedItems.Count > 0 Then
            'MsgBox("Activar")
            'PresentarContrasenia()
        Else
            'MsgBox("Desactivar")
            TB_Out_PSW.Clear()
        End If

    End Sub


    Private Sub PanelDePassword_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles PanelDePassword.MouseDoubleClick
        Dim lvi As ListViewItem = PanelDePassword.HitTest(e.Location).Item
        If lvi IsNot Nothing Then
            'MsgBox("Dos Clics: " & lvi.Index)
            'Copiar en porta papeles
            If TB_Out_PSW.Text.Length <= 0 Then
                MsgBox("Contraseña Vacia")
            Else
                My.Computer.Clipboard.SetText(TB_Out_PSW.Text.ToString) ' Copiando en PortaPapeles
                'Inicia temporizador 1000 = 1 seg & Duracion 10 Seg
                TiempoCopy.Start()
                TimeLeft = 10
                TiempoCopy.Interval = 1000
                Out_Time_Life.Visible = True
            End If
        End If
    End Sub

    Private Sub PanelDePassword_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelDePassword.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Right Then
            If PanelDePassword.SelectedItems.Count > 0 Then
                'MsgBox("Clic derecho")
            End If
        End If
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PanelDePassword.SelectedIndexChanged

        If PanelDePassword.SelectedItems.Count > 0 Then
            'MsgBox("Activar")
            ModificarToolStripMenuItem.Enabled = True
            EliminarToolStripMenuItem.Enabled = True

            NumeroFila = PanelDePassword.SelectedItems(0)
            Dim apunta As String = NumeroFila.SubItems(0).Text ' Obtiene el ID con subitem 0
            PresentarContrasenia(CInt(apunta))


        Else
            'MsgBox("Desactivar")
            ModificarToolStripMenuItem.Enabled = False
            EliminarToolStripMenuItem.Enabled = False
        End If

    End Sub
    Private Function habilitacontrol()
        If PanelDePassword.Items.Count() > 0 Then
            PanelDePassword.Enabled = True
        Else
            MsgBox("No hay datos en esta lista.")
            PanelDePassword.Enabled = False
        End If
        Return 0
    End Function

    Private Sub CB_type_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_type.SelectedIndexChanged
        If CB_type.Text = "Application" Then

            PanelDePassword.Items.Clear()
            ImprimirLista(CB_type.Text)
            habilitacontrol()

        ElseIf CB_type.Text = "WebSite" Then

            PanelDePassword.Items.Clear()
            ImprimirLista(CB_type.Text)
            habilitacontrol()

        ElseIf CB_type.Text = "Email" Then

            PanelDePassword.Items.Clear()
            ImprimirLista(CB_type.Text)
            habilitacontrol()

        ElseIf CB_type.Text = "Windows" Then

            PanelDePassword.Items.Clear()
            ImprimirLista(CB_type.Text)
            habilitacontrol()

        ElseIf CB_type.Text = "Networks" Then

            PanelDePassword.Items.Clear()
            ImprimirLista(CB_type.Text)
            habilitacontrol()
        Else
            MsgBox("Seleccione una lista a imprimir")
        End If
    End Sub

    Private Sub B_Back_Click(sender As Object, e As EventArgs) Handles B_Back.Click
        Principal.Show()
        Me.Close()
    End Sub

    Private Sub VerPass_Click(sender As Object, e As EventArgs) Handles VerPass.Click
        If PanelDePassword.SelectedItems.Count > 0 Then
            If TB_Out_PSW.UseSystemPasswordChar = True Then
                TB_Out_PSW.UseSystemPasswordChar = False
                'Inicia temporizador 1000 = 1 seg & Duracion 10 Seg
                T_lockPass.Start()
                TimeLeft1 = 3
                T_lockPass.Interval = 1000
                OutTimeView.Visible = True
            Else
                TB_Out_PSW.UseSystemPasswordChar = True
                TimeLeft1 = -1
            End If
        End If
    End Sub

    Private Sub TiempoCopy_Tick(sender As Object, e As EventArgs) Handles TiempoCopy.Tick
        If TimeLeft > 0 Then
            'Copiado en portapapeles: 10 Segundos
            Out_Time_Life.Text = "Copiado en portapapeles: " & TimeLeft & " Segundos"
            TimeLeft -= 1
        Else ' Cuando TimeLeft es 0 Limpia el PortaPeles y Detiene el Temporizador
            My.Computer.Clipboard.Clear()
            TiempoCopy.Stop()
            Out_Time_Life.Visible = False
        End If
    End Sub

    

    Private Sub T_lockPass_Tick(sender As Object, e As EventArgs) Handles T_lockPass.Tick
        If TimeLeft1 > 0 Then
            OutTimeView.Text = TimeLeft1
            TimeLeft1 -= 1
        Else ' Cuando TimeLeft es 0 Limpia vuelve a tapar la contraseña
            TB_Out_PSW.UseSystemPasswordChar = True
            T_lockPass.Stop()
            OutTimeView.Visible = False
        End If
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        If PanelDePassword.SelectedItems.Count > 0 Then
            Dim apunta As String = NumeroFila.SubItems(0).Text
            If CInt(apunta) >= 0 Then

                Dim YesOrNot As String
                Dim Pregunta As String

                Pregunta = "¿Estas Seguro de Eliminar esta Cuenta?"
                YesOrNot = MsgBox(Pregunta, vbYesNo, "Confirmar Operación")

                If YesOrNot = vbNo Then
                    'Si elige no no pasa nada xD
                Else        ' YES YES
                    EliminarItemActual(apunta)
                    amigo()

                    'Me.Hide()
                    'Servidores.Show()
                    'Servidores.LimpiaPresentacion()
                    'Servidores.ListandoHostnames()
                End If
            End If
        End If
    End Sub
    Private Function EliminarItemActual(ByVal ID As Integer)
        Dim CountNewList As Integer
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
            Dim Variable, Account, actual, ListaServidor As XmlNode
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

                If WC > 1 Then
                    CountNewList = WC - 1
                    ListaServidor = Datos.SelectSingleNode("/DataFenix/Wallet")
                    actual = Datos.SelectSingleNode("/DataFenix/Wallet/Cartera[@id='" & ID & "']")
                    ListaServidor.RemoveChild(actual)

                    For Each Account In Settings
                        Account.ChildNodes(2).InnerText = CountNewList
                    Next

                    For Renumerar As Integer = ID To (CountNewList - 1)
                        Variable = Datos.SelectSingleNode("/DataFenix/Wallet/Cartera[@id='" & Renumerar + 1 & "']")
                        Variable.Attributes.GetNamedItem("id").Value = Renumerar
                    Next

                    Datos.Save(Ruta)
                    MsgBox("Cuenta Eliminada")
                ElseIf WC = 1 Then
                    Conjunto = Datos.SelectNodes("/DataFenix/Wallet/Cartera[@id='" & ID & "']")
                    For Each Variable In Conjunto
                        Variable.ChildNodes(0).InnerText = ""
                        Variable.ChildNodes(1).InnerText = ""
                        Variable.ChildNodes(2).InnerText = ""
                        Variable.ChildNodes(3).InnerText = ""
                        Variable.ChildNodes(4).InnerText = ""
                        Variable.ChildNodes(5).InnerText = ""
                        Variable.ChildNodes(6).InnerText = ""
                        Variable.ChildNodes(7).InnerText = ""
                        Variable.ChildNodes(8).InnerText = ""
                        Variable.ChildNodes(9).InnerText = ""
                        Variable.ChildNodes(10).InnerText = ""
                        Variable.ChildNodes(11).InnerText = ""
                        Variable.ChildNodes(12).InnerText = ""
                        Variable.ChildNodes(13).InnerText = ""
                    Next

                    Settings = Datos.SelectNodes("/DataFenix/Settings")

                    For Each Account In Settings
                        Account.ChildNodes(1).InnerText = True
                        Account.ChildNodes(2).InnerText = 0
                    Next
                    Datos.Save(Ruta)
                    MsgBox("Cuenta Eliminada")
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
End Class