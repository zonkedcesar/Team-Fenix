<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Analizar_Contraseña_Invitado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Analizar_Contraseña_Invitado))
        Me.VerPass = New System.Windows.Forms.Button()
        Me.B_InvReturn = New System.Windows.Forms.Button()
        Me.LevelPass = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.testpsw = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.validar = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'VerPass
        '
        Me.VerPass.BackColor = System.Drawing.SystemColors.Control
        Me.VerPass.Image = CType(resources.GetObject("VerPass.Image"), System.Drawing.Image)
        Me.VerPass.Location = New System.Drawing.Point(225, 98)
        Me.VerPass.Name = "VerPass"
        Me.VerPass.Size = New System.Drawing.Size(30, 20)
        Me.VerPass.TabIndex = 18
        Me.VerPass.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.VerPass.UseVisualStyleBackColor = False
        '
        'B_InvReturn
        '
        Me.B_InvReturn.Location = New System.Drawing.Point(11, 212)
        Me.B_InvReturn.Name = "B_InvReturn"
        Me.B_InvReturn.Size = New System.Drawing.Size(75, 23)
        Me.B_InvReturn.TabIndex = 17
        Me.B_InvReturn.Text = "Regresar"
        Me.B_InvReturn.UseVisualStyleBackColor = True
        '
        'LevelPass
        '
        Me.LevelPass.AutoSize = True
        Me.LevelPass.Location = New System.Drawing.Point(67, 185)
        Me.LevelPass.Name = "LevelPass"
        Me.LevelPass.Size = New System.Drawing.Size(57, 13)
        Me.LevelPass.TabIndex = 16
        Me.LevelPass.Text = "Dificultad: "
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(47, 164)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(197, 10)
        Me.ProgressBar1.TabIndex = 15
        '
        'testpsw
        '
        Me.testpsw.Location = New System.Drawing.Point(70, 98)
        Me.testpsw.MaxLength = 30
        Me.testpsw.Name = "testpsw"
        Me.testpsw.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.testpsw.Size = New System.Drawing.Size(149, 20)
        Me.testpsw.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(86, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Fortaleza de Contraseña"
        '
        'validar
        '
        Me.validar.Location = New System.Drawing.Point(106, 133)
        Me.validar.Name = "validar"
        Me.validar.Size = New System.Drawing.Size(75, 23)
        Me.validar.TabIndex = 12
        Me.validar.Text = "Analizar"
        Me.validar.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.SystemColors.Menu
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Location = New System.Drawing.Point(12, 12)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(260, 56)
        Me.RichTextBox1.TabIndex = 19
        Me.RichTextBox1.Text = "Este analizador de contraseñas detecta el tipo de caracteres utilizados los cuale" & _
    "s seran calculados, para saber que nivel de dificultad presentan ante un ataque " & _
    "de fuerza bruta."
        '
        'Analizar_Contraseña_Invitado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 243)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.VerPass)
        Me.Controls.Add(Me.B_InvReturn)
        Me.Controls.Add(Me.LevelPass)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.testpsw)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.validar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Analizar_Contraseña_Invitado"
        Me.Text = "Analizar Contraseña"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents VerPass As System.Windows.Forms.Button
    Friend WithEvents B_InvReturn As System.Windows.Forms.Button
    Friend WithEvents LevelPass As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents testpsw As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents validar As System.Windows.Forms.Button
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
End Class
