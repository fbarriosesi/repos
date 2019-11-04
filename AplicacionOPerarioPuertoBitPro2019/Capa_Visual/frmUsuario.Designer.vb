<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmUsuario
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUsuario))
        Me.lblBCedula = New System.Windows.Forms.Label()
        Me.lblBUsuario = New System.Windows.Forms.Label()
        Me.cmdBuscarCedula = New System.Windows.Forms.Button()
        Me.txtBCedula = New System.Windows.Forms.TextBox()
        Me.txtBUsuario = New System.Windows.Forms.TextBox()
        Me.cmdBuscarUsuario = New System.Windows.Forms.Button()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.lblCedula = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtRUsuario = New System.Windows.Forms.TextBox()
        Me.txtRCedula = New System.Windows.Forms.TextBox()
        Me.txtRNombre = New System.Windows.Forms.TextBox()
        Me.txtRApellido = New System.Windows.Forms.TextBox()
        Me.cmdVolver = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtRTelefono = New System.Windows.Forms.TextBox()
        Me.cmdModificar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblBCedula
        '
        Me.lblBCedula.AutoSize = True
        Me.lblBCedula.Location = New System.Drawing.Point(16, 44)
        Me.lblBCedula.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBCedula.Name = "lblBCedula"
        Me.lblBCedula.Size = New System.Drawing.Size(122, 17)
        Me.lblBCedula.TabIndex = 12
        Me.lblBCedula.Text = "Bucar por Cedula:"
        '
        'lblBUsuario
        '
        Me.lblBUsuario.AutoSize = True
        Me.lblBUsuario.Location = New System.Drawing.Point(16, 11)
        Me.lblBUsuario.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBUsuario.Name = "lblBUsuario"
        Me.lblBUsuario.Size = New System.Drawing.Size(127, 17)
        Me.lblBUsuario.TabIndex = 13
        Me.lblBUsuario.Text = "Bucar por Usuario:"
        '
        'cmdBuscarCedula
        '
        Me.cmdBuscarCedula.Location = New System.Drawing.Point(373, 39)
        Me.cmdBuscarCedula.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdBuscarCedula.Name = "cmdBuscarCedula"
        Me.cmdBuscarCedula.Size = New System.Drawing.Size(100, 28)
        Me.cmdBuscarCedula.TabIndex = 11
        Me.cmdBuscarCedula.Text = "Buscar"
        Me.cmdBuscarCedula.UseVisualStyleBackColor = True
        '
        'txtBCedula
        '
        Me.txtBCedula.Location = New System.Drawing.Point(172, 41)
        Me.txtBCedula.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtBCedula.MaxLength = 8
        Me.txtBCedula.Name = "txtBCedula"
        Me.txtBCedula.Size = New System.Drawing.Size(175, 22)
        Me.txtBCedula.TabIndex = 10
        '
        'txtBUsuario
        '
        Me.txtBUsuario.Location = New System.Drawing.Point(172, 7)
        Me.txtBUsuario.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtBUsuario.Name = "txtBUsuario"
        Me.txtBUsuario.Size = New System.Drawing.Size(175, 22)
        Me.txtBUsuario.TabIndex = 9
        '
        'cmdBuscarUsuario
        '
        Me.cmdBuscarUsuario.Location = New System.Drawing.Point(373, 6)
        Me.cmdBuscarUsuario.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdBuscarUsuario.Name = "cmdBuscarUsuario"
        Me.cmdBuscarUsuario.Size = New System.Drawing.Size(100, 28)
        Me.cmdBuscarUsuario.TabIndex = 8
        Me.cmdBuscarUsuario.Text = "Buscar"
        Me.cmdBuscarUsuario.UseVisualStyleBackColor = True
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Location = New System.Drawing.Point(16, 114)
        Me.lblUsuario.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(61, 17)
        Me.lblUsuario.TabIndex = 14
        Me.lblUsuario.Text = "Usuario:"
        '
        'lblCedula
        '
        Me.lblCedula.AutoSize = True
        Me.lblCedula.Location = New System.Drawing.Point(19, 151)
        Me.lblCedula.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCedula.Name = "lblCedula"
        Me.lblCedula.Size = New System.Drawing.Size(56, 17)
        Me.lblCedula.TabIndex = 15
        Me.lblCedula.Text = "Cedula:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 188)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 17)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Nombre:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 225)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 17)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Apellido:"
        '
        'txtRUsuario
        '
        Me.txtRUsuario.Location = New System.Drawing.Point(87, 110)
        Me.txtRUsuario.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtRUsuario.Name = "txtRUsuario"
        Me.txtRUsuario.ReadOnly = True
        Me.txtRUsuario.Size = New System.Drawing.Size(260, 22)
        Me.txtRUsuario.TabIndex = 18
        '
        'txtRCedula
        '
        Me.txtRCedula.Location = New System.Drawing.Point(87, 146)
        Me.txtRCedula.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtRCedula.Name = "txtRCedula"
        Me.txtRCedula.ReadOnly = True
        Me.txtRCedula.Size = New System.Drawing.Size(260, 22)
        Me.txtRCedula.TabIndex = 19
        '
        'txtRNombre
        '
        Me.txtRNombre.Location = New System.Drawing.Point(87, 183)
        Me.txtRNombre.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtRNombre.Name = "txtRNombre"
        Me.txtRNombre.ReadOnly = True
        Me.txtRNombre.Size = New System.Drawing.Size(260, 22)
        Me.txtRNombre.TabIndex = 20
        '
        'txtRApellido
        '
        Me.txtRApellido.Location = New System.Drawing.Point(88, 220)
        Me.txtRApellido.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtRApellido.Name = "txtRApellido"
        Me.txtRApellido.ReadOnly = True
        Me.txtRApellido.Size = New System.Drawing.Size(259, 22)
        Me.txtRApellido.TabIndex = 21
        '
        'cmdVolver
        '
        Me.cmdVolver.Location = New System.Drawing.Point(376, 315)
        Me.cmdVolver.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdVolver.Name = "cmdVolver"
        Me.cmdVolver.Size = New System.Drawing.Size(100, 28)
        Me.cmdVolver.TabIndex = 22
        Me.cmdVolver.Text = "Volver"
        Me.cmdVolver.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 262)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 17)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Teléfono:"
        '
        'txtRTelefono
        '
        Me.txtRTelefono.Location = New System.Drawing.Point(87, 258)
        Me.txtRTelefono.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtRTelefono.Name = "txtRTelefono"
        Me.txtRTelefono.ReadOnly = True
        Me.txtRTelefono.Size = New System.Drawing.Size(260, 22)
        Me.txtRTelefono.TabIndex = 24
        '
        'cmdModificar
        '
        Me.cmdModificar.Location = New System.Drawing.Point(16, 315)
        Me.cmdModificar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdModificar.Name = "cmdModificar"
        Me.cmdModificar.Size = New System.Drawing.Size(100, 28)
        Me.cmdModificar.TabIndex = 25
        Me.cmdModificar.Text = "Modificar"
        Me.cmdModificar.UseVisualStyleBackColor = True
        '
        'frmUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(492, 358)
        Me.Controls.Add(Me.cmdModificar)
        Me.Controls.Add(Me.txtRTelefono)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdVolver)
        Me.Controls.Add(Me.txtRApellido)
        Me.Controls.Add(Me.txtRNombre)
        Me.Controls.Add(Me.txtRCedula)
        Me.Controls.Add(Me.txtRUsuario)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblCedula)
        Me.Controls.Add(Me.lblUsuario)
        Me.Controls.Add(Me.lblBCedula)
        Me.Controls.Add(Me.lblBUsuario)
        Me.Controls.Add(Me.cmdBuscarCedula)
        Me.Controls.Add(Me.txtBCedula)
        Me.Controls.Add(Me.txtBUsuario)
        Me.Controls.Add(Me.cmdBuscarUsuario)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmUsuario"
        Me.Text = "Buscar Usuario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblBCedula As Label
    Friend WithEvents lblBUsuario As Label
    Friend WithEvents cmdBuscarCedula As Button
    Friend WithEvents txtBCedula As TextBox
    Friend WithEvents txtBUsuario As TextBox
    Friend WithEvents cmdBuscarUsuario As Button
    Friend WithEvents lblUsuario As Label
    Friend WithEvents lblCedula As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtRUsuario As TextBox
    Friend WithEvents txtRCedula As TextBox
    Friend WithEvents txtRNombre As TextBox
    Friend WithEvents txtRApellido As TextBox
    Friend WithEvents cmdVolver As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtRTelefono As TextBox
    Friend WithEvents cmdModificar As Button
End Class
