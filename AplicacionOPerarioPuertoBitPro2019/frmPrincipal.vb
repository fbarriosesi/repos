Public Class frmPrincipal

    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        If cn.State = 0 Then ' chequeamos que la aplicacion no este conectada con la Base de Datos abre la ventana de login

            'frmLogin.MdiParent = Me ' decimos que el formulario es hijo de este formulario principal
            'frmLogin.Show() ' decimos que se muestre el formulario loggin dentro del principal
            'frmLogin.idAplicacion = 1 ' uso del metodo SET, programado en el formulario loggin

        Else
            If MsgBox("Desea desloguearse ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then ' Caso este conectada, preguntamos si quiere desconectarse
                cn.Close() 'Si la respuesta es SI (Yes) cerramos la conexion
                'doyPermisos(" ", 1)
            End If
        End If
    End Sub

    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'frmBusca_Vehiculo.MdiParent = Me
        'frmBusca_Vehiculo.Show()
    End Sub
End Class