<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtPatientName = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser
        Me.Label6 = New System.Windows.Forms.Label
        Me.btnLogin = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnBack = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtDateTime = New System.Windows.Forms.DateTimePicker
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtTreatmentDescription = New System.Windows.Forms.TextBox
        Me.txtIllnessDescription = New System.Windows.Forms.TextBox
        Me.txtDiagnosis = New System.Windows.Forms.TextBox
        Me.txtDrugsAndInspection = New System.Windows.Forms.TextBox
        Me.txtTreatedBy = New System.Windows.Forms.TextBox
        Me.txtPrescription = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Button3 = New System.Windows.Forms.Button
        Me.txtDrugsGiven = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtCost = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PATIENT NAME"
        '
        'txtPatientName
        '
        Me.txtPatientName.Location = New System.Drawing.Point(38, 60)
        Me.txtPatientName.Multiline = True
        Me.txtPatientName.Name = "txtPatientName"
        Me.txtPatientName.Size = New System.Drawing.Size(271, 31)
        Me.txtPatientName.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 238)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(140, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "DRUGS AND INSPECTION"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(35, 175)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "DIAGNOSIS"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(35, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "ILLNESS DESRIPTION"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(35, 301)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "TREATED BY"
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(38, 419)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(641, 31)
        Me.WebBrowser1.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(41, 403)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "ATTACHMENT"
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(185, 456)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(124, 38)
        Me.btnLogin.TabIndex = 12
        Me.btnLogin.Text = "CLEAR"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(38, 456)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(124, 38)
        Me.btnSave.TabIndex = 13
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(404, 456)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(124, 38)
        Me.btnBack.TabIndex = 14
        Me.btnBack.Text = "BACK"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(401, 44)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "DATE AND TIME"
        '
        'txtDateTime
        '
        Me.txtDateTime.Location = New System.Drawing.Point(397, 71)
        Me.txtDateTime.Name = "txtDateTime"
        Me.txtDateTime.Size = New System.Drawing.Size(264, 20)
        Me.txtDateTime.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(401, 108)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(143, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "TREATMENT DESRIPTION"
        '
        'txtTreatmentDescription
        '
        Me.txtTreatmentDescription.Location = New System.Drawing.Point(397, 133)
        Me.txtTreatmentDescription.Multiline = True
        Me.txtTreatmentDescription.Name = "txtTreatmentDescription"
        Me.txtTreatmentDescription.Size = New System.Drawing.Size(271, 39)
        Me.txtTreatmentDescription.TabIndex = 18
        '
        'txtIllnessDescription
        '
        Me.txtIllnessDescription.Location = New System.Drawing.Point(38, 131)
        Me.txtIllnessDescription.Multiline = True
        Me.txtIllnessDescription.Name = "txtIllnessDescription"
        Me.txtIllnessDescription.Size = New System.Drawing.Size(271, 31)
        Me.txtIllnessDescription.TabIndex = 19
        '
        'txtDiagnosis
        '
        Me.txtDiagnosis.Location = New System.Drawing.Point(38, 191)
        Me.txtDiagnosis.Multiline = True
        Me.txtDiagnosis.Name = "txtDiagnosis"
        Me.txtDiagnosis.Size = New System.Drawing.Size(271, 31)
        Me.txtDiagnosis.TabIndex = 20
        '
        'txtDrugsAndInspection
        '
        Me.txtDrugsAndInspection.Location = New System.Drawing.Point(38, 254)
        Me.txtDrugsAndInspection.Multiline = True
        Me.txtDrugsAndInspection.Name = "txtDrugsAndInspection"
        Me.txtDrugsAndInspection.Size = New System.Drawing.Size(271, 31)
        Me.txtDrugsAndInspection.TabIndex = 21
        '
        'txtTreatedBy
        '
        Me.txtTreatedBy.Location = New System.Drawing.Point(38, 317)
        Me.txtTreatedBy.Multiline = True
        Me.txtTreatedBy.Name = "txtTreatedBy"
        Me.txtTreatedBy.Size = New System.Drawing.Size(271, 31)
        Me.txtTreatedBy.TabIndex = 22
        '
        'txtPrescription
        '
        Me.txtPrescription.Location = New System.Drawing.Point(397, 212)
        Me.txtPrescription.Multiline = True
        Me.txtPrescription.Name = "txtPrescription"
        Me.txtPrescription.Size = New System.Drawing.Size(271, 39)
        Me.txtPrescription.TabIndex = 24
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(401, 194)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 13)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "PRESCRIPTION"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(195, 9)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(257, 25)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Patient Diagnosis Form"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(534, 456)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(124, 38)
        Me.Button3.TabIndex = 26
        Me.Button3.Text = "NEXT"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'txtDrugsGiven
        '
        Me.txtDrugsGiven.Location = New System.Drawing.Point(397, 283)
        Me.txtDrugsGiven.Multiline = True
        Me.txtDrugsGiven.Name = "txtDrugsGiven"
        Me.txtDrugsGiven.Size = New System.Drawing.Size(271, 31)
        Me.txtDrugsGiven.TabIndex = 28
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(394, 267)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(82, 13)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "DRUGS GIVEN"
        '
        'txtCost
        '
        Me.txtCost.Location = New System.Drawing.Point(397, 336)
        Me.txtCost.Multiline = True
        Me.txtCost.Name = "txtCost"
        Me.txtCost.Size = New System.Drawing.Size(271, 31)
        Me.txtCost.TabIndex = 30
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(394, 320)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(36, 13)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "COST"
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(706, 519)
        Me.Controls.Add(Me.txtCost)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtDrugsGiven)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtPrescription)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtTreatedBy)
        Me.Controls.Add(Me.txtDrugsAndInspection)
        Me.Controls.Add(Me.txtDiagnosis)
        Me.Controls.Add(Me.txtIllnessDescription)
        Me.Controls.Add(Me.txtTreatmentDescription)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtDateTime)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPatientName)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form4"
        Me.Text = "Form4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPatientName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtDateTime As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtTreatmentDescription As System.Windows.Forms.TextBox
    Friend WithEvents txtIllnessDescription As System.Windows.Forms.TextBox
    Friend WithEvents txtDiagnosis As System.Windows.Forms.TextBox
    Friend WithEvents txtDrugsAndInspection As System.Windows.Forms.TextBox
    Friend WithEvents txtTreatedBy As System.Windows.Forms.TextBox
    Friend WithEvents txtPrescription As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents txtDrugsGiven As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtCost As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
End Class
