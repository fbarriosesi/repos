<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.lblbienvenido = New System.Windows.Forms.Label()
        Me.lblconectarse = New System.Windows.Forms.Label()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.lblClave = New System.Windows.Forms.Label()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.txtClave = New System.Windows.Forms.TextBox()
        Me.cmdAceptar = New System.Windows.Forms.Button()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.lblFechaHora = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblbienvenido
        '
        Me.lblbienvenido.AutoSize = True
        Me.lblbienvenido.Font = New System.Drawing.Font("Sitka Small", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbienvenido.Location = New System.Drawing.Point(164, 30)
        Me.lblbienvenido.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblbienvenido.Name = "lblbienvenido"
        Me.lblbienvenido.Size = New System.Drawing.Size(278, 33)
        Me.lblbienvenido.TabIndex = 0
        Me.lblbienvenido.Text = "Bienvenido al Sistema"
        '
        'lblconectarse
        '
        Me.lblconectarse.AutoSize = True
        Me.lblconectarse.Location = New System.Drawing.Point(238, 89)
        Me.lblconectarse.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblconectarse.Name = "lblconectarse"
        Me.lblconectarse.Size = New System.Drawing.Size(80, 13)
        Me.lblconectarse.TabIndex = 1
        Me.lblconectarse.Text = "CONECTARSE"
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Location = New System.Drawing.Point(127, 131)
        Me.lblUsuario.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(43, 13)
        Me.lblUsuario.TabIndex = 2
        Me.lblUsuario.Text = "Usuario"
        '
        'lblClave
        '
        Me.lblClave.AutoSize = True
        Me.lblClave.Location = New System.Drawing.Point(137, 180)
        Me.lblClave.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblClave.Name = "lblClave"
        Me.lblClave.Size = New System.Drawing.Size(34, 13)
        Me.lblClave.TabIndex = 3
        Me.lblClave.Text = "Clave"
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(174, 128)
        Me.txtUsuario.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(240, 20)
        Me.txtUsuario.TabIndex = 4
        '
        'txtClave
        '
        Me.txtClave.Location = New System.Drawing.Point(174, 178)
        Me.txtClave.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtClave.Name = "txtClave"
        Me.txtClave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtClave.Size = New System.Drawing.Size(240, 20)
        Me.txtClave.TabIndex = 5
        '
        'cmdAceptar
        '
        Me.cmdAceptar.Location = New System.Drawing.Point(357, 266)
        Me.cmdAceptar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmdAceptar.Name = "cmdAceptar"
        Me.cmdAceptar.Size = New System.Drawing.Size(56, 28)
        Me.cmdAceptar.TabIndex = 6
        Me.cmdAceptar.Text = "Aceptar"
        Me.cmdAceptar.UseVisualStyleBackColor = True
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(174, 266)
        Me.cmdSalir.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(65, 28)
        Me.cmdSalir.TabIndex = 7
        Me.cmdSalir.Text = "Salir"
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'lblFechaHora
        '
        Me.lblFechaHora.AutoSize = True
        Me.lblFechaHora.Cursor = System.Windows.Forms.Cursors.No
        Me.lblFechaHora.Location = New System.Drawing.Point(475, 7)
        Me.lblFechaHora.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFechaHora.Name = "lblFechaHora"
        Me.lblFechaHora.Size = New System.Drawing.Size(39, 13)
        Me.lblFechaHora.TabIndex = 8
        Me.lblFechaHora.Text = "Label1"
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 366)
        Me.Controls.Add(Me.lblFechaHora)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.cmdAceptar)
        Me.Controls.Add(Me.txtClave)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.lblClave)
        Me.Controls.Add(Me.lblUsuario)
        Me.Controls.Add(Me.lblconectarse)
        Me.Controls.Add(Me.lblbienvenido)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmLogin"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblbienvenido As Label
    Friend WithEvents lblconectarse As Label
    Friend WithEvents lblUsuario As Label
    Friend WithEvents lblClave As Label
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents txtClave As TextBox
    Friend WithEvents cmdAceptar As Button
    Friend WithEvents cmdSalir As Button
    Friend WithEvents lblFechaHora As Label
End Class
