﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class changeNip
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(changeNip))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TB_A_NIP = New System.Windows.Forms.TextBox()
        Me.TB_N_NIP = New System.Windows.Forms.TextBox()
        Me.TB_C_NIP = New System.Windows.Forms.TextBox()
        Me.B_Actualizar = New System.Windows.Forms.Button()
        Me.B_Cancelar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Actual NIP:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nuevo NIP:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Confirmar NIP:"
        '
        'TB_A_NIP
        '
        Me.TB_A_NIP.Location = New System.Drawing.Point(139, 23)
        Me.TB_A_NIP.Name = "TB_A_NIP"
        Me.TB_A_NIP.Size = New System.Drawing.Size(100, 20)
        Me.TB_A_NIP.TabIndex = 3
        '
        'TB_N_NIP
        '
        Me.TB_N_NIP.Location = New System.Drawing.Point(139, 58)
        Me.TB_N_NIP.Name = "TB_N_NIP"
        Me.TB_N_NIP.Size = New System.Drawing.Size(100, 20)
        Me.TB_N_NIP.TabIndex = 4
        '
        'TB_C_NIP
        '
        Me.TB_C_NIP.Location = New System.Drawing.Point(139, 94)
        Me.TB_C_NIP.Name = "TB_C_NIP"
        Me.TB_C_NIP.Size = New System.Drawing.Size(100, 20)
        Me.TB_C_NIP.TabIndex = 5
        '
        'B_Actualizar
        '
        Me.B_Actualizar.Location = New System.Drawing.Point(12, 132)
        Me.B_Actualizar.Name = "B_Actualizar"
        Me.B_Actualizar.Size = New System.Drawing.Size(75, 23)
        Me.B_Actualizar.TabIndex = 6
        Me.B_Actualizar.Text = "Actualizar"
        Me.B_Actualizar.UseVisualStyleBackColor = True
        '
        'B_Cancelar
        '
        Me.B_Cancelar.Location = New System.Drawing.Point(197, 132)
        Me.B_Cancelar.Name = "B_Cancelar"
        Me.B_Cancelar.Size = New System.Drawing.Size(75, 23)
        Me.B_Cancelar.TabIndex = 7
        Me.B_Cancelar.Text = "Cancelar"
        Me.B_Cancelar.UseVisualStyleBackColor = True
        '
        'changeNip
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 168)
        Me.Controls.Add(Me.B_Cancelar)
        Me.Controls.Add(Me.B_Actualizar)
        Me.Controls.Add(Me.TB_C_NIP)
        Me.Controls.Add(Me.TB_N_NIP)
        Me.Controls.Add(Me.TB_A_NIP)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "changeNip"
        Me.Text = "Cambio de NIP"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TB_A_NIP As System.Windows.Forms.TextBox
    Friend WithEvents TB_N_NIP As System.Windows.Forms.TextBox
    Friend WithEvents TB_C_NIP As System.Windows.Forms.TextBox
    Friend WithEvents B_Actualizar As System.Windows.Forms.Button
    Friend WithEvents B_Cancelar As System.Windows.Forms.Button
End Class
