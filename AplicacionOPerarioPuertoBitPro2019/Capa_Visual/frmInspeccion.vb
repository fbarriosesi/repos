Imports ADODB

Public Class frmInspeccion
    Dim rs As New ADODB.Recordset
    '*****************************************************************************************************************************
    '*****************************************************************************************************************************

    Private Sub cmdCerrar_Click(sender As Object, e As EventArgs) Handles cmdCerrar.Click
        Select Case rolusuario
            Case 1000 'Administrador hay que ver a donde tirarlo 
                frmMenu.Show()

            Case 1001 'Operario de Puerto
                frmOperarioPuerto.Show()

            Case 1002 'Operario de Patio
                frmOperarioPatio.Show()

        End Select
        Me.Close()
    End Sub

    '*****************************************************************************************************************************
    '*****************************************************************************************************************************


    Private Sub optChapa_CheckedChanged(sender As Object, e As EventArgs) Handles optChapa.CheckedChanged

        cboDanios.Items.Clear()
        rs.Open("select * from danio where tipo = 'Chapa - Pintura'", cn)
        While Not rs.EOF
            cboDanios.Items.Add(rs("descripcion").Value)
            rs.MoveNext()

        End While
        rs.Close()


    End Sub

    '*****************************************************************************************************************************
    '*****************************************************************************************************************************

    Private Sub optVidrios_CheckedChanged(sender As Object, e As EventArgs) Handles optVidrios.CheckedChanged

        cboDanios.Items.Clear()
        rs.Open("select * from danio where tipo = 'Vidrios'", cn)
        While Not rs.EOF
            cboDanios.Items.Add(rs("descripcion").Value)
            rs.MoveNext()
        End While
        rs.Close()

    End Sub

    '*****************************************************************************************************************************
    '*****************************************************************************************************************************

    Private Sub optNeumaticos_CheckedChanged(sender As Object, e As EventArgs) Handles optNeumaticos.CheckedChanged

        cboDanios.Items.Clear()
        rs.Open("select * from danio where tipo = 'Neumaticos'", cn)
        While Not rs.EOF
            cboDanios.Items.Add(rs("descripcion").Value)
            rs.MoveNext()
        End While
        rs.Close()

    End Sub

    ''*****************************************************************************************************************************
    ''*****************************************************************************************************************************

    Private Sub cmdGuardarInspeccion_Click(sender As Object, e As EventArgs) Handles cmdGuardarInspeccion.Click
        Dim i As New Clase_Inspeccion
        Dim v As New Clase_Vehiculo
        i.cedula = cedula 'la obtengo en el modulo de permisos como pública
        i.vehiculo = CInt(lblId_vehiculoMostrar.Text)
        i.guardarInspección()
        lblId_Vin_vehiculo.Text = "ID de Inspección: "
        lblVinMostrar.Text = i.id_inspeccion
        cmdCerrar.Enabled = False
        cmdGuardarInspeccion.Enabled = False
        optChapa.Enabled = True
        optNeumaticos.Enabled = True
        cboDanios.Enabled = True
        optVidrios.Enabled = True
        cmdGuardarLinea.Enabled = True
    End Sub

    ''*****************************************************************************************************************************
    ''*****************************************************************************************************************************

    Private Sub frmInspeccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        optChapa.Enabled = False
        optNeumaticos.Enabled = False
        optVidrios.Enabled = False
        cboDanios.Enabled = False
        cmdGuardarLinea.Enabled = False
        cmdFotografia.Enabled = False
    End Sub

    ''*****************************************************************************************************************************
    ''*****************************************************************************************************************************

    Private Sub cmdGuardarLinea_Click(sender As Object, e As EventArgs) Handles cmdGuardarLinea.Click
        Dim l As New Clase_Linea
        Dim d As New Clase_Danio
        Dim i As New Clase_Inspeccion
        l.inspeccion = i.id_inspeccion
        l.danio = d.buscarDanio(cboDanios.SelectedItem.ToString)
        l.borrado = "f"
        l.guardarLinea(cn)
        cmdFotografia.Enabled = True
        pbFotoDanio.Image = Nothing
        cmdGuardarInspeccion.Enabled = False
        cmdGuardarLinea.Enabled = False
        optChapa.Enabled = False
        optVidrios.Enabled = False
        optNeumaticos.Enabled = False
    End Sub

    ''*****************************************************************************************************************************
    ''*****************************************************************************************************************************

    Private Sub cmdFotografia_Click(sender As Object, e As EventArgs) Handles cmdFotografia.Click
        frmSacarFoto.Show()
        cmdFotografia.Enabled = False
        Me.Hide()
    End Sub
    '*****************************************************************************************************************************
    '*****************************************************************************************************************************

    Private Sub cboDanios_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDanios.SelectedIndexChanged
        cmdGuardarLinea.Enabled = True
    End Sub
    '*****************************************************************************************************************************
    '*****************************************************************************************************************************

End Class