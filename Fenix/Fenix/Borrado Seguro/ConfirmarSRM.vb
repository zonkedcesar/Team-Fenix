Imports System.Diagnostics
Public Class ConfirmarSRM

    Private Sub Borrar_Click(sender As Object, e As EventArgs) Handles Borrar.Click
        Dim comando As String
        Dim Ruta As String = Nothing
        Dim tmp As String = Nothing

        'Crea la lista en forma horizontal
        For x As Integer = 0 To OutputSRM.Items.Count - 1
            tmp = OutputSRM.Items.Item(0)
            Ruta = Ruta + """" + tmp + """" + " "
            OutputSRM.Items.RemoveAt(0)
        Next x
        If SecureRemove.CB_SRM.SelectedIndex = 1 Then
            comando = " -" + "vfv" + "s" + " " + Ruta
            Process.Start("C:\Fenix\srm.exe", comando)
        ElseIf SecureRemove.CB_SRM.SelectedIndex = 2 Then
            comando = " -" + "vfv" + "P" + " " + Ruta
            Process.Start("C:\Fenix\srm.exe", comando)
        ElseIf SecureRemove.CB_SRM.SelectedIndex = 3 Then
            comando = " -" + "vfv" + "E" + " " + Ruta
            Process.Start("C:\Fenix\srm.exe", comando)
        ElseIf SecureRemove.CB_SRM.SelectedIndex = 4 Then
            comando = " -" + "vfv" + "D" + " " + Ruta
            Process.Start("C:\Fenix\srm.exe", comando)
        ElseIf SecureRemove.CB_SRM.SelectedIndex = 5 Then
            comando = " -" + "vfv" + "C" + " " + Ruta
            Process.Start("C:\Fenix\srm.exe", comando)
        ElseIf SecureRemove.CB_SRM.SelectedIndex = 6 Then
            comando = " -" + "vfv" + "G" + " " + Ruta
            Process.Start("C:\Fenix\srm.exe", comando)
        End If

        OutputSRM.Items.Clear()
        Me.Hide()
    End Sub
End Class