<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModificar
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
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtRUsuario = New System.Windows.Forms.TextBox()
        Me.txtRNombre = New System.Windows.Forms.TextBox()
        Me.txtRApellido = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtRTelefono = New System.Windows.Forms.TextBox()
        Me.cmdVolver = New System.Windows.Forms.Button()
        Me.cmdGuardar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Location = New System.Drawing.Point(27, 19)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(46, 13)
        Me.lblUsuario.TabIndex = 14
        Me.lblUsuario.Text = "Usuario:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Nombre:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(27, 93)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Apellido:"
        '
        'txtRUsuario
        '
        Me.txtRUsuario.Location = New System.Drawing.Point(80, 15)
        Me.txtRUsuario.Name = "txtRUsuario"
        Me.txtRUsuario.ReadOnly = True
        Me.txtRUsuario.Size = New System.Drawing.Size(196, 20)
        Me.txtRUsuario.TabIndex = 18
        '
        'txtRNombre
        '
        Me.txtRNombre.Location = New System.Drawing.Point(80, 52)
        Me.txtRNombre.Name = "txtRNombre"
        Me.txtRNombre.Size = New System.Drawing.Size(196, 20)
        Me.txtRNombre.TabIndex = 20
        '
        'txtRApellido
        '
        Me.txtRApellido.Location = New System.Drawing.Point(81, 89)
        Me.txtRApellido.Name = "txtRApellido"
        Me.txtRApellido.Size = New System.Drawing.Size(195, 20)
        Me.txtRApellido.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 130)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Teléfono:"
        '
        'txtRTelefono
        '
        Me.txtRTelefono.Location = New System.Drawing.Point(80, 126)
        Me.txtRTelefono.Name = "txtRTelefono"
        Me.txtRTelefono.Size = New System.Drawing.Size(196, 20)
        Me.txtRTelefono.TabIndex = 24
        '
        'cmdVolver
        '
        Me.cmdVolver.Location = New System.Drawing.Point(200, 178)
        Me.cmdVolver.Name = "cmdVolver"
        Me.cmdVolver.Size = New System.Drawing.Size(75, 23)
        Me.cmdVolver.TabIndex = 25
        Me.cmdVolver.Text = "Volver"
        Me.cmdVolver.UseVisualStyleBackColor = True
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Location = New System.Drawing.Point(32, 178)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(75, 23)
        Me.cmdGuardar.TabIndex = 26
        Me.cmdGuardar.Text = "Guardar"
        Me.cmdGuardar.UseVisualStyleBackColor = True
        '
        'frmModificar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(320, 213)
        Me.Controls.Add(Me.cmdGuardar)
        Me.Controls.Add(Me.cmdVolver)
        Me.Controls.Add(Me.txtRNombre)
        Me.Controls.Add(Me.txtRTelefono)
        Me.Controls.Add(Me.lblUsuario)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtRApellido)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtRUsuario)
        Me.Name = "frmModificar"
        Me.Text = "Modificar Usuario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblUsuario As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtRUsuario As TextBox
    Friend WithEvents txtRNombre As TextBox
    Friend WithEvents txtRApellido As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtRTelefono As TextBox
    Friend WithEvents cmdVolver As Button
    Friend WithEvents cmdGuardar As Button
End Class
