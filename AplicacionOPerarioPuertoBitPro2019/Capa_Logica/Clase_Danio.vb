Public Class Clase_Danio

    '*****ATRIBUTOS DE LA TABLA DANIO*******************************

    Protected _id_danio As Integer
    Protected _tipo As String
    Protected _descripcion As String
    Protected _borrado As String

    '********METODOS SETTER Y GETTER*******************************
    '**************************************************************
    Property id_danio As Integer
        Get
            Return (_id_danio)
        End Get
        Set(value As Integer)
            _id_danio = value
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
    Property descripcion As String
        Get
            Return (_descripcion)
        End Get
        Set(value As String)
            _descripcion = value
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

        _id_danio = 0
        _tipo = 0
        _descripcion = ""
        _borrado = ""

    End Sub
    '**************************************************************
    '**************************************************************
    Sub New(id_danio As Integer, tipo As Integer, descripcion As String, borrado As String)

        _id_danio = id_danio
        _tipo = tipo
        _descripcion = descripcion
        _borrado = borrado

    End Sub
    '**************************************************************
    '**************************************************************
    Function buscarDanio(descripcion As String) As Integer
        Dim sql As String
        Dim rs As New ADODB.Recordset
        Dim retorno As Integer = 0

        sql = "select id_danio from danio where descripcion = '" & descripcion & "'"
        Try
            rs.Open(sql, cn)
            'MsgBox("EN EL TRY EL SQL: " & sql)

        Catch ex As Exception
            'MsgBox(ex.ToString)
        End Try
        If rs.RecordCount = 0 Then
            'MsgBox("No se encontró el ID del Daño con esa Descripción.")
        Else
            _id_danio = rs("id_danio").Value
        End If
        rs.Close()
        retorno = _id_danio
        Return retorno
    End Function

End Class