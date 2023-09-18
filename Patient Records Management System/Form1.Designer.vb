<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Admin")
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Doctor")
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.ListView2 = New System.Windows.Forms.ListView
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtUserName = New System.Windows.Forms.TextBox
        Me.cmbUserType = New System.Windows.Forms.ComboBox
        Me.btnLogin = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnReset = New System.Windows.Forms.Button
        Me.txtPassword = New System.Windows.Forms.TextBox
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.Location = New System.Drawing.Point(35, 12)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(531, 90)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(140, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(411, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Patient's Record Management System"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(47, 21)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(75, 70)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'ListView2
        '
        Me.ListView2.BackColor = System.Drawing.Color.Silver
        Me.ListView2.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2})
        Me.ListView2.Location = New System.Drawing.Point(35, 155)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(531, 242)
        Me.ListView2.TabIndex = 3
        Me.ListView2.UseCompatibleStateImageBehavior = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(178, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(250, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Provide Your User Credentails"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Silver
        Me.Label3.Location = New System.Drawing.Point(121, 201)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "SELECT USER TYPE"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Silver
        Me.Label4.Location = New System.Drawing.Point(121, 250)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "USERNAME"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Silver
        Me.Label5.Location = New System.Drawing.Point(121, 295)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "PASSWORD"
        '
        'txtUserName
        '
        Me.txtUserName.Location = New System.Drawing.Point(252, 247)
        Me.txtUserName.Multiline = True
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(187, 30)
        Me.txtUserName.TabIndex = 8
        '
        'cmbUserType
        '
        Me.cmbUserType.FormattingEnabled = True
        Me.cmbUserType.Items.AddRange(New Object() {"Admin", "Doctor"})
        Me.cmbUserType.Location = New System.Drawing.Point(252, 198)
        Me.cmbUserType.Name = "cmbUserType"
        Me.cmbUserType.Size = New System.Drawing.Size(187, 21)
        Me.cmbUserType.TabIndex = 10
        Me.cmbUserType.Text = "Select User"
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(145, 337)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(124, 38)
        Me.btnLogin.TabIndex = 11
        Me.btnLogin.Text = "LOGIN"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(390, 337)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 38)
        Me.btnExit.TabIndex = 12
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(275, 337)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(97, 38)
        Me.btnReset.TabIndex = 13
        Me.btnReset.Text = "RESET"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(252, 292)
        Me.txtPassword.Multiline = True
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(187, 30)
        Me.txtPassword.TabIndex = 14
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(615, 428)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.cmbUserType)
        Me.Controls.Add(Me.txtUserName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ListView2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListView1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ListView2 As System.Windows.Forms.ListView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtUserName As System.Windows.Forms.TextBox
    Friend WithEvents cmbUserType As System.Windows.Forms.ComboBox
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox

End Class
