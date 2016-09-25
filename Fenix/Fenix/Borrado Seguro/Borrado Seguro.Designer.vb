<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Borrado_Seguro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Borrado_Seguro))
        Me.examineButton = New System.Windows.Forms.Button()
        Me.browseButton = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.filesListBox = New System.Windows.Forms.ListBox()
        Me.saveCheckBox = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'examineButton
        '
        Me.examineButton.Location = New System.Drawing.Point(154, 167)
        Me.examineButton.Name = "examineButton"
        Me.examineButton.Size = New System.Drawing.Size(75, 23)
        Me.examineButton.TabIndex = 1
        Me.examineButton.Text = "Archivo"
        Me.examineButton.UseVisualStyleBackColor = True
        '
        'browseButton
        '
        Me.browseButton.Location = New System.Drawing.Point(154, 196)
        Me.browseButton.Name = "browseButton"
        Me.browseButton.Size = New System.Drawing.Size(75, 23)
        Me.browseButton.TabIndex = 2
        Me.browseButton.Text = "Carpeta"
        Me.browseButton.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(133, 225)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(124, 23)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Papeleria de Reciclaje"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 172)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Objeto a eliminar:"
        '
        'filesListBox
        '
        Me.filesListBox.FormattingEnabled = True
        Me.filesListBox.Location = New System.Drawing.Point(154, 20)
        Me.filesListBox.Name = "filesListBox"
        Me.filesListBox.Size = New System.Drawing.Size(277, 95)
        Me.filesListBox.TabIndex = 7
        '
        'saveCheckBox
        '
        Me.saveCheckBox.AutoSize = True
        Me.saveCheckBox.Location = New System.Drawing.Point(293, 134)
        Me.saveCheckBox.Name = "saveCheckBox"
        Me.saveCheckBox.Size = New System.Drawing.Size(81, 17)
        Me.saveCheckBox.TabIndex = 8
        Me.saveCheckBox.Text = "CheckBox1"
        Me.saveCheckBox.UseVisualStyleBackColor = True
        '
        'Borrado_Seguro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(461, 274)
        Me.Controls.Add(Me.saveCheckBox)
        Me.Controls.Add(Me.filesListBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.browseButton)
        Me.Controls.Add(Me.examineButton)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Borrado_Seguro"
        Me.Text = "Borrado Seguro"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents examineButton As System.Windows.Forms.Button
    Friend WithEvents browseButton As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents filesListBox As System.Windows.Forms.ListBox
    Friend WithEvents saveCheckBox As System.Windows.Forms.CheckBox
End Class
