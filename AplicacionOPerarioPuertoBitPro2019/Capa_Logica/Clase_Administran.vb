Public Class Clase_administran

    '*****ATRIBUTOS DE LA TABLA ADMINISTRAN*************************

    Protected _id_administran As Integer
    Protected _cedula As Integer
    Protected _zona As Integer
    Protected _subzona As Integer
    Protected _fechahora As Date
    Protected _accion As String
    Protected _borrado As String

    '********METODOS SETTER Y GETTER*******************************
    '**************************************************************
    Property id_administran As Integer
        Get
            Return (_id_administran)
        End Get
        Set(value As Integer)
            _id_administran = value
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
    Property accion As String
        Get
            Return (_accion)
        End Get
        Set(value As String)
            _accion = value
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

        _id_administran = 0
        _cedula = 0
        _zona = 0
        _subzona = 0
        _accion = ""
        _borrado = ""

    End Sub
    '**************************************************************
    '**************************************************************
    Sub New(id_administran As Integer, cedula As Integer, zona As Integer, subzona As Integer, accion As String, borrado As String)

        _id_administran = id_administran
        _cedula = cedula
        _zona = zona
        _subzona = subzona
        _accion = accion
        _borrado = borrado

    End Sub
    '**************************************************************
    '**************************************************************
End Class
