Imports System.Xml

Public Class ConfirmarOperacionNIP
    Protected Friend Interacion As Integer

    Private Function ConsultaNIP(ByVal NIPVigente As Integer) As String
        Dim MyNip As String
        Dim UsuarioData As String = "nobody"

        Dim Ruta As String
        Ruta = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\Documents\Fenix\" + Inicio.UsuarioConect + ".fnx"
        Try
            'Declaracion de variables de entorno
            Dim Datos As XmlDocument
            Dim Variable, Account As XmlNode
            'Manipulacion de documentos XML con carga
            Datos = New XmlDocument
            Datos.Load(Ruta)
            'Lectura de NODOS para acceder al panel principal
            Account = Datos.SelectSingleNode("/Fenix/Perfil/Usuario")
            UsuarioData = Account.InnerText

            If UsuarioData = LCase(SHA512(Inicio.UsuarioConect + Inicio.psw.Text)) Then

                Variable = Datos.SelectSingleNode("/Fenix/Seguridad/NIP")
                MyNip = Variable.InnerText

            ElseIf UsuarioData = "nobody" Then
                MsgBox("Error: la base de datos " & Inicio.UsuarioConect & ".fnx - Esta corrupta por favor de contactar al administrador")
            Else
                MsgBox("Vaya usted esta intentando vulnerar este sistema, sin embargo juega con fuego por favor reconsidera tu accion")
            End If
        Catch ex As Exception
            MessageBox.Show("Error Inesperado por favor de contactar al administrador - Out: " & ex.Message)
        End Try


        Return MyNip
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles B_ConfirmarNIP.Click

        If ConsultaNIP(TB_NIP.Text) = LCase(SHA512(TB_NIP.Text + Inicio.UsuarioConect)) Then
            ChangePassword.ActualizacionPassword(TB_NIP.Text)
            Me.Hide()
            TB_NIP.Clear()
        Else
            MsgBox("NIP incorrecto")
            TB_NIP.Clear()
            TB_NIP.Focus()

        End If

        
    End Sub
    Private Sub TB_NIP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TB_NIP.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub ConfirmarOperacionNIP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TB_NIP.Focus()
    End Sub
End Class