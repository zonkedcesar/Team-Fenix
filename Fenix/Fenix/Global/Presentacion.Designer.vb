<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Presentacion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Presentacion))
        Me.BannerPresentacion = New System.Windows.Forms.PictureBox()
        CType(Me.BannerPresentacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BannerPresentacion
        '
        Me.BannerPresentacion.BackColor = System.Drawing.Color.Transparent
        Me.BannerPresentacion.Image = CType(resources.GetObject("BannerPresentacion.Image"), System.Drawing.Image)
        Me.BannerPresentacion.Location = New System.Drawing.Point(0, 0)
        Me.BannerPresentacion.Name = "BannerPresentacion"
        Me.BannerPresentacion.Size = New System.Drawing.Size(650, 403)
        Me.BannerPresentacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.BannerPresentacion.TabIndex = 0
        Me.BannerPresentacion.TabStop = False
        '
        'Presentacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkKhaki
        Me.ClientSize = New System.Drawing.Size(650, 403)
        Me.ControlBox = False
        Me.Controls.Add(Me.BannerPresentacion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Presentacion"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TransparencyKey = System.Drawing.Color.DarkKhaki
        CType(Me.BannerPresentacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BannerPresentacion As System.Windows.Forms.PictureBox

End Class
