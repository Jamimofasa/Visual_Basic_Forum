Public Class frmMain


    Private Sub BtnQuit_Click(sender As Object, e As EventArgs) Handles BtnQuit.Click

        'close the application
        Me.Close()

    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click

        'clear the screen of all text
        TxtFirstname.Text = ""
        TxtLastname.Text = ""
        lblResult.Text = ""

    End Sub

    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles BtnPrint.Click

        'concatentate frist name and last name
        lblResult.Text = "Hello : " + TxtFirstname.Text + " " + TxtLastname.Text

    End Sub
End Class
