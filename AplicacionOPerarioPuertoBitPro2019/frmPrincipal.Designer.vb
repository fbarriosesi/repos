<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPrincipal
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
        Me.MenuLoginSalir = New System.Windows.Forms.MenuStrip()
        Me.LoginSalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuLoginSalir.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuLoginSalir
        '
        Me.MenuLoginSalir.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuLoginSalir.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginSalirToolStripMenuItem})
        Me.MenuLoginSalir.Location = New System.Drawing.Point(0, 0)
        Me.MenuLoginSalir.Name = "MenuLoginSalir"
        Me.MenuLoginSalir.Size = New System.Drawing.Size(800, 28)
        Me.MenuLoginSalir.TabIndex = 0
        Me.MenuLoginSalir.Text = "Login/Salir"
        '
        'LoginSalirToolStripMenuItem
        '
        Me.LoginSalirToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.LoginSalirToolStripMenuItem.Name = "LoginSalirToolStripMenuItem"
        Me.LoginSalirToolStripMenuItem.Size = New System.Drawing.Size(93, 24)
        Me.LoginSalirToolStripMenuItem.Text = "Login/Salir"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.LoginToolStripMenuItem.Text = "Login"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(216, 26)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuLoginSalir)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuLoginSalir
        Me.Name = "frmPrincipal"
        Me.Text = "Principal"
        Me.MenuLoginSalir.ResumeLayout(False)
        Me.MenuLoginSalir.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuLoginSalir As MenuStrip
    Friend WithEvents LoginSalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
End Class
