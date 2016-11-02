<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangePassword
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ChangePassword))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TB_A_PSW = New System.Windows.Forms.TextBox()
        Me.TB_N_PSW = New System.Windows.Forms.TextBox()
        Me.TB_C_PSW = New System.Windows.Forms.TextBox()
        Me.B_Actualizar = New System.Windows.Forms.Button()
        Me.B_Cancelar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Contraseña Actual:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nueva Contraseña:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Confirmar Contraseña:"
        '
        'TB_A_PSW
        '
        Me.TB_A_PSW.Location = New System.Drawing.Point(151, 24)
        Me.TB_A_PSW.MaxLength = 8
        Me.TB_A_PSW.Name = "TB_A_PSW"
        Me.TB_A_PSW.Size = New System.Drawing.Size(100, 20)
        Me.TB_A_PSW.TabIndex = 3
        Me.TB_A_PSW.UseSystemPasswordChar = True
        '
        'TB_N_PSW
        '
        Me.TB_N_PSW.Location = New System.Drawing.Point(151, 60)
        Me.TB_N_PSW.MaxLength = 8
        Me.TB_N_PSW.Name = "TB_N_PSW"
        Me.TB_N_PSW.Size = New System.Drawing.Size(100, 20)
        Me.TB_N_PSW.TabIndex = 4
        Me.TB_N_PSW.UseSystemPasswordChar = True
        '
        'TB_C_PSW
        '
        Me.TB_C_PSW.Location = New System.Drawing.Point(151, 95)
        Me.TB_C_PSW.MaxLength = 8
        Me.TB_C_PSW.Name = "TB_C_PSW"
        Me.TB_C_PSW.Size = New System.Drawing.Size(100, 20)
        Me.TB_C_PSW.TabIndex = 5
        Me.TB_C_PSW.UseSystemPasswordChar = True
        '
        'B_Actualizar
        '
        Me.B_Actualizar.Location = New System.Drawing.Point(12, 132)
        Me.B_Actualizar.Name = "B_Actualizar"
        Me.B_Actualizar.Size = New System.Drawing.Size(75, 23)
        Me.B_Actualizar.TabIndex = 6
        Me.B_Actualizar.Text = "Actualizar"
        Me.B_Actualizar.UseVisualStyleBackColor = True
        '
        'B_Cancelar
        '
        Me.B_Cancelar.Location = New System.Drawing.Point(197, 132)
        Me.B_Cancelar.Name = "B_Cancelar"
        Me.B_Cancelar.Size = New System.Drawing.Size(75, 23)
        Me.B_Cancelar.TabIndex = 7
        Me.B_Cancelar.Text = "Cancelar"
        Me.B_Cancelar.UseVisualStyleBackColor = True
        '
        'ChangePassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 171)
        Me.Controls.Add(Me.B_Cancelar)
        Me.Controls.Add(Me.B_Actualizar)
        Me.Controls.Add(Me.TB_C_PSW)
        Me.Controls.Add(Me.TB_N_PSW)
        Me.Controls.Add(Me.TB_A_PSW)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(300, 210)
        Me.MinimumSize = New System.Drawing.Size(300, 210)
        Me.Name = "ChangePassword"
        Me.Text = "Cambiar Contraseña"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TB_A_PSW As System.Windows.Forms.TextBox
    Friend WithEvents TB_N_PSW As System.Windows.Forms.TextBox
    Friend WithEvents TB_C_PSW As System.Windows.Forms.TextBox
    Friend WithEvents B_Actualizar As System.Windows.Forms.Button
    Friend WithEvents B_Cancelar As System.Windows.Forms.Button
End Class
