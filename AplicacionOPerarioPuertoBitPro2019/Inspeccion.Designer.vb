<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInspeccion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInspeccion))
        Me.gbDaños = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cboOtros = New System.Windows.Forms.ComboBox()
        Me.cboDaños = New System.Windows.Forms.ComboBox()
        Me.lblDaño = New System.Windows.Forms.Label()
        Me.optOtros = New System.Windows.Forms.RadioButton()
        Me.optNeumaticos = New System.Windows.Forms.RadioButton()
        Me.optVidrios = New System.Windows.Forms.RadioButton()
        Me.optChapa = New System.Windows.Forms.RadioButton()
        Me.cmdMas = New System.Windows.Forms.Button()
        Me.cmdMenos = New System.Windows.Forms.Button()
        Me.cmdGuardar = New System.Windows.Forms.Button()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.lblIdInspeccion = New System.Windows.Forms.Label()
        Me.lblnumeroInspeccion = New System.Windows.Forms.Label()
        Me.gbDaños.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbDaños
        '
        Me.gbDaños.Controls.Add(Me.PictureBox1)
        Me.gbDaños.Controls.Add(Me.cboOtros)
        Me.gbDaños.Controls.Add(Me.cboDaños)
        Me.gbDaños.Controls.Add(Me.lblDaño)
        Me.gbDaños.Controls.Add(Me.optOtros)
        Me.gbDaños.Controls.Add(Me.optNeumaticos)
        Me.gbDaños.Controls.Add(Me.cmdMenos)
        Me.gbDaños.Controls.Add(Me.optVidrios)
        Me.gbDaños.Controls.Add(Me.optChapa)
        Me.gbDaños.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDaños.Location = New System.Drawing.Point(16, 11)
        Me.gbDaños.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbDaños.Name = "gbDaños"
        Me.gbDaños.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbDaños.Size = New System.Drawing.Size(1169, 288)
        Me.gbDaños.TabIndex = 1
        Me.gbDaños.TabStop = False
        Me.gbDaños.Text = "Daños"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(8, 34)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(337, 188)
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'cboOtros
        '
        Me.cboOtros.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboOtros.FormattingEnabled = True
        Me.cboOtros.Location = New System.Drawing.Point(451, 97)
        Me.cboOtros.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboOtros.Name = "cboOtros"
        Me.cboOtros.Size = New System.Drawing.Size(703, 32)
        Me.cboOtros.TabIndex = 6
        '
        'cboDaños
        '
        Me.cboDaños.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDaños.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDaños.FormattingEnabled = True
        Me.cboDaños.Location = New System.Drawing.Point(451, 97)
        Me.cboDaños.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboDaños.Name = "cboDaños"
        Me.cboDaños.Size = New System.Drawing.Size(703, 32)
        Me.cboDaños.TabIndex = 5
        '
        'lblDaño
        '
        Me.lblDaño.AutoSize = True
        Me.lblDaño.Location = New System.Drawing.Point(369, 100)
        Me.lblDaño.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDaño.Name = "lblDaño"
        Me.lblDaño.Size = New System.Drawing.Size(70, 29)
        Me.lblDaño.TabIndex = 4
        Me.lblDaño.Text = "Daño"
        '
        'optOtros
        '
        Me.optOtros.AutoSize = True
        Me.optOtros.Location = New System.Drawing.Point(1057, 38)
        Me.optOtros.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.optOtros.Name = "optOtros"
        Me.optOtros.Size = New System.Drawing.Size(93, 33)
        Me.optOtros.TabIndex = 3
        Me.optOtros.TabStop = True
        Me.optOtros.Text = "Otros"
        Me.optOtros.UseVisualStyleBackColor = True
        '
        'optNeumaticos
        '
        Me.optNeumaticos.AutoSize = True
        Me.optNeumaticos.Location = New System.Drawing.Point(832, 39)
        Me.optNeumaticos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.optNeumaticos.Name = "optNeumaticos"
        Me.optNeumaticos.Size = New System.Drawing.Size(162, 33)
        Me.optNeumaticos.TabIndex = 2
        Me.optNeumaticos.TabStop = True
        Me.optNeumaticos.Text = "Neumaticos"
        Me.optNeumaticos.UseVisualStyleBackColor = True
        '
        'optVidrios
        '
        Me.optVidrios.AutoSize = True
        Me.optVidrios.Location = New System.Drawing.Point(641, 39)
        Me.optVidrios.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.optVidrios.Name = "optVidrios"
        Me.optVidrios.Size = New System.Drawing.Size(109, 33)
        Me.optVidrios.TabIndex = 1
        Me.optVidrios.TabStop = True
        Me.optVidrios.Text = "Vidrios"
        Me.optVidrios.UseVisualStyleBackColor = True
        '
        'optChapa
        '
        Me.optChapa.AutoSize = True
        Me.optChapa.Location = New System.Drawing.Point(376, 39)
        Me.optChapa.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.optChapa.Name = "optChapa"
        Me.optChapa.Size = New System.Drawing.Size(199, 33)
        Me.optChapa.TabIndex = 0
        Me.optChapa.TabStop = True
        Me.optChapa.Text = "Chapa - Pintura"
        Me.optChapa.UseVisualStyleBackColor = True
        '
        'cmdMas
        '
        Me.cmdMas.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMas.Location = New System.Drawing.Point(959, 495)
        Me.cmdMas.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdMas.Name = "cmdMas"
        Me.cmdMas.Size = New System.Drawing.Size(60, 49)
        Me.cmdMas.TabIndex = 2
        Me.cmdMas.Text = "+"
        Me.cmdMas.UseVisualStyleBackColor = True
        '
        'cmdMenos
        '
        Me.cmdMenos.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdMenos.Location = New System.Drawing.Point(8, 230)
        Me.cmdMenos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdMenos.Name = "cmdMenos"
        Me.cmdMenos.Size = New System.Drawing.Size(175, 49)
        Me.cmdMenos.TabIndex = 3
        Me.cmdMenos.Text = "Eliminar"
        Me.cmdMenos.UseVisualStyleBackColor = True
        '
        'cmdGuardar
        '
        Me.cmdGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGuardar.Location = New System.Drawing.Point(1039, 495)
        Me.cmdGuardar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdGuardar.Name = "cmdGuardar"
        Me.cmdGuardar.Size = New System.Drawing.Size(128, 49)
        Me.cmdGuardar.TabIndex = 4
        Me.cmdGuardar.Text = "Guardar"
        Me.cmdGuardar.UseVisualStyleBackColor = True
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.Location = New System.Drawing.Point(149, 507)
        Me.lblFecha.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(121, 29)
        Me.lblFecha.TabIndex = 5
        Me.lblFecha.Text = "dd/mm/aa"
        '
        'lblHora
        '
        Me.lblHora.AutoSize = True
        Me.lblHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHora.Location = New System.Drawing.Point(19, 507)
        Me.lblHora.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(117, 29)
        Me.lblHora.TabIndex = 6
        Me.lblHora.Text = "hh/mm/ss"
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuario.Location = New System.Drawing.Point(283, 508)
        Me.lblUsuario.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(190, 29)
        Me.lblUsuario.TabIndex = 7
        Me.lblUsuario.Text = "Nombre Usuario"
        '
        'lblIdInspeccion
        '
        Me.lblIdInspeccion.AutoSize = True
        Me.lblIdInspeccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdInspeccion.Location = New System.Drawing.Point(503, 508)
        Me.lblIdInspeccion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblIdInspeccion.Name = "lblIdInspeccion"
        Me.lblIdInspeccion.Size = New System.Drawing.Size(164, 29)
        Me.lblIdInspeccion.TabIndex = 10
        Me.lblIdInspeccion.Text = "ID Inspeccion:"
        '
        'lblnumeroInspeccion
        '
        Me.lblnumeroInspeccion.AutoSize = True
        Me.lblnumeroInspeccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnumeroInspeccion.Location = New System.Drawing.Point(671, 508)
        Me.lblnumeroInspeccion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblnumeroInspeccion.Name = "lblnumeroInspeccion"
        Me.lblnumeroInspeccion.Size = New System.Drawing.Size(26, 29)
        Me.lblnumeroInspeccion.TabIndex = 11
        Me.lblnumeroInspeccion.Text = "0"
        '
        'frmInspeccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1192, 554)
        Me.Controls.Add(Me.lblnumeroInspeccion)
        Me.Controls.Add(Me.lblIdInspeccion)
        Me.Controls.Add(Me.lblUsuario)
        Me.Controls.Add(Me.lblHora)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.cmdGuardar)
        Me.Controls.Add(Me.cmdMas)
        Me.Controls.Add(Me.gbDaños)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmInspeccion"
        Me.Text = "Inspeccion"
        Me.gbDaños.ResumeLayout(False)
        Me.gbDaños.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbDaños As GroupBox
    Friend WithEvents optOtros As RadioButton
    Friend WithEvents optNeumaticos As RadioButton
    Friend WithEvents optVidrios As RadioButton
    Friend WithEvents optChapa As RadioButton
    Friend WithEvents cboDaños As ComboBox
    Friend WithEvents lblDaño As Label
    Friend WithEvents cboOtros As ComboBox
    Friend WithEvents cmdMas As Button
    Friend WithEvents cmdMenos As Button
    Friend WithEvents cmdGuardar As Button
    Friend WithEvents lblFecha As Label
    Friend WithEvents lblHora As Label
    Friend WithEvents lblUsuario As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblIdInspeccion As Label
    Friend WithEvents lblnumeroInspeccion As Label
End Class
