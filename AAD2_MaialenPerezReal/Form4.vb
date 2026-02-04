Imports System.Net.Http
Imports System.Web.Script.Serialization ' Necesitas agregar la referencia System.Web.Extensions
Public Class Form4
    Private Async Sub FormCreditos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Await CargarDatosGithub("maialenperez06")
    End Sub

    Private Async Function CargarDatosGithub(usuario As String) As Task
        Dim url As String = "https://api.github.com/users/" & usuario

        Using client As New HttpClient()
            ' GitHub requiere un "User-Agent" para aceptar la petición
            client.DefaultRequestHeaders.Add("User-Agent", "VB-App")

            Try
                Dim response As String = Await client.GetStringAsync(url)
                Dim js As New JavaScriptSerializer()
                Dim datos As Dictionary(Of String, Object) = js.Deserialize(Of Dictionary(Of String, Object))(response)

                ' Asignar Nombre y Repositorios
                lblNombre.Text = "Usuario: " & datos("login").ToString()
                lblRepos.Text = "Repositorios públicos: " & datos("public_repos").ToString()

                ' Cargar Imagen desde la URL de la API
                Dim urlImagen As String = datos("avatar_url").ToString()
                pbGithub.ImageLocation = urlImagen
                pbGithub.SizeMode = PictureBoxSizeMode.StretchImage

            Catch ex As Exception
                MsgBox("No se pudo conectar con GitHub: " & ex.Message)
            End Try
        End Using
    End Function

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()

    End Sub
End Class