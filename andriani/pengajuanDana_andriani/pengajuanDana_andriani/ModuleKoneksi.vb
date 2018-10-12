Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient

Module ModuleKoneksi
    Public comSQL As New SqlClient.SqlCommand
    Public sql As String
    Public conn As New SqlConnection

    Public str As String = "Data Source=USER-PC\SQLEXPRESS;" & _
                            "Initial Catalog=db_ai;" & _
                            "Persist Security Info=True;" & _
                            "UID=sa;PWD=admin"
    Public Sub openKoneksi()
        If conn.State = ConnectionState.Closed Then

            conn.ConnectionString = str
            Try
                conn.Open()
            Catch ex As Exception
                MsgBox("Yah Gagal : " & ex.ToString)
            End Try
        End If
    End Sub

    Public Sub closeKoneksi()
        If conn.State = ConnectionState.Open Then
            Try
                conn.Close()
            Catch ex As Exception
                MsgBox("Error " & ex.ToString)
            End Try
        End If
    End Sub
End Module
