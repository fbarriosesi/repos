Public Class Clase_transporta

    '*****ATRIBUTOS DE LA TABLA TRANSPORTA*************************

    Protected _id_transporta As Integer
    Protected _lote As Integer
    Protected _cedula As Integer
    Protected _nombre As String
    Protected _fechahora_inicio As Date
    Protected _fechahora_final As Date
    Protected _borrado As String

    '********METODOS SETTER Y GETTER*******************************
    '**************************************************************
    Property id_transporta As Integer
        Get
            Return (_id_transporta)
        End Get
        Set(value As Integer)
            _id_transporta = value
        End Set
    End Property
    '**************************************************************
    Property lote As Integer
        Get
            Return (_lote)
        End Get
        Set(value As Integer)
            _lote = value
        End Set
    End Property
    '**************************************************************
    Property cedula As Integer
        Get
            Return (_cedula)
        End Get
        Set(value As Integer)
            _cedula = value
        End Set
    End Property
    '**************************************************************
    Property nombre As String
        Get
            Return (_nombre)
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property
    '**************************************************************
    Property fechahora_inicio As Date
        Get
            Return (_fechahora_inicio)
        End Get
        Set(value As Date)
            _fechahora_inicio = value
        End Set
    End Property
    '**************************************************************
    Property fechahora_final As Date
        Get
            Return (_fechahora_final)
        End Get
        Set(value As Date)
            _fechahora_final = value
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

        _id_transporta = 0
        _lote = 0
        _cedula = 0
        _nombre = ""
        _fechahora_inicio = DateTime.Now
        _fechahora_final = DateTime.Now
        _borrado = ""

    End Sub
    '**************************************************************
    '**************************************************************
    Sub New(id_transporta As Integer, lote As Integer, cedula As Integer, nombre As String, fechahora_inicio As Date, fechahora_final As Date, borrado As String)
        _id_transporta = id_transporta
        _lote = lote
        _cedula = cedula
        _nombre = nombre
        _fechahora_inicio = fechahora_inicio
        _fechahora_final = fechahora_final
        _borrado = borrado
    End Sub
    '**************************************************************
    '**************************************************************
    Public Sub ListarLotes()
        Dim sql As String
        Dim rs As New ADODB.Recordset

        sql = "select id_lote, count (lote) from lote left join lotecargado on id_lote = lote
where id_lote = all (select id_lote from transporta where fechahorafinal is null) group by id_lote
having count(lote) = 10 order by id_lote"
        MsgBox("aqui: " & sql)
        rs.Open(sql, cn)
        _lote = rs("id_lote").Value
        cargaGrilla(rs, frmTransportista.dgvLotes)
        rs.Close()
    End Sub

    Public Sub IniciarViaje()
        Dim sql As String
        sql = "insert into transporta (id_transporta, lote, cedula, fechahorainicio, borrado) values (" & _id_transporta & ", " & _lote & ", " & Permisos.cedula & ", current, 'f')"
        MsgBox("El sql del insert de iniciar viaje: " & sql)
        Try
            cn.Execute(sql, cn)
        Catch ex As Exception
            MsgBox("Error:" & ex.Message)
        End Try
    End Sub

    Public Sub ObtenerId()
        rs.Open("select * from transporta", cn)
        If rs.RecordCount = 0 Then
            _id_transporta = 1
        Else
            rs.MoveLast()
            _id_transporta = CInt(rs("id_transporta").Value) + 1
        End If
    End Sub

    Public Sub FinalizarViaje()
        Dim sql As String
        sql = "update transporta set fechahorafinal = current where id_transporta =" & _id_transporta
        MsgBox("El sql del update de finalizar viaje: " & sql)
        Try
            cn.Execute(sql, cn)

        Catch ex As Exception
            MsgBox("Error:" & ex.Message)
        End Try

    End Sub

End Class
