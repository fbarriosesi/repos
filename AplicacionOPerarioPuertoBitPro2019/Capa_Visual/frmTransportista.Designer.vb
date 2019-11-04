<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTransportista
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
        Me.cmdIniciarViaje = New System.Windows.Forms.Button()
        Me.cmdFinalizarViaje = New System.Windows.Forms.Button()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.dgvLotes = New System.Windows.Forms.DataGridView()
        CType(Me.dgvLotes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdIniciarViaje
        '
        Me.cmdIniciarViaje.Location = New System.Drawing.Point(707, 504)
        Me.cmdIniciarViaje.Name = "cmdIniciarViaje"
        Me.cmdIniciarViaje.Size = New System.Drawing.Size(150, 37)
        Me.cmdIniciarViaje.TabIndex = 2
        Me.cmdIniciarViaje.Text = "Iniciar Viaje"
        Me.cmdIniciarViaje.UseVisualStyleBackColor = True
        '
        'cmdFinalizarViaje
        '
        Me.cmdFinalizarViaje.Location = New System.Drawing.Point(996, 504)
        Me.cmdFinalizarViaje.Name = "cmdFinalizarViaje"
        Me.cmdFinalizarViaje.Size = New System.Drawing.Size(150, 37)
        Me.cmdFinalizarViaje.TabIndex = 3
        Me.cmdFinalizarViaje.Text = "Finalizar Viaje"
        Me.cmdFinalizarViaje.UseVisualStyleBackColor = True
        Me.cmdFinalizarViaje.Visible = False
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(12, 504)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(150, 37)
        Me.cmdSalir.TabIndex = 4
        Me.cmdSalir.Text = "Salir"
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'dgvLotes
        '
        Me.dgvLotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLotes.Location = New System.Drawing.Point(12, 12)
        Me.dgvLotes.Name = "dgvLotes"
        Me.dgvLotes.RowTemplate.Height = 24
        Me.dgvLotes.Size = New System.Drawing.Size(1134, 486)
        Me.dgvLotes.TabIndex = 5
        '
        'frmTransportista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1158, 551)
        Me.Controls.Add(Me.dgvLotes)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.cmdFinalizarViaje)
        Me.Controls.Add(Me.cmdIniciarViaje)
        Me.Name = "frmTransportista"
        Me.Text = "frmTransportista"
        CType(Me.dgvLotes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdIniciarViaje As Button
    Friend WithEvents cmdFinalizarViaje As Button
    Friend WithEvents cmdSalir As Button
    Friend WithEvents dgvLotes As DataGridView
End Class