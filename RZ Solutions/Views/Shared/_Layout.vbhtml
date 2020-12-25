<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link runat="server" rel="shortcut icon" href="/Content/core-images/favicon.ico" type="image/x-icon" />
    <link runat="server" rel="icon" href="/Content/core-images/favicon.ico" type="image/ico" />

    <title>@ViewBag.Title - My ASP.NET Application</title>
    @Styles.Render("~/Content/css")
    @Styles.Render("~/Content/css/sharedpage.css")
    @Scripts.Render("~/bundles/modernizr")
</head>
<body>

    @Html.Partial("_PartialNavbar_main")

    <div class="container-fluid">
        @RenderBody()
        <hr />
        <footer>
            <p>&copy; @DateTime.Now.Year - RZ Solutions Pvt. Ltd</p>
        </footer>
    </div>

    @Scripts.Render("~/bundles/jquery")
    @Scripts.Render("~/bundles/bootstrap")
    @RenderSection("scripts", required:=False)
</body>
</html>
