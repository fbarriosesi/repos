Option Strict On
Imports ADODB

Public Class frmZonasSubZonas

    Public id_zona As Integer

    '*****************************************************************************************************************************
    '*****************************************************************************************************************************

    Private Sub frmZonasSubZonas_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        lblFechahora.Text = DateTime.Now.ToString
        lbl_Id_vehiculo.Text = frmOperarioPatio.txtid_vehiculo.Text
        lbl_Vin.Text = frmOperarioPatio.txt_Vin.Text

        Dim z As New Clase_Zona
        cboZona.Show()
        cboZona.Items.Clear()
        Dim rs As New ADODB.Recordset

        rs.Open("select nombre from zona", cn)
        While Not rs.EOF
            cboZona.Items.Add(rs("nombre").Value)

            rs.MoveNext()
        End While
        rs.Close()

    End Sub

    '*****************************************************************************************************************************
    '*****************************************************************************************************************************

    Private Sub cmdVolver_Click(sender As Object, e As EventArgs) Handles cmdVolver.Click

        frmOperarioPatio.Show()
        Me.Refresh()
        Me.Close()

    End Sub

    '*****************************************************************************************************************************
    '*****************************************************************************************************************************

    Private Sub cboZona_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboZona.SelectedIndexChanged


        Dim z As New Clase_Zona
        cboSubzona.Items.Clear()
        z.auxiliar = cboZona.SelectedItem.ToString()
        rs.Open("select id_zona from zona where nombre = '" & z.auxiliar & "'", cn)
        id_zona = CInt(rs("id_zona").Value)
        rs.Close()
        rs.Open("select nombre from subzona where zona = " & id_zona, cn)

        While Not rs.EOF
            cboSubzona.Items.Add(rs("nombre").Value)

            rs.MoveNext()
        End While
        rs.Close()
    End Sub

    '*****************************************************************************************************************************
    '*****************************************************************************************************************************

    Private Sub cmdAsignar_Click(sender As Object, e As EventArgs) Handles cmdAsignar.Click

        Dim z As New Clase_Zona
        Dim d As New Clase_deriva
        Dim retorno As Integer = 0
        Dim sql As String
        Dim sql2 As String
        Dim fechahora As Date

        sql = "select id_deriva from deriva" 'Averiguo el id_deriva para el insert de asignacion de vehiuclo en zonas y subzonas.
        Try
            rs.Open(sql, cn)
        Catch ex As Exception

            MsgBox("El error es: " & ex.Message)
        End Try
        If rs.RecordCount = 0 Then
            retorno = 3
            d.id_deriva = 1
        Else
            rs.MoveLast()
            d.id_deriva = CInt(rs("id_deriva").Value) + 1
        End If
        rs.Close()

        d.borrado = "f" 'Por defecto el borrado logico viene en False ('f').
        rs.Open("select id_subzona from subzona where zona = " & id_zona, cn)
        d.subzona = CInt(rs("id_subzona").Value)
        rs.Close()

        'ORDEN DE LA TABLA DERIVA
        '(id_deriva, ceduala, zona, subzona, fechahora, borrado)
        sql2 = "insert into deriva values (" & d.id_deriva & ", " & cedula & ", " & id_zona & ", " & d.subzona & ", " & fechahora & ", '" & d.borrado & "')"
        'MsgBox(sql2)

        Try
            cn.Execute(sql2)
            MsgBox("Se asigno un vehiculo a la Zona: " & id_zona & vbLf & "Se asigno el vehiculo a la subzona: " & d.subzona)
        Catch ex As Exception
            MsgBox("No se pudo asignar el vehiculo a la zona." & ex.Message)
        End Try

    End Sub

    '*****************************************************************************************************************************
    '*****************************************************************************************************************************

End Class