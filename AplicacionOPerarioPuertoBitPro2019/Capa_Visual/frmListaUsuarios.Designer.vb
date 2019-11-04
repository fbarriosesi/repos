<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmListaUsuarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListaUsuarios))
        Me.cmdBuscarUsuario = New System.Windows.Forms.Button()
        Me.cmdVolver = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.txtCedula = New System.Windows.Forms.TextBox()
        Me.cmdBuscarCedula = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cedula = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdBuscarUsuario
        '
        Me.cmdBuscarUsuario.Location = New System.Drawing.Point(581, 13)
        Me.cmdBuscarUsuario.Name = "cmdBuscarUsuario"
        Me.cmdBuscarUsuario.Size = New System.Drawing.Size(75, 23)
        Me.cmdBuscarUsuario.TabIndex = 0
        Me.cmdBuscarUsuario.Text = "Buscar"
        Me.cmdBuscarUsuario.UseVisualStyleBackColor = True
        '
        'cmdVolver
        '
        Me.cmdVolver.Location = New System.Drawing.Point(581, 443)
        Me.cmdVolver.Name = "cmdVolver"
        Me.cmdVolver.Size = New System.Drawing.Size(75, 23)
        Me.cmdVolver.TabIndex = 1
        Me.cmdVolver.Text = "Volver"
        Me.cmdVolver.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cedula, Me.nombre, Me.apellido, Me.telefono, Me.usuario, Me.rol})
        Me.DataGridView1.Location = New System.Drawing.Point(13, 69)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(643, 368)
        Me.DataGridView1.TabIndex = 2
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(430, 14)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(132, 20)
        Me.txtUsuario.TabIndex = 3
        '
        'txtCedula
        '
        Me.txtCedula.Location = New System.Drawing.Point(430, 41)
        Me.txtCedula.Name = "txtCedula"
        Me.txtCedula.Size = New System.Drawing.Size(132, 20)
        Me.txtCedula.TabIndex = 4
        '
        'cmdBuscarCedula
        '
        Me.cmdBuscarCedula.Location = New System.Drawing.Point(581, 40)
        Me.cmdBuscarCedula.Name = "cmdBuscarCedula"
        Me.cmdBuscarCedula.Size = New System.Drawing.Size(75, 23)
        Me.cmdBuscarCedula.TabIndex = 6
        Me.cmdBuscarCedula.Text = "Buscar"
        Me.cmdBuscarCedula.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(313, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Bucar por Usuario:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(313, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Bucar por Cedula:"
        '
        'cedula
        '
        Me.cedula.HeaderText = "Cédula"
        Me.cedula.Name = "cedula"
        Me.cedula.ReadOnly = True
        '
        'nombre
        '
        Me.nombre.HeaderText = "Nombre del Empleado"
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        '
        'apellido
        '
        Me.apellido.HeaderText = "Apellido del Empleado"
        Me.apellido.Name = "apellido"
        Me.apellido.ReadOnly = True
        '
        'telefono
        '
        Me.telefono.HeaderText = "Teléfono"
        Me.telefono.Name = "telefono"
        Me.telefono.ReadOnly = True
        '
        'usuario
        '
        Me.usuario.HeaderText = "Usuario del Sistema"
        Me.usuario.Name = "usuario"
        Me.usuario.ReadOnly = True
        '
        'rol
        '
        Me.rol.HeaderText = "Rol del Empleado"
        Me.rol.Name = "rol"
        Me.rol.ReadOnly = True
        '
        'frmListaUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(668, 478)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdBuscarCedula)
        Me.Controls.Add(Me.txtCedula)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.cmdVolver)
        Me.Controls.Add(Me.cmdBuscarUsuario)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmListaUsuarios"
        Me.Text = "frmListaUsuarios"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdBuscarUsuario As Button
    Friend WithEvents cmdVolver As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents txtCedula As TextBox
    Friend WithEvents cmdBuscarCedula As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cedula As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents apellido As DataGridViewTextBoxColumn
    Friend WithEvents telefono As DataGridViewTextBoxColumn
    Friend WithEvents usuario As DataGridViewTextBoxColumn
    Friend WithEvents rol As DataGridViewTextBoxColumn
End Class
