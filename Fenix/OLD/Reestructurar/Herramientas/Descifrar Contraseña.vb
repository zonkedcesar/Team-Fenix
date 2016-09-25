Public Class Descifrar_Contraseña

    Dim EstadoVisible As Integer = 0
    Dim estadoVisible2 As Integer = 0
    Dim estadoVisible3 As Integer = 0
    Dim estadoVisible4 As Integer = 0
    Dim TimeLeft As Integer ' 10 Seg para mantener la contraseña en el portapapeles


    Private Sub CB_Cipher_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_Cipher.SelectedIndexChanged
        If CB_Cipher.Text = "AES-128" Then
            Key.Show()
            LabelKey.Show()
            SaltPass.Hide()
            LabelSalt.Hide()
            ViewPass2.Show()
            ViewPass3.Hide()
            PassOUT.Text = ""
            Key.Text = ""

        ElseIf CB_Cipher.Text = "AES-256" Then
            Key.Show()
            LabelKey.Show()
            SaltPass.Show()
            LabelSalt.Show()
            ViewPass2.Show()
            ViewPass3.Show()

            PassOUT.Text = ""
            Key.Text = ""
            SaltPass.Text = ""
        End If
    End Sub

    Private Sub ClipBoard_Click(sender As Object, e As EventArgs) Handles ClipBoard.Click
        If PassOUT.Text.Length <= 0 Then
            MsgBox("No hay Hash que copiar")
        Else
            My.Computer.Clipboard.SetText(PassOUT.Text.ToString) ' Copiando en PortaPapeles
            'Inicia temporizador 1000 = 1 seg & Duracion 10 Seg
            Timer1.Start()
            Timer1.Interval = 1000
            TimeLeft = 10
        End If
    End Sub

    Private Sub VerPass_Click(sender As Object, e As EventArgs) Handles VerPass.Click
        If PassOUT.Text.Length <= 0 Then
            MsgBox("No hay contraseña a mostrar")
        Else
            ' Muestra o Esconde La contraseña al Usuario
            If EstadoVisible = 0 Then
                PassOUT.PasswordChar = ""
                EstadoVisible = 1
            Else
                PassOUT.PasswordChar = "*"
                EstadoVisible = 0
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If CB_Cipher.Text = "AES-128" Then
            PassOUT.Text = AES_Decrypt(HashIN.Text, Key.Text)
        ElseIf CB_Cipher.Text = "AES-256" Then

            If SaltPass.Text.Length <= 0 Then
                PassOUT.Text = Decrypt(HashIN.Text, Key.Text, "PASSWORD")
            Else
                Dim AES256Descry As String
                AES256Descry = Decrypt(HashIN.Text, "HaHaHackingTeam", "hola")
                PassOUT.Text = AES256Descry
            End If
        Else
            MsgBox("Selecciona un Cipher")
        End If
    End Sub

    Private Sub ViewPass2_Click(sender As Object, e As EventArgs) Handles ViewPass2.Click
        If Key.Text.Length <= 0 Then
            MsgBox("No hay KEY que mostrar")
        Else
            ' Muestra o Esconde La contraseña al Usuario
            If estadoVisible3 = 0 Then
                Key.PasswordChar = ""
                estadoVisible3 = 1
            Else
                Key.PasswordChar = "*"
                estadoVisible3 = 0
            End If
        End If
    End Sub

    Private Sub ViewPass3_Click(sender As Object, e As EventArgs) Handles ViewPass3.Click
        If SaltPass.Text.Length <= 0 Then
            MsgBox("No hay SALT que mostrar")
        Else
            ' Muestra o Esconde La contraseña al Usuario
            If estadoVisible4 = 0 Then
                SaltPass.PasswordChar = ""
                estadoVisible4 = 1
            Else
                SaltPass.PasswordChar = "*"
                estadoVisible4 = 0
            End If
        End If
    End Sub

    Private Sub Descifrar_Contraseña_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Key.Hide()
        LabelKey.Hide()
        LabelSalt.Hide()
        SaltPass.Hide()
        ViewPass2.Hide()
        ViewPass3.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Cifrar_contraseña.Show()
        Me.Hide()

    End Sub
End Class