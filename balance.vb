Imports System.Data.OleDb
Public Class balance

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Close()
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim SAPI
        SAPI = CreateObject("SAPI.spvoice")
        SAPI.speak("Your Balance is " & ibldisplay.Text & "Naira")
        Timer1.Stop()
    End Sub

    Private Sub balance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            ConnDB()
            Dim cmd As OleDbCommand = New OleDbCommand(("select balance FROM cust_data WHERE account_num ='" & Trim(dis.Text) & " '"), conn)
            'conn.Open()
            Dim sdr As OleDbDataReader = cmd.ExecuteReader()
            While sdr.Read = True
                ibldisplay.Text = (sdr(0).ToString())
            End While
            sdr.Close()
            conn = Nothing
        Catch ex As Exception
        End Try
    End Sub
End Class