<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MoreServer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MoreServer))
        Me.MoreHostname = New System.Windows.Forms.Label()
        Me.MoreAmbiente = New System.Windows.Forms.Label()
        Me.MoreSite = New System.Windows.Forms.Label()
        Me.OutSite = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OutRack = New System.Windows.Forms.Label()
        Me.MoreModelo = New System.Windows.Forms.Label()
        Me.OutModelo = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.OutSerial = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.OutControlDomain = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.OutSistem = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.OutVersion = New System.Windows.Forms.Label()
        Me.B_Close = New System.Windows.Forms.Button()
        Me.B_Baja = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'MoreHostname
        '
        Me.MoreHostname.AutoSize = True
        Me.MoreHostname.Location = New System.Drawing.Point(39, 15)
        Me.MoreHostname.MinimumSize = New System.Drawing.Size(200, 13)
        Me.MoreHostname.Name = "MoreHostname"
        Me.MoreHostname.Size = New System.Drawing.Size(200, 13)
        Me.MoreHostname.TabIndex = 0
        Me.MoreHostname.Text = "Administrator"
        Me.MoreHostname.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'MoreAmbiente
        '
        Me.MoreAmbiente.AutoSize = True
        Me.MoreAmbiente.Location = New System.Drawing.Point(105, 38)
        Me.MoreAmbiente.Name = "MoreAmbiente"
        Me.MoreAmbiente.Size = New System.Drawing.Size(61, 13)
        Me.MoreAmbiente.TabIndex = 1
        Me.MoreAmbiente.Text = "Produccion"
        Me.MoreAmbiente.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'MoreSite
        '
        Me.MoreSite.AutoSize = True
        Me.MoreSite.Location = New System.Drawing.Point(43, 77)
        Me.MoreSite.Name = "MoreSite"
        Me.MoreSite.Size = New System.Drawing.Size(28, 13)
        Me.MoreSite.TabIndex = 2
        Me.MoreSite.Text = "Site:"
        '
        'OutSite
        '
        Me.OutSite.AutoSize = True
        Me.OutSite.Location = New System.Drawing.Point(77, 77)
        Me.OutSite.Name = "OutSite"
        Me.OutSite.Size = New System.Drawing.Size(0, 13)
        Me.OutSite.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(152, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Rack:"
        '
        'OutRack
        '
        Me.OutRack.AutoSize = True
        Me.OutRack.Location = New System.Drawing.Point(194, 77)
        Me.OutRack.Name = "OutRack"
        Me.OutRack.Size = New System.Drawing.Size(0, 13)
        Me.OutRack.TabIndex = 5
        '
        'MoreModelo
        '
        Me.MoreModelo.AutoSize = True
        Me.MoreModelo.Location = New System.Drawing.Point(26, 105)
        Me.MoreModelo.Name = "MoreModelo"
        Me.MoreModelo.Size = New System.Drawing.Size(45, 13)
        Me.MoreModelo.TabIndex = 6
        Me.MoreModelo.Text = "Modelo:"
        '
        'OutModelo
        '
        Me.OutModelo.AutoSize = True
        Me.OutModelo.Location = New System.Drawing.Point(77, 105)
        Me.OutModelo.Name = "OutModelo"
        Me.OutModelo.Size = New System.Drawing.Size(0, 13)
        Me.OutModelo.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(152, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Serial:"
        '
        'OutSerial
        '
        Me.OutSerial.AutoSize = True
        Me.OutSerial.Location = New System.Drawing.Point(194, 105)
        Me.OutSerial.MaximumSize = New System.Drawing.Size(80, 13)
        Me.OutSerial.Name = "OutSerial"
        Me.OutSerial.Size = New System.Drawing.Size(0, 13)
        Me.OutSerial.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(26, 139)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Hypervisor:"
        '
        'OutControlDomain
        '
        Me.OutControlDomain.AutoSize = True
        Me.OutControlDomain.Location = New System.Drawing.Point(92, 139)
        Me.OutControlDomain.Name = "OutControlDomain"
        Me.OutControlDomain.Size = New System.Drawing.Size(0, 13)
        Me.OutControlDomain.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(39, 164)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Sistema:"
        '
        'OutSistem
        '
        Me.OutSistem.AutoSize = True
        Me.OutSistem.Location = New System.Drawing.Point(92, 164)
        Me.OutSistem.Name = "OutSistem"
        Me.OutSistem.Size = New System.Drawing.Size(0, 13)
        Me.OutSistem.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(41, 189)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Version:"
        '
        'OutVersion
        '
        Me.OutVersion.AutoSize = True
        Me.OutVersion.Location = New System.Drawing.Point(92, 189)
        Me.OutVersion.Name = "OutVersion"
        Me.OutVersion.Size = New System.Drawing.Size(0, 13)
        Me.OutVersion.TabIndex = 15
        '
        'B_Close
        '
        Me.B_Close.Location = New System.Drawing.Point(197, 224)
        Me.B_Close.Name = "B_Close"
        Me.B_Close.Size = New System.Drawing.Size(75, 23)
        Me.B_Close.TabIndex = 16
        Me.B_Close.Text = "Cerrar"
        Me.B_Close.UseVisualStyleBackColor = True
        '
        'B_Baja
        '
        Me.B_Baja.Location = New System.Drawing.Point(12, 224)
        Me.B_Baja.Name = "B_Baja"
        Me.B_Baja.Size = New System.Drawing.Size(75, 23)
        Me.B_Baja.TabIndex = 17
        Me.B_Baja.Text = "Eliminar"
        Me.B_Baja.UseVisualStyleBackColor = True
        '
        'MoreServer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 259)
        Me.Controls.Add(Me.B_Baja)
        Me.Controls.Add(Me.B_Close)
        Me.Controls.Add(Me.OutVersion)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.OutSistem)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.OutControlDomain)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.OutSerial)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.OutModelo)
        Me.Controls.Add(Me.MoreModelo)
        Me.Controls.Add(Me.OutRack)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.OutSite)
        Me.Controls.Add(Me.MoreSite)
        Me.Controls.Add(Me.MoreAmbiente)
        Me.Controls.Add(Me.MoreHostname)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MoreServer"
        Me.Text = "Mas Informacion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MoreHostname As System.Windows.Forms.Label
    Friend WithEvents MoreAmbiente As System.Windows.Forms.Label
    Friend WithEvents MoreSite As System.Windows.Forms.Label
    Friend WithEvents OutSite As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents OutRack As System.Windows.Forms.Label
    Friend WithEvents MoreModelo As System.Windows.Forms.Label
    Friend WithEvents OutModelo As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents OutSerial As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents OutControlDomain As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents OutSistem As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents OutVersion As System.Windows.Forms.Label
    Friend WithEvents B_Close As System.Windows.Forms.Button
    Friend WithEvents B_Baja As System.Windows.Forms.Button
End Class
