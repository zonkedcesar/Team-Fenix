Imports System.Security
Imports System.IO

Public Class SecureRemove
    Private Sub SecureRemove_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeOpenFileDialog()

        ' Area de sugerencias
        ToolTip1.SetToolTip(CB_SRM, "Numero de Pasadas")
        ToolTip1.SetToolTip(Check_Log, "Permite almacenar log")

    End Sub
    Public Sub InitializeOpenFileDialog()

        Me.OpenFileDialog1.InitialDirectory = "%USERPROFILE%"
        Me.OpenFileDialog1.Filter = "All files (*.*)|*.*"
        Me.OpenFileDialog1.FileName = "Archivos"
        Me.OpenFileDialog1.Multiselect = True
        Me.OpenFileDialog1.Title = "Borrado Seguro"
        Me.OpenFileDialog1.RestoreDirectory = True

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If CB_SRM.Text.Length <= 0 Then
            MsgBox("Debe Seleccionar un Algortimo de Borrado")
        Else
            Dim Completado As DialogResult = Me.OpenFileDialog1.ShowDialog()
            If (Completado = System.Windows.Forms.DialogResult.OK) Then
                'Eliminando por objeto
                Dim file As String

                For Each file In OpenFileDialog1.FileNames
                    Try
                        ConfirmarSRM.OutputSRM.Items.Add(file)
                    Catch Ex As Exception
                        MessageBox.Show("El archivo que intenta Seleccionar no Existe o esta corrupto. Original error: " & Ex.Message)
                    End Try
                Next file
                ConfirmarSRM.Show()
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim comando As String
        If CB_SRM.Text.Length <= 0 Then
            MsgBox("Debe Seleccionar un Algortimo de Borrado")
        Else

            If CB_SRM.SelectedIndex = 1 Then
                comando = " -" + "vfvr" + "s" + " " + "C:\$Recycle.Bin\*"
                Process.Start("C:\Fenix\srm.exe", comando)
            ElseIf CB_SRM.SelectedIndex = 2 Then
                comando = " -" + "vfvr" + "P" + " " + "C:\$Recycle.Bin\*"
                Process.Start("C:\Fenix\srm.exe", comando)
            ElseIf CB_SRM.SelectedIndex = 3 Then
                comando = " -" + "vfvr" + "E" + " " + "C:\$Recycle.Bin\*"
                Process.Start("C:\Fenix\srm.exe", comando)
            ElseIf CB_SRM.SelectedIndex = 4 Then
                comando = " -" + "vfvr" + "D" + " " + "C:\$Recycle.Bin\*"
                Process.Start("C:\Fenix\srm.exe", comando)
            ElseIf CB_SRM.SelectedIndex = 5 Then
                comando = " -" + "vfvr" + "C" + " " + "C:\$Recycle.Bin\*"
                Process.Start("C:\Fenix\srm.exe", comando)
            ElseIf CB_SRM.SelectedIndex = 6 Then
                comando = " -" + "vfvr" + "G" + " " + "C:\$Recycle.Bin\*"
                Process.Start("C:\Fenix\srm.exe", comando)
            End If
            Process.Start("shell:RecycleBinFolder")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim PATH As String
        If CB_SRM.Text.Length <= 0 Then
            MsgBox("Debe Seleccionar un Algortimo de Borrado")
        Else
            If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
                Dim comando As String
                PATH = FolderBrowserDialog1.SelectedPath

                If CB_SRM.SelectedIndex = 1 Then
                    comando = " -" + "vfvr" + "s" + " " + """" + PATH + """"
                    Process.Start("C:\Fenix\srm.exe", comando)
                ElseIf CB_SRM.SelectedIndex = 2 Then
                    comando = " -" + "vfvr" + "P" + " " + """" + PATH + """"
                    Process.Start("C:\Fenix\srm.exe", comando)
                ElseIf CB_SRM.SelectedIndex = 3 Then
                    comando = " -" + "vfvr" + "E" + " " + """" + PATH + """"
                    Process.Start("C:\Fenix\srm.exe", comando)
                ElseIf CB_SRM.SelectedIndex = 4 Then
                    comando = " -" + "vfvr" + "D" + " " + """" + PATH + """"
                    Process.Start("C:\Fenix\srm.exe", comando)
                ElseIf CB_SRM.SelectedIndex = 5 Then
                    comando = " -" + "vfvr" + "C" + " " + """" + PATH + """"
                    Process.Start("C:\Fenix\srm.exe", comando)
                ElseIf CB_SRM.SelectedIndex = 6 Then
                    comando = " -" + "vfvr" + "G" + " " + """" + PATH + """"
                    Process.Start("C:\Fenix\srm.exe", comando)
                End If
            End If
        End If
    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        Me.Hide()
        Principal.Show()
    End Sub
End Class