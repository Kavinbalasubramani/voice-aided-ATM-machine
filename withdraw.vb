Imports System.Data.OleDb

Public Class Withdrawal
    Dim speaker As New SpeechSynthesizer()
    Dim withdraw, balance, newbalance, response As Integer
    Private Sub Withdrawal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        wait.Visible = False
        pixloading.Visible = False
        take_money.Visible = False
        pixmoney.Visible = False
        Timer1.Interval = 4000
        Timer1.Enabled = False
        'Label3.Visible = False
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_500.Click
        btndisplay.Text = btn_500.Text
        Dim SAPI
        SAPI = CreateObject("SAPI.spvoice")
        SAPI.speak("Five Hundred Naira")
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Close()
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim accountContents As String
        accountContents = Me.dis.Text
        Dispenser.dis.Text = accountContents
        Dispenser.Show()
    End Sub
    Private Sub btn_1000_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_1000.Click
        btndisplay.Text = btn_1000.Text
        Dim SAPI
        SAPI = CreateObject("SAPI.spvoice")
        SAPI.speak("One Thousand Naira")
    End Sub
    Private Sub btn_5000_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_5000.Click
        btndisplay.Text = btn_5000.Text
        Dim SAPI
        SAPI = CreateObject("SAPI.spvoice")
        SAPI.speak("Five Thousand Naira")
    End Sub
    Private Sub btn_10000_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_10000.Click
        btndisplay.Text = btn_10000.Text
        Dim SAPI
        SAPI = CreateObject("SAPI.spvoice")
        SAPI.speak("Ten Thousand Naira")
    End Sub
    Private Sub btn_20000_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_20000.Click
        btndisplay.Text = btn_20000.Text
        Dim SAPI
        SAPI = CreateObject("SAPI.spvoice")
        SAPI.speak("Twenty thousand Naira")
    End Sub
    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim SAPI
        SAPI = CreateObject("SAPI.spvoice")
        SAPI.speak("Withdraw Your Money")
        Try
            ConnDB()
            Dim cmd As OleDbCommand = New OleDbCommand(("select balance FROM cust_data WHERE account_num ='" & Trim(dis.Text) & " '"), conn)
            Dim sdr As OleDbDataReader = cmd.ExecuteReader()
            While sdr.Read = True
                balance = (sdr(0).ToString())
            End While
            sdr.Close()
            conn = Nothing

            'CHECK IF THERE IS SUFFICIENT AMOUNT
            withdraw = btndisplay.Text
            If balance > withdraw And balance > 1000 Then
                'transaction
                newbalance = (balance) - (withdraw)
                ' btndisplay.Text = newbalance

                'update New Balance


                sqL = "UPDATE cust_data SET balance = '" & newbalance & "' WHERE account_num = '" & dis.Text & "'"
            ConnDB()
            cmd = New OleDbCommand(sqL, conn)
            Dim i As Integer
            i = cmd.ExecuteNonQuery
            If i > 0 Then
                    MsgBox("Withdrawal was Successful", MsgBoxStyle.Information, "Withdraw info")
                    SAPI.speak("Your withdrawal transaction was Successful")
                    ' Else
                    '   MsgBox("Dear customer you have insufficient Balance", MsgBoxStyle.Information, "Withdraw info")
            End If
       
            cmd.Dispose()
            conn.Close()




            Else : MsgBox("Dear customer you have insufficient Balance")
            SAPI.speak("Dear customer you have insufficient Balance ")
            End If

        Catch ex As Exception
        End Try
        If balance > withdraw And balance > 1000 Then
            wait.Visible = True
            pixloading.Visible = True
            Timer1.Enabled = True
        Else
            wait.Visible = False
            pixloading.Visible = False
            Timer1.Enabled = False
            'Button15.Visible = False
        End If
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        pixmoney.Visible = True
        take_money.Visible = True
        wait.Visible = False
        pixloading.Visible = False
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
End Class