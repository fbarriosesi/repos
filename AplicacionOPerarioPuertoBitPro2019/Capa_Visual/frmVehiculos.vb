Public Class frmVehiculos
    Private Sub cmdBuscar_Click(sender As Object, e As EventArgs) Handles cmdBuscar.Click
        frmBuscaVehiculoAdmin.Show()
        Me.Close()
    End Sub

    Private Sub cmdVolver_Click(sender As Object, e As EventArgs) Handles cmdVolver.Click
        frmMenu.Show()
        Me.Close()
    End Sub

    Private Sub cmdListar_Click(sender As Object, e As EventArgs) Handles cmdListar.Click
        frmListadoVehiculos.Show()
        Me.Close()
    End Sub
End Class