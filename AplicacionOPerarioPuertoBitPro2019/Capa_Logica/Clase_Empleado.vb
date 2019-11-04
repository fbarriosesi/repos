Public Class Clase_empleado

    '*****ATRIBUTOS DE LA TABLA EMPLEADO****************************

    Protected _cedula As Integer
    Protected _nombre As String
    Protected _apellido As String
    Protected _telefono As Integer
    Protected _usuario As String
    Protected _rol As Integer
    Protected _borrado As String

    '********METODOS SETTER Y GETTER*******************************
    Property cedula As Integer
        Get
            Return (_cedula)
        End Get
        Set(value As Integer)
            _cedula = value
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
    Property apellido As String
        Get
            Return (_apellido)
        End Get
        Set(value As String)
            _apellido = value
        End Set
    End Property
    '**************************************************************
    Property telefono As Integer
        Get
            Return (_telefono)
        End Get
        Set(value As Integer)
            _telefono = value
        End Set
    End Property
    '**************************************************************
    Property usuario As String
        Get
            Return (_usuario)
        End Get
        Set(value As String)
            _usuario = value
        End Set
    End Property
    '**************************************************************
    Property rol As Integer
        Get
            Return (_rol)
        End Get
        Set(value As Integer)
            _rol = value
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

        _cedula = 0
        _nombre = ""
        _apellido = ""
        _telefono = 0
        _usuario = ""
        _rol = 0
        _borrado = ""

    End Sub
    '**************************************************************
    '**************************************************************
    Sub New(cedula As Integer, nombre As String, apellido As String, telefono As Integer, usuario As String, rol As Integer, borrado As String)

        _cedula = cedula
        _nombre = nombre
        _apellido = apellido
        _telefono = telefono
        _usuario = usuario
        _rol = rol
        _borrado = borrado

    End Sub
    '**************************************************************
    '**************************************************************
    Function buscarUsuario(cn As ADODB.Connection) As Integer
        Dim sql As String
        Dim retorno As Integer = 0
        Dim rs As New ADODB.Recordset
        If cn.State = 0 Then
            retorno = 1
        Else

            sql = "select * from empleado where usuario ='" & frmLogin.txtUsuario.Text & "'"
            Try
                rs.Open(sql, cn)
            Catch ex As Exception
                Return (2)
            End Try
            If rs.RecordCount = 0 Then
                retorno = 3
            Else

                _cedula = rs("cedula").Value
                _usuario = rs("usuario").Value
                _rol = rs("rol").Value
                _borrado = rs("borrado").Value

            End If
        End If
        rs.Close()
        Return (retorno)
    End Function
    '**************************************************************
    '**************************************************************
    Public Sub buscarUsuario(usuario As String)

        Dim sql As String

        sql = "select * from empleado where usuario ='" & usuario & "'"
        Try
            rs.Open(sql, cn)
        Catch ex As Exception
            MsgBox("El usuario no existe, verifique.")
        End Try
        If IsDBNull(rs("nombre").Value) Then
            _usuario = rs("usuario").Value
            _nombre = "No Ingresado"
            _apellido = "No ingresado"
            _telefono = 0
        Else
            _usuario = rs("usuario").Value
            _nombre = rs("nombre").Value
            _apellido = rs("apellido").Value
            _telefono = rs("telefono").Value
        End If
        _cedula = rs("cedula").Value
        rs.Close()
    End Sub
    '**************************************************************
    '**************************************************************
    Public Sub buscarCedula(cedula As Integer)
        Dim sql As String

        sql = "select * from empleado where cedula ='" & cedula & "'"
        Try
            rs.Open(sql, cn)
        Catch ex As Exception
            MsgBox("El usuario no existe, verifique.")
        End Try
        If IsDBNull(rs("nombre").Value) Then
            _usuario = rs("usuario").Value
            _nombre = "No Ingresado"
            _apellido = "No ingresado"
            _telefono = 0
        Else
            _usuario = rs("usuario").Value
            _nombre = rs("nombre").Value
            _apellido = rs("apellido").Value
            _telefono = rs("telefono").Value
        End If
        _cedula = rs("cedula").Value
        rs.Close()
    End Sub
    '**************************************************************
    '**************************************************************
    Public Function modificarUsuario(usuario As String) As String
        Dim sql As String
        Dim ret As String
        sql = "update empleado set nombre = '" & _nombre & "', apellido = '" & _apellido & "', telefono = " & _telefono & " where usuario = '" & usuario & "'"
        Try
            rs.Open(sql, cn)
            ret = "Usuario modificado con éxito."
        Catch ex As Exception
            ret = "Ocurrió un error en la modificación."
        End Try
        Return ret
    End Function
    '**************************************************************
    '**************************************************************
End Class
