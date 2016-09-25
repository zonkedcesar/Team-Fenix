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

        credenciales = "/generic:" + "192.168.0.24" + " /user:" + "Win10" + " /pass:" + "P455w0rd"
        servidor = "/v " + "192.168.0.24"

        System.Diagnostics.Process.Start("cmdkey.exe", credenciales)

        System.Diagnostics.Process.Start("mstsc.exe", servidor)

        Timer1.Start()
        Timer1.Interval = 1000
        TimeLeft = 5

        'System.Diagnostics.Process.Start("cmdkey.exe", zombie)

    End Sub

    Private Sub Shell_Click(sender As Object, e As EventArgs) Handles Shell.Click
        Dim comando As String
        comando = "-ssh " + "ZonkedCesar" + "@" + "localhost" + " -pw " + "jeje"

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

    
    Private Sub CB_ServerSelect_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CB_ServerSelect.KeyPress
        'Realiza la misma accion que el Boton OK
        If Asc(e.KeyChar) = 13 Then
            B_Ok.Focus()

        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If timeLeft > 0 Then
            timeLeft -= 1
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
End Class