Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Private coms As New ComController

    Function Index() As ActionResult
        Return View()
    End Function

    Function About() As ActionResult
        Return View()
    End Function

    <HttpGet>
    Function Contact() As ActionResult
        ViewBag.Success = TempData("Success")
        Return View()
    End Function

    <HttpPost>
    <ValidateAntiForgeryToken>
    Function Contact(model As ContactModel) As ActionResult
        Try
            If ModelState.IsValid Then
                Dim sb As New StringBuilder
                sb.AppendLine(model.CustomerName)
                sb.AppendLine(model.CustomerEmail)
                sb.AppendLine(model.CustomerPhone)
                sb.AppendLine(model.CustomerMsg)
                coms.SendEmail(coms.Self, "Contact: ", model.CustomerName, sb.ToString)
                ModelState.Clear()
                TempData("Success") = True
                Return RedirectToAction("Contact")
            Else
                Return View()
            End If
        Catch ex As Exception
            TempData("Success") = False
            Return View()
        End Try
    End Function


End Class
