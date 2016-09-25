<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Contraseña
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Contraseña))
        Me.Tb_NewPass = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TB_ConfPass = New System.Windows.Forms.TextBox()
        Me.B_PasswordUser = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'Tb_NewPass
        '
        Me.Tb_NewPass.Location = New System.Drawing.Point(48, 42)
        Me.Tb_NewPass.MaxLength = 12
        Me.Tb_NewPass.Name = "Tb_NewPass"
        Me.Tb_NewPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Tb_NewPass.Size = New System.Drawing.Size(100, 20)
        Me.Tb_NewPass.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nueva Contraseña:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(45, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Confirmar Contraseña:"
        '
        'TB_ConfPass
        '
        Me.TB_ConfPass.Location = New System.Drawing.Point(48, 104)
        Me.TB_ConfPass.MaxLength = 12
        Me.TB_ConfPass.Name = "TB_ConfPass"
        Me.TB_ConfPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TB_ConfPass.Size = New System.Drawing.Size(100, 20)
        Me.TB_ConfPass.TabIndex = 3
        '
        'B_PasswordUser
        '
        Me.B_PasswordUser.Location = New System.Drawing.Point(57, 148)
        Me.B_PasswordUser.Name = "B_PasswordUser"
        Me.B_PasswordUser.Size = New System.Drawing.Size(75, 23)
        Me.B_PasswordUser.TabIndex = 4
        Me.B_PasswordUser.Text = "OK"
        Me.B_PasswordUser.UseVisualStyleBackColor = True
        '
        'Contraseña
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(201, 183)
        Me.Controls.Add(Me.B_PasswordUser)
        Me.Controls.Add(Me.TB_ConfPass)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Tb_NewPass)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Contraseña"
        Me.Text = "Contraseña"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Tb_NewPass As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TB_ConfPass As System.Windows.Forms.TextBox
    Friend WithEvents B_PasswordUser As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
