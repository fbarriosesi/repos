<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmInspeccion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInspeccion))
        Me.gbDanio = New System.Windows.Forms.GroupBox()
        Me.cmdFotografia = New System.Windows.Forms.Button()
        Me.optNeumaticos = New System.Windows.Forms.RadioButton()
        Me.optVidrios = New System.Windows.Forms.RadioButton()
        Me.optChapa = New System.Windows.Forms.RadioButton()
        Me.cboDanios = New System.Windows.Forms.ComboBox()
        Me.cmdEliminar = New System.Windows.Forms.Button()
        Me.lblDanio = New System.Windows.Forms.Label()
        Me.cboOtros = New System.Windows.Forms.ComboBox()
        Me.pbFotoDanio = New System.Windows.Forms.PictureBox()
        Me.lblId_Vin_vehiculo = New System.Windows.Forms.Label()
        Me.cmdCerrar = New System.Windows.Forms.Button()
        Me.lblVinMostrar = New System.Windows.Forms.Label()
        Me.lblIdVehiculo = New System.Windows.Forms.Label()
        Me.lblId_vehiculoMostrar = New System.Windows.Forms.Label()
        Me.cmdGuardarInspeccion = New System.Windows.Forms.Button()
        Me.cmdGuardarLinea = New System.Windows.Forms.Button()
        Me.gbDanio.SuspendLayout()
        CType(Me.pbFotoDanio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbDanio
        '
        Me.gbDanio.Controls.Add(Me.cmdFotografia)
        Me.gbDanio.Controls.Add(Me.optNeumaticos)
        Me.gbDanio.Controls.Add(Me.optVidrios)
        Me.gbDanio.Controls.Add(Me.optChapa)
        Me.gbDanio.Controls.Add(Me.cboDanios)
        Me.gbDanio.Controls.Add(Me.cmdEliminar)
        Me.gbDanio.Controls.Add(Me.lblDanio)
        Me.gbDanio.Controls.Add(Me.cboOtros)
        Me.gbDanio.Controls.Add(Me.pbFotoDanio)
        Me.gbDanio.Location = New System.Drawing.Point(19, 41)
        Me.gbDanio.Margin = New System.Windows.Forms.Padding(2)
        Me.gbDanio.Name = "gbDanio"
        Me.gbDanio.Padding = New System.Windows.Forms.Padding(2)
        Me.gbDanio.Size = New System.Drawing.Size(645, 158)
        Me.gbDanio.TabIndex = 0
        Me.gbDanio.TabStop = False
        Me.gbDanio.Text = "Ingreso de Daño"
        '
        'cmdFotografia
        '
        Me.cmdFotografia.Location = New System.Drawing.Point(230, 122)
        Me.cmdFotografia.Name = "cmdFotografia"
        Me.cmdFotografia.Size = New System.Drawing.Size(97, 23)
        Me.cmdFotografia.TabIndex = 12
        Me.cmdFotografia.Text = "Tomar Fotografía"
        Me.cmdFotografia.UseVisualStyleBackColor = True
        '
        'optNeumaticos
        '
        Me.optNeumaticos.AutoSize = True
        Me.optNeumaticos.Location = New System.Drawing.Point(450, 19)
        Me.optNeumaticos.Margin = New System.Windows.Forms.Padding(2)
        Me.optNeumaticos.Name = "optNeumaticos"
        Me.optNeumaticos.Size = New System.Drawing.Size(81, 17)
        Me.optNeumaticos.TabIndex = 11
        Me.optNeumaticos.Text = "Neumaticos"
        Me.optNeumaticos.UseVisualStyleBackColor = True
        '
        'optVidrios
        '
        Me.optVidrios.AutoSize = True
        Me.optVidrios.Location = New System.Drawing.Point(378, 19)
        Me.optVidrios.Margin = New System.Windows.Forms.Padding(2)
        Me.optVidrios.Name = "optVidrios"
        Me.optVidrios.Size = New System.Drawing.Size(56, 17)
        Me.optVidrios.TabIndex = 10
        Me.optVidrios.Text = "Vidrios"
        Me.optVidrios.UseVisualStyleBackColor = True
        '
        'optChapa
        '
        Me.optChapa.AutoSize = True
        Me.optChapa.Location = New System.Drawing.Point(255, 19)
        Me.optChapa.Margin = New System.Windows.Forms.Padding(2)
        Me.optChapa.Name = "optChapa"
        Me.optChapa.Size = New System.Drawing.Size(98, 17)
        Me.optChapa.TabIndex = 9
        Me.optChapa.Text = "Chapa - Pintura"
        Me.optChapa.UseVisualStyleBackColor = True
        '
        'cboDanios
        '
        Me.cboDanios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDanios.FormattingEnabled = True
        Me.cboDanios.Location = New System.Drawing.Point(263, 63)
        Me.cboDanios.Margin = New System.Windows.Forms.Padding(2)
        Me.cboDanios.Name = "cboDanios"
        Me.cboDanios.Size = New System.Drawing.Size(344, 21)
        Me.cboDanios.TabIndex = 8
        '
        'cmdEliminar
        '
        Me.cmdEliminar.Location = New System.Drawing.Point(576, 123)
        Me.cmdEliminar.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdEliminar.Name = "cmdEliminar"
        Me.cmdEliminar.Size = New System.Drawing.Size(56, 23)
        Me.cmdEliminar.TabIndex = 7
        Me.cmdEliminar.Text = "Eliminar"
        Me.cmdEliminar.UseVisualStyleBackColor = True
        '
        'lblDanio
        '
        Me.lblDanio.AutoSize = True
        Me.lblDanio.Location = New System.Drawing.Point(227, 66)
        Me.lblDanio.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDanio.Name = "lblDanio"
        Me.lblDanio.Size = New System.Drawing.Size(33, 13)
        Me.lblDanio.TabIndex = 6
        Me.lblDanio.Text = "Daño"
        '
        'cboOtros
        '
        Me.cboOtros.FormattingEnabled = True
        Me.cboOtros.Location = New System.Drawing.Point(263, 63)
        Me.cboOtros.Margin = New System.Windows.Forms.Padding(2)
        Me.cboOtros.Name = "cboOtros"
        Me.cboOtros.Size = New System.Drawing.Size(344, 21)
        Me.cboOtros.TabIndex = 5
        '
        'pbFotoDanio
        '
        Me.pbFotoDanio.Location = New System.Drawing.Point(4, 17)
        Me.pbFotoDanio.Margin = New System.Windows.Forms.Padding(2)
        Me.pbFotoDanio.Name = "pbFotoDanio"
        Me.pbFotoDanio.Size = New System.Drawing.Size(217, 133)
        Me.pbFotoDanio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbFotoDanio.TabIndex = 4
        Me.pbFotoDanio.TabStop = False
        '
        'lblId_Vin_vehiculo
        '
        Me.lblId_Vin_vehiculo.AutoSize = True
        Me.lblId_Vin_vehiculo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblId_Vin_vehiculo.Location = New System.Drawing.Point(279, 14)
        Me.lblId_Vin_vehiculo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblId_Vin_vehiculo.Name = "lblId_Vin_vehiculo"
        Me.lblId_Vin_vehiculo.Size = New System.Drawing.Size(36, 13)
        Me.lblId_Vin_vehiculo.TabIndex = 2
        Me.lblId_Vin_vehiculo.Text = "VIN :"
        '
        'cmdCerrar
        '
        Me.cmdCerrar.Location = New System.Drawing.Point(320, 236)
        Me.cmdCerrar.Margin = New System.Windows.Forms.Padding(2)
        Me.cmdCerrar.Name = "cmdCerrar"
        Me.cmdCerrar.Size = New System.Drawing.Size(64, 24)
        Me.cmdCerrar.TabIndex = 5
        Me.cmdCerrar.Text = "Cerrar"
        Me.cmdCerrar.UseVisualStyleBackColor = True
        '
        'lblVinMostrar
        '
        Me.lblVinMostrar.AutoSize = True
        Me.lblVinMostrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVinMostrar.Location = New System.Drawing.Point(394, 14)
        Me.lblVinMostrar.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblVinMostrar.Name = "lblVinMostrar"
        Me.lblVinMostrar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblVinMostrar.Size = New System.Drawing.Size(28, 13)
        Me.lblVinMostrar.TabIndex = 7
        Me.lblVinMostrar.Text = "VIN"
        '
        'lblIdVehiculo
        '
        Me.lblIdVehiculo.AutoSize = True
        Me.lblIdVehiculo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdVehiculo.Location = New System.Drawing.Point(16, 14)
        Me.lblIdVehiculo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblIdVehiculo.Name = "lblIdVehiculo"
        Me.lblIdVehiculo.Size = New System.Drawing.Size(94, 13)
        Me.lblIdVehiculo.TabIndex = 8
        Me.lblIdVehiculo.Text = "ID VEHICULO :"
        '
        'lblId_vehiculoMostrar
        '
        Me.lblId_vehiculoMostrar.AutoSize = True
        Me.lblId_vehiculoMostrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblId_vehiculoMostrar.Location = New System.Drawing.Point(99, 14)
        Me.lblId_vehiculoMostrar.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblId_vehiculoMostrar.Name = "lblId_vehiculoMostrar"
        Me.lblId_vehiculoMostrar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblId_vehiculoMostrar.Size = New System.Drawing.Size(73, 13)
        Me.lblId_vehiculoMostrar.TabIndex = 9
        Me.lblId_vehiculoMostrar.Text = "Id_vehiculo"
        '
        'cmdGuardarInspeccion
        '
        Me.cmdGuardarInspeccion.Location = New System.Drawing.Point(422, 236)
        Me.cmdGuardarInspeccion.Name = "cmdGuardarInspeccion"
        Me.cmdGuardarInspeccion.Size = New System.Drawing.Size(115, 23)
        Me.cmdGuardarInspeccion.TabIndex = 10
        Me.cmdGuardarInspeccion.Text = "Guardar Inspección"
        Me.cmdGuardarInspeccion.UseVisualStyleBackColor = True
        '
        'cmdGuardarLinea
        '
        Me.cmdGuardarLinea.Location = New System.Drawing.Point(568, 236)
        Me.cmdGuardarLinea.Name = "cmdGuardarLinea"
        Me.cmdGuardarLinea.Size = New System.Drawing.Size(96, 23)
        Me.cmdGuardarLinea.TabIndex = 11
        Me.cmdGuardarLinea.Text = "Guardar Linea"
        Me.cmdGuardarLinea.UseVisualStyleBackColor = True
        '
        'frmInspeccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(678, 288)
        Me.Controls.Add(Me.cmdGuardarLinea)
        Me.Controls.Add(Me.cmdGuardarInspeccion)
        Me.Controls.Add(Me.lblId_vehiculoMostrar)
        Me.Controls.Add(Me.lblIdVehiculo)
        Me.Controls.Add(Me.lblVinMostrar)
        Me.Controls.Add(Me.cmdCerrar)
        Me.Controls.Add(Me.lblId_Vin_vehiculo)
        Me.Controls.Add(Me.gbDanio)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmInspeccion"
        Me.Text = "frmInspeccion"
        Me.gbDanio.ResumeLayout(False)
        Me.gbDanio.PerformLayout()
        CType(Me.pbFotoDanio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gbDanio As GroupBox
    Friend WithEvents cmdEliminar As Button
    Friend WithEvents lblDanio As Label
    Friend WithEvents cboOtros As ComboBox
    Friend WithEvents pbFotoDanio As PictureBox
    Friend WithEvents lblId_Vin_vehiculo As Label
    Friend WithEvents cboDanios As ComboBox
    Friend WithEvents cmdCerrar As Button
    Friend WithEvents optNeumaticos As RadioButton
    Friend WithEvents optVidrios As RadioButton
    Friend WithEvents optChapa As RadioButton
    Friend WithEvents lblVinMostrar As Label
    Friend WithEvents lblIdVehiculo As Label
    Friend WithEvents lblId_vehiculoMostrar As Label
    Friend WithEvents cmdGuardarInspeccion As Button
    Friend WithEvents cmdGuardarLinea As Button
    Friend WithEvents cmdFotografia As Button
End Class
