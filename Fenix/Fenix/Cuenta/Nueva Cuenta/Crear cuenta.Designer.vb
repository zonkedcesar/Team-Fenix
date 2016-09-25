<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Crear_cuenta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Crear_cuenta))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TB_Nombres = New System.Windows.Forms.TextBox()
        Me.TB_Apellidos = New System.Windows.Forms.TextBox()
        Me.TB_Usuario = New System.Windows.Forms.TextBox()
        Me.TB_pass = New System.Windows.Forms.TextBox()
        Me.TB_password = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TB_Email = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Back = New System.Windows.Forms.Button()
        Me.B_Registrar = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombre(s):"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(212, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Apellido(s):"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 158)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Usuario:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 184)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Contraseña:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(206, 184)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Confirma Contraseña:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TB_Nombres
        '
        Me.TB_Nombres.Location = New System.Drawing.Point(97, 75)
        Me.TB_Nombres.Name = "TB_Nombres"
        Me.TB_Nombres.Size = New System.Drawing.Size(100, 20)
        Me.TB_Nombres.TabIndex = 7
        '
        'TB_Apellidos
        '
        Me.TB_Apellidos.Location = New System.Drawing.Point(276, 75)
        Me.TB_Apellidos.Name = "TB_Apellidos"
        Me.TB_Apellidos.Size = New System.Drawing.Size(169, 20)
        Me.TB_Apellidos.TabIndex = 8
        '
        'TB_Usuario
        '
        Me.TB_Usuario.Location = New System.Drawing.Point(97, 155)
        Me.TB_Usuario.Name = "TB_Usuario"
        Me.TB_Usuario.Size = New System.Drawing.Size(100, 20)
        Me.TB_Usuario.TabIndex = 9
        '
        'TB_pass
        '
        Me.TB_pass.Location = New System.Drawing.Point(97, 181)
        Me.TB_pass.Name = "TB_pass"
        Me.TB_pass.Size = New System.Drawing.Size(100, 20)
        Me.TB_pass.TabIndex = 10
        '
        'TB_password
        '
        Me.TB_password.Location = New System.Drawing.Point(320, 181)
        Me.TB_password.Name = "TB_password"
        Me.TB_password.Size = New System.Drawing.Size(125, 20)
        Me.TB_password.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(27, 104)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Email:"
        '
        'TB_Email
        '
        Me.TB_Email.Location = New System.Drawing.Point(97, 101)
        Me.TB_Email.Name = "TB_Email"
        Me.TB_Email.Size = New System.Drawing.Size(100, 20)
        Me.TB_Email.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 54)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Datos Personales:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 134)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Credenciales:"
        '
        'Back
        '
        Me.Back.Location = New System.Drawing.Point(15, 225)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(104, 24)
        Me.Back.TabIndex = 16
        Me.Back.Text = "Regresar"
        Me.Back.UseVisualStyleBackColor = True
        '
        'B_Registrar
        '
        Me.B_Registrar.Location = New System.Drawing.Point(370, 225)
        Me.B_Registrar.Name = "B_Registrar"
        Me.B_Registrar.Size = New System.Drawing.Size(75, 23)
        Me.B_Registrar.TabIndex = 17
        Me.B_Registrar.Text = "Registrar"
        Me.B_Registrar.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(9, 19)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(237, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Por favor llena todos los campos para configurar."
        '
        'Crear_cuenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(460, 261)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.B_Registrar)
        Me.Controls.Add(Me.Back)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TB_Email)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TB_password)
        Me.Controls.Add(Me.TB_pass)
        Me.Controls.Add(Me.TB_Usuario)
        Me.Controls.Add(Me.TB_Apellidos)
        Me.Controls.Add(Me.TB_Nombres)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Crear_cuenta"
        Me.Text = "Crear Cuenta"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TB_Nombres As System.Windows.Forms.TextBox
    Friend WithEvents TB_Apellidos As System.Windows.Forms.TextBox
    Friend WithEvents TB_Usuario As System.Windows.Forms.TextBox
    Friend WithEvents TB_pass As System.Windows.Forms.TextBox
    Friend WithEvents TB_password As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TB_Email As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Back As System.Windows.Forms.Button
    Friend WithEvents B_Registrar As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
