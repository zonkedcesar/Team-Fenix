Public Class New_Account

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles B_Crear.Click
        Contraseña.Show()
        Me.Enabled = False
    End Sub

    Private Sub New_Account_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Seguro de llenado de formulario
        B_Crear.Enabled = False

        ' Area de sugerencias ToolTip
        ToolTip1.SetToolTip(TB_Perfil, "Este sera el nombre de tu cuenta")
        ToolTip1.SetToolTip(TB_Nombre, "Este sera el nombre de tu cuenta")
        ToolTip1.SetToolTip(TB_Apellido, "Este sera el nombre de tu cuenta")
        ToolTip1.SetToolTip(TB_Email, "Este sera el nombre de tu cuenta")
        ToolTip1.SetToolTip(TB_N_empleado, "Este sera el nombre de tu cuenta")

    End Sub

   
    Private Sub TB_Perfil_TextChanged(sender As Object, e As EventArgs) Handles TB_Perfil.TextChanged
        ' Revisar todos los campos llenos
        B_Crear.Enabled = TB_Perfil.Text.Length > 0 And TB_Nombre.Text.Length > 0 And TB_Apellido.Text.Length > 0 And TB_Email.Text.Length > 0 And TB_N_empleado.Text.Length > 0
    End Sub

    Private Sub TB_Nombre_TextChanged(sender As Object, e As EventArgs) Handles TB_Nombre.TextChanged
        ' Revisar todos los campos llenos
        B_Crear.Enabled = TB_Perfil.Text.Length > 0 And TB_Nombre.Text.Length > 0 And TB_Apellido.Text.Length > 0 And TB_Email.Text.Length > 0 And TB_N_empleado.Text.Length > 0
    End Sub

    Private Sub TB_Apellido_TextChanged(sender As Object, e As EventArgs) Handles TB_Apellido.TextChanged
        ' Revisar todos los campos llenos
        B_Crear.Enabled = TB_Perfil.Text.Length > 0 And TB_Nombre.Text.Length > 0 And TB_Apellido.Text.Length > 0 And TB_Email.Text.Length > 0 And TB_N_empleado.Text.Length > 0
    End Sub

    Private Sub TB_Email_TextChanged(sender As Object, e As EventArgs) Handles TB_Email.TextChanged
        ' Revisar todos los campos llenos
        B_Crear.Enabled = TB_Perfil.Text.Length > 0 And TB_Nombre.Text.Length > 0 And TB_Apellido.Text.Length > 0 And TB_Email.Text.Length > 0 And TB_N_empleado.Text.Length > 0
    End Sub

    Private Sub TB_N_empleado_TextChanged(sender As Object, e As EventArgs) Handles TB_N_empleado.TextChanged
        ' Revisar todos los campos llenos
        B_Crear.Enabled = TB_Perfil.Text.Length > 0 And TB_Nombre.Text.Length > 0 And TB_Apellido.Text.Length > 0 And TB_Email.Text.Length > 0 And TB_N_empleado.Text.Length > 0
    End Sub
End Class