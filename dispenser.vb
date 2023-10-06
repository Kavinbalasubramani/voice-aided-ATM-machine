Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.IO
Imports System.Data.OleDb
Public Class dispenser
    Dim withdraw, balance, newbalance, response As Integer
    Private Sub btnchk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnchk.Click
        Try
            ConnDB()
            ' create a new command object
            Dim cmd As OleDbCommand = New OleDbCommand(("select balance FROM cust_data WHERE account_num ='" & Trim(dis.Text) & " '"), conn)
            ' conn.Open()
            Dim sdr As OleDbDataReader = cmd.ExecuteReader()
            While sdr.Read = True
                btndisplay.Text = (sdr(0).ToString())
                Dim SAPI
                SAPI = CreateObject("SAPI.spvoice")
                SAPI.speak("Your Balance is" & btndisplay.Text)
            End While
            sdr.Close()
            conn = Nothing
        Catch ex As Exception
        End Try
        Label3.Visible = True
    End Sub
    Private Sub Dispenser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        wait.Visible = False
        pixloading.Visible = False
        take_money.Visible = False
        pixmoney.Visible = False
        Timer1.Interval = 4500
        Timer1.Enabled = False
        Label3.Visible = False
        Label1.Visible = False
        Label2.Visible = False
    End Sub
    Private Sub Btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn1.Click
        btndisplay.Text += Btn1.Text

        Dim SAPI
        SAPI = CreateObject("SAPI.spvoice")
        SAPI.speak(Btn1.Text)
    End Sub
    Private Sub Btn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn2.Click
        btndisplay.Text += Btn2.Text
        Dim SAPI
        SAPI = CreateObject("SAPI.spvoice")
        SAPI.speak(Btn2.Text)
    End Sub
    Private Sub Btn3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn3.Click
        btndisplay.Text += Btn3.Text
        Dim SAPI
        SAPI = CreateObject("SAPI.spvoice")
        SAPI.speak(Btn3.Text)
    End Sub
    Private Sub Btn4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn4.Click
        btndisplay.Text += Btn4.Text
        Dim SAPI
        SAPI = CreateObject("SAPI.spvoice")
        SAPI.speak(Btn4.Text)
    End Sub
    Private Sub Btn5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn5.Click
        btndisplay.Text += Btn5.Text
        Dim SAPI
        SAPI = CreateObject("SAPI.spvoice")
        SAPI.speak(Btn5.Text)
    End Sub
    Private Sub Btn6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn6.Click
        btndisplay.Text += Btn6.Text
        Dim SAPI
        SAPI = CreateObject("SAPI.spvoice")
        SAPI.speak(Btn6.Text)
    End Sub
    Private Sub Btn7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn7.Click
        btndisplay.Text += Btn7.Text
        Dim SAPI
        SAPI = CreateObject("SAPI.spvoice")
        SAPI.speak(Btn7.Text)
    End Sub
    Private Sub Btn8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn8.Click
        btndisplay.Text += Btn8.Text
        Dim SAPI
        SAPI = CreateObject("SAPI.spvoice")
        SAPI.speak(Btn8.Text)
    End Sub
    Private Sub Btn9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn9.Click
        btndisplay.Text += Btn9.Text
        Dim SAPI
        SAPI = CreateObject("SAPI.spvoice")
        SAPI.speak(Btn9.Text)
    End Sub
    Private Sub Btn0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn0.Click
        btndisplay.Text += Btn0.Text
        Dim SAPI
        SAPI = CreateObject("SAPI.spvoice")
        SAPI.speak(Btn0.Text)
    End Sub
    Private Sub btnwithdraw_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnwithdraw.Click
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

        End If
    End Sub
    Private Sub button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button1.Click
        Me.Close()
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        pixmoney.Visible = True
        take_money.Visible = True
        wait.Visible = False
        pixloading.Visible = False
    End Sub
    Private Sub Btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnclear.Click
        Try
            Dim loc As Integer
            'Get the length of the string
            loc = btndisplay.Text.Length
            'Remove the last character, incrementing by 1
            btndisplay.Text = btndisplay.Text.Remove(loc - 1)
            If btndisplay.Text = "" Then
                Dim SAPI
                SAPI = CreateObject("SAPI.spvoice")
                SAPI.speak("Screen Is Empty")
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If balance > withdraw Then
            wait.Visible = True
            pixloading.Visible = True
            Timer1.Enabled = True
        Else
            wait.Visible = False
            pixloading.Visible = False
            Timer1.Enabled = False
        End If
        Dim SAPI
        SAPI = CreateObject("SAPI.spvoice")
        SAPI.speak("Your balance is" & " " & btndisplay.Text & "  " & "Naira")
    End Sub
End Class