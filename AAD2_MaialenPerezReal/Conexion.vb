Imports System.Data.SqlClient
Public Class Conexion
    ' Cambia el Data Source por el de tu instancia de SQL Server
    Public Shared cadena As String = "Data Source=Eustakio;Initial Catalog=CINE;Integrated Security=True"

    Public Shared Function LeerBD(query As String) As DataTable
        Dim dt As New DataTable()
        Try
            Using conn As New SqlConnection(cadena)
                Dim cmd As New SqlCommand(query, conn)
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
            End Using
        Catch ex As Exception
            MsgBox("Error al leer datos: " & ex.Message)
        End Try
        Return dt
    End Function

    Public Shared Sub EjecutarSQL(query As String)
        Try
            Using conn As New SqlConnection(cadena)
                Dim cmd As New SqlCommand(query, conn)
                conn.Open()
                cmd.ExecuteNonQuery()
                conn.Close()
            End Using
        Catch ex As Exception
            MsgBox("Error al ejecutar acción: " & ex.Message)
        End Try
    End Sub
End Class
