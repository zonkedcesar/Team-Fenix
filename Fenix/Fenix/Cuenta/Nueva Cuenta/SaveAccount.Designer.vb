<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SaveAccount
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SaveAccount))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TB_C_Codigo = New System.Windows.Forms.TextBox()
        Me.B_Validar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(71, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ingrese Codigo de Seguridad"
        '
        'TB_C_Codigo
        '
        Me.TB_C_Codigo.Location = New System.Drawing.Point(55, 34)
        Me.TB_C_Codigo.MaxLength = 10
        Me.TB_C_Codigo.Name = "TB_C_Codigo"
        Me.TB_C_Codigo.Size = New System.Drawing.Size(164, 20)
        Me.TB_C_Codigo.TabIndex = 1
        '
        'B_Validar
        '
        Me.B_Validar.Location = New System.Drawing.Point(12, 76)
        Me.B_Validar.Name = "B_Validar"
        Me.B_Validar.Size = New System.Drawing.Size(75, 23)
        Me.B_Validar.TabIndex = 2
        Me.B_Validar.Text = "Validar"
        Me.B_Validar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(200, 76)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(72, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Reenviar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'SaveAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 111)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.B_Validar)
        Me.Controls.Add(Me.TB_C_Codigo)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SaveAccount"
        Me.Text = "Codigo de Validacion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TB_C_Codigo As System.Windows.Forms.TextBox
    Friend WithEvents B_Validar As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
