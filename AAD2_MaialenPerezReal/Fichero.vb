Imports System.IO

Public Class Fichero
    Private sFicheroActual As String

    Public Sub New(nombreFich As String)
        ' Combinamos la ruta de la carpeta del programa con el nombre del archivo
        Me.sFicheroActual = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, nombreFich)
    End Sub


    Public Sub GuardarVenta(texto As String)
        Try

            Using fs As New FileStream(Me.sFicheroActual, FileMode.Append, FileAccess.Write)
                Using bw As New BinaryWriter(fs)

                    bw.Write(texto & Environment.NewLine)
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Error al escribir: " & ex.Message)
        End Try
    End Sub
End Class
