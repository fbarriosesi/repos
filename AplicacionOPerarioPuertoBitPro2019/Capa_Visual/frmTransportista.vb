Public Class frmTransportista

    Dim t As New Clase_transporta

    Private Sub frmTransportista_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        t.ListarLotes()

    End Sub

    Private Sub cmdIniciarViaje_Click(sender As Object, e As EventArgs) Handles cmdIniciarViaje.Click

        cmdFinalizarViaje.Visible = True
        cmdIniciarViaje.Visible = False
        t.ObtenerId()
        t.IniciarViaje()


    End Sub

    Private Sub cmdFinalizarViaje_Click(sender As Object, e As EventArgs) Handles cmdFinalizarViaje.Click

        cmdFinalizarViaje.Visible = False
        cmdIniciarViaje.Visible = True
        t.FinalizarViaje()

    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        frmLogin.Show()
        Me.Close()
    End Sub
End Class