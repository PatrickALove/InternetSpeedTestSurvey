' Program Name: Internet Speed Test Survey
' Author      : Patrick Andrew Love
' Student ID  : 1683445
' Date        : 03/26/19
' Purpose     : This Windows Classic Desktop application finds the average speed of a home Internet connection
'               (see speedtest.net to measure your own connection's download speed).








Public Class frmInter
    Private Sub btnEnterInternetSpeed_Click(sender As Object, e As EventArgs) Handles btnEnterInternetSpeed.Click
        ' the btnEnterInternetSpeed_Click event accepts and displays up to 10 internet speed values
        ' and then calculates and displays the average speed for the user.

        'Declare and initialize variables
        Dim strInternetSpeed As String
        Dim decSpeed As Decimal
        Dim decAverageLoss As Decimal
        Dim decTotalSpeed As Decimal = 0D
        Dim strInputMessage As String = "Please enter the internet speed value #"
        Dim strInputHeading As String = "Internet Speed"
        Dim strNormalMessage As String = "Please enter the internet speed value #"
        Dim strNonNumericError As String = "Error- Please enter the internet speed value #"
        Dim strNegativeError As String = "Error- Please enter a positive number for the internet speed for value #"

        'Declare and initialize loop variables
        Dim strCancelClicked As String = ""
        Dim intMaxNumberOfEntries As Integer = 10
        Dim intNumberOfEntries As Integer = 1

        'This loop allows the user to enter the internet speed of 10 values.
        'the loop terminates when the user has entered 10 speed values or the user
        'clicks the Cancel button or the Close button in the InputBox
        strInternetSpeed = InputBox(strInputMessage & intNumberOfEntries, strInputHeading, " ")

        Do Until intNumberOfEntries > intMaxNumberOfEntries Or strInternetSpeed = strCancelClicked
            If IsNumeric(strInternetSpeed) Then
                decSpeed = Convert.ToDecimal(strInternetSpeed)
                If decSpeed > 0 Then
                    lstInternetSpeeds.Items.Add(decSpeed)
                    decTotalSpeed += decSpeed
                    intNumberOfEntries += 1
                    strInputMessage = strNormalMessage
                Else
                    strInputMessage = strNegativeError
                End If
            Else
                strInputMessage = strNonNumericError
            End If
            If intNumberOfEntries <= intMaxNumberOfEntries Then
                strInternetSpeed = InputBox(strInputMessage & intNumberOfEntries, strInputHeading, " ")
            End If
        Loop
        'Calculates and displays average internet speed for the user
        If intNumberOfEntries > 1 Then
            lblAverageInternetSpeed.Visible = True
            decAverageLoss = decTotalSpeed / (intNumberOfEntries - 1)
            lblAverageInternetSpeed.Text = "Average internet speed is " &
                decAverageLoss.ToString("F2") & " Mbps"
        Else
            MsgBox("No internet speed value entered")
        End If

        'disables the rainfall button
        btnEnterInternetSpeed.Enabled = False
    End Sub

    Private Sub mnuClear_Click(sender As Object, e As EventArgs) Handles mnuClear.Click
        ' The mnuClear_Click event clears the ListBox object and hides
        ' the average speed label. It also enables the Enter Internet Speed button

        lstInternetSpeeds.Items.Clear()
        lblAverageInternetSpeed.Visible = False
        btnEnterInternetSpeed.Enabled = True
    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        ' mnuExit_Click event closes the window and exits the application

        Close()
    End Sub
End Class
