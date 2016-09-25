<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Servidores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Servidores))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OutPassword = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ClipBoard = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Shell = New System.Windows.Forms.Button()
        Me.Back = New System.Windows.Forms.Button()
        Me.Mas = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Remote = New System.Windows.Forms.Button()
        Me.Actualiza = New System.Windows.Forms.Button()
        Me.CB_ServerSelect = New System.Windows.Forms.ComboBox()
        Me.B_Ok = New System.Windows.Forms.Button()
        Me.OutHostname = New System.Windows.Forms.Label()
        Me.OutIP = New System.Windows.Forms.Label()
        Me.OutSO = New System.Windows.Forms.Label()
        Me.OutAmbiente = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Servidor :"
        '
        'OutPassword
        '
        Me.OutPassword.Location = New System.Drawing.Point(71, 133)
        Me.OutPassword.Name = "OutPassword"
        Me.OutPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.OutPassword.Size = New System.Drawing.Size(156, 20)
        Me.OutPassword.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Hostname :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(23, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "IP :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(185, 50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "SO :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(156, 68)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Ambiente :"
        '
        'ClipBoard
        '
        Me.ClipBoard.Image = CType(resources.GetObject("ClipBoard.Image"), System.Drawing.Image)
        Me.ClipBoard.Location = New System.Drawing.Point(233, 131)
        Me.ClipBoard.Name = "ClipBoard"
        Me.ClipBoard.Size = New System.Drawing.Size(26, 23)
        Me.ClipBoard.TabIndex = 12
        Me.ClipBoard.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(139, 183)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "SSH"
        '
        'Shell
        '
        Me.Shell.Image = CType(resources.GetObject("Shell.Image"), System.Drawing.Image)
        Me.Shell.Location = New System.Drawing.Point(174, 178)
        Me.Shell.Name = "Shell"
        Me.Shell.Size = New System.Drawing.Size(30, 23)
        Me.Shell.TabIndex = 14
        Me.Shell.UseVisualStyleBackColor = True
        '
        'Back
        '
        Me.Back.Location = New System.Drawing.Point(12, 227)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(75, 23)
        Me.Back.TabIndex = 15
        Me.Back.Text = "Regreso"
        Me.Back.UseVisualStyleBackColor = True
        '
        'Mas
        '
        Me.Mas.Location = New System.Drawing.Point(12, 96)
        Me.Mas.Name = "Mas"
        Me.Mas.Size = New System.Drawing.Size(35, 23)
        Me.Mas.TabIndex = 16
        Me.Mas.Text = "Más"
        Me.Mas.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(67, 183)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(30, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "RDP"
        '
        'Remote
        '
        Me.Remote.Image = CType(resources.GetObject("Remote.Image"), System.Drawing.Image)
        Me.Remote.Location = New System.Drawing.Point(103, 178)
        Me.Remote.Name = "Remote"
        Me.Remote.Size = New System.Drawing.Size(30, 23)
        Me.Remote.TabIndex = 18
        Me.Remote.UseVisualStyleBackColor = True
        '
        'Actualiza
        '
        Me.Actualiza.Location = New System.Drawing.Point(210, 96)
        Me.Actualiza.Name = "Actualiza"
        Me.Actualiza.Size = New System.Drawing.Size(62, 23)
        Me.Actualiza.TabIndex = 19
        Me.Actualiza.Text = "Actualizar"
        Me.Actualiza.UseVisualStyleBackColor = True
        '
        'CB_ServerSelect
        '
        Me.CB_ServerSelect.FormattingEnabled = True
        Me.CB_ServerSelect.Location = New System.Drawing.Point(71, 12)
        Me.CB_ServerSelect.Name = "CB_ServerSelect"
        Me.CB_ServerSelect.Size = New System.Drawing.Size(156, 21)
        Me.CB_ServerSelect.TabIndex = 20
        '
        'B_Ok
        '
        Me.B_Ok.Location = New System.Drawing.Point(233, 12)
        Me.B_Ok.Name = "B_Ok"
        Me.B_Ok.Size = New System.Drawing.Size(39, 23)
        Me.B_Ok.TabIndex = 21
        Me.B_Ok.Text = "OK"
        Me.B_Ok.UseVisualStyleBackColor = True
        '
        'OutHostname
        '
        Me.OutHostname.AutoSize = True
        Me.OutHostname.Location = New System.Drawing.Point(79, 50)
        Me.OutHostname.Name = "OutHostname"
        Me.OutHostname.Size = New System.Drawing.Size(39, 13)
        Me.OutHostname.TabIndex = 22
        Me.OutHostname.Text = "Label9"
        '
        'OutIP
        '
        Me.OutIP.AutoSize = True
        Me.OutIP.Location = New System.Drawing.Point(41, 68)
        Me.OutIP.Name = "OutIP"
        Me.OutIP.Size = New System.Drawing.Size(45, 13)
        Me.OutIP.TabIndex = 23
        Me.OutIP.Text = "Label10"
        '
        'OutSO
        '
        Me.OutSO.AutoSize = True
        Me.OutSO.Location = New System.Drawing.Point(219, 50)
        Me.OutSO.Name = "OutSO"
        Me.OutSO.Size = New System.Drawing.Size(45, 13)
        Me.OutSO.TabIndex = 24
        Me.OutSO.Text = "Label11"
        '
        'OutAmbiente
        '
        Me.OutAmbiente.AutoSize = True
        Me.OutAmbiente.Location = New System.Drawing.Point(219, 68)
        Me.OutAmbiente.Name = "OutAmbiente"
        Me.OutAmbiente.Size = New System.Drawing.Size(45, 13)
        Me.OutAmbiente.TabIndex = 25
        Me.OutAmbiente.Text = "Label12"
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(197, 227)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "Nuevo"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Servidores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.OutAmbiente)
        Me.Controls.Add(Me.OutSO)
        Me.Controls.Add(Me.OutIP)
        Me.Controls.Add(Me.OutHostname)
        Me.Controls.Add(Me.B_Ok)
        Me.Controls.Add(Me.Actualiza)
        Me.Controls.Add(Me.CB_ServerSelect)
        Me.Controls.Add(Me.Remote)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Mas)
        Me.Controls.Add(Me.Back)
        Me.Controls.Add(Me.Shell)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ClipBoard)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.OutPassword)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Servidores"
        Me.Text = "Servidores"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents OutPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ClipBoard As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Shell As System.Windows.Forms.Button
    Friend WithEvents Back As System.Windows.Forms.Button
    Friend WithEvents Mas As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Remote As System.Windows.Forms.Button
    Friend WithEvents Actualiza As System.Windows.Forms.Button
    Friend WithEvents CB_ServerSelect As System.Windows.Forms.ComboBox
    Friend WithEvents B_Ok As System.Windows.Forms.Button
    Friend WithEvents OutHostname As System.Windows.Forms.Label
    Friend WithEvents OutIP As System.Windows.Forms.Label
    Friend WithEvents OutSO As System.Windows.Forms.Label
    Friend WithEvents OutAmbiente As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
