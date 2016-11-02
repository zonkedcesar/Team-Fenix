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
        Me.components = New System.ComponentModel.Container()
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
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TB_Pregunta = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TB_Respuesta = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TB_NIP = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TB_C_NIP = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombre(s):"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(212, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Apellido(s):"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Usuario:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Contraseña:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(206, 138)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Confirma Contraseña:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TB_Nombres
        '
        Me.TB_Nombres.Location = New System.Drawing.Point(97, 56)
        Me.TB_Nombres.MaxLength = 30
        Me.TB_Nombres.Name = "TB_Nombres"
        Me.TB_Nombres.Size = New System.Drawing.Size(100, 20)
        Me.TB_Nombres.TabIndex = 1
        '
        'TB_Apellidos
        '
        Me.TB_Apellidos.Location = New System.Drawing.Point(276, 56)
        Me.TB_Apellidos.MaxLength = 30
        Me.TB_Apellidos.Name = "TB_Apellidos"
        Me.TB_Apellidos.Size = New System.Drawing.Size(169, 20)
        Me.TB_Apellidos.TabIndex = 2
        '
        'TB_Usuario
        '
        Me.TB_Usuario.Location = New System.Drawing.Point(97, 106)
        Me.TB_Usuario.MaxLength = 8
        Me.TB_Usuario.Name = "TB_Usuario"
        Me.TB_Usuario.Size = New System.Drawing.Size(100, 20)
        Me.TB_Usuario.TabIndex = 3
        '
        'TB_pass
        '
        Me.TB_pass.Location = New System.Drawing.Point(97, 135)
        Me.TB_pass.MaxLength = 8
        Me.TB_pass.Name = "TB_pass"
        Me.TB_pass.Size = New System.Drawing.Size(100, 20)
        Me.TB_pass.TabIndex = 5
        Me.TB_pass.UseSystemPasswordChar = True
        '
        'TB_password
        '
        Me.TB_password.Location = New System.Drawing.Point(320, 135)
        Me.TB_password.MaxLength = 8
        Me.TB_password.Name = "TB_password"
        Me.TB_password.Size = New System.Drawing.Size(125, 20)
        Me.TB_password.TabIndex = 6
        Me.TB_password.UseSystemPasswordChar = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(206, 109)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Email:"
        '
        'TB_Email
        '
        Me.TB_Email.Location = New System.Drawing.Point(247, 106)
        Me.TB_Email.MaxLength = 20
        Me.TB_Email.Name = "TB_Email"
        Me.TB_Email.Size = New System.Drawing.Size(109, 20)
        Me.TB_Email.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 35)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Datos Personales:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 85)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Credenciales:"
        '
        'Back
        '
        Me.Back.Location = New System.Drawing.Point(15, 271)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(104, 24)
        Me.Back.TabIndex = 16
        Me.Back.Text = "Regresar"
        Me.Back.UseVisualStyleBackColor = True
        '
        'B_Registrar
        '
        Me.B_Registrar.Location = New System.Drawing.Point(370, 271)
        Me.B_Registrar.Name = "B_Registrar"
        Me.B_Registrar.Size = New System.Drawing.Size(75, 23)
        Me.B_Registrar.TabIndex = 17
        Me.B_Registrar.Text = "Registrar"
        Me.B_Registrar.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(9, 11)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(237, 13)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Por favor llena todos los campos para configurar."
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(9, 169)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(146, 13)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Recuperacion de Contraseña"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(25, 196)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(116, 13)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Pregunta de Seguridad"
        '
        'TB_Pregunta
        '
        Me.TB_Pregunta.Location = New System.Drawing.Point(160, 193)
        Me.TB_Pregunta.MaxLength = 60
        Me.TB_Pregunta.Name = "TB_Pregunta"
        Me.TB_Pregunta.Size = New System.Drawing.Size(249, 20)
        Me.TB_Pregunta.TabIndex = 7
        Me.TB_Pregunta.Text = "Una pregunta que solo yo sepa la respuesta"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(80, 222)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(61, 13)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Respuesta:"
        '
        'TB_Respuesta
        '
        Me.TB_Respuesta.Location = New System.Drawing.Point(160, 219)
        Me.TB_Respuesta.MaxLength = 30
        Me.TB_Respuesta.Name = "TB_Respuesta"
        Me.TB_Respuesta.Size = New System.Drawing.Size(170, 20)
        Me.TB_Respuesta.TabIndex = 8
        Me.TB_Respuesta.Text = "De una a dos palabras"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(116, 252)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(25, 13)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "NIP"
        '
        'TB_NIP
        '
        Me.TB_NIP.Location = New System.Drawing.Point(147, 249)
        Me.TB_NIP.MaxLength = 4
        Me.TB_NIP.Name = "TB_NIP"
        Me.TB_NIP.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TB_NIP.Size = New System.Drawing.Size(50, 20)
        Me.TB_NIP.TabIndex = 9
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(219, 252)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(72, 13)
        Me.Label14.TabIndex = 26
        Me.Label14.Text = "Confirmar NIP"
        '
        'TB_C_NIP
        '
        Me.TB_C_NIP.Location = New System.Drawing.Point(297, 249)
        Me.TB_C_NIP.MaxLength = 4
        Me.TB_C_NIP.Name = "TB_C_NIP"
        Me.TB_C_NIP.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TB_C_NIP.Size = New System.Drawing.Size(50, 20)
        Me.TB_C_NIP.TabIndex = 10
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(359, 109)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(86, 13)
        Me.Label15.TabIndex = 28
        Me.Label15.Text = "@ prosa.com.mx"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(146, 196)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(13, 13)
        Me.Label16.TabIndex = 29
        Me.Label16.Text = "¿"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(412, 196)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(13, 13)
        Me.Label17.TabIndex = 30
        Me.Label17.Text = "?"
        '
        'Crear_cuenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(459, 303)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.TB_C_NIP)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.TB_NIP)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.TB_Respuesta)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TB_Pregunta)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
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
        Me.MaximumSize = New System.Drawing.Size(475, 342)
        Me.MinimumSize = New System.Drawing.Size(475, 342)
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
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TB_Pregunta As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TB_Respuesta As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TB_NIP As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TB_C_NIP As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
End Class
