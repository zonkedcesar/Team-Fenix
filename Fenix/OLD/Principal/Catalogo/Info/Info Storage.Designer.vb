<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Info_Storage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Info_Storage))
        Me.Cancelar = New System.Windows.Forms.Button()
        Me.Anotar = New System.Windows.Forms.Button()
        Me.CB_Tipo = New System.Windows.Forms.ComboBox()
        Me.TB_NumeroSerie = New System.Windows.Forms.TextBox()
        Me.CB_Capacidad_Unidad = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TB_DiscoDuro = New System.Windows.Forms.TextBox()
        Me.CB_Marca = New System.Windows.Forms.ComboBox()
        Me.CB_Modelo = New System.Windows.Forms.ComboBox()
        Me.TB_Capacidad_Cifra = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Cancelar
        '
        Me.Cancelar.Location = New System.Drawing.Point(12, 166)
        Me.Cancelar.Name = "Cancelar"
        Me.Cancelar.Size = New System.Drawing.Size(75, 23)
        Me.Cancelar.TabIndex = 0
        Me.Cancelar.Text = "Cancelar"
        Me.Cancelar.UseVisualStyleBackColor = True
        '
        'Anotar
        '
        Me.Anotar.Location = New System.Drawing.Point(122, 166)
        Me.Anotar.Name = "Anotar"
        Me.Anotar.Size = New System.Drawing.Size(75, 23)
        Me.Anotar.TabIndex = 1
        Me.Anotar.Text = "Anotar"
        Me.Anotar.UseVisualStyleBackColor = True
        '
        'CB_Tipo
        '
        Me.CB_Tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_Tipo.FormattingEnabled = True
        Me.CB_Tipo.Items.AddRange(New Object() {"HDD", "SSD"})
        Me.CB_Tipo.Location = New System.Drawing.Point(143, 113)
        Me.CB_Tipo.Name = "CB_Tipo"
        Me.CB_Tipo.Size = New System.Drawing.Size(52, 21)
        Me.CB_Tipo.TabIndex = 19
        '
        'TB_NumeroSerie
        '
        Me.TB_NumeroSerie.Location = New System.Drawing.Point(95, 140)
        Me.TB_NumeroSerie.Name = "TB_NumeroSerie"
        Me.TB_NumeroSerie.Size = New System.Drawing.Size(100, 20)
        Me.TB_NumeroSerie.TabIndex = 18
        '
        'CB_Capacidad_Unidad
        '
        Me.CB_Capacidad_Unidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_Capacidad_Unidad.FormattingEnabled = True
        Me.CB_Capacidad_Unidad.Items.AddRange(New Object() {"GB", "TB"})
        Me.CB_Capacidad_Unidad.Location = New System.Drawing.Point(153, 86)
        Me.CB_Capacidad_Unidad.Name = "CB_Capacidad_Unidad"
        Me.CB_Capacidad_Unidad.Size = New System.Drawing.Size(42, 21)
        Me.CB_Capacidad_Unidad.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 143)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Numero Serie:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 116)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Tipo:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Capacidad:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Modelo:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Marca:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Disco Duro:"
        '
        'TB_DiscoDuro
        '
        Me.TB_DiscoDuro.Location = New System.Drawing.Point(153, 6)
        Me.TB_DiscoDuro.Name = "TB_DiscoDuro"
        Me.TB_DiscoDuro.Size = New System.Drawing.Size(44, 20)
        Me.TB_DiscoDuro.TabIndex = 20
        Me.TB_DiscoDuro.Text = "1"
        '
        'CB_Marca
        '
        Me.CB_Marca.FormattingEnabled = True
        Me.CB_Marca.Location = New System.Drawing.Point(95, 32)
        Me.CB_Marca.Name = "CB_Marca"
        Me.CB_Marca.Size = New System.Drawing.Size(102, 21)
        Me.CB_Marca.TabIndex = 21
        '
        'CB_Modelo
        '
        Me.CB_Modelo.FormattingEnabled = True
        Me.CB_Modelo.Location = New System.Drawing.Point(95, 59)
        Me.CB_Modelo.Name = "CB_Modelo"
        Me.CB_Modelo.Size = New System.Drawing.Size(102, 21)
        Me.CB_Modelo.TabIndex = 22
        '
        'TB_Capacidad_Cifra
        '
        Me.TB_Capacidad_Cifra.Location = New System.Drawing.Point(95, 86)
        Me.TB_Capacidad_Cifra.Name = "TB_Capacidad_Cifra"
        Me.TB_Capacidad_Cifra.Size = New System.Drawing.Size(52, 20)
        Me.TB_Capacidad_Cifra.TabIndex = 23
        '
        'Info_Storage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(205, 194)
        Me.Controls.Add(Me.TB_Capacidad_Cifra)
        Me.Controls.Add(Me.CB_Modelo)
        Me.Controls.Add(Me.CB_Marca)
        Me.Controls.Add(Me.TB_DiscoDuro)
        Me.Controls.Add(Me.CB_Tipo)
        Me.Controls.Add(Me.TB_NumeroSerie)
        Me.Controls.Add(Me.CB_Capacidad_Unidad)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Anotar)
        Me.Controls.Add(Me.Cancelar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Info_Storage"
        Me.Text = "Info Storage"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Cancelar As System.Windows.Forms.Button
    Friend WithEvents Anotar As System.Windows.Forms.Button
    Friend WithEvents CB_Tipo As System.Windows.Forms.ComboBox
    Friend WithEvents TB_NumeroSerie As System.Windows.Forms.TextBox
    Friend WithEvents CB_Capacidad_Unidad As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TB_DiscoDuro As System.Windows.Forms.TextBox
    Friend WithEvents CB_Marca As System.Windows.Forms.ComboBox
    Friend WithEvents CB_Modelo As System.Windows.Forms.ComboBox
    Friend WithEvents TB_Capacidad_Cifra As System.Windows.Forms.TextBox
End Class
