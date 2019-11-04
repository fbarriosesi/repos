Imports System.Data.Odbc
Public Class frmArchivocsv

    Dim id_vehiculo As Integer

    '**************************************************************************************************************************************************
    '**************************************************************************************************************************************************

    Private Sub ButtonCARGAR_Click(sender As System.Object, e As System.EventArgs) Handles ButtonCARGAR.Click
        If OpenFileDialog1.ShowDialog Then

            DataGridView1.Columns.Clear() 'LIMPIA DE RESULTADOS ANTERIORES

            'CABECERA
            Try
                Dim CABECERA As String = IO.File.ReadLines(OpenFileDialog1.FileName)(0) 'PRIMERA LINEA DEL ARCHIVO COMO CABECERA
                Dim COLUMNAS As String() = CABECERA.Split(",")
                DataGridView1.ColumnCount = COLUMNAS.Count
                For I = 0 To COLUMNAS.Count - 1
                    DataGridView1.Columns(I).Name = COLUMNAS(I)
                Next

                'RESTO DE FILAS
                For I = 1 To IO.File.ReadLines(OpenFileDialog1.FileName).Count - 1
                    Dim FILA As String() = IO.File.ReadLines(OpenFileDialog1.FileName)(I).Split(",")
                    DataGridView1.Rows.Add(FILA)
                Next
            Catch
                MsgBox("error en carga de CSV.")
            End Try

        End If

    End Sub

    '**************************************************************************************************************************************************
    '**************************************************************************************************************************************************

    Private Sub ButtonBUSCAR_Click(sender As System.Object, e As System.EventArgs) Handles ButtonBUSCAR.Click
        'BUSCA UN TEXTO EN EL DATAGRIDVIEW
        For I = 0 To DataGridView1.Rows().Count - 1 'RECORRE LAS FILAS
            For Each CELDA In DataGridView1.Rows(I).Cells 'RECORRE LAS CELDAS DE CADA FILA
                If CELDA.VALUE = TextBox1.Text Then
                    DataGridView1.CurrentCell = CELDA 'SELECCIONA LA CELDA
                    MsgBox(DataGridView1.CurrentCellAddress.ToString) 'ESCRIBE LA FILA Y COLUMNA DE LA CELDA
                    Exit Sub 'CUANDO LA ENCUENTRA SALE DE LOS 2 BUCLES
                End If
            Next
        Next

        MsgBox("DATO NO ENCONTRADO") 'SI HA LLEGADO HASTA AQUI ES QUE NO HA ENCONTRADO EL DATO

    End Sub

    '**************************************************************************************************************************************************
    '**************************************************************************************************************************************************

    Private Sub ButtonGUARDAR_Click(sender As System.Object, e As System.EventArgs) Handles ButtonGUARDAR.Click

        SaveFileDialog1.DefaultExt = ".csv" 'EVITA TENER QUE ESCRIBIR LA EXTENSION AL GUARDAR

        If SaveFileDialog1.ShowDialog Then

            'GUARDA EL VALOR DE LA CABECERA (COLUMNAS)
            Dim COLUMNAS As Integer = DataGridView1.Columns.Count
            Dim CABECERA As String = String.Empty
            For I = 0 To COLUMNAS - 2 'RECORRE LA CABECERA
                CABECERA += DataGridView1.Columns(I).Name & "," 'AÑADE LA COMA PARA LOS CAMPOS
            Next
            CABECERA += DataGridView1.Columns(COLUMNAS - 1).Name & vbCrLf 'AÑADE EL SALTO DE LINEA CUANDO SE HA COMPLETADO EL REGISTRO
            My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, CABECERA, False) 'GUARDA EL REGISTRO CABECERA

            'GUARDA EL RESTO DE VALORES (FILAS)
            Dim FILAS As Integer = DataGridView1.Rows.Count
            Dim TEXTO As String = String.Empty

            'RECORRE FILAS X COLUMNAS
            For I = 0 To FILAS - 2
                For J = 0 To COLUMNAS - 2
                    TEXTO += DataGridView1.Item(J, I).Value & "," 'AÑADE LA , PARA LOS CAMPOS
                Next
                TEXTO += DataGridView1.Item(COLUMNAS - 1, I).Value & vbCrLf 'AÑADE EL SALTO DE LINEA CUANDO SE HA COMPLETADO CADA REGISTRO
            Next
            My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, TEXTO, True) 'GUARDA LOS REGSITROS
        End If
    End Sub

    '**************************************************************************************************************************************************
    '**************************************************************************************************************************************************

    Sub insertCSV()

        Dim vinDATO As String
        Dim marcaDATO As String
        Dim modeloDATO As String
        Dim colorDATO As String
        Dim anioDATO As Integer
        Dim tipoDATO As String
        Dim sql As String

        Dim situacionDATO As String
        Dim localizacionDATO As String
        Dim borradoDATO As String
        'Dim loteDATO As Nullable

        borradoDATO = "f"
        situacionDATO = "a inspeccionar"
        localizacionDATO = ""


        For Each dato As DataGridViewRow In DataGridView1.Rows 'RECORRE LAS CELDAS DE CADA FILA

            ObtenerId_vehiculo()
            'id_vehiculo = id_vehiculo + 1

            vinDATO = CStr(dato.Cells(0).Value) 'Cargo los datos de cada celda del datagrid en las respectivas variables
            marcaDATO = CStr(dato.Cells(1).Value) 'para poder hacer los insert de los nuevos vehiculos en el orden en que
            modeloDATO = CStr(dato.Cells(2).Value) 'aparece en el archivo importado.
            colorDATO = CStr(dato.Cells(3).Value)
            anioDATO = CStr(dato.Cells(4).Value)
            tipoDATO = CStr(dato.Cells(5).Value)

            'ORDEN DE LA TABLA VEHICULO
            '(id_vehiculo, vin, marca, modelo, color, anio, tipo, situacion, localizacion, borrado, lote)
            sql = "insert into vehiculo values (" & id_vehiculo & ", '" & vinDATO & "', '" & marcaDATO & "', '" & modeloDATO &
                "', '" & colorDATO & "', " & anioDATO & ", '" & tipoDATO & "', '" & situacionDATO & "', '" & localizacionDATO &
                "', '" & borradoDATO & "')"

            MsgBox(sql)

            Try
                cn.Execute(sql)
                MsgBox("Se Guardó la correctamente")

            Catch ex As Exception
                MsgBox("No se pudo ingresar la linea a la inspección.")

            End Try
        Next

    End Sub

    '**************************************************************************************************************************************************
    '**************************************************************************************************************************************************

    Private Sub cmdInsert_Click(sender As Object, e As EventArgs) Handles cmdInsert.Click

        insertCSV()

    End Sub

    '**************************************************************************************************************************************************
    '**************************************************************************************************************************************************

    Sub ObtenerId_vehiculo()

        rs.Open("select id_vehiculo from vehiculo", cn)
        rs.MoveLast()
        id_vehiculo = (rs("id_vehiculo").Value) + 1

        rs.Close()

    End Sub

    '**************************************************************************************************************************************************
    '**************************************************************************************************************************************************

End Class