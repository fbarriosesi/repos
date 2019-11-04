Public Class frmInspeccion
    Private Sub optChapa_CheckedChanged(sender As Object, e As EventArgs) Handles optChapa.CheckedChanged

        If optChapa.Checked Then
            'gbDaños2.Hide()
            cboOtros.Hide()
            cboDaños.Show()
            cboDaños.Items.Clear()
            cboDaños.Items.Add("Rayon puerta delantera lado izquierdo")
            cboDaños.Items.Add("Rayon puerta trasera lado izquierdo")
            cboDaños.Items.Add("Rayon puerta delantera lado derecho")
            cboDaños.Items.Add("Rayon puerta trasera lado derecho")
            cboDaños.Items.Add("Rayon parte delantera")
            cboDaños.Items.Add("Rayon parte trasera")
            cboDaños.Items.Add("Abolladura puerta delantera lado izquierdo")
            cboDaños.Items.Add("Abolladura puerta trasera lado izquierdo")
            cboDaños.Items.Add("Abolladura puerta delantera lado derecho")
            cboDaños.Items.Add("Abolladura puerta trasera lado derecho")
            cboDaños.Items.Add("Abolladura parte delantera")
            cboDaños.Items.Add("Abolladura parte trasera")
            cboDaños.Items.Add("Rayon y abolladura puerta delantera lado izquierdo")
            cboDaños.Items.Add("Rayon y abolladura puerta trasera lado izquierdo")
            cboDaños.Items.Add("Rayon y abodalladura puerta delantera lado derecho")
            cboDaños.Items.Add("Rayon y abolladura puerta trasera lado derecho")
            cboDaños.Items.Add("Rayon y abolladura parte delantera")
            cboDaños.Items.Add("Rayon y abolladura parte trasera")
            cboDaños.Items.Add("Perforacion de chapa puerta delantera lado izquierdo")
            cboDaños.Items.Add("Perforacion de chapa puerta trasera lado izquiero")
            cboDaños.Items.Add("Perforacion de chapa puerta delantera lado derecho")
            cboDaños.Items.Add("Perforacion de chapa puerta trasera lado derecho")
            cboDaños.Items.Add("Perforacion de chapa parte delantera")
            cboDaños.Items.Add("Perforacion de chapa parte trasera")
        End If
    End Sub
    Private Sub optVidrios_CheckedChanged(sender As Object, e As EventArgs) Handles optVidrios.CheckedChanged

        If optVidrios.Checked Then
            'gbDaños2.Hide()
            cboOtros.Hide()
            cboDaños.Show()
            cboDaños.Items.Clear()
            cboDaños.Items.Add("Rotura vidrio delantero lado izquierdo")
            cboDaños.Items.Add("Rotura vidrio trasero lado izquierdo")
            cboDaños.Items.Add("Rotura vidrio delantero lado derecho")
            cboDaños.Items.Add("Rotura vidriotrasero lado derecho")
            cboDaños.Items.Add("Rotura vidrio parte delantera")
            cboDaños.Items.Add("Rotura vidrio parte trasera")
            cboDaños.Items.Add("Vidrio grietado delantero lado izquierdo")
            cboDaños.Items.Add("Vidrio grietado trasero lado izquierdo")
            cboDaños.Items.Add("Vidrio grietado delantero lado derecho")
            cboDaños.Items.Add("Vidrio grietado trasero lado derecho")
            cboDaños.Items.Add("Vidrio grietado parte delantera")
            cboDaños.Items.Add("Vidrio grietado parte trasera")
            cboDaños.Items.Add("Vidrio rayado delantero lado izquierdo")
            cboDaños.Items.Add("Vidrio rayado trasero lado izquierdo")
            cboDaños.Items.Add("Vidrio rayado delantero lado derecho")
            cboDaños.Items.Add("Vidrio rayado trasero lado derecho")
            cboDaños.Items.Add("Vidrio rayado parte delantera")
            cboDaños.Items.Add("Vidrio rayado parte trasera")
            cboDaños.Items.Add("Lamina de seguridad dañada delantera lado izquierdo")
            cboDaños.Items.Add("Lamina de seguridad dañada trasera lado izquiero")
            cboDaños.Items.Add("Lamina de seguridad dañada delantera lado derecho")
            cboDaños.Items.Add("Lamina de seguridad dañada trasera lado derecho")
            cboDaños.Items.Add("Lamina de seguridad dañada delantera")
            cboDaños.Items.Add("Lamina de seguridad dañada trasera")
            cboDaños.Items.Add("Rotura vidrio farol delantero izquierdo")
            cboDaños.Items.Add("Rotura vidrio farol delantero derecho")
            cboDaños.Items.Add("Rotura vidrio farol trasero izquierdo")
            cboDaños.Items.Add("Rotura vidrio farol trasero derecho")
            cboDaños.Items.Add("Vidrio grietado farol delantero izquierdo")
            cboDaños.Items.Add("Vidrio grietado farol delantero derecho")
            cboDaños.Items.Add("Vidrio grietado farol trasero izquierdo")
            cboDaños.Items.Add("Vidrio grietado farol trasero derecho")
            cboDaños.Items.Add("Vidrio rayado farol delantero izquierdo")
            cboDaños.Items.Add("Vidrio rayado farol delantero derecho")
            cboDaños.Items.Add("Vidrio rayado farol trasero izquierdo")
            cboDaños.Items.Add("Vidrio rayado farol trasero izquierdo")
        End If
    End Sub

    Private Sub optNeumaticos_CheckedChanged(sender As Object, e As EventArgs) Handles optNeumaticos.CheckedChanged
        If optNeumaticos.Checked Then
            'gbDaños2.Hide()
            cboOtros.Hide()
            cboDaños.Show()
            cboDaños.Items.Clear()
            cboDaños.Items.Add("Neumatico delantero izquierdo desinflado")
            cboDaños.Items.Add("Neumatico delantero derecho desinflado")
            cboDaños.Items.Add("Neumatico trasero izquierdo desinflado")
            cboDaños.Items.Add("Neumatico trasero derecho desinflado")
            cboDaños.Items.Add("Llanta rota de neumatico delantero izquierdo")
            cboDaños.Items.Add("LLanta rota de neumatico delantero derecho")
            cboDaños.Items.Add("Llanta rota de neumatico trasero izquierdo")
            cboDaños.Items.Add("Llanta rota de neumatico trasero derecho")
            cboDaños.Items.Add("Tasa rota de neumatico delantero izquierdo")
            cboDaños.Items.Add("Tasa rota de neumatico delantero derecho")
            cboDaños.Items.Add("Tasa rota de neumatico trasero izquierdo")
            cboDaños.Items.Add("Tasa rota de neumatico trasero derecho")
            cboDaños.Items.Add("Tasa y llanta rota de nuematico delantero izquierdo")
            cboDaños.Items.Add("Tasa y llanta rota de nuematico delantero derecho")
            cboDaños.Items.Add("Tasa y llanta rota de nuematico trasero izquierdo")
            cboDaños.Items.Add("Tasa y llanta rota de nuematico trasero izquierdo")
            cboDaños.Items.Add("Neumatico delantero izquierdo roto")
            cboDaños.Items.Add("Neumatico delantero derecho roto")
            cboDaños.Items.Add("Neumatico trasero izquierdo roto")
            cboDaños.Items.Add("Neumatico trasero derecho roto")
        End If
    End Sub
    Private Sub optOtros_CheckedChanged(sender As Object, e As EventArgs) Handles optOtros.CheckedChanged
        If optOtros.Checked Then
            'gbDaños2.Hide()
            cboDaños.Hide()
            cboOtros.Show()
            cboOtros.Items.Add(cboOtros.Text)

        End If
    End Sub

    Private Sub cmdMas_Click(sender As Object, e As EventArgs) Handles cmdMas.Click
        'gbDaños2.Show()
    End Sub

    Private Sub cmdMenos_Click(sender As Object, e As EventArgs) Handles cmdMenos.Click
        'gbDaños2.Hide()
    End Sub

    Private Sub cmdGuardar_Click(sender As Object, e As EventArgs) Handles cmdGuardar.Click
        Dim c As New Inspecciometodos
        Dim cont As Integer = 0
        c.tipo_danio = optChapa.Text
        c.descripcion_danio = cboOtros.Text
        c.id_inspeccion = lblnumeroInspeccion.Text
        lblnumeroInspeccion.Text = cont
        cont = cont + 1

        Select Case c.guardar(cn.cmdGuardar.Enable)
            Case 0
                gbDaños.Visible = True
            Case 1
                MsgBox("Se perdio la sesion, debe loguearse nuevamente")
            Case Else
                MsgBox("Hubo errores al efectuar operacion")
        End Select

        cont = cont + 1
        lblnumeroInspeccion.Text = cont

    End Sub
End Class