Imports QRCoder

Public Class frmBuscaVehiculoAdmin

    Public resultado As MsgBoxResult

    '*****************************************************************************************************************************
    '***SI PULSA ENTER, EJECUTA ACCION DEL BOTON BUSCAR***************************************************************************
    '*****************************************************************************************************************************


    Private Sub txt_Vin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Vin.KeyPress

        If Asc(e.KeyChar) = 13 Then
            Dim c As New Clase_Vehiculo
            Dim l As New Clase_lote

            c.vin = txt_Vin.Text
            txt_Vin.Text = c.vin

            Select Case c.buscarVehiculo1(cn)
                Case 0 'SE BUSCO Y SE ENCONTRO
                    txt_marca.Text = c.marca
                    txt_modelo.Text = c.modelo
                    txt_color.Text = c.color
                    txt_anio.Text = c.anio
                    txt_tipovehiculo.Text = c.tipo
                    txtid_vehiculo.Text = c.id_vehiculo
                    'txtLote.Text = l.AgregarLote1()
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

    Private Sub cmdUbicar_Click(sender As Object, e As EventArgs)

        frmUbicacionMaps.Show()
        Me.Close()

    End Sub

    '*****************************************************************************************************************************
    '*****************************************************************************************************************************

    Private Sub txtURL_TextChanged(sender As Object, e As EventArgs)

    End Sub

    '*****************************************************************************************************************************
    '*****************************************************************************************************************************

    Private Sub cmdBuscar_Click_1(sender As Object, e As EventArgs) Handles cmdBuscar.Click

        Dim c As New Clase_Vehiculo
        Dim l As New Clase_lote

        c.vin = txt_Vin.Text
        txt_Vin.Text = c.vin

        Select Case c.buscarVehiculo1(cn)
            Case 0 'SE BUSCO Y SE ENCONTRO
                txt_marca.Text = c.marca
                txt_modelo.Text = c.modelo
                txt_color.Text = c.color
                txt_anio.Text = c.anio
                txt_tipovehiculo.Text = c.tipo
                txtid_vehiculo.Text = c.id_vehiculo
                'txtLote.Text = l.AgregarLote1()

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

    Private Sub cmdQRGen_Click_1(sender As Object, e As EventArgs) Handles cmdQRGen.Click

        frmQRCode.Show()
        Me.Hide()

    End Sub

    Private Sub cmdUbicarVehiculo_Click(sender As Object, e As EventArgs) Handles cmdUbicarVehiculo.Click

        frmUbicacionMaps.Show()
        Me.Hide()

    End Sub


    'Private Sub frmBuscaVehiculoAdmin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

    '    resultado = CType(MessageBox.Show("Desea salir de la aplicacion?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question), MsgBoxResult)

    '    If resultado = MsgBoxResult.No Then
    '        e.Cancel = True
    '    Else
    '        e.Cancel = False
    '    End If

    'End Sub

    Private Sub cmdVolver_Click(sender As Object, e As EventArgs) Handles cmdVolver.Click

        frmVehiculos.Show()
        Me.Refresh()
        Me.Close()

    End Sub

    '*****************************************************************************************************************************
    '*****************************************************************************************************************************

End Class