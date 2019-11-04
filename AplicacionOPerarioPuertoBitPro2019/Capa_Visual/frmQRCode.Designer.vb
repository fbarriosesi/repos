<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmQRCode
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmQRCode))
        Me.QRpic = New System.Windows.Forms.PictureBox()
        Me.lblId_Vehiculo_QR = New System.Windows.Forms.Label()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.cmdGuardarQR = New System.Windows.Forms.Button()
        Me.lblDeseaGuardarQR2 = New System.Windows.Forms.Label()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        CType(Me.QRpic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'QRpic
        '
        Me.QRpic.BackColor = System.Drawing.Color.White
        Me.QRpic.Location = New System.Drawing.Point(12, 48)
        Me.QRpic.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.QRpic.Name = "QRpic"
        Me.QRpic.Size = New System.Drawing.Size(427, 258)
        Me.QRpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.QRpic.TabIndex = 0
        Me.QRpic.TabStop = False
        '
        'lblId_Vehiculo_QR
        '
        Me.lblId_Vehiculo_QR.AutoSize = True
        Me.lblId_Vehiculo_QR.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblId_Vehiculo_QR.Location = New System.Drawing.Point(37, 25)
        Me.lblId_Vehiculo_QR.Name = "lblId_Vehiculo_QR"
        Me.lblId_Vehiculo_QR.Size = New System.Drawing.Size(106, 20)
        Me.lblId_Vehiculo_QR.TabIndex = 1
        Me.lblId_Vehiculo_QR.Text = "Código QR:"
        '
        'cmdSalir
        '
        Me.cmdSalir.Location = New System.Drawing.Point(12, 378)
        Me.cmdSalir.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(116, 47)
        Me.cmdSalir.TabIndex = 2
        Me.cmdSalir.Text = "Salir"
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'cmdGuardarQR
        '
        Me.cmdGuardarQR.Location = New System.Drawing.Point(323, 378)
        Me.cmdGuardarQR.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmdGuardarQR.Name = "cmdGuardarQR"
        Me.cmdGuardarQR.Size = New System.Drawing.Size(116, 47)
        Me.cmdGuardarQR.TabIndex = 3
        Me.cmdGuardarQR.Text = "Guardar"
        Me.cmdGuardarQR.UseVisualStyleBackColor = True
        '
        'lblDeseaGuardarQR2
        '
        Me.lblDeseaGuardarQR2.AutoSize = True
        Me.lblDeseaGuardarQR2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDeseaGuardarQR2.Location = New System.Drawing.Point(48, 331)
        Me.lblDeseaGuardarQR2.Name = "lblDeseaGuardarQR2"
        Me.lblDeseaGuardarQR2.Size = New System.Drawing.Size(349, 20)
        Me.lblDeseaGuardarQR2.TabIndex = 5
        Me.lblDeseaGuardarQR2.Text = "¿Desea guardar el QR correspondiente?"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.FileName = "Nombre.png"
        Me.SaveFileDialog1.Filter = "PNG Image |*.png"
        '
        'frmQRCode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(451, 437)
        Me.Controls.Add(Me.lblDeseaGuardarQR2)
        Me.Controls.Add(Me.cmdGuardarQR)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.lblId_Vehiculo_QR)
        Me.Controls.Add(Me.QRpic)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmQRCode"
        Me.Text = "frmQRCode"
        CType(Me.QRpic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents QRpic As PictureBox
    Friend WithEvents lblId_Vehiculo_QR As Label
    Friend WithEvents cmdSalir As Button
    Friend WithEvents cmdGuardarQR As Button
    Friend WithEvents lblDeseaGuardarQR2 As Label
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
End Class
