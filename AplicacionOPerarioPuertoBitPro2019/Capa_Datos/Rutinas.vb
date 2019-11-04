Module Rutinas

    Public cn As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public sql As String

    Public Sub cargaGrilla(rs As ADODB.Recordset, ByRef dgvLista As DataGridView)
        Dim cantcolumnasgrilla As Integer
        Dim contador As Integer = 0
        If rs.State <> 0 Then
            cantcolumnasgrilla = dgvLista.Columns.GetColumnCount(DataGridViewElementStates.Visible)
            If rs.Fields.Count >= cantcolumnasgrilla Then
                dgvLista.Rows.Clear()
                While Not rs.EOF
                    dgvLista.Rows.Add()
                    For i = 0 To cantcolumnasgrilla - 1
                        dgvLista.Item(i, contador).Value = rs(i).Value
                    Next
                    contador += 1
                    rs.MoveNext()
                End While
            End If
        End If
    End Sub

End Module
