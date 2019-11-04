<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmOperarioPuerto
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdBuscar = New System.Windows.Forms.Button()
        Me.cmdInspeccion = New System.Windows.Forms.Button()
        Me.txt_Vin = New System.Windows.Forms.TextBox()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblLote = New System.Windows.Forms.Label()
        Me.txtLote = New System.Windows.Forms.TextBox()
        Me.cmdQRGen = New System.Windows.Forms.Button()
        Me.txtid_vehiculo = New System.Windows.Forms.TextBox()
        Me.lblId_vehiculo = New System.Windows.Forms.Label()
        Me.txt_marca = New System.Windows.Forms.TextBox()
        Me.txt_modelo = New System.Windows.Forms.TextBox()
        Me.txt_tipovehiculo = New System.Windows.Forms.TextBox()
        Me.txt_color = New System.Windows.Forms.TextBox()
        Me.txt_anio = New System.Windows.Forms.TextBox()
        Me.lbl_tipo_vehiculo = New System.Windows.Forms.Label()
        Me.lbl_color = New System.Windows.Forms.Label()
        Me.lbl_anio = New System.Windows.Forms.Label()
        Me.lbl_modelo = New System.Windows.Forms.Label()
        Me.lbl_marca = New System.Windows.Forms.Label()
        Me.lbl_Vin = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label1.Location = New System.Drawing.Point(241, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(327, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sistema de Inspeccion de Vehiculos"
        '
        'cmdBuscar
        '
        Me.cmdBuscar.Location = New System.Drawing.Point(461, 47)
        Me.cmdBuscar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(75, 33)
        Me.cmdBuscar.TabIndex = 37
        Me.cmdBuscar.Text = "Buscar"
        Me.cmdBuscar.UseVisualStyleBackColor = True
        '
        'cmdInspeccion
        '
        Me.cmdInspeccion.Enabled = False
        Me.cmdInspeccion.Location = New System.Drawing.Point(656, 462)
        Me.cmdInspeccion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmdInspeccion.Name = "cmdInspeccion"
        Me.cmdInspeccion.Size = New System.Drawing.Size(116, 30)
        Me.cmdInspeccion.TabIndex = 38
        Me.cmdInspeccion.Text = "Inspección"
        Me.cmdInspeccion.UseVisualStyleBackColor = True
        '
        'txt_Vin
        '
        Me.txt_Vin.Location = New System.Drawing.Point(89, 52)
        Me.txt_Vin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_Vin.Name = "txt_Vin"
        Me.txt_Vin.Size = New System.Drawing.Size(343, 22)
        Me.txt_Vin.TabIndex = 35
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(101, 460)
        Me.cmdSalir.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(84, 30)
        Me.cmdSalir.TabIndex = 39
        Me.cmdSalir.Text = "Salir"
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblLote)
        Me.GroupBox1.Controls.Add(Me.txtLote)
        Me.GroupBox1.Controls.Add(Me.cmdQRGen)
        Me.GroupBox1.Controls.Add(Me.txtid_vehiculo)
        Me.GroupBox1.Controls.Add(Me.lblId_vehiculo)
        Me.GroupBox1.Controls.Add(Me.txt_marca)
        Me.GroupBox1.Controls.Add(Me.txt_modelo)
        Me.GroupBox1.Controls.Add(Me.txt_tipovehiculo)
        Me.GroupBox1.Controls.Add(Me.txt_color)
        Me.GroupBox1.Controls.Add(Me.txt_anio)
        Me.GroupBox1.Controls.Add(Me.lbl_tipo_vehiculo)
        Me.GroupBox1.Controls.Add(Me.lbl_color)
        Me.GroupBox1.Controls.Add(Me.lbl_anio)
        Me.GroupBox1.Controls.Add(Me.lbl_modelo)
        Me.GroupBox1.Controls.Add(Me.lbl_marca)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(39, 103)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(781, 270)
        Me.GroupBox1.TabIndex = 36
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Vehiculo"
        '
        'lblLote
        '
        Me.lblLote.AutoSize = True
        Me.lblLote.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLote.Location = New System.Drawing.Point(506, 25)
        Me.lblLote.Name = "lblLote"
        Me.lblLote.Size = New System.Drawing.Size(42, 20)
        Me.lblLote.TabIndex = 19
        Me.lblLote.Text = "Lote"
        '
        'txtLote
        '
        Me.txtLote.Location = New System.Drawing.Point(510, 58)
        Me.txtLote.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtLote.Name = "txtLote"
        Me.txtLote.ReadOnly = True
        Me.txtLote.Size = New System.Drawing.Size(265, 22)
        Me.txtLote.TabIndex = 18
        '
        'cmdQRGen
        '
        Me.cmdQRGen.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdQRGen.Location = New System.Drawing.Point(412, 21)
        Me.cmdQRGen.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmdQRGen.Name = "cmdQRGen"
        Me.cmdQRGen.Size = New System.Drawing.Size(44, 30)
        Me.cmdQRGen.TabIndex = 17
        Me.cmdQRGen.Text = "QR"
        Me.cmdQRGen.UseVisualStyleBackColor = True
        '
        'txtid_vehiculo
        '
        Me.txtid_vehiculo.Location = New System.Drawing.Point(131, 25)
        Me.txtid_vehiculo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtid_vehiculo.Name = "txtid_vehiculo"
        Me.txtid_vehiculo.ReadOnly = True
        Me.txtid_vehiculo.Size = New System.Drawing.Size(265, 22)
        Me.txtid_vehiculo.TabIndex = 16
        '
        'lblId_vehiculo
        '
        Me.lblId_vehiculo.AutoSize = True
        Me.lblId_vehiculo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblId_vehiculo.Location = New System.Drawing.Point(13, 25)
        Me.lblId_vehiculo.Name = "lblId_vehiculo"
        Me.lblId_vehiculo.Size = New System.Drawing.Size(91, 20)
        Me.lblId_vehiculo.TabIndex = 15
        Me.lblId_vehiculo.Text = "Id Vehiculo"
        '
        'txt_marca
        '
        Me.txt_marca.Location = New System.Drawing.Point(131, 60)
        Me.txt_marca.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_marca.Name = "txt_marca"
        Me.txt_marca.ReadOnly = True
        Me.txt_marca.Size = New System.Drawing.Size(265, 22)
        Me.txt_marca.TabIndex = 11
        '
        'txt_modelo
        '
        Me.txt_modelo.Location = New System.Drawing.Point(131, 98)
        Me.txt_modelo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_modelo.Name = "txt_modelo"
        Me.txt_modelo.ReadOnly = True
        Me.txt_modelo.Size = New System.Drawing.Size(265, 22)
        Me.txt_modelo.TabIndex = 10
        '
        'txt_tipovehiculo
        '
        Me.txt_tipovehiculo.Location = New System.Drawing.Point(131, 212)
        Me.txt_tipovehiculo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_tipovehiculo.Name = "txt_tipovehiculo"
        Me.txt_tipovehiculo.ReadOnly = True
        Me.txt_tipovehiculo.Size = New System.Drawing.Size(265, 22)
        Me.txt_tipovehiculo.TabIndex = 7
        '
        'txt_color
        '
        Me.txt_color.Location = New System.Drawing.Point(131, 137)
        Me.txt_color.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_color.Name = "txt_color"
        Me.txt_color.ReadOnly = True
        Me.txt_color.Size = New System.Drawing.Size(265, 22)
        Me.txt_color.TabIndex = 9
        '
        'txt_anio
        '
        Me.txt_anio.Location = New System.Drawing.Point(131, 174)
        Me.txt_anio.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_anio.Name = "txt_anio"
        Me.txt_anio.ReadOnly = True
        Me.txt_anio.Size = New System.Drawing.Size(100, 22)
        Me.txt_anio.TabIndex = 8
        '
        'lbl_tipo_vehiculo
        '
        Me.lbl_tipo_vehiculo.AutoSize = True
        Me.lbl_tipo_vehiculo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tipo_vehiculo.Location = New System.Drawing.Point(13, 215)
        Me.lbl_tipo_vehiculo.Name = "lbl_tipo_vehiculo"
        Me.lbl_tipo_vehiculo.Size = New System.Drawing.Size(110, 20)
        Me.lbl_tipo_vehiculo.TabIndex = 6
        Me.lbl_tipo_vehiculo.Text = "Tipo Vehiculo"
        '
        'lbl_color
        '
        Me.lbl_color.AutoSize = True
        Me.lbl_color.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_color.Location = New System.Drawing.Point(13, 140)
        Me.lbl_color.Name = "lbl_color"
        Me.lbl_color.Size = New System.Drawing.Size(49, 20)
        Me.lbl_color.TabIndex = 5
        Me.lbl_color.Text = "Color"
        '
        'lbl_anio
        '
        Me.lbl_anio.AutoSize = True
        Me.lbl_anio.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_anio.Location = New System.Drawing.Point(13, 178)
        Me.lbl_anio.Name = "lbl_anio"
        Me.lbl_anio.Size = New System.Drawing.Size(38, 20)
        Me.lbl_anio.TabIndex = 3
        Me.lbl_anio.Text = "Año"
        '
        'lbl_modelo
        '
        Me.lbl_modelo.AutoSize = True
        Me.lbl_modelo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_modelo.Location = New System.Drawing.Point(13, 102)
        Me.lbl_modelo.Name = "lbl_modelo"
        Me.lbl_modelo.Size = New System.Drawing.Size(63, 20)
        Me.lbl_modelo.TabIndex = 2
        Me.lbl_modelo.Text = "Modelo"
        '
        'lbl_marca
        '
        Me.lbl_marca.AutoSize = True
        Me.lbl_marca.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_marca.Location = New System.Drawing.Point(13, 60)
        Me.lbl_marca.Name = "lbl_marca"
        Me.lbl_marca.Size = New System.Drawing.Size(56, 20)
        Me.lbl_marca.TabIndex = 1
        Me.lbl_marca.Text = "Marca"
        '
        'lbl_Vin
        '
        Me.lbl_Vin.AutoSize = True
        Me.lbl_Vin.Location = New System.Drawing.Point(36, 55)
        Me.lbl_Vin.Name = "lbl_Vin"
        Me.lbl_Vin.Size = New System.Drawing.Size(42, 17)
        Me.lbl_Vin.TabIndex = 34
        Me.lbl_Vin.Text = "V.I.N."
        '
        'frmOperarioPuerto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.ClientSize = New System.Drawing.Size(857, 538)
        Me.Controls.Add(Me.cmdBuscar)
        Me.Controls.Add(Me.cmdInspeccion)
        Me.Controls.Add(Me.txt_Vin)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lbl_Vin)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmOperarioPuerto"
        Me.Text = "Operario de Puerto"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cmdBuscar As Button
    Friend WithEvents cmdInspeccion As Button
    Friend WithEvents txt_Vin As TextBox
    Friend WithEvents cmdSalir As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmdQRGen As Button
    Friend WithEvents txtid_vehiculo As TextBox
    Friend WithEvents lblId_vehiculo As Label
    Friend WithEvents txt_marca As TextBox
    Friend WithEvents txt_modelo As TextBox
    Friend WithEvents txt_tipovehiculo As TextBox
    Friend WithEvents txt_color As TextBox
    Friend WithEvents txt_anio As TextBox
    Friend WithEvents lbl_tipo_vehiculo As Label
    Friend WithEvents lbl_color As Label
    Friend WithEvents lbl_anio As Label
    Friend WithEvents lbl_modelo As Label
    Friend WithEvents lbl_marca As Label
    Friend WithEvents lbl_Vin As Label
    Friend WithEvents lblLote As Label
    Friend WithEvents txtLote As TextBox
End Class
