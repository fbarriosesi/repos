Imports AForge.Video.DirectShow
Imports AForge.Video
Imports AForge.Imaging

Public Class frmSacarFoto

    Public idInspeccion As Integer
    Public idLinea As Integer
    Public url As String

    Private Sub cmdIniciar_Click(sender As Object, e As EventArgs) Handles cmdIniciar.Click
        Dim WebcamForm As New AForge.Video.DirectShow.VideoCaptureDeviceForm
        WebcamForm.ShowDialog()
        Dim webcam As New AForge.Video.DirectShow.VideoCaptureDevice(WebcamForm.VideoDeviceMoniker)
        webcam.Start()
        vspCamara.VideoSource = webcam
        vspCamara.Start()
        cmdCapturar.Enabled = True
        cmdIniciar.Enabled = False
    End Sub

    Private Sub cmdCapturar_Click(sender As Object, e As EventArgs) Handles cmdCapturar.Click
        pbVistaPrevia.Image = vspCamara.GetCurrentVideoFrame
        cmdGuardar.Enabled = True
    End Sub

    Private Sub cmdGuardar_Click(sender As Object, e As EventArgs) Handles cmdGuardar.Click
        Dim f As New Clase_foto

        'hay que editar la ubicacion a la que corresponda
        url = "D:\Usuario\Desktop\FotoInspeccion\" & lblIDInspeccion.Text & "_" & lblIDLinea.Text & ".jpg"
        MsgBox("GUARDA EN: " & url)
        f.link = url
        Try
            pbVistaPrevia.Image.Save("" & url & "")
            f.guardarfoto(idLinea, idInspeccion, url)
            'pbVistaPrevia.Image.Save("" & url & "")
        Catch ex As Exception
            Dim salida As String = ex.ToString
        End Try

        frmInspeccion.pbFotoDanio.Image = pbVistaPrevia.Image
        vspCamara.Stop()
        frmInspeccion.cmdGuardarLinea.Enabled = False
        frmInspeccion.cmdFotografia.Enabled = False
        frmInspeccion.optChapa.Checked = False
        frmInspeccion.optNeumaticos.Checked = False
        frmInspeccion.optVidrios.Checked = False
        frmInspeccion.optChapa.Enabled = True
        frmInspeccion.optNeumaticos.Enabled = True
        frmInspeccion.optVidrios.Enabled = True
        frmInspeccion.cmdCerrar.Enabled = True
        frmInspeccion.Show()
        Me.Close()
    End Sub

    Private Sub frmSacarFoto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblIDInspeccion.Text = idInspeccion
        lblIDLinea.Text = idLinea
        cmdCapturar.Enabled = False
        cmdGuardar.Enabled = False
    End Sub

End Class

