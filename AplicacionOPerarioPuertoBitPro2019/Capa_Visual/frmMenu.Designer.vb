<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenu))
        Me.cmdVehiculos = New System.Windows.Forms.Button()
        Me.cmdUsuarios = New System.Windows.Forms.Button()
        Me.cmdVolver = New System.Windows.Forms.Button()
        Me.cmdCSV = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmdVehiculos
        '
        Me.cmdVehiculos.Location = New System.Drawing.Point(77, 39)
        Me.cmdVehiculos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdVehiculos.Name = "cmdVehiculos"
        Me.cmdVehiculos.Size = New System.Drawing.Size(175, 64)
        Me.cmdVehiculos.TabIndex = 0
        Me.cmdVehiculos.Text = "Vehiculos"
        Me.cmdVehiculos.UseVisualStyleBackColor = True
        '
        'cmdUsuarios
        '
        Me.cmdUsuarios.Location = New System.Drawing.Point(320, 39)
        Me.cmdUsuarios.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdUsuarios.Name = "cmdUsuarios"
        Me.cmdUsuarios.Size = New System.Drawing.Size(175, 64)
        Me.cmdUsuarios.TabIndex = 1
        Me.cmdUsuarios.Text = "Usuarios"
        Me.cmdUsuarios.UseVisualStyleBackColor = True
        '
        'cmdVolver
        '
        Me.cmdVolver.Location = New System.Drawing.Point(77, 169)
        Me.cmdVolver.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdVolver.Name = "cmdVolver"
        Me.cmdVolver.Size = New System.Drawing.Size(175, 64)
        Me.cmdVolver.TabIndex = 2
        Me.cmdVolver.Text = "Volver"
        Me.cmdVolver.UseVisualStyleBackColor = True
        '
        'cmdCSV
        '
        Me.cmdCSV.Location = New System.Drawing.Point(320, 169)
        Me.cmdCSV.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdCSV.Name = "cmdCSV"
        Me.cmdCSV.Size = New System.Drawing.Size(175, 64)
        Me.cmdCSV.TabIndex = 3
        Me.cmdCSV.Text = "Archivos .CSV"
        Me.cmdCSV.UseVisualStyleBackColor = True
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(581, 308)
        Me.Controls.Add(Me.cmdCSV)
        Me.Controls.Add(Me.cmdVolver)
        Me.Controls.Add(Me.cmdUsuarios)
        Me.Controls.Add(Me.cmdVehiculos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmMenu"
        Me.Text = "Menu Administrador"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmdVehiculos As Button
    Friend WithEvents cmdUsuarios As Button
    Friend WithEvents cmdVolver As Button
    Friend WithEvents cmdCSV As Button
End Class
