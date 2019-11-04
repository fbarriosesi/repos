Module Permisos
    Public cedula As Integer
    Public rolusuario As Integer

    Public Sub habilito(rol As Integer)

        '*****************************************************************************************************************************
        '*****************************************************************************************************************************

        Select Case rol ' SELECT ENCARGADO DE DEFINIR LOS ROLES DE LAS APLICACIONES EN LA BASE DE DATOS

            Case rol 'Loggin

                '*********************************************************************************************************************
                '*********************************************************************************************************************
                Select Case rol
                    Case 1000 'ADMINISTRADOR
                        Try
                            frmMenu.Show()

                        Catch ex As Exception
                            MsgBox("algo sale mal...." + ex.ToString)
                        End Try


                    Case 1002 'OPERARIO DE PATIO
                        Try
                            frmOperarioPatio.Show()

                        Catch ex As Exception
                            MsgBox("algo sale mal...." + ex.ToString)
                        End Try

                    Case 1001 'OPERARIO DE PUERTO
                        Try
                            frmOperarioPuerto.Show()

                        Catch ex As Exception
                            MsgBox("algo sale mal...." + ex.ToString)
                        End Try

                    Case 1003
                        Try
                            frmTransportista.Show()

                        Catch ex As Exception
                            MsgBox("algo sale mal...." + ex.ToString)
                        End Try

                End Select

            Case Else ' NO ES ROL DE COMPRAS NI VENTAS.
                MsgBox("Datos no válidos para ingreso.")

        End Select

    End Sub

    '*****************************************************************************************************************************
    '*****************************************************************************************************************************

    Public Function rol(usuario As String) As Integer
        Dim ret As Integer = -1 ' SE INICIA EN MENOS 1 PORQUE UNA FUNCION NO PUEDE DEVOLVER VALORES NEGATIVOS
        Dim sql As String = "Select rol from empleado where usuario ='" & usuario & "'" ' TODOS LOS ACCESOS A BASE DE DATOS DEBEN TENER SU TRY CATCH
        Dim rs As New ADODB.Recordset
        Try
            rs.Open(sql, cn) ' ES DONDE SE ALMACENA EL RESULTADO DE LA CONSULTA
            rolusuario = rs("rol").Value
        Catch ex As Exception
            Return (ret)
        End Try
        If rs.RecordCount = 1 Then ' ESTO SIGNIFICA QUE EL SELECT ENCONTRO UN ROL O UN DATO DEL ROL
            ret = rs(0).Value
        End If
        rs.Close() ' SI NO SE CIERRA EL OBJETO RECORDSET NO SE PUEDE USAR
        sql = "select cedula from empleado where usuario ='" & usuario & "'"
        rs.Open(sql, cn)
        cedula = rs("cedula").Value
        Return (ret) ' EL RETURN DEBE TENER ESPACIO CON LA VARIABLE
    End Function
End Module
