Public Class Clase_Recibe

    '*****ATRIBUTOS DE LA TABLA RECIBE******************************

    Protected _vehiculo As Integer
    Protected _lote As Integer
    Protected _fechahora As Date
    Protected _borrado As String

    '********METODOS SETTER Y GETTER*******************************
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
    Property lote As Integer
        Get
            Return (_lote)
        End Get
        Set(value As Integer)
            _lote = value
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

        _vehiculo = 0
        _lote = 0
        _borrado = ""

    End Sub
    '**************************************************************
    '**************************************************************
    Sub New(vehiculo As Integer, lote As Integer, borrado As String)

        _vehiculo = vehiculo
        _lote = lote
        _borrado = borrado

    End Sub
    '**************************************************************
    '**************************************************************
End Class
