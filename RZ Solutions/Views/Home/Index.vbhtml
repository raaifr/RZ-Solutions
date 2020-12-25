@Code
    ViewData("Title") = "Index"
    Layout = "~/Views/Shared/_LayoutPageHome.vbhtml"
End Code

@Styles.Render("~/Content/sharedHomepage.css")

<div class="container-fluid bg-overlay text-center" id="welc">


    <h1>Connecting you to your Dreams</h1>

    <br />
    <br />
    <br />

    <input type="button" class="btn btn-outline-light" value="Get a Quote" onclick="location.href='@Url.Action("Contact", "Home")'" />

    <input type="button" class="btn btn-dark" value="View Portfolio" onclick="location.href='@Url.Action("Products", "Product")'" />

</div>

