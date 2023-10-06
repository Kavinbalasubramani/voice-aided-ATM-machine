Imports System.Data.OleDb
Public Class Login

    Private Sub login()
        Try
            sqL = "SELECT * FROM cust_data WHERE account_num = '" & txtaccount_number.Text & "' AND pin ='" & txtPin.Text & "'"
            ConnDB()
            cmd = New OleDbCommand(sqL, conn)
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)

            If dr.Read = True Then
                Me.Hide()
                Main.Show()
                'transfer account Number
                Dim accountContents As String
                accountContents = txtaccount_number.Text
                Main.dis1.Text = accountContents
                MessageBox.Show("Login Accepted", "Login message")

            Else
                MessageBox.Show("Incorrect Account Number or PIN", "Login")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub
    Private Sub btnlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogin.Click
        login()
    End Sub
    Private Sub txtaccount_number_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtaccount_number.TextChanged
        Try
            ConnDB()
            Dim da As New OleDbDataAdapter(("select * from cust_data where account_num ='" & Trim(txtaccount_number.Text) & "'"), conn)
            Dim dt As New DataTable
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                Label3.Text = dt.Rows(0).Item("fullname") & ""

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        Me.Close()
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim SAPI
        SAPI = CreateObject("SAPI.spvoice")
        SAPI.speak("Please enter Your Account Number and PIN number Here")
        Timer1.Stop()
    End Sub

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub
End Class
