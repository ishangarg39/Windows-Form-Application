<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateSubmissionForm
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
        txtStopwatch = New TextBox()
        txtGitHub = New TextBox()
        txtPhone = New TextBox()
        txtEmail = New TextBox()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        txtName = New TextBox()
        Label1 = New Label()
        btnSubmit = New Button()
        btnStopwatch = New Button()
        SuspendLayout()
        ' 
        ' txtStopwatch
        ' 
        txtStopwatch.BackColor = SystemColors.ControlDark
        txtStopwatch.Location = New Point(258, 219)
        txtStopwatch.Name = "txtStopwatch"
        txtStopwatch.Size = New Size(109, 23)
        txtStopwatch.TabIndex = 29
        ' 
        ' txtGitHub
        ' 
        txtGitHub.BackColor = SystemColors.ControlLightLight
        txtGitHub.Location = New Point(223, 174)
        txtGitHub.Name = "txtGitHub"
        txtGitHub.Size = New Size(144, 23)
        txtGitHub.TabIndex = 28
        ' 
        ' txtPhone
        ' 
        txtPhone.BackColor = SystemColors.ControlLightLight
        txtPhone.Location = New Point(223, 136)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(144, 23)
        txtPhone.TabIndex = 27
        ' 
        ' txtEmail
        ' 
        txtEmail.BackColor = SystemColors.ControlLightLight
        txtEmail.Location = New Point(223, 105)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(144, 23)
        txtEmail.TabIndex = 26
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(125, 189)
        Label6.Name = "Label6"
        Label6.Size = New Size(61, 15)
        Label6.TabIndex = 23
        Label6.Text = " For Task 2"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(125, 174)
        Label5.Name = "Label5"
        Label5.Size = New Size(68, 15)
        Label5.TabIndex = 22
        Label5.Text = "Github Link"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(125, 144)
        Label4.Name = "Label4"
        Label4.Size = New Size(71, 15)
        Label4.TabIndex = 21
        Label4.Text = "Phone Num"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(147, 113)
        Label3.Name = "Label3"
        Label3.Size = New Size(36, 15)
        Label3.TabIndex = 20
        Label3.Text = "Email"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(147, 84)
        Label2.Name = "Label2"
        Label2.Size = New Size(39, 15)
        Label2.TabIndex = 19
        Label2.Text = "Name"
        ' 
        ' txtName
        ' 
        txtName.BackColor = SystemColors.ControlLightLight
        txtName.Location = New Point(223, 76)
        txtName.Name = "txtName"
        txtName.Size = New Size(144, 23)
        txtName.TabIndex = 18
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(125, 37)
        Label1.Name = "Label1"
        Label1.Size = New Size(251, 15)
        Label1.TabIndex = 17
        Label1.Text = "Ishan Garg, Slidely Task 2 - Create Submissions"
        ' 
        ' btnSubmit
        ' 
        btnSubmit.BackColor = SystemColors.ActiveCaption
        btnSubmit.Location = New Point(125, 265)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(242, 23)
        btnSubmit.TabIndex = 16
        btnSubmit.Text = "SUBMIT"
        btnSubmit.UseVisualStyleBackColor = False
        ' 
        ' btnStopwatch
        ' 
        btnStopwatch.BackColor = SystemColors.Info
        btnStopwatch.Location = New Point(125, 219)
        btnStopwatch.Name = "btnStopwatch"
        btnStopwatch.Size = New Size(127, 23)
        btnStopwatch.TabIndex = 15
        btnStopwatch.Text = "TOGGLE SOTPWATCH"
        btnStopwatch.UseVisualStyleBackColor = False
        ' 
        ' CreateSubmissionForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(492, 337)
        Controls.Add(txtStopwatch)
        Controls.Add(txtGitHub)
        Controls.Add(txtPhone)
        Controls.Add(txtEmail)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(txtName)
        Controls.Add(Label1)
        Controls.Add(btnSubmit)
        Controls.Add(btnStopwatch)
        Name = "CreateSubmissionForm"
        Text = "CreateSubmissionForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtStopwatch As TextBox
    Friend WithEvents txtGitHub As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnStopwatch As Button
End Class
