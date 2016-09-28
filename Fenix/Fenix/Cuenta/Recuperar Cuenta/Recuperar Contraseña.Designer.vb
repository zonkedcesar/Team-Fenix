<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Recuperar_Contraseña
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Recuperar_Contraseña))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TB_Respuesta = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TB_NIP = New System.Windows.Forms.TextBox()
        Me.TB_P_Secure = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TB_User = New System.Windows.Forms.TextBox()
        Me.TB_Email = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.B_File_Account = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(110, 136)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pregunta de Seguridad"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(54, 199)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Respuesta"
        '
        'TB_Respuesta
        '
        Me.TB_Respuesta.Enabled = False
        Me.TB_Respuesta.Location = New System.Drawing.Point(118, 196)
        Me.TB_Respuesta.MaxLength = 30
        Me.TB_Respuesta.Name = "TB_Respuesta"
        Me.TB_Respuesta.Size = New System.Drawing.Size(170, 20)
        Me.TB_Respuesta.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(87, 233)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(25, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "NIP"
        '
        'TB_NIP
        '
        Me.TB_NIP.Enabled = False
        Me.TB_NIP.Location = New System.Drawing.Point(118, 230)
        Me.TB_NIP.MaxLength = 4
        Me.TB_NIP.Name = "TB_NIP"
        Me.TB_NIP.Size = New System.Drawing.Size(100, 20)
        Me.TB_NIP.TabIndex = 6
        '
        'TB_P_Secure
        '
        Me.TB_P_Secure.Enabled = False
        Me.TB_P_Secure.Location = New System.Drawing.Point(21, 162)
        Me.TB_P_Secure.MaxLength = 60
        Me.TB_P_Secure.Name = "TB_P_Secure"
        Me.TB_P_Secure.Size = New System.Drawing.Size(300, 20)
        Me.TB_P_Secure.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(12, 259)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Recuperar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(254, 259)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(44, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Usuario"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(52, 59)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Email:"
        '
        'TB_User
        '
        Me.TB_User.Location = New System.Drawing.Point(113, 24)
        Me.TB_User.MaxLength = 8
        Me.TB_User.Name = "TB_User"
        Me.TB_User.Size = New System.Drawing.Size(100, 20)
        Me.TB_User.TabIndex = 1
        '
        'TB_Email
        '
        Me.TB_Email.Location = New System.Drawing.Point(113, 56)
        Me.TB_Email.MaxLength = 12
        Me.TB_Email.Name = "TB_Email"
        Me.TB_Email.Size = New System.Drawing.Size(109, 20)
        Me.TB_Email.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(235, 59)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "@ prosa.com.mx"
        '
        'B_File_Account
        '
        Me.B_File_Account.Location = New System.Drawing.Point(129, 92)
        Me.B_File_Account.Name = "B_File_Account"
        Me.B_File_Account.Size = New System.Drawing.Size(75, 23)
        Me.B_File_Account.TabIndex = 3
        Me.B_File_Account.Text = "Archivo"
        Me.B_File_Account.UseVisualStyleBackColor = True
        '
        'Recuperar_Contraseña
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(341, 294)
        Me.Controls.Add(Me.B_File_Account)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TB_Email)
        Me.Controls.Add(Me.TB_User)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TB_P_Secure)
        Me.Controls.Add(Me.TB_NIP)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TB_Respuesta)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Recuperar_Contraseña"
        Me.Text = "Recuperar Contraseña"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TB_Respuesta As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TB_NIP As System.Windows.Forms.TextBox
    Friend WithEvents TB_P_Secure As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TB_User As System.Windows.Forms.TextBox
    Friend WithEvents TB_Email As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents B_File_Account As System.Windows.Forms.Button
End Class
