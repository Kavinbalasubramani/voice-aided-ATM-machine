Imports System.Data.OleDb

Public Class changepin

    Private Sub button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button2.Click
        Me.Close()
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim SAPI
        SAPI = CreateObject("SAPI.spvoice")
        SAPI.speak("Change PIN")
        Timer1.Stop()
    End Sub
    Private Sub changepin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            ConnDB()
            Dim cmd As OleDbCommand = New OleDbCommand(("select * FROM cust_data WHERE account_num ='" & Trim(dis.Text) & " '"), conn)
            'conn.Open()
            Dim sdr As OleDbDataReader = cmd.ExecuteReader()
            While sdr.Read = True
                txtoldpin.Text = (sdr("pin").ToString())
                txtcustname.Text = (sdr("fullname").ToString())
            End While
            sdr.Close()
            conn = Nothing
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnchange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnchange.Click
        If txtnewpin.Text <> txtconfirmpin.Text Then
            Dim SAPI
            SAPI = CreateObject("SAPI.spvoice")
            SAPI.speak("Your Pin Numbers are not compatible")
            Label3.Text = ("Your Pin Numbers are not compatible")
        ElseIf txtnewpin.Text = txtconfirmpin.Text Then

            sqL = "UPDATE cust_data SET pin = '" & txtnewpin.Text & "' WHERE account_num = '" & txtaccountnum.Text & "'"
            ConnDB()
            cmd = New OleDbCommand(sqL, conn)
            Dim i As Integer
            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("PIN was Changed Successful and System will be shutdown now", MsgBoxStyle.Information, "Change PIN")
                Dim SAPI
                SAPI = CreateObject("SAPI.spvoice")
                SAPI.speak("PIN was Changed Successful")
                Application.Exit()

            Else
                MsgBox("Change of PIN was Not Successful", MsgBoxStyle.Information, "Change PIN")
                Dim SAPI
                SAPI = CreateObject("SAPI.spvoice")
                SAPI.speak("Change of PIN was Not Successful")

            End If

            cmd.Dispose()
            conn.Close()
        End If
    End Sub
End Class