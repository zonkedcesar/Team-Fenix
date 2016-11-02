<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConfirmacionTotal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConfirmacionTotal))
        Me.TB_Pass = New System.Windows.Forms.TextBox()
        Me.TB_NIP = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.B_Confirmar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TB_Pass
        '
        Me.TB_Pass.Location = New System.Drawing.Point(121, 46)
        Me.TB_Pass.Name = "TB_Pass"
        Me.TB_Pass.Size = New System.Drawing.Size(100, 20)
        Me.TB_Pass.TabIndex = 0
        Me.TB_Pass.UseSystemPasswordChar = True
        '
        'TB_NIP
        '
        Me.TB_NIP.Location = New System.Drawing.Point(121, 72)
        Me.TB_NIP.Name = "TB_NIP"
        Me.TB_NIP.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TB_NIP.Size = New System.Drawing.Size(100, 20)
        Me.TB_NIP.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(277, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Por favor llenar la informacion para confirmar la operacion"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(59, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Password:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(79, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "NIP:"
        '
        'B_Confirmar
        '
        Me.B_Confirmar.Location = New System.Drawing.Point(106, 104)
        Me.B_Confirmar.Name = "B_Confirmar"
        Me.B_Confirmar.Size = New System.Drawing.Size(75, 23)
        Me.B_Confirmar.TabIndex = 5
        Me.B_Confirmar.Text = "Confirmar"
        Me.B_Confirmar.UseVisualStyleBackColor = True
        '
        'ConfirmacionTotal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(299, 144)
        Me.Controls.Add(Me.B_Confirmar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TB_NIP)
        Me.Controls.Add(Me.TB_Pass)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(315, 183)
        Me.MinimumSize = New System.Drawing.Size(315, 183)
        Me.Name = "ConfirmacionTotal"
        Me.Text = "Confirmar Operaracion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TB_Pass As System.Windows.Forms.TextBox
    Friend WithEvents TB_NIP As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents B_Confirmar As System.Windows.Forms.Button
End Class
