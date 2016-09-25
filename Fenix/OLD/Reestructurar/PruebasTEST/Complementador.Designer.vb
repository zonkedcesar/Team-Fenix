<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Complementador
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
        Me.Find = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Find
        '
        Me.Find.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Find.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Find.FormattingEnabled = True
        Me.Find.Items.AddRange(New Object() {"192.168.105.13", "192.168.105.14", "192.168.105.15", "192.168.105.16", "192.168.105.17", "192.168.105.18", "192.168.105.19", "192.168.105.50", "10.255.207.13", "10.255.207.20", "10.255.207.30", "10.255.207.54", "10.255.207.70", "10.255.207.130"})
        Me.Find.Location = New System.Drawing.Point(81, 26)
        Me.Find.Name = "Find"
        Me.Find.Size = New System.Drawing.Size(121, 21)
        Me.Find.TabIndex = 0
        '
        'Complementador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.Find)
        Me.Name = "Complementador"
        Me.Text = "Complementador"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Find As System.Windows.Forms.ComboBox
End Class
