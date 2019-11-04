Public Class Clase_lote

    Public lotecargado As Integer
    Public vehiculo As Integer

    '*****ATRIBUTOS DE LA TABLA LINEA******************************

    Protected _id_lote As Integer
    Protected _nombre As String
    Protected _descripcion As String
    Protected _cedula As Integer
    Protected _borrado As String

    '********METODOS SETTER Y GETTER*******************************
    Property id_lote As Integer
        Get
            Return (_id_lote)
        End Get
        Set(value As Integer)

            _id_lote = value
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
    Property descripcion As String
        Get
            Return (_descripcion)
        End Get
        Set(value As String)

            _descripcion = value
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

        _id_lote = 0
        _nombre = ""
        _descripcion = ""
        _cedula = 0
        _borrado = ""

    End Sub
    '**************************************************************
    '**************************************************************

    Sub New(id_lote As Integer, nombre As String, descripcion As String, cedula As Integer, borrado As String)

        _id_lote = id_lote
        _nombre = nombre
        _descripcion = descripcion
        _cedula = cedula
        _borrado = borrado

    End Sub

    '**************************************************************
    '**************************************************************

    Function buscarLote(cn As ADODB.Connection) As Integer
        Dim c As New Clase_Inspeccion
        Dim sql As String
        Dim retorno As Integer = 0
        Dim rs As New ADODB.Recordset
        If cn.State = 0 Then
            retorno = 1
        Else

            sql = "select * from lote where id_lote ='" & _id_lote & "'"

            MsgBox(sql)
            Try
                rs.Open(sql, cn)
                rs.MoveLast()
            Catch ex As Exception
                Return (2)
            End Try
            If rs.RecordCount = 0 Then
                retorno = 3
            Else
                _id_lote = rs("id_lote").Value
                _nombre = "Vehiculos"
                _descripcion = "Negros"
                _cedula = rs("cedula").Value
                _borrado = "'f'"

            End If
        End If
        rs.Close()
        Return (retorno)
    End Function

    '**************************************************************
    '**************************************************************

    Function AsignarLote(id_vehiculo As Integer) As Integer
        vehiculo = id_vehiculo
        Dim op As New frmOperarioPuerto
        Dim idlote As Integer
        Dim rsCount As Integer
        Dim rs As New ADODB.Recordset

        rs.Open("select lote from lotecargado where vehiculo = '" & id_vehiculo & "'", cn)

        If rs.RecordCount = 0 Then
            rs.Close()
            rs.Open("select * from lote", cn)
            rs.MoveLast()
            idlote = rs("id_lote").Value
            lotecargado = idlote
            rs.Close()

            rs.Open("select * from lotecargado where lote = " & idlote, cn)
            rsCount = rs.RecordCount

            If rsCount = 10 Then

                idlote = idlote + 1
                Return idlote
                'MsgBox("Llegue al rsCount = 10 donde se incrementa el id de lote")
            Else

                'MsgBox("Llegue al rsCount < 10")
                Return idlote
            End If
            rs.Close()
        Else

            lotecargado = rs("lote").Value
            Return lotecargado

        End If
        rs.Close()

    End Function
    '**************************************************************
    '**************************************************************

    Public Sub InsertLote(lote As Integer, vehiculo As Integer)

        Dim op As New frmOperarioPuerto
        Dim sql As String

        sql = "insert into lotecargado values (" & lote & ", " & vehiculo & ", current, 'f')"


        Try
            cn.Execute(sql, cn)

        Catch ex As Exception
            Dim salida As String = ex.ToString

        End Try
    End Sub
End Class
