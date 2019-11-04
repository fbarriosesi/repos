<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDetalles
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
        Me.dgvLineas = New System.Windows.Forms.DataGridView()
        Me.lblDetalles = New System.Windows.Forms.Label()
        Me.lblIDInspeccion = New System.Windows.Forms.Label()
        Me.cmdVerFoto = New System.Windows.Forms.Button()
        Me.cmdVolver = New System.Windows.Forms.Button()
        Me.id_linea = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvLineas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvLineas
        '
        Me.dgvLineas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLineas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_linea, Me.descripcion})
        Me.dgvLineas.Location = New System.Drawing.Point(12, 35)
        Me.dgvLineas.Name = "dgvLineas"
        Me.dgvLineas.ReadOnly = True
        Me.dgvLineas.Size = New System.Drawing.Size(776, 373)
        Me.dgvLineas.TabIndex = 0
        '
        'lblDetalles
        '
        Me.lblDetalles.AutoSize = True
        Me.lblDetalles.Location = New System.Drawing.Point(12, 13)
        Me.lblDetalles.Name = "lblDetalles"
        Me.lblDetalles.Size = New System.Drawing.Size(98, 13)
        Me.lblDetalles.TabIndex = 1
        Me.lblDetalles.Text = "Detalle Inspección:"
        '
        'lblIDInspeccion
        '
        Me.lblIDInspeccion.AutoSize = True
        Me.lblIDInspeccion.Location = New System.Drawing.Point(116, 13)
        Me.lblIDInspeccion.Name = "lblIDInspeccion"
        Me.lblIDInspeccion.Size = New System.Drawing.Size(0, 13)
        Me.lblIDInspeccion.TabIndex = 2
        '
        'cmdVerFoto
        '
        Me.cmdVerFoto.Location = New System.Drawing.Point(713, 415)
        Me.cmdVerFoto.Name = "cmdVerFoto"
        Me.cmdVerFoto.Size = New System.Drawing.Size(75, 23)
        Me.cmdVerFoto.TabIndex = 3
        Me.cmdVerFoto.Text = "Ver Foto"
        Me.cmdVerFoto.UseVisualStyleBackColor = True
        '
        'cmdVolver
        '
        Me.cmdVolver.Location = New System.Drawing.Point(616, 415)
        Me.cmdVolver.Name = "cmdVolver"
        Me.cmdVolver.Size = New System.Drawing.Size(75, 23)
        Me.cmdVolver.TabIndex = 4
        Me.cmdVolver.Text = "Volver"
        Me.cmdVolver.UseVisualStyleBackColor = True
        '
        'id_linea
        '
        Me.id_linea.Frozen = True
        Me.id_linea.HeaderText = "ID de Línea"
        Me.id_linea.Name = "id_linea"
        Me.id_linea.ReadOnly = True
        '
        'descripcion
        '
        Me.descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.descripcion.HeaderText = "Descripción del Daño"
        Me.descripcion.Name = "descripcion"
        Me.descripcion.ReadOnly = True
        Me.descripcion.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'frmDetalles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.cmdVolver)
        Me.Controls.Add(Me.cmdVerFoto)
        Me.Controls.Add(Me.lblIDInspeccion)
        Me.Controls.Add(Me.lblDetalles)
        Me.Controls.Add(Me.dgvLineas)
        Me.Name = "frmDetalles"
        Me.Text = "Detalles de Inspección"
        CType(Me.dgvLineas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvLineas As DataGridView
    Friend WithEvents lblDetalles As Label
    Friend WithEvents lblIDInspeccion As Label
    Friend WithEvents cmdVerFoto As Button
    Friend WithEvents cmdVolver As Button
    Friend WithEvents id_linea As DataGridViewTextBoxColumn
    Friend WithEvents descripcion As DataGridViewTextBoxColumn
End Class