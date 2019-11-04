Option Strict On
Public Class Clase_Zona

    '*****ATRIBUTOS DE LA TABLA ZONA*******************************

    Protected _id_zona As Integer
    Protected _nombre As String
    Protected _tamanio As Integer
    Protected _borrado As String
    Protected _auxiliar As String

    '********METODOS SETTER Y GETTER*******************************
    '**************************************************************
    Property id_zona As Integer
        Get
            Return (_id_zona)
        End Get
        Set(value As Integer)
            _id_zona = value
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
    Property tamanio As Integer
        Get
            Return (_tamanio)
        End Get
        Set(value As Integer)
            _tamanio = value
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
    Property auxiliar As String
        Get
            Return (_auxiliar)
        End Get
        Set(value As String)
            _auxiliar = value
        End Set
    End Property
    '**************************************************************
    '**************************************************************
    Sub New()

        _id_zona = 0
        _nombre = ""
        _tamanio = 0
        _borrado = ""
        _auxiliar = ""
    End Sub
    '**************************************************************
    '**************************************************************
    Sub New(id_zona As Integer, nombre As String, tamanio As Integer, borrado As String, auxiliar As String)
        _id_zona = id_zona
        _nombre = nombre
        _tamanio = tamanio
        _borrado = borrado
        _auxiliar = auxiliar
    End Sub
    '**************************************************************
    '**************************************************************
End Class