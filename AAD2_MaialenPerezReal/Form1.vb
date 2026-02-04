Public Class Form1
    Public ID As Integer
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        AbrirDetalle(3)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        AbrirDetalle(1)
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        AbrirDetalle(2)
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        AbrirDetalle(4)
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        AbrirDetalle(5)
    End Sub

    Private Sub AbrirDetalle(idPelicula As Integer)
        ' La consulta ahora es mucho más limpia y rápida
        Dim dt As DataTable = Conexion.LeerBD("SELECT * FROM PELICULA WHERE ID = " & idPelicula)

        If dt.Rows.Count > 0 Then
            Dim fila As DataRow = dt.Rows(0)
            Dim pantallaPelicula As New Form2()


            pantallaPelicula.ID = idPelicula ' le pasa al form2 el id que tenga 'idpelicula'
            ' Pasamos los datos

            pantallaPelicula.titulo = fila("Titulo").ToString()
            pantallaPelicula.anio = CInt(fila("Estreno"))
            pantallaPelicula.duracion = CInt(fila("Duracion"))
            pantallaPelicula.precio = CDbl(fila("Precio"))
            pantallaPelicula.sinopsis = fila("Sinopsis").ToString()
            pantallaPelicula.rutaImg = fila("URL_Imagen").ToString()

            pantallaPelicula.ShowDialog()
        End If
    End Sub

    Private Sub btnCreditos_Click(sender As Object, e As EventArgs) Handles btnCreditos.Click
        Form4.Show()
    End Sub
End Class
