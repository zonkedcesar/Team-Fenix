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
        Me.B_Mas = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Remote = New System.Windows.Forms.Button()
        Me.B_Actualiza = New System.Windows.Forms.Button()
        Me.CB_ServerSelect = New System.Windows.Forms.ComboBox()
        Me.OutHostname = New System.Windows.Forms.Label()
        Me.OutIP = New System.Windows.Forms.Label()
        Me.OutSO = New System.Windows.Forms.Label()
        Me.OutAmbiente = New System.Windows.Forms.Label()
        Me.T_Token = New System.Windows.Forms.Timer(Me.components)
        Me.T_Copy = New System.Windows.Forms.Timer(Me.components)
        Me.B_Nuevo = New System.Windows.Forms.Button()
        Me.OutUsr = New System.Windows.Forms.Label()
        Me.VerPass = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.T_lockPass = New System.Windows.Forms.Timer(Me.components)
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Out_Time_Life = New System.Windows.Forms.Label()
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
        Me.OutPassword.Enabled = False
        Me.OutPassword.Location = New System.Drawing.Point(71, 133)
        Me.OutPassword.Name = "OutPassword"
        Me.OutPassword.ReadOnly = True
        Me.OutPassword.Size = New System.Drawing.Size(156, 20)
        Me.OutPassword.TabIndex = 5
        Me.OutPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OutPassword.UseSystemPasswordChar = True
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
        Me.ClipBoard.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.ClipBoard, "10 seg. copiado en el portapapeles")
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
        Me.Shell.TabIndex = 5
        Me.Shell.UseVisualStyleBackColor = True
        '
        'Back
        '
        Me.Back.Location = New System.Drawing.Point(12, 227)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(75, 23)
        Me.Back.TabIndex = 9
        Me.Back.Text = "Regreso"
        Me.Back.UseVisualStyleBackColor = True
        '
        'B_Mas
        '
        Me.B_Mas.Enabled = False
        Me.B_Mas.Location = New System.Drawing.Point(12, 96)
        Me.B_Mas.Name = "B_Mas"
        Me.B_Mas.Size = New System.Drawing.Size(35, 23)
        Me.B_Mas.TabIndex = 6
        Me.B_Mas.Text = "Más"
        Me.B_Mas.UseVisualStyleBackColor = True
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
        Me.Remote.TabIndex = 4
        Me.Remote.UseVisualStyleBackColor = True
        '
        'B_Actualiza
        '
        Me.B_Actualiza.Enabled = False
        Me.B_Actualiza.Location = New System.Drawing.Point(210, 96)
        Me.B_Actualiza.Name = "B_Actualiza"
        Me.B_Actualiza.Size = New System.Drawing.Size(62, 23)
        Me.B_Actualiza.TabIndex = 7
        Me.B_Actualiza.Text = "Actualizar"
        Me.B_Actualiza.UseVisualStyleBackColor = True
        '
        'CB_ServerSelect
        '
        Me.CB_ServerSelect.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CB_ServerSelect.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CB_ServerSelect.FormattingEnabled = True
        Me.CB_ServerSelect.ItemHeight = 13
        Me.CB_ServerSelect.Location = New System.Drawing.Point(71, 12)
        Me.CB_ServerSelect.Name = "CB_ServerSelect"
        Me.CB_ServerSelect.Size = New System.Drawing.Size(156, 21)
        Me.CB_ServerSelect.TabIndex = 1
        '
        'OutHostname
        '
        Me.OutHostname.AutoSize = True
        Me.OutHostname.Location = New System.Drawing.Point(79, 50)
        Me.OutHostname.Name = "OutHostname"
        Me.OutHostname.Size = New System.Drawing.Size(0, 13)
        Me.OutHostname.TabIndex = 22
        '
        'OutIP
        '
        Me.OutIP.AutoSize = True
        Me.OutIP.Location = New System.Drawing.Point(41, 68)
        Me.OutIP.Name = "OutIP"
        Me.OutIP.Size = New System.Drawing.Size(0, 13)
        Me.OutIP.TabIndex = 23
        '
        'OutSO
        '
        Me.OutSO.AutoSize = True
        Me.OutSO.Location = New System.Drawing.Point(219, 50)
        Me.OutSO.Name = "OutSO"
        Me.OutSO.Size = New System.Drawing.Size(0, 13)
        Me.OutSO.TabIndex = 24
        '
        'OutAmbiente
        '
        Me.OutAmbiente.AutoSize = True
        Me.OutAmbiente.Location = New System.Drawing.Point(219, 68)
        Me.OutAmbiente.Name = "OutAmbiente"
        Me.OutAmbiente.Size = New System.Drawing.Size(0, 13)
        Me.OutAmbiente.TabIndex = 25
        '
        'T_Token
        '
        '
        'T_Copy
        '
        '
        'B_Nuevo
        '
        Me.B_Nuevo.Location = New System.Drawing.Point(197, 227)
        Me.B_Nuevo.Name = "B_Nuevo"
        Me.B_Nuevo.Size = New System.Drawing.Size(75, 23)
        Me.B_Nuevo.TabIndex = 8
        Me.B_Nuevo.Text = "Nuevo"
        Me.B_Nuevo.UseVisualStyleBackColor = True
        '
        'OutUsr
        '
        Me.OutUsr.AutoSize = True
        Me.OutUsr.Location = New System.Drawing.Point(100, 101)
        Me.OutUsr.Name = "OutUsr"
        Me.OutUsr.Size = New System.Drawing.Size(0, 13)
        Me.OutUsr.TabIndex = 27
        '
        'VerPass
        '
        Me.VerPass.BackColor = System.Drawing.SystemColors.Control
        Me.VerPass.Image = CType(resources.GetObject("VerPass.Image"), System.Drawing.Image)
        Me.VerPass.Location = New System.Drawing.Point(15, 152)
        Me.VerPass.Name = "VerPass"
        Me.VerPass.Size = New System.Drawing.Size(30, 20)
        Me.VerPass.TabIndex = 3
        Me.VerPass.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.ToolTip1.SetToolTip(Me.VerPass, "3 Seg. Mostrar contraseña")
        Me.VerPass.UseVisualStyleBackColor = False
        '
        'T_lockPass
        '
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(67, 101)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(32, 13)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "User:"
        '
        'Out_Time_Life
        '
        Me.Out_Time_Life.AutoSize = True
        Me.Out_Time_Life.Location = New System.Drawing.Point(41, 207)
        Me.Out_Time_Life.MaximumSize = New System.Drawing.Size(200, 13)
        Me.Out_Time_Life.MinimumSize = New System.Drawing.Size(200, 13)
        Me.Out_Time_Life.Name = "Out_Time_Life"
        Me.Out_Time_Life.Size = New System.Drawing.Size(200, 13)
        Me.Out_Time_Life.TabIndex = 29
        Me.Out_Time_Life.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Out_Time_Life.Visible = False
        '
        'Servidores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.Out_Time_Life)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.VerPass)
        Me.Controls.Add(Me.OutUsr)
        Me.Controls.Add(Me.B_Nuevo)
        Me.Controls.Add(Me.OutAmbiente)
        Me.Controls.Add(Me.OutSO)
        Me.Controls.Add(Me.OutIP)
        Me.Controls.Add(Me.OutHostname)
        Me.Controls.Add(Me.B_Actualiza)
        Me.Controls.Add(Me.CB_ServerSelect)
        Me.Controls.Add(Me.Remote)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.B_Mas)
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
        Me.Location = New System.Drawing.Point(450, 150)
        Me.MaximumSize = New System.Drawing.Size(300, 301)
        Me.MinimumSize = New System.Drawing.Size(300, 301)
        Me.Name = "Servidores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
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
    Friend WithEvents B_Mas As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Remote As System.Windows.Forms.Button
    Friend WithEvents B_Actualiza As System.Windows.Forms.Button
    Friend WithEvents CB_ServerSelect As System.Windows.Forms.ComboBox
    Friend WithEvents OutHostname As System.Windows.Forms.Label
    Friend WithEvents OutIP As System.Windows.Forms.Label
    Friend WithEvents OutSO As System.Windows.Forms.Label
    Friend WithEvents OutAmbiente As System.Windows.Forms.Label
    Friend WithEvents T_Token As System.Windows.Forms.Timer
    Friend WithEvents T_Copy As System.Windows.Forms.Timer
    Friend WithEvents B_Nuevo As System.Windows.Forms.Button
    Friend WithEvents OutUsr As System.Windows.Forms.Label
    Friend WithEvents VerPass As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents T_lockPass As System.Windows.Forms.Timer
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Out_Time_Life As System.Windows.Forms.Label
End Class
