Imports System.Data
Imports System.Xml

Public Class Principal
    Friend LoginUsuario As String
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Generador_de_Contraseñas.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Servidores.Show()
    End Sub

    Private Sub M_Credenciales_Click(sender As Object, e As EventArgs)
        Me.Hide()

    End Sub

    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Inicio.usr.Text <> LoginUsuario Or LoginUsuario.Length <= 0 Then
            MsgBox("Usted es habil con sus intenciones, no ha iniciado sesión")
            Me.Close()
        Else
            'Todo lo demas
            Dim Ruta As String
            Ruta = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\Documents\Fenix\" + LoginUsuario + ".fnx"
            Try
                'Declaracion de variables de entorno
                Dim cuenta As XmlDocument
                Dim Nombre As XmlNode
                'Manipulacion de documentos XML con carga
                cuenta = New XmlDocument

                cuenta.Load(Ruta)

                'Lectura de NODOS para acceder al panel principal
                Nombre = cuenta.SelectSingleNode("Fenix/Personal/Nombre")
                L_NombreUSR.Text = Decode64(Nombre.InnerText)
                
            Catch ex As Exception
                'MessageBox.Show("Error Inesperado " & ex.Message)
                MsgBox("Error 80")
                MsgBox("Por favor contactar al administrador inmediatamente")
                Close()
            End Try

        End If
    End Sub

    Private Sub LogOut_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Inicio.Show()
    End Sub


    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        TestPassword.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs)

        Me.Hide()

    End Sub

    Private Sub B_Generador_Click(sender As Object, e As EventArgs) Handles B_Generador.Click
        Generador_de_Contraseñas.Show()

    End Sub

    Private Sub B_Cartera_Click(sender As Object, e As EventArgs) Handles B_Cartera.Click
        Wallet.Show()
        'Me.Hide()
    End Sub

    Private Sub B_Sesion_Click(sender As Object, e As EventArgs) Handles B_Sesion.Click
        Servidores.Show()


    End Sub

    Private Sub B_Borrado_Click(sender As Object, e As EventArgs) Handles B_Borrado.Click
        SecureRemove.Show()

    End Sub


    Private Sub CambiarNIPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CambiarNIPToolStripMenuItem.Click
        changeNip.Show()
    End Sub

    Private Sub CambiarContraseñaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CambiarContraseñaToolStripMenuItem.Click
        ChangePassword.Show()
    End Sub

    Private Sub PreguntaSecretaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PreguntaSecretaToolStripMenuItem.Click
        ChangeQuestion.Show()
    End Sub

    Private Sub Salir_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Inicio.Show()
        Inicio.psw.Clear()
    End Sub

    Private Sub logoff_Click(sender As Object, e As EventArgs) Handles logoff.Click
        Me.Close()
        Inicio.Show()
        Inicio.psw.Clear()
        Inicio.psw.Focus()
    End Sub
    Private Function Liberando()
        Servidores.Close()
        Generador_de_Contraseñas.Close()
        SecureRemove.Close()
        Return 0
    End Function
End Class