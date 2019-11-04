Public Class frmListaUsuarios
    Private Sub cmdVolver_Click(sender As Object, e As EventArgs) Handles cmdVolver.Click
        frmUsuarios.Show()
        Me.Close()
    End Sub

    Private Sub cmdBuscarUsuario_Click(sender As Object, e As EventArgs) Handles cmdBuscarUsuario.Click
        If txtUsuario.Text.Trim = "" Then
            'ListarUsuarios()
        Else
            'ListarUsuario(txtUsuario.Text)
        End If
    End Sub

    Private Sub cmdBuscarCedula_Click(sender As Object, e As EventArgs) Handles cmdBuscarCedula.Click
        If txtUsuario.Text.Trim = "" Then
            'ListarUsuarios()
        Else
            'ListarCedula(txtCedula.Text)
        End If
    End Sub
End Class