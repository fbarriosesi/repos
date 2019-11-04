Public Class Clase_rol

    '*****ATRIBUTOS DE LA TABLA ROL********************************

    Protected _id_rol As Integer
    Protected _nombre_rol As String
    Protected _borrado_rol As String

    '********METODOS SETTER Y GETTER*******************************
    '**************************************************************
    Property id_rol As Integer
        Get
            Return (_id_rol)
        End Get
        Set(value As Integer)

            _id_rol = value
        End Set
    End Property
    '**************************************************************
    Property nombre_rol As String
        Get
            Return (_nombre_rol)
        End Get
        Set(value As String)

            _nombre_rol = value
        End Set
    End Property
    '**************************************************************
    Property borrado_rol As String
        Get
            Return (_borrado_rol)
        End Get
        Set(value As String)

            _borrado_rol = value
        End Set
    End Property
    '**************************************************************
    '**************************************************************
    Sub New()
        _id_rol = 0
        _nombre_rol = ""
        _borrado_rol = ""
    End Sub
    '**************************************************************
    '**************************************************************
    Sub New(id_rol As Integer, nombre_rol As String, borrado_rol As String)
        _id_rol = id_rol
        _nombre_rol = nombre_rol
        _borrado_rol = borrado_rol
    End Sub
    '**************************************************************
    '**************************************************************
End Class
