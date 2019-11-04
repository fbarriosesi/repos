
Public Class frmUsuario

    Dim ob As New Clase_empleado

    '*****************************************************************************************************************************
    '*****************************************************************************************************************************

    Private Sub cmdBuscarUsuario_Click(sender As Object, e As EventArgs) Handles cmdBuscarUsuario.Click

        If txtBUsuario.Text.Trim = "" Or IsNumeric(txtBUsuario.Text) Then
            MsgBox("Debe Ingresar un Dato a Buscar, Usuario o Cedula.")
        Else
            txtRUsuario.Text = txtBUsuario.Text
            ob.buscarUsuario(txtBUsuario.Text)
            txtRUsuario.Text = ob.usuario
            txtRCedula.Text = ob.cedula
            txtRApellido.Text = ob.apellido
            txtRNombre.Text = ob.nombre
            txtRTelefono.Text = ob.telefono
        End If

    End Sub

    '*****************************************************************************************************************************
    '*****************************************************************************************************************************

    Private Sub cmdBuscarCedula_Click(sender As Object, e As EventArgs) Handles cmdBuscarCedula.Click

        If txtBCedula.Text.Trim = "" Or Not IsNumeric(txtBCedula.Text) Then
            MsgBox("Debe Ingresar un Dato a Buscar, Usuario o Cedula.")
        Else
            If txtBCedula.Text.Length <> 8 Then
                MsgBox("Debe Ingresar un Dato a Buscar, Usuario o Cedula.")
            Else
                txtRCedula.Text = txtBCedula.Text
                ob.buscarCedula(txtBCedula.Text)
                txtRUsuario.Text = ob.usuario
                txtRApellido.Text = ob.apellido
                txtRNombre.Text = ob.nombre
                txtRTelefono.Text = ob.telefono
            End If

        End If

    End Sub

    '*****************************************************************************************************************************
    '*****************************************************************************************************************************

    Private Sub cmdModificar_Click(sender As Object, e As EventArgs) Handles cmdModificar.Click

        frmModificar.Show()
        frmModificar.txtRUsuario.Text = txtRUsuario.Text
        Me.Refresh()
        Me.Hide()

    End Sub

    '*****************************************************************************************************************************
    '*****************************************************************************************************************************

    Private Sub cmdVolver_Click(sender As Object, e As EventArgs) Handles cmdVolver.Click

        frmUsuarios.Show()
        Me.Close()

    End Sub

    '*****************************************************************************************************************************
    '*****************************************************************************************************************************

End Class