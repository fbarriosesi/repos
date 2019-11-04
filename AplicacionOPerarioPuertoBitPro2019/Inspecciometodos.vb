Public Class Inspecciometodos

    Protected _descripciondanio As String
    Protected _tipodanio As String
    Protected _idinspeccion As Integer
    Property descripcion_danio As String
        Get
            Return (_descripciondanio)
        End Get
        Set(value As String)
            _descripciondanio = value
        End Set
    End Property

    Property tipo_danio As String
        Get
            Return (_tipodanio)
        End Get
        Set(value As String)
            _tipodanio = value
        End Set
    End Property

    Property id_inspeccion As Integer
        Get
            Return (_idinspeccion)
        End Get
        Set(value As Integer)
            _idinspeccion = value
        End Set
    End Property

    Sub New() ' la sintaxis 'new'  hace referencia al metodo constructor por defecto
        _tipodanio = ""
        _descripciondanio = ""
        _idinspeccion = 0
    End Sub


    Function guardar(cn As ADODB.Connection, inserta As Boolean) As Integer
        Dim retorno As Integer = 0
        Dim sql As String
        If cn.state = 0 Then ' si la conexion esta cerrrada
            retorno = 1
        Else
            If inserta Then 'si modifica
                sql = "insert into linea (tipo_danio) values (" & _tipodanio &
                    "; insert into linea (descripcion_danio) values (" & _descripciondanio &
                    "; insert into inspeccion (id_inspeccion) values (" & _idinspeccion & "')"

            End If
            Try
                cn.execute(sql)
            Catch ex As Exception
                Return (2)
            End Try
        End If
        Return (retorno)
    End Function
End Class
