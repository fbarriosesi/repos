Imports QRCoder

Public Class frmQRCode
    Private Sub frmQRCode_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim obj As New frmOperarioPatio 'CREO EL OBJETO DE LA frmOperarioPatio PARA TRAER EL txtId_Vehiculo.
        'Dim auxIdVehiculo As String


        Dim gen As New QRCodeGenerator 'CREO UN OBJETO PARA GENERAR LOS QR.
        Dim data = gen.CreateQrCode(obj.txtId_Vehiculo.Text, QRCodeGenerator.ECCLevel.Q) 'LE PASO AL OBJETO LOS PARAMETROS.
        Dim code As New QRCode(data)
        QRpic.Image = code.GetGraphic(6) 'EN LA CASILLA DE IMAGEN DESPLIEGO EL RESULTADO DE LA IMAGEN DEL QR GENERADO.


    End Sub

    Private Sub cmdGuardarQR_Click(sender As Object, e As EventArgs) Handles cmdGuardarQR.Click
        'SI EL USUARIO PRESIONA GUARDAR SE TOMARA LA IMAGEN DEL QR GENERADA Y SE GUARDARA ASOCIADA AL 
        'ID DEL VEHICULO EN SU TUPLA Y TABLA CORRESPONDIENTE.


    End Sub

    Private Sub SaveFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk

        'USAMOS UN TRY CATCH PARA CORROBORAR QUE NO HAYAN ERRORES Y CREAMOS EL EVENTO NECESARIO PARA QUE CUANDO EL USUARIO
        'PRESIONE EL BOTON GUARDAR SE GENERE EL PROCESO DE UNA VENTANA QUE NOS PERMITA ELEGIR DONDE GUARDAR LA IMAGEN.
        Try
            Dim img As New Bitmap(QRpic.Image)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    Private Sub QRpic_Click(sender As Object, e As EventArgs) Handles QRpic.Click
        SaveFileDialog1.ShowDialog() 'NOS PERMITE GUARDAR EL QR COMO PNG EN EL HOST.
    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        frmOperarioPatio.Show()
        Me.Close()
    End Sub
End Class