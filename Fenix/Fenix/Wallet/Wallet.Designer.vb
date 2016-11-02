<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Wallet
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Wallet))
        Me.PanelDePassword = New System.Windows.Forms.ListView()
        Me.ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Titulo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Usuario = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Password = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.URL = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Comentarios = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.B_Back = New System.Windows.Forms.Button()
        Me.MenuWallet = New System.Windows.Forms.MenuStrip()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CB_type = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TB_Out_PSW = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.VerPass = New System.Windows.Forms.Button()
        Me.TiempoCopy = New System.Windows.Forms.Timer(Me.components)
        Me.Out_Time_Life = New System.Windows.Forms.Label()
        Me.T_lockPass = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.OutTimeView = New System.Windows.Forms.Label()
        Me.MenuWallet.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelDePassword
        '
        Me.PanelDePassword.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ID, Me.Titulo, Me.Usuario, Me.Password, Me.URL, Me.Comentarios})
        Me.PanelDePassword.Enabled = False
        Me.PanelDePassword.FullRowSelect = True
        Me.PanelDePassword.GridLines = True
        Me.PanelDePassword.Location = New System.Drawing.Point(12, 42)
        Me.PanelDePassword.MaximumSize = New System.Drawing.Size(660, 178)
        Me.PanelDePassword.MultiSelect = False
        Me.PanelDePassword.Name = "PanelDePassword"
        Me.PanelDePassword.Size = New System.Drawing.Size(660, 178)
        Me.PanelDePassword.TabIndex = 0
        Me.PanelDePassword.UseCompatibleStateImageBehavior = False
        Me.PanelDePassword.View = System.Windows.Forms.View.Details
        '
        'ID
        '
        Me.ID.Text = "ID"
        Me.ID.Width = 30
        '
        'Titulo
        '
        Me.Titulo.Text = "Titulo"
        Me.Titulo.Width = 70
        '
        'Usuario
        '
        Me.Usuario.Text = "Usuario"
        Me.Usuario.Width = 130
        '
        'Password
        '
        Me.Password.Text = "Contraseña"
        Me.Password.Width = 80
        '
        'URL
        '
        Me.URL.Text = "URL"
        Me.URL.Width = 130
        '
        'Comentarios
        '
        Me.Comentarios.Text = "Comentarios"
        Me.Comentarios.Width = 195
        '
        'B_Back
        '
        Me.B_Back.Location = New System.Drawing.Point(12, 226)
        Me.B_Back.Name = "B_Back"
        Me.B_Back.Size = New System.Drawing.Size(75, 23)
        Me.B_Back.TabIndex = 1
        Me.B_Back.Text = "Regresar"
        Me.B_Back.UseVisualStyleBackColor = True
        '
        'MenuWallet
        '
        Me.MenuWallet.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.ModificarToolStripMenuItem, Me.EliminarToolStripMenuItem})
        Me.MenuWallet.Location = New System.Drawing.Point(0, 0)
        Me.MenuWallet.Name = "MenuWallet"
        Me.MenuWallet.Size = New System.Drawing.Size(684, 24)
        Me.MenuWallet.TabIndex = 2
        Me.MenuWallet.Text = "MenuStrip1"
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.NuevoToolStripMenuItem.Text = "Nuevo"
        '
        'ModificarToolStripMenuItem
        '
        Me.ModificarToolStripMenuItem.Enabled = False
        Me.ModificarToolStripMenuItem.Name = "ModificarToolStripMenuItem"
        Me.ModificarToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.ModificarToolStripMenuItem.Text = "Modificar"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Enabled = False
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'CB_type
        '
        Me.CB_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CB_type.FormattingEnabled = True
        Me.CB_type.Items.AddRange(New Object() {"Application", "WebSite", "Email", "Windows", "Networks"})
        Me.CB_type.Location = New System.Drawing.Point(551, 228)
        Me.CB_type.Name = "CB_type"
        Me.CB_type.Size = New System.Drawing.Size(121, 21)
        Me.CB_type.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(467, 231)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Lista a mostrar:"
        '
        'TB_Out_PSW
        '
        Me.TB_Out_PSW.Enabled = False
        Me.TB_Out_PSW.Location = New System.Drawing.Point(198, 228)
        Me.TB_Out_PSW.Name = "TB_Out_PSW"
        Me.TB_Out_PSW.Size = New System.Drawing.Size(200, 20)
        Me.TB_Out_PSW.TabIndex = 5
        Me.TB_Out_PSW.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TB_Out_PSW.UseSystemPasswordChar = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(128, 231)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Contraseña:"
        '
        'VerPass
        '
        Me.VerPass.BackColor = System.Drawing.SystemColors.Control
        Me.VerPass.Image = CType(resources.GetObject("VerPass.Image"), System.Drawing.Image)
        Me.VerPass.Location = New System.Drawing.Point(404, 227)
        Me.VerPass.Name = "VerPass"
        Me.VerPass.Size = New System.Drawing.Size(30, 20)
        Me.VerPass.TabIndex = 19
        Me.VerPass.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.ToolTip1.SetToolTip(Me.VerPass, "3 Seg. Visible Contraseña")
        Me.VerPass.UseVisualStyleBackColor = False
        '
        'TiempoCopy
        '
        '
        'Out_Time_Life
        '
        Me.Out_Time_Life.AutoSize = True
        Me.Out_Time_Life.Location = New System.Drawing.Point(467, 6)
        Me.Out_Time_Life.MaximumSize = New System.Drawing.Size(200, 13)
        Me.Out_Time_Life.MinimumSize = New System.Drawing.Size(200, 13)
        Me.Out_Time_Life.Name = "Out_Time_Life"
        Me.Out_Time_Life.Size = New System.Drawing.Size(200, 13)
        Me.Out_Time_Life.TabIndex = 20
        Me.Out_Time_Life.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Out_Time_Life.Visible = False
        '
        'T_lockPass
        '
        '
        'OutTimeView
        '
        Me.OutTimeView.AutoSize = True
        Me.OutTimeView.Location = New System.Drawing.Point(440, 231)
        Me.OutTimeView.MaximumSize = New System.Drawing.Size(13, 13)
        Me.OutTimeView.MinimumSize = New System.Drawing.Size(13, 13)
        Me.OutTimeView.Name = "OutTimeView"
        Me.OutTimeView.Size = New System.Drawing.Size(13, 13)
        Me.OutTimeView.TabIndex = 21
        Me.OutTimeView.Visible = False
        '
        'Wallet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 261)
        Me.Controls.Add(Me.OutTimeView)
        Me.Controls.Add(Me.Out_Time_Life)
        Me.Controls.Add(Me.VerPass)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TB_Out_PSW)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CB_type)
        Me.Controls.Add(Me.B_Back)
        Me.Controls.Add(Me.PanelDePassword)
        Me.Controls.Add(Me.MenuWallet)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(350, 150)
        Me.MainMenuStrip = Me.MenuWallet
        Me.MaximumSize = New System.Drawing.Size(700, 300)
        Me.MinimumSize = New System.Drawing.Size(700, 300)
        Me.Name = "Wallet"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Cartera de Contraseñas"
        Me.MenuWallet.ResumeLayout(False)
        Me.MenuWallet.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PanelDePassword As System.Windows.Forms.ListView
    Friend WithEvents Titulo As System.Windows.Forms.ColumnHeader
    Friend WithEvents Usuario As System.Windows.Forms.ColumnHeader
    Friend WithEvents Password As System.Windows.Forms.ColumnHeader
    Friend WithEvents URL As System.Windows.Forms.ColumnHeader
    Friend WithEvents Comentarios As System.Windows.Forms.ColumnHeader
    Friend WithEvents B_Back As System.Windows.Forms.Button
    Friend WithEvents MenuWallet As System.Windows.Forms.MenuStrip
    Friend WithEvents NuevoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CB_type As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ID As System.Windows.Forms.ColumnHeader
    Friend WithEvents TB_Out_PSW As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents VerPass As System.Windows.Forms.Button
    Friend WithEvents TiempoCopy As System.Windows.Forms.Timer
    Friend WithEvents Out_Time_Life As System.Windows.Forms.Label
    Friend WithEvents T_lockPass As System.Windows.Forms.Timer
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents OutTimeView As System.Windows.Forms.Label
End Class
