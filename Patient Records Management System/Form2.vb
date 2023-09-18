Public Class Form2

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label13.Click

    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        ' Creating an instance of Form4
        Dim form4 As New Form4()

        ' Show Form4
        form4.Show()

        ' Hide the current form (Form3)
        Me.Hide()
    End Sub

    Private Sub btnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        ' Collecting Patient Information from TextBox controls
        Dim surname As String = txtSurname.Text
        Dim givenName As String = txtGivenName.Text
        Dim dateOfBirth As String = txtDateofBirth.Text
        Dim gender As String = txtGender.Text
        Dim dateOfAdmit As String = txtDateofAdmit.Text
        Dim bloodGroup As String = txtBloodGroup.Text
        Dim disease As String = txtDisease.Text
        Dim department As String = txtDepartment.Text
        Dim doctorName As String = txtDoctorName.Text
        Dim phone As String = txtPhone.Text
        Dim address As String = txtAddress.Text
        Dim roomType As String = txtRoomType.Text
        Dim roomNumber As String = txtRoomNumber.Text
        Dim bed As String = txtBedNumber.Text

        ' Creating a message to display the patient's record
        Dim message As String = "Patient's Record Saved Successfully:" & vbCrLf & _
                                "Surname: " & surname & vbCrLf & _
                                "Given Name: " & givenName & vbCrLf & _
                                "Date of Birth: " & dateOfBirth & vbCrLf & _
                                "Gender: " & gender & vbCrLf & _
                                "Date of Admit: " & dateOfAdmit & vbCrLf & _
                                "Blood Group: " & bloodGroup & vbCrLf & _
                                "Disease: " & disease & vbCrLf & _
                                "Department: " & department & vbCrLf & _
                                "Doctor Name: " & doctorName & vbCrLf & _
                                "Phone: " & phone & vbCrLf & _
                                "Address: " & address & vbCrLf & _
                                "Room Type: " & roomType & vbCrLf & _
                                "Room Number: " & roomNumber & vbCrLf & _
                                "Bed: " & bed

        ' Displaying the message in a MessageBox
        MessageBox.Show(message, "Record Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class