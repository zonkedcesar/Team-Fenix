<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConfirmarOperacionNIP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConfirmarOperacionNIP))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TB_NIP = New System.Windows.Forms.TextBox()
        Me.B_ConfirmarNIP = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(195, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Por favor ingresar su NIP para confirmar"
        '
        'TB_NIP
        '
        Me.TB_NIP.Location = New System.Drawing.Point(97, 32)
        Me.TB_NIP.MaxLength = 4
        Me.TB_NIP.Name = "TB_NIP"
        Me.TB_NIP.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TB_NIP.Size = New System.Drawing.Size(81, 20)
        Me.TB_NIP.TabIndex = 1
        '
        'B_ConfirmarNIP
        '
        Me.B_ConfirmarNIP.Location = New System.Drawing.Point(101, 61)
        Me.B_ConfirmarNIP.Name = "B_ConfirmarNIP"
        Me.B_ConfirmarNIP.Size = New System.Drawing.Size(75, 23)
        Me.B_ConfirmarNIP.TabIndex = 2
        Me.B_ConfirmarNIP.Text = "Confirmar"
        Me.B_ConfirmarNIP.UseVisualStyleBackColor = True
        '
        'ConfirmarOperacionNIP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 92)
        Me.Controls.Add(Me.B_ConfirmarNIP)
        Me.Controls.Add(Me.TB_NIP)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(300, 131)
        Me.MinimumSize = New System.Drawing.Size(300, 131)
        Me.Name = "ConfirmarOperacionNIP"
        Me.Text = "Confirmar Operacion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TB_NIP As System.Windows.Forms.TextBox
    Friend WithEvents B_ConfirmarNIP As System.Windows.Forms.Button
End Class
