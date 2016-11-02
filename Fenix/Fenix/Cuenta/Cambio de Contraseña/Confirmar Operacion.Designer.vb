<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Confirmar_Operacion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Confirmar_Operacion))
        Me.TB_Conf_Pass = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.B_Confirmar_PSW = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TB_Conf_Pass
        '
        Me.TB_Conf_Pass.Location = New System.Drawing.Point(97, 35)
        Me.TB_Conf_Pass.MaxLength = 8
        Me.TB_Conf_Pass.Name = "TB_Conf_Pass"
        Me.TB_Conf_Pass.Size = New System.Drawing.Size(100, 20)
        Me.TB_Conf_Pass.TabIndex = 0
        Me.TB_Conf_Pass.UseSystemPasswordChar = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(290, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Por favor Ingrese su Contraseña para confirmar la operación"
        '
        'B_Confirmar_PSW
        '
        Me.B_Confirmar_PSW.Location = New System.Drawing.Point(111, 64)
        Me.B_Confirmar_PSW.Name = "B_Confirmar_PSW"
        Me.B_Confirmar_PSW.Size = New System.Drawing.Size(75, 23)
        Me.B_Confirmar_PSW.TabIndex = 2
        Me.B_Confirmar_PSW.Text = "Confirmar"
        Me.B_Confirmar_PSW.UseVisualStyleBackColor = True
        '
        'Confirmar_Operacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(307, 99)
        Me.Controls.Add(Me.B_Confirmar_PSW)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TB_Conf_Pass)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(323, 138)
        Me.MinimumSize = New System.Drawing.Size(323, 138)
        Me.Name = "Confirmar_Operacion"
        Me.Text = "Confirmar Operacion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TB_Conf_Pass As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents B_Confirmar_PSW As System.Windows.Forms.Button
End Class
