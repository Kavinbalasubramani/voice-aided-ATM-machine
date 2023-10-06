Public Class welcome

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim SAPI
        SAPI = CreateObject("SAPI.spvoice")
        SAPI.speak("Welcome to a voice Aided ATM for blind Customers")

        Timer1.Stop()
        Me.Hide()
        Login.Show()
    End Sub
    Private Sub welcome_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
    End Sub
End Class