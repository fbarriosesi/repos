Public Class frmLogin

    Public resultado As MsgBoxResult

    Protected _idAplicacion As Integer ' VARIABLE POR ESO TIENE GUION BAJO, ESTA ES LA VARIABLE PROTEGIDA QUE SE VE APENAS DESDE ESTE FORMULARIO

    '**************************************************************************************************************************************************
    '**************************************************************************************************************************************************

    Property idAplicacion As Integer 'PROPIEDAD POR ESO NO TIENE EL GUION BAJO, METODO SET QUE DETERMINA EL USO DE LAS APLICACIONES POR LOS FORMULARIOS
        Get
            Return (_idAplicacion) '
        End Get
        Set(value As Integer)
            _idAplicacion = value
        End Set
    End Property

    '**************************************************************************************************************************************************
    '**************************************************************************************************************************************************

    Private Sub cmdAceptar_Click(sender As Object, e As EventArgs) Handles cmdAceptar.Click
        Try
            cn.Open("miodbc", txtUsuario.Text, txtClave.Text) ' miodbc ES EL NOMBRE DE LA CONEXION Y ACA HACEMOS EL CHEQUEO DE USUARIO Y PASS

            MsgBox("Bienvenido, usted está Conectado") ' SOLO DE PRUEBA PARA VERIFICAR QUE SE CONECTA


        Catch ex As Exception
            MsgBox("Usuario o Contrasenia incorrecto") ' CASO LA EXCEPCION SEA CUALQUIER CSA, ASUMIMOS QUE ES ERROR DE USUARIO O PASS
            Exit Sub

        End Try

        cn.CursorLocation = ADODB.CursorLocationEnum.adUseClient ' INDICA EN QUE LADO SE ALMACENA EL RESULTADO DE UN SELECT, EN ESTE CASO SE GUARDA EN EL LADO DEL CLIENTE


        habilito(rol(txtUsuario.Text))  ' --> CON ESTO USAMOS EL PROCEDIMIENTO DOYPERMISO Y ABRIMOS LA APLICACION QUE TENGA EL IDAPLICACION INDICADO PARA ESE USUARIO
        Me.Hide()
    End Sub

    '**************************************************************************************************************************************************
    '**************************************************************************************************************************************************

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblFechaHora.Text = DateTime.Now
    End Sub


    '**************************************************************************************************************************************************
    '**************************************************************************************************************************************************

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        Me.Close()
    End Sub

    '**************************************************************
    '***SI PULSA ENTER EJECUTA ACCION DEL BOTON ACEPTAR************
    '**************************************************************

    Private Sub txtClave_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtClave.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Try
                cn.Open("miodbc", txtUsuario.Text, txtClave.Text) ' miodbc ES EL NOMBRE DE LA CONEXION Y ACA HACEMOS EL CHEQUEO DE USUARIO Y PASS

                'MsgBox("Bienvenido, usted está Conectado") ' SOLO DE PRUEBA PARA VERIFICAR QUE SE CONECTA


            Catch ex As Exception
                MsgBox("Usuario o Contrasenia incorrecto" + ex.ToString) ' CASO LA EXCEPCION SEA CUALQUIER CSA, ASUMIMOS QUE ES ERROR DE USUARIO O PASS
                Exit Sub

            End Try

            cn.CursorLocation = ADODB.CursorLocationEnum.adUseClient ' INDICA EN QUE LADO SE ALMACENA EL RESULTADO DE UN SELECT, EN ESTE CASO SE GUARDA EN EL LADO DEL CLIENTE


            habilito(rol(txtUsuario.Text))  ' --> CON ESTO USAMOS EL PROCEDIMIENTO DOYPERMISO Y ABRIMOS LA APLICACION QUE TENGA EL IDAPLICACION INDICADO PARA ESE USUARIO
            Me.Hide()
        End If
    End Sub

    Private Sub frmLogin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        resultado = CType(MessageBox.Show("Desea salir de la aplicacion?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question), MsgBoxResult)

        If resultado = MsgBoxResult.No Then
            e.Cancel = True
        Else
            e.Cancel = False
        End If

    End Sub
End Class