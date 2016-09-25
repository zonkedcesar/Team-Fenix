<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistroRack
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegistroRack))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CB_Site = New System.Windows.Forms.ComboBox()
        Me.TB_Numero_Rack = New System.Windows.Forms.TextBox()
        Me.TB_Nombre = New System.Windows.Forms.TextBox()
        Me.CB_Numero_Hilera = New System.Windows.Forms.ComboBox()
        Me.Registrar = New System.Windows.Forms.Button()
        Me.B_Regresar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Numero Rack:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(164, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Numero Hilera:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Site:"
        '
        'CB_Site
        '
        Me.CB_Site.FormattingEnabled = True
        Me.CB_Site.Location = New System.Drawing.Point(46, 6)
        Me.CB_Site.Name = "CB_Site"
        Me.CB_Site.Size = New System.Drawing.Size(108, 21)
        Me.CB_Site.TabIndex = 5
        '
        'TB_Numero_Rack
        '
        Me.TB_Numero_Rack.Location = New System.Drawing.Point(94, 33)
        Me.TB_Numero_Rack.MaxLength = 3
        Me.TB_Numero_Rack.Name = "TB_Numero_Rack"
        Me.TB_Numero_Rack.Size = New System.Drawing.Size(47, 20)
        Me.TB_Numero_Rack.TabIndex = 6
        '
        'TB_Nombre
        '
        Me.TB_Nombre.Location = New System.Drawing.Point(64, 59)
        Me.TB_Nombre.MaxLength = 50
        Me.TB_Nombre.Name = "TB_Nombre"
        Me.TB_Nombre.Size = New System.Drawing.Size(121, 20)
        Me.TB_Nombre.TabIndex = 7
        '
        'CB_Numero_Hilera
        '
        Me.CB_Numero_Hilera.FormattingEnabled = True
        Me.CB_Numero_Hilera.Location = New System.Drawing.Point(247, 33)
        Me.CB_Numero_Hilera.Name = "CB_Numero_Hilera"
        Me.CB_Numero_Hilera.Size = New System.Drawing.Size(47, 21)
        Me.CB_Numero_Hilera.TabIndex = 8
        '
        'Registrar
        '
        Me.Registrar.Location = New System.Drawing.Point(219, 206)
        Me.Registrar.Name = "Registrar"
        Me.Registrar.Size = New System.Drawing.Size(75, 23)
        Me.Registrar.TabIndex = 9
        Me.Registrar.Text = "Registrar"
        Me.Registrar.UseVisualStyleBackColor = True
        '
        'B_Regresar
        '
        Me.B_Regresar.Location = New System.Drawing.Point(17, 206)
        Me.B_Regresar.Name = "B_Regresar"
        Me.B_Regresar.Size = New System.Drawing.Size(75, 23)
        Me.B_Regresar.TabIndex = 10
        Me.B_Regresar.Text = "Regresar"
        Me.B_Regresar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Altura:"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(54, 85)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(40, 20)
        Me.NumericUpDown1.TabIndex = 12
        Me.NumericUpDown1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(95, 89)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(15, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "U"
        '
        'RegistroRack
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(306, 262)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.B_Regresar)
        Me.Controls.Add(Me.Registrar)
        Me.Controls.Add(Me.CB_Numero_Hilera)
        Me.Controls.Add(Me.TB_Nombre)
        Me.Controls.Add(Me.TB_Numero_Rack)
        Me.Controls.Add(Me.CB_Site)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "RegistroRack"
        Me.Text = "Registro Rack"
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CB_Site As System.Windows.Forms.ComboBox
    Friend WithEvents TB_Numero_Rack As System.Windows.Forms.TextBox
    Friend WithEvents TB_Nombre As System.Windows.Forms.TextBox
    Friend WithEvents CB_Numero_Hilera As System.Windows.Forms.ComboBox
    Friend WithEvents Registrar As System.Windows.Forms.Button
    Friend WithEvents B_Regresar As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
