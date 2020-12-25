<nav class="navbar navbar-expand-lg navbar-dark bg-dark">

    <a class="navbar-brand" href="#">
        <img src="~/Content/core-images/RZ.png" height="32" width="32" />
        RZ Solutions
    </a>

    <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarNavAltMarkup" aria-controls="navbarNavAltMarkup" aria-expanded="false" aria-label="Toggle navigation">
        <span class="navbar-toggler-icon"></span>
    </button>

    <div class="navbar-collapse collapse">
        <ul class="navbar-nav ml-auto ">
            <!-- ...ActionLink(Link Name, ControllerAction, Controller Name, new {  class = "nav-link" }) -->
            <li class="nav-item">@Html.ActionLink("Home", "Index", "Home", Nothing, New With {.class = "nav-link"})</li>
            <li class="nav-item">@Html.ActionLink("Products", "Products", "Product", Nothing, New With {.class = "nav-link"})</li>
            <li class="nav-item">@Html.ActionLink("About", "About", "Home", Nothing, New With {.class = "nav-link"})</li>
            <li class="nav-item">@Html.ActionLink("Contact", "Contact", "Home", Nothing, New With {.class = "nav-link"})</li>
        </ul>
    </div>

</nav>
