Public Class frmDetalles
    Dim l As New Clase_Linea
    Dim idLinea As Integer
    'Public url As String
    Dim _idInspeccion As Integer
    Property idInspeccion As Integer
        Get
            Return _idInspeccion
        End Get
        Set(value As Integer)
            _idInspeccion = value
        End Set
    End Property

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLineas.CellContentClick

        'idLinea = CInt(dgvLineas.CurrentRow.Cells(0).Value)
    End Sub

    Private Sub frmDetalles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        l.ListarLineas(idInspeccion)
    End Sub

    Private Sub cmdVolver_Click(sender As Object, e As EventArgs) Handles cmdVolver.Click
        frmListaInspecciones.Show()
        Me.Close()
    End Sub

    Private Sub cmdVerFoto_Click(sender As Object, e As EventArgs) Handles cmdVerFoto.Click
        Dim f As New frmFoto2
        MsgBox(dgvLineas.CurrentRow.Cells(0).Value)
        f.inspeccion = Val(lblIDInspeccion.Text)
        f.linea = dgvLineas.CurrentRow.Cells(0).Value
        MsgBox(f.linea)
        f.Show()
        Me.Hide()
    End Sub
End Class