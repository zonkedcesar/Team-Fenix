<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificarWaller
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModificarWaller))
        Me.VerPass = New System.Windows.Forms.Button()
        Me.TB_C_psw = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TB_coment = New System.Windows.Forms.TextBox()
        Me.TB_URL = New System.Windows.Forms.TextBox()
        Me.TB_psw = New System.Windows.Forms.TextBox()
        Me.TB_Usr = New System.Windows.Forms.TextBox()
        Me.TB_Titulo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CB_tipe = New System.Windows.Forms.ComboBox()
        Me.B_Actualizar = New System.Windows.Forms.Button()
        Me.B_cancelar = New System.Windows.Forms.Button()
        Me.CB_yesURL = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'VerPass
        '
        Me.VerPass.BackColor = System.Drawing.SystemColors.Control
        Me.VerPass.Image = CType(resources.GetObject("VerPass.Image"), System.Drawing.Image)
        Me.VerPass.Location = New System.Drawing.Point(245, 96)
        Me.VerPass.Name = "VerPass"
        Me.VerPass.Size = New System.Drawing.Size(30, 20)
        Me.VerPass.TabIndex = 33
        Me.VerPass.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.VerPass.UseVisualStyleBackColor = False
        '
        'TB_C_psw
        '
        Me.TB_C_psw.Location = New System.Drawing.Point(119, 122)
        Me.TB_C_psw.MaxLength = 80
        Me.TB_C_psw.Name = "TB_C_psw"
        Me.TB_C_psw.Size = New System.Drawing.Size(120, 20)
        Me.TB_C_psw.TabIndex = 5
        Me.TB_C_psw.UseSystemPasswordChar = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(10, 128)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 13)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Conf. Contraseña:"
        '
        'TB_coment
        '
        Me.TB_coment.Location = New System.Drawing.Point(55, 191)
        Me.TB_coment.MaxLength = 200
        Me.TB_coment.Multiline = True
        Me.TB_coment.Name = "TB_coment"
        Me.TB_coment.Size = New System.Drawing.Size(170, 60)
        Me.TB_coment.TabIndex = 7
        '
        'TB_URL
        '
        Me.TB_URL.Enabled = False
        Me.TB_URL.Location = New System.Drawing.Point(55, 147)
        Me.TB_URL.MaxLength = 80
        Me.TB_URL.Name = "TB_URL"
        Me.TB_URL.Size = New System.Drawing.Size(184, 20)
        Me.TB_URL.TabIndex = 6
        '
        'TB_psw
        '
        Me.TB_psw.Location = New System.Drawing.Point(119, 96)
        Me.TB_psw.MaxLength = 80
        Me.TB_psw.Name = "TB_psw"
        Me.TB_psw.Size = New System.Drawing.Size(120, 20)
        Me.TB_psw.TabIndex = 4
        Me.TB_psw.UseSystemPasswordChar = True
        '
        'TB_Usr
        '
        Me.TB_Usr.Location = New System.Drawing.Point(119, 70)
        Me.TB_Usr.MaxLength = 80
        Me.TB_Usr.Name = "TB_Usr"
        Me.TB_Usr.Size = New System.Drawing.Size(120, 20)
        Me.TB_Usr.TabIndex = 3
        '
        'TB_Titulo
        '
        Me.TB_Titulo.Location = New System.Drawing.Point(119, 44)
        Me.TB_Titulo.MaxLength = 80
        Me.TB_Titulo.Name = "TB_Titulo"
        Me.TB_Titulo.Size = New System.Drawing.Size(120, 20)
        Me.TB_Titulo.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(102, 175)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 13)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Comentarios:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 150)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "URL:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(38, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Contraseña:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(56, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Usuario:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(66, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Titulo:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(52, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Tipo:"
        '
        'CB_tipe
        '
        Me.CB_tipe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_tipe.FormattingEnabled = True
        Me.CB_tipe.Items.AddRange(New Object() {"Application", "WebSite", "Email", "Windows", "Networks"})
        Me.CB_tipe.Location = New System.Drawing.Point(89, 12)
        Me.CB_tipe.Name = "CB_tipe"
        Me.CB_tipe.Size = New System.Drawing.Size(121, 21)
        Me.CB_tipe.TabIndex = 1
        '
        'B_Actualizar
        '
        Me.B_Actualizar.Location = New System.Drawing.Point(12, 256)
        Me.B_Actualizar.Name = "B_Actualizar"
        Me.B_Actualizar.Size = New System.Drawing.Size(75, 23)
        Me.B_Actualizar.TabIndex = 34
        Me.B_Actualizar.Text = "Actualizar"
        Me.B_Actualizar.UseVisualStyleBackColor = True
        '
        'B_cancelar
        '
        Me.B_cancelar.Location = New System.Drawing.Point(197, 256)
        Me.B_cancelar.Name = "B_cancelar"
        Me.B_cancelar.Size = New System.Drawing.Size(75, 23)
        Me.B_cancelar.TabIndex = 35
        Me.B_cancelar.Text = "Cancelar"
        Me.B_cancelar.UseVisualStyleBackColor = True
        '
        'CB_yesURL
        '
        Me.CB_yesURL.AutoSize = True
        Me.CB_yesURL.Location = New System.Drawing.Point(245, 149)
        Me.CB_yesURL.Name = "CB_yesURL"
        Me.CB_yesURL.Size = New System.Drawing.Size(15, 14)
        Me.CB_yesURL.TabIndex = 36
        Me.CB_yesURL.UseVisualStyleBackColor = True
        '
        'ModificarWaller
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 291)
        Me.Controls.Add(Me.CB_yesURL)
        Me.Controls.Add(Me.B_cancelar)
        Me.Controls.Add(Me.B_Actualizar)
        Me.Controls.Add(Me.VerPass)
        Me.Controls.Add(Me.TB_C_psw)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TB_coment)
        Me.Controls.Add(Me.TB_URL)
        Me.Controls.Add(Me.TB_psw)
        Me.Controls.Add(Me.TB_Usr)
        Me.Controls.Add(Me.TB_Titulo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CB_tipe)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ModificarWaller"
        Me.Text = "Actualizar Datos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents VerPass As System.Windows.Forms.Button
    Friend WithEvents TB_C_psw As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TB_coment As System.Windows.Forms.TextBox
    Friend WithEvents TB_URL As System.Windows.Forms.TextBox
    Friend WithEvents TB_psw As System.Windows.Forms.TextBox
    Friend WithEvents TB_Usr As System.Windows.Forms.TextBox
    Friend WithEvents TB_Titulo As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CB_tipe As System.Windows.Forms.ComboBox
    Friend WithEvents B_Actualizar As System.Windows.Forms.Button
    Friend WithEvents B_cancelar As System.Windows.Forms.Button
    Friend WithEvents CB_yesURL As System.Windows.Forms.CheckBox
End Class
