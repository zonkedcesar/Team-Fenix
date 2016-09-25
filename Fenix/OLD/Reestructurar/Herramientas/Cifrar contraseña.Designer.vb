<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cifrar_contraseña
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cifrar_contraseña))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PassIN = New System.Windows.Forms.TextBox()
        Me.VerPass = New System.Windows.Forms.Button()
        Me.HashOut = New System.Windows.Forms.TextBox()
        Me.CB_Cipher = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Key = New System.Windows.Forms.TextBox()
        Me.LabelKey = New System.Windows.Forms.Label()
        Me.LabelSalt = New System.Windows.Forms.Label()
        Me.SaltPass = New System.Windows.Forms.TextBox()
        Me.ViewPass2 = New System.Windows.Forms.Button()
        Me.ViewPass3 = New System.Windows.Forms.Button()
        Me.ClipBoard = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.B_Cifrar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Password:"
        '
        'PassIN
        '
        Me.PassIN.Location = New System.Drawing.Point(74, 18)
        Me.PassIN.Name = "PassIN"
        Me.PassIN.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PassIN.Size = New System.Drawing.Size(162, 20)
        Me.PassIN.TabIndex = 1
        '
        'VerPass
        '
        Me.VerPass.BackColor = System.Drawing.SystemColors.Control
        Me.VerPass.Image = CType(resources.GetObject("VerPass.Image"), System.Drawing.Image)
        Me.VerPass.Location = New System.Drawing.Point(242, 17)
        Me.VerPass.Name = "VerPass"
        Me.VerPass.Size = New System.Drawing.Size(30, 20)
        Me.VerPass.TabIndex = 10
        Me.VerPass.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.VerPass.UseVisualStyleBackColor = False
        '
        'HashOut
        '
        Me.HashOut.Location = New System.Drawing.Point(12, 163)
        Me.HashOut.Name = "HashOut"
        Me.HashOut.Size = New System.Drawing.Size(221, 20)
        Me.HashOut.TabIndex = 11
        '
        'CB_Cipher
        '
        Me.CB_Cipher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_Cipher.FormattingEnabled = True
        Me.CB_Cipher.Items.AddRange(New Object() {"SHA-512", "AES-128", "AES-256"})
        Me.CB_Cipher.Location = New System.Drawing.Point(74, 49)
        Me.CB_Cipher.Name = "CB_Cipher"
        Me.CB_Cipher.Size = New System.Drawing.Size(72, 21)
        Me.CB_Cipher.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Cipher:"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(15, 219)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Regresar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(125, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Hash"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(197, 49)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 17
        Me.Button3.Text = "Cifrar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Key
        '
        Me.Key.Location = New System.Drawing.Point(74, 78)
        Me.Key.Name = "Key"
        Me.Key.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Key.Size = New System.Drawing.Size(162, 20)
        Me.Key.TabIndex = 18
        '
        'LabelKey
        '
        Me.LabelKey.AutoSize = True
        Me.LabelKey.Location = New System.Drawing.Point(12, 81)
        Me.LabelKey.Name = "LabelKey"
        Me.LabelKey.Size = New System.Drawing.Size(28, 13)
        Me.LabelKey.TabIndex = 19
        Me.LabelKey.Text = "Key:"
        '
        'LabelSalt
        '
        Me.LabelSalt.AutoSize = True
        Me.LabelSalt.Location = New System.Drawing.Point(12, 111)
        Me.LabelSalt.Name = "LabelSalt"
        Me.LabelSalt.Size = New System.Drawing.Size(28, 13)
        Me.LabelSalt.TabIndex = 20
        Me.LabelSalt.Text = "Salt:"
        '
        'SaltPass
        '
        Me.SaltPass.Location = New System.Drawing.Point(74, 104)
        Me.SaltPass.Name = "SaltPass"
        Me.SaltPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.SaltPass.Size = New System.Drawing.Size(162, 20)
        Me.SaltPass.TabIndex = 21
        '
        'ViewPass2
        '
        Me.ViewPass2.BackColor = System.Drawing.SystemColors.Control
        Me.ViewPass2.Image = CType(resources.GetObject("ViewPass2.Image"), System.Drawing.Image)
        Me.ViewPass2.Location = New System.Drawing.Point(242, 77)
        Me.ViewPass2.Name = "ViewPass2"
        Me.ViewPass2.Size = New System.Drawing.Size(30, 20)
        Me.ViewPass2.TabIndex = 22
        Me.ViewPass2.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.ViewPass2.UseVisualStyleBackColor = False
        '
        'ViewPass3
        '
        Me.ViewPass3.BackColor = System.Drawing.SystemColors.Control
        Me.ViewPass3.Image = CType(resources.GetObject("ViewPass3.Image"), System.Drawing.Image)
        Me.ViewPass3.Location = New System.Drawing.Point(242, 104)
        Me.ViewPass3.Name = "ViewPass3"
        Me.ViewPass3.Size = New System.Drawing.Size(30, 20)
        Me.ViewPass3.TabIndex = 23
        Me.ViewPass3.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.ViewPass3.UseVisualStyleBackColor = False
        '
        'ClipBoard
        '
        Me.ClipBoard.Image = CType(resources.GetObject("ClipBoard.Image"), System.Drawing.Image)
        Me.ClipBoard.Location = New System.Drawing.Point(246, 161)
        Me.ClipBoard.Name = "ClipBoard"
        Me.ClipBoard.Size = New System.Drawing.Size(26, 23)
        Me.ClipBoard.TabIndex = 24
        Me.ClipBoard.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'B_Cifrar
        '
        Me.B_Cifrar.Location = New System.Drawing.Point(197, 219)
        Me.B_Cifrar.Name = "B_Cifrar"
        Me.B_Cifrar.Size = New System.Drawing.Size(75, 23)
        Me.B_Cifrar.TabIndex = 25
        Me.B_Cifrar.Text = "Descifrar"
        Me.B_Cifrar.UseVisualStyleBackColor = True
        '
        'Cifrar_contraseña
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 254)
        Me.Controls.Add(Me.B_Cifrar)
        Me.Controls.Add(Me.ClipBoard)
        Me.Controls.Add(Me.ViewPass3)
        Me.Controls.Add(Me.ViewPass2)
        Me.Controls.Add(Me.SaltPass)
        Me.Controls.Add(Me.LabelSalt)
        Me.Controls.Add(Me.LabelKey)
        Me.Controls.Add(Me.Key)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CB_Cipher)
        Me.Controls.Add(Me.HashOut)
        Me.Controls.Add(Me.VerPass)
        Me.Controls.Add(Me.PassIN)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Cifrar_contraseña"
        Me.Text = "Cifrar Contraseña"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PassIN As System.Windows.Forms.TextBox
    Friend WithEvents VerPass As System.Windows.Forms.Button
    Friend WithEvents HashOut As System.Windows.Forms.TextBox
    Friend WithEvents CB_Cipher As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Key As System.Windows.Forms.TextBox
    Friend WithEvents LabelKey As System.Windows.Forms.Label
    Friend WithEvents LabelSalt As System.Windows.Forms.Label
    Friend WithEvents SaltPass As System.Windows.Forms.TextBox
    Friend WithEvents ViewPass2 As System.Windows.Forms.Button
    Friend WithEvents ViewPass3 As System.Windows.Forms.Button
    Friend WithEvents ClipBoard As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents B_Cifrar As System.Windows.Forms.Button
End Class
