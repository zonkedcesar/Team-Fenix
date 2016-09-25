<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class New_Account
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(New_Account))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TB_Nombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TB_Apellido = New System.Windows.Forms.TextBox()
        Me.B_Crear = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TB_Email = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TB_N_empleado = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TB_Perfil = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre(s):"
        '
        'TB_Nombre
        '
        Me.TB_Nombre.Location = New System.Drawing.Point(94, 50)
        Me.TB_Nombre.Name = "TB_Nombre"
        Me.TB_Nombre.Size = New System.Drawing.Size(160, 20)
        Me.TB_Nombre.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Apellidos:"
        '
        'TB_Apellido
        '
        Me.TB_Apellido.Location = New System.Drawing.Point(94, 76)
        Me.TB_Apellido.Name = "TB_Apellido"
        Me.TB_Apellido.Size = New System.Drawing.Size(160, 20)
        Me.TB_Apellido.TabIndex = 3
        '
        'B_Crear
        '
        Me.B_Crear.Location = New System.Drawing.Point(197, 191)
        Me.B_Crear.Name = "B_Crear"
        Me.B_Crear.Size = New System.Drawing.Size(75, 23)
        Me.B_Crear.TabIndex = 4
        Me.B_Crear.Text = "Crear"
        Me.B_Crear.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Email:"
        '
        'TB_Email
        '
        Me.TB_Email.Location = New System.Drawing.Point(95, 119)
        Me.TB_Email.Name = "TB_Email"
        Me.TB_Email.Size = New System.Drawing.Size(160, 20)
        Me.TB_Email.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 148)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "N° Empleado:"
        '
        'TB_N_empleado
        '
        Me.TB_N_empleado.Location = New System.Drawing.Point(94, 145)
        Me.TB_N_empleado.Name = "TB_N_empleado"
        Me.TB_N_empleado.Size = New System.Drawing.Size(161, 20)
        Me.TB_N_empleado.TabIndex = 8
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 191)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Regresar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Perfil:"
        '
        'TB_Perfil
        '
        Me.TB_Perfil.Location = New System.Drawing.Point(94, 16)
        Me.TB_Perfil.Name = "TB_Perfil"
        Me.TB_Perfil.Size = New System.Drawing.Size(160, 20)
        Me.TB_Perfil.TabIndex = 1
        '
        'New_Account
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 232)
        Me.Controls.Add(Me.TB_Perfil)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TB_N_empleado)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TB_Email)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.B_Crear)
        Me.Controls.Add(Me.TB_Apellido)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TB_Nombre)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "New_Account"
        Me.Text = "Nueva Cuenta"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TB_Nombre As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TB_Apellido As System.Windows.Forms.TextBox
    Friend WithEvents B_Crear As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TB_Email As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TB_N_empleado As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TB_Perfil As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
