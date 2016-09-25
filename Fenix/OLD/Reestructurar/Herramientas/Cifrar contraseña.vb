Public Class Cifrar_contraseña
    Dim EstadoVisible As Integer = 0
    Dim estadoVisible2 As Integer = 0
    Dim estadoVisible3 As Integer = 0
    Dim estadoVisible4 As Integer = 0
    Dim TimeLeft As Integer ' 10 Seg para mantener la contraseña en el portapapeles
    
    Private Sub VerPass_Click(sender As Object, e As EventArgs) Handles VerPass.Click
        If PassIN.Text.Length <= 0 Then
            MsgBox("No hay contraseña a mostrar")
        Else
            ' Muestra o Esconde La contraseña al Usuario
            If EstadoVisible = 0 Then
                PassIN.PasswordChar = ""
                EstadoVisible = 1
            Else
                PassIN.PasswordChar = "*"
                EstadoVisible = 0
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Generador_de_Contraseñas.Show()
        Me.Hide()

    End Sub

   

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If CB_Cipher.Text = "SHA-512" Then
            HashOut.Text = LCase(SHA512(PassIN.Text))
        ElseIf CB_Cipher.Text = "AES-128" Then
            HashOut.Text = LCase(AES_Encrypt(PassIN.Text, Key.Text))
        ElseIf CB_Cipher.Text = "AES-256" Then

            If SaltPass.Text.Length <= 0 Then
                HashOut.Text = LCase(Encrypt(PassIN.Text, Key.Text, "PASSWORD"))
            Else
                HashOut.Text = LCase(Encrypt(PassIN.Text, Key.Text, SaltPass.Text))
            End If
        Else
            MsgBox("Selecciona un Cipher")
        End If

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_Cipher.SelectedIndexChanged
        If CB_Cipher.Text = "AES-128" Then
            Key.Show()
            LabelKey.Show()
            SaltPass.Hide()
            LabelSalt.Hide()
            ViewPass2.Show()
            ViewPass3.Hide()
            HashOut.Text = ""
            Key.Text = ""

        ElseIf CB_Cipher.Text = "AES-256" Then
            Key.Show()
            LabelKey.Show()
            SaltPass.Show()
            LabelSalt.Show()
            ViewPass2.Show()
            ViewPass3.Show()

            HashOut.Text = ""
            Key.Text = ""
            SaltPass.Text = ""
        Else
            Key.Hide()
            LabelKey.Hide()
            SaltPass.Hide()
            LabelSalt.Hide()
            ViewPass2.Hide()
            ViewPass3.Hide()
            HashOut.Text = ""
        End If
    End Sub

    Private Sub Cifrar_contraseña_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Key.Hide()
        LabelKey.Hide()
        LabelSalt.Hide()
        SaltPass.Hide()
        ViewPass2.Hide()
        ViewPass3.Hide()

        B_Cifrar.Hide()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles ViewPass2.Click
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

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles ViewPass3.Click
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

    Private Sub ClipBoard_Click(sender As Object, e As EventArgs) Handles ClipBoard.Click
        If HashOut.Text.Length <= 0 Then
            MsgBox("No hay Hash que copiar")
        Else
            My.Computer.Clipboard.SetText(HashOut.Text.ToString) ' Copiando en PortaPapeles
            'Inicia temporizador 1000 = 1 seg & Duracion 10 Seg
            Timer1.Start()
            Timer1.Interval = 1000
            TimeLeft = 10
        End If
    End Sub
    Private Sub Timer1_Tick() Handles Timer1.Tick
        If timeLeft > 0 Then
            timeLeft -= 1
        Else ' Cuando TimeLeft es 0 Limpia el PortaPeles y Detiene el Temporizador
            My.Computer.Clipboard.Clear()
            Timer1.Stop()
        End If
    End Sub

    Private Sub PassIN_Click(sender As Object, e As EventArgs) Handles PassIN.Click
        PassIN.Text = ""
        PassIN.PasswordChar = "*"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles B_Cifrar.Click
        Descifrar_Contraseña.Show()
        Descifrar_Contraseña.HashIN.Text = HashOut.Text

        Descifrar_Contraseña.Key.Text = ""
        Descifrar_Contraseña.SaltPass.Text = ""

        Me.Hide()
    End Sub
End Class