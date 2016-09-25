<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Invitado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Invitado))
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.B_Generar = New System.Windows.Forms.Button()
        Me.B_Analizar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.B_Back = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.SystemColors.Menu
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Enabled = False
        Me.RichTextBox1.Location = New System.Drawing.Point(12, 12)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(253, 91)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = "Cuenta Invitado:" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & "Con esta cuenta usted podra analizar y generar contraseñas sin " & _
    "ninguna restriccion." & Global.Microsoft.VisualBasic.ChrW(10) & "Sin embargo, no podra cifrarlas ni almacenar en una cuenta " & _
    "existente."
        '
        'B_Generar
        '
        Me.B_Generar.Location = New System.Drawing.Point(162, 131)
        Me.B_Generar.Name = "B_Generar"
        Me.B_Generar.Size = New System.Drawing.Size(75, 23)
        Me.B_Generar.TabIndex = 1
        Me.B_Generar.Text = "Generar"
        Me.B_Generar.UseVisualStyleBackColor = True
        '
        'B_Analizar
        '
        Me.B_Analizar.Location = New System.Drawing.Point(23, 131)
        Me.B_Analizar.Name = "B_Analizar"
        Me.B_Analizar.Size = New System.Drawing.Size(75, 23)
        Me.B_Analizar.TabIndex = 2
        Me.B_Analizar.Text = "Analizar"
        Me.B_Analizar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(86, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Elige una opcion:"
        '
        'B_Back
        '
        Me.B_Back.Location = New System.Drawing.Point(12, 177)
        Me.B_Back.Name = "B_Back"
        Me.B_Back.Size = New System.Drawing.Size(75, 23)
        Me.B_Back.TabIndex = 4
        Me.B_Back.Text = "Regresar"
        Me.B_Back.UseVisualStyleBackColor = True
        '
        'Invitado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 212)
        Me.Controls.Add(Me.B_Back)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.B_Analizar)
        Me.Controls.Add(Me.B_Generar)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Invitado"
        Me.Text = "Invitado"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents B_Generar As System.Windows.Forms.Button
    Friend WithEvents B_Analizar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents B_Back As System.Windows.Forms.Button
End Class
