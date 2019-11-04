Public Class Clase_deriva

    '*****ATRIBUTOS DE LA TABLA DERIVA******************************

    Protected _id_deriva As Integer
    Protected _cedula As Integer
    Protected _zona As Integer
    Protected _subzona As Integer
    Protected _fechahora As Date
    Protected _borrado As String

    '********METODOS SETTER Y GETTER*******************************
    '**************************************************************
    Property id_deriva As Integer
        Get
            Return (_id_deriva)
        End Get
        Set(value As Integer)
            _id_deriva = value
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
    Property zona As Integer
        Get
            Return (_zona)
        End Get
        Set(value As Integer)
            _zona = value
        End Set
    End Property
    '**************************************************************
    Property subzona As Integer
        Get
            Return (_subzona)
        End Get
        Set(value As Integer)
            _subzona = value
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

        _id_deriva = 0
        _cedula = 0
        _zona = 0
        _subzona = 0
        _borrado = ""

    End Sub
    '**************************************************************
    '**************************************************************
    Sub New(id_deriva As Integer, cedula As Integer, zona As Integer, subzonas As Integer, borrado As String)
        _id_deriva = id_deriva
        _cedula = cedula
        _zona = zona
        _subzona = subzona
        _borrado = borrado

    End Sub
    '**************************************************************
    '**************************************************************

End Class
