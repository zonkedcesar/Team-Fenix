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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(List_Pass))
        Me.ListB_Pass = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LevelPass = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.B_Back = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListB_Pass
        '
        Me.ListB_Pass.FormattingEnabled = True
        Me.ListB_Pass.Location = New System.Drawing.Point(34, 36)
        Me.ListB_Pass.Name = "ListB_Pass"
        Me.ListB_Pass.Size = New System.Drawing.Size(224, 160)
        Me.ListB_Pass.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(85, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Contraseñas Generadas:"
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
        Me.B_Back.Location = New System.Drawing.Point(12, 246)
        Me.B_Back.Name = "B_Back"
        Me.B_Back.Size = New System.Drawing.Size(75, 23)
        Me.B_Back.TabIndex = 20
        Me.B_Back.Text = "Cerrar"
        Me.B_Back.UseVisualStyleBackColor = True
        '
        'List_Pass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(295, 282)
        Me.Controls.Add(Me.B_Back)
        Me.Controls.Add(Me.LevelPass)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListB_Pass)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "List_Pass"
        Me.Text = "Lista Generada"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListB_Pass As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LevelPass As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents B_Back As System.Windows.Forms.Button
End Class
