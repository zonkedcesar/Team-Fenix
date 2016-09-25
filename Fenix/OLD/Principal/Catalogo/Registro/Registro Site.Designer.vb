<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registro_Site
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Registro_Site))
        Me.B_Regresar = New System.Windows.Forms.Button()
        Me.B_Registrar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TB_Site = New System.Windows.Forms.TextBox()
        Me.TB_Ciudad = New System.Windows.Forms.TextBox()
        Me.TB_Direccion = New System.Windows.Forms.TextBox()
        Me.TB_CP = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'B_Regresar
        '
        Me.B_Regresar.Location = New System.Drawing.Point(12, 155)
        Me.B_Regresar.Name = "B_Regresar"
        Me.B_Regresar.Size = New System.Drawing.Size(75, 23)
        Me.B_Regresar.TabIndex = 0
        Me.B_Regresar.Text = "Regresar"
        Me.B_Regresar.UseVisualStyleBackColor = True
        '
        'B_Registrar
        '
        Me.B_Registrar.Location = New System.Drawing.Point(260, 155)
        Me.B_Registrar.Name = "B_Registrar"
        Me.B_Registrar.Size = New System.Drawing.Size(75, 23)
        Me.B_Registrar.TabIndex = 1
        Me.B_Registrar.Text = "Registrar"
        Me.B_Registrar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Site:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(186, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Ciudad:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Direccion:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(192, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Codigo Postal:"
        '
        'TB_Site
        '
        Me.TB_Site.Location = New System.Drawing.Point(43, 12)
        Me.TB_Site.MaxLength = 50
        Me.TB_Site.Name = "TB_Site"
        Me.TB_Site.Size = New System.Drawing.Size(100, 20)
        Me.TB_Site.TabIndex = 6
        '
        'TB_Ciudad
        '
        Me.TB_Ciudad.Location = New System.Drawing.Point(235, 12)
        Me.TB_Ciudad.MaxLength = 100
        Me.TB_Ciudad.Name = "TB_Ciudad"
        Me.TB_Ciudad.Size = New System.Drawing.Size(100, 20)
        Me.TB_Ciudad.TabIndex = 7
        '
        'TB_Direccion
        '
        Me.TB_Direccion.Location = New System.Drawing.Point(70, 41)
        Me.TB_Direccion.Name = "TB_Direccion"
        Me.TB_Direccion.Size = New System.Drawing.Size(100, 20)
        Me.TB_Direccion.TabIndex = 8
        '
        'TB_CP
        '
        Me.TB_CP.Location = New System.Drawing.Point(273, 41)
        Me.TB_CP.MaxLength = 8
        Me.TB_CP.Name = "TB_CP"
        Me.TB_CP.Size = New System.Drawing.Size(62, 20)
        Me.TB_CP.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Proveedor:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(74, 71)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 104)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Comentarios:"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(78, 104)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(257, 45)
        Me.TextBox2.TabIndex = 13
        '
        'Registro_Site
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(347, 186)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TB_CP)
        Me.Controls.Add(Me.TB_Direccion)
        Me.Controls.Add(Me.TB_Ciudad)
        Me.Controls.Add(Me.TB_Site)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.B_Registrar)
        Me.Controls.Add(Me.B_Regresar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Registro_Site"
        Me.Text = "Registro Site"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents B_Regresar As System.Windows.Forms.Button
    Friend WithEvents B_Registrar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TB_Site As System.Windows.Forms.TextBox
    Friend WithEvents TB_Ciudad As System.Windows.Forms.TextBox
    Friend WithEvents TB_Direccion As System.Windows.Forms.TextBox
    Friend WithEvents TB_CP As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
End Class
