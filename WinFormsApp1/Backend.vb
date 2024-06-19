Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json
Imports System.Threading.Tasks

Public Class Backend
    Private apiUrl As String = "http://localhost:3000"
    Private ReadOnly client As HttpClient

    Public Sub New()
        client = New HttpClient()
    End Sub

    Public Async Function SaveSubmissionAsync(submission As Submission) As Task
        Dim data As String = JsonConvert.SerializeObject(submission)
        Dim content As New StringContent(data, Encoding.UTF8, "application/json")
        Dim response As HttpResponseMessage = Await client.PostAsync(apiUrl & "/submit", content)
        response.EnsureSuccessStatusCode()
    End Function

    Public Async Function GetSubmissionAsync(index As Integer) As Task(Of Submission)
        Dim response As HttpResponseMessage = Await client.GetAsync(apiUrl & "/read?index=" & index)
        response.EnsureSuccessStatusCode()
        Dim responseData As String = Await response.Content.ReadAsStringAsync()
        Return JsonConvert.DeserializeObject(Of Submission)(responseData)
    End Function
End Class

Public Class Submission
    Public Property Name As String
    Public Property Email As String
    Public Property PhoneNumber As String
    Public Property GitHubLink As String
    Public Property TimeSpent As String
End Class
