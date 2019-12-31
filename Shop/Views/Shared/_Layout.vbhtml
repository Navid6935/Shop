﻿<!DOCTYPE html>
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
        <div class="container-fluid">
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
                        <il style="font-size:30px">
                            |
                        </il>
                    </ul>
                    <ul class="nav navbar-nav" style="margin-top:15px;margin-right:5px;color:#9d9d9d">
                        <il>
                            <button class="btn btn-success">سبد خرید <i class="glyphicon glyphicon-shopping-cart"></i></button>
                        </il>
                    </ul>
                </span>
                @Html.ActionLink("SpadWear", "Index", "Home", New With {.area = ""}, New With {.class = "navbar-brand"})

            </div>
            <hr style="margin-top:0px;margin-bottom:0px;border-top: 1px solid #9d9d9d;"/>
            @*<div class="navbar-collapse collapse">
                <h6 class="pull-left">
                </h6>
            </div>*@
            </div>
        <div class="container-fluid">
            <div class="navbar-header">
                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>

            </div>
            <div class="navbar-collapse collapse pull-right">

                <ul class="nav navbar-nav"l>
                    <li id="MainPage" class="TopMenu">@Html.ActionLink("صفحه اصلی", "Index", "Home")</li>
                    <li id="Products" class="dropdown">
                        <a href="#" class="dropdown-toggle" data-toggle="dropdown" role="button" aria-haspopup="true" aria-expanded="true">محصولات<span class="caret"></span></a>
                        <ul class="dropdown-menu">
                            <li><a href="#">Action</a></li>
                            <li><a href="#">Another action</a></li>
                            <li><a href="#">Something else here</a></li>
                            <li role="separator" class="divider"></li>
                            <li class="dropdown-header">Nav header</li>
                            <li><a href="#">Separated link</a></li>
                            <li><a href="#">One more separated link</a></li>
                        </ul>

                <li id="Products">@Html.ActionLink("درباره ما", "About", "Home")</li>
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
    <script>
        $('.dropdown-toggle').click(function(e) {
          if ($(document).width() > 768) {
            e.preventDefault();

            var url = $(this).attr('href');

       
            if (url !== '#') {
    
              window.location.href = url;
            }

  }
        });
    //    $(".TopMenu").mouseover(function () {
    //        $(this).animate({
    //    width:"2px"
    //}, 500 );
        })
    </script>
</body>
</html>
