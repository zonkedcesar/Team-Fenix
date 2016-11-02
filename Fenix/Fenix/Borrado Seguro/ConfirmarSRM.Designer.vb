<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConfirmarSRM
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConfirmarSRM))
        Me.OutputSRM = New System.Windows.Forms.ListBox()
        Me.Borrar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'OutputSRM
        '
        Me.OutputSRM.FormattingEnabled = True
        Me.OutputSRM.HorizontalScrollbar = True
        Me.OutputSRM.Location = New System.Drawing.Point(12, 12)
        Me.OutputSRM.Name = "OutputSRM"
        Me.OutputSRM.Size = New System.Drawing.Size(494, 95)
        Me.OutputSRM.TabIndex = 0
        '
        'Borrar
        '
        Me.Borrar.Location = New System.Drawing.Point(207, 113)
        Me.Borrar.Name = "Borrar"
        Me.Borrar.Size = New System.Drawing.Size(75, 23)
        Me.Borrar.TabIndex = 1
        Me.Borrar.Text = "Borrar"
        Me.Borrar.UseVisualStyleBackColor = True
        '
        'ConfirmarSRM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(517, 146)
        Me.Controls.Add(Me.Borrar)
        Me.Controls.Add(Me.OutputSRM)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(500, 150)
        Me.MaximumSize = New System.Drawing.Size(533, 185)
        Me.MinimumSize = New System.Drawing.Size(533, 185)
        Me.Name = "ConfirmarSRM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Borrar"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OutputSRM As System.Windows.Forms.ListBox
    Friend WithEvents Borrar As System.Windows.Forms.Button
End Class
