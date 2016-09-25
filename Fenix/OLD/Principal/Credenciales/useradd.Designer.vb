<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class useradd
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(useradd))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TB_Nempleado = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TB_Nombre = New System.Windows.Forms.TextBox()
        Me.TB_Apellidos = New System.Windows.Forms.TextBox()
        Me.TB_Correo = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TB_Comentarios = New System.Windows.Forms.TextBox()
        Me.TB_ConfirmPassword = New System.Windows.Forms.TextBox()
        Me.TB_NewPassword = New System.Windows.Forms.TextBox()
        Me.TB_Usuario = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "N° Empleado: "
        '
        'TB_Nempleado
        '
        Me.TB_Nempleado.BackColor = System.Drawing.SystemColors.Window
        Me.TB_Nempleado.Location = New System.Drawing.Point(132, 6)
        Me.TB_Nempleado.Name = "TB_Nempleado"
        Me.TB_Nempleado.Size = New System.Drawing.Size(140, 20)
        Me.TB_Nempleado.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Apellidos:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Correo:"
        '
        'TB_Nombre
        '
        Me.TB_Nombre.Location = New System.Drawing.Point(132, 32)
        Me.TB_Nombre.Name = "TB_Nombre"
        Me.TB_Nombre.Size = New System.Drawing.Size(140, 20)
        Me.TB_Nombre.TabIndex = 5
        '
        'TB_Apellidos
        '
        Me.TB_Apellidos.Location = New System.Drawing.Point(132, 58)
        Me.TB_Apellidos.Name = "TB_Apellidos"
        Me.TB_Apellidos.Size = New System.Drawing.Size(140, 20)
        Me.TB_Apellidos.TabIndex = 6
        '
        'TB_Correo
        '
        Me.TB_Correo.Location = New System.Drawing.Point(132, 84)
        Me.TB_Correo.Name = "TB_Correo"
        Me.TB_Correo.Size = New System.Drawing.Size(140, 20)
        Me.TB_Correo.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 227)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Cancelar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(197, 227)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "Registrar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 113)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Comentarios:"
        '
        'TB_Comentarios
        '
        Me.TB_Comentarios.Location = New System.Drawing.Point(132, 110)
        Me.TB_Comentarios.Name = "TB_Comentarios"
        Me.TB_Comentarios.Size = New System.Drawing.Size(140, 20)
        Me.TB_Comentarios.TabIndex = 18
        '
        'TB_ConfirmPassword
        '
        Me.TB_ConfirmPassword.Location = New System.Drawing.Point(132, 188)
        Me.TB_ConfirmPassword.Name = "TB_ConfirmPassword"
        Me.TB_ConfirmPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TB_ConfirmPassword.Size = New System.Drawing.Size(140, 20)
        Me.TB_ConfirmPassword.TabIndex = 25
        '
        'TB_NewPassword
        '
        Me.TB_NewPassword.Location = New System.Drawing.Point(132, 162)
        Me.TB_NewPassword.Name = "TB_NewPassword"
        Me.TB_NewPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TB_NewPassword.Size = New System.Drawing.Size(140, 20)
        Me.TB_NewPassword.TabIndex = 24
        '
        'TB_Usuario
        '
        Me.TB_Usuario.Location = New System.Drawing.Point(132, 136)
        Me.TB_Usuario.Name = "TB_Usuario"
        Me.TB_Usuario.Size = New System.Drawing.Size(140, 20)
        Me.TB_Usuario.TabIndex = 23
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 191)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 13)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Confirma Password:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 165)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 13)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Password:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(11, 136)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 13)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Usuario:"
        '
        'useradd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.TB_ConfirmPassword)
        Me.Controls.Add(Me.TB_NewPassword)
        Me.Controls.Add(Me.TB_Usuario)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TB_Comentarios)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TB_Correo)
        Me.Controls.Add(Me.TB_Apellidos)
        Me.Controls.Add(Me.TB_Nombre)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TB_Nempleado)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "useradd"
        Me.Text = "Alta Usuario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TB_Nempleado As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TB_Nombre As System.Windows.Forms.TextBox
    Friend WithEvents TB_Apellidos As System.Windows.Forms.TextBox
    Friend WithEvents TB_Correo As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TB_Comentarios As System.Windows.Forms.TextBox
    Friend WithEvents TB_ConfirmPassword As System.Windows.Forms.TextBox
    Friend WithEvents TB_NewPassword As System.Windows.Forms.TextBox
    Friend WithEvents TB_Usuario As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
