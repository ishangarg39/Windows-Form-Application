Imports System.Diagnostics
Imports System.Windows.Forms
Imports System.Threading.Tasks

Public Class CreateSubmissionForm
    Private backend As Backend
    Private stopwatch As New Stopwatch()
    Private timer As New Timer()

    Public Sub New(backendInstance As Backend)
        ' This call is required by the designer.
        InitializeComponent()
        backend = backendInstance

        ' Initialize the timer
        timer.Interval = 1000 ' Update every second
        AddHandler timer.Tick, AddressOf Timer_Tick
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs)
        txtStopwatch.Text = stopwatch.Elapsed.ToString("hh\:mm\:ss")
    End Sub

    Private Sub btnStopwatch_Click(sender As Object, e As EventArgs) Handles btnStopwatch.Click
        If stopwatch.IsRunning Then
            stopwatch.Stop()
            timer.Stop()
            btnStopwatch.Text = "Start Stopwatch"
        Else
            stopwatch.Start()
            timer.Start()
            btnStopwatch.Text = "Stop Stopwatch"
        End If
    End Sub

    Private Async Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim submission As New Submission With {
            .Name = txtName.Text,
            .Email = txtEmail.Text,
            .PhoneNumber = txtPhone.Text,
            .GitHubLink = txtGitHub.Text,
            .TimeSpent = stopwatch.Elapsed.ToString("hh\:mm\:ss")
        }
        Try
            Await backend.SaveSubmissionAsync(submission)
            MessageBox.Show("Submission saved successfully!")
        Catch ex As Exception
            MessageBox.Show("Error saving submission: " & ex.Message)
        End Try
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        If keyData = (Keys.Control Or Keys.S) Then
            btnSubmit.PerformClick()
            Return True
        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function
End Class
