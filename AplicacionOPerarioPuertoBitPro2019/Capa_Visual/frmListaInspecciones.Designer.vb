<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmListaInspecciones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListaInspecciones))
        Me.lblInspecciones = New System.Windows.Forms.Label()
        Me.lblIDVehiulo = New System.Windows.Forms.Label()
        Me.dgvInspecciones = New System.Windows.Forms.DataGridView()
        Me.cmdVolver = New System.Windows.Forms.Button()
        Me.cmdDetalles = New System.Windows.Forms.Button()
        Me.id_inspeccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cedula = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vehiculo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fechahora = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvInspecciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblInspecciones
        '
        Me.lblInspecciones.AutoSize = True
        Me.lblInspecciones.Location = New System.Drawing.Point(13, 13)
        Me.lblInspecciones.Name = "lblInspecciones"
        Me.lblInspecciones.Size = New System.Drawing.Size(134, 13)
        Me.lblInspecciones.TabIndex = 0
        Me.lblInspecciones.Text = "Inspecciones del Vehiculo:"
        '
        'lblIDVehiulo
        '
        Me.lblIDVehiulo.AutoSize = True
        Me.lblIDVehiulo.Location = New System.Drawing.Point(154, 13)
        Me.lblIDVehiulo.Name = "lblIDVehiulo"
        Me.lblIDVehiulo.Size = New System.Drawing.Size(0, 13)
        Me.lblIDVehiulo.TabIndex = 1
        '
        'dgvInspecciones
        '
        Me.dgvInspecciones.AllowUserToAddRows = False
        Me.dgvInspecciones.AllowUserToDeleteRows = False
        Me.dgvInspecciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInspecciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_inspeccion, Me.cedula, Me.vehiculo, Me.fechahora})
        Me.dgvInspecciones.Location = New System.Drawing.Point(12, 29)
        Me.dgvInspecciones.Name = "dgvInspecciones"
        Me.dgvInspecciones.ReadOnly = True
        Me.dgvInspecciones.Size = New System.Drawing.Size(641, 409)
        Me.dgvInspecciones.TabIndex = 2
        '
        'cmdVolver
        '
        Me.cmdVolver.Location = New System.Drawing.Point(457, 444)
        Me.cmdVolver.Name = "cmdVolver"
        Me.cmdVolver.Size = New System.Drawing.Size(75, 23)
        Me.cmdVolver.TabIndex = 3
        Me.cmdVolver.Text = "Volver"
        Me.cmdVolver.UseVisualStyleBackColor = True
        '
        'cmdDetalles
        '
        Me.cmdDetalles.Location = New System.Drawing.Point(578, 444)
        Me.cmdDetalles.Name = "cmdDetalles"
        Me.cmdDetalles.Size = New System.Drawing.Size(75, 23)
        Me.cmdDetalles.TabIndex = 4
        Me.cmdDetalles.Text = "Ver Detalles"
        Me.cmdDetalles.UseVisualStyleBackColor = True
        '
        'id_inspeccion
        '
        Me.id_inspeccion.HeaderText = "ID Inspección"
        Me.id_inspeccion.Name = "id_inspeccion"
        Me.id_inspeccion.ReadOnly = True
        '
        'cedula
        '
        Me.cedula.HeaderText = "Cédula Operario"
        Me.cedula.Name = "cedula"
        Me.cedula.ReadOnly = True
        '
        'vehiculo
        '
        Me.vehiculo.HeaderText = "ID Vehículo"
        Me.vehiculo.Name = "vehiculo"
        Me.vehiculo.ReadOnly = True
        '
        'fechahora
        '
        Me.fechahora.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.fechahora.HeaderText = "Fecha de Inspección"
        Me.fechahora.Name = "fechahora"
        Me.fechahora.ReadOnly = True
        '
        'frmListaInspecciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(665, 470)
        Me.Controls.Add(Me.cmdDetalles)
        Me.Controls.Add(Me.cmdVolver)
        Me.Controls.Add(Me.dgvInspecciones)
        Me.Controls.Add(Me.lblIDVehiulo)
        Me.Controls.Add(Me.lblInspecciones)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmListaInspecciones"
        Me.Text = "Lista de Inspecciones"
        CType(Me.dgvInspecciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblInspecciones As Label
    Friend WithEvents lblIDVehiulo As Label
    Friend WithEvents dgvInspecciones As DataGridView
    Friend WithEvents cmdVolver As Button
    Friend WithEvents cmdDetalles As Button
    Friend WithEvents id_inspeccion As DataGridViewTextBoxColumn
    Friend WithEvents cedula As DataGridViewTextBoxColumn
    Friend WithEvents vehiculo As DataGridViewTextBoxColumn
    Friend WithEvents fechahora As DataGridViewTextBoxColumn
End Class
