Public Class Clase_foto

    '*****ATRIBUTOS DE LA TABLA FOTO*******************************

    Protected _id_foto As Integer
    Protected _linea As Integer
    Protected _inspeccion As Integer
    Protected _link As String
    Protected _borrado As String

    '********METODOS SETTER Y GETTER*******************************
    Property id_foto As Integer
        Get
            Return (_id_foto)
        End Get
        Set(value As Integer)
            _id_foto = value
        End Set
    End Property
    '**************************************************************
    Property linea As Integer
        Get
            Return (_linea)
        End Get
        Set(value As Integer)
            _linea = value
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
    Property link As String
        Get
            Return (_link)
        End Get
        Set(value As String)
            _link = value
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

        _id_foto = 0
        _linea = 0
        _inspeccion = 0
        _link = ""
        _borrado = ""

    End Sub
    '**************************************************************
    '**************************************************************
    Sub New(id_foto As Integer, linea As Integer, inspeccion As Integer, link As Integer, borrado As String)

        _id_foto = id_foto
        _linea = linea
        _inspeccion = inspeccion
        _link = link
        borrado = borrado

    End Sub
    '**************************************************************
    '**************************************************************
    Public Sub buscarfoto()
        Dim rs As New ADODB.Recordset
        Try
            rs.Open("select id_foto from foto", cn)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        If rs.RecordCount = 0 Then
            _id_foto = 1
        Else
            rs.MoveLast()
            _id_foto = CInt(rs("id_foto").Value) + 1
        End If
        'MsgBox("ID FOTO: " & _id_foto) 'funcionando
        rs.Close()

    End Sub

    '**************************************************************
    '**************************************************************
    Public Sub guardarfoto(linea As Integer, inspeccion As Integer, link As String)
        buscarfoto()
        Dim rs As New ADODB.Recordset
        Dim sql As String = "insert into foto (id_foto, linea, inspeccion, link, borrado) values (" & _id_foto & ", " & linea & ", " & inspeccion & ", '" & link & "', 'f')"
        Try
            rs.Open("insert into foto (id_foto, linea, inspeccion, link, borrado) values (" & _id_foto & ", " & linea & ", " & inspeccion & ", '" & link & "', 'f')", cn)
            'MsgBox("La foto se guardó correctamente. GF")
        Catch ex As Exception
            MsgBox("No se pudo guardar la foto. GF")
        End Try
        rs.Close()
    End Sub


    '**************************************************************
    '**************************************************************
    Function verfoto(id_inspeccion As Integer, id_linea As Integer) As String
        Dim retorno As String
        Dim rs As New ADODB.Recordset
        Dim sql As String = "select link from foto where linea = " & id_linea & " and inspeccion = " & id_inspeccion
        Try
            'MsgBox(sql)
            rs.Open(sql, cn)
        Catch ex As Exception
            MsgBox("Error al encontrar la foto para mostrar.")
        End Try
        retorno = rs("link").Value
        rs.Close()
        Return retorno
    End Function
    '**************************************************************
    '**************************************************************
End Class
