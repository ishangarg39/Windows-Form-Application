Imports System.Threading.Tasks
Imports System.Windows.Forms

Public Class ViewSubmissionsForm
    Private backend As Backend
    Private currentIndex As Integer = 0

    Public Sub New(backendInstance As Backend)
        InitializeComponent()
        backend = backendInstance
    End Sub

    Private Async Sub ViewSubmissionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Await LoadSubmission(currentIndex)
    End Sub

    Private Async Function LoadSubmission(index As Integer) As Task
        Try
            Dim submission = Await backend.GetSubmissionAsync(index)
            If submission IsNot Nothing Then
                txtName.Text = submission.Name
                txtEmail.Text = submission.Email
                txtPhone.Text = submission.PhoneNumber
                txtGitHub.Text = submission.GitHubLink
                txtTimeSpent.Text = submission.TimeSpent
            Else
                MessageBox.Show("Submission not found.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error loading submission: " & ex.Message)
        End Try
    End Function

    Private Async Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        currentIndex += 1
        Await LoadSubmission(currentIndex)
    End Sub

    Private Async Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            Await LoadSubmission(currentIndex)
        Else
            MessageBox.Show("No previous submissions.")
        End If
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        If keyData = (Keys.Control Or Keys.P) Then
            btnPrevious.PerformClick()
            Return True
        End If

        If keyData = (Keys.Control Or Keys.N) Then
            btnNext.PerformClick()
            Return True
        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function
End Class
