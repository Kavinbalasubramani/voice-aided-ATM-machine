Imports System.Data.OleDb

Public Class fund
    Dim amount_transfer, balance, transfer, newbalance, newtransfer, response As Integer
    Private Sub fund_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ConnDB()
        Dim cmd As OleDbCommand = New OleDbCommand(("select balance FROM cust_data WHERE account_num ='" & Trim(dis.Text) & " '"), conn)
        Dim sdr As OleDbDataReader = cmd.ExecuteReader()
        While sdr.Read = True
            Label2.Text = (sdr(0).ToString())
        End While
        sdr.Close()
        conn = Nothing
    End Sub
    Private Sub btntransfer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntransfer.Click
        Try
            '  get Donors Balance
            ConnDB()
            Dim cmd As OleDbCommand = New OleDbCommand(("select balance FROM cust_data WHERE account_num ='" & Trim(dis.Text) & " '"), conn)
            Dim sdr As OleDbDataReader = cmd.ExecuteReader()
            While sdr.Read = True
                balance = (sdr(0).ToString())

            End While
            sdr.Close()
            conn = Nothing


            '  get recipient Balance
            ConnDB()
            Dim cmd1 As OleDbCommand = New OleDbCommand(("select balance FROM cust_data WHERE account_num ='" & Trim(txtaccount_num.Text) & " '"), conn)
            Dim sdr1 As OleDbDataReader = cmd1.ExecuteReader()
            While sdr1.Read = True
                transfer = (sdr1(0).ToString())
            End While
            sdr1.Close()
            conn = Nothing


            'CHECK IF THERE IS SUFFICIENT AMOUNT
            amount_transfer = txtamount.Text
            If balance > amount_transfer And balance >= 1000 Then
                'transaction
                newbalance = (balance) - (amount_transfer)
                Label2.Text = newbalance
                newtransfer = (amount_transfer) + (transfer)
                nnn.Text = newtransfer

                'update New your Balance
                sqL = "UPDATE cust_data SET balance = '" & newbalance & "' WHERE account_num = '" & dis.Text & "'"
                ConnDB()
                cmd = New OleDbCommand(sqL, conn)
                Dim i As Integer
                i = cmd.ExecuteNonQuery
                If i > 0 Then
                    MsgBox("Fund Transfered Successfully", MsgBoxStyle.Information, "Fund Transfer")
                    Dim SAPI
                    SAPI = CreateObject("SAPI.spvoice")
                    SAPI.speak("Fund Transfered Successfully")
                Else
                    MsgBox("Fund Transfered was Not Successful", MsgBoxStyle.Information, "Fund Transfer")
                    Dim SAPI
                    SAPI = CreateObject("SAPI.spvoice")
                    SAPI.speak("Fund Transfered was Not Successful")

                End If

                'update recipent Balance
                sqL = "UPDATE cust_data SET balance = '" & nnn.Text & "' WHERE account_num = '" & txtaccount_num.Text & "'"
                ConnDB()
                cmd = New OleDbCommand(sqL, conn)
                'Dim i As Integer
                i = cmd.ExecuteNonQuery

            ElseIf balance < amount_transfer Then
                MsgBox("Dear customer you have insufficient Balance " & balance)
            ElseIf balance <= 1000 Then
                MsgBox("Dear customer, the minimum fund transfer is 1000 ")
            End If

        Catch ex As Exception
        End Try
    End Sub
    Private Sub button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button2.Click
        Me.Close()
    End Sub
End Class