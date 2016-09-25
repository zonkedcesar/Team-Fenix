<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Info_Network
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Info_Network))
        Me.Cancelar = New System.Windows.Forms.Button()
        Me.Anotar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Num_Puerto = New System.Windows.Forms.NumericUpDown()
        Me.TB_Mac_Address = New System.Windows.Forms.TextBox()
        Me.CB_Velocidad_Unidad = New System.Windows.Forms.ComboBox()
        Me.TB_Velocidad_Cifra = New System.Windows.Forms.TextBox()
        Me.Num_NIC = New System.Windows.Forms.NumericUpDown()
        CType(Me.Num_Puerto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Num_NIC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cancelar
        '
        Me.Cancelar.Location = New System.Drawing.Point(12, 119)
        Me.Cancelar.Name = "Cancelar"
        Me.Cancelar.Size = New System.Drawing.Size(75, 23)
        Me.Cancelar.TabIndex = 0
        Me.Cancelar.Text = "Cancelar"
        Me.Cancelar.UseVisualStyleBackColor = True
        '
        'Anotar
        '
        Me.Anotar.Location = New System.Drawing.Point(116, 119)
        Me.Anotar.Name = "Anotar"
        Me.Anotar.Size = New System.Drawing.Size(75, 23)
        Me.Anotar.TabIndex = 1
        Me.Anotar.Text = "Anotar"
        Me.Anotar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "NIC:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Puerto:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Mac Address:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Velocidad:"
        '
        'Num_Puerto
        '
        Me.Num_Puerto.Location = New System.Drawing.Point(151, 36)
        Me.Num_Puerto.Name = "Num_Puerto"
        Me.Num_Puerto.Size = New System.Drawing.Size(40, 20)
        Me.Num_Puerto.TabIndex = 6
        '
        'TB_Mac_Address
        '
        Me.TB_Mac_Address.Location = New System.Drawing.Point(110, 62)
        Me.TB_Mac_Address.Name = "TB_Mac_Address"
        Me.TB_Mac_Address.Size = New System.Drawing.Size(81, 20)
        Me.TB_Mac_Address.TabIndex = 7
        Me.TB_Mac_Address.Text = "00:00:00:00:00"
        '
        'CB_Velocidad_Unidad
        '
        Me.CB_Velocidad_Unidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_Velocidad_Unidad.FormattingEnabled = True
        Me.CB_Velocidad_Unidad.Items.AddRange(New Object() {"MB", "GB"})
        Me.CB_Velocidad_Unidad.Location = New System.Drawing.Point(151, 88)
        Me.CB_Velocidad_Unidad.Name = "CB_Velocidad_Unidad"
        Me.CB_Velocidad_Unidad.Size = New System.Drawing.Size(40, 21)
        Me.CB_Velocidad_Unidad.TabIndex = 8
        '
        'TB_Velocidad_Cifra
        '
        Me.TB_Velocidad_Cifra.Location = New System.Drawing.Point(101, 88)
        Me.TB_Velocidad_Cifra.Name = "TB_Velocidad_Cifra"
        Me.TB_Velocidad_Cifra.Size = New System.Drawing.Size(44, 20)
        Me.TB_Velocidad_Cifra.TabIndex = 9
        Me.TB_Velocidad_Cifra.Text = "100"
        '
        'Num_NIC
        '
        Me.Num_NIC.Location = New System.Drawing.Point(151, 10)
        Me.Num_NIC.Name = "Num_NIC"
        Me.Num_NIC.Size = New System.Drawing.Size(40, 20)
        Me.Num_NIC.TabIndex = 10
        '
        'Info_Network
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(201, 148)
        Me.Controls.Add(Me.Num_NIC)
        Me.Controls.Add(Me.TB_Velocidad_Cifra)
        Me.Controls.Add(Me.CB_Velocidad_Unidad)
        Me.Controls.Add(Me.TB_Mac_Address)
        Me.Controls.Add(Me.Num_Puerto)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Anotar)
        Me.Controls.Add(Me.Cancelar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(217, 186)
        Me.Name = "Info_Network"
        Me.Text = "Info Network"
        CType(Me.Num_Puerto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Num_NIC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Cancelar As System.Windows.Forms.Button
    Friend WithEvents Anotar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Num_Puerto As System.Windows.Forms.NumericUpDown
    Friend WithEvents TB_Mac_Address As System.Windows.Forms.TextBox
    Friend WithEvents CB_Velocidad_Unidad As System.Windows.Forms.ComboBox
    Friend WithEvents TB_Velocidad_Cifra As System.Windows.Forms.TextBox
    Friend WithEvents Num_NIC As System.Windows.Forms.NumericUpDown
End Class
