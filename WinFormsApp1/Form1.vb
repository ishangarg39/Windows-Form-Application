Public Class Form1
    ' Define instances of the forms
    Private viewSubmissionsForm As ViewSubmissionsForm
    Private createSubmissionForm As CreateSubmissionForm
    Private backend As Backend

    ' Constructor
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Initialize backend
        backend = New Backend()

        ' Initialize forms
        viewSubmissionsForm = New ViewSubmissionsForm(backend)
        createSubmissionForm = New CreateSubmissionForm(backend)
    End Sub

    ' Handle View Submissions button click
    Private Sub btnViewSubmissions_Click(sender As Object, e As EventArgs) Handles btnViewSubmissions.Click
        viewSubmissionsForm.Show()
    End Sub

    ' Handle Create New Submission button click
    Private Sub btnCreateSubmission_Click(sender As Object, e As EventArgs) Handles btnCreateSubmission.Click
        createSubmissionForm.Show()
    End Sub

    ' Handles Shortcuts
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        If keyData = (Keys.Control Or Keys.V) Then
            btnViewSubmissions.PerformClick()
            Return True
        End If

        If keyData = (Keys.Control Or Keys.N) Then
            btnCreateSubmission.PerformClick()
            Return True
        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Any initialization logic can go here
    End Sub
End Class
