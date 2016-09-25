<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TestPassword
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TestPassword))
        Me.validar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.testpsw = New System.Windows.Forms.TextBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.LevelPass = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.VerPass = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'validar
        '
        Me.validar.Location = New System.Drawing.Point(107, 137)
        Me.validar.Name = "validar"
        Me.validar.Size = New System.Drawing.Size(75, 23)
        Me.validar.TabIndex = 0
        Me.validar.Text = "Analizar"
        Me.validar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(87, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Fortaleza de Contraseña"
        '
        'testpsw
        '
        Me.testpsw.Location = New System.Drawing.Point(71, 102)
        Me.testpsw.MaxLength = 30
        Me.testpsw.Name = "testpsw"
        Me.testpsw.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.testpsw.Size = New System.Drawing.Size(149, 20)
        Me.testpsw.TabIndex = 2
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(48, 168)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(197, 10)
        Me.ProgressBar1.TabIndex = 3
        '
        'LevelPass
        '
        Me.LevelPass.AutoSize = True
        Me.LevelPass.Location = New System.Drawing.Point(68, 189)
        Me.LevelPass.Name = "LevelPass"
        Me.LevelPass.Size = New System.Drawing.Size(57, 13)
        Me.LevelPass.TabIndex = 4
        Me.LevelPass.Text = "Dificultad: "
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 216)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Regresar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'VerPass
        '
        Me.VerPass.BackColor = System.Drawing.SystemColors.Control
        Me.VerPass.Image = CType(resources.GetObject("VerPass.Image"), System.Drawing.Image)
        Me.VerPass.Location = New System.Drawing.Point(226, 102)
        Me.VerPass.Name = "VerPass"
        Me.VerPass.Size = New System.Drawing.Size(30, 20)
        Me.VerPass.TabIndex = 11
        Me.VerPass.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.VerPass.UseVisualStyleBackColor = False
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.SystemColors.Menu
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Location = New System.Drawing.Point(12, 12)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(260, 56)
        Me.RichTextBox1.TabIndex = 20
        Me.RichTextBox1.Text = "Este analizador de contraseñas detecta el tipo de caracteres utilizados los cuale" & _
    "s seran calculados, para saber que nivel de dificultad presentan ante un ataque " & _
    "de fuerza bruta."
        '
        'TestPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 249)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.VerPass)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LevelPass)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.testpsw)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.validar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "TestPassword"
        Me.Text = "Analizar Contraseñas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents validar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents testpsw As System.Windows.Forms.TextBox
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents LevelPass As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents VerPass As System.Windows.Forms.Button
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
End Class
