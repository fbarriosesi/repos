Public Class frmUbicacionMaps

    Public urlfin As String

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted

    End Sub

    Private Sub cmdLocalizar_Click(sender As Object, e As EventArgs) Handles cmdLocalizar.Click

        urlfin = "https://maps.app.goo.gl/4ga7ei22CGZozuxB9"
        WebBrowser1.Navigate(urlfin)

    End Sub

    Private Sub cmdVolver_Click(sender As Object, e As EventArgs) Handles cmdVolver.Click

        If cedula = 44444444 Then

            frmBuscaVehiculoAdmin.Show()
            Me.Refresh()
            Me.Close()

        ElseIf cedula = 22222222 Then

            frmOperarioPuerto.Show()
            Me.Refresh()
            Me.Close()

        ElseIf cedula = 33333333 Then

            frmOperarioPatio.Show()
            Me.Refresh()
            Me.Close()

        End If

    End Sub
End Class