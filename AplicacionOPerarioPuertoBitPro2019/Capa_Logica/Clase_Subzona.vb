Public Class Clase_Subzona

    '*****ATRIBUTOS DE LA TABLA SUBZONA****************************

    Protected _id_subzona As Integer
    Protected _nombre As String
    Protected _zona As Integer
    Protected _borrado As String


    '********METODOS SETTER Y GETTER*******************************
    '**************************************************************
    Property id_subzona As Integer
        Get
            Return (_id_subzona)
        End Get
        Set(value As Integer)
            _id_subzona = value
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
    Property zona As Integer
        Get
            Return (_zona)
        End Get
        Set(value As Integer)
            _zona = value
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

        _id_subzona = 0
        _nombre = ""
        _zona = 0
        _borrado = ""

    End Sub
    '**************************************************************
    '**************************************************************
    Sub New(id_subzona As Integer, nombre As String, zona As Integer, borrado As String)

        _id_subzona = id_subzona
        _nombre = nombre
        _zona = zona
        _borrado = borrado

    End Sub
    '**************************************************************
    '**************************************************************
    'Public Sub gAsignarSubzona(cn As ADODB.Connection)

    '    Dim retorno As Integer = 0
    '    Dim sql As String
    '    _borrado = "f"

    '    'ORDEN DE LA TABLA ZONA
    '    '(id_subzona, nombre, zona, borrado)
    '    sql = "insert into subzona values (" & _id_subzona & ", '" & _nombre & "', " & _zona & ", '" & _borrado & "')"
    '    MsgBox(sql)
    '    Try
    '        cn.Execute(sql)
    '        MsgBox("Se Asigno un vehiculo a la subzona: " & _id_subzona & ", de nombre: " & _nombre)
    '    Catch ex As Exception
    '        MsgBox("No se pudo asignar el vehiculo a la zona.")
    '    End Try

    'End Sub

    '**************************************************************
    '**************************************************************
End Class
