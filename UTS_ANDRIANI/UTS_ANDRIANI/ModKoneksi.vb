Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient

Module ModKoneksi
    Public comSQL As New SqlClient.SqlCommand
    Public sql As String
    Public conn As New SqlConnection

    Public str As String = "Data Source=A10\MSQLSERVER;" & _
                            "Initial Catalog=dbTransportation;" & _
                            "Persist Security Info=True;" & _
                            "UID=sa;PWD=admin;"
    Public Sub bukaKoneksi()
        If conn.State = ConnectionState.Closed Then
            conn.ConnectionString = str

            Try
                conn.Open()
            Catch ex As Exception
                MsgBox("yah gagal : " & ex.ToString)
            End Try
        End If
    End Sub

    Public Sub tutupKoneksi()
        If conn.State = ConnectionState.Open Then
            Try
                conn.Close()
            Catch ex As Exception
                MsgBox("error : " & ex.ToString)
            End Try
        End If
    End Sub

End Module
