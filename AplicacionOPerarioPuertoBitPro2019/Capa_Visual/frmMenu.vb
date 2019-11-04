Public Class frmMenu
    Private Sub cmdVehiculos_Click(sender As Object, e As EventArgs) Handles cmdVehiculos.Click
        frmVehiculos.Show()
        Me.Hide()
    End Sub

    Private Sub cmdUsuarios_Click(sender As Object, e As EventArgs) Handles cmdUsuarios.Click
        frmUsuarios.Show()
        Me.Hide()
    End Sub

    Private Sub cmdVolver_Click(sender As Object, e As EventArgs) Handles cmdVolver.Click
        frmLogin.Show()
        cn.Close()
        Me.Close()
    End Sub

    Private Sub cmdCSV_Click(sender As Object, e As EventArgs) Handles cmdCSV.Click

        frmArchivocsv.Show()
        Me.Close()

    End Sub
End Class