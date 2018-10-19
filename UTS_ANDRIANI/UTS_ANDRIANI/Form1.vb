Imports System.Data.SqlClient
Public Class Form1
    Dim cmd_gl As SqlCommand
    Dim dr_gl As SqlDataReader
    Dim query_gl As String

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call bukaKoneksi()
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader
        Dim strsql As String

        Try
            strsql = "select * from Transport"
            cmd = New SqlCommand(strsql, conn)
            dr = cmd.ExecuteReader
            cbtransportation.Items.Clear()
            Do While dr.Read
                cbtransportation.Items.Add(dr("Transport"))
            Loop
            Call tutupKoneksi()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        tampilkan()
        DateTimePicker1.Value = Now
        tbid.Visible = False
        tbother.Visible = False
    End Sub

    Private Sub btsend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btsend.Click
        Dim query As String
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader
        Dim uid As String

        Try
            Call bukaKoneksi()
            Dim query_id As String = "SELECT MAX(requestId)+1 AS MXID FROM Transportation"
            cmd = New SqlCommand(query_id, conn)
            dr = cmd.ExecuteReader
            dr.Read()
            uid = dr("MXID")
            dr.Close()

            If tbother.Text = "Other               " Then
                query = "INSERT INTO Transportation(RequestId,NameRequestor,RequestorId,Unit,DateIssue,UnitDestination,acRegis,Transportation,Phone,Instruction) VALUES (" & uid & ",'" & tbname.Text & "','" & tbidnumber.Text & "','" & tbunit.Text & "','" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "','" & tbTo.Text & "','" & tbreg.Text & "','" & cbtransportation.Text & "','" & tbphone.Text & "','" & tbIndtruction.Text & "')"
            Else
                query = "INSERT INTO Transportation(RequestId,NameRequestor,RequestorId,Unit,DateIssue,UnitDestination,acRegis,Transportation,Phone,Instruction) VALUES (" & uid & ",'" & tbname.Text & "','" & tbidnumber.Text & "','" & tbunit.Text & "','" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "','" & tbTo.Text & "','" & tbreg.Text & "','" & cbtransportation.Text & "','" & tbphone.Text & "','" & tbIndtruction.Text & "')"

            End If

            cmd = New SqlCommand(query, conn)
            dr = cmd.ExecuteReader
            dr.Close()

            MsgBox("REQUEST DATA '" + tbname.Text + "' ALREADY SAVED -v-")
            Lv1.Clear()
            tampilkan()
            Call tutupKoneksi()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub bersih()
        tbname.Text = ""
        tbidnumber.Text = ""
        tbunit.Text = ""
        tbTo.Text = ""
        tbreg.Text = ""
        cbtransportation.Text = ""
        tbphone.Text = ""
        tbIndtruction.Text = ""
    End Sub

    Private Sub tampilkan()
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader

        Lv1.View = View.Details
        Lv1.Columns.Add("NO", 30)
        Lv1.Columns.Add("Name of Requestor", 200)
        Lv1.Columns.Add("Unit From", 100)
        Lv1.Columns.Add("Unit To", 100)
        Lv1.Columns.Add("Request Date", 100)
        Lv1.Columns.Add("Transportation", 100)

        Try
            Call bukaKoneksi()
            Dim query_id As String = "select * from Transportation"
            cmd = New SqlCommand(query_id, conn)
            dr = cmd.ExecuteReader

            Do While dr.Read
                Lv1.Items.Add(dr("RequestId"))
                Lv1.Items(Lv1.Items.Count - 1).SubItems.Add(dr("NameRequestor"))
                Lv1.Items(Lv1.Items.Count - 1).SubItems.Add(dr("Unit"))
                Lv1.Items(Lv1.Items.Count - 1).SubItems.Add(dr("UnitDestination"))
                Lv1.Items(Lv1.Items.Count - 1).SubItems.Add(dr("DateIssue"))
                Lv1.Items(Lv1.Items.Count - 1).SubItems.Add(dr("Transportation"))
            Loop
            dr.Close()
            Call tutupKoneksi()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btedit.Click
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader
        Dim requestId As String

        Try
            requestId = Lv1.SelectedItems(0).Text
            Call bukaKoneksi()
            Dim query As String = "select * from Transportation where RequestId='" + requestId + "'"

            cmd = New SqlCommand(query, conn)
            dr = cmd.ExecuteReader

            dr.Read()
            tbid.Text = dr("RequestId")
            tbname.Text = dr("NameRequestor")
            tbidnumber.Text = dr("RequestorId")
            tbunit.Text = dr("Unit")
            tbTo.Text = dr("UnitDestination")
            tbreg.Text = dr("acRegis")
            cbtransportation.Text = dr("Transportation")
            tbphone.Text = dr("Phone")
            tbIndtruction.Text = dr("Instruction")
            dr.Close()
            Call tutupKoneksi()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Lv1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lv1.SelectedIndexChanged
        btedit.Enabled = True

    End Sub

    Private Sub btdelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btdelete.Click
        Dim cmd As SqlCommand
        Dim dr As SqlDataReader
        Dim requestId As String

        Try
            requestId = Lv1.SelectedItems(0).Text
            Call bukaKoneksi()
            Dim query As String = "delete from Transportation where RequestId='" + requestId + "'"
            cmd = New SqlCommand(query, conn)
            dr = cmd.ExecuteReader
            Call tutupKoneksi()
            dr.Close()
            MsgBox("sudah dihapus")
            Lv1.Clear()
            tampilkan()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btupdate.Click
        Try
            Call bukaKoneksi()
            query_gl = "UPDATE Transportation SET NameRequestor = '" & tbname.Text & "',RequestorId = '" & tbidnumber.Text & "',Unit ='" & tbunit.Text & "',UnitDestination = '" & tbTo.Text & "',acRegis = '" & tbreg.Text & "',Transportation = '" & cbtransportation.Text & "',Phone = '" & tbphone.Text & "',Instruction = '" & tbIndtruction.Text & "' WHERE RequestId = '" & tbid.Text & "'"
            cmd_gl = New SqlCommand(query_gl, conn)
            dr_gl = cmd_gl.ExecuteReader
            dr_gl.Close()
            Call tutupKoneksi()
            bersih()
            Lv1.Clear()
            tampilkan()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub cbtransportation_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbtransportation.SelectedIndexChanged
        If cbtransportation.Text = "Other               " Then
            tbother.Visible = True
        Else
            tbother.Visible = False
        End If
    End Sub
End Class
