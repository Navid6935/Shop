<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>@ViewBag.Title - SpadWear</title>
    @Styles.Render("~/Content/css")
    @Scripts.Render("~/bundles/modernizr")

</head>
<body>
    <div class="navbar navbar-inverse navbar-fixed-top">
        <div class="container">
            <div class="navbar-header">
                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
                <h1>
                    @Html.ActionLink("SpadWear", "Index", "Home", New With {.area = ""}, New With {.class = "navbar-brand"})
                </h1>
            </div>
            <div class="navbar-collapse collapse pull-left">
                <ul class="nav navbar-nav">
                    <li>@Html.ActionLink("صفحه اصلی", "Index", "Home")</li>
                    <li>@Html.ActionLink("درباره ما", "About", "Home")</li>
                    <li>@Html.ActionLink("تماس با ما", "Contact", "Home")</li>
                </ul>
                @Html.Partial("_LoginPartial")
            </div>
        </div>
    </div>
    <div class="container body-content">
        @RenderBody()
        <hr />
        <footer>
            <p>&copy; @DateTime.Now.Year - استفاده از مطالب فروشگاه اینترنتی اسپاد فقط برای مقاصد غیرتجاری و با ذکر منبع بلامانع است. کلیه حقوق این سایت متعلق به شرکت اسپاد نوآوران اسپادان (فروشگاه آنلاین اسپاد) می‌باشد</p>
        </footer>
    </div>

    @Scripts.Render("~/bundles/jquery")
    @Scripts.Render("~/bundles/bootstrap")
    @RenderSection("scripts", required:=False)
</body>
</html>
