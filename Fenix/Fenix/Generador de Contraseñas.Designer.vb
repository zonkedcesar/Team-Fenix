<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Generador_de_Contraseñas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Generador_de_Contraseñas))
        Me.Minusculas = New System.Windows.Forms.CheckBox()
        Me.Mayusculas = New System.Windows.Forms.CheckBox()
        Me.Numeros = New System.Windows.Forms.CheckBox()
        Me.Simbolos = New System.Windows.Forms.CheckBox()
        Me.Generar = New System.Windows.Forms.Button()
        Me.GenPass = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ClipBoardCopy = New System.Windows.Forms.Button()
        Me.VerPass = New System.Windows.Forms.Button()
        Me.CB_MinLong = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Back = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CB_MaxLong = New System.Windows.Forms.ComboBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.LevelPass = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Cifrar = New System.Windows.Forms.Button()
        Me.Clear = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Number_Gen = New System.Windows.Forms.NumericUpDown()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        CType(Me.Number_Gen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Minusculas
        '
        Me.Minusculas.AutoSize = True
        Me.Minusculas.Location = New System.Drawing.Point(53, 101)
        Me.Minusculas.Name = "Minusculas"
        Me.Minusculas.Size = New System.Drawing.Size(58, 17)
        Me.Minusculas.TabIndex = 0
        Me.Minusculas.Text = "[ a - z ]"
        Me.Minusculas.UseVisualStyleBackColor = True
        '
        'Mayusculas
        '
        Me.Mayusculas.AutoSize = True
        Me.Mayusculas.Location = New System.Drawing.Point(53, 78)
        Me.Mayusculas.Name = "Mayusculas"
        Me.Mayusculas.Size = New System.Drawing.Size(61, 17)
        Me.Mayusculas.TabIndex = 1
        Me.Mayusculas.Text = "[ A - Z ]"
        Me.Mayusculas.UseVisualStyleBackColor = True
        '
        'Numeros
        '
        Me.Numeros.AutoSize = True
        Me.Numeros.Location = New System.Drawing.Point(53, 124)
        Me.Numeros.Name = "Numeros"
        Me.Numeros.Size = New System.Drawing.Size(59, 17)
        Me.Numeros.TabIndex = 2
        Me.Numeros.Text = "[ 0 - 9 ]"
        Me.Numeros.UseVisualStyleBackColor = True
        '
        'Simbolos
        '
        Me.Simbolos.AutoSize = True
        Me.Simbolos.Location = New System.Drawing.Point(53, 147)
        Me.Simbolos.Name = "Simbolos"
        Me.Simbolos.Size = New System.Drawing.Size(73, 17)
        Me.Simbolos.TabIndex = 3
        Me.Simbolos.Text = "[ ! # $ * . ]"
        Me.Simbolos.UseVisualStyleBackColor = True
        '
        'Generar
        '
        Me.Generar.Location = New System.Drawing.Point(251, 136)
        Me.Generar.Name = "Generar"
        Me.Generar.Size = New System.Drawing.Size(75, 23)
        Me.Generar.TabIndex = 5
        Me.Generar.Text = "Generar"
        Me.Generar.UseVisualStyleBackColor = True
        '
        'GenPass
        '
        Me.GenPass.Location = New System.Drawing.Point(76, 185)
        Me.GenPass.Name = "GenPass"
        Me.GenPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.GenPass.Size = New System.Drawing.Size(228, 20)
        Me.GenPass.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 188)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Password"
        '
        'ClipBoardCopy
        '
        Me.ClipBoardCopy.Image = CType(resources.GetObject("ClipBoardCopy.Image"), System.Drawing.Image)
        Me.ClipBoardCopy.Location = New System.Drawing.Point(310, 185)
        Me.ClipBoardCopy.Name = "ClipBoardCopy"
        Me.ClipBoardCopy.Size = New System.Drawing.Size(34, 23)
        Me.ClipBoardCopy.TabIndex = 8
        Me.ClipBoardCopy.UseVisualStyleBackColor = True
        '
        'VerPass
        '
        Me.VerPass.BackColor = System.Drawing.SystemColors.Control
        Me.VerPass.Image = CType(resources.GetObject("VerPass.Image"), System.Drawing.Image)
        Me.VerPass.Location = New System.Drawing.Point(350, 186)
        Me.VerPass.Name = "VerPass"
        Me.VerPass.Size = New System.Drawing.Size(30, 20)
        Me.VerPass.TabIndex = 9
        Me.VerPass.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.VerPass.UseVisualStyleBackColor = False
        '
        'CB_MinLong
        '
        Me.CB_MinLong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_MinLong.FormattingEnabled = True
        Me.CB_MinLong.Items.AddRange(New Object() {"8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35"})
        Me.CB_MinLong.Location = New System.Drawing.Point(251, 58)
        Me.CB_MinLong.MaxLength = 2
        Me.CB_MinLong.Name = "CB_MinLong"
        Me.CB_MinLong.Size = New System.Drawing.Size(36, 21)
        Me.CB_MinLong.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(161, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Minima Longitud"
        '
        'Back
        '
        Me.Back.Location = New System.Drawing.Point(19, 222)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(75, 23)
        Me.Back.TabIndex = 13
        Me.Back.Text = "Regreso"
        Me.Back.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(310, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Maxima Longitud"
        '
        'CB_MaxLong
        '
        Me.CB_MaxLong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_MaxLong.FormattingEnabled = True
        Me.CB_MaxLong.Location = New System.Drawing.Point(403, 58)
        Me.CB_MaxLong.Name = "CB_MaxLong"
        Me.CB_MaxLong.Size = New System.Drawing.Size(36, 21)
        Me.CB_MaxLong.TabIndex = 15
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(115, 217)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(174, 13)
        Me.ProgressBar1.TabIndex = 16
        '
        'LevelPass
        '
        Me.LevelPass.AutoSize = True
        Me.LevelPass.Location = New System.Drawing.Point(292, 217)
        Me.LevelPass.Name = "LevelPass"
        Me.LevelPass.Size = New System.Drawing.Size(63, 13)
        Me.LevelPass.TabIndex = 17
        Me.LevelPass.Text = "Dificultad: ?"
        '
        'Timer1
        '
        '
        'Cifrar
        '
        Me.Cifrar.Location = New System.Drawing.Point(384, 217)
        Me.Cifrar.Name = "Cifrar"
        Me.Cifrar.Size = New System.Drawing.Size(55, 23)
        Me.Cifrar.TabIndex = 19
        Me.Cifrar.Text = "Cifrar"
        Me.Cifrar.UseVisualStyleBackColor = True
        '
        'Clear
        '
        Me.Clear.Location = New System.Drawing.Point(386, 185)
        Me.Clear.Name = "Clear"
        Me.Clear.Size = New System.Drawing.Size(53, 23)
        Me.Clear.TabIndex = 20
        Me.Clear.Text = "Limpiar"
        Me.Clear.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(63, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Requerido"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(208, 100)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(116, 13)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Contraseñas a Generar"
        '
        'Number_Gen
        '
        Me.Number_Gen.Location = New System.Drawing.Point(330, 97)
        Me.Number_Gen.Maximum = New Decimal(New Integer() {30, 0, 0, 0})
        Me.Number_Gen.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Number_Gen.Name = "Number_Gen"
        Me.Number_Gen.Size = New System.Drawing.Size(36, 20)
        Me.Number_Gen.TabIndex = 31
        Me.Number_Gen.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.SystemColors.Menu
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Location = New System.Drawing.Point(11, 11)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(401, 41)
        Me.RichTextBox1.TabIndex = 33
        Me.RichTextBox1.Text = "El generador de contraseñas contiene multiples opciones las cuales puede combinar" & _
    " aumentando la seguridad en el algortimo aleatorio de la generacion de estas con" & _
    "traseñas."
        '
        'Generador_de_Contraseñas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(452, 253)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Number_Gen)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Clear)
        Me.Controls.Add(Me.Cifrar)
        Me.Controls.Add(Me.LevelPass)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.CB_MaxLong)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Back)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CB_MinLong)
        Me.Controls.Add(Me.VerPass)
        Me.Controls.Add(Me.ClipBoardCopy)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GenPass)
        Me.Controls.Add(Me.Generar)
        Me.Controls.Add(Me.Simbolos)
        Me.Controls.Add(Me.Numeros)
        Me.Controls.Add(Me.Mayusculas)
        Me.Controls.Add(Me.Minusculas)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Generador_de_Contraseñas"
        Me.Text = "Generador de Contraseñas"
        CType(Me.Number_Gen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Minusculas As System.Windows.Forms.CheckBox
    Friend WithEvents Mayusculas As System.Windows.Forms.CheckBox
    Friend WithEvents Numeros As System.Windows.Forms.CheckBox
    Friend WithEvents Simbolos As System.Windows.Forms.CheckBox
    Friend WithEvents Generar As System.Windows.Forms.Button
    Friend WithEvents GenPass As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ClipBoardCopy As System.Windows.Forms.Button
    Friend WithEvents VerPass As System.Windows.Forms.Button
    Friend WithEvents CB_MinLong As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Back As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CB_MaxLong As System.Windows.Forms.ComboBox
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents LevelPass As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Cifrar As System.Windows.Forms.Button
    Friend WithEvents Clear As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Number_Gen As System.Windows.Forms.NumericUpDown
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
End Class
