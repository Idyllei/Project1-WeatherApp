Public Class frmWeather
    Private Sub HideAllImages()
        'Set all images to being hidden.
        picHail.Visible = False
        picRain.Visible = False
        picSun.Visible = False
        picWind.Visible = False
    End Sub

    Private Sub EnableAllButtons()
        'Make sure each button can be pressed.
        btnHail.Enabled = True
        btnRainy.Enabled = True
        btnSunny.Enabled = True
        btnWindy.Enabled = True
    End Sub

    Private Sub ResetState()
        'Put the form back to its original state so we can modify it easily.
        HideAllImages()
        EnableAllButtons()
    End Sub

    Private Sub SetReport(msg As String)
        lblReport.Text = msg

        'Make sure the label is visible, just in case somewhere we turned it off.
        If lblReport.Visible = False Then
            lblReport.Visible = True
        End If
    End Sub

    Private Sub BtnSunny_Click(sender As Object, e As EventArgs) Handles btnSunny.Click
        'Show the image for Sunny weather; don't let the user click the btnSunny again.
        ResetState()
        picSun.Visible = True
        btnSunny.Enabled = False
        SetReport("What a beautiful sunny day!")
    End Sub

    Private Sub BtnRainy_Click(sender As Object, e As EventArgs) Handles btnRainy.Click
        'Show the image for Rainy weather; don't let the user click the btnRainy again.
        ResetState()
        picRain.Visible = True
        btnRainy.Enabled = False
        SetReport("Rain, rain, go away; come again another day!")
    End Sub

    Private Sub BtnHail_Click(sender As Object, e As EventArgs) Handles btnHail.Click
        'Show the image for Hail don't let the user click the btnHail again.
        ResetState()
        picHail.Visible = True
        btnHail.Enabled = False
        SetReport("White peas are falling from the sky!!!")
    End Sub

    Private Sub BtnWindy_Click(sender As Object, e As EventArgs) Handles btnWindy.Click
        'Show the image for Windy weather; don't let the user click the btnWindy again.
        ResetState()
        picWind.Visible = True
        btnWindy.Enabled = False
        SetReport("Mother Nature's sister, Gale, is paying us a visit!")
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Exit the program.
        Close()
    End Sub
End Class
