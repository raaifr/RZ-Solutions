Imports System.ComponentModel.DataAnnotations

Public Class ContactModel
    <Display(Name:="Name*")>
    <Required(ErrorMessage:="You need to provide us a name")>
    Public Property CustomerName As String

    <Display(Name:="Email*")>
    <Required(ErrorMessage:="You need to provide us an email")>
    <DataType(DataType.EmailAddress)>
    Public Property CustomerEmail As String

    <Display(Name:="Phone")>
    <DataType(DataType.PhoneNumber)>
    Public Property CustomerPhone As String

    <Display(Name:="Message*")>
    <Required(ErrorMessage:="You need to type in a message")>
    <DataType(DataType.MultilineText)>
    Public Property CustomerMsg As String

End Class
