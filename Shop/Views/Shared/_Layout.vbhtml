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
    <div class="navbar navbar-inverse navbar-fixed-top" style="background-color:white">
        <div class="container">
            <div class="navbar-collapse collapse">
                <span>
                </span>
                <span class="pull-left">
                    <ul class="nav navbar-nav" style="color:#9d9d9d">
                        <il>
                            @Html.Partial("_LoginPartial")
                        </il>
                    </ul>
                    <ul class="nav navbar-nav" style="margin-top:15px;color:#9d9d9d">
                        <il>
                            |
                        </il>
                    </ul>
                    <ul class="nav navbar-nav" style="margin-top:15px;margin-right:5px;color:#9d9d9d">
                        <il>
                            سبد خرید
                        </il>
                    </ul>
                </span>
                @Html.ActionLink("SpadWear", "Index", "Home", New With {.area = ""}, New With {.class = "navbar-brand"})

            </div>
            <hr style="margin-top:0px"/>
            @*<div class="navbar-collapse collapse">
                <h6 class="pull-left">
                </h6>
            </div>*@
            </div>
        <div class="container">
            <div class="navbar-header">
                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>

            </div>
            <div class="navbar-collapse collapse pull-right">

                <ul class="nav navbar-nav">
                    <li>@Html.ActionLink("صفحه اصلی", "Index", "Home")</li>
                    <li>@Html.ActionLink("درباره ما", "About", "Home")</li>
                    <li>@Html.ActionLink("تماس با ما", "Contact", "Home")</li>
                </ul>
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
