<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NuevoCuenta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NuevoCuenta))
        Me.CB_Tipo = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TB_Titulo = New System.Windows.Forms.TextBox()
        Me.TB_Usr = New System.Windows.Forms.TextBox()
        Me.TB_psw = New System.Windows.Forms.TextBox()
        Me.TB_URL = New System.Windows.Forms.TextBox()
        Me.TB_coment = New System.Windows.Forms.TextBox()
        Me.B_Save = New System.Windows.Forms.Button()
        Me.B_Cancelar = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TB_C_psw = New System.Windows.Forms.TextBox()
        Me.VerPass = New System.Windows.Forms.Button()
        Me.YESurl = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'CB_Tipo
        '
        Me.CB_Tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_Tipo.FormattingEnabled = True
        Me.CB_Tipo.Items.AddRange(New Object() {"Application", "WebSite", "Email", "Windows", "Networks"})
        Me.CB_Tipo.Location = New System.Drawing.Point(92, 12)
        Me.CB_Tipo.Name = "CB_Tipo"
        Me.CB_Tipo.Size = New System.Drawing.Size(121, 21)
        Me.CB_Tipo.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(55, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Tipo:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(69, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Titulo:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(59, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Usuario:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(41, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Contraseña:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 150)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "URL:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(105, 175)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Comentarios:"
        '
        'TB_Titulo
        '
        Me.TB_Titulo.Location = New System.Drawing.Point(122, 44)
        Me.TB_Titulo.MaxLength = 80
        Me.TB_Titulo.Name = "TB_Titulo"
        Me.TB_Titulo.Size = New System.Drawing.Size(120, 20)
        Me.TB_Titulo.TabIndex = 2
        '
        'TB_Usr
        '
        Me.TB_Usr.Location = New System.Drawing.Point(122, 70)
        Me.TB_Usr.MaxLength = 80
        Me.TB_Usr.Name = "TB_Usr"
        Me.TB_Usr.Size = New System.Drawing.Size(120, 20)
        Me.TB_Usr.TabIndex = 3
        '
        'TB_psw
        '
        Me.TB_psw.Location = New System.Drawing.Point(122, 96)
        Me.TB_psw.MaxLength = 80
        Me.TB_psw.Name = "TB_psw"
        Me.TB_psw.Size = New System.Drawing.Size(120, 20)
        Me.TB_psw.TabIndex = 4
        Me.TB_psw.UseSystemPasswordChar = True
        '
        'TB_URL
        '
        Me.TB_URL.Enabled = False
        Me.TB_URL.Location = New System.Drawing.Point(58, 147)
        Me.TB_URL.MaxLength = 80
        Me.TB_URL.Name = "TB_URL"
        Me.TB_URL.Size = New System.Drawing.Size(184, 20)
        Me.TB_URL.TabIndex = 6
        '
        'TB_coment
        '
        Me.TB_coment.Location = New System.Drawing.Point(58, 191)
        Me.TB_coment.MaxLength = 200
        Me.TB_coment.Multiline = True
        Me.TB_coment.Name = "TB_coment"
        Me.TB_coment.Size = New System.Drawing.Size(170, 60)
        Me.TB_coment.TabIndex = 7
        '
        'B_Save
        '
        Me.B_Save.Location = New System.Drawing.Point(11, 257)
        Me.B_Save.Name = "B_Save"
        Me.B_Save.Size = New System.Drawing.Size(75, 23)
        Me.B_Save.TabIndex = 8
        Me.B_Save.Text = "Guardar"
        Me.B_Save.UseVisualStyleBackColor = True
        '
        'B_Cancelar
        '
        Me.B_Cancelar.Location = New System.Drawing.Point(197, 257)
        Me.B_Cancelar.Name = "B_Cancelar"
        Me.B_Cancelar.Size = New System.Drawing.Size(75, 23)
        Me.B_Cancelar.TabIndex = 9
        Me.B_Cancelar.Text = "Cancelar"
        Me.B_Cancelar.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 128)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Conf. Contraseña:"
        '
        'TB_C_psw
        '
        Me.TB_C_psw.Location = New System.Drawing.Point(122, 122)
        Me.TB_C_psw.MaxLength = 80
        Me.TB_C_psw.Name = "TB_C_psw"
        Me.TB_C_psw.Size = New System.Drawing.Size(120, 20)
        Me.TB_C_psw.TabIndex = 5
        Me.TB_C_psw.UseSystemPasswordChar = True
        '
        'VerPass
        '
        Me.VerPass.BackColor = System.Drawing.SystemColors.Control
        Me.VerPass.Image = CType(resources.GetObject("VerPass.Image"), System.Drawing.Image)
        Me.VerPass.Location = New System.Drawing.Point(248, 96)
        Me.VerPass.Name = "VerPass"
        Me.VerPass.Size = New System.Drawing.Size(30, 20)
        Me.VerPass.TabIndex = 18
        Me.VerPass.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.VerPass.UseVisualStyleBackColor = False
        '
        'YESurl
        '
        Me.YESurl.AutoSize = True
        Me.YESurl.Location = New System.Drawing.Point(248, 149)
        Me.YESurl.Name = "YESurl"
        Me.YESurl.Size = New System.Drawing.Size(15, 14)
        Me.YESurl.TabIndex = 19
        Me.YESurl.UseVisualStyleBackColor = True
        '
        'NuevoCuenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 291)
        Me.Controls.Add(Me.YESurl)
        Me.Controls.Add(Me.VerPass)
        Me.Controls.Add(Me.TB_C_psw)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.B_Cancelar)
        Me.Controls.Add(Me.B_Save)
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
        Me.Controls.Add(Me.CB_Tipo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(300, 330)
        Me.MinimumSize = New System.Drawing.Size(300, 330)
        Me.Name = "NuevoCuenta"
        Me.Text = "Resguardar Cuenta"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CB_Tipo As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TB_Titulo As System.Windows.Forms.TextBox
    Friend WithEvents TB_Usr As System.Windows.Forms.TextBox
    Friend WithEvents TB_psw As System.Windows.Forms.TextBox
    Friend WithEvents TB_URL As System.Windows.Forms.TextBox
    Friend WithEvents TB_coment As System.Windows.Forms.TextBox
    Friend WithEvents B_Save As System.Windows.Forms.Button
    Friend WithEvents B_Cancelar As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TB_C_psw As System.Windows.Forms.TextBox
    Friend WithEvents VerPass As System.Windows.Forms.Button
    Friend WithEvents YESurl As System.Windows.Forms.CheckBox
End Class
