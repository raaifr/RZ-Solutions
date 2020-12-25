@Code
    ViewData("Title") = "Products"
End Code

@Styles.Render("~/Content/productspage.css")

<div class="container-fluid">

    <div class="jumbotron text-center">
        <h1>Maple Library Management System</h1>
        <p>A modern and sleek system that includes kiosk machines and cutting edge contactless transactions, increasing productivity and minimizing staff utilization - paving towards new opportunities for the expansion and further development of the city public library to new and greater heights.</p>
        <p><a class="btn btn-lg btn-outline-light" href="http://www.maple.com" target="_blank" role="button">Maple</a></p>
    </div>



    <div class="container">

        <!-- Quotes / reviews -->
        <div class="row">
            <div class="col-lg-4">
                <img class="rounded-circle" src="@Url.Content("~/Content/core-images/tractor.jpg")" width="140" height="140">
                <blockquote class="blockquote">
                    <p class="mb-0">Trusted, Timely and meets client expectations</p>
                    <footer class="blockquote-footer">Jhon Deere <cite title="Source Title">Jhon & Dependents</cite></footer>
                </blockquote>
            </div>
            <div class="col-lg-4">
                <img class="rounded-circle" src="~/Content/core-images/solar.jpg" width="140" height="140">
                <blockquote class="blockquote">
                    <p class="mb-0">Very impressed by their work. One of the few companuies in the country that meets the highest of standards</p>
                    <footer class="blockquote-footer">Manager <cite title="Source Title">Son.mv</cite></footer>
                </blockquote>
            </div><!-- /.col-lg-4 -->
            <div class="col-lg-4">
                <img class="rounded-circle" src="~/Content/core-images/mic.jpg" width="140" height="140">
                <blockquote class="blockquote">
                    <p class="mb-0">Hulhumale based company, well known for their work in the public QR project have the highest delivery and success rate. Definitly worth a try!</p>
                    <footer class="blockquote-footer">Mariyam <cite title="Source Title">Evening News</cite></footer>
                </blockquote>
            </div>
        </div>

        <hr class="featurette-divider">

        <div class="row featurette">
            <div class="col-md-7">
                <h2 class="featurette-heading">Resort Management Solution</h2>
                <p class="lead">All aspects of a resort management are covered including booking, accounting, maintenance, cleaning, online booking, travel insurance, trusteeship etc.</p>
            </div>
            <div class="col-md-5">
                <img class="featurette-image img-fluid mx-auto" src="~/Content/core-images/resort.jpg">
            </div>
        </div>

        <hr class="featurette-divider">

        <div class="row featurette">
            <div class="col-md-7 order-md-2">
                <h2 class="featurette-heading">Public QR code Project</h2>
                <p class="lead">This pilot project involved the selection and QR Code labeling of physical locations within the city for which a user's experience could be significantly enhanced by a convenient portal to related services and resources. We initially focused on tourist attractions and high-use areas such as shops and mosques. A mobile web-based aggregation of services and resources that are specifically relevant to each labeled location previously developed are connected to support QR code-based service browsing. </p>

            </div>
            <div class="col-md-5 order-md-1">
                <img class="featurette-image img-fluid mx-auto" src="~/Content/core-images/qr.png">
            </div>
        </div>

        <hr class="featurette-divider">

        <div class="row featurette">
            <div class="col-md-7">
                <h2 class="featurette-heading">Warehouse Management and Automation System</h2>
                <p class="lead">This software solution helps control and manage the day-to-day operations in the client warehouse. WMS software guides inventory receiving and put-away, optimizes picking and shipping of orders and advises on inventory replenishment and projecting future stock needs. This was part of an Enterprise Resource Planning (ERP) system developed for a client.</p>
            </div>
            <div class="col-md-5">
                <img class="featurette-image img-fluid mx-auto" src="~/Content/core-images/warehouse.jpg" alt="Generic placeholder image">
            </div>
        </div>



    </div>

</div>