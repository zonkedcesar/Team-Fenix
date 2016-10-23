<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registrar_Servidor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Registrar_Servidor))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TB_Rack = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TB_Modelo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TB_SerialNumber = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TB_ControlDomain = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TB_Hostname = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TB_IP = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.B_Registrar = New System.Windows.Forms.Button()
        Me.B_Cancelar = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TB_Usuario = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TB_Password = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TB_Dominio = New System.Windows.Forms.TextBox()
        Me.Check_Dominio = New System.Windows.Forms.CheckBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.VerPass = New System.Windows.Forms.Button()
        Me.TB_Site = New System.Windows.Forms.ComboBox()
        Me.TB_Ambiente = New System.Windows.Forms.ComboBox()
        Me.TB_Sistema = New System.Windows.Forms.ComboBox()
        Me.TB_Version = New System.Windows.Forms.ComboBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Site:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Rack:"
        '
        'TB_Rack
        '
        Me.TB_Rack.Location = New System.Drawing.Point(60, 62)
        Me.TB_Rack.MaxLength = 30
        Me.TB_Rack.Name = "TB_Rack"
        Me.TB_Rack.Size = New System.Drawing.Size(94, 20)
        Me.TB_Rack.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(195, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Modelo:"
        '
        'TB_Modelo
        '
        Me.TB_Modelo.Location = New System.Drawing.Point(246, 36)
        Me.TB_Modelo.MaxLength = 50
        Me.TB_Modelo.Name = "TB_Modelo"
        Me.TB_Modelo.Size = New System.Drawing.Size(129, 20)
        Me.TB_Modelo.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(164, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Serial Number:"
        '
        'TB_SerialNumber
        '
        Me.TB_SerialNumber.Location = New System.Drawing.Point(246, 65)
        Me.TB_SerialNumber.MaxLength = 50
        Me.TB_SerialNumber.Name = "TB_SerialNumber"
        Me.TB_SerialNumber.Size = New System.Drawing.Size(129, 20)
        Me.TB_SerialNumber.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 123)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Control Domain:"
        '
        'TB_ControlDomain
        '
        Me.TB_ControlDomain.Location = New System.Drawing.Point(111, 120)
        Me.TB_ControlDomain.MaxLength = 30
        Me.TB_ControlDomain.Name = "TB_ControlDomain"
        Me.TB_ControlDomain.Size = New System.Drawing.Size(100, 20)
        Me.TB_ControlDomain.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(50, 151)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Hostname"
        '
        'TB_Hostname
        '
        Me.TB_Hostname.Location = New System.Drawing.Point(111, 148)
        Me.TB_Hostname.MaxLength = 30
        Me.TB_Hostname.Name = "TB_Hostname"
        Me.TB_Hostname.Size = New System.Drawing.Size(100, 20)
        Me.TB_Hostname.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(254, 151)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(17, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "IP"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 179)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Sistema Operativo:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(217, 123)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 13)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Ambiente:"
        '
        'TB_IP
        '
        Me.TB_IP.Location = New System.Drawing.Point(277, 148)
        Me.TB_IP.MaxLength = 30
        Me.TB_IP.Name = "TB_IP"
        Me.TB_IP.Size = New System.Drawing.Size(100, 20)
        Me.TB_IP.TabIndex = 8
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(226, 179)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Version:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(18, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(131, 13)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Informacion del Hardware:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(18, 94)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(97, 13)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "Informacion Logica"
        '
        'B_Registrar
        '
        Me.B_Registrar.Location = New System.Drawing.Point(12, 295)
        Me.B_Registrar.Name = "B_Registrar"
        Me.B_Registrar.Size = New System.Drawing.Size(75, 23)
        Me.B_Registrar.TabIndex = 13
        Me.B_Registrar.Text = "Registrar"
        Me.B_Registrar.UseVisualStyleBackColor = True
        '
        'B_Cancelar
        '
        Me.B_Cancelar.Location = New System.Drawing.Point(300, 295)
        Me.B_Cancelar.Name = "B_Cancelar"
        Me.B_Cancelar.Size = New System.Drawing.Size(75, 23)
        Me.B_Cancelar.TabIndex = 14
        Me.B_Cancelar.Text = "Cancelar"
        Me.B_Cancelar.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(50, 263)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(43, 13)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "Usuario"
        '
        'TB_Usuario
        '
        Me.TB_Usuario.Location = New System.Drawing.Point(104, 260)
        Me.TB_Usuario.Name = "TB_Usuario"
        Me.TB_Usuario.Size = New System.Drawing.Size(100, 20)
        Me.TB_Usuario.TabIndex = 11
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(210, 263)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(61, 13)
        Me.Label14.TabIndex = 24
        Me.Label14.Text = "Contraseña"
        '
        'TB_Password
        '
        Me.TB_Password.Location = New System.Drawing.Point(277, 260)
        Me.TB_Password.Name = "TB_Password"
        Me.TB_Password.Size = New System.Drawing.Size(100, 20)
        Me.TB_Password.TabIndex = 12
        Me.TB_Password.UseSystemPasswordChar = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(53, 237)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(45, 13)
        Me.Label15.TabIndex = 26
        Me.Label15.Text = "Dominio"
        '
        'TB_Dominio
        '
        Me.TB_Dominio.Enabled = False
        Me.TB_Dominio.Location = New System.Drawing.Point(104, 234)
        Me.TB_Dominio.Name = "TB_Dominio"
        Me.TB_Dominio.Size = New System.Drawing.Size(100, 20)
        Me.TB_Dominio.TabIndex = 27
        Me.TB_Dominio.Text = "PROSAMX"
        '
        'Check_Dominio
        '
        Me.Check_Dominio.AutoSize = True
        Me.Check_Dominio.Location = New System.Drawing.Point(220, 236)
        Me.Check_Dominio.Name = "Check_Dominio"
        Me.Check_Dominio.Size = New System.Drawing.Size(50, 17)
        Me.Check_Dominio.TabIndex = 28
        Me.Check_Dominio.Text = "Yes?"
        Me.Check_Dominio.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(18, 211)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(68, 13)
        Me.Label16.TabIndex = 29
        Me.Label16.Text = "Credenciales"
        '
        'VerPass
        '
        Me.VerPass.BackColor = System.Drawing.SystemColors.Control
        Me.VerPass.Image = CType(resources.GetObject("VerPass.Image"), System.Drawing.Image)
        Me.VerPass.Location = New System.Drawing.Point(347, 234)
        Me.VerPass.Name = "VerPass"
        Me.VerPass.Size = New System.Drawing.Size(30, 20)
        Me.VerPass.TabIndex = 30
        Me.VerPass.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.VerPass.UseVisualStyleBackColor = False
        '
        'TB_Site
        '
        Me.TB_Site.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TB_Site.FormattingEnabled = True
        Me.TB_Site.Items.AddRange(New Object() {"Chachalacas", "Santa Fe", "Triara"})
        Me.TB_Site.Location = New System.Drawing.Point(60, 35)
        Me.TB_Site.Name = "TB_Site"
        Me.TB_Site.Size = New System.Drawing.Size(94, 21)
        Me.TB_Site.TabIndex = 1
        '
        'TB_Ambiente
        '
        Me.TB_Ambiente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TB_Ambiente.FormattingEnabled = True
        Me.TB_Ambiente.Items.AddRange(New Object() {"Desarrollo", "Producción", "Proveedor", "QA"})
        Me.TB_Ambiente.Location = New System.Drawing.Point(277, 119)
        Me.TB_Ambiente.Name = "TB_Ambiente"
        Me.TB_Ambiente.Size = New System.Drawing.Size(100, 21)
        Me.TB_Ambiente.TabIndex = 6
        '
        'TB_Sistema
        '
        Me.TB_Sistema.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TB_Sistema.FormattingEnabled = True
        Me.TB_Sistema.Items.AddRange(New Object() {"AIX", "RedHat", "Solaris SPARC", "Solaris X86", "Ubuntu Server", "Windows Server"})
        Me.TB_Sistema.Location = New System.Drawing.Point(111, 176)
        Me.TB_Sistema.Name = "TB_Sistema"
        Me.TB_Sistema.Size = New System.Drawing.Size(100, 21)
        Me.TB_Sistema.TabIndex = 9
        '
        'TB_Version
        '
        Me.TB_Version.FormattingEnabled = True
        Me.TB_Version.Location = New System.Drawing.Point(277, 176)
        Me.TB_Version.Name = "TB_Version"
        Me.TB_Version.Size = New System.Drawing.Size(100, 21)
        Me.TB_Version.TabIndex = 10
        '
        'Registrar_Servidor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(392, 329)
        Me.Controls.Add(Me.TB_Version)
        Me.Controls.Add(Me.TB_Sistema)
        Me.Controls.Add(Me.TB_Ambiente)
        Me.Controls.Add(Me.TB_Site)
        Me.Controls.Add(Me.VerPass)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Check_Dominio)
        Me.Controls.Add(Me.TB_Dominio)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.TB_Password)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.TB_Usuario)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.B_Cancelar)
        Me.Controls.Add(Me.B_Registrar)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TB_IP)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TB_Hostname)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TB_ControlDomain)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TB_SerialNumber)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TB_Modelo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TB_Rack)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Registrar_Servidor"
        Me.Text = "Registrar Servidor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TB_Rack As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TB_Modelo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TB_SerialNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TB_ControlDomain As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TB_Hostname As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TB_IP As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents B_Registrar As System.Windows.Forms.Button
    Friend WithEvents B_Cancelar As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TB_Usuario As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TB_Password As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TB_Dominio As System.Windows.Forms.TextBox
    Friend WithEvents Check_Dominio As System.Windows.Forms.CheckBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents VerPass As System.Windows.Forms.Button
    Friend WithEvents TB_Site As System.Windows.Forms.ComboBox
    Friend WithEvents TB_Ambiente As System.Windows.Forms.ComboBox
    Friend WithEvents TB_Sistema As System.Windows.Forms.ComboBox
    Friend WithEvents TB_Version As System.Windows.Forms.ComboBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
