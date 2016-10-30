Imports System.Xml

Public Class MoreServer

    Private Function ElimianrServer()
        Dim IDServer As Integer = Servidores.puntero
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

                If SC > 1 Then
                    CountNewList = SC - 1
                    ListaServidor = Datos.SelectSingleNode("/DataFenix/Servers")
                    actual = Datos.SelectSingleNode("/DataFenix/Servers/Servidor[@id='" & IDServer & "']")
                    ListaServidor.RemoveChild(actual)

                    For Each Account In Settings
                        Account.ChildNodes(4).InnerText = CountNewList
                    Next

                    For Renumerar As Integer = IDServer To (CountNewList - 1)
                        Variable = Datos.SelectSingleNode("/DataFenix/Servers/Servidor[@id='" & Renumerar + 1 & "']")
                        Variable.Attributes.GetNamedItem("id").Value = Renumerar
                    Next

                    Datos.Save(Ruta)
                    MsgBox("Servidor Eliminado")
                    Me.Hide()
                    Servidores.Show()
                    Servidores.LimpiaPresentacion()
                    Servidores.ListandoHostnames()
                ElseIf SC = 1 Then
                    Conjunto = Datos.SelectNodes("/DataFenix/Servers/Servidor[@id='" & IDServer & "']")
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
                        Account.ChildNodes(3).InnerText = True
                        Account.ChildNodes(4).InnerText = 0
                    Next
                    Datos.Save(Ruta)
                    MsgBox("Servidor Eliminado")
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


    Private Sub B_Close_Click(sender As Object, e As EventArgs) Handles B_Close.Click
        Me.Hide()
        Servidores.Show()
    End Sub

    Private Sub B_Baja_Click(sender As Object, e As EventArgs) Handles B_Baja.Click
        Dim YesOrNot As String
        Dim Pregunta As String

        Pregunta = "¿Estas Seguro de Eliminar esta Servidor?"
        YesOrNot = MsgBox(Pregunta, vbYesNo, "Confirmar Operación")

        If YesOrNot = vbNo Then
            'Si elige no no pasa nada xD
        Else        ' YES YES
            ElimianrServer()
        End If
    End Sub
End Class