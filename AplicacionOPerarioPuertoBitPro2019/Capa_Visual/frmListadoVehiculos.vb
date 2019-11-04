Public Class frmListadoVehiculos
    Dim v As New Clase_Vehiculo
    Dim idVehiculo As Integer

    Private Sub dgvListado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvListado.CellClick
        Dim datoV As DataGridViewRow = dgvListado.CurrentRow
        idVehiculo = CInt(datoV.Cells(0).Value)
        MsgBox("VEHICULO SELECCIONADO:" & idVehiculo)
    End Sub

    Private Sub cmdBuscarVIN_Click(sender As Object, e As EventArgs) Handles cmdBuscarVIN.Click
        If txtBuscarVIN.Text.Trim = "" Then
            v.Listar_Vehiculos()
        Else
            v.ListarVehiculoVIN(txtBuscarVIN.Text)
        End If

    End Sub

    Private Sub cmdBuscarID_Click(sender As Object, e As EventArgs) Handles cmdBuscarID.Click
        If txtBuscarID.Text.Trim = "" Then
            v.Listar_Vehiculos()
        Else
            v.ListarVehiculoID(CInt(txtBuscarID.Text))
        End If
    End Sub

    Private Sub cmdLocalizar_Click(sender As Object, e As EventArgs) Handles cmdLocalizar.Click

    End Sub

    Private Sub cmdVolver_Click(sender As Object, e As EventArgs) Handles cmdVolver.Click
        frmVehiculos.Show()
        Me.Close()
    End Sub

    Private Sub cmdInspecciones_Click(sender As Object, e As EventArgs) Handles cmdInspecciones.Click
        frmListaInspecciones.lblIDVehiulo.Text = idVehiculo
        frmListaInspecciones.Show()
        Me.Hide()
    End Sub


End Class