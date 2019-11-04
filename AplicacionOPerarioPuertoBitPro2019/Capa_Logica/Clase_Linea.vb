Public Class Clase_Linea

    '*****ATRIBUTOS DE LA TABLA LINEA******************************

    Protected _id_linea As Integer
    Protected _inspeccion As Integer
    Protected _danio As Integer
    Protected _borrado As String

    '********METODOS SETTER Y GETTER*******************************
    Property id_linea As Integer
        Get
            Return (_id_linea)
        End Get
        Set(value As Integer)

            _id_linea = value
        End Set
    End Property
    '**************************************************************
    Property inspeccion As Integer
        Get
            Return (_inspeccion)
        End Get
        Set(value As Integer)

            _inspeccion = value
        End Set
    End Property
    '**************************************************************
    Property danio As Integer
        Get
            Return (_danio)
        End Get
        Set(value As Integer)

            _danio = value
        End Set
    End Property
    '**************************************************************
    Property borrado As String
        Get
            Return (_borrado)
        End Get
        Set(value As String)

            _borrado = value
        End Set
    End Property
    '**************************************************************
    '**************************************************************
    Sub New()

        _id_linea = 0
        _inspeccion = 0
        _danio = 0
        _borrado = ""

    End Sub
    '**************************************************************
    '**************************************************************
    Sub New(id_linea As Integer, inspeccion As Integer, danio As Integer, borrado As String)

        _id_linea = id_linea
        _inspeccion = inspeccion
        _danio = danio
        _borrado = borrado

    End Sub
    '**************************************************************
    '**************************************************************
    '**************************************************************
    Function buscarLineas() As Integer

        Dim sql As String
        Dim retorno As Integer = 0
        Dim rs As New ADODB.Recordset
        If cn.State = 0 Then
            retorno = 1
        Else
            sql = "select * from linea where inspeccion = '" & _inspeccion & "'"
            Try
                rs.Open(sql, cn)
            Catch ex As Exception
                Return (2)
                MsgBox("El error es: " & ex.Message)
            End Try
            If rs.RecordCount = 0 Then
                _id_linea = 1
            Else
                rs.MoveLast()
                _id_linea = CInt(rs("id_linea").Value) + 1
            End If
            _borrado = "f"
        End If
        rs.Close()
        retorno = _id_linea
        Return (retorno)
    End Function
    '**************************************************************
    Public Sub guardarLinea(cn As ADODB.Connection)
        _inspeccion = CInt(frmInspeccion.lblVinMostrar.Text)
        Dim sql As String
        buscarLineas()

        sql = "insert into linea values (" & _id_linea & ", " & _inspeccion & ", " & _danio & ", '" & _borrado & "')"
        Try
            cn.Execute(sql)
            frmSacarFoto.idInspeccion = _inspeccion
            frmSacarFoto.idLinea = _id_linea
            frmInspeccion.cmdFotografia.Enabled = True
        Catch ex As Exception
            MsgBox("No se pudo ingresar la linea a la inspección.")
        End Try
    End Sub
    '**************************************************************
    Public Sub ListarLineas(inspeccion As Integer)
        Dim sql As String
        Dim rs As New ADODB.Recordset
        sql = "select id_linea, descripcion from linea inner join danio on danio = id_danio where inspeccion = " & inspeccion
        Try
            'MsgBox("lista lineas: " & sql)
            rs.Open(sql, cn)
            cargaGrilla(rs, frmDetalles.dgvLineas)
        Catch ex As Exception
            MsgBox("No se pudo cargar la grilla.")
        End Try
        rs.Close()
    End Sub

End Class
