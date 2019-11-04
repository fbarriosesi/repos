Imports QRCoder

Public Class frmOperarioPatio

    Public resultado As MsgBoxResult

    '*****************************************************************************************************************************
    '*****************************************************************************************************************************

    Private Sub cmdInspeccion_Click(sender As Object, e As EventArgs) Handles cmdInspeccion.Click

        frmInspeccion.Show()
        frmInspeccion.lblId_vehiculoMostrar.Text = txtid_vehiculo.Text
        frmInspeccion.lblVinMostrar.Text = txt_Vin.Text
        Me.Hide()
    End Sub

    '*****************************************************************************************************************************
    '***SI PULSA ENTER, EJECUTA ACCION DEL BOTON BUSCAR***************************************************************************
    '*****************************************************************************************************************************

    Private Sub txt_Vin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Vin.KeyPress

        If Asc(e.KeyChar) = 13 Then
            Dim c As New Clase_Vehiculo

            c.vin = txt_Vin.Text
            txt_Vin.Text = c.vin

            Select Case c.buscarVehiculo(cn)
                Case 0 'SE BUSCO Y SE ENCONTRO
                    txt_marca.Text = c.marca
                    txt_modelo.Text = c.modelo
                    txt_color.Text = c.color
                    txt_anio.Text = c.anio
                    txt_tipovehiculo.Text = c.tipo
                    txtid_vehiculo.Text = c.id_vehiculo

                Case 1
                    MsgBox("Se ha perdido la conexion, debe loguearse nuevamente")
                Case 3
                    MsgBox(" NO ENCONTRADO")
                Case Else
                    MsgBox("Hubo errores al efectuar operacion")
            End Select
        End If

    End Sub

    '*****************************************************************************************************************************
    '*****************************************************************************************************************************

    Private Sub cmdQRGen_Click(sender As Object, e As EventArgs) Handles cmdQRGen.Click

        frmQRCode.Show()
        Me.Hide()

    End Sub

    '*****************************************************************************************************************************
    '*****************************************************************************************************************************

    Private Sub cmdBuscar_Click(sender As Object, e As EventArgs) Handles cmdBuscar.Click

        Dim c As New Clase_Vehiculo

        c.vin = txt_Vin.Text
        txt_Vin.Text = c.vin

        Select Case c.buscarVehiculo(cn)
            Case 0 'SE BUSCO Y SE ENCONTRO
                txt_marca.Text = c.marca
                txt_modelo.Text = c.modelo
                txt_color.Text = c.color
                txt_anio.Text = c.anio
                txt_tipovehiculo.Text = c.tipo
                txtid_vehiculo.Text = c.id_vehiculo

            Case 1
                MsgBox("Se ha perdido la conexion, debe loguearse nuevamente")
            Case 3
                MsgBox(" NO ENCONTRADO")
            Case Else
                MsgBox("Hubo errores al efectuar operacion")
        End Select

    End Sub

    '*****************************************************************************************************************************
    '*****************************************************************************************************************************

    Private Sub cmdZonaSubZona_Click(sender As Object, e As EventArgs) Handles cmdZonaSubZona.Click
        frmZonasSubZonas.Show()
        Me.Hide()
    End Sub

    '*****************************************************************************************************************************
    '*****************************************************************************************************************************

    Private Sub frmOperarioPatio_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        resultado = CType(MessageBox.Show("Desea salir de la aplicacion?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question), MsgBoxResult)

        If resultado = MsgBoxResult.No Then
            e.Cancel = True
        Else
            e.Cancel = False
        End If

    End Sub

    '*****************************************************************************************************************************
    '*****************************************************************************************************************************

End Class