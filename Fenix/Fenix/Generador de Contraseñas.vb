Imports System.Threading
Public Class Generador_de_Contraseñas

    Dim activos As Integer = 0  ' Opciones seleccionadas
    Dim EstadoVisible As Integer = 0    ' Variable para mostrar contraseña
    Dim TimeLeft As Integer ' 10 Seg para mantener la contraseña en el portapapeles

    Dim GranString() As String = Nothing
    Dim Numero() As String = {"1", "2", "3", "4", "5", "6", "7", "8", "9", "0"}
    Dim Minuscula() As String = {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "w", "v", "x", "y", "z"}
    Dim Mayuscula() As String = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "W", "V", "X", "Y", "Z"}
    Dim Caracteres() As String = {"!", "@", "#", "$", "%", "&", "*", "(", ")", "_", "-", "+", "=", "¿", "?", "[", "]", "{", "}", "|", ":", ".", ";", "<", ">", ","}
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Generar.Click
        If Number_Gen.Value.ToString < 2 Then
        
        Dim Dificultad As Integer = 0
        ' Pasar numero de combinaciones a valores

        If Mayusculas.CheckState = CheckState.Checked Then
            activos = activos + 1
            If GranString Is Nothing Then
                GranString = Mayuscula
            Else
                GranString = GranString.Concat(Mayuscula).ToArray
            End If
        End If
        If Minusculas.CheckState = CheckState.Checked Then
            activos = activos + 1
            If GranString Is Nothing Then
                GranString = Minuscula
            Else
                GranString = GranString.Concat(Minuscula).ToArray
            End If
        End If
        If Numeros.CheckState = CheckState.Checked Then
            activos = activos + 1
            If GranString Is Nothing Then
                GranString = Numero
            Else
                GranString = GranString.Concat(Numero).ToArray
            End If
        End If
        If Simbolos.CheckState = CheckState.Checked Then
            activos = activos + 1
            If GranString Is Nothing Then
                GranString = Caracteres
            Else
                GranString = GranString.Concat(Caracteres).ToArray
            End If
        End If

        ' Almenos 1 checked Activado & MinLong Establecido
        If activos < 1 Then
            MsgBox("Debe Seleccionar Minimo Una Opcion Para Generar Un Password")
        ElseIf CB_MinLong.Text.Length = 0 Then
            MsgBox("Debe establecer una minima Longitud")
        Else
            ' Limita el Maximo dependiendo los parametros
            Randomize()
            Dim NewPass As String = ""
                Dim TempPass As String = ""

                'Cuando el Operador quiera resetear el CBMax RESETEAR
                If CB_MaxLong.Text = "-" Then
                    Dim seleccion As String = CB_MinLong.Text
                    CB_MaxLong.Items.Clear()
                    'Evita mantener el while activo
                    If CB_MinLong.SelectedIndex <> -1 Then
                        ' Contruir el Max CB desde la primera Seleccion
                        CB_MaxLong.Items.Add("-")
                        While seleccion < 35

                            CB_MaxLong.Items.Add(seleccion + 1)
                            seleccion = seleccion + 1
                        End While
                    End If
                End If

            ' Activacion de Max & Min o ELSE simplemente Min
            If CB_MaxLong.Text.Length > 0 Then
                Dim Longitud As Integer = 0
                ' Filtra la longitud Max y Min con 2 filtros de reajuste
                While Longitud > CB_MaxLong.Text Or Longitud < CB_MinLong.Text
                    Longitud = CInt(Int((CB_MaxLong.Text * Rnd()) + CB_MinLong.Text))
                End While

                Dim Absoluto As Integer = GranString.Length

                While Longitud > 0
                    Dim variantes As Integer = CInt(Int((Absoluto * Rnd()) + 1)) - 1
                    TempPass = GranString(variantes)

                    If NewPass.Length > 0 Then
                        NewPass = NewPass + TempPass
                    Else
                        NewPass = TempPass
                    End If
                    Longitud -= 1
                End While
            Else
                Dim Longitud As Integer = CB_MinLong.Text
                Dim Absoluto As Integer = GranString.Length
                ' While para formar la cadena de de longitud MIN
                While Longitud > 0
                    Dim variantes As Integer = CInt(Int((Absoluto * Rnd()) + 1)) - 1
                    TempPass = GranString(variantes)

                    If NewPass.Length > 0 Then
                        NewPass = NewPass + TempPass
                    Else
                        NewPass = TempPass
                    End If
                    Longitud -= 1
                End While
            End If

            GenPass.Text = NewPass
            GranString = Nothing
            activos = 0

            ' Inicia el Tester de dificultad para la password 

            Dificultad = LevelPassword.Medir(GenPass.Text)

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

            'Si selecciona 1 y esta abierta la ventana de lista cerrar
            List_Pass.Hide()
            List_Pass.ListB_Pass.Items.Clear()

        Else
            'Inicia 
            ' Ciclo repetitivo para generar contraseñas concatenadas
            Dim Dificultad As Integer = 0
            ' Pasar numero de combinaciones a valores

            If Mayusculas.CheckState = CheckState.Checked Then
                activos = activos + 1
                If GranString Is Nothing Then
                    GranString = Mayuscula
                Else
                    GranString = GranString.Concat(Mayuscula).ToArray
                End If
            End If
            If Minusculas.CheckState = CheckState.Checked Then
                activos = activos + 1
                If GranString Is Nothing Then
                    GranString = Minuscula
                Else
                    GranString = GranString.Concat(Minuscula).ToArray
                End If
            End If
            If Numeros.CheckState = CheckState.Checked Then
                activos = activos + 1
                If GranString Is Nothing Then
                    GranString = Numero
                Else
                    GranString = GranString.Concat(Numero).ToArray
                End If
            End If
            If Simbolos.CheckState = CheckState.Checked Then
                activos = activos + 1
                If GranString Is Nothing Then
                    GranString = Caracteres
                Else
                    GranString = GranString.Concat(Caracteres).ToArray
                End If
            End If
            ' Almenos 1 checked Activado & MinLong Establecido
            If activos < 1 Then
                MsgBox("Debe Seleccionar Minimo Una Opcion Para Generar Un Password")
            ElseIf CB_MinLong.Text.Length = 0 Then
                MsgBox("Debe establecer una minima Longitud")
            Else

                'Limpieza del primer panel
                GenPass.Text = ""
                ProgressBar1.Value = 0
                LevelPass.Text = "Dificultad: ?"
                GenPass.PasswordChar = "*"
                'Termina la limpieza

                Dim ListGen As Integer = Number_Gen.Value.ToString
                List_Pass.ListB_Pass.Items.Add("******   Lista Generada   ******")
                While ListGen > 0


                    ' Limita el Maximo dependiendo los parametros
                    Randomize()
                    Dim NewPass As String = ""
                    Dim TempPass As String = ""

                    ' Activacion de Max & Min o ELSE simplemente Min
                    If CB_MaxLong.Text.Length > 0 Then
                        Dim Longitud As Integer = 0
                        ' Filtra la longitud Max y Min con 2 filtros de reajuste
                        While Longitud > CB_MaxLong.Text Or Longitud < CB_MinLong.Text
                            Longitud = CInt(Int((CB_MaxLong.Text * Rnd()) + CB_MinLong.Text))
                        End While

                        Dim Absoluto As Integer = GranString.Length

                        While Longitud > 0
                            Dim variantes As Integer = CInt(Int((Absoluto * Rnd()) + 1)) - 1
                            TempPass = GranString(variantes)

                            If NewPass.Length > 0 Then
                                NewPass = NewPass + TempPass
                            Else
                                NewPass = TempPass
                            End If
                            Longitud -= 1
                        End While
                    Else
                        Dim Longitud As Integer = CB_MinLong.Text
                        Dim Absoluto As Integer = GranString.Length
                        ' While para formar la cadena de de longitud MIN
                        While Longitud > 0
                            Dim variantes As Integer = CInt(Int((Absoluto * Rnd()) + 1)) - 1
                            TempPass = GranString(variantes)

                            If NewPass.Length > 0 Then
                                NewPass = NewPass + TempPass
                            Else
                                NewPass = TempPass
                            End If
                            Longitud -= 1
                        End While
                    End If

                    List_Pass.ListB_Pass.Items.Add(NewPass)
                    'GenPass.Text = NewPass
                    'GranString = Nothing
                    activos = 0
                    ListGen -= 1
                End While
                List_Pass.Show()
                ' Termina Ciclo WHILE
                GranString = Nothing
            End If
            End If
    End Sub


    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        Me.Hide()
        List_Pass.Hide()
        Principal.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles VerPass.Click
        If GenPass.Text.Length <= 0 Then
            MsgBox("No has generado una contraseña")
        Else
            ' Muestra o Esconde La contraseña al Usuario
            If EstadoVisible = 0 Then
                GenPass.PasswordChar = ""
                EstadoVisible = 1
            Else
                GenPass.PasswordChar = "*"
                EstadoVisible = 0
            End If
        End If
    End Sub

    Private Sub ClipBoardCopy_Click(sender As Object, e As EventArgs) Handles ClipBoardCopy.Click
        If GenPass.Text.Length <= 0 Then
            MsgBox("No has generado una contraseña")
        Else
            My.Computer.Clipboard.SetText(GenPass.Text.ToString) ' Copiando en PortaPapeles
            'Inicia temporizador 1000 = 1 seg & Duracion 10 Seg
            Timer1.Start()
            Timer1.Interval = 1000
            TimeLeft = 10
        End If
    End Sub

    ' Cuando Se Inicia el Temporizador se llama esta Instruccion
    ' 1 Seg que pasa hace la comparacion restando a TimeLeft 1 Seg
    Private Sub Timer1_Tick() Handles Timer1.Tick
        If TimeLeft > 0 Then
            TimeLeft -= 1
        Else ' Cuando TimeLeft es 0 Limpia el PortaPeles y Detiene el Temporizador
            My.Computer.Clipboard.Clear()
            Timer1.Stop()
        End If
    End Sub

    Private Sub CB_MinLong_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_MinLong.SelectedIndexChanged
        Dim seleccion As String = CB_MinLong.Text
        CB_MaxLong.Items.Clear()
        'Evita mantener el while activo
        If CB_MinLong.SelectedIndex <> -1 Then
            ' Contruir el Max CB desde la primera Seleccion
            CB_MaxLong.Items.Add("-")
            While seleccion < 35

                CB_MaxLong.Items.Add(seleccion + 1)
                seleccion = seleccion + 1
            End While
        End If
    End Sub

    Private Sub Cifrar_Click(sender As Object, e As EventArgs) Handles Cifrar.Click
        Cifrar_contraseña.Show()

        'Control de Cifear_contraseña
        'Cifrar_contraseña.PassIN.Text = GenPass.Text   NUEVA VERSION EN controladores
        Cifrar_contraseña.CB_Cipher.SelectedIndex = -1
        Cifrar_contraseña.Key.Hide()
        Cifrar_contraseña.LabelKey.Hide()
        Cifrar_contraseña.SaltPass.Hide()
        Cifrar_contraseña.LabelSalt.Hide()
        Cifrar_contraseña.ViewPass2.Hide()
        Cifrar_contraseña.ViewPass3.Hide()

        Cifrar_contraseña.Key.Text = ""
        Cifrar_contraseña.SaltPass.Text = ""
        Cifrar_contraseña.HashOut.Text = ""

        'Controladores
        If GenPass.Text.Length <= 0 Then
            Cifrar_contraseña.PassIN.PasswordChar = ""
            Cifrar_contraseña.PassIN.Text = "INGRESAR PASSWORD"
        Else
            Cifrar_contraseña.PassIN.Text = GenPass.Text
        End If

        Me.Hide()

    End Sub

    Private Sub CB_MaxLong_Click(sender As Object, e As EventArgs) Handles CB_MaxLong.Click
        If CB_MinLong.SelectedIndex = -1 Then
            MsgBox("Seleccione una minima longitud")
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Clear.Click
        CB_MaxLong.SelectedIndex = -1
        CB_MinLong.SelectedIndex = -1
        Mayusculas.Checked = False
        Minusculas.Checked = False
        Numeros.Checked = False
        Simbolos.Checked = False
        GenPass.Text = ""
        ProgressBar1.Value = 0
        LevelPass.Text = "Dificultad: ?"
        GenPass.PasswordChar = "*"
    End Sub


    Private Sub CB_MaxLong_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_MaxLong.SelectedIndexChanged

    End Sub
End Class