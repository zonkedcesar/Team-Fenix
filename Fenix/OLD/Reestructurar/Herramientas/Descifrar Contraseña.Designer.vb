<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Descifrar_Contraseña
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Descifrar_Contraseña))
        Me.ClipBoard = New System.Windows.Forms.Button()
        Me.ViewPass3 = New System.Windows.Forms.Button()
        Me.ViewPass2 = New System.Windows.Forms.Button()
        Me.SaltPass = New System.Windows.Forms.TextBox()
        Me.LabelSalt = New System.Windows.Forms.Label()
        Me.LabelKey = New System.Windows.Forms.Label()
        Me.Key = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CB_Cipher = New System.Windows.Forms.ComboBox()
        Me.HashIN = New System.Windows.Forms.TextBox()
        Me.VerPass = New System.Windows.Forms.Button()
        Me.PassOUT = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'ClipBoard
        '
        Me.ClipBoard.Image = CType(resources.GetObject("ClipBoard.Image"), System.Drawing.Image)
        Me.ClipBoard.Location = New System.Drawing.Point(210, 163)
        Me.ClipBoard.Name = "ClipBoard"
        Me.ClipBoard.Size = New System.Drawing.Size(26, 23)
        Me.ClipBoard.TabIndex = 40
        Me.ClipBoard.UseVisualStyleBackColor = True
        '
        'ViewPass3
        '
        Me.ViewPass3.BackColor = System.Drawing.SystemColors.Control
        Me.ViewPass3.Image = CType(resources.GetObject("ViewPass3.Image"), System.Drawing.Image)
        Me.ViewPass3.Location = New System.Drawing.Point(242, 106)
        Me.ViewPass3.Name = "ViewPass3"
        Me.ViewPass3.Size = New System.Drawing.Size(30, 20)
        Me.ViewPass3.TabIndex = 39
        Me.ViewPass3.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.ViewPass3.UseVisualStyleBackColor = False
        '
        'ViewPass2
        '
        Me.ViewPass2.BackColor = System.Drawing.SystemColors.Control
        Me.ViewPass2.Image = CType(resources.GetObject("ViewPass2.Image"), System.Drawing.Image)
        Me.ViewPass2.Location = New System.Drawing.Point(242, 79)
        Me.ViewPass2.Name = "ViewPass2"
        Me.ViewPass2.Size = New System.Drawing.Size(30, 20)
        Me.ViewPass2.TabIndex = 38
        Me.ViewPass2.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.ViewPass2.UseVisualStyleBackColor = False
        '
        'SaltPass
        '
        Me.SaltPass.Location = New System.Drawing.Point(42, 110)
        Me.SaltPass.Name = "SaltPass"
        Me.SaltPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.SaltPass.Size = New System.Drawing.Size(194, 20)
        Me.SaltPass.TabIndex = 37
        '
        'LabelSalt
        '
        Me.LabelSalt.AutoSize = True
        Me.LabelSalt.Location = New System.Drawing.Point(8, 113)
        Me.LabelSalt.Name = "LabelSalt"
        Me.LabelSalt.Size = New System.Drawing.Size(28, 13)
        Me.LabelSalt.TabIndex = 36
        Me.LabelSalt.Text = "Salt:"
        '
        'LabelKey
        '
        Me.LabelKey.AutoSize = True
        Me.LabelKey.Location = New System.Drawing.Point(8, 83)
        Me.LabelKey.Name = "LabelKey"
        Me.LabelKey.Size = New System.Drawing.Size(28, 13)
        Me.LabelKey.TabIndex = 35
        Me.LabelKey.Text = "Key:"
        '
        'Key
        '
        Me.Key.Location = New System.Drawing.Point(42, 80)
        Me.Key.Name = "Key"
        Me.Key.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Key.Size = New System.Drawing.Size(194, 20)
        Me.Key.TabIndex = 34
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(197, 44)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 33
        Me.Button3.Text = "Descifrar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Hash"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(15, 221)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 31
        Me.Button2.Text = "Regresar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(50, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Cipher:"
        '
        'CB_Cipher
        '
        Me.CB_Cipher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_Cipher.FormattingEnabled = True
        Me.CB_Cipher.Items.AddRange(New Object() {"AES-128", "AES-256"})
        Me.CB_Cipher.Location = New System.Drawing.Point(106, 46)
        Me.CB_Cipher.Name = "CB_Cipher"
        Me.CB_Cipher.Size = New System.Drawing.Size(72, 21)
        Me.CB_Cipher.TabIndex = 29
        '
        'HashIN
        '
        Me.HashIN.Location = New System.Drawing.Point(46, 17)
        Me.HashIN.Name = "HashIN"
        Me.HashIN.Size = New System.Drawing.Size(226, 20)
        Me.HashIN.TabIndex = 28
        '
        'VerPass
        '
        Me.VerPass.BackColor = System.Drawing.SystemColors.Control
        Me.VerPass.Image = CType(resources.GetObject("VerPass.Image"), System.Drawing.Image)
        Me.VerPass.Location = New System.Drawing.Point(242, 164)
        Me.VerPass.Name = "VerPass"
        Me.VerPass.Size = New System.Drawing.Size(30, 20)
        Me.VerPass.TabIndex = 27
        Me.VerPass.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.VerPass.UseVisualStyleBackColor = False
        '
        'PassOUT
        '
        Me.PassOUT.Location = New System.Drawing.Point(70, 165)
        Me.PassOUT.Name = "PassOUT"
        Me.PassOUT.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PassOUT.Size = New System.Drawing.Size(132, 20)
        Me.PassOUT.TabIndex = 26
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 168)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Password:"
        '
        'Descifrar_Contraseña
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
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
        Me.Controls.Add(Me.HashIN)
        Me.Controls.Add(Me.VerPass)
        Me.Controls.Add(Me.PassOUT)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Descifrar_Contraseña"
        Me.Text = "Descifrar Contraseña"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ClipBoard As System.Windows.Forms.Button
    Friend WithEvents ViewPass3 As System.Windows.Forms.Button
    Friend WithEvents ViewPass2 As System.Windows.Forms.Button
    Friend WithEvents SaltPass As System.Windows.Forms.TextBox
    Friend WithEvents LabelSalt As System.Windows.Forms.Label
    Friend WithEvents LabelKey As System.Windows.Forms.Label
    Friend WithEvents Key As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CB_Cipher As System.Windows.Forms.ComboBox
    Friend WithEvents HashIN As System.Windows.Forms.TextBox
    Friend WithEvents VerPass As System.Windows.Forms.Button
    Friend WithEvents PassOUT As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
