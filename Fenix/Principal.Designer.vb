<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Principal))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.B_Generador = New System.Windows.Forms.Button()
        Me.B_Borrado = New System.Windows.Forms.Button()
        Me.B_Cartera = New System.Windows.Forms.Button()
        Me.B_Sesion = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(85, 12)
        Me.PictureBox1.MaximumSize = New System.Drawing.Size(137, 175)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(103, 131)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'B_Generador
        '
        Me.B_Generador.Location = New System.Drawing.Point(40, 154)
        Me.B_Generador.Name = "B_Generador"
        Me.B_Generador.Size = New System.Drawing.Size(75, 43)
        Me.B_Generador.TabIndex = 10
        Me.B_Generador.Text = "Generar Contraseñas"
        Me.B_Generador.UseVisualStyleBackColor = True
        '
        'B_Borrado
        '
        Me.B_Borrado.Location = New System.Drawing.Point(165, 154)
        Me.B_Borrado.Name = "B_Borrado"
        Me.B_Borrado.Size = New System.Drawing.Size(75, 43)
        Me.B_Borrado.TabIndex = 11
        Me.B_Borrado.Text = "Borrado Seguro"
        Me.B_Borrado.UseVisualStyleBackColor = True
        '
        'B_Cartera
        '
        Me.B_Cartera.Location = New System.Drawing.Point(40, 213)
        Me.B_Cartera.Name = "B_Cartera"
        Me.B_Cartera.Size = New System.Drawing.Size(75, 37)
        Me.B_Cartera.TabIndex = 12
        Me.B_Cartera.Text = "Cartera de Contraseñas"
        Me.B_Cartera.UseVisualStyleBackColor = True
        '
        'B_Sesion
        '
        Me.B_Sesion.Location = New System.Drawing.Point(165, 213)
        Me.B_Sesion.Name = "B_Sesion"
        Me.B_Sesion.Size = New System.Drawing.Size(75, 37)
        Me.B_Sesion.TabIndex = 13
        Me.B_Sesion.Text = "Lanzador de Sesiones"
        Me.B_Sesion.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(165, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(96, 28)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 14
        Me.PictureBox2.TabStop = False
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.B_Sesion)
        Me.Controls.Add(Me.B_Cartera)
        Me.Controls.Add(Me.B_Borrado)
        Me.Controls.Add(Me.B_Generador)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Principal"
        Me.Text = "Menu"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents B_Generador As System.Windows.Forms.Button
    Friend WithEvents B_Borrado As System.Windows.Forms.Button
    Friend WithEvents B_Cartera As System.Windows.Forms.Button
    Friend WithEvents B_Sesion As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
End Class
