<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewSubmissionsForm
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
        btnPrevious = New Button()
        btnNext = New Button()
        Label1 = New Label()
        txtName = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        txtEmail = New TextBox()
        txtPhone = New TextBox()
        txtGitHub = New TextBox()
        txtTimeSpent = New TextBox()
        SuspendLayout()
        ' 
        ' btnPrevious
        ' 
        btnPrevious.BackColor = SystemColors.Info
        btnPrevious.Location = New Point(112, 278)
        btnPrevious.Name = "btnPrevious"
        btnPrevious.Size = New Size(75, 23)
        btnPrevious.TabIndex = 0
        btnPrevious.Text = "Previous"
        btnPrevious.UseVisualStyleBackColor = False
        ' 
        ' btnNext
        ' 
        btnNext.BackColor = SystemColors.ActiveCaption
        btnNext.Location = New Point(279, 278)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(75, 23)
        btnNext.TabIndex = 1
        btnNext.Text = "Next"
        btnNext.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(112, 38)
        Label1.Name = "Label1"
        Label1.Size = New Size(242, 15)
        Label1.TabIndex = 2
        Label1.Text = "Ishan Garg, Slidely Task 2 - View Submissions"
        ' 
        ' txtName
        ' 
        txtName.BackColor = SystemColors.ControlDark
        txtName.Location = New Point(210, 77)
        txtName.Name = "txtName"
        txtName.Size = New Size(144, 23)
        txtName.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(134, 85)
        Label2.Name = "Label2"
        Label2.Size = New Size(39, 15)
        Label2.TabIndex = 4
        Label2.Text = "Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(134, 114)
        Label3.Name = "Label3"
        Label3.Size = New Size(36, 15)
        Label3.TabIndex = 5
        Label3.Text = "Email"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(112, 145)
        Label4.Name = "Label4"
        Label4.Size = New Size(71, 15)
        Label4.TabIndex = 6
        Label4.Text = "Phone Num"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(112, 175)
        Label5.Name = "Label5"
        Label5.Size = New Size(68, 15)
        Label5.TabIndex = 7
        Label5.Text = "Github Link"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(112, 190)
        Label6.Name = "Label6"
        Label6.Size = New Size(61, 15)
        Label6.TabIndex = 8
        Label6.Text = " For Task 2"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(112, 220)
        Label7.Name = "Label7"
        Label7.Size = New Size(63, 15)
        Label7.TabIndex = 9
        Label7.Text = "Stopwatch"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(123, 235)
        Label8.Name = "Label8"
        Label8.Size = New Size(33, 15)
        Label8.TabIndex = 10
        Label8.Text = "Time"
        ' 
        ' txtEmail
        ' 
        txtEmail.BackColor = SystemColors.ControlDark
        txtEmail.Location = New Point(210, 106)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(144, 23)
        txtEmail.TabIndex = 11
        ' 
        ' txtPhone
        ' 
        txtPhone.BackColor = SystemColors.ControlDark
        txtPhone.Location = New Point(210, 137)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(144, 23)
        txtPhone.TabIndex = 12
        ' 
        ' txtGitHub
        ' 
        txtGitHub.BackColor = SystemColors.ControlDark
        txtGitHub.Location = New Point(210, 175)
        txtGitHub.Name = "txtGitHub"
        txtGitHub.Size = New Size(144, 23)
        txtGitHub.TabIndex = 13
        ' 
        ' txtTimeSpent
        ' 
        txtTimeSpent.BackColor = SystemColors.ControlDark
        txtTimeSpent.Location = New Point(210, 220)
        txtTimeSpent.Name = "txtTimeSpent"
        txtTimeSpent.Size = New Size(144, 23)
        txtTimeSpent.TabIndex = 14
        ' 
        ' ViewSubmissionsForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(479, 326)
        Controls.Add(txtTimeSpent)
        Controls.Add(txtGitHub)
        Controls.Add(txtPhone)
        Controls.Add(txtEmail)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(txtName)
        Controls.Add(Label1)
        Controls.Add(btnNext)
        Controls.Add(btnPrevious)
        Name = "ViewSubmissionsForm"
        Text = "ViewSubmissionsForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtGitHub As TextBox
    Friend WithEvents txtTimeSpent As TextBox
End Class
