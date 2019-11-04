Public Class frmFoto2
    Protected _inspeccion, _linea As Integer
    Property inspeccion As Integer
        Get
            Return _inspeccion
        End Get
        Set(value As Integer)
            _inspeccion = value
        End Set
    End Property

    Property linea As Integer
        Get
            Return _linea
        End Get
        Set(value As Integer)
            _linea = value
        End Set
    End Property

    Private Sub frmFoto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim f As New Clase_foto
        Dim archivo As String
        archivo = CStr(f.verfoto(inspeccion, linea))
        pbFoto.Image = Image.FromFile(archivo)
    End Sub

    Private Sub cmdVolver_Click(sender As Object, e As EventArgs) Handles cmdVolver.Click
        frmDetalles.Show()
        Me.Close()
    End Sub
End Class