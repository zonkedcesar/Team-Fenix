<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangeQuestion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ChangeQuestion))
        Me.B_Actualizar = New System.Windows.Forms.Button()
        Me.B_Cancelar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TB_P_Secure = New System.Windows.Forms.TextBox()
        Me.TB_Respuesta = New System.Windows.Forms.TextBox()
        Me.TB_NIP = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'B_Actualizar
        '
        Me.B_Actualizar.Location = New System.Drawing.Point(12, 170)
        Me.B_Actualizar.Name = "B_Actualizar"
        Me.B_Actualizar.Size = New System.Drawing.Size(75, 23)
        Me.B_Actualizar.TabIndex = 4
        Me.B_Actualizar.Text = "Actualizar"
        Me.B_Actualizar.UseVisualStyleBackColor = True
        '
        'B_Cancelar
        '
        Me.B_Cancelar.Location = New System.Drawing.Point(197, 170)
        Me.B_Cancelar.Name = "B_Cancelar"
        Me.B_Cancelar.Size = New System.Drawing.Size(75, 23)
        Me.B_Cancelar.TabIndex = 5
        Me.B_Cancelar.Text = "Cancelar"
        Me.B_Cancelar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(126, 116)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "NIP"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(80, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nueva Pregunta Secreta"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(111, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Respuesta:"
        '
        'TB_P_Secure
        '
        Me.TB_P_Secure.Location = New System.Drawing.Point(55, 39)
        Me.TB_P_Secure.MaxLength = 60
        Me.TB_P_Secure.Name = "TB_P_Secure"
        Me.TB_P_Secure.Size = New System.Drawing.Size(170, 20)
        Me.TB_P_Secure.TabIndex = 1
        '
        'TB_Respuesta
        '
        Me.TB_Respuesta.Location = New System.Drawing.Point(89, 88)
        Me.TB_Respuesta.MaxLength = 30
        Me.TB_Respuesta.Name = "TB_Respuesta"
        Me.TB_Respuesta.Size = New System.Drawing.Size(100, 20)
        Me.TB_Respuesta.TabIndex = 2
        '
        'TB_NIP
        '
        Me.TB_NIP.Location = New System.Drawing.Point(114, 138)
        Me.TB_NIP.MaxLength = 4
        Me.TB_NIP.Name = "TB_NIP"
        Me.TB_NIP.Size = New System.Drawing.Size(50, 20)
        Me.TB_NIP.TabIndex = 3
        '
        'ChangeQuestion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 207)
        Me.Controls.Add(Me.TB_NIP)
        Me.Controls.Add(Me.TB_Respuesta)
        Me.Controls.Add(Me.TB_P_Secure)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.B_Cancelar)
        Me.Controls.Add(Me.B_Actualizar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ChangeQuestion"
        Me.Text = "Pregunta Secreta"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents B_Actualizar As System.Windows.Forms.Button
    Friend WithEvents B_Cancelar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TB_P_Secure As System.Windows.Forms.TextBox
    Friend WithEvents TB_Respuesta As System.Windows.Forms.TextBox
    Friend WithEvents TB_NIP As System.Windows.Forms.TextBox
End Class
