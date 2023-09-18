Public Class Form1
    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        ' Get the selected user type from the combo box
        Dim selectedUserType As String = cmbUserType.SelectedItem

        ' Get the entered username and password
        Dim userName As String = txtUserName.Text
        Dim password As String = txtPassword.Text

        ' Check if either username or password is empty
        If String.IsNullOrEmpty(userName) OrElse String.IsNullOrEmpty(password) Then
            MessageBox.Show("Please fill in both username and password fields.")
            Return ' Exit the method without further processing
        End If

        ' Check user credentials based on the selected user type
        If selectedUserType = "Admin" Then
            ' Check admin credentials
            If userName = "admin" AndAlso password = "admin123" Then
                ' Successful login for admin
                Dim adminForm As New Form3()
                adminForm.Show()
                Me.Hide()
            Else
                MessageBox.Show("Invalid admin credentials. Please try again.")
            End If
        ElseIf selectedUserType = "Doctor" Then
            ' Check doctor credentials 
            If userName = "doctor" AndAlso password = "doctor123" Then
                ' Successful login for doctor
                Dim doctorForm As New Form2()
                doctorForm.Show()
                Me.Hide()
            Else
                MessageBox.Show("Invalid doctor credentials. Please try again.")
            End If
        Else
            MessageBox.Show("Please select a valid user type.")
        End If
    End Sub





    Private Sub ListView2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView2.SelectedIndexChanged

    End Sub
    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        ' Clearing the text in the username and password textboxes
        txtUserName.Text = ""
        txtPassword.Text = ""

        ' Also clear the selected item in the combo box
        cmbUserType.SelectedIndex = -1 ' Set to -1 to deselect any item

    End Sub

    
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' Exit the application
        Application.Exit()
    End Sub
End Class
