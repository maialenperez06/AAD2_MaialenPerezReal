Imports System.IO

Public Class Form3
    Public idSeleccionado As Integer
    Private pelicula As Pelicula

    Private Sub btnComprar_Click(sender As Object, e As EventArgs) Handles btnComprar.Click
        comprarEntradas()

    End Sub

    Private Sub comprarEntradas()
        ' 1. Consultar el stock actual REAL de la base de datos
        ' Añadimos "Titulo" a la consulta para poder guardarlo en el fichero
        Dim dt As DataTable = Conexion.LeerBD("SELECT Titulo, Entradas FROM PELICULA WHERE ID = " & idSeleccionado)

        If dt.Rows.Count > 0 Then
            Dim entradasEnBD As Integer = CInt(dt.Rows(0)("Entradas"))
            Dim tituloPeli As String = dt.Rows(0)("Titulo").ToString() ' <--- Guardamos el nombre
            Dim cantidadAComprar As Integer = CInt(numEntradas.Value)

            ' 2. Validación: Máximo 10
            If cantidadAComprar > 10 Then
                MsgBox("No puedes comprar más de 10 entradas.")
                Return
            End If

            ' 3. Validación: Stock suficiente
            If cantidadAComprar > entradasEnBD Then
                MsgBox("Error: Solo quedan " & entradasEnBD & " entradas en el sistema.")
            Else
                ' 4. Todo OK: Restamos y actualizamos
                Dim nuevoStock As Integer = entradasEnBD - cantidadAComprar
                Conexion.EjecutarSQL("UPDATE PELICULA SET Entradas = " & nuevoStock & " WHERE ID = " & idSeleccionado)

                ' --- NUEVO: GUARDAR EN FICHERO ---
                Dim miFich As New Fichero("ventas.txt")
                Dim lineaVenta As String = "Peli: " & tituloPeli & " | Entradas: " & cantidadAComprar & " | Fecha: " & Now.ToString()
                miFich.GuardarVenta(lineaVenta)
                ' ---------------------------------

                MsgBox("¡Compra realizada! Has comprado " & cantidadAComprar & " entradas.")

                Form1.Show()
                Me.Close()

            End If
        End If
    End Sub

End Class