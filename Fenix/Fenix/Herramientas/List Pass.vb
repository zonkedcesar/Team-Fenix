Public Class List_Pass
    Dim Dificultad As Integer = 0
    Dim TimeLeft As Integer
    Private Sub B_Back_Click(sender As Object, e As EventArgs) Handles B_Back.Click
        Me.Hide()
        ListB_Pass.Items.Clear()
        Generador_de_Contraseñas.Show()
    End Sub
    Private Function VerDificultad()
        ' Inicia el Tester de dificultad para la password 
        If ListB_Pass.Text = "******   Lista Generada   ******" Then
            ProgressBar1.Value = 0
            LevelPass.Text = "Dificultad: ?"
        Else
            Dificultad = LevelPassword.Medir(ListB_Pass.Text)

            If Dificultad > 5 And Dificultad <= 35 Then
                LevelPass.Text = "Dificultad: Facil "
            ElseIf Dificultad > 35 And Dificultad <= 50 Then
                LevelPass.Text = "Dificultad: Regular "
            ElseIf Dificultad > 50 And Dificultad <= 75 Then
                LevelPass.Text = "Dificultad: Media "
            ElseIf Dificultad > 75 And Dificultad <= 90 Then
                LevelPass.Text = "Dificultad: Alta "
            ElseIf Dificultad > 90 And Dificultad <= 100 Then
                LevelPass.Text = "Dificultad: Muy Alta "
            Else
                LevelPass.Text = "Contraseña Vacio"
            End If
            ProgressBar1.Minimum = 0%
            ProgressBar1.Maximum = 100%
            ProgressBar1.Value = Dificultad%
        End If
        Return 0
    End Function
    Private Sub ListB_Pass_Click(sender As Object, e As EventArgs) Handles ListB_Pass.Click

        VerDificultad()

    End Sub

    Private Sub ListB_Pass_KeyDown(sender As Object, e As KeyEventArgs) Handles ListB_Pass.KeyDown
        VerDificultad()
    End Sub

    Private Sub ListB_Pass_KeyUp(sender As Object, e As KeyEventArgs) Handles ListB_Pass.KeyUp
        VerDificultad()
    End Sub

    Private Sub ListB_Pass_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ListB_Pass.MouseDoubleClick
        'ListB_Pass.Text
        If ListB_Pass.Text.Length <= 0 Then
            MsgBox("Contraseña Vacia")
        Else
            My.Computer.Clipboard.SetText(ListB_Pass.Text.ToString) ' Copiando en PortaPapeles
            'Inicia temporizador 1000 = 1 seg & Duracion 10 Seg
            T_Copy.Start()
            T_Copy.Interval = 1000
            TimeLeft = 10
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Generador_de_Contraseñas.GenMultiple()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles T_Copy.Tick
        If TimeLeft > 0 Then
            Out_Time_Life.Text = "Copiado en portapapeles: " & TimeLeft & " Segundos"
            TimeLeft -= 1
        Else ' Cuando TimeLeft es 0 Limpia el PortaPeles y Detiene el Temporizador
            My.Computer.Clipboard.Clear()
            T_Copy.Stop()
            Out_Time_Life.Text = "Contraseñas Generadas:"

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Seleccione una carpeta de destino")
        Dim PATH As String

        If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
            PATH = FolderBrowserDialog1.SelectedPath

            If ListB_Pass.Items.Count() > 0 Then
                Dim obj, archivo As Object
                Dim Ruta As String

                obj = CreateObject("Scripting.FileSystemObject")
                Ruta = PATH + "\PasswordsSecure" + ".txt"
                archivo = obj.CreateTextFile(Ruta, True)
                archivo.WriteLine("EXPORT - FENIX - GENERACION MULTIPLE DE CONTRASEÑAS")
                archivo.WriteLine("TENGAN EN CUENTA QUE NO ES SEGURO MANTENER ESTE ARCHIVO")
                archivo.WriteLine("TOTAL DE CONTRASEÑAS: " & ListB_Pass.Items.Count.ToString)
                archivo.WriteLine("FECHA DE CREACIÓN: " & DateTime.Now.ToShortDateString.ToString)
                archivo.WriteLine("----------------")

                For cuenta As Integer = 1 To ListB_Pass.Items.Count() - 1

                    Dim valor As Object = ListB_Pass.Items.Item(cuenta)

                    archivo.WriteLine(valor.ToString)

                Next
                archivo.WriteLine("----------------")
                archivo.close()
            End If
        End If
        MsgBox("Exportacion con exito archivo 'PasswordsSecure.txt' creado")
    End Sub
End Class