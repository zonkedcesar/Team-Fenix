<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Generador_Invitado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Generador_Invitado))
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Number_Gen = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Clear = New System.Windows.Forms.Button()
        Me.LevelPass = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.CB_MaxLong = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Back = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CB_MinLong = New System.Windows.Forms.ComboBox()
        Me.VerPass = New System.Windows.Forms.Button()
        Me.ClipBoardCopy = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GenPass = New System.Windows.Forms.TextBox()
        Me.Generar = New System.Windows.Forms.Button()
        Me.Simbolos = New System.Windows.Forms.CheckBox()
        Me.Numeros = New System.Windows.Forms.CheckBox()
        Me.Mayusculas = New System.Windows.Forms.CheckBox()
        Me.Minusculas = New System.Windows.Forms.CheckBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.Number_Gen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.SystemColors.Menu
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Location = New System.Drawing.Point(21, 12)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(419, 41)
        Me.RichTextBox1.TabIndex = 61
        Me.RichTextBox1.Text = "Para garantizar la seguridad de la contraseña a generar por favor de configurar s" & _
    "u salida con el mayor uso de opciones disponibles."
        '
        'Number_Gen
        '
        Me.Number_Gen.Location = New System.Drawing.Point(331, 98)
        Me.Number_Gen.Maximum = New Decimal(New Integer() {30, 0, 0, 0})
        Me.Number_Gen.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Number_Gen.Name = "Number_Gen"
        Me.Number_Gen.Size = New System.Drawing.Size(36, 20)
        Me.Number_Gen.TabIndex = 59
        Me.Number_Gen.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(209, 101)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(116, 13)
        Me.Label7.TabIndex = 58
        Me.Label7.Text = "Contraseñas a Generar"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(42, 59)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 57
        Me.Label5.Text = "Composición"
        '
        'Clear
        '
        Me.Clear.Location = New System.Drawing.Point(387, 186)
        Me.Clear.Name = "Clear"
        Me.Clear.Size = New System.Drawing.Size(53, 23)
        Me.Clear.TabIndex = 51
        Me.Clear.Text = "Limpiar"
        Me.Clear.UseVisualStyleBackColor = True
        '
        'LevelPass
        '
        Me.LevelPass.AutoSize = True
        Me.LevelPass.Location = New System.Drawing.Point(293, 218)
        Me.LevelPass.Name = "LevelPass"
        Me.LevelPass.Size = New System.Drawing.Size(63, 13)
        Me.LevelPass.TabIndex = 49
        Me.LevelPass.Text = "Dificultad: ?"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(116, 218)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(174, 13)
        Me.ProgressBar1.TabIndex = 48
        '
        'CB_MaxLong
        '
        Me.CB_MaxLong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_MaxLong.FormattingEnabled = True
        Me.CB_MaxLong.Location = New System.Drawing.Point(404, 59)
        Me.CB_MaxLong.Name = "CB_MaxLong"
        Me.CB_MaxLong.Size = New System.Drawing.Size(36, 21)
        Me.CB_MaxLong.TabIndex = 47
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(311, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "Maxima Longitud"
        '
        'Back
        '
        Me.Back.Location = New System.Drawing.Point(20, 223)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(75, 23)
        Me.Back.TabIndex = 45
        Me.Back.Text = "Regreso"
        Me.Back.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(162, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Minima Longitud"
        '
        'CB_MinLong
        '
        Me.CB_MinLong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_MinLong.FormattingEnabled = True
        Me.CB_MinLong.Items.AddRange(New Object() {"8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35"})
        Me.CB_MinLong.Location = New System.Drawing.Point(252, 59)
        Me.CB_MinLong.MaxLength = 2
        Me.CB_MinLong.Name = "CB_MinLong"
        Me.CB_MinLong.Size = New System.Drawing.Size(36, 21)
        Me.CB_MinLong.TabIndex = 43
        '
        'VerPass
        '
        Me.VerPass.BackColor = System.Drawing.SystemColors.Control
        Me.VerPass.Image = CType(resources.GetObject("VerPass.Image"), System.Drawing.Image)
        Me.VerPass.Location = New System.Drawing.Point(351, 187)
        Me.VerPass.Name = "VerPass"
        Me.VerPass.Size = New System.Drawing.Size(30, 20)
        Me.VerPass.TabIndex = 42
        Me.VerPass.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.VerPass.UseVisualStyleBackColor = False
        '
        'ClipBoardCopy
        '
        Me.ClipBoardCopy.Image = CType(resources.GetObject("ClipBoardCopy.Image"), System.Drawing.Image)
        Me.ClipBoardCopy.Location = New System.Drawing.Point(311, 186)
        Me.ClipBoardCopy.Name = "ClipBoardCopy"
        Me.ClipBoardCopy.Size = New System.Drawing.Size(34, 23)
        Me.ClipBoardCopy.TabIndex = 41
        Me.ClipBoardCopy.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 189)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Password"
        '
        'GenPass
        '
        Me.GenPass.Location = New System.Drawing.Point(77, 186)
        Me.GenPass.Name = "GenPass"
        Me.GenPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.GenPass.Size = New System.Drawing.Size(228, 20)
        Me.GenPass.TabIndex = 39
        '
        'Generar
        '
        Me.Generar.Location = New System.Drawing.Point(252, 137)
        Me.Generar.Name = "Generar"
        Me.Generar.Size = New System.Drawing.Size(75, 23)
        Me.Generar.TabIndex = 38
        Me.Generar.Text = "Generar"
        Me.Generar.UseVisualStyleBackColor = True
        '
        'Simbolos
        '
        Me.Simbolos.AutoSize = True
        Me.Simbolos.Location = New System.Drawing.Point(48, 148)
        Me.Simbolos.Name = "Simbolos"
        Me.Simbolos.Size = New System.Drawing.Size(73, 17)
        Me.Simbolos.TabIndex = 37
        Me.Simbolos.Text = "[ ! # $ * . ]"
        Me.Simbolos.UseVisualStyleBackColor = True
        '
        'Numeros
        '
        Me.Numeros.AutoSize = True
        Me.Numeros.Location = New System.Drawing.Point(48, 125)
        Me.Numeros.Name = "Numeros"
        Me.Numeros.Size = New System.Drawing.Size(59, 17)
        Me.Numeros.TabIndex = 36
        Me.Numeros.Text = "[ 0 - 9 ]"
        Me.Numeros.UseVisualStyleBackColor = True
        '
        'Mayusculas
        '
        Me.Mayusculas.AutoSize = True
        Me.Mayusculas.Location = New System.Drawing.Point(48, 79)
        Me.Mayusculas.Name = "Mayusculas"
        Me.Mayusculas.Size = New System.Drawing.Size(61, 17)
        Me.Mayusculas.TabIndex = 35
        Me.Mayusculas.Text = "[ A - Z ]"
        Me.Mayusculas.UseVisualStyleBackColor = True
        '
        'Minusculas
        '
        Me.Minusculas.AutoSize = True
        Me.Minusculas.Location = New System.Drawing.Point(48, 102)
        Me.Minusculas.Name = "Minusculas"
        Me.Minusculas.Size = New System.Drawing.Size(58, 17)
        Me.Minusculas.TabIndex = 34
        Me.Minusculas.Text = "[ a - z ]"
        Me.Minusculas.UseVisualStyleBackColor = True
        '
        'Generador_Invitado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(456, 256)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Number_Gen)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Clear)
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
        Me.MaximumSize = New System.Drawing.Size(472, 295)
        Me.MinimumSize = New System.Drawing.Size(472, 295)
        Me.Name = "Generador_Invitado"
        Me.Text = "Generador de Contraseñas"
        CType(Me.Number_Gen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents Number_Gen As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Clear As System.Windows.Forms.Button
    Friend WithEvents LevelPass As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents CB_MaxLong As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Back As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CB_MinLong As System.Windows.Forms.ComboBox
    Friend WithEvents VerPass As System.Windows.Forms.Button
    Friend WithEvents ClipBoardCopy As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GenPass As System.Windows.Forms.TextBox
    Friend WithEvents Generar As System.Windows.Forms.Button
    Friend WithEvents Simbolos As System.Windows.Forms.CheckBox
    Friend WithEvents Numeros As System.Windows.Forms.CheckBox
    Friend WithEvents Mayusculas As System.Windows.Forms.CheckBox
    Friend WithEvents Minusculas As System.Windows.Forms.CheckBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
