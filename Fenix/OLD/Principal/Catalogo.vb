Public Class Catalogo

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Altas.Click
        If CB_Seleccion.Text = "Sites" Then

        ElseIf CB_Seleccion.Text = "Racks" Then

        ElseIf CB_Seleccion.Text = "Equipos" Then

        ElseIf CB_Seleccion.Text = "Servidores" Then

        Else
            MsgBox("Selecciona una opcion")
        End If
    End Sub

    Private Sub Ver_Click(sender As Object, e As EventArgs) Handles Ver.Click
        If CB_Seleccion.Text = "Sites" Then

        ElseIf CB_Seleccion.Text = "Racks" Then

        ElseIf CB_Seleccion.Text = "Equipos" Then

        ElseIf CB_Seleccion.Text = "Servidores" Then

        Else
            MsgBox("Selecciona una opcion")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Info_Network.Show()
    End Sub

    Private Sub Catalogo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CB_Seleccion.SelectedIndex = 0
    End Sub

    Private Sub Modificaciones_Click(sender As Object, e As EventArgs) Handles Modificaciones.Click
        If CB_Seleccion.Text = "Sites" Then

        ElseIf CB_Seleccion.Text = "Racks" Then

        ElseIf CB_Seleccion.Text = "Equipos" Then

        ElseIf CB_Seleccion.Text = "Servidores" Then

        Else
            MsgBox("Selecciona una opcion")
        End If
    End Sub

    Private Sub Bajas_Click(sender As Object, e As EventArgs) Handles Bajas.Click
        If CB_Seleccion.Text = "Sites" Then

        ElseIf CB_Seleccion.Text = "Racks" Then

        ElseIf CB_Seleccion.Text = "Equipos" Then

        ElseIf CB_Seleccion.Text = "Servidores" Then

        Else
            MsgBox("Selecciona una opcion")
        End If
    End Sub
End Class