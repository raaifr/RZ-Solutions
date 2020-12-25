Imports System.Net.Mail
Public Class ComController
    Public Self As String = "developer3601@gmail.com"

    Public Class Prefixes
        Public Shared Test As String = "TestFunc: "
        Public Shared AppError As String = "AppError: "
        Public Shared Reminder As String = "!Reminder: "
        Public Shared Debug As String = "Debug: "
    End Class

    Public Sub SendEmail(ByVal emailTo As String, ByVal subjectPrefix As String, ByVal emailSubject As String, ByVal emailBody As String)
        Dim mailmsg As MailMessage = New MailMessage("developer3601@gmail.com", emailTo)
        mailmsg.Subject = subjectPrefix + emailSubject
        mailmsg.Body = emailBody

        Using client As SmtpClient = New SmtpClient("smtp.gmail.com", 587)
            client.UseDefaultCredentials = False
            client.Credentials = New Net.NetworkCredential("developer3601@gmail.com", "mnantnsfcknlkqne")
            client.EnableSsl = True
            client.Send(mailmsg)
        End Using
    End Sub

End Class
