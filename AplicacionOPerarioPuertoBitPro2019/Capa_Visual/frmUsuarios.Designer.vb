<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsuarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUsuarios))
        Me.cmdBusar = New System.Windows.Forms.Button()
        Me.cmdListar = New System.Windows.Forms.Button()
        Me.cmdVolver = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmdBusar
        '
        Me.cmdBusar.Location = New System.Drawing.Point(67, 55)
        Me.cmdBusar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdBusar.Name = "cmdBusar"
        Me.cmdBusar.Size = New System.Drawing.Size(175, 64)
        Me.cmdBusar.TabIndex = 0
        Me.cmdBusar.Text = "Buscar Usuario"
        Me.cmdBusar.UseVisualStyleBackColor = True
        '
        'cmdListar
        '
        Me.cmdListar.Location = New System.Drawing.Point(300, 55)
        Me.cmdListar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdListar.Name = "cmdListar"
        Me.cmdListar.Size = New System.Drawing.Size(175, 64)
        Me.cmdListar.TabIndex = 1
        Me.cmdListar.Text = "Listar Usuarios"
        Me.cmdListar.UseVisualStyleBackColor = True
        '
        'cmdVolver
        '
        Me.cmdVolver.Location = New System.Drawing.Point(179, 188)
        Me.cmdVolver.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdVolver.Name = "cmdVolver"
        Me.cmdVolver.Size = New System.Drawing.Size(175, 64)
        Me.cmdVolver.TabIndex = 2
        Me.cmdVolver.Text = "Volver"
        Me.cmdVolver.UseVisualStyleBackColor = True
        '
        'frmUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(543, 306)
        Me.Controls.Add(Me.cmdVolver)
        Me.Controls.Add(Me.cmdListar)
        Me.Controls.Add(Me.cmdBusar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmUsuarios"
        Me.Text = "frmUsuarios"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmdBusar As Button
    Friend WithEvents cmdListar As Button
    Friend WithEvents cmdVolver As Button
End Class
