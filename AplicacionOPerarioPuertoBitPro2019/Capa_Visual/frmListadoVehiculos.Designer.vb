<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmListadoVehiculos
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
        Me.dgvListado = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmdInspecciones = New System.Windows.Forms.Button()
        Me.cmdBuscarVIN = New System.Windows.Forms.Button()
        Me.cmdBuscarID = New System.Windows.Forms.Button()
        Me.txtBuscarID = New System.Windows.Forms.TextBox()
        Me.txtBuscarVIN = New System.Windows.Forms.TextBox()
        Me.lblBuscarVIN = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdLocalizar = New System.Windows.Forms.Button()
        Me.cmdVolver = New System.Windows.Forms.Button()
        CType(Me.dgvListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvListado
        '
        Me.dgvListado.AllowUserToAddRows = False
        Me.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.dgvListado.Location = New System.Drawing.Point(12, 70)
        Me.dgvListado.Name = "dgvListado"
        Me.dgvListado.Size = New System.Drawing.Size(643, 395)
        Me.dgvListado.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID Vehiculo"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "VIN"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Marca"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Modelo"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "Año"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "Color"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'cmdInspecciones
        '
        Me.cmdInspecciones.Location = New System.Drawing.Point(530, 471)
        Me.cmdInspecciones.Name = "cmdInspecciones"
        Me.cmdInspecciones.Size = New System.Drawing.Size(125, 23)
        Me.cmdInspecciones.TabIndex = 1
        Me.cmdInspecciones.Text = "Ver Inspecciones"
        Me.cmdInspecciones.UseVisualStyleBackColor = True
        '
        'cmdBuscarVIN
        '
        Me.cmdBuscarVIN.Location = New System.Drawing.Point(580, 12)
        Me.cmdBuscarVIN.Name = "cmdBuscarVIN"
        Me.cmdBuscarVIN.Size = New System.Drawing.Size(75, 23)
        Me.cmdBuscarVIN.TabIndex = 2
        Me.cmdBuscarVIN.Text = "Buscar"
        Me.cmdBuscarVIN.UseVisualStyleBackColor = True
        '
        'cmdBuscarID
        '
        Me.cmdBuscarID.Location = New System.Drawing.Point(580, 41)
        Me.cmdBuscarID.Name = "cmdBuscarID"
        Me.cmdBuscarID.Size = New System.Drawing.Size(75, 23)
        Me.cmdBuscarID.TabIndex = 3
        Me.cmdBuscarID.Text = "Buscar"
        Me.cmdBuscarID.UseVisualStyleBackColor = True
        '
        'txtBuscarID
        '
        Me.txtBuscarID.Location = New System.Drawing.Point(422, 43)
        Me.txtBuscarID.Name = "txtBuscarID"
        Me.txtBuscarID.Size = New System.Drawing.Size(152, 20)
        Me.txtBuscarID.TabIndex = 4
        '
        'txtBuscarVIN
        '
        Me.txtBuscarVIN.Location = New System.Drawing.Point(422, 14)
        Me.txtBuscarVIN.Name = "txtBuscarVIN"
        Me.txtBuscarVIN.Size = New System.Drawing.Size(152, 20)
        Me.txtBuscarVIN.TabIndex = 5
        '
        'lblBuscarVIN
        '
        Me.lblBuscarVIN.AutoSize = True
        Me.lblBuscarVIN.Location = New System.Drawing.Point(334, 17)
        Me.lblBuscarVIN.Name = "lblBuscarVIN"
        Me.lblBuscarVIN.Size = New System.Drawing.Size(82, 13)
        Me.lblBuscarVIN.TabIndex = 6
        Me.lblBuscarVIN.Text = "Buscar por VIN:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(341, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Buscar por ID:"
        '
        'cmdLocalizar
        '
        Me.cmdLocalizar.Location = New System.Drawing.Point(409, 471)
        Me.cmdLocalizar.Name = "cmdLocalizar"
        Me.cmdLocalizar.Size = New System.Drawing.Size(75, 23)
        Me.cmdLocalizar.TabIndex = 8
        Me.cmdLocalizar.Text = "Localizar"
        Me.cmdLocalizar.UseVisualStyleBackColor = True
        '
        'cmdVolver
        '
        Me.cmdVolver.Location = New System.Drawing.Point(288, 471)
        Me.cmdVolver.Name = "cmdVolver"
        Me.cmdVolver.Size = New System.Drawing.Size(75, 23)
        Me.cmdVolver.TabIndex = 9
        Me.cmdVolver.Text = "Volver"
        Me.cmdVolver.UseVisualStyleBackColor = True
        '
        'frmListadoVehiculos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(665, 506)
        Me.Controls.Add(Me.cmdVolver)
        Me.Controls.Add(Me.cmdLocalizar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblBuscarVIN)
        Me.Controls.Add(Me.txtBuscarVIN)
        Me.Controls.Add(Me.txtBuscarID)
        Me.Controls.Add(Me.cmdBuscarID)
        Me.Controls.Add(Me.cmdBuscarVIN)
        Me.Controls.Add(Me.cmdInspecciones)
        Me.Controls.Add(Me.dgvListado)
        Me.Name = "frmListadoVehiculos"
        Me.Text = "Listado de Vehículos"
        CType(Me.dgvListado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvListado As DataGridView
    Friend WithEvents cmdInspecciones As Button
    Friend WithEvents cmdBuscarVIN As Button
    Friend WithEvents cmdBuscarID As Button
    Friend WithEvents txtBuscarID As TextBox
    Friend WithEvents txtBuscarVIN As TextBox
    Friend WithEvents lblBuscarVIN As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmdLocalizar As Button
    Friend WithEvents cmdVolver As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
End Class
