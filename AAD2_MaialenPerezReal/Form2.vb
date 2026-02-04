Public Class Form2

    ' Variables para recibir los datos desde el Form1
    Public ID As Integer
    Public titulo As String
    Public anio As Integer
    Public duracion As Integer
    Public precio As Double
    Public sinopsis As String
    Public rutaImg As String

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Llenamos los TextBox (TextFields)
        txtTitulo.Text = titulo
        txtAnio.Text = anio.ToString()
        txtDuracion.Text = duracion.ToString()
        txtPrecio.Text = precio.ToString("F2") ' Muestra 2 decimales

        ' Llenamos la Label de la sinopsis
        lblSip.Text = sinopsis



        ' Cargar imagen
        If System.IO.File.Exists(rutaImg) Then
            PictureBox1.ImageLocation = rutaImg
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    Private Sub btnVender_Click(sender As Object, e As EventArgs) Handles btnVender.Click

        Dim pantallaCompra As New Form3()

        ' Solo pasamos el ID, el Form3 se encarga del resto
        pantallaCompra.idSeleccionado = Me.ID
        pantallaCompra.ShowDialog()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class