<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVehiculos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVehiculos))
        Me.cmdBuscar = New System.Windows.Forms.Button()
        Me.cmdListar = New System.Windows.Forms.Button()
        Me.cmdVolver = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmdBuscar
        '
        Me.cmdBuscar.Location = New System.Drawing.Point(77, 53)
        Me.cmdBuscar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(175, 64)
        Me.cmdBuscar.TabIndex = 0
        Me.cmdBuscar.Text = "Buscar Vehiculo"
        Me.cmdBuscar.UseVisualStyleBackColor = True
        '
        'cmdListar
        '
        Me.cmdListar.Location = New System.Drawing.Point(352, 53)
        Me.cmdListar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdListar.Name = "cmdListar"
        Me.cmdListar.Size = New System.Drawing.Size(175, 64)
        Me.cmdListar.TabIndex = 1
        Me.cmdListar.Text = "Listar Vehiculos"
        Me.cmdListar.UseVisualStyleBackColor = True
        '
        'cmdVolver
        '
        Me.cmdVolver.Location = New System.Drawing.Point(205, 192)
        Me.cmdVolver.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdVolver.Name = "cmdVolver"
        Me.cmdVolver.Size = New System.Drawing.Size(175, 64)
        Me.cmdVolver.TabIndex = 2
        Me.cmdVolver.Text = "Volver"
        Me.cmdVolver.UseVisualStyleBackColor = True
        '
        'frmVehiculos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(617, 316)
        Me.Controls.Add(Me.cmdVolver)
        Me.Controls.Add(Me.cmdListar)
        Me.Controls.Add(Me.cmdBuscar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmVehiculos"
        Me.Text = "frmVehiculos"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmdBuscar As Button
    Friend WithEvents cmdListar As Button
    Friend WithEvents cmdVolver As Button
End Class
