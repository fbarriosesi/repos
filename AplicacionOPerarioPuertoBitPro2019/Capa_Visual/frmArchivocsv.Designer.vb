<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmArchivocsv
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
        Me.ButtonGUARDAR = New System.Windows.Forms.Button()
        Me.ButtonCARGAR = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.vinDGV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.marcaDGV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.modeloDGV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colorDGV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.anioDGV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipoDGV = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ButtonBUSCAR = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdInsert = New System.Windows.Forms.Button()
        Me.lblGuardarCSV = New System.Windows.Forms.Label()
        Me.cmdVolver = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonGUARDAR
        '
        Me.ButtonGUARDAR.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonGUARDAR.BackColor = System.Drawing.SystemColors.Control
        Me.ButtonGUARDAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonGUARDAR.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButtonGUARDAR.Location = New System.Drawing.Point(682, 146)
        Me.ButtonGUARDAR.Name = "ButtonGUARDAR"
        Me.ButtonGUARDAR.Size = New System.Drawing.Size(192, 40)
        Me.ButtonGUARDAR.TabIndex = 6
        Me.ButtonGUARDAR.Text = "GUARDAR"
        Me.ButtonGUARDAR.UseVisualStyleBackColor = False
        '
        'ButtonCARGAR
        '
        Me.ButtonCARGAR.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtonCARGAR.BackColor = System.Drawing.SystemColors.Control
        Me.ButtonCARGAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCARGAR.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButtonCARGAR.Location = New System.Drawing.Point(681, 48)
        Me.ButtonCARGAR.Name = "ButtonCARGAR"
        Me.ButtonCARGAR.Size = New System.Drawing.Size(192, 40)
        Me.ButtonCARGAR.TabIndex = 5
        Me.ButtonCARGAR.Text = "CARGAR"
        Me.ButtonCARGAR.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.vinDGV, Me.marcaDGV, Me.modeloDGV, Me.colorDGV, Me.anioDGV, Me.tipoDGV})
        Me.DataGridView1.Location = New System.Drawing.Point(13, 13)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(663, 380)
        Me.DataGridView1.TabIndex = 7
        '
        'vinDGV
        '
        Me.vinDGV.HeaderText = "Vin"
        Me.vinDGV.Name = "vinDGV"
        '
        'marcaDGV
        '
        Me.marcaDGV.HeaderText = "Marca"
        Me.marcaDGV.Name = "marcaDGV"
        '
        'modeloDGV
        '
        Me.modeloDGV.HeaderText = "Modelo"
        Me.modeloDGV.Name = "modeloDGV"
        '
        'colorDGV
        '
        Me.colorDGV.HeaderText = "Color"
        Me.colorDGV.Name = "colorDGV"
        '
        'anioDGV
        '
        Me.anioDGV.HeaderText = "Año"
        Me.anioDGV.Name = "anioDGV"
        '
        'tipoDGV
        '
        Me.tipoDGV.HeaderText = "Tipo"
        Me.tipoDGV.Name = "tipoDGV"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TextBox1.Location = New System.Drawing.Point(180, 406)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(273, 26)
        Me.TextBox1.TabIndex = 8
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ButtonBUSCAR
        '
        Me.ButtonBUSCAR.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.ButtonBUSCAR.BackColor = System.Drawing.SystemColors.Control
        Me.ButtonBUSCAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonBUSCAR.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButtonBUSCAR.Location = New System.Drawing.Point(496, 399)
        Me.ButtonBUSCAR.Name = "ButtonBUSCAR"
        Me.ButtonBUSCAR.Size = New System.Drawing.Size(140, 40)
        Me.ButtonBUSCAR.TabIndex = 9
        Me.ButtonBUSCAR.Text = "BUSCAR"
        Me.ButtonBUSCAR.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(715, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 20)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Importar CSV"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(720, 330)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 20)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Insertar CSV"
        '
        'cmdInsert
        '
        Me.cmdInsert.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdInsert.BackColor = System.Drawing.SystemColors.Control
        Me.cmdInsert.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdInsert.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmdInsert.Location = New System.Drawing.Point(682, 353)
        Me.cmdInsert.Name = "cmdInsert"
        Me.cmdInsert.Size = New System.Drawing.Size(192, 40)
        Me.cmdInsert.TabIndex = 12
        Me.cmdInsert.Text = "INSERTAR EN BD"
        Me.cmdInsert.UseVisualStyleBackColor = False
        '
        'lblGuardarCSV
        '
        Me.lblGuardarCSV.AutoSize = True
        Me.lblGuardarCSV.Location = New System.Drawing.Point(715, 123)
        Me.lblGuardarCSV.Name = "lblGuardarCSV"
        Me.lblGuardarCSV.Size = New System.Drawing.Size(123, 20)
        Me.lblGuardarCSV.TabIndex = 13
        Me.lblGuardarCSV.Text = "Exportar CSV"
        '
        'cmdVolver
        '
        Me.cmdVolver.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cmdVolver.BackColor = System.Drawing.SystemColors.Control
        Me.cmdVolver.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdVolver.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmdVolver.Location = New System.Drawing.Point(12, 399)
        Me.cmdVolver.Name = "cmdVolver"
        Me.cmdVolver.Size = New System.Drawing.Size(140, 40)
        Me.cmdVolver.TabIndex = 14
        Me.cmdVolver.Text = "VOLVER"
        Me.cmdVolver.UseVisualStyleBackColor = False
        '
        'frmArchivocsv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(885, 444)
        Me.Controls.Add(Me.cmdVolver)
        Me.Controls.Add(Me.lblGuardarCSV)
        Me.Controls.Add(Me.cmdInsert)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonBUSCAR)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ButtonGUARDAR)
        Me.Controls.Add(Me.ButtonCARGAR)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmArchivocsv"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CSV"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonGUARDAR As System.Windows.Forms.Button
    Friend WithEvents ButtonCARGAR As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ButtonBUSCAR As System.Windows.Forms.Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmdInsert As Button
    Friend WithEvents vinDGV As DataGridViewTextBoxColumn
    Friend WithEvents marcaDGV As DataGridViewTextBoxColumn
    Friend WithEvents modeloDGV As DataGridViewTextBoxColumn
    Friend WithEvents colorDGV As DataGridViewTextBoxColumn
    Friend WithEvents anioDGV As DataGridViewTextBoxColumn
    Friend WithEvents tipoDGV As DataGridViewTextBoxColumn
    Friend WithEvents lblGuardarCSV As Label
    Friend WithEvents cmdVolver As Button
End Class