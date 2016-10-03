<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cartera_de_Contraseñas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cartera_de_Contraseñas))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.B_Back = New System.Windows.Forms.Button()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Contraseña = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.URL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Comentarios = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.Tipo, Me.Usuario, Me.Contraseña, Me.URL, Me.Comentarios})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(718, 150)
        Me.DataGridView1.TabIndex = 0
        '
        'B_Back
        '
        Me.B_Back.Location = New System.Drawing.Point(12, 228)
        Me.B_Back.Name = "B_Back"
        Me.B_Back.Size = New System.Drawing.Size(75, 23)
        Me.B_Back.TabIndex = 1
        Me.B_Back.Text = "Regresar"
        Me.B_Back.UseVisualStyleBackColor = True
        '
        'Id
        '
        Me.Id.HeaderText = "Id"
        Me.Id.Name = "Id"
        Me.Id.ReadOnly = True
        Me.Id.Width = 50
        '
        'Tipo
        '
        Me.Tipo.HeaderText = "Tipo"
        Me.Tipo.Name = "Tipo"
        '
        'Usuario
        '
        Me.Usuario.HeaderText = "Usuario"
        Me.Usuario.Name = "Usuario"
        '
        'Contraseña
        '
        Me.Contraseña.HeaderText = "Contraseña"
        Me.Contraseña.Name = "Contraseña"
        '
        'URL
        '
        Me.URL.HeaderText = "URL"
        Me.URL.Name = "URL"
        Me.URL.Width = 150
        '
        'Comentarios
        '
        Me.Comentarios.HeaderText = "Comentarios"
        Me.Comentarios.Name = "Comentarios"
        Me.Comentarios.Width = 175
        '
        'Cartera_de_Contraseñas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(742, 283)
        Me.Controls.Add(Me.B_Back)
        Me.Controls.Add(Me.DataGridView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Cartera_de_Contraseñas"
        Me.Text = "Cartera de Contraseñas"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents B_Back As System.Windows.Forms.Button
    Friend WithEvents Id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Usuario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Contraseña As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents URL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Comentarios As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
