Public Class Clase_Vehiculo

    '*****ATRIBUTOS DE LA TABLA VEHICULO***************************

    Protected _id_vehiculo As Integer     'PK
    Protected _vin As String
    Protected _marca As String
    Protected _modelo As String
    Protected _color As String
    Protected _anio As Integer
    Protected _tipo As String
    Protected _borrado As String
    Protected _UbicacionCompleta As String

    '********METODOS SETTER Y GETTER*******************************
    '**************************************************************
    Property id_vehiculo As Integer
        Get
            Return (_id_vehiculo)
        End Get
        Set(value As Integer)
            _id_vehiculo = value
        End Set
    End Property
    '**************************************************************
    Property vin As String
        Get
            Return (_vin)
        End Get
        Set(value As String)
            _vin = value
        End Set
    End Property
    '**************************************************************
    Property marca As String
        Get
            Return (_marca)
        End Get
        Set(value As String)
            _marca = value
        End Set
    End Property
    '**************************************************************
    Property modelo As String
        Get
            Return (_modelo)
        End Get
        Set(value As String)
            _modelo = value
        End Set
    End Property
    '**************************************************************
    Property color As String
        Get
            Return (_color)
        End Get
        Set(value As String)
            _color = value
        End Set
    End Property
    '**************************************************************
    Property anio As String
        Get
            Return (_anio)
        End Get
        Set(value As String)
            _anio = value
        End Set
    End Property
    '**************************************************************
    Property tipo As String
        Get
            Return (_tipo)
        End Get
        Set(value As String)
            _tipo = value
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
    Property UbicacionCompleta As String
        Get
            Return (_UbicacionCompleta)
        End Get
        Set(value As String)
            _UbicacionCompleta = value
        End Set
    End Property
    '**************************************************************
    '**************************************************************
    Sub New()

        _id_vehiculo = 0
        _vin = ""
        _marca = ""
        _modelo = ""
        _color = ""
        _anio = 0
        _tipo = ""
        _borrado = ""
        _UbicacionCompleta = ""

    End Sub
    '**************************************************************
    '**************************************************************
    Sub New(id_vehiculo As Integer, vin As String, marca As String, modelo As String, color As String, anio As Integer, borrado As String, ubicacionCompleta As String)

        _id_vehiculo = id_vehiculo
        _vin = vin
        _marca = marca
        _modelo = modelo
        _color = color
        _anio = anio
        _tipo = tipo
        _borrado = borrado
        _UbicacionCompleta = ubicacionCompleta

    End Sub
    '**************************************************************
    '**************************************************************
    Function buscarVehiculo(cn As ADODB.Connection) As Integer

        Dim sql As String
        Dim retorno As Integer = 0
        Dim rs As New ADODB.Recordset
        If cn.State = 0 Then
            retorno = 1
        Else

            sql = "select * from vehiculo where vin ='" & frmOperarioPatio.txt_Vin.Text & "'"

            Try
                rs.Open(sql, cn)
            Catch ex As Exception
                Return (2)
            End Try
            If rs.RecordCount = 0 Then
                retorno = 3
            Else
                _marca = rs("marca").Value
                _modelo = rs("modelo").Value
                _color = rs("color").Value
                _anio = rs("anio").Value
                _tipo = rs("tipo").Value
                _id_vehiculo = rs("id_vehiculo").Value
                frmInspeccion.lblVinMostrar.Text = _vin
                frmInspeccion.lblId_vehiculoMostrar.Text = _id_vehiculo

            End If
        End If
        rs = Nothing
        Return (retorno)
    End Function
    '**************************************************************
    '**************************************************************
    Function buscarVehiculo1(cn As ADODB.Connection) As Integer

        Dim sql As String
        Dim retorno As Integer = 0
        Dim rs As New ADODB.Recordset
        If cn.State = 0 Then
            retorno = 1
        Else

            sql = "select * from vehiculo where vin ='" & frmBuscaVehiculoAdmin.txt_Vin.Text & "'"

            Try
                rs.Open(sql, cn)
            Catch ex As Exception
                Return (2)
            End Try
            If rs.RecordCount = 0 Then
                retorno = 3
            Else
                _marca = rs("marca").Value
                _modelo = rs("modelo").Value
                _color = rs("color").Value
                _anio = rs("anio").Value
                _tipo = rs("tipo").Value
                _id_vehiculo = rs("id_vehiculo").Value
                frmInspeccion.lblVinMostrar.Text = _vin
                frmInspeccion.lblId_vehiculoMostrar.Text = _id_vehiculo

            End If
        End If
        rs = Nothing
        Return (retorno)
    End Function
    '**************************************************************
    '**************************************************************
    Function buscarVehiculo2(cn As ADODB.Connection) As Integer

        Dim sql As String
        Dim retorno As Integer = 0
        Dim rs As New ADODB.Recordset
        If cn.State = 0 Then
            retorno = 1
        Else

            sql = "select * from vehiculo where vin ='" & frmOperarioPuerto.txt_Vin.Text & "'"

            Try
                rs.Open(sql, cn)
            Catch ex As Exception
                Return (2)
            End Try
            If rs.RecordCount = 0 Then
                retorno = 3
            Else
                _marca = rs("marca").Value
                _modelo = rs("modelo").Value
                _color = rs("color").Value
                _anio = rs("anio").Value
                _tipo = rs("tipo").Value
                _id_vehiculo = rs("id_vehiculo").Value
                frmInspeccion.lblVinMostrar.Text = _vin
                frmInspeccion.lblId_vehiculoMostrar.Text = _id_vehiculo

            End If
        End If
        rs = Nothing
        Return (retorno)
    End Function
    '**************************************************************
    '**************************************************************
    Public Sub Listar_Vehiculos()
        Dim sql As String
        sql = "select id_vehiculo, vin, marca, modelo, color, anio, tipo, situacion, localizacion from vehiculo"
        rs.Open(sql, cn)
        cargaGrilla(rs, frmListadoVehiculos.dgvListado)
        rs.Close()
    End Sub
    '**************************************************************
    '**************************************************************
    Public Sub ListarVehiculoVIN(vin As String)
        Dim sql As String
        sql = "select * from vehiculo where vin = '" & vin & "'"
        rs.Open(sql, cn)
        cargaGrilla(rs, frmListadoVehiculos.dgvListado)
        rs.Close()
    End Sub
    '**************************************************************
    '**************************************************************
    Public Sub ListarVehiculoID(id As Integer)
        Dim sql As String
        sql = "select * from vehiculo where id_vehiculo = " & id
        rs.Open(sql, cn)
        cargaGrilla(rs, frmListadoVehiculos.dgvListado)
        rs.Close()
    End Sub
    '**************************************************************
    '**************************************************************
End Class
