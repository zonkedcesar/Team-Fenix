<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class List_Pass
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(List_Pass))
        Me.ListB_Pass = New System.Windows.Forms.ListBox()
        Me.Out_Time_Life = New System.Windows.Forms.Label()
        Me.LevelPass = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.B_Back = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.T_Copy = New System.Windows.Forms.Timer(Me.components)
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.SuspendLayout()
        '
        'ListB_Pass
        '
        Me.ListB_Pass.FormattingEnabled = True
        Me.ListB_Pass.Location = New System.Drawing.Point(12, 36)
        Me.ListB_Pass.Name = "ListB_Pass"
        Me.ListB_Pass.Size = New System.Drawing.Size(271, 160)
        Me.ListB_Pass.TabIndex = 2
        '
        'Out_Time_Life
        '
        Me.Out_Time_Life.AutoSize = True
        Me.Out_Time_Life.Location = New System.Drawing.Point(85, 9)
        Me.Out_Time_Life.Name = "Out_Time_Life"
        Me.Out_Time_Life.Size = New System.Drawing.Size(124, 13)
        Me.Out_Time_Life.TabIndex = 3
        Me.Out_Time_Life.Text = "Contraseñas Generadas:"
        '
        'LevelPass
        '
        Me.LevelPass.AutoSize = True
        Me.LevelPass.Location = New System.Drawing.Point(118, 229)
        Me.LevelPass.Name = "LevelPass"
        Me.LevelPass.Size = New System.Drawing.Size(63, 13)
        Me.LevelPass.TabIndex = 19
        Me.LevelPass.Text = "Dificultad: ?"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(34, 202)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(224, 13)
        Me.ProgressBar1.TabIndex = 18
        '
        'B_Back
        '
        Me.B_Back.Location = New System.Drawing.Point(12, 259)
        Me.B_Back.Name = "B_Back"
        Me.B_Back.Size = New System.Drawing.Size(60, 23)
        Me.B_Back.TabIndex = 20
        Me.B_Back.Text = "Regresar"
        Me.B_Back.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(223, 259)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(60, 23)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Exportar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(118, 259)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(60, 23)
        Me.Button2.TabIndex = 22
        Me.Button2.Text = "Generar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'T_Copy
        '
        '
        'List_Pass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(295, 293)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.B_Back)
        Me.Controls.Add(Me.LevelPass)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Out_Time_Life)
        Me.Controls.Add(Me.ListB_Pass)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(500, 150)
        Me.MaximumSize = New System.Drawing.Size(311, 332)
        Me.MinimumSize = New System.Drawing.Size(311, 332)
        Me.Name = "List_Pass"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Lista Generada"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListB_Pass As System.Windows.Forms.ListBox
    Friend WithEvents Out_Time_Life As System.Windows.Forms.Label
    Friend WithEvents LevelPass As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents B_Back As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents T_Copy As System.Windows.Forms.Timer
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
End Class
