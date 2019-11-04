<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmZonasSubZonas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmZonasSubZonas))
        Me.lblVin = New System.Windows.Forms.Label()
        Me.lblId_Vehiculo = New System.Windows.Forms.Label()
        Me.cboZona = New System.Windows.Forms.ComboBox()
        Me.cboSubzona = New System.Windows.Forms.ComboBox()
        Me.lblZona = New System.Windows.Forms.Label()
        Me.lblSuzbona = New System.Windows.Forms.Label()
        Me.cmdAsignar = New System.Windows.Forms.Button()
        Me.cmdVolver = New System.Windows.Forms.Button()
        Me.lblFechahora = New System.Windows.Forms.Label()
        Me.lbl_Vin = New System.Windows.Forms.Label()
        Me.lbl_Id_vehiculo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblVin
        '
        Me.lblVin.AutoSize = True
        Me.lblVin.Location = New System.Drawing.Point(64, 42)
        Me.lblVin.Name = "lblVin"
        Me.lblVin.Size = New System.Drawing.Size(28, 17)
        Me.lblVin.TabIndex = 2
        Me.lblVin.Text = "Vin"
        '
        'lblId_Vehiculo
        '
        Me.lblId_Vehiculo.AutoSize = True
        Me.lblId_Vehiculo.Location = New System.Drawing.Point(396, 42)
        Me.lblId_Vehiculo.Name = "lblId_Vehiculo"
        Me.lblId_Vehiculo.Size = New System.Drawing.Size(77, 17)
        Me.lblId_Vehiculo.TabIndex = 3
        Me.lblId_Vehiculo.Text = "Id Vehiculo"
        '
        'cboZona
        '
        Me.cboZona.FormattingEnabled = True
        Me.cboZona.Location = New System.Drawing.Point(16, 144)
        Me.cboZona.Name = "cboZona"
        Me.cboZona.Size = New System.Drawing.Size(232, 24)
        Me.cboZona.TabIndex = 4
        '
        'cboSubzona
        '
        Me.cboSubzona.FormattingEnabled = True
        Me.cboSubzona.Location = New System.Drawing.Point(278, 144)
        Me.cboSubzona.Name = "cboSubzona"
        Me.cboSubzona.Size = New System.Drawing.Size(232, 24)
        Me.cboSubzona.TabIndex = 5
        '
        'lblZona
        '
        Me.lblZona.AutoSize = True
        Me.lblZona.Location = New System.Drawing.Point(13, 119)
        Me.lblZona.Name = "lblZona"
        Me.lblZona.Size = New System.Drawing.Size(119, 17)
        Me.lblZona.TabIndex = 6
        Me.lblZona.Text = "Seleccionar Zona"
        '
        'lblSuzbona
        '
        Me.lblSuzbona.AutoSize = True
        Me.lblSuzbona.Location = New System.Drawing.Point(275, 119)
        Me.lblSuzbona.Name = "lblSuzbona"
        Me.lblSuzbona.Size = New System.Drawing.Size(148, 17)
        Me.lblSuzbona.TabIndex = 7
        Me.lblSuzbona.Text = "Seleccionar Sub Zona"
        '
        'cmdAsignar
        '
        Me.cmdAsignar.Location = New System.Drawing.Point(394, 281)
        Me.cmdAsignar.Name = "cmdAsignar"
        Me.cmdAsignar.Size = New System.Drawing.Size(116, 54)
        Me.cmdAsignar.TabIndex = 8
        Me.cmdAsignar.Text = "Asignar Vehiculo"
        Me.cmdAsignar.UseVisualStyleBackColor = True
        '
        'cmdVolver
        '
        Me.cmdVolver.Location = New System.Drawing.Point(16, 281)
        Me.cmdVolver.Name = "cmdVolver"
        Me.cmdVolver.Size = New System.Drawing.Size(116, 54)
        Me.cmdVolver.TabIndex = 9
        Me.cmdVolver.Text = "Volver"
        Me.cmdVolver.UseVisualStyleBackColor = True
        '
        'lblFechahora
        '
        Me.lblFechahora.AutoSize = True
        Me.lblFechahora.Location = New System.Drawing.Point(221, 15)
        Me.lblFechahora.Name = "lblFechahora"
        Me.lblFechahora.Size = New System.Drawing.Size(78, 17)
        Me.lblFechahora.TabIndex = 10
        Me.lblFechahora.Text = "FechaHora"
        '
        'lbl_Vin
        '
        Me.lbl_Vin.AutoSize = True
        Me.lbl_Vin.Location = New System.Drawing.Point(61, 9)
        Me.lbl_Vin.Name = "lbl_Vin"
        Me.lbl_Vin.Size = New System.Drawing.Size(28, 17)
        Me.lbl_Vin.TabIndex = 11
        Me.lbl_Vin.Text = "Vin"
        '
        'lbl_Id_vehiculo
        '
        Me.lbl_Id_vehiculo.AutoSize = True
        Me.lbl_Id_vehiculo.Location = New System.Drawing.Point(420, 15)
        Me.lbl_Id_vehiculo.Name = "lbl_Id_vehiculo"
        Me.lbl_Id_vehiculo.Size = New System.Drawing.Size(77, 17)
        Me.lbl_Id_vehiculo.TabIndex = 12
        Me.lbl_Id_vehiculo.Text = "Id Vehiculo"
        '
        'frmZonasSubZonas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(522, 347)
        Me.Controls.Add(Me.lbl_Id_vehiculo)
        Me.Controls.Add(Me.lbl_Vin)
        Me.Controls.Add(Me.lblFechahora)
        Me.Controls.Add(Me.cmdVolver)
        Me.Controls.Add(Me.cmdAsignar)
        Me.Controls.Add(Me.lblSuzbona)
        Me.Controls.Add(Me.lblZona)
        Me.Controls.Add(Me.cboSubzona)
        Me.Controls.Add(Me.cboZona)
        Me.Controls.Add(Me.lblId_Vehiculo)
        Me.Controls.Add(Me.lblVin)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmZonasSubZonas"
        Me.Text = "frmZonasSubZonas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblVin As Label
    Friend WithEvents lblId_Vehiculo As Label
    Friend WithEvents cboZona As ComboBox
    Friend WithEvents cboSubzona As ComboBox
    Friend WithEvents lblZona As Label
    Friend WithEvents lblSuzbona As Label
    Friend WithEvents cmdAsignar As Button
    Friend WithEvents cmdVolver As Button
    Friend WithEvents lblFechahora As Label
    Friend WithEvents lbl_Vin As Label
    Friend WithEvents lbl_Id_vehiculo As Label
End Class
