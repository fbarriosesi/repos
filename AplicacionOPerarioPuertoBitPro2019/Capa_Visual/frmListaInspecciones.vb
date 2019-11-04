Public Class frmListaInspecciones
    Dim i As New Clase_Inspeccion
    Dim idVehiculo As Integer
    Dim idInspeccion As Integer

    Private Sub dgvInspecciones_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvInspecciones.CellClick
        Dim datoI As DataGridViewRow = dgvInspecciones.CurrentRow
        idInspeccion = CInt(datoI.Cells(0).Value)
        MsgBox("INSPECCION SELECCIONADA: " & idInspeccion)
    End Sub

    Private Sub frmListaInspecciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox(i.ListarInspecciones(CInt(lblIDVehiulo.Text)))
    End Sub

    Private Sub cmdVolver_Click(sender As Object, e As EventArgs) Handles cmdVolver.Click
        frmListadoVehiculos.Show()
        Me.Close()
    End Sub

    Private Sub cmdDetalles_Click(sender As Object, e As EventArgs) Handles cmdDetalles.Click
        frmDetalles.lblIDInspeccion.Text = idInspeccion
        frmDetalles.idInspeccion = idInspeccion
        frmDetalles.Show()
        Me.Hide()
    End Sub

    Private Sub dgvInspecciones_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvInspecciones.CellContentClick

    End Sub
End Class