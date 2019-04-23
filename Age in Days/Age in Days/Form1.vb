'Age in Days Program made by Thomas Bernard


Public Class frmageindays
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblageindays.Click

    End Sub

    Private Sub btncalculate_Click(sender As Object, e As EventArgs) Handles btncalculate.Click
        'Declare Variables
        Dim intageinyears, intageindays As Integer

        'input - Get Info from Text Box and Put into intageinyears

        intageinyears = txtageinyears.Text

        'Processing

        intageindays = intageinyears * 365 ' Not Counting Leap Years

        'output

        lblageindays.Text = "Your Age in Days is: " & intageindays



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub
End Class
