Public Class frmModificar
    Private Sub cmdGuardar_Click(sender As Object, e As EventArgs) Handles cmdGuardar.Click
        Dim em As New Clase_empleado
        em.nombre = txtRNombre.Text
        em.apellido = txtRApellido.Text
        em.telefono = txtRTelefono.Text
        MsgBox(em.modificarUsuario(txtRUsuario.Text))

    End Sub

    Private Sub cmdVolver_Click(sender As Object, e As EventArgs) Handles cmdVolver.Click
        frmUsuarios.Show()
        frmUsuario.Close()
        Me.Close()
    End Sub
End Class