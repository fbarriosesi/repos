Public Class frmUsuarios
    Private Sub cmdBuscar_Click(sender As Object, e As EventArgs) Handles cmdBusar.Click
        frmUsuario.Show()
        Me.Hide()
    End Sub

    Private Sub cmdListar_Click(sender As Object, e As EventArgs) Handles cmdListar.Click
        frmListaUsuarios.Show()
        Me.Close()

    End Sub

    Private Sub cmdVolver_Click(sender As Object, e As EventArgs) Handles cmdVolver.Click
        frmMenu.Show()
        Me.Refresh()
        Me.Close()
    End Sub
End Class