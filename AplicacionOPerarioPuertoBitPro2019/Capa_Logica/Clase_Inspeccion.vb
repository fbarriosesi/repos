Imports ADODB

Public Class Clase_Inspeccion

    Dim c As New Clase_Linea
    Dim l As New Clase_lote
    Dim n As New Clase_Vehiculo


    '*****ATRIBUTOS DE LA TABLA INSPECCION**************************

    Protected _id_inspeccion As Integer
    Protected _cedula As Integer
    Protected _vehiculo As Integer
    Protected _fechahora As Date
    Protected _borrado As String
    Protected _danio As Integer

    '********METODOS SETTER Y GETTER*******************************
    Property id_inspeccion As Integer
        Get
            Return (_id_inspeccion)
        End Get
        Set(value As Integer)
            _id_inspeccion = value
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
    Property vehiculo As Integer
        Get
            Return (_vehiculo)
        End Get
        Set(value As Integer)

            _vehiculo = value
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

    Property danio As Integer
        Get
            Return _danio
        End Get
        Set(value As Integer)
            _danio = value
        End Set
    End Property

    '**************************************************************
    '**************************************************************
    Sub New()
        _id_inspeccion = 0
        _cedula = 0
        _vehiculo = 0
        _borrado = ""
    End Sub
    '**************************************************************
    '**************************************************************
    Sub New(id_inspecicon As Integer, cedula As Integer, vehiculo As Integer, borrado As String)
        _id_inspeccion = id_inspecicon
        _cedula = cedula
        _vehiculo = vehiculo
        _borrado = borrado
    End Sub
    '**************************************************************
    '**************************************************************
    Function buscarInspeccion() As Integer

        Dim sql As String
        Dim retorno As Integer = 0
        Dim rs As New ADODB.Recordset
        If cn.State = 0 Then
            retorno = 1
        Else
            sql = "select * from inspeccion"
            Try
                rs.Open(sql, cn)
            Catch ex As Exception
                Return (2)
            End Try
            If rs.RecordCount = 0 Then
                _id_inspeccion = 1
            Else
                rs.MoveLast()
                _id_inspeccion = CInt(rs("id_inspeccion").Value) + 1
            End If
        End If
        c.inspeccion = _id_inspeccion
        _borrado = "f"
        rs.Close()
        Return (retorno)
    End Function
    '**************************************************************
    '**************************************************************
    Public Sub guardarInspección()
        Dim retorno As Integer = 0
        Dim sql As String

        'EJECUTO TODOS LAS FUNCIONES DE SELEECT DENTRO DE ESTA FUNCION GUARDAR PARA TENER LOS DATOS ACTUALIZADOS
        'Y QUE NO DE TIEMPO A QUE OTRO USUARIO HAGA LO MISMO, ASI, SE HACE EL SELECT Y DE FORMA INSTANTANEA SE GUARDA:


        buscarInspeccion()
        c.inspeccion = _id_inspeccion

        'ORDEN DE LA TABLA INSPECCION
        '(id_inspeccion, cedula, vehiculo, fechahora, borrado)
        sql = "insert into inspeccion values (" & _id_inspeccion & ", " & _cedula & ", " & _vehiculo & ", current, '" & _borrado & "')"
        MsgBox("SQL DE GUARDAR INSPECCION: " & sql)
        Try
            cn.Execute(sql)
        Catch ex As Exception
            MsgBox("No se pudo guardar la inspeccón")
        End Try


    End Sub
    '**************************************************************
    '**************************************************************

    Public Function ListarInspecciones(dato As Integer)
        Dim sql As String
        Dim retorno As Integer
        sql = "select id_inspeccion , cedula , vehiculo , fechahora from inspeccion where vehiculo =" & dato
        Try
            rs.Open(sql, cn)
            cargaGrilla(rs, frmListaInspecciones.dgvInspecciones)
        Catch ex As Exception
            MsgBox("No se pudo cargar el listado de inspecciones")
        End Try
        rs.Close()
        Return retorno = 0
    End Function

End Class