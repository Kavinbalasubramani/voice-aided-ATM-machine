Public Class Main

    Private Sub btnexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnexit.Click
        Application.Exit()
    End Sub
    Private Sub Btnwithdraw_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnwithdraw.Click
        Dim accountContents As String
        accountContents = Me.dis1.Text
        withdrawal.dis.Text = accountContents


        Dim SAPI
        SAPI = CreateObject("SAPI.spvoice")
        SAPI.speak("Withdraw Cash")
        withdrawal.Show()
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub btnbalance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbalance.Click
        Dim accountContents As String
        accountContents = Me.dis1.Text
        balance.dis.Text = accountContents


        Dim SAPI
        SAPI = CreateObject("SAPI.spvoice")
        SAPI.speak("Check Your Balance")
        balance.Show()
    End Sub

    Private Sub btnpin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpin.Click
        Dim accountContents As String
        accountContents = Me.dis1.Text
        changepin.dis.Text = accountContents
        changepin.txtaccountnum.Text = accountContents

        Dim SAPI
        SAPI = CreateObject("SAPI.spvoice")
        SAPI.speak("Change Your PIN ")
        changepin.Show()
    End Sub

    Private Sub btnfund_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfund.Click
        Dim accountContents As String
        accountContents = Me.dis1.Text
        fund.dis.Text = accountContents

        Dim SAPI
        SAPI = CreateObject("SAPI.spvoice")
        SAPI.speak("Transfer Fund")
        fund.Show()
    End Sub
End Class