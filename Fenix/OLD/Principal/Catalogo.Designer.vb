<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Catalogo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Catalogo))
        Me.Ver = New System.Windows.Forms.Button()
        Me.CB_Seleccion = New System.Windows.Forms.ComboBox()
        Me.Altas = New System.Windows.Forms.Button()
        Me.Bajas = New System.Windows.Forms.Button()
        Me.Modificaciones = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Ver
        '
        Me.Ver.Location = New System.Drawing.Point(29, 33)
        Me.Ver.Name = "Ver"
        Me.Ver.Size = New System.Drawing.Size(75, 23)
        Me.Ver.TabIndex = 0
        Me.Ver.Text = "Ver"
        Me.Ver.UseVisualStyleBackColor = True
        '
        'CB_Seleccion
        '
        Me.CB_Seleccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_Seleccion.FormattingEnabled = True
        Me.CB_Seleccion.Items.AddRange(New Object() {"Sites", "Racks", "Equipos", "Servidores"})
        Me.CB_Seleccion.Location = New System.Drawing.Point(93, 6)
        Me.CB_Seleccion.Name = "CB_Seleccion"
        Me.CB_Seleccion.Size = New System.Drawing.Size(105, 21)
        Me.CB_Seleccion.TabIndex = 2
        '
        'Altas
        '
        Me.Altas.Location = New System.Drawing.Point(29, 62)
        Me.Altas.Name = "Altas"
        Me.Altas.Size = New System.Drawing.Size(75, 23)
        Me.Altas.TabIndex = 3
        Me.Altas.Text = "Altas"
        Me.Altas.UseVisualStyleBackColor = True
        '
        'Bajas
        '
        Me.Bajas.Location = New System.Drawing.Point(179, 62)
        Me.Bajas.Name = "Bajas"
        Me.Bajas.Size = New System.Drawing.Size(75, 23)
        Me.Bajas.TabIndex = 4
        Me.Bajas.Text = "Bajas"
        Me.Bajas.UseVisualStyleBackColor = True
        '
        'Modificaciones
        '
        Me.Modificaciones.Location = New System.Drawing.Point(179, 33)
        Me.Modificaciones.Name = "Modificaciones"
        Me.Modificaciones.Size = New System.Drawing.Size(75, 23)
        Me.Modificaciones.TabIndex = 5
        Me.Modificaciones.Text = "Modificacion"
        Me.Modificaciones.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 91)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Regresar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Seleccion:"
        '
        'Catalogo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 123)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Modificaciones)
        Me.Controls.Add(Me.Bajas)
        Me.Controls.Add(Me.Altas)
        Me.Controls.Add(Me.CB_Seleccion)
        Me.Controls.Add(Me.Ver)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Catalogo"
        Me.Text = "Catalogo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Ver As System.Windows.Forms.Button
    Friend WithEvents CB_Seleccion As System.Windows.Forms.ComboBox
    Friend WithEvents Altas As System.Windows.Forms.Button
    Friend WithEvents Bajas As System.Windows.Forms.Button
    Friend WithEvents Modificaciones As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
