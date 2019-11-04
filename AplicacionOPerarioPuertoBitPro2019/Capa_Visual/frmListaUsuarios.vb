Public Class frmListaUsuarios

    Dim e As New Clase_empleado

    Private Sub cmdVolver_Click(sender As Object, e As EventArgs) Handles cmdVolver.Click
        frmUsuarios.Show()
        Me.Close()
    End Sub

    Private Sub cmdBuscarUsuario_Click(sender As Object, e As EventArgs) Handles cmdBuscarUsuario.Click
        If txtUsuario.Text.Trim = "" Then
            ListarUsuarios()
        Else
            ListarCedula(txtCedula.Text)
        End If
    End Sub

    Private Sub cmdBuscarCedula_Click(sender As Object, e As EventArgs) Handles cmdBuscarCedula.Click
        If txtCedula.Text.Trim = "" Then
            ListarUsuarios()
        Else
            ListarUsuario(txtUsuario.Text)
        End If
    End Sub

    Private Sub frmListaUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim datoV As DataGridViewRow = DataGridView1.CurrentRow
    End Sub
    Public Sub ListarUsuarios()
        Dim sql As String
        Dim rs As New ADODB.Recordset

        sql = "select * from empleado"
        MsgBox("aqui: " & sql)
        rs.Open(sql, cn)
        cargaGrilla(rs, DataGridView1)
        rs.Close()
    End Sub
    '**************************************************************
    '**************************************************************
    Public Sub ListarUsuario(usuario As Integer)
        Dim sql As String
        sql = "select * from empleado where usuario = " & usuario
        rs.Open(sql, cn)
        cargaGrilla(rs, DataGridView1)
        rs.Close()
    End Sub
    '**************************************************************
    '**************************************************************
    Public Sub ListarCedula(cedula As Integer)
        Dim sql As String
        sql = "select * from empleado where cedula = " & cedula
        rs.Open(sql, cn)
        cargaGrilla(rs, DataGridView1)
        rs.Close()
    End Sub
    '**************************************************************
    '**************************************************************
End Class