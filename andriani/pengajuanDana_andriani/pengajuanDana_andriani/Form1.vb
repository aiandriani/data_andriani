Imports System.Data.SqlClient

Public Class Form1
    Dim bentuk As String
    Dim cmd_gl As SqlCommand
    Dim dr_gl As SqlDataReader
    Dim query_gl As String

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tampilkan()
        DateTimePicker1.Value = Now
        TBID.Visible = False
        Tbbentuk.Visible = False
    End Sub

    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click
        Dim query As String
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader
        Dim uid As String
        Dim cekStok As Boolean = False


        Call openKoneksi()
        Try
            Dim query_id As String = "SELECT MAX(idPengajuan)+1 AS MXID FROM pengajuan"
            cmd = New SqlCommand(query_id, conn)
            dr = cmd.ExecuteReader
            dr.Read()
            uid = dr("MXID")
            dr.Close()

            query = "INSERT INTO pengajuan (idPengajuan,namaPengajuan,bidang,jmlPermintaan,bentukDana,keperluan,tgl) VALUES (" & uid & ",'" & tbNama.Text & "','" & cbBidang.Text & "','" & tbPermintaan.Text & "','" & Tbbentuk.Text & "','" & tbKeperluan.Text & "','" & DateTimePicker1.Value & "')"
            cmd = New SqlCommand(query, conn)
            dr = cmd.ExecuteReader
            dr.Close()
            ListView1.Clear()
            hapus()
            tampilkan()


            MsgBox("Data pengajuan '" + tbNama.Text + "' Selesai Disimpan")
            Call closeKoneksi()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub tampilkan()
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader


        ListView1.View = View.Details
        ListView1.Columns.Add("No", 50)
        ListView1.Columns.Add("Nama Pelaksana", 300)
        ListView1.Columns.Add("Bidang", 150)
        ListView1.Columns.Add("Jumlah Permintaan", 200)
        ListView1.Columns.Add("Bentuk Dana", 200)
        ListView1.Columns.Add("Keperluan", 200)

        Call openKoneksi()
        Dim query_id As String = "select * from pengajuan"
        cmd = New SqlCommand(query_id, conn)
        dr = cmd.ExecuteReader

        Do While dr.Read
            ListView1.Items.Add(dr("idPengajuan"))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dr("namaPengajuan"))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dr("bidang"))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dr("jmlPermintaan"))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dr("bentukDana"))
            ListView1.Items(ListView1.Items.Count - 1).SubItems.Add(dr("keperluan"))
        Loop
        dr.Close()
        Call closeKoneksi()
    End Sub

    Private Sub hapus()
        tbNama.Text = ""
        tbKeperluan.Text = ""
        cbBidang.Text = ""
        tbPermintaan.Text = ""
        rbCek.Checked = False
        rbGiro.Checked = False
        rbTunai.Checked = False
    End Sub

    Private Sub btEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btEdit.Click
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader
        Dim idPengajuan As String

        Try
            idPengajuan = ListView1.SelectedItems(0).Text
            Call openKoneksi()
            Dim query As String = "select * from pengajuan where idPengajuan='" + idPengajuan + "'"

            cmd = New SqlCommand(query, conn)
            dr = cmd.ExecuteReader

            dr.Read()

            TBID.Text = dr("idPengajuan")
            tbNama.Text = dr("namaPengajuan")
            cbBidang.Text = dr("bidang")
            tbPermintaan.Text = dr("jmlPermintaan")
            tbKeperluan.Text = dr("keperluan")
            Tbbentuk.Text = dr("bentukdana")

            If Tbbentuk.Text = "Tunai" Then
                rbTunai.Checked = True
            ElseIf Tbbentuk.Text = "Cek Bank" Then
                rbCek.Checked = True
            ElseIf Tbbentuk.Text = "Giro" Then
                rbGiro.Checked = True
            End If
            dr.Close()
            Call closeKoneksi()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged
        btEdit.Enabled = True
    End Sub

    Private Sub btDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btDelete.Click
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader
        Dim idPengajuan As String

        Try
            idPengajuan = ListView1.SelectedItems(0).Text
            Call openKoneksi()
            Dim query As String = "delete from pengajuan where idPengajuan='" + idPengajuan + "'"
            cmd = New SqlCommand(query, conn)
            dr = cmd.ExecuteReader
            Call closeKoneksi()
            dr.Close()
            MsgBox("Udah dihapus coyyyy!!!!!!")
            ListView1.Clear()
            tampilkan()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btUpdate.Click
        Try
            Call openKoneksi()
            query_gl = "UPDATE pengajuan SET namaPengajuan = '" & tbNama.Text & "',bidang ='" & cbBidang.Text & "',jmlPermintaan = '" & tbPermintaan.Text & "',bentukDana = '" & Tbbentuk.Text & "',keperluan = '" & tbKeperluan.Text & "' WHERE idPengajuan = '" & TBID.Text & "'"
            cmd_gl = New SqlCommand(query_gl, conn)
            dr_gl = cmd_gl.ExecuteReader
            dr_gl.Close()
            Call closeKoneksi()
            hapus()
            ListView1.Clear()
            tampilkan()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub rbTunai_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbTunai.CheckedChanged
        Tbbentuk.Text = "Tunai"
    End Sub

    Private Sub rbCek_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbCek.CheckedChanged
        Tbbentuk.Text = "Cek Bank"
    End Sub

    Private Sub rbGiro_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbGiro.CheckedChanged
        Tbbentuk.Text = "Giro"
    End Sub
End Class
