Public Class Form4

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        ' Creating an instance of Form4
        Dim form2 As New Form2()

        ' Show Form4
        form2.Show()

        ' Hide the current form (Form3)
        Me.Hide()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        ' Colleting diagnosis information from TextBox controls
        Dim patientName As String = txtPatientName.Text
        Dim illnessDescription As String = txtIllnessDescription.Text
        Dim diagnosis As String = txtDiagnosis.Text
        Dim drugsAndInspection As String = txtDrugsAndInspection.Text
        Dim treatedBy As String = txtTreatedBy.Text
        Dim dateTime As String = txtDateTime.Text
        Dim treatmentDescription As String = txtTreatmentDescription.Text
        Dim prescription As String = txtPrescription.Text
        Dim drugsGiven As String = txtDrugsGiven.Text()
        Dim cost As String = txtCost.Text()
        Dim totalCost As Double = drugsGiven * cost

        ' Create a message to display the patient's record
        Dim message As String = "Patient's Record Saved Successfully:" & vbCrLf & _
                                "Patient Name: " & patientName & vbCrLf & _
                                "Illness Description: " & illnessDescription & vbCrLf & _
                                "Diagnosis: " & diagnosis & vbCrLf & _
                                "Drugs and Inspection: " & drugsAndInspection & vbCrLf & _
                                "Treated By: " & treatedBy & vbCrLf & _
                                "Date and Time: " & dateTime & vbCrLf & _
                                "Treatment Description: " & treatmentDescription & vbCrLf & _
                                "Prescription: " & prescription & vbCrLf & _
                                "Drugs Given: " & drugsGiven & vbCrLf & _
                                "Cost: " & cost & vbCrLf & _
                                "Total Cost: " & totalCost.ToString("C2")


        ' Display the message in a MessageBox
        MessageBox.Show(message, "Record Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ' Creating an instance of Form4
        Dim form5 As New Form5()

        ' Show Form4
        form5.Show()

        ' Hide the current form (Form3)
        Me.Hide()
    End Sub
End Class