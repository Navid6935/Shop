﻿<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>@ViewBag.Title - SpadWear</title>
    @Styles.Render("~/Content/css")
    @Scripts.Render("~/bundles/modernizr")
    <style>
        .btn-success
        {
            background-color:#fff;
            color:#5cb85c;
        }
    </style>
</head>

<body>
    <div class="navbar navbar-inverse navbar-fixed-top" style="background-color:white;border-bottom-color:#e6e4e4;box-shadow:0 2px 4px 0 rgba(0,0,0,.1)">
        <div class="container-fluid">
            <div class="navbar-collapse collapse">
                <span>
                </span>
                <span class="pull-left">
                    <ul class="nav navbar-nav hidden-xs" style="color:#9d9d9d">
                        <il>
                            @Html.Partial("_LoginPartial")
                        </il>
                    </ul>
                    <ul class="nav navbar-nav hidden-xs" style="margin-top:15px;color:#9d9d9d">
                        <il style="        font-size: 30px
">
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
                <button type="button" class="navbar-toggle" style="background-color:black" data-toggle="collapse" data-target=".navbar-collapse">
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
    <div class="container-fluid">
        <div class="row"  style="margin-top:80px">
            <div class="col-lg-8 col-lg-pull-2">
                <div id="PerchaseCarouel" class="carousel slide " data-ride="carousel" data-pause="true" data-interval="3000">
                    <ol class="carousel-indicators">
                        <li data-target="#PerchaseCarouel" data-slide-to="0" class="active"></li>
                        <li data-target="#PerchaseCarouel" data-slide-to="1"></li>
                        <li data-target="#PerchaseCarouel" data-slide-to="2"></li>
                        @*<li data-target="#PerchaseCarouel" data-slide-to="3"></li>
                        <li data-target="#PerchaseCarouel" data-slide-to="4"></li>*@
                    </ol>
                    <div class="carousel-inner">
                        <div class="item active">
                            <img class="img-rounded rounded-left rounded-lg" src="~/Images/1.jpg" alt="" style="display:block;width:100%" />
                            @*کپشن در هر کروسل*@
                            <div class="carousel-caption hidden-sm hidden-xs">
                                <h5>مدل اسپاد 1</h5>
                                <p>استفاده از پارچه نخ پنبه</p>
                            </div>
                        </div>
                        <div class="item">
                            <img src="~/Images/2.jpg" alt="" style="display:block;width:100%;height:50% !important" />
                            @*کپشن در هر کروسل*@
                        <div class="carousel-caption hidden-sm hidden-xs">
                            <h5>مدل اسپاد 2</h5>
                            <p>استفاده از پارچه نخ پنبه</p>
                        </div>
                        </div>
                        <div class="item">
                            <img src="~/Images/3.jpg" alt="" style="display:block" />
                            @*کپشن در هر کروسل*@
                        <div class="carousel-caption hidden-sm hidden-xs">
                            <h5>مدل اسپاد 3</h5>
                            <p>استفاده از پارچه نخ پنبه</p>
                        </div>
                        </div>

                    </div>
                    <a class="left carousel-control" href="#PerchaseCarouel" data-slide="prev">
                        <span class="glyphicon glyphicon-chevron-left"></span>
                        <span class="sr-only">Previous</span>
                    </a>
                    <a class="right carousel-control" href="#PerchaseCarouel" data-slide="next">
                        <span class="glyphicon glyphicon-chevron-right"></span>
                        <span class="sr-only">Next</span>
                    </a>
                </div>
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

    </script>
</body>
</html>
