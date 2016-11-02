<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateServer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UpdateServer))
        Me.TB_U_Site = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TB_U_Rack = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TB_U_Hostname = New System.Windows.Forms.TextBox()
        Me.TB_U_IP = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TB_U_Usr = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TB_U_Psw = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.B_update = New System.Windows.Forms.Button()
        Me.B_Cancelar = New System.Windows.Forms.Button()
        Me.VerPass = New System.Windows.Forms.Button()
        Me.CB_Hostname = New System.Windows.Forms.CheckBox()
        Me.CB_IP = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'TB_U_Site
        '
        Me.TB_U_Site.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TB_U_Site.FormattingEnabled = True
        Me.TB_U_Site.Items.AddRange(New Object() {"Chachalacas", "Santa Fe", "Triara"})
        Me.TB_U_Site.Location = New System.Drawing.Point(97, 32)
        Me.TB_U_Site.Name = "TB_U_Site"
        Me.TB_U_Site.Size = New System.Drawing.Size(94, 21)
        Me.TB_U_Site.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(63, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Site:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(55, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Rack:"
        '
        'TB_U_Rack
        '
        Me.TB_U_Rack.Location = New System.Drawing.Point(97, 59)
        Me.TB_U_Rack.Name = "TB_U_Rack"
        Me.TB_U_Rack.Size = New System.Drawing.Size(94, 20)
        Me.TB_U_Rack.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Hostname:"
        '
        'TB_U_Hostname
        '
        Me.TB_U_Hostname.Enabled = False
        Me.TB_U_Hostname.Location = New System.Drawing.Point(97, 110)
        Me.TB_U_Hostname.Name = "TB_U_Hostname"
        Me.TB_U_Hostname.Size = New System.Drawing.Size(100, 20)
        Me.TB_U_Hostname.TabIndex = 7
        '
        'TB_U_IP
        '
        Me.TB_U_IP.Enabled = False
        Me.TB_U_IP.Location = New System.Drawing.Point(97, 136)
        Me.TB_U_IP.Name = "TB_U_IP"
        Me.TB_U_IP.Size = New System.Drawing.Size(100, 20)
        Me.TB_U_IP.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(70, 139)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(20, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "IP:"
        '
        'TB_U_Usr
        '
        Me.TB_U_Usr.Location = New System.Drawing.Point(97, 190)
        Me.TB_U_Usr.Name = "TB_U_Usr"
        Me.TB_U_Usr.Size = New System.Drawing.Size(100, 20)
        Me.TB_U_Usr.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(45, 193)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Usuario:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(27, 219)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Contraseña:"
        '
        'TB_U_Psw
        '
        Me.TB_U_Psw.Location = New System.Drawing.Point(97, 216)
        Me.TB_U_Psw.Name = "TB_U_Psw"
        Me.TB_U_Psw.Size = New System.Drawing.Size(100, 20)
        Me.TB_U_Psw.TabIndex = 13
        Me.TB_U_Psw.UseSystemPasswordChar = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Datos Fisicos:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 90)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Conexión:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 167)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(46, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Acceso:"
        '
        'B_update
        '
        Me.B_update.Location = New System.Drawing.Point(12, 252)
        Me.B_update.Name = "B_update"
        Me.B_update.Size = New System.Drawing.Size(75, 23)
        Me.B_update.TabIndex = 17
        Me.B_update.Text = "Actualizar"
        Me.B_update.UseVisualStyleBackColor = True
        '
        'B_Cancelar
        '
        Me.B_Cancelar.Location = New System.Drawing.Point(140, 252)
        Me.B_Cancelar.Name = "B_Cancelar"
        Me.B_Cancelar.Size = New System.Drawing.Size(75, 23)
        Me.B_Cancelar.TabIndex = 18
        Me.B_Cancelar.Text = "Cancelar"
        Me.B_Cancelar.UseVisualStyleBackColor = True
        '
        'VerPass
        '
        Me.VerPass.BackColor = System.Drawing.SystemColors.Control
        Me.VerPass.Image = CType(resources.GetObject("VerPass.Image"), System.Drawing.Image)
        Me.VerPass.Location = New System.Drawing.Point(203, 216)
        Me.VerPass.Name = "VerPass"
        Me.VerPass.Size = New System.Drawing.Size(30, 20)
        Me.VerPass.TabIndex = 31
        Me.VerPass.Text = "cc"
        Me.VerPass.UseVisualStyleBackColor = False
        '
        'CB_Hostname
        '
        Me.CB_Hostname.AutoSize = True
        Me.CB_Hostname.Location = New System.Drawing.Point(203, 113)
        Me.CB_Hostname.Name = "CB_Hostname"
        Me.CB_Hostname.Size = New System.Drawing.Size(15, 14)
        Me.CB_Hostname.TabIndex = 32
        Me.CB_Hostname.UseVisualStyleBackColor = True
        '
        'CB_IP
        '
        Me.CB_IP.AutoSize = True
        Me.CB_IP.Location = New System.Drawing.Point(203, 138)
        Me.CB_IP.Name = "CB_IP"
        Me.CB_IP.Size = New System.Drawing.Size(15, 14)
        Me.CB_IP.TabIndex = 33
        Me.CB_IP.UseVisualStyleBackColor = True
        '
        'UpdateServer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(241, 287)
        Me.Controls.Add(Me.CB_IP)
        Me.Controls.Add(Me.CB_Hostname)
        Me.Controls.Add(Me.VerPass)
        Me.Controls.Add(Me.B_Cancelar)
        Me.Controls.Add(Me.B_update)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TB_U_Psw)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TB_U_Usr)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TB_U_IP)
        Me.Controls.Add(Me.TB_U_Hostname)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TB_U_Rack)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TB_U_Site)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(257, 326)
        Me.MinimumSize = New System.Drawing.Size(257, 326)
        Me.Name = "UpdateServer"
        Me.Text = "Actualizar Servidor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TB_U_Site As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TB_U_Rack As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TB_U_Hostname As System.Windows.Forms.TextBox
    Friend WithEvents TB_U_IP As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TB_U_Usr As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TB_U_Psw As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents B_update As System.Windows.Forms.Button
    Friend WithEvents B_Cancelar As System.Windows.Forms.Button
    Friend WithEvents VerPass As System.Windows.Forms.Button
    Friend WithEvents CB_Hostname As System.Windows.Forms.CheckBox
    Friend WithEvents CB_IP As System.Windows.Forms.CheckBox
End Class
