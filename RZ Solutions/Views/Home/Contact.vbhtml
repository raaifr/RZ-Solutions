@ModelType RZ_Solutions.ContactModel
@Code
    ViewData("Title") = "Contact"
End Code

@Styles.Render("~/Content/ContactPage.css")

@If Not ViewBag.Success = Nothing And ViewBag.Success Then
    @<div class="alert alert-success" role="alert">
        We have received your message and would like to thank you for writing to us. If your inquiry is urgent, please use the telephone number listed below to talk to one of our staff members. Otherwise, we will reply by email as soon as possible.
    </div>
End If


<div class="row">
    <div class="col-md-6">
        <!-- form-->
        <div class="container-fluid">

            <div class="login-form">

                <div class="main-div">

                    @Using (Html.BeginForm("Contact", "Home"))
                        @Html.AntiForgeryToken
                        @Html.ValidationSummary(False, "", New With {.class = "text-danger"})

                        @<div class="form-row">
                            @Html.EditorFor(Function(model) model.CustomerName, New With {.htmlAttributes = New With {.placeholder = "Name*", .id = "inputName", .class = "form-group form-control"}})
                        </div>

                        @<div class="form-row">
                            @Html.EditorFor(Function(model) model.CustomerEmail, New With {.htmlAttributes = New With {.placeholder = "Email*", .id = "inputEmail", .class = "form-group form-control"}})
                            @Html.EditorFor(Function(model) model.CustomerPhone, New With {.htmlAttributes = New With {.placeholder = "Phone", .id = "inputPhone", .class = "form-group form-control"}})
                        </div>

                        @<div class="form-row">
                            @Html.EditorFor(Function(model) model.CustomerMsg, New With {.htmlAttributes = New With {.id = "inputMsg", .rows = "3", .placeholder = "Your Message Here *. . .", .class = "form-group form-control"}})
                        </div>

                        @<button Class="btn btn-dark" id="btnSubmit" submit">Submit</button>


                    End using

                </div>
            </div>
        </div>


    </div>
    <div class="col-md-6">
        <div class="row h-100 flex-column">
            <div class="col-md-6">
                Wihcester Garden Flr.5
                <br />
                Nirolhu Magu
                <br />
                28008 Hulhumale
                <br />
                Maldives

                <p>Tel: +960 332-4567</p>
                <p>Fax: +960 600-4567</p>
            </div>
            <div class="col-md-6 mw-100">
                <iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d2815.122341669315!2d-123.1157914845459!3d45.123856564109445!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x0%3A0x0!2zNDXCsDA3JzI1LjkiTiAxMjPCsDA2JzQ5LjAiVw!5e0!3m2!1sen!2smv!4v1602916027705!5m2!1sen!2smv" frameborder="0" style="border:0;"></iframe>
            </div>
        </div>
    </div>
</div>



@Section Scripts
    @Scripts.Render("~/bundles/jqueryval")
End Section
