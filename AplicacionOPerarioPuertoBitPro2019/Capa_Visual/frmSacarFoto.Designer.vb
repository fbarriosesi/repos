<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSacarFoto
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
        Me.cmdCapturar = New System.Windows.Forms.Button()
        Me.pbVistaPrevia = New System.Windows.Forms.PictureBox()
        Me.cmdIniciar = New System.Windows.Forms.Button()
        Me.cmdGuardar = New System.Windows.Forms.Button()
        Me.lblCámara = New System.Windows.Forms.Label()
        Me.lblVistaPrevia = New System.Windows.Forms.Label()
        Me.vspCamara = New AForge.Controls.VideoSourcePlayer()
        Me.gbSacarFoto = New System.Windows.Forms.GroupBox()
        Me.lblInspeccion = New System.Windows.Forms.Label()
        Me.lblIDInspeccion = New System.Windows.Forms.Label()
        Me.lblLiena = New System.Windows.Forms.Label()
        Me.lblIDLinea = New System.Windows.Forms.Label()
        CType(Me.pbVistaPrevia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbSacarFoto.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdCapturar
        '
        Me.cmdCapturar.Location = New System.Drawing.Point(335, 410)
        Me.cmdCapturar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdCapturar.Name = "cmdCapturar"
        Me.cmdCapturar.Size = New System.Drawing.Size(193, 28)
        Me.cmdCapturar.TabIndex = 0
        Me.cmdCapturar.Text = "Capturar"
        Me.cmdCapturar.UseVisualStyleBackColor = True
        '
        'pbVistaPrevia
        '
        Me.pbVistaPrevia.Location = New System.Drawing.Point(536, 41)
        Me.pbVistaPrevia.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pbVistaPrevia.Name = "pbVistaPrevia"
        Me.pbVistaPrevia.Size = New System.Drawing.Size(517, 363)
        Me.pbVistaPrevia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbVistaPrevia.TabIndex = 2
        Me.pbVistaPrevia.TabStop = False
        '
        'cmdIniciar
        '
        Me.cmdIniciar.Location = New System.Drawing.Point(5, 410)
        Me.cmdIniciar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdIniciar.Name = "cmdIniciar"
        Me.cmdIniciar.Size = New System.Drawing.Size(193, 28)
        Me.cmdIniciar.TabIndex = 3
        Me.cmdIniciar.Text = "Iniciar Cámara"
        Me.cmdIniciar.UseVisualStyleBackColor = True
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Location = New System.Drawing.Point(699, 410)
        Me.cmdGuardar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(193, 28)
        Me.cmdGuardar.TabIndex = 4
        Me.cmdGuardar.Text = "Guardar Fotografía"
        Me.cmdGuardar.UseVisualStyleBackColor = True
        '
        'lblCámara
        '
        Me.lblCámara.AutoSize = True
        Me.lblCámara.Location = New System.Drawing.Point(8, 20)
        Me.lblCámara.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCámara.Name = "lblCámara"
        Me.lblCámara.Size = New System.Drawing.Size(57, 17)
        Me.lblCámara.TabIndex = 5
        Me.lblCámara.Text = "Cámara"
        '
        'lblVistaPrevia
        '
        Me.lblVistaPrevia.AutoSize = True
        Me.lblVistaPrevia.Location = New System.Drawing.Point(532, 20)
        Me.lblVistaPrevia.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblVistaPrevia.Name = "lblVistaPrevia"
        Me.lblVistaPrevia.Size = New System.Drawing.Size(83, 17)
        Me.lblVistaPrevia.TabIndex = 6
        Me.lblVistaPrevia.Text = "Vista Previa"
        '
        'vspCamara
        '
        Me.vspCamara.Location = New System.Drawing.Point(11, 41)
        Me.vspCamara.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.vspCamara.Name = "vspCamara"
        Me.vspCamara.Size = New System.Drawing.Size(517, 363)
        Me.vspCamara.TabIndex = 7
        Me.vspCamara.Text = "VideoSourcePlayer1"
        Me.vspCamara.VideoSource = Nothing
        '
        'gbSacarFoto
        '
        Me.gbSacarFoto.Controls.Add(Me.lblCámara)
        Me.gbSacarFoto.Controls.Add(Me.vspCamara)
        Me.gbSacarFoto.Controls.Add(Me.cmdCapturar)
        Me.gbSacarFoto.Controls.Add(Me.lblVistaPrevia)
        Me.gbSacarFoto.Controls.Add(Me.pbVistaPrevia)
        Me.gbSacarFoto.Controls.Add(Me.cmdIniciar)
        Me.gbSacarFoto.Controls.Add(Me.cmdGuardar)
        Me.gbSacarFoto.Location = New System.Drawing.Point(16, 60)
        Me.gbSacarFoto.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbSacarFoto.Name = "gbSacarFoto"
        Me.gbSacarFoto.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbSacarFoto.Size = New System.Drawing.Size(1060, 452)
        Me.gbSacarFoto.TabIndex = 8
        Me.gbSacarFoto.TabStop = False
        Me.gbSacarFoto.Text = "Sacar Fotografía"
        '
        'lblInspeccion
        '
        Me.lblInspeccion.AutoSize = True
        Me.lblInspeccion.Location = New System.Drawing.Point(27, 16)
        Me.lblInspeccion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblInspeccion.Name = "lblInspeccion"
        Me.lblInspeccion.Size = New System.Drawing.Size(96, 17)
        Me.lblInspeccion.TabIndex = 9
        Me.lblInspeccion.Text = "ID Inspección:"
        '
        'lblIDInspeccion
        '
        Me.lblIDInspeccion.AutoSize = True
        Me.lblIDInspeccion.Location = New System.Drawing.Point(136, 16)
        Me.lblIDInspeccion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblIDInspeccion.Name = "lblIDInspeccion"
        Me.lblIDInspeccion.Size = New System.Drawing.Size(0, 17)
        Me.lblIDInspeccion.TabIndex = 10
        '
        'lblLiena
        '
        Me.lblLiena.AutoSize = True
        Me.lblLiena.Location = New System.Drawing.Point(351, 16)
        Me.lblLiena.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLiena.Name = "lblLiena"
        Me.lblLiena.Size = New System.Drawing.Size(64, 17)
        Me.lblLiena.TabIndex = 11
        Me.lblLiena.Text = "ID Liena:"
        '
        'lblIDLinea
        '
        Me.lblIDLinea.AutoSize = True
        Me.lblIDLinea.Location = New System.Drawing.Point(425, 16)
        Me.lblIDLinea.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblIDLinea.Name = "lblIDLinea"
        Me.lblIDLinea.Size = New System.Drawing.Size(0, 17)
        Me.lblIDLinea.TabIndex = 12
        '
        'frmSacarFoto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1092, 527)
        Me.Controls.Add(Me.lblIDLinea)
        Me.Controls.Add(Me.lblLiena)
        Me.Controls.Add(Me.lblIDInspeccion)
        Me.Controls.Add(Me.lblInspeccion)
        Me.Controls.Add(Me.gbSacarFoto)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmSacarFoto"
        Me.Text = "Sacar Fotografía"
        CType(Me.pbVistaPrevia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbSacarFoto.ResumeLayout(False)
        Me.gbSacarFoto.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdCapturar As Button
    Friend WithEvents pbVistaPrevia As PictureBox
    Friend WithEvents cmdIniciar As Button
    Friend WithEvents cmdGuardar As Button
    Friend WithEvents lblCámara As Label
    Friend WithEvents lblVistaPrevia As Label
    Friend WithEvents vspCamara As AForge.Controls.VideoSourcePlayer
    Friend WithEvents gbSacarFoto As GroupBox
    Friend WithEvents lblInspeccion As Label
    Friend WithEvents lblIDInspeccion As Label
    Friend WithEvents lblLiena As Label
    Friend WithEvents lblIDLinea As Label
End Class
